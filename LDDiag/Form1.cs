using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDiag
{
    public partial class MainWindow : System.Windows.Forms.Form
    {

        public string ldhome;
        public MainWindow()
        {
            InitializeComponent();

            if (Environment.GetEnvironmentVariable("%LDMS_HOME%") != null)
            {
                //set variable to LDMS_HOME variable if valid
                ldhome = System.Environment.GetEnvironmentVariable("%LDMS_HOME%");
            }
            else
            {
                //if not on a Core, sets ldhome to current running directory and warns user
                MessageBox.Show("Could detect Core install path.\n" +
                    "The current directory will be used instead.\n", "Install Directory Not Found!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                ldhome = System.Environment.CurrentDirectory;
            }

            
            logLocationTextBox.Text = ldhome + "log";

            openSCN.InitialDirectory = ldhome + "ldscan\\ErrorScans";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void configToolStrpButton_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

      

        private void proxyOverrideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            proxyPasswordTextBox.ReadOnly = !proxyPasswordTextBox.ReadOnly;
            proxyAddressTextBox.ReadOnly = !proxyAddressTextBox.ReadOnly;

            if(proxyOverrideCheckBox.Checked == false)
            {
                proxyPasswordTextBox.Text = "";
                proxyAddressTextBox.Text = "";
            }
        }

        private void TabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSCN_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void scnToCheckText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
