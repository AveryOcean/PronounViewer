using Microsoft.Win32;
using System.Drawing;
using System.Windows.Forms;

namespace Viewer
{
    public static class ColorValues
    {
        // - DARK MODE -
        public static Color primaryBackgroundDark = Color.FromArgb(40, 44, 52);
        public static Color primaryAccentDark = Color.FromArgb(69, 76, 90);
        public static Color secondaryAccentDark = Color.FromArgb(146, 161, 191);
        public static Color primaryTextDark = Color.White;
        public static Color secondaryTextDark = Color.FromArgb(27, 30, 36);

        // - LIGHT MODE -
        public static Color primaryBackgroundLight = Color.FromArgb(225, 225, 225);
        public static Color primaryAccentLight = Color.FromArgb(240, 240, 240);
        public static Color secondaryAccentLight = Color.FromArgb(225, 225, 225);
        public static Color primaryTextLight = Color.Black;
        public static Color secondaryTextLight = Color.Black;

        // - AUTOMATIC SELECTION -
        public static Color primaryBackground
        {
            get => IsSystemDark ? primaryBackgroundDark : primaryBackgroundLight;
        }
        public static Color primaryAccent
        {
            get => IsSystemDark ? primaryAccentDark : primaryAccentLight;
        }
        public static Color secondaryAccent
        {
            get => IsSystemDark ? secondaryAccentDark : secondaryAccentLight;
        }
        public static Color primaryText
        {
            get => IsSystemDark ? primaryTextDark : primaryTextLight;
        }
        public static Color secondaryText
        {
            get => IsSystemDark ? secondaryTextDark : secondaryTextLight;
        }

        // - BOOLS -
        private static bool? _isSystemDark = null;
        public static bool IsSystemDark
        {
            get
            {
                if (_isSystemDark == null)
                {
                    int result = (int)HomeMenu.softwareKey.GetValue(HomeMenu.REGISTRY_THEME_TOGGLE, -1);
                    _isSystemDark = result == 0;
                }

                return (bool)_isSystemDark;
            }
            set
            {
                _isSystemDark = value;
            }
        }
    }
}
