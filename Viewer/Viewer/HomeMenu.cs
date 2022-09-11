using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Viewer
{
    public partial class HomeMenu : Form
    {
        static HomeMenu Instance;

        public static RegistryKey softwareKey;
        public const string REGISTRY_PROFILE_SAVE_PATH = "ProfileSaveLocation";
        
        public HomeMenu()
        {
            InitializeComponent();
            softwareKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\AveryOcean\PronounViewer");
            Instance = this;
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
            var savePath = (string)softwareKey.GetValue(REGISTRY_PROFILE_SAVE_PATH);
            var pfpLocation = Path.Combine(savePath, $"{global.username}-pfp.png");
            var globalJsonLocation = Path.Combine(savePath, $"{global.username}.json");

            var imgBytes = ImageUtils.ImageToByteArray(profilePicture);

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
            var files = Directory.GetFiles(dir);

            //Get each JSON and PNG files split up
            foreach (var f in files)
            {
                if (f.EndsWith(".json")) jsonFiles.Add(f);
            }

            //Create List View Items for each JSON
            foreach (var f in jsonFiles)
            {
                var trimEnd = f.Substring(0, f.Length - 5);
                var backslashIndex = trimEnd.LastIndexOf('\\');
                var trimStart = trimEnd.Substring(backslashIndex + 1);

                var listItem = new ListViewItem(trimStart);
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
            string jsonFile = $"{Path.Combine(dir, item.Text + ".json")}";

            int index = jsonFiles.IndexOf(jsonFile);

            string jsonPfp = jsonFiles[index].Substring(0, jsonFiles[index].Length - 5) + "-pfp.png";
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
