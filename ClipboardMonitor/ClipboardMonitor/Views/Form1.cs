using ClipboardMonitor.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipboardMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtStartMonitor_Click(object sender, EventArgs e)
        {
            if (TmMonitor.Enabled)
            {
                TmMonitor.Enabled = false;
                ((Button)sender).Text = "监视：" + TmMonitor.Enabled;
            }
            else
            {
                TmMonitor.Interval = 1000;
                TmMonitor.Enabled = true;
                ((Button)sender).Text = "监视：" + TmMonitor.Enabled;
            }
        }

        private void TmMonitor_Tick(object sender, EventArgs e)
        {
            string content = ClipboardHelper.GetText();
            TbClipboardContent.Text = content;
        }
    }
}
