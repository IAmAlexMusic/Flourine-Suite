using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace libexport
{
    public class Entrypoint
    {
        public static void ExportAsIcon(string directory, string Location, Image Source)
        {
            try
            {
                string NewLocation = Path.GetFileNameWithoutExtension(Location);
                NewLocation = directory + NewLocation + ".ico";
                Source.Save(NewLocation, ImageFormat.Icon);
                MessageBox.Show("ICO File has been exported.", "Export Complete | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("ICO File could not be exported.", "Export Error | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                
            }
        }
        public static void ExportAsPNG(string directory, string Location, Image Source)
        {
            try
            {
                string NewLocation = Path.GetFileNameWithoutExtension(Location);
                NewLocation = directory + NewLocation + ".png";
                Source.Save(NewLocation, ImageFormat.Png);
                MessageBox.Show("PNG File has been exported.", "Export Complete | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("PNG File could not be exported.", "Export Error | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public static void ExportAsJPG(string directory, string Location, Image Source)
        {
            try
            {
                string NewLocation = Path.GetFileNameWithoutExtension(Location);
                NewLocation = directory + NewLocation + ".jpg";
                Source.Save(NewLocation, ImageFormat.Jpeg);
                MessageBox.Show("JPG File has been exported.", "Export Complete | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("JPG File could not be exported.", "Export Error | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public static void ExportAsGIF(string directory, string Location, Image Source)
        {
            try
            {
                string NewLocation = Path.GetFileNameWithoutExtension(Location);
                NewLocation = directory + NewLocation + ".gif";
                Source.Save(NewLocation, ImageFormat.Gif);
                MessageBox.Show("GIF File has been exported.", "Export Complete | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("ICO File could not be exported.", "Export Error | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        public static void ExportAsTIFF(string directory, string Location, Image Source)
        {
            try
            {
                string NewLocation = Path.GetFileNameWithoutExtension(Location);
                NewLocation = directory + NewLocation + ".tiff";
                Source.Save(NewLocation, ImageFormat.Tiff);
                MessageBox.Show("TIFF File has been exported.", "Export Complete | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception)
            {
                MessageBox.Show("ICO File could not be exported.", "Export Error | ImageView", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
