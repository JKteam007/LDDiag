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
using System.Threading;
//using STDiag;

namespace STDiag
{
    public partial class MainWindow : System.Windows.Forms.Form
    {
        private static readonly ILog NativeLogger = log4net.LogManager.GetLogger("Native"); //Used to log exceptions and background info
        private static readonly ILog ManagedLogger = log4net.LogManager.GetLogger("MainWindow"); //Used to log human readable output

        private Thread csThread;

        private bool isCore;

        private int totalcheckedBoxes = 0;
        public MainWindow()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
            Debug.WriteLine("Main Window Loaded");

            ManagedLogger.Info("LDDiag loaded. Version is: " + Environment.Version);

            TabMenu.TabPages.Remove(ConfigCheck);
            TabMenu.TabPages.Remove(InvCheck);

            isCore = checkIsCore();

        }

        private bool checkIsCore()
        {
            //Check to see if configured Core is actually a Core.


            return false;
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

            if (isCore)
            {

                if (consoleDebugBox.Checked)
                {
                    try
                    {
                        Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\Console.exe", "logVerbose", "1", "DWORD");
                        Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\Console.exe", "logXTrace", "1", "DWORD");
                        Util.setRegKey("\\Software\\Landesk\\ManagementSuite\\LogOptions\\Console.exe", "showSource", "1", "DWORD");
                    }
                    catch (Exception ex)
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
                    catch (Exception ex)
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
            else
            {
                MessageBox.Show("A valid core hasn't been specified. This action cannot be preformed.", "Core Not Found!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

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

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NativeLogger.Info("Application shutdown requested.");
            System.Windows.Forms.Application.Exit();
        }

        private void coreSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Debug.WriteLine("Core Settings clicked");
            csThread = new Thread(getCoreSettings);
            csThread.Start();

        }

        public void getCoreSettings()
        {
          

            CoreSettings initCoreSettings = new CoreSettings();
            Application.Run(initCoreSettings);
           // initCoreSettings.submitButton.Click += initCoreSettings.submitButton_Click;           

        }
        private void closeCoreSettings(object sender, EventArgs e)
        {
            //try
            //{
            //    string[] coreInfo = initCoreSettings.getSettings();

            //    foreach (string st in coreInfo)
            //    {
            //        NativeLogger.Debug(st);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    ManagedLogger.Error("Error saving core settings: " + ex.Data.ToString());
            //}
            Debug.WriteLine("Aborting thread");
            csThread.Abort();
        }
    }
}




