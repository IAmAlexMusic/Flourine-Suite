using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageView
{
    public partial class WND_ABOUT : Form
    {
        public WND_ABOUT()
        {
            InitializeComponent();
        }

        private void BUTTON_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
