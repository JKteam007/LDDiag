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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.proxyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.zippedLogsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.logLocationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coreSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateLDDiagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoUpdateChangeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadNewChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.InvCheck = new System.Windows.Forms.TabPage();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.ConfigCheck = new System.Windows.Forms.TabPage();
            this.DMCheck = new System.Windows.Forms.TabPage();
            this.mainChanges = new System.Windows.Forms.Button();
            this.getSCNButton = new System.Windows.Forms.Button();
            this.kitchenSinkButton = new System.Windows.Forms.Button();
            this.validateBox = new System.Windows.Forms.CheckBox();
            this.restartBox = new System.Windows.Forms.CheckBox();
            this.dmBackupBox = new System.Windows.Forms.CheckBox();
            this.commitDBButton = new System.Windows.Forms.Button();
            this.updateDMButton = new System.Windows.Forms.Button();
            this.checkChangesButton = new System.Windows.Forms.Button();
            this.dmLogBox = new System.Windows.Forms.TextBox();
            this.scnToCheckText = new System.Windows.Forms.TextBox();
            this.manualDMBox = new System.Windows.Forms.CheckBox();
            this.scnToCheckLabel = new System.Windows.Forms.Label();
            this.dmPathLabel = new System.Windows.Forms.Label();
            this.dmPathText = new System.Windows.Forms.TextBox();
            this.openSCN = new System.Windows.Forms.OpenFileDialog();
            this.DebugButton = new System.Windows.Forms.Button();
            this.consoleDebugBox = new System.Windows.Forms.CheckBox();
            this.inventoryDebugLog = new System.Windows.Forms.CheckBox();
            this.debugPanel = new System.Windows.Forms.Panel();
            this.webDTSDebug = new System.Windows.Forms.CheckBox();
            this.activeDTSDebug = new System.Windows.Forms.CheckBox();
            this.alertSvcDebug = new System.Windows.Forms.CheckBox();
            this.brokerDebug = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.DMCheck.SuspendLayout();
            this.debugPanel.SuspendLayout();
            this.SuspendLayout();
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoUpdateLDDiagToolStripMenuItem,
            this.autoUpdateChangeDBToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // autoUpdateLDDiagToolStripMenuItem
            // 
            this.autoUpdateLDDiagToolStripMenuItem.Name = "autoUpdateLDDiagToolStripMenuItem";
            this.autoUpdateLDDiagToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.autoUpdateLDDiagToolStripMenuItem.Text = "Auto Update LDDiag";
            // 
            // autoUpdateChangeDBToolStripMenuItem
            // 
            this.autoUpdateChangeDBToolStripMenuItem.Name = "autoUpdateChangeDBToolStripMenuItem";
            this.autoUpdateChangeDBToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.autoUpdateChangeDBToolStripMenuItem.Text = "Auto Update Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentationToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.downloadNewChangesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateToolStripMenuItem.Text = "Update LDDiag";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // downloadNewChangesToolStripMenuItem
            // 
            this.downloadNewChangesToolStripMenuItem.Name = "downloadNewChangesToolStripMenuItem";
            this.downloadNewChangesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.downloadNewChangesToolStripMenuItem.Text = "Update Database";
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
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.SystemColors.Control;
            this.HomePage.Controls.Add(this.debugPanel);
            this.HomePage.Controls.Add(this.DebugButton);
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
            this.TabMenu.Controls.Add(this.ConfigCheck);
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
            // ConfigCheck
            // 
            this.ConfigCheck.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigCheck.Location = new System.Drawing.Point(4, 22);
            this.ConfigCheck.Name = "ConfigCheck";
            this.ConfigCheck.Size = new System.Drawing.Size(490, 470);
            this.ConfigCheck.TabIndex = 5;
            this.ConfigCheck.Text = "Config Checker";
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
            this.DMCheck.Controls.Add(this.dmLogBox);
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
            // mainChanges
            // 
            this.mainChanges.Location = new System.Drawing.Point(10, 88);
            this.mainChanges.Name = "mainChanges";
            this.mainChanges.Size = new System.Drawing.Size(115, 23);
            this.mainChanges.TabIndex = 14;
            this.mainChanges.Text = "Standard Changes";
            this.mainChanges.UseVisualStyleBackColor = true;
            this.mainChanges.Click += new System.EventHandler(this.mainChanges_Click);
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
            // kitchenSinkButton
            // 
            this.kitchenSinkButton.Location = new System.Drawing.Point(131, 88);
            this.kitchenSinkButton.Name = "kitchenSinkButton";
            this.kitchenSinkButton.Size = new System.Drawing.Size(115, 23);
            this.kitchenSinkButton.TabIndex = 12;
            this.kitchenSinkButton.Text = "Kitchen Sink";
            this.kitchenSinkButton.UseVisualStyleBackColor = true;
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
            // commitDBButton
            // 
            this.commitDBButton.Location = new System.Drawing.Point(252, 117);
            this.commitDBButton.Name = "commitDBButton";
            this.commitDBButton.Size = new System.Drawing.Size(115, 23);
            this.commitDBButton.TabIndex = 8;
            this.commitDBButton.Text = "Commit To DB";
            this.commitDBButton.UseVisualStyleBackColor = true;
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
            // checkChangesButton
            // 
            this.checkChangesButton.Location = new System.Drawing.Point(11, 117);
            this.checkChangesButton.Name = "checkChangesButton";
            this.checkChangesButton.Size = new System.Drawing.Size(115, 23);
            this.checkChangesButton.TabIndex = 6;
            this.checkChangesButton.Text = "Compare to SCN";
            this.checkChangesButton.UseVisualStyleBackColor = true;
            // 
            // dmLogBox
            // 
            this.dmLogBox.Location = new System.Drawing.Point(0, 176);
            this.dmLogBox.Multiline = true;
            this.dmLogBox.Name = "dmLogBox";
            this.dmLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dmLogBox.Size = new System.Drawing.Size(490, 294);
            this.dmLogBox.TabIndex = 5;
            this.dmLogBox.TextChanged += new System.EventHandler(this.dmLogBox_TextChanged);
            // 
            // scnToCheckText
            // 
            this.scnToCheckText.Location = new System.Drawing.Point(142, 53);
            this.scnToCheckText.Name = "scnToCheckText";
            this.scnToCheckText.Size = new System.Drawing.Size(340, 20);
            this.scnToCheckText.TabIndex = 4;
            this.scnToCheckText.TextChanged += new System.EventHandler(this.scnToCheckText_TextChanged);
            this.scnToCheckText.Validating += new System.ComponentModel.CancelEventHandler(this.scnToCheckText_Validating);
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
            this.manualDMBox.CheckedChanged += new System.EventHandler(this.manualDMBox_CheckedChanged);
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
            // dmPathText
            // 
            this.dmPathText.Location = new System.Drawing.Point(168, 14);
            this.dmPathText.Name = "dmPathText";
            this.dmPathText.ReadOnly = true;
            this.dmPathText.Size = new System.Drawing.Size(314, 20);
            this.dmPathText.TabIndex = 0;
            this.dmPathText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openSCN
            // 
            this.openSCN.Filter = "\"SCN Files|*.scn\"";
            this.openSCN.FileOk += new System.ComponentModel.CancelEventHandler(this.openSCN_FileOk);
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(278, 188);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(180, 23);
            this.DebugButton.TabIndex = 0;
            this.DebugButton.Text = "Enable Debug Logs For Above";
            this.DebugButton.UseVisualStyleBackColor = true;
            // 
            // consoleDebugBox
            // 
            this.consoleDebugBox.AutoSize = true;
            this.consoleDebugBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleDebugBox.Location = new System.Drawing.Point(7, 6);
            this.consoleDebugBox.Name = "consoleDebugBox";
            this.consoleDebugBox.Size = new System.Drawing.Size(117, 20);
            this.consoleDebugBox.TabIndex = 0;
            this.consoleDebugBox.Text = "LDMS Console";
            this.consoleDebugBox.UseVisualStyleBackColor = true;
            // 
            // inventoryDebugLog
            // 
            this.inventoryDebugLog.AutoSize = true;
            this.inventoryDebugLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDebugLog.Location = new System.Drawing.Point(7, 42);
            this.inventoryDebugLog.Name = "inventoryDebugLog";
            this.inventoryDebugLog.Size = new System.Drawing.Size(124, 20);
            this.inventoryDebugLog.TabIndex = 1;
            this.inventoryDebugLog.Text = "Inventory Server";
            this.inventoryDebugLog.UseVisualStyleBackColor = true;
            // 
            // debugPanel
            // 
            this.debugPanel.Controls.Add(this.alertSvcDebug);
            this.debugPanel.Controls.Add(this.activeDTSDebug);
            this.debugPanel.Controls.Add(this.brokerDebug);
            this.debugPanel.Controls.Add(this.webDTSDebug);
            this.debugPanel.Controls.Add(this.inventoryDebugLog);
            this.debugPanel.Controls.Add(this.consoleDebugBox);
            this.debugPanel.Location = new System.Drawing.Point(225, 0);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(265, 182);
            this.debugPanel.TabIndex = 1;
            // 
            // webDTSDebug
            // 
            this.webDTSDebug.AutoSize = true;
            this.webDTSDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webDTSDebug.Location = new System.Drawing.Point(134, 6);
            this.webDTSDebug.Name = "webDTSDebug";
            this.webDTSDebug.Size = new System.Drawing.Size(128, 20);
            this.webDTSDebug.TabIndex = 2;
            this.webDTSDebug.Text = "DTS Web Macro";
            this.webDTSDebug.UseVisualStyleBackColor = true;
            // 
            // activeDTSDebug
            // 
            this.activeDTSDebug.AutoSize = true;
            this.activeDTSDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDTSDebug.Location = new System.Drawing.Point(134, 42);
            this.activeDTSDebug.Name = "activeDTSDebug";
            this.activeDTSDebug.Size = new System.Drawing.Size(133, 20);
            this.activeDTSDebug.TabIndex = 3;
            this.activeDTSDebug.Text = "Active DTS Rules";
            this.activeDTSDebug.UseVisualStyleBackColor = true;
            // 
            // alertSvcDebug
            // 
            this.alertSvcDebug.AutoSize = true;
            this.alertSvcDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertSvcDebug.Location = new System.Drawing.Point(7, 123);
            this.alertSvcDebug.Name = "alertSvcDebug";
            this.alertSvcDebug.Size = new System.Drawing.Size(121, 20);
            this.alertSvcDebug.TabIndex = 4;
            this.alertSvcDebug.Text = "Alerting Service";
            this.alertSvcDebug.UseVisualStyleBackColor = true;
            this.alertSvcDebug.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // brokerDebug
            // 
            this.brokerDebug.AutoSize = true;
            this.brokerDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brokerDebug.Location = new System.Drawing.Point(7, 82);
            this.brokerDebug.Name = "brokerDebug";
            this.brokerDebug.Size = new System.Drawing.Size(116, 20);
            this.brokerDebug.TabIndex = 7;
            this.brokerDebug.Text = "Broker Service";
            this.brokerDebug.UseVisualStyleBackColor = true;
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
            this.HomePage.ResumeLayout(false);
            this.TabMenu.ResumeLayout(false);
            this.DMCheck.ResumeLayout(false);
            this.DMCheck.PerformLayout();
            this.debugPanel.ResumeLayout(false);
            this.debugPanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadNewChangesToolStripMenuItem;
        private System.Windows.Forms.Button mainChanges;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateChangeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateLDDiagToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSCN;
        private System.Windows.Forms.TabPage ConfigCheck;
        public System.Windows.Forms.TextBox dmLogBox;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.CheckBox brokerDebug;
        private System.Windows.Forms.Panel debugPanel;
        private System.Windows.Forms.CheckBox alertSvcDebug;
        private System.Windows.Forms.CheckBox activeDTSDebug;
        private System.Windows.Forms.CheckBox webDTSDebug;
        private System.Windows.Forms.CheckBox inventoryDebugLog;
        private System.Windows.Forms.CheckBox consoleDebugBox;
        private System.Windows.Forms.Button DebugButton;
    }
}

