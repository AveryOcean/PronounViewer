using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Viewer
{
    internal class ImageUtils
    {
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn, System.Drawing.Image defaultImage)
        {
            using (var ms = new MemoryStream())
            {
                try
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                } catch
                {
                    MessageBox.Show("Image loading failed! Using default image.");
                    defaultImage.Save(ms, defaultImage.RawFormat);
                }

                return ms.ToArray();
            }
        }

        public static Image ToImage(byte[] b)
        {
            //Create memory stream
            using (var ms = new MemoryStream(b))
            {
                //Get image from stream
                return Image.FromStream(ms);
            }
        }
    }
}
