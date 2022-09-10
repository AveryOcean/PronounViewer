using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;

namespace Viewer
{
    struct LanguageProfile
    {
        public Dictionary<string, int> names;
        public Dictionary<string, int> pronouns;
        public string? description;
        public int? age;

        private static Dictionary<int, string> EmojiPairs = new Dictionary<int, string>
        {
            { -1, "👎" },
            { 0, "👍" },
            { 1, "♥" },
            { 2, "😛" }, //BLEHHH :p I'm not gonna do that, you can't make me!!!!!!
            { 3, "💑" },
        };

        public static string SerializeDictionary(Dictionary<string, int> dict, string header = "")
        {
            string output = $"{header}\n";
            foreach (var k in dict)
            {
                var type = k.Key;
                var rating = k.Value;

                var ratingStr = EmojiPairs[rating];
                output += $"{ratingStr} {type}\n";
            }

            return output;
        }
    }

    struct GlobalProfile
    {
        public string username;
        public string avatar;
        public Dictionary<string, LanguageProfile> profiles;
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

        private Dictionary<string, int> ParseNounPronouns(Dictionary<string, int> dict)
        {
            var copy = new Dictionary<string, int>();
            foreach (var pron in dict)
            {
                var preparse = pron.Key;
                var rating = pron.Value;

                if (!preparse.StartsWith(":")) { copy.Add(preparse, rating); continue; }
                var substr = preparse.Substring(1);
                var finalPronoun = $"{substr}/{substr}'s";

                copy.Add(finalPronoun, rating);
            }

            return copy;
        }

        private void demoFetch_Click(object sender, EventArgs e)
        {
            //-- SETUP --
            string user = "jai_";
            string userFetchFull = userFetch + user;

            //-- JSON GETTING & PARSING --
            //Get JSON from pronouns.page API
            string json = client.DownloadString(userFetchFull);

            //Let JsonConvert do the dirty work of converting to the Profile Struct for us.
            GlobalProfile globalProfile = JsonConvert.DeserializeObject<GlobalProfile>(json);

            //-- USERNAME --
            //Get Username from global profile and put it into the username label
            username.Text = globalProfile.username;

            //-- FORM TITLE --
            //Set form title with username (e.g.: A user with the username of "jai_" would get: "jai_ - pronouns.page" for the form title.
            Text = $"{globalProfile.username} - pronouns.page";

            //-- PROFILE PICTURE --
            try
            {
                //Download profile picture from data
                var pfp = client.DownloadData(globalProfile.avatar);
                
                //Parse byte data to the image and insert into picture box
                profilePicture.Image = ToImage(pfp);
            } catch { /* Profile Picture doesn't exist. Just keep default. */ }

            //-- PRIMARY LANGUAGE PROFILE --
            //Get the profile with the primary language of the user (usually English)
            LanguageProfile primaryProfile = globalProfile.profiles.First().Value;

            //-- AGE --
            //Get age from language profile, convert to string and insert into age label
            age.Text = primaryProfile.age.ToString();

            //-- NAMES --
            //Get list of names, serialize into proper formatting with ratings
            var serializedNames = LanguageProfile.SerializeDictionary(primaryProfile.names, "Names:");
            
            //Insert names into label for names
            names.Text = serializedNames;

            //-- PRONOUNS --
            //Parse any potential noun pronouns that could exist like "kit/kit's" (example from @jai_)
            var parsedPronouns = ParseNounPronouns(primaryProfile.pronouns);

            //Parse pronouns and rating into string
            var serializedPronouns = LanguageProfile.SerializeDictionary(parsedPronouns, "Pronouns:");
            
            //Display parsed stirng in pronouns textbox
            pronouns.Text = serializedPronouns;
        }
    }
}
