using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceAndDesktop
{
    public partial class MainForm : Form
    {
        private CoreModule core = new CoreModule();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateUI(bool start)
        {
            btnStart.Enabled = !start;
            btnStop.Enabled = start;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            core.Start();
            UpdateUI(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            core.Stop();
            UpdateUI(false);
        }
    }
}
