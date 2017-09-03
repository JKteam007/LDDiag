using System;

namespace LDDiag
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
            this.openSCN = new System.Windows.Forms.OpenFileDialog();
            this.InvCheck = new System.Windows.Forms.TabPage();
            this.inventoryProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConfigCheck = new System.Windows.Forms.TabPage();
            this.configProgessBar = new System.Windows.Forms.ProgressBar();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.flushIISButton = new System.Windows.Forms.Button();
            this.warningsPanel = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.archiveLogsButton = new System.Windows.Forms.Button();
            this.currentSettingsPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currentHealthPanel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainProgressBar = new System.Windows.Forms.ProgressBar();
            this.restartSvcsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consoleDebugBox = new System.Windows.Forms.CheckBox();
            this.alertSvcDebug = new System.Windows.Forms.CheckBox();
            this.inventoryDebugLog = new System.Windows.Forms.CheckBox();
            this.activeDTSDebug = new System.Windows.Forms.CheckBox();
            this.webDTSDebug = new System.Windows.Forms.CheckBox();
            this.DebugButton = new System.Windows.Forms.Button();
            this.brokerDebug = new System.Windows.Forms.CheckBox();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.DBCheck = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dbCheckAllButton = new System.Windows.Forms.Button();
            this.dbTableSizesButton = new System.Windows.Forms.Button();
            this.dbFragButton = new System.Windows.Forms.Button();
            this.dbDiag = new System.Windows.Forms.Label();
            this.dbInfoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ScheduledMaint = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbProgressBar = new System.Windows.Forms.ProgressBar();
            this.ConfigTab = new System.Windows.Forms.TabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nodeCountLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.InvCheck.SuspendLayout();
            this.ConfigCheck.SuspendLayout();
            this.HomePage.SuspendLayout();
            this.warningsPanel.SuspendLayout();
            this.currentSettingsPanel.SuspendLayout();
            this.currentHealthPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.DBCheck.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ConfigTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
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
            this.supportOptionsToolStripMenuItem.Text = "Developer Mode";
            this.supportOptionsToolStripMenuItem.Visible = false;
            // 
            // enterKeyToolStripMenuItem
            // 
            this.enterKeyToolStripMenuItem.Name = "enterKeyToolStripMenuItem";
            this.enterKeyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.enterKeyToolStripMenuItem.Text = "Enter Key";
            this.enterKeyToolStripMenuItem.Click += new System.EventHandler(this.enterKeyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoUpdateLDDiagToolStripMenuItem,
            this.autoUpdateChangeDBToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
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
            // openSCN
            // 
            this.openSCN.Filter = "\"SCN Files|*.scn\"";
            // 
            // InvCheck
            // 
            this.InvCheck.BackColor = System.Drawing.SystemColors.Control;
            this.InvCheck.Controls.Add(this.inventoryProgressBar);
            this.InvCheck.Location = new System.Drawing.Point(4, 22);
            this.InvCheck.Name = "InvCheck";
            this.InvCheck.Size = new System.Drawing.Size(490, 470);
            this.InvCheck.TabIndex = 3;
            this.InvCheck.Text = "Inventory Checker";
            // 
            // inventoryProgressBar
            // 
            this.inventoryProgressBar.Location = new System.Drawing.Point(3, 442);
            this.inventoryProgressBar.Name = "inventoryProgressBar";
            this.inventoryProgressBar.Size = new System.Drawing.Size(484, 23);
            this.inventoryProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.inventoryProgressBar.TabIndex = 11;
            // 
            // ConfigCheck
            // 
            this.ConfigCheck.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigCheck.Controls.Add(this.configProgessBar);
            this.ConfigCheck.Location = new System.Drawing.Point(4, 22);
            this.ConfigCheck.Name = "ConfigCheck";
            this.ConfigCheck.Size = new System.Drawing.Size(490, 470);
            this.ConfigCheck.TabIndex = 5;
            this.ConfigCheck.Text = "Config Checker";
            // 
            // configProgessBar
            // 
            this.configProgessBar.Location = new System.Drawing.Point(3, 442);
            this.configProgessBar.Name = "configProgessBar";
            this.configProgessBar.Size = new System.Drawing.Size(484, 23);
            this.configProgessBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.configProgessBar.TabIndex = 11;
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.SystemColors.Control;
            this.HomePage.Controls.Add(this.flushIISButton);
            this.HomePage.Controls.Add(this.warningsPanel);
            this.HomePage.Controls.Add(this.archiveLogsButton);
            this.HomePage.Controls.Add(this.currentSettingsPanel);
            this.HomePage.Controls.Add(this.currentHealthPanel);
            this.HomePage.Controls.Add(this.mainProgressBar);
            this.HomePage.Controls.Add(this.restartSvcsButton);
            this.HomePage.Controls.Add(this.panel1);
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(490, 470);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.Click += new System.EventHandler(this.HomePage_Click);
            // 
            // flushIISButton
            // 
            this.flushIISButton.Location = new System.Drawing.Point(6, 232);
            this.flushIISButton.Name = "flushIISButton";
            this.flushIISButton.Size = new System.Drawing.Size(148, 23);
            this.flushIISButton.TabIndex = 13;
            this.flushIISButton.Text = "Flush IIS";
            this.flushIISButton.UseVisualStyleBackColor = true;
            // 
            // warningsPanel
            // 
            this.warningsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.warningsPanel.Controls.Add(this.textBox3);
            this.warningsPanel.Controls.Add(this.label5);
            this.warningsPanel.Location = new System.Drawing.Point(334, 6);
            this.warningsPanel.Name = "warningsPanel";
            this.warningsPanel.Size = new System.Drawing.Size(148, 209);
            this.warningsPanel.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(-1, 30);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(148, 178);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Issues Found";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // archiveLogsButton
            // 
            this.archiveLogsButton.Location = new System.Drawing.Point(334, 232);
            this.archiveLogsButton.Name = "archiveLogsButton";
            this.archiveLogsButton.Size = new System.Drawing.Size(144, 23);
            this.archiveLogsButton.TabIndex = 14;
            this.archiveLogsButton.Text = "Archive Logs";
            this.archiveLogsButton.UseVisualStyleBackColor = true;
            // 
            // currentSettingsPanel
            // 
            this.currentSettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentSettingsPanel.Controls.Add(this.textBox2);
            this.currentSettingsPanel.Controls.Add(this.label4);
            this.currentSettingsPanel.Location = new System.Drawing.Point(162, 6);
            this.currentSettingsPanel.Name = "currentSettingsPanel";
            this.currentSettingsPanel.Size = new System.Drawing.Size(165, 209);
            this.currentSettingsPanel.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(-1, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(165, 177);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "General";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentHealthPanel
            // 
            this.currentHealthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentHealthPanel.Controls.Add(this.textBox4);
            this.currentHealthPanel.Controls.Add(this.label3);
            this.currentHealthPanel.Location = new System.Drawing.Point(6, 6);
            this.currentHealthPanel.Name = "currentHealthPanel";
            this.currentHealthPanel.Size = new System.Drawing.Size(148, 209);
            this.currentHealthPanel.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(-1, 30);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(148, 178);
            this.textBox4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Core Health";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainProgressBar
            // 
            this.mainProgressBar.Location = new System.Drawing.Point(3, 442);
            this.mainProgressBar.Name = "mainProgressBar";
            this.mainProgressBar.Size = new System.Drawing.Size(484, 23);
            this.mainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.mainProgressBar.TabIndex = 10;
            // 
            // restartSvcsButton
            // 
            this.restartSvcsButton.Location = new System.Drawing.Point(162, 232);
            this.restartSvcsButton.Name = "restartSvcsButton";
            this.restartSvcsButton.Size = new System.Drawing.Size(165, 23);
            this.restartSvcsButton.TabIndex = 9;
            this.restartSvcsButton.Text = "Restart All Landesk Services";
            this.restartSvcsButton.UseVisualStyleBackColor = true;
            this.restartSvcsButton.Click += new System.EventHandler(this.restartSvcsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consoleDebugBox);
            this.panel1.Controls.Add(this.alertSvcDebug);
            this.panel1.Controls.Add(this.inventoryDebugLog);
            this.panel1.Controls.Add(this.activeDTSDebug);
            this.panel1.Controls.Add(this.webDTSDebug);
            this.panel1.Controls.Add(this.DebugButton);
            this.panel1.Controls.Add(this.brokerDebug);
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 176);
            this.panel1.TabIndex = 8;
            // 
            // consoleDebugBox
            // 
            this.consoleDebugBox.AutoSize = true;
            this.consoleDebugBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleDebugBox.Location = new System.Drawing.Point(6, 21);
            this.consoleDebugBox.Name = "consoleDebugBox";
            this.consoleDebugBox.Size = new System.Drawing.Size(135, 20);
            this.consoleDebugBox.TabIndex = 0;
            this.consoleDebugBox.Text = "Windows Console";
            this.consoleDebugBox.UseVisualStyleBackColor = true;
            this.consoleDebugBox.CheckedChanged += new System.EventHandler(this.consoleDebugBox_CheckedChanged);
            // 
            // alertSvcDebug
            // 
            this.alertSvcDebug.AutoSize = true;
            this.alertSvcDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertSvcDebug.Location = new System.Drawing.Point(349, 59);
            this.alertSvcDebug.Name = "alertSvcDebug";
            this.alertSvcDebug.Size = new System.Drawing.Size(121, 20);
            this.alertSvcDebug.TabIndex = 4;
            this.alertSvcDebug.Text = "Alerting Service";
            this.alertSvcDebug.UseVisualStyleBackColor = true;
            this.alertSvcDebug.CheckedChanged += new System.EventHandler(this.alertSvc_checkChanged);
            // 
            // inventoryDebugLog
            // 
            this.inventoryDebugLog.AutoSize = true;
            this.inventoryDebugLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryDebugLog.Location = new System.Drawing.Point(6, 59);
            this.inventoryDebugLog.Name = "inventoryDebugLog";
            this.inventoryDebugLog.Size = new System.Drawing.Size(124, 20);
            this.inventoryDebugLog.TabIndex = 1;
            this.inventoryDebugLog.Text = "Inventory Server";
            this.inventoryDebugLog.UseVisualStyleBackColor = true;
            this.inventoryDebugLog.CheckedChanged += new System.EventHandler(this.inventoryDebugLog_CheckedChanged);
            // 
            // activeDTSDebug
            // 
            this.activeDTSDebug.AutoSize = true;
            this.activeDTSDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeDTSDebug.Location = new System.Drawing.Point(349, 21);
            this.activeDTSDebug.Name = "activeDTSDebug";
            this.activeDTSDebug.Size = new System.Drawing.Size(133, 20);
            this.activeDTSDebug.TabIndex = 3;
            this.activeDTSDebug.Text = "Active DTS Rules";
            this.activeDTSDebug.UseVisualStyleBackColor = true;
            this.activeDTSDebug.CheckedChanged += new System.EventHandler(this.activeDTSDebug_CheckedChanged);
            // 
            // webDTSDebug
            // 
            this.webDTSDebug.AutoSize = true;
            this.webDTSDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webDTSDebug.Location = new System.Drawing.Point(176, 21);
            this.webDTSDebug.Name = "webDTSDebug";
            this.webDTSDebug.Size = new System.Drawing.Size(125, 20);
            this.webDTSDebug.TabIndex = 2;
            this.webDTSDebug.Text = "DTS WebMacro";
            this.webDTSDebug.UseVisualStyleBackColor = true;
            this.webDTSDebug.CheckedChanged += new System.EventHandler(this.webDTSDebug_CheckedChanged);
            // 
            // DebugButton
            // 
            this.DebugButton.Location = new System.Drawing.Point(162, 111);
            this.DebugButton.Name = "DebugButton";
            this.DebugButton.Size = new System.Drawing.Size(165, 23);
            this.DebugButton.TabIndex = 0;
            this.DebugButton.Text = "Enable Debug Logs For Above";
            this.DebugButton.UseVisualStyleBackColor = true;
            this.DebugButton.Click += new System.EventHandler(this.DebugButton_Click);
            // 
            // brokerDebug
            // 
            this.brokerDebug.AutoSize = true;
            this.brokerDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brokerDebug.Location = new System.Drawing.Point(176, 59);
            this.brokerDebug.Name = "brokerDebug";
            this.brokerDebug.Size = new System.Drawing.Size(116, 20);
            this.brokerDebug.TabIndex = 7;
            this.brokerDebug.Text = "Broker Service";
            this.brokerDebug.UseVisualStyleBackColor = true;
            this.brokerDebug.CheckedChanged += new System.EventHandler(this.brokerDebug_CheckedChanged);
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.HomePage);
            this.TabMenu.Controls.Add(this.ConfigCheck);
            this.TabMenu.Controls.Add(this.InvCheck);
            this.TabMenu.Controls.Add(this.DBCheck);
            this.TabMenu.Controls.Add(this.ConfigTab);
            this.TabMenu.Location = new System.Drawing.Point(0, 24);
            this.TabMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(498, 496);
            this.TabMenu.TabIndex = 1;
            // 
            // DBCheck
            // 
            this.DBCheck.BackColor = System.Drawing.SystemColors.Control;
            this.DBCheck.Controls.Add(this.panel3);
            this.DBCheck.Controls.Add(this.panel2);
            this.DBCheck.Controls.Add(this.dbProgressBar);
            this.DBCheck.Location = new System.Drawing.Point(4, 22);
            this.DBCheck.Name = "DBCheck";
            this.DBCheck.Size = new System.Drawing.Size(490, 470);
            this.DBCheck.TabIndex = 6;
            this.DBCheck.Text = "Database Maintenance";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.dbCheckAllButton);
            this.panel3.Controls.Add(this.dbTableSizesButton);
            this.panel3.Controls.Add(this.dbFragButton);
            this.panel3.Controls.Add(this.dbDiag);
            this.panel3.Controls.Add(this.dbInfoButton);
            this.panel3.Location = new System.Drawing.Point(3, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 211);
            this.panel3.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(162, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(303, 150);
            this.textBox1.TabIndex = 17;
            // 
            // dbCheckAllButton
            // 
            this.dbCheckAllButton.Location = new System.Drawing.Point(5, 165);
            this.dbCheckAllButton.Name = "dbCheckAllButton";
            this.dbCheckAllButton.Size = new System.Drawing.Size(138, 23);
            this.dbCheckAllButton.TabIndex = 16;
            this.dbCheckAllButton.Text = "Check All";
            this.dbCheckAllButton.UseVisualStyleBackColor = true;
            // 
            // dbTableSizesButton
            // 
            this.dbTableSizesButton.Location = new System.Drawing.Point(5, 122);
            this.dbTableSizesButton.Name = "dbTableSizesButton";
            this.dbTableSizesButton.Size = new System.Drawing.Size(138, 23);
            this.dbTableSizesButton.TabIndex = 15;
            this.dbTableSizesButton.Text = "Check Table Sizes";
            this.dbTableSizesButton.UseVisualStyleBackColor = true;
            // 
            // dbFragButton
            // 
            this.dbFragButton.Location = new System.Drawing.Point(5, 80);
            this.dbFragButton.Name = "dbFragButton";
            this.dbFragButton.Size = new System.Drawing.Size(138, 23);
            this.dbFragButton.TabIndex = 14;
            this.dbFragButton.Text = "Check Fragmentation";
            this.dbFragButton.UseVisualStyleBackColor = true;
            // 
            // dbDiag
            // 
            this.dbDiag.AutoSize = true;
            this.dbDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbDiag.Location = new System.Drawing.Point(145, 0);
            this.dbDiag.Name = "dbDiag";
            this.dbDiag.Size = new System.Drawing.Size(189, 24);
            this.dbDiag.TabIndex = 13;
            this.dbDiag.Text = "Database Diagnostics";
            // 
            // dbInfoButton
            // 
            this.dbInfoButton.Location = new System.Drawing.Point(5, 38);
            this.dbInfoButton.Name = "dbInfoButton";
            this.dbInfoButton.Size = new System.Drawing.Size(138, 23);
            this.dbInfoButton.TabIndex = 12;
            this.dbInfoButton.Text = "Check DB Info";
            this.dbInfoButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ScheduledMaint);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.checkBox8);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 219);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Scheduled Maintenance Tasks";
            // 
            // ScheduledMaint
            // 
            this.ScheduledMaint.FormattingEnabled = true;
            this.ScheduledMaint.Location = new System.Drawing.Point(159, 55);
            this.ScheduledMaint.Name = "ScheduledMaint";
            this.ScheduledMaint.Size = new System.Drawing.Size(175, 147);
            this.ScheduledMaint.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 54);
            this.button2.TabIndex = 34;
            this.button2.Text = "Schedule";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 54);
            this.button1.TabIndex = 33;
            this.button1.Text = "Run Now";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(21, 111);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(95, 17);
            this.checkBox8.TabIndex = 29;
            this.checkBox8.Text = "Purge Auditing";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(21, 65);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(120, 17);
            this.checkBox5.TabIndex = 28;
            this.checkBox5.Text = "Purge Patch History";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(21, 88);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(91, 17);
            this.checkBox3.TabIndex = 26;
            this.checkBox3.Text = "Purge FileInfo";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(21, 134);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Purge Security Activity";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Rebuild Indexes";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Database Maintenance";
            // 
            // dbProgressBar
            // 
            this.dbProgressBar.Location = new System.Drawing.Point(3, 442);
            this.dbProgressBar.Name = "dbProgressBar";
            this.dbProgressBar.Size = new System.Drawing.Size(484, 23);
            this.dbProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dbProgressBar.TabIndex = 11;
            // 
            // ConfigTab
            // 
            this.ConfigTab.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigTab.Controls.Add(this.textBox5);
            this.ConfigTab.Controls.Add(this.nodeCountLabel);
            this.ConfigTab.Location = new System.Drawing.Point(4, 22);
            this.ConfigTab.Name = "ConfigTab";
            this.ConfigTab.Size = new System.Drawing.Size(490, 470);
            this.ConfigTab.TabIndex = 7;
            this.ConfigTab.Text = "Config";
            // 
            // nodeCountLabel
            // 
            this.nodeCountLabel.AutoSize = true;
            this.nodeCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeCountLabel.Location = new System.Drawing.Point(8, 44);
            this.nodeCountLabel.Name = "nodeCountLabel";
            this.nodeCountLabel.Size = new System.Drawing.Size(121, 16);
            this.nodeCountLabel.TabIndex = 0;
            this.nodeCountLabel.Text = "Approx # Of Nodes";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InvCheck.ResumeLayout(false);
            this.ConfigCheck.ResumeLayout(false);
            this.HomePage.ResumeLayout(false);
            this.warningsPanel.ResumeLayout(false);
            this.warningsPanel.PerformLayout();
            this.currentSettingsPanel.ResumeLayout(false);
            this.currentSettingsPanel.PerformLayout();
            this.currentHealthPanel.ResumeLayout(false);
            this.currentHealthPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            this.DBCheck.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ConfigTab.ResumeLayout(false);
            this.ConfigTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void restartSvcsButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ToolTip proxyToolTip;
        private System.Windows.Forms.ToolTip zippedLogsToolTip;
        private System.Windows.Forms.ToolTip logLocationToolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadNewChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateChangeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoUpdateLDDiagToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openSCN;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.TabPage InvCheck;
        private System.Windows.Forms.TabPage ConfigCheck;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.ProgressBar mainProgressBar;
        private System.Windows.Forms.Button restartSvcsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox consoleDebugBox;
        private System.Windows.Forms.CheckBox alertSvcDebug;
        private System.Windows.Forms.CheckBox inventoryDebugLog;
        private System.Windows.Forms.CheckBox activeDTSDebug;
        private System.Windows.Forms.CheckBox webDTSDebug;
        private System.Windows.Forms.Button DebugButton;
        private System.Windows.Forms.CheckBox brokerDebug;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage DBCheck;
        private System.Windows.Forms.ProgressBar inventoryProgressBar;
        private System.Windows.Forms.ProgressBar configProgessBar;
        private System.Windows.Forms.ProgressBar dbProgressBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dbCheckAllButton;
        private System.Windows.Forms.Button dbTableSizesButton;
        private System.Windows.Forms.Button dbFragButton;
        private System.Windows.Forms.Label dbDiag;
        private System.Windows.Forms.Button dbInfoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox ScheduledMaint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel currentSettingsPanel;
        private System.Windows.Forms.Panel currentHealthPanel;
        private System.Windows.Forms.Panel warningsPanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button flushIISButton;
        private System.Windows.Forms.Button archiveLogsButton;
        private System.Windows.Forms.TabPage ConfigTab;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label nodeCountLabel;
    }
}

