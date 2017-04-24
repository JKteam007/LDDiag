namespace STDiag
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.proxyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.proxyOverrideCheckBox = new System.Windows.Forms.CheckBox();
            this.zippedLogsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logLocationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.logLocationTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coreSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.InvCheck = new System.Windows.Forms.TabPage();
            this.LogCheckPage = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfigCheckPage = new System.Windows.Forms.TabPage();
            this.proxyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.proxyAddressTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.proxyPasswordLabel = new System.Windows.Forms.Label();
            this.proxyAddressLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.TestGridView = new System.Windows.Forms.DataGridView();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.DMCheck = new System.Windows.Forms.TabPage();
            this.dmPathText = new System.Windows.Forms.TextBox();
            this.dmPathLabel = new System.Windows.Forms.Label();
            this.scnToCheckLabel = new System.Windows.Forms.Label();
            this.manualDMBox = new System.Windows.Forms.CheckBox();
            this.scnToCheckText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkChangesButton = new System.Windows.Forms.Button();
            this.updateDMButton = new System.Windows.Forms.Button();
            this.commitDBButton = new System.Windows.Forms.Button();
            this.dmBackupBox = new System.Windows.Forms.CheckBox();
            this.restartBox = new System.Windows.Forms.CheckBox();
            this.validateBox = new System.Windows.Forms.CheckBox();
            this.kitchenSinkButton = new System.Windows.Forms.Button();
            this.getSCNButton = new System.Windows.Forms.Button();
            this.supportOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainChanges = new System.Windows.Forms.Button();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadNewChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateChangeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateLDDiagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSCN = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.LogCheckPage.SuspendLayout();
            this.ConfigCheckPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.DMCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // proxyOverrideCheckBox
            // 
            this.proxyOverrideCheckBox.AutoSize = true;
            this.proxyOverrideCheckBox.Location = new System.Drawing.Point(6, 92);
            this.proxyOverrideCheckBox.Name = "proxyOverrideCheckBox";
            this.proxyOverrideCheckBox.Size = new System.Drawing.Size(95, 17);
            this.proxyOverrideCheckBox.TabIndex = 4;
            this.proxyOverrideCheckBox.Text = "Proxy Override";
            this.proxyToolTip.SetToolTip(this.proxyOverrideCheckBox, "Overrides the auto-detected proxy settings");
            this.proxyOverrideCheckBox.UseVisualStyleBackColor = true;
            this.proxyOverrideCheckBox.CheckedChanged += new System.EventHandler(this.proxyOverrideCheckBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Analyze Zipped Logs";
            this.zippedLogsToolTip.SetToolTip(this.checkBox1, "Check to specify a .zip file instead of the default logging directory");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // logLocationTextBox
            // 
            this.logLocationTextBox.Location = new System.Drawing.Point(99, 8);
            this.logLocationTextBox.Name = "logLocationTextBox";
            this.logLocationTextBox.ReadOnly = true;
            this.logLocationTextBox.Size = new System.Drawing.Size(383, 20);
            this.logLocationTextBox.TabIndex = 8;
            this.logLocationTextBox.Text = "C:\\Program Files\\Landesk\\ManagementSuite\\log";
            this.logLocationToolTip.SetToolTip(this.logLocationTextBox, "Must be a valid local path or UNC path");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportOptionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coreSettingsToolStripMenuItem,
            this.credentialsToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // coreSettingsToolStripMenuItem
            // 
            this.coreSettingsToolStripMenuItem.Name = "coreSettingsToolStripMenuItem";
            this.coreSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coreSettingsToolStripMenuItem.Text = "Core Settings";
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            this.credentialsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.credentialsToolStripMenuItem.Text = "Credentials";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.downloadNewChangesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // InvCheck
            // 
            this.InvCheck.BackColor = System.Drawing.SystemColors.Control;
            this.InvCheck.Location = new System.Drawing.Point(4, 22);
            this.InvCheck.Name = "InvCheck";
            this.InvCheck.Size = new System.Drawing.Size(490, 470);
            this.InvCheck.TabIndex = 3;
            this.InvCheck.Text = "Inventory Checker";
            // 
            // LogCheckPage
            // 
            this.LogCheckPage.BackColor = System.Drawing.SystemColors.Control;
            this.LogCheckPage.Controls.Add(this.textBox3);
            this.LogCheckPage.Controls.Add(this.logLocationTextBox);
            this.LogCheckPage.Controls.Add(this.checkBox1);
            this.LogCheckPage.Controls.Add(this.label3);
            this.LogCheckPage.Location = new System.Drawing.Point(4, 22);
            this.LogCheckPage.Name = "LogCheckPage";
            this.LogCheckPage.Size = new System.Drawing.Size(490, 470);
            this.LogCheckPage.TabIndex = 2;
            this.LogCheckPage.Text = "Log Analyzer";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 97);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(484, 369);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log Location";
            // 
            // ConfigCheckPage
            // 
            this.ConfigCheckPage.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigCheckPage.Controls.Add(this.proxyPasswordTextBox);
            this.ConfigCheckPage.Controls.Add(this.proxyAddressTextBox);
            this.ConfigCheckPage.Controls.Add(this.usernameTextBox);
            this.ConfigCheckPage.Controls.Add(this.proxyPasswordLabel);
            this.ConfigCheckPage.Controls.Add(this.proxyAddressLabel);
            this.ConfigCheckPage.Controls.Add(this.stopButton);
            this.ConfigCheckPage.Controls.Add(this.passwordTextBox);
            this.ConfigCheckPage.Controls.Add(this.passwordLabel);
            this.ConfigCheckPage.Controls.Add(this.usernameLabel);
            this.ConfigCheckPage.Controls.Add(this.proxyOverrideCheckBox);
            this.ConfigCheckPage.Controls.Add(this.startButton);
            this.ConfigCheckPage.Controls.Add(this.TestGridView);
            this.ConfigCheckPage.Location = new System.Drawing.Point(4, 22);
            this.ConfigCheckPage.Name = "ConfigCheckPage";
            this.ConfigCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigCheckPage.Size = new System.Drawing.Size(490, 470);
            this.ConfigCheckPage.TabIndex = 1;
            this.ConfigCheckPage.Text = "Config Checker";
            // 
            // proxyPasswordTextBox
            // 
            this.proxyPasswordTextBox.Location = new System.Drawing.Point(334, 52);
            this.proxyPasswordTextBox.Name = "proxyPasswordTextBox";
            this.proxyPasswordTextBox.ReadOnly = true;
            this.proxyPasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.proxyPasswordTextBox.TabIndex = 13;
            this.proxyPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // proxyAddressTextBox
            // 
            this.proxyAddressTextBox.Location = new System.Drawing.Point(84, 52);
            this.proxyAddressTextBox.Name = "proxyAddressTextBox";
            this.proxyAddressTextBox.ReadOnly = true;
            this.proxyAddressTextBox.Size = new System.Drawing.Size(150, 20);
            this.proxyAddressTextBox.TabIndex = 12;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(81, 15);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 20);
            this.usernameTextBox.TabIndex = 7;
            // 
            // proxyPasswordLabel
            // 
            this.proxyPasswordLabel.AutoSize = true;
            this.proxyPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyPasswordLabel.Location = new System.Drawing.Point(240, 55);
            this.proxyPasswordLabel.Name = "proxyPasswordLabel";
            this.proxyPasswordLabel.Size = new System.Drawing.Size(82, 13);
            this.proxyPasswordLabel.TabIndex = 11;
            this.proxyPasswordLabel.Text = "Proxy Password";
            // 
            // proxyAddressLabel
            // 
            this.proxyAddressLabel.AutoSize = true;
            this.proxyAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyAddressLabel.Location = new System.Drawing.Point(4, 55);
            this.proxyAddressLabel.Name = "proxyAddressLabel";
            this.proxyAddressLabel.Size = new System.Drawing.Size(74, 13);
            this.proxyAddressLabel.TabIndex = 10;
            this.proxyAddressLabel.Text = "Proxy Address";
            this.proxyAddressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(407, 92);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(311, 15);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(237, 15);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 16);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(4, 19);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(71, 16);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(311, 92);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // TestGridView
            // 
            this.TestGridView.AllowUserToAddRows = false;
            this.TestGridView.AllowUserToDeleteRows = false;
            this.TestGridView.AllowUserToResizeColumns = false;
            this.TestGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.TestGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TestGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TestGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TestGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Test,
            this.Result});
            this.TestGridView.GridColor = System.Drawing.Color.LightGray;
            this.TestGridView.Location = new System.Drawing.Point(0, 121);
            this.TestGridView.Name = "TestGridView";
            this.TestGridView.RowHeadersVisible = false;
            this.TestGridView.RowTemplate.ReadOnly = true;
            this.TestGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TestGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TestGridView.Size = new System.Drawing.Size(490, 352);
            this.TestGridView.TabIndex = 2;
            // 
            // Test
            // 
            this.Test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Test.HeaderText = "Test";
            this.Test.MinimumWidth = 150;
            this.Test.Name = "Test";
            this.Test.ReadOnly = true;
            this.Test.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Test.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Test.Width = 150;
            // 
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Result.HeaderText = "Results";
            this.Result.MinimumWidth = 298;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Result.Width = 338;
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.SystemColors.Control;
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(490, 470);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.HomePage);
            this.TabMenu.Controls.Add(this.ConfigCheckPage);
            this.TabMenu.Controls.Add(this.LogCheckPage);
            this.TabMenu.Controls.Add(this.InvCheck);
            this.TabMenu.Controls.Add(this.DMCheck);
            this.TabMenu.Location = new System.Drawing.Point(0, 24);
            this.TabMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(498, 496);
            this.TabMenu.TabIndex = 1;
            this.TabMenu.SelectedIndexChanged += new System.EventHandler(this.TabMenu_SelectedIndexChanged);
            // 
            // DMCheck
            // 
            this.DMCheck.BackColor = System.Drawing.SystemColors.Control;
            this.DMCheck.Controls.Add(this.mainChanges);
            this.DMCheck.Controls.Add(this.getSCNButton);
            this.DMCheck.Controls.Add(this.kitchenSinkButton);
            this.DMCheck.Controls.Add(this.validateBox);
            this.DMCheck.Controls.Add(this.restartBox);
            this.DMCheck.Controls.Add(this.dmBackupBox);
            this.DMCheck.Controls.Add(this.commitDBButton);
            this.DMCheck.Controls.Add(this.updateDMButton);
            this.DMCheck.Controls.Add(this.checkChangesButton);
            this.DMCheck.Controls.Add(this.textBox4);
            this.DMCheck.Controls.Add(this.scnToCheckText);
            this.DMCheck.Controls.Add(this.manualDMBox);
            this.DMCheck.Controls.Add(this.scnToCheckLabel);
            this.DMCheck.Controls.Add(this.dmPathLabel);
            this.DMCheck.Controls.Add(this.dmPathText);
            this.DMCheck.Location = new System.Drawing.Point(4, 22);
            this.DMCheck.Name = "DMCheck";
            this.DMCheck.Size = new System.Drawing.Size(490, 470);
            this.DMCheck.TabIndex = 4;
            this.DMCheck.Text = "Datamart Checker";
            // 
            // dmPathText
            // 
            this.dmPathText.Location = new System.Drawing.Point(168, 14);
            this.dmPathText.Name = "dmPathText";
            this.dmPathText.ReadOnly = true;
            this.dmPathText.Size = new System.Drawing.Size(314, 20);
            this.dmPathText.TabIndex = 0;
            this.dmPathText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dmPathLabel
            // 
            this.dmPathLabel.AutoSize = true;
            this.dmPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmPathLabel.Location = new System.Drawing.Point(8, 18);
            this.dmPathLabel.Name = "dmPathLabel";
            this.dmPathLabel.Size = new System.Drawing.Size(154, 16);
            this.dmPathLabel.TabIndex = 1;
            this.dmPathLabel.Text = "Detected Datamart Path:";
            // 
            // scnToCheckLabel
            // 
            this.scnToCheckLabel.AutoSize = true;
            this.scnToCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scnToCheckLabel.Location = new System.Drawing.Point(8, 57);
            this.scnToCheckLabel.Name = "scnToCheckLabel";
            this.scnToCheckLabel.Size = new System.Drawing.Size(128, 16);
            this.scnToCheckLabel.TabIndex = 2;
            this.scnToCheckLabel.Text = "Scan File To Check:";
            // 
            // manualDMBox
            // 
            this.manualDMBox.AutoSize = true;
            this.manualDMBox.Location = new System.Drawing.Point(11, 37);
            this.manualDMBox.Name = "manualDMBox";
            this.manualDMBox.Size = new System.Drawing.Size(112, 17);
            this.manualDMBox.TabIndex = 3;
            this.manualDMBox.Text = "Set Path Manually";
            this.manualDMBox.UseVisualStyleBackColor = true;
            // 
            // scnToCheckText
            // 
            this.scnToCheckText.Location = new System.Drawing.Point(142, 53);
            this.scnToCheckText.Name = "scnToCheckText";
            this.scnToCheckText.Size = new System.Drawing.Size(340, 20);
            this.scnToCheckText.TabIndex = 4;
            this.scnToCheckText.TextChanged += new System.EventHandler(this.scnToCheckText_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 176);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(490, 294);
            this.textBox4.TabIndex = 5;
            // 
            // checkChangesButton
            // 
            this.checkChangesButton.Location = new System.Drawing.Point(11, 117);
            this.checkChangesButton.Name = "checkChangesButton";
            this.checkChangesButton.Size = new System.Drawing.Size(115, 23);
            this.checkChangesButton.TabIndex = 6;
            this.checkChangesButton.Text = "Check Changes";
            this.checkChangesButton.UseVisualStyleBackColor = true;
            // 
            // updateDMButton
            // 
            this.updateDMButton.Location = new System.Drawing.Point(131, 117);
            this.updateDMButton.Name = "updateDMButton";
            this.updateDMButton.Size = new System.Drawing.Size(115, 23);
            this.updateDMButton.TabIndex = 7;
            this.updateDMButton.Text = "Update Datamart";
            this.updateDMButton.UseVisualStyleBackColor = true;
            // 
            // commitDBButton
            // 
            this.commitDBButton.Location = new System.Drawing.Point(252, 117);
            this.commitDBButton.Name = "commitDBButton";
            this.commitDBButton.Size = new System.Drawing.Size(115, 23);
            this.commitDBButton.TabIndex = 8;
            this.commitDBButton.Text = "Commit To DB";
            this.commitDBButton.UseVisualStyleBackColor = true;
            // 
            // dmBackupBox
            // 
            this.dmBackupBox.AutoSize = true;
            this.dmBackupBox.Location = new System.Drawing.Point(11, 153);
            this.dmBackupBox.Name = "dmBackupBox";
            this.dmBackupBox.Size = new System.Drawing.Size(127, 17);
            this.dmBackupBox.TabIndex = 9;
            this.dmBackupBox.Text = "Backup Datamart.xml";
            this.dmBackupBox.UseVisualStyleBackColor = true;
            // 
            // restartBox
            // 
            this.restartBox.AutoSize = true;
            this.restartBox.Location = new System.Drawing.Point(142, 153);
            this.restartBox.Name = "restartBox";
            this.restartBox.Size = new System.Drawing.Size(104, 17);
            this.restartBox.TabIndex = 10;
            this.restartBox.Text = "Restart Services";
            this.restartBox.UseVisualStyleBackColor = true;
            // 
            // validateBox
            // 
            this.validateBox.AutoSize = true;
            this.validateBox.Location = new System.Drawing.Point(252, 153);
            this.validateBox.Name = "validateBox";
            this.validateBox.Size = new System.Drawing.Size(109, 17);
            this.validateBox.TabIndex = 11;
            this.validateBox.Text = "Validate Changes";
            this.validateBox.UseVisualStyleBackColor = true;
            // 
            // kitchenSinkButton
            // 
            this.kitchenSinkButton.Location = new System.Drawing.Point(131, 88);
            this.kitchenSinkButton.Name = "kitchenSinkButton";
            this.kitchenSinkButton.Size = new System.Drawing.Size(115, 23);
            this.kitchenSinkButton.TabIndex = 12;
            this.kitchenSinkButton.Text = "Kitchen Sink";
            this.kitchenSinkButton.UseVisualStyleBackColor = true;
            // 
            // getSCNButton
            // 
            this.getSCNButton.Location = new System.Drawing.Point(252, 88);
            this.getSCNButton.Name = "getSCNButton";
            this.getSCNButton.Size = new System.Drawing.Size(151, 23);
            this.getSCNButton.TabIndex = 13;
            this.getSCNButton.Text = "Get SCN From EventViewer";
            this.getSCNButton.UseVisualStyleBackColor = true;
            // 
            // supportOptionsToolStripMenuItem
            // 
            this.supportOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterKeyToolStripMenuItem});
            this.supportOptionsToolStripMenuItem.Name = "supportOptionsToolStripMenuItem";
            this.supportOptionsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.supportOptionsToolStripMenuItem.Text = "Support Options";
            // 
            // enterKeyToolStripMenuItem
            // 
            this.enterKeyToolStripMenuItem.Name = "enterKeyToolStripMenuItem";
            this.enterKeyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enterKeyToolStripMenuItem.Text = "Enter Key";
            // 
            // mainChanges
            // 
            this.mainChanges.Location = new System.Drawing.Point(10, 88);
            this.mainChanges.Name = "mainChanges";
            this.mainChanges.Size = new System.Drawing.Size(115, 23);
            this.mainChanges.TabIndex = 14;
            this.mainChanges.Text = "Standard Changes";
            this.mainChanges.UseVisualStyleBackColor = true;
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateToolStripMenuItem.Text = "Update LDDiag";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // downloadNewChangesToolStripMenuItem
            // 
            this.downloadNewChangesToolStripMenuItem.Name = "downloadNewChangesToolStripMenuItem";
            this.downloadNewChangesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.downloadNewChangesToolStripMenuItem.Text = "Update ChangeDB";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoUpdateChangeDBToolStripMenuItem,
            this.autoUpdateLDDiagToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // autoUpdateChangeDBToolStripMenuItem
            // 
            this.autoUpdateChangeDBToolStripMenuItem.Name = "autoUpdateChangeDBToolStripMenuItem";
            this.autoUpdateChangeDBToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.autoUpdateChangeDBToolStripMenuItem.Text = "Auto Update ChangeDB";
            // 
            // autoUpdateLDDiagToolStripMenuItem
            // 
            this.autoUpdateLDDiagToolStripMenuItem.Name = "autoUpdateLDDiagToolStripMenuItem";
            this.autoUpdateLDDiagToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.autoUpdateLDDiagToolStripMenuItem.Text = "Auto Update LDDiag";
            // 
            // openSCN
            // 
            this.openSCN.Filter = "\"SCN Files|*.scn\"";
            this.openSCN.FileOk += new System.ComponentModel.CancelEventHandler(this.openSCN_FileOk);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 523);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(514, 562);
            this.MinimumSize = new System.Drawing.Size(514, 562);
            this.Name = "MainWindow";
            this.Text = "LDDiag";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LogCheckPage.ResumeLayout(false);
            this.LogCheckPage.PerformLayout();
            this.ConfigCheckPage.ResumeLayout(false);
            this.ConfigCheckPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.DMCheck.ResumeLayout(false);
            this.DMCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip proxyToolTip;
        private System.Windows.Forms.ToolTip zippedLogsToolTip;
        private System.Windows.Forms.ToolTip logLocationToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TabPage InvCheck;
        private System.Windows.Forms.TabPage LogCheckPage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox logLocationTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage ConfigCheckPage;
        private System.Windows.Forms.TextBox proxyPasswordTextBox;
        private System.Windows.Forms.TextBox proxyAddressTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label proxyPasswordLabel;
        private System.Windows.Forms.Label proxyAddressLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox proxyOverrideCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView TestGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage DMCheck;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coreSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox scnToCheckText;
        private System.Windows.Forms.CheckBox manualDMBox;
        private System.Windows.Forms.Label scnToCheckLabel;
        private System.Windows.Forms.Label dmPathLabel;
        private System.Windows.Forms.TextBox dmPathText;
        private System.Windows.Forms.ToolStripMenuItem supportOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterKeyToolStripMenuItem;
        private System.Windows.Forms.Button getSCNButton;
        private System.Windows.Forms.Button kitchenSinkButton;
        private System.Windows.Forms.CheckBox validateBox;
        private System.Windows.Forms.CheckBox restartBox;
        private System.Windows.Forms.CheckBox dmBackupBox;
        private System.Windows.Forms.Button commitDBButton;
        private System.Windows.Forms.Button updateDMButton;
        private System.Windows.Forms.Button checkChangesButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadNewChangesToolStripMenuItem;
        private System.Windows.Forms.Button mainChanges;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateChangeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateLDDiagToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSCN;
    }
}

