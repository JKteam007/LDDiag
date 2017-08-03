using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STDiag;
using log4net;
using System.Diagnostics;

namespace LDDiag
{
    class CoreSettings : Form
    {

        private static readonly ILog NativeLogger = log4net.LogManager.GetLogger("Native"); //Used to log exceptions and background info
        private static readonly ILog ManagedLogger = log4net.LogManager.GetLogger("MainWindow"); //Used to log human readable output

        private bool isWindowsAuth, dbAuthUseCore;

        private string coreAddress, coreUsername, corePassword, dbUsername, dbPassword;

        TextBox coreAddressBox = new TextBox();
        TextBox coreUsernameBox = new TextBox();
        TextBox corePasswordBox = new TextBox();
        TextBox dbUsernameBox = new TextBox();
        TextBox dbPasswordBox = new TextBox();

        Label coreAddressLabel = new Label();
        Label coreUsernameLabel = new Label();
        Label corePasswordLabel = new Label();
        Label dbUsernameLabel = new Label();
        Label dbPasswordLabel = new Label();



        public Button submitButton = new Button();

        CheckBox isWindowsAuthBox = new CheckBox();
        CheckBox dbUseCoreAuthBox = new CheckBox();

        FlowLayoutPanel flowPanel = new FlowLayoutPanel();

        FlowLayoutPanel coreAddressPanel = new FlowLayoutPanel();
        FlowLayoutPanel coreUsernamePanel = new FlowLayoutPanel();
        FlowLayoutPanel corePasswordPanel = new FlowLayoutPanel();
        FlowLayoutPanel dbUsernamePanel = new FlowLayoutPanel();
        FlowLayoutPanel dbPasswordPanel = new FlowLayoutPanel();
        FlowLayoutPanel bottomPanel = new FlowLayoutPanel();

        public CoreSettings()
        {
            //Form this = new Form();



            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(450, 250);
            this.Text = "Core Information";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            flowPanel.Size = new System.Drawing.Size(450, 250);



            coreAddressPanel.FlowDirection = FlowDirection.LeftToRight;
            corePasswordPanel.FlowDirection = FlowDirection.LeftToRight;
            coreUsernamePanel.FlowDirection = FlowDirection.LeftToRight;
            dbUsernamePanel.FlowDirection = FlowDirection.LeftToRight;
            dbPasswordPanel.FlowDirection = FlowDirection.LeftToRight;
            bottomPanel.FlowDirection = FlowDirection.LeftToRight;

            System.Drawing.Size subPanelSize = new System.Drawing.Size(450, 28);
            System.Drawing.Size labelSize = new System.Drawing.Size(105, 28);
            System.Drawing.Size textBoxSize = new System.Drawing.Size(300, 28);

            coreAddressPanel.MaximumSize = subPanelSize;
            corePasswordPanel.MaximumSize = subPanelSize;
            coreUsernamePanel.MaximumSize = subPanelSize;
            dbUsernamePanel.MaximumSize = subPanelSize;
            dbPasswordPanel.MaximumSize = subPanelSize;
            bottomPanel.MaximumSize = subPanelSize;

            coreAddressPanel.MinimumSize = subPanelSize;
            corePasswordPanel.MinimumSize = subPanelSize;
            coreUsernamePanel.MinimumSize = subPanelSize;
            dbUsernamePanel.MinimumSize = subPanelSize;
            dbPasswordPanel.MinimumSize = subPanelSize;
            bottomPanel.MinimumSize = subPanelSize;

            coreAddressPanel.AutoSize = false;
            corePasswordPanel.AutoSize = false;
            coreUsernamePanel.AutoSize = false;
            dbUsernamePanel.AutoSize = false;
            dbPasswordPanel.AutoSize = false;
            bottomPanel.AutoSize = false;



            isWindowsAuthBox.MinimumSize = new System.Drawing.Size(120, 28);
            dbUseCoreAuthBox.MinimumSize = new System.Drawing.Size(200, 28);

            flowPanel.Margin = new Padding(0);

            isWindowsAuthBox.Text = "Integrated Logon";
            dbUseCoreAuthBox.Text = "Use Core Authentication for DB";

            coreAddressLabel.Text = "Core Server: ";
            coreUsernameLabel.Text = "Username: ";
            corePasswordLabel.Text = "Password: ";
            corePasswordBox.UseSystemPasswordChar = true;
            dbUsernameLabel.Text = "DB Username: ";
            dbPasswordLabel.Text = "DB Password: ";
            dbPasswordBox.UseSystemPasswordChar = true;

            coreAddressLabel.Size = labelSize;
            coreUsernameLabel.Size = labelSize;
            corePasswordLabel.Size = labelSize;
            dbUsernameLabel.Size = labelSize;
            dbPasswordLabel.Size = labelSize;

            coreAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            coreAddressLabel.Font = new Font("Calibri", 12);
            coreUsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            coreUsernameLabel.Font = new Font("Calibri", 12);
            corePasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            corePasswordLabel.Font = new Font("Calibri", 12);
            dbUsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
            dbUsernameLabel.Font = new Font("Calibri", 12);
            dbPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            dbPasswordLabel.Font = new Font("Calibri", 12);

            submitButton.Text = "Submit";

            this.Controls.Add(flowPanel);

            coreAddressBox.Size = textBoxSize;
            corePasswordBox.Size = textBoxSize;
            dbUsernameBox.Size = textBoxSize;
            coreUsernameBox.Size = textBoxSize;
            dbPasswordBox.Size = textBoxSize;


            coreAddressPanel.Controls.Add(coreAddressLabel);
            coreAddressPanel.Controls.Add(coreAddressBox);

            coreUsernamePanel.Controls.Add(coreUsernameLabel);
            coreUsernamePanel.Controls.Add(coreUsernameBox);
            //coreUsernamePanel.Controls.Add(isWindowsAuthBox);

            corePasswordPanel.Controls.Add(corePasswordLabel);
            corePasswordPanel.Controls.Add(corePasswordBox);

            dbUsernamePanel.Controls.Add(dbUsernameLabel);
            dbUsernamePanel.Controls.Add(dbUsernameBox);
            //dbUsernamePanel.Controls.Add(dbUseCoreAuthBox);

            dbPasswordPanel.Controls.Add(dbPasswordLabel);
            dbPasswordPanel.Controls.Add(dbPasswordBox);

            bottomPanel.Controls.Add(submitButton);
            bottomPanel.Controls.Add(isWindowsAuthBox);
            bottomPanel.Controls.Add(dbUseCoreAuthBox);

            flowPanel.Controls.Add(coreAddressPanel);
            flowPanel.Controls.Add(coreUsernamePanel);
            flowPanel.Controls.Add(corePasswordPanel);
            flowPanel.Controls.Add(dbPasswordPanel);
            flowPanel.Controls.Add(dbUsernamePanel);
            flowPanel.Controls.Add(bottomPanel);

            //coreAddressPanel.BackColor = Color.Green;
            //coreUsernamePanel.BackColor = Color.Blue;
            //corePasswordPanel.BackColor = Color.Red;
            //dbPasswordPanel.BackColor = Color.Aqua;
            //dbUsernamePanel.BackColor = Color.Violet;
            //bottomPanel.BackColor = Color.Honeydew;


            flowPanel.AutoSize = false;

            submitButton.Click += submitButton_Click;

           // this.Show();

        }

        public void submitButton_Click(object sender, EventArgs e)
        {

            if(isWindowsAuth)
            {

                //Code here to get windows context

            }
            if (dbUseCoreAuthBox.Checked)
            {
                dbUsername = coreUsername;
                dbPassword = corePassword;
            }
            else
            {
                dbUsername = dbUsernameBox.Text;
                dbPassword = dbPasswordBox.Text;
            }

            coreAddress = coreAddressBox.Text;
            coreUsername = coreUsernameBox.Text;
            corePassword = corePasswordBox.Text;

            //NativeLogger.Debug("submit button clicked");
            Debug.WriteLine("Submit clicked");

        }

        public string[] getSettings()
        {
            string[] settings = new string[]{coreAddress, coreUsername, corePassword, dbUsername, dbPassword};

            

            return settings;
        }
    }
}
