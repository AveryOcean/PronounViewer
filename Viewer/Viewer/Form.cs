using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;

namespace Viewer
{
    struct Profile
    {
        public Dictionary<string, int> names;
        public Dictionary<string, int> pronouns;
        public string? description;
        public int? age;

        public static string SerializeDictionary(Dictionary<string, int> dict)
        {
            /*
                Emojis for Dislike, Like, Yes, Jokingly and Only If We're Close
                👎 [-1] 
                👍 [0]
                ♥ [1] 
                😛 [2]
                💑 [3]
             */

            //TODO: Clean up this code
            string output = "";
            foreach(var item in dict)
            {
                var name = item.Key;
                var rating = item.Value;

                output += $"{name}: ";
                switch(rating)
                {
                    case -1:
                        output += "👎";
                        break;
                    case 0:
                        output += "👍";
                        break;
                    case 1:
                        output += "♥";
                        break;
                    case 2:
                        output += "😛";
                        break;
                    case 3:
                        output += "💑";
                        break;
                    default:
                        output += $"?";
                        break;
                }
                output += $"\n";
            }

            return output;
        }
    }

    struct UserProfile
    {
        public string username;
        public string avatar;
        public Dictionary<string, Profile> profiles;
    }

    public partial class Form : System.Windows.Forms.Form
    {
        const string userFetch = "https://en.pronouns.page/api/profile/get/";
        WebClient client;

        public Form()
        {
            InitializeComponent();
            client = new WebClient();
        }

        public Image ToImage(byte[] b)
        {
            using (var ms = new MemoryStream(b))
            {
                return Image.FromStream(ms);
            }
        }

        private void demoFetch_Click(object sender, EventArgs e)
        {
            string user = "opabinasveryno";
            string userFetchFull = userFetch + user;

            string json = client.DownloadString(userFetchFull);
            UserProfile profile = JsonConvert.DeserializeObject<UserProfile>(json);

            //Show username
            username.Text = profile.username;

            //Change Form Title
            Text = $"{profile.username} - pronouns.page";

            //Fetch profile picture
            try
            {
                var pfp = client.DownloadData(profile.avatar);
                profilePicture.Image = ToImage(pfp);
            } catch { }

            //Get first profile
            Profile primaryProfile = profile.profiles.First().Value;

            //Get age
            age.Text = primaryProfile.age.ToString();

            //Get names
            var serializedNames = "Names:\n" + Profile.SerializeDictionary(primaryProfile.names);
            names.Text = serializedNames;

            //Get pronouns
            var serializedPronouns = "Pronouns:\n" + Profile.SerializeDictionary(primaryProfile.pronouns);
            pronouns.Text = serializedPronouns;
        }
    }
}
