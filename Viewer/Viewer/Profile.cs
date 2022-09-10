using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Viewer
{
    public struct LanguageProfile
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
            //Create output with header
            string output = $"{header}\n";

            foreach (var k in dict)
            {
                //Get type (name) and rating
                var type = k.Key;
                var rating = k.Value;

                //Convert rating to correct symbol
                var ratingStr = EmojiPairs[rating];

                //Add to output
                output += $"{ratingStr} {type}\n";
            }

            return output;
        }
    }

    public struct GlobalProfile
    {
        public string username;
        public string avatar;
        public Dictionary<string, LanguageProfile> profiles;
    }

    public partial class Profile : System.Windows.Forms.Form
    {
        const string userFetch = "https://en.pronouns.page/api/profile/get/";
        WebClient client;

        GlobalProfile globalProfile = new GlobalProfile();
        LanguageProfile primaryProfile = new LanguageProfile();

        public Profile()
        {
            InitializeComponent();

            //Initialize WebClient
            client = new WebClient();
        }

        private Dictionary<string, int> ParseNounPronouns(Dictionary<string, int> dict)
        {
            //Create copy of dictionary 
            var copy = new Dictionary<string, int>();

            //Loop through dictionary and parse noun pronouns
            foreach (var pron in dict)
            {
                var preparse = pron.Key;
                var rating = pron.Value;

                //Guard clause, just so we don't mess with other kinds of pronouns
                if (!preparse.StartsWith(":")) { copy.Add(preparse, rating); continue; }

                //Format noun pronouns
                var substr = preparse.Substring(1);
                var finalPronoun = $"{substr}/{substr}'s";

                copy.Add(finalPronoun, rating);
            }

            return copy;
        }

        public bool FetchUser(string jsonPath, Image pfp = null)
        {
            //Disable save profile button
            saveProfile.Hide();

            //Let JsonConvert do the dirty work of converting to the Profile Struct for us.
            try
            {
                string json = File.ReadAllText(jsonPath);
                globalProfile = JsonConvert.DeserializeObject<GlobalProfile>(json);
            } catch
            {
                MessageBox.Show("User data invalid!");
                return false;
            }

            //-- USERNAME --
            //Get Username from global profile and put it into the username label
            username.Text = globalProfile.username;

            //-- FORM TITLE --
            //Set form title with username (e.g.: A user with the username of "jai_" would get: "jai_ - pronouns.page (LOCAL SAVE)" for the form title.
            Text = $"{globalProfile.username} - pronouns.page (LOCAL SAVE)";

            //-- PROFILE PICTURE --
            if(pfp != null)
                profilePicture.Image = pfp;

            //-- PRIMARY LANGUAGE PROFILE --
            //Get the profile with the primary language of the user (usually English)
            try
            {
                primaryProfile = globalProfile.profiles.First().Value;
            }
            catch
            {
                MessageBox.Show("No User found!");
                return false;
            }

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

            return true;
        }

        public bool FetchUser(string user)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please input a username!");
                return false;
            }

            //-- SETUP --
            string userFetchFull = userFetch + user;

            //-- JSON GETTING & PARSING --
            //Get JSON from pronouns.page API
            string json = client.DownloadString(userFetchFull);

            //Let JsonConvert do the dirty work of converting to the Profile Struct for us.
            globalProfile = JsonConvert.DeserializeObject<GlobalProfile>(json);

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
                profilePicture.Image = ImageUtils.ToImage(pfp);
            }
            catch { /* Profile Picture doesn't exist. Just keep default. */ }

            //-- PRIMARY LANGUAGE PROFILE --
            //Get the profile with the primary language of the user (usually English)
            try
            {
                primaryProfile = globalProfile.profiles.First().Value;
            }
            catch
            {
                MessageBox.Show("No User found!");
                return false;
            }

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

            return true;
        }

        private void saveProfile_Click(object sender, EventArgs e)
        {
            HomeMenu.SaveProfile(globalProfile, profilePicture.Image);
        }
    }
}
