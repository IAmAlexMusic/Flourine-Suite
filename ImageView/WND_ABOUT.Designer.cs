namespace ImageView
{
    partial class WND_ABOUT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WND_ABOUT));
            this.label1 = new System.Windows.Forms.Label();
            this.TEXT_EDITION = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BUTTON_CLOSE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // TEXT_EDITION
            // 
            resources.ApplyResources(this.TEXT_EDITION, "TEXT_EDITION");
            this.TEXT_EDITION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TEXT_EDITION.Name = "TEXT_EDITION";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(228)))));
            this.label3.Name = "label3";
            // 
            // BUTTON_CLOSE
            // 
            this.BUTTON_CLOSE.FlatAppearance.BorderSize = 0;
            this.BUTTON_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.BUTTON_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BUTTON_CLOSE, "BUTTON_CLOSE");
            this.BUTTON_CLOSE.Name = "BUTTON_CLOSE";
            this.BUTTON_CLOSE.UseVisualStyleBackColor = true;
            this.BUTTON_CLOSE.Click += new System.EventHandler(this.BUTTON_CLOSE_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Name = "label4";
            // 
            // WND_ABOUT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BUTTON_CLOSE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TEXT_EDITION);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WND_ABOUT";
            this.ShowIcon = false;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label TEXT_EDITION;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BUTTON_CLOSE;
        public System.Windows.Forms.Label label4;
    }
}