using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Viewer.Properties;

namespace Viewer
{
    public partial class HomeMenu : Form
    {
        static HomeMenu Instance;

        public static RegistryKey softwareKey;
        public const string REGISTRY_PROFILE_SAVE_PATH = "ProfileSaveLocation";
        public const string FOLDER_NAME_SUFFIX = "-profile";

        public static Image DefaultImage;

        public HomeMenu()
        {
            InitializeComponent();
            softwareKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AveryOcean\PronounViewer");
            Instance = this;

            DefaultImage = Resources.Default_Profile;
        }

        private void getUserOnline_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            var success = profile.FetchUser(username.Text);
            if (!success) return;

            profile.Show();
        }

        List<string> jsonFiles = new List<string>();
        public static void SaveProfile(GlobalProfile global, Image profilePicture)
        {
            var usernameFolder = global.username + FOLDER_NAME_SUFFIX;
            var savePath = (string)softwareKey.GetValue(REGISTRY_PROFILE_SAVE_PATH);
            var pfpLocation = Path.Combine(savePath, $"{usernameFolder}\\profile.png");
            var globalJsonLocation = Path.Combine(savePath, $"{usernameFolder}\\data.json");

            var imgBytes = ImageUtils.ImageToByteArray(profilePicture, DefaultImage);

            Directory.CreateDirectory(Path.Combine(savePath, usernameFolder));
            using(var fs = File.Create(pfpLocation))
            {
                fs.Write(imgBytes, 0, imgBytes.Length);
            }

            using(var fs = File.Create(globalJsonLocation))
            {
                var json = JsonConvert.SerializeObject(global);

                var bytes = Encoding.UTF8.GetBytes(json);
                fs.Write(bytes, 0, bytes.Length);
            }

            Instance.LoadJsonFiles();
        }

        public void LoadJsonFiles()
        {
            savedProfiles.Clear();
            jsonFiles = new List<string>();

            //Get files in save directory 
            var dir = (string)softwareKey.GetValue(REGISTRY_PROFILE_SAVE_PATH);
            var allDirectories = Directory.GetDirectories(dir);

            //Filter profiles
            List<string> filteredDirectories = new List<string>();
            foreach (var item in allDirectories)
            {
                if (!item.EndsWith("profile")) continue;
                filteredDirectories.Add(item);
            }

            //Create List Ite
            //m for each JSON in each directory
            foreach (var item in filteredDirectories)
            {
                //Files
                var jsonFile = Path.Combine(item, "data.json");
                jsonFiles.Add(jsonFile);
                
                //Trim
                var backslashIndex = item.LastIndexOf('\\');
                var trimStart = item.Substring(backslashIndex + 1);
                var profileIndex = trimStart.LastIndexOf(FOLDER_NAME_SUFFIX);
                var trimEnd = trimStart.Substring(0, profileIndex);

                //Create List Item
                var listItem = new ListViewItem(trimEnd);
                savedProfiles.Items.Add(listItem);
            }
        }

        public static bool ChangeSaveLocation(bool showMessage = false)
        {
            if(showMessage)
                MessageBox.Show("Please set a directory for us to store your saved profiles in.", "Directory Required!");

            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    softwareKey.SetValue(REGISTRY_PROFILE_SAVE_PATH, fbd.SelectedPath);
                    return true;
                }
            }

            return false;
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            if (softwareKey.GetValue(REGISTRY_PROFILE_SAVE_PATH) == null)
            {
                if (ChangeSaveLocation(true))
                    Activate();
                else
                    Close();
            }

            LoadJsonFiles();
        }


        private void savedProfiles_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            try
            {
                item = savedProfiles.SelectedItems[0];
            } catch
            {
                return;
            }

            string dir = (string)softwareKey.GetValue(REGISTRY_PROFILE_SAVE_PATH);
            string jsonFile = $"{Path.Combine(dir, $"{item.Text}{FOLDER_NAME_SUFFIX}\\data.json")}";

            int index = jsonFiles.IndexOf(jsonFile);

            string jsonPfp = jsonFiles[index].Substring(0, jsonFiles[index].Length - 9) + "profile.png";
            Image pfp = null;

            if(File.Exists(jsonPfp))
            {
                byte[] pfpRead = File.ReadAllBytes(jsonPfp);
                pfp = ImageUtils.ToImage(pfpRead);
            }

            Profile profile = new Profile();
            bool success = profile.FetchUser(jsonFile, pfp);
            
            if(success)
                profile.Show();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            LoadJsonFiles();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }
    }
}
