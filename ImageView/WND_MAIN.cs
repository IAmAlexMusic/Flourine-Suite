using System;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using ExifLib;

namespace ImageView
{
    public partial class WND_MAIN : Form
    {
        public bool isImageOpen = false;
        public FileInfoManager fileManager;
        public Thread _splashThread = new Thread(new ThreadStart(ShowSplashScreen));
        public static void ShowSplashScreen()
        {
            try
            {
                new WND_SPLASH().ShowDialog();

            }
            catch (Exception)
            {
                Console.WriteLine("Unable to Load SplashScreen. NONFATAL:0");
            }
        }
        private void RunFinalStartupTasks(object sender, EventArgs e)
        {
            _splashThread.Abort();
            this.WindowState = FormWindowState.Maximized;
        }
        public WND_MAIN()
        {
            _splashThread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPEN_IMAGE_FILE_DIALOG.FileOk += OPEN_IMAGE_FILE_DIALOG_FileOk;
            OPEN_IMAGE_FILE_DIALOG.ShowDialog();
        }
        private void OPEN_IMAGE_FILE_DIALOG_FileOk(object sender, CancelEventArgs e)
        {
            var img = Image.FromFile($"{OPEN_IMAGE_FILE_DIALOG.FileName}");
            this.Text = $"ImageView | <{OPEN_IMAGE_FILE_DIALOG.FileName}>";
            PROPERTIES_NAME.Text = $"Name: {OPEN_IMAGE_FILE_DIALOG.SafeFileName}";
            PROPERTIES_SIZE_KBYTES.Text = $"Size (KB): {(new FileInfo(OPEN_IMAGE_FILE_DIALOG.FileName).Length / 1024)}KB";
            PROPERTIES_SIZE_BYTES.Text = $"Size: {(new FileInfo(OPEN_IMAGE_FILE_DIALOG.FileName).Length)}B";
            IMAGE_VIEW.Image = new Bitmap(OPEN_IMAGE_FILE_DIALOG.FileName);
            PROPERTIES_RESOLUTION.Text = $"Resolution (HxW): {img.Width}x{img.Height}";
            GetImageDate(OPEN_IMAGE_FILE_DIALOG.FileName);
            isImageOpen = true;
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void exportAsIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpen)
            {
                if (CHOOSE_DIRECTORY_DIALOG.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine(CHOOSE_DIRECTORY_DIALOG.SelectedPath);
                    libexport.Entrypoint.ExportAsIcon(CHOOSE_DIRECTORY_DIALOG.SelectedPath + @"\", OPEN_IMAGE_FILE_DIALOG.FileName, IMAGE_VIEW.Image);
                }
            }
        }

        private void exportAsPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpen)
            {
                if (CHOOSE_DIRECTORY_DIALOG.ShowDialog() == DialogResult.OK)
                {
                    libexport.Entrypoint.ExportAsPNG(CHOOSE_DIRECTORY_DIALOG.SelectedPath + @"\", OPEN_IMAGE_FILE_DIALOG.FileName, IMAGE_VIEW.Image);
                }
            }
        }

        private void exportAsJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpen)
            {
                if (CHOOSE_DIRECTORY_DIALOG.ShowDialog() == DialogResult.OK)
                {
                    libexport.Entrypoint.ExportAsJPG(CHOOSE_DIRECTORY_DIALOG.SelectedPath + @"\", OPEN_IMAGE_FILE_DIALOG.FileName, IMAGE_VIEW.Image);
                }
            }
        }

        private void exportAsGIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpen)
            {
                if (CHOOSE_DIRECTORY_DIALOG.ShowDialog() == DialogResult.OK)
                {
                    libexport.Entrypoint.ExportAsGIF(CHOOSE_DIRECTORY_DIALOG.SelectedPath + @"\", OPEN_IMAGE_FILE_DIALOG.FileName, IMAGE_VIEW.Image);
                }
            }
        }

        private void exportAsTIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isImageOpen)
            {
                if (CHOOSE_DIRECTORY_DIALOG.ShowDialog() == DialogResult.OK)
                {
                    libexport.Entrypoint.ExportAsTIFF(CHOOSE_DIRECTORY_DIALOG.SelectedPath + @"\", OPEN_IMAGE_FILE_DIALOG.FileName, IMAGE_VIEW.Image);
                }
            }
        }

        private void aboutImageViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new WND_ABOUT().ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Start of Update Process
            //
            //There is no server go get the latest content yet, so the check for Updates Button will be hidden.
        }
        public void GetImageDate(string ImageLocation)
        {
            try
            {
                using (ExifReader reader = new ExifReader(ImageLocation))
                {
                    DateTime dateImageTaken;
                    if (reader.GetTagValue<DateTime>(ExifTags.DateTimeDigitized, out dateImageTaken))
                    {
                        PROPERTIES_DATETIME.Text = $"Date: {dateImageTaken.ToString()}";
                    }
                }
            }
            catch (Exception)
            {
                PROPERTIES_DATETIME.Text = "Date: N/A";
            }
        }
    }
}
