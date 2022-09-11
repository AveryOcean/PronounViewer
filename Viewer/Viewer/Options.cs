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
        }

        private void UpdateLabel()
        {
            profileSaveLocLabel.Text = $"Current Location: {HomeMenu.softwareKey.GetValue(HomeMenu.REGISTRY_PROFILE_SAVE_PATH)}";
        }

        private void changeSaveLoc_Click(object sender, EventArgs e)
        {
            HomeMenu.ChangeSaveLocation();
            UpdateLabel();
        }
    }
}
