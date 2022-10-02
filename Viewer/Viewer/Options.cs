using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            UpdateLabel();
            InitializeColors();
        }

        private bool _initializing = true;
        private void UpdateLabel()
        {
            profileSaveLocLabel.Text = $"Current Location: {HomeMenu.softwareKey.GetValue(HomeMenu.REGISTRY_PROFILE_SAVE_PATH)}";
            var result = (int)HomeMenu.softwareKey.GetValue(HomeMenu.REGISTRY_THEME_TOGGLE, -1);
            
            useLightTheme.Checked = IntToBool(result);
            _initializing = false;
        }

        private void changeSaveLoc_Click(object sender, EventArgs e)
        {
            HomeMenu.ChangeSaveLocation();
            UpdateLabel();
        }

        private void InitializeColors()
        {
            BackColor = ColorValues.primaryBackground;

            label1.ForeColor = ColorValues.primaryText;
            label2.ForeColor = ColorValues.primaryText;

            profileSaveLocLabel.ForeColor = ColorValues.primaryText;

            changeSaveLoc.BackColor = ColorValues.secondaryAccent;
            changeSaveLoc.ForeColor = ColorValues.secondaryText;

            useLightTheme.ForeColor = ColorValues.primaryText;
        }

        private void useLightTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (_initializing) return;

            var softwareKey = HomeMenu.softwareKey;
            var lightThemeKey = HomeMenu.REGISTRY_THEME_TOGGLE;

            softwareKey.SetValue(lightThemeKey, BoolToInt(useLightTheme.Checked));
            MessageBox.Show("Theme preference updated. Please restart the app for the full theme to take effect.");
        }

        private int BoolToInt(bool b)
            => b ? 1 : 0;

        private bool IntToBool(int i)
            => i != 0 ? true : false;

    }
}
