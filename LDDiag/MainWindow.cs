using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDiag
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private static readonly ILog NativeLogger = log4net.LogManager.GetLogger("Native"); //Used to log exceptions and background info
        private static readonly ILog ManagedLogger = log4net.LogManager.GetLogger("MainWindow"); //Used to log human readable output

        public string ldhome;
        public MainWindow()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
            NativeLogger.Info("Main Window Loaded");

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
                ldhome = System.Environment.CurrentDirectory + "\\";
            }


            openSCN.InitialDirectory = ldhome + "ldscan\\ErrorScans";
            dmPathText.Text = ldhome + "Datamart.xml";

        }

        public void updateDMLogBox(string message)
        {
            message = message + System.Environment.NewLine;
            dmLogBox.AppendText(message);
        }



        private void scnToCheckText_Validating(object sender, CancelEventArgs e)
        {
            string str = scnToCheckText.Text;
            int length = str.Length;
            int index = str.IndexOf('.') + 1;
            string extension = "";

            try
            {               

                if (scnToCheckText.Text.IndexOf('.') != -1)
                {
                    extension = scnToCheckText.Text.Substring(index);
                }
                else
                {
                    e.Cancel = true;
                }              

            }
            catch (Exception ex)
            {
                NativeLogger.Error(ex.Data.ToString());
            }

            if (extension != "scn")
            {
                updateDMLogBox("Invalid filename. File extension must be .scn");
                scnToCheckText.Text = "";
            }
        }

<<<<<<< HEAD
        private void dmLogBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
=======
>>>>>>> origin/master
    }
}
