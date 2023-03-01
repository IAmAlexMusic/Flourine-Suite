namespace ImageView
{
    partial class WND_MAIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WND_MAIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PROPERTIES_RESOLUTION = new System.Windows.Forms.Label();
            this.PROPERTIES_SIZE_KBYTES = new System.Windows.Forms.Label();
            this.PROPERTIES_SIZE_BYTES = new System.Windows.Forms.Label();
            this.PROPERTIES_NAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IMAGE_VIEW = new System.Windows.Forms.PictureBox();
            this.MASTER_MENU = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPEN_IMAGE_FILE_DIALOG = new System.Windows.Forms.OpenFileDialog();
            this.SAVE_IMAGE_FILE_DIALOG = new System.Windows.Forms.SaveFileDialog();
            this.exportAsIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsGIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsTIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CHOOSE_DIRECTORY_DIALOG = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_VIEW)).BeginInit();
            this.MASTER_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PROPERTIES_RESOLUTION);
            this.panel1.Controls.Add(this.PROPERTIES_SIZE_KBYTES);
            this.panel1.Controls.Add(this.PROPERTIES_SIZE_BYTES);
            this.panel1.Controls.Add(this.PROPERTIES_NAME);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // PROPERTIES_RESOLUTION
            // 
            resources.ApplyResources(this.PROPERTIES_RESOLUTION, "PROPERTIES_RESOLUTION");
            this.PROPERTIES_RESOLUTION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROPERTIES_RESOLUTION.Name = "PROPERTIES_RESOLUTION";
            // 
            // PROPERTIES_SIZE_KBYTES
            // 
            resources.ApplyResources(this.PROPERTIES_SIZE_KBYTES, "PROPERTIES_SIZE_KBYTES");
            this.PROPERTIES_SIZE_KBYTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROPERTIES_SIZE_KBYTES.Name = "PROPERTIES_SIZE_KBYTES";
            // 
            // PROPERTIES_SIZE_BYTES
            // 
            resources.ApplyResources(this.PROPERTIES_SIZE_BYTES, "PROPERTIES_SIZE_BYTES");
            this.PROPERTIES_SIZE_BYTES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROPERTIES_SIZE_BYTES.Name = "PROPERTIES_SIZE_BYTES";
            // 
            // PROPERTIES_NAME
            // 
            resources.ApplyResources(this.PROPERTIES_NAME, "PROPERTIES_NAME");
            this.PROPERTIES_NAME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PROPERTIES_NAME.Name = "PROPERTIES_NAME";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // IMAGE_VIEW
            // 
            resources.ApplyResources(this.IMAGE_VIEW, "IMAGE_VIEW");
            this.IMAGE_VIEW.Name = "IMAGE_VIEW";
            this.IMAGE_VIEW.TabStop = false;
            // 
            // MASTER_MENU
            // 
            this.MASTER_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem});
            resources.ApplyResources(this.MASTER_MENU, "MASTER_MENU");
            this.MASTER_MENU.Name = "MASTER_MENU";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            resources.ApplyResources(this.openFileToolStripMenuItem, "openFileToolStripMenuItem");
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsIconToolStripMenuItem,
            this.exportAsPNGToolStripMenuItem,
            this.exportAsJPGToolStripMenuItem,
            this.exportAsGIFToolStripMenuItem,
            this.exportAsTIFFToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            // 
            // OPEN_IMAGE_FILE_DIALOG
            // 
            resources.ApplyResources(this.OPEN_IMAGE_FILE_DIALOG, "OPEN_IMAGE_FILE_DIALOG");
            // 
            // SAVE_IMAGE_FILE_DIALOG
            // 
            this.SAVE_IMAGE_FILE_DIALOG.FileName = "MyImage";
            resources.ApplyResources(this.SAVE_IMAGE_FILE_DIALOG, "SAVE_IMAGE_FILE_DIALOG");
            // 
            // exportAsIconToolStripMenuItem
            // 
            this.exportAsIconToolStripMenuItem.Name = "exportAsIconToolStripMenuItem";
            resources.ApplyResources(this.exportAsIconToolStripMenuItem, "exportAsIconToolStripMenuItem");
            this.exportAsIconToolStripMenuItem.Click += new System.EventHandler(this.exportAsIconToolStripMenuItem_Click);
            // 
            // exportAsPNGToolStripMenuItem
            // 
            this.exportAsPNGToolStripMenuItem.Name = "exportAsPNGToolStripMenuItem";
            resources.ApplyResources(this.exportAsPNGToolStripMenuItem, "exportAsPNGToolStripMenuItem");
            this.exportAsPNGToolStripMenuItem.Click += new System.EventHandler(this.exportAsPNGToolStripMenuItem_Click);
            // 
            // exportAsJPGToolStripMenuItem
            // 
            this.exportAsJPGToolStripMenuItem.Name = "exportAsJPGToolStripMenuItem";
            resources.ApplyResources(this.exportAsJPGToolStripMenuItem, "exportAsJPGToolStripMenuItem");
            this.exportAsJPGToolStripMenuItem.Click += new System.EventHandler(this.exportAsJPGToolStripMenuItem_Click);
            // 
            // exportAsGIFToolStripMenuItem
            // 
            this.exportAsGIFToolStripMenuItem.Name = "exportAsGIFToolStripMenuItem";
            resources.ApplyResources(this.exportAsGIFToolStripMenuItem, "exportAsGIFToolStripMenuItem");
            this.exportAsGIFToolStripMenuItem.Click += new System.EventHandler(this.exportAsGIFToolStripMenuItem_Click);
            // 
            // exportAsTIFFToolStripMenuItem
            // 
            this.exportAsTIFFToolStripMenuItem.Name = "exportAsTIFFToolStripMenuItem";
            resources.ApplyResources(this.exportAsTIFFToolStripMenuItem, "exportAsTIFFToolStripMenuItem");
            this.exportAsTIFFToolStripMenuItem.Click += new System.EventHandler(this.exportAsTIFFToolStripMenuItem_Click);
            // 
            // CHOOSE_DIRECTORY_DIALOG
            // 
            this.CHOOSE_DIRECTORY_DIALOG.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // WND_MAIN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.IMAGE_VIEW);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MASTER_MENU);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.MainMenuStrip = this.MASTER_MENU;
            this.Name = "WND_MAIN";
            this.Shown += new System.EventHandler(this.RunFinalStartupTasks);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE_VIEW)).EndInit();
            this.MASTER_MENU.ResumeLayout(false);
            this.MASTER_MENU.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PROPERTIES_NAME;
        private System.Windows.Forms.PictureBox IMAGE_VIEW;
        private System.Windows.Forms.MenuStrip MASTER_MENU;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OPEN_IMAGE_FILE_DIALOG;
        private System.Windows.Forms.Label PROPERTIES_SIZE_BYTES;
        private System.Windows.Forms.Label PROPERTIES_SIZE_KBYTES;
        private System.Windows.Forms.Label PROPERTIES_RESOLUTION;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SAVE_IMAGE_FILE_DIALOG;
        private System.Windows.Forms.ToolStripMenuItem exportAsIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsJPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsGIFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsTIFFToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog CHOOSE_DIRECTORY_DIALOG;
    }
}