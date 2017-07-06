using LDDiag;
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
using System.ServiceProcess;
//using STDiag;

namespace STDiag
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private static readonly ILog NativeLogger = log4net.LogManager.GetLogger("Native"); //Used to log exceptions and background info
        private static readonly ILog ManagedLogger = log4net.LogManager.GetLogger("MainWindow"); //Used to log human readable output


        public string ldhome;

        private int totalcheckedBoxes = 0;
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

        public static void updateDMLogBox(string message)
        {

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

        private void dmLogBox_TextChanged(object sender, EventArgs e)
        {

        }




        private void restartSvcsButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceController[] scms = ServiceController.GetServices();
                foreach (ServiceController sc in scms)
                {
                    if (sc.DisplayName.Contains("Landesk") || sc.DisplayName.Contains("Managed Planet"))
                    {
                        if (sc.Status == ServiceControllerStatus.Running)
                        {
                            sc.Stop();
                            sc.WaitForStatus(ServiceControllerStatus.Stopped);
                            sc.Start();
                        }
                        else
                        {
                            if (sc.Status == ServiceControllerStatus.Stopped)
                            {
                                sc.Start();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                NativeLogger.Error(ex.Data.ToString());
            }
        }
        private void DebugButton_Click(object sender, EventArgs e)
        {
            ServiceController scm;

            if (consoleDebugBox.Checked)
            {
                try
                {                
                    Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\Console.exe", "logVerbose", "1", "DWORD");
                    Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\Console.exe", "logXTrace", "1", "DWORD");
                    Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\Console.exe", "showSource", "1", "DWORD");
                }
                catch(Exception ex)
                {
                    ManagedLogger.Error("Failed to enable Console.exe debug logging");
                    NativeLogger.Error(ex.Data.ToString());
                }
            }
            if (inventoryDebugLog.Checked)
            {
                try
                {


                    Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\LDInv32.exe", "logVerbose", "1", "DWORD");
                    Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\LDInv32.exe", "logXTrace", "1", "DWORD");
                    Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\LDInv32.exe", "showSource", "1", "DWORD");
                }
                catch(Exception ex)
                {
                    ManagedLogger.Error("Failed to set registry keys to enable LDInv32.exe debug logging");
                    NativeLogger.Error(ex.Data.ToString());
                }
                scm = new ServiceController("Landesk Inventory Server");

                
                if (scm.Status == ServiceControllerStatus.Running)
                {
                    try
                    {
                        scm.Stop();
                    }
                    catch(Exception ex)
                    {
                        ManagedLogger.Error("Failed to stop service: " + scm.DisplayName);
                        NativeLogger.Error(ex.Data.ToString());
                    }
                    scm.WaitForStatus(ServiceControllerStatus.Stopped);
                    try
                    {

                        scm.Start();
                    }
                    catch(Exception ey)
                    {
                        ManagedLogger.Error("Failed to start service: " + scm.DisplayName);
                        NativeLogger.Error(ey.Data.ToString());
                    }
                }
                else
                {
                    scm.Start();

                }
            }

            if (webDTSDebug.Checked)
            {

                Util.setRegKey("\\Software\\Landesk\\Managed Planet\\Data Translation Services", "WebDebug", "1", "DWORD");

            }

            if (brokerDebug.Checked)
            {

                Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\BrokerService.exe", "logVerbose", "1", "DWORD");
                Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\BrokerService.exe", "logXTrace", "1", "DWORD");
                Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\BrokerService.exe", "showSource", "1", "DWORD");
                scm = new ServiceController("LDGSB");
                if (scm.Status == ServiceControllerStatus.Running)
                {
                    try
                    {
                        scm.Stop();
                    }
                    catch (Exception ex)
                    {
                        ManagedLogger.Error("Failed to stop service: " + scm.DisplayName);
                        NativeLogger.Error(ex.Data.ToString());
                    }
                    scm.WaitForStatus(ServiceControllerStatus.Stopped);
                    try
                    {

                        scm.Start();
                    }
                    catch (Exception ey)
                    {
                        ManagedLogger.Error("Failed to start service: " + scm.DisplayName);
                        NativeLogger.Error(ey.Data.ToString());
                    }
                }
                else
                {
                    scm.Start();

                }
            }

            if (activeDTSDebug.Checked)
            {
                Util.createRegKey("\\SOFTWARE\\Wow6432Node\\Managed Planet\\Core", "DebugLevel", "DWORD", "4");
            }

            if (alertSvcDebug.Checked)
            {

                Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\AlertService.exe", "logVerbose", "1", "DWORD");
                Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\AlertService.exe", "logXTrace", "1", "DWORD");
                Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\AlertService.exe", "showSource", "1", "DWORD");
                scm = new ServiceController("CBA8Alert");
                if (scm.Status == ServiceControllerStatus.Running)
                {
                    try
                    {
                        scm.Stop();
                    }
                    catch (Exception ex)
                    {
                        ManagedLogger.Error("Failed to stop service: " + scm.DisplayName);
                        NativeLogger.Error(ex.Data.ToString());
                    }
                    scm.WaitForStatus(ServiceControllerStatus.Stopped);
                    try
                    {

                        scm.Start();
                    }
                    catch (Exception ey)
                    {
                        ManagedLogger.Error("Failed to start service: " + scm.DisplayName);
                        NativeLogger.Error(ey.Data.ToString());
                    }
                }
                else
                {
                    scm.Start();

                }
            }

        }
        private void mainChanges_Click(object sender, EventArgs e)
        {
            DatamartChecker DMChecker = new DatamartChecker(dmPathText.Text, scnToCheckText.Text, "Standard", false, false, false);
        }
        
        private void webDTSDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (webDTSDebug.Checked)
            {
                totalcheckedBoxes++;
                Debug.WriteLine(totalcheckedBoxes);
            }
            if (!webDTSDebug.Checked)
            {
                totalcheckedBoxes--;
                Debug.WriteLine(totalcheckedBoxes);
            }
        }

        private void activeDTSDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (activeDTSDebug.Checked)
            {
                totalcheckedBoxes++;
                Debug.WriteLine(totalcheckedBoxes);
            }
            if (!activeDTSDebug.Checked)
            {
                totalcheckedBoxes--;
                Debug.WriteLine(totalcheckedBoxes);
            }
        }

        private void brokerDebug_CheckedChanged(object sender, EventArgs e)
        {
            if (brokerDebug.Checked)
            {
                totalcheckedBoxes++;
                Debug.WriteLine(totalcheckedBoxes);
            }
            if (!brokerDebug.Checked)
            {
                totalcheckedBoxes--;
                Debug.WriteLine(totalcheckedBoxes);
            }
        }

        private void alertSvc_checkChanged(object sender, EventArgs e)
        {
            if (alertSvcDebug.Checked)
            {
                totalcheckedBoxes++;
                Debug.WriteLine(totalcheckedBoxes);
            }
            if (!alertSvcDebug.Checked)
            {
                totalcheckedBoxes--;
                Debug.WriteLine(totalcheckedBoxes);
            }
        }
        private void consoleDebugBox_CheckedChanged(object sender, EventArgs e)
        {
            if (consoleDebugBox.Checked)
            {
                totalcheckedBoxes++;
                Debug.WriteLine(totalcheckedBoxes);
            }
            if (!consoleDebugBox.Checked)
            {
                totalcheckedBoxes--;
                Debug.WriteLine(totalcheckedBoxes);
            }
        }

        private void inventoryDebugLog_CheckedChanged(object sender, EventArgs e)
        {
            if (inventoryDebugLog.Checked)
            {
                totalcheckedBoxes++;
                Debug.WriteLine(totalcheckedBoxes);
            }
            if (!inventoryDebugLog.Checked)
            {
                totalcheckedBoxes--;
                Debug.WriteLine(totalcheckedBoxes);
            }
        }
    }
}



