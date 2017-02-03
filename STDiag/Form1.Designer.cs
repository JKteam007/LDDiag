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
            this.LicenseCheckPage = new System.Windows.Forms.TabPage();
            this.LogCheckPage = new System.Windows.Forms.TabPage();
            this.ConfigCheckPage = new System.Windows.Forms.TabPage();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.proxyCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.TestGridView = new System.Windows.Forms.DataGridView();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.logLocationTextBox = new System.Windows.Forms.TextBox();
            this.proxyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.zippedLogsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.logLocationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.configToolStrpButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.LogCheckPage.SuspendLayout();
            this.ConfigCheckPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.menuToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LicenseCheckPage
            // 
            this.LicenseCheckPage.BackColor = System.Drawing.SystemColors.Control;
            this.LicenseCheckPage.Location = new System.Drawing.Point(4, 22);
            this.LicenseCheckPage.Name = "LicenseCheckPage";
            this.LicenseCheckPage.Size = new System.Drawing.Size(490, 470);
            this.LicenseCheckPage.TabIndex = 3;
            this.LicenseCheckPage.Text = "License Console";
            // 
            // LogCheckPage
            // 
            this.LogCheckPage.BackColor = System.Drawing.SystemColors.Control;
            this.LogCheckPage.Controls.Add(this.textBox3);
            this.LogCheckPage.Controls.Add(this.checkBox1);
            this.LogCheckPage.Controls.Add(this.label3);
            this.LogCheckPage.Controls.Add(this.logLocationTextBox);
            this.LogCheckPage.Location = new System.Drawing.Point(4, 22);
            this.LogCheckPage.Name = "LogCheckPage";
            this.LogCheckPage.Size = new System.Drawing.Size(490, 470);
            this.LogCheckPage.TabIndex = 2;
            this.LogCheckPage.Text = "Log Analyzer";
            // 
            // ConfigCheckPage
            // 
            this.ConfigCheckPage.BackColor = System.Drawing.SystemColors.Control;
            this.ConfigCheckPage.Controls.Add(this.textBox2);
            this.ConfigCheckPage.Controls.Add(this.textBox1);
            this.ConfigCheckPage.Controls.Add(this.label2);
            this.ConfigCheckPage.Controls.Add(this.label1);
            this.ConfigCheckPage.Controls.Add(this.stopButton);
            this.ConfigCheckPage.Controls.Add(this.passwordTextBox);
            this.ConfigCheckPage.Controls.Add(this.usernameTextBox);
            this.ConfigCheckPage.Controls.Add(this.passwordLabel);
            this.ConfigCheckPage.Controls.Add(this.usernameLabel);
            this.ConfigCheckPage.Controls.Add(this.proxyCheckBox);
            this.ConfigCheckPage.Controls.Add(this.startButton);
            this.ConfigCheckPage.Controls.Add(this.TestGridView);
            this.ConfigCheckPage.Location = new System.Drawing.Point(4, 22);
            this.ConfigCheckPage.Name = "ConfigCheckPage";
            this.ConfigCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigCheckPage.Size = new System.Drawing.Size(490, 470);
            this.ConfigCheckPage.TabIndex = 1;
            this.ConfigCheckPage.Text = "Config Checker";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(311, 15);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(150, 20);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(81, 15);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 20);
            this.usernameTextBox.TabIndex = 7;
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
            // proxyCheckBox
            // 
            this.proxyCheckBox.AutoSize = true;
            this.proxyCheckBox.Location = new System.Drawing.Point(6, 92);
            this.proxyCheckBox.Name = "proxyCheckBox";
            this.proxyCheckBox.Size = new System.Drawing.Size(95, 17);
            this.proxyCheckBox.TabIndex = 4;
            this.proxyCheckBox.Text = "Proxy Override";
            this.proxyToolTip.SetToolTip(this.proxyCheckBox, "Overrides the auto-detected proxy settings");
            this.proxyCheckBox.UseVisualStyleBackColor = true;
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
            this.TabMenu.Controls.Add(this.LicenseCheckPage);
            this.TabMenu.Location = new System.Drawing.Point(0, 27);
            this.TabMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(498, 496);
            this.TabMenu.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Proxy Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Proxy Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(334, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 13;
            // 
            // logLocationTextBox
            // 
            this.logLocationTextBox.Location = new System.Drawing.Point(99, 48);
            this.logLocationTextBox.Name = "logLocationTextBox";
            this.logLocationTextBox.ReadOnly = true;
            this.logLocationTextBox.Size = new System.Drawing.Size(383, 20);
            this.logLocationTextBox.TabIndex = 8;
            this.logLocationTextBox.Text = "C:\\ProgramData\\Landesk\\Shavlik Protect\\Logs";
            this.logLocationToolTip.SetToolTip(this.logLocationTextBox, "Must be a valid local path or UNC path");
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Log Location";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Analyze Zipped Logs";
            this.zippedLogsToolTip.SetToolTip(this.checkBox1, "Check to specify a .zip file instead of the default logging directory");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(3, 97);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(484, 369);
            this.textBox3.TabIndex = 11;
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.AllowMerge = false;
            this.menuToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuToolStrip.AutoSize = false;
            this.menuToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.menuToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuToolStrip.CanOverflow = false;
            this.menuToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuToolStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripButton,
            this.configToolStrpButton});
            this.menuToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuToolStrip.Location = new System.Drawing.Point(0, 2);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuToolStrip.Size = new System.Drawing.Size(498, 25);
            this.menuToolStrip.Stretch = true;
            this.menuToolStrip.TabIndex = 3;
            // 
            // fileToolStripButton
            // 
            this.fileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripButton.Image")));
            this.fileToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripButton.Name = "fileToolStripButton";
            this.fileToolStripButton.Size = new System.Drawing.Size(38, 19);
            this.fileToolStripButton.Text = "File";
            // 
            // configToolStrpButton
            // 
            this.configToolStrpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.configToolStrpButton.Image = ((System.Drawing.Image)(resources.GetObject("configToolStrpButton.Image")));
            this.configToolStrpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configToolStrpButton.Name = "configToolStrpButton";
            this.configToolStrpButton.Size = new System.Drawing.Size(73, 19);
            this.configToolStrpButton.Text = "Configure";
            this.configToolStrpButton.Click += new System.EventHandler(this.configToolStrpButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(498, 523);
            this.Controls.Add(this.menuToolStrip);
            this.Controls.Add(this.TabMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(514, 562);
            this.MinimumSize = new System.Drawing.Size(514, 562);
            this.Name = "MainWindow";
            this.Text = "STConsole";
            this.LogCheckPage.ResumeLayout(false);
            this.LogCheckPage.PerformLayout();
            this.ConfigCheckPage.ResumeLayout(false);
            this.ConfigCheckPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestGridView)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage LicenseCheckPage;
        private System.Windows.Forms.TabPage LogCheckPage;
        private System.Windows.Forms.TabPage ConfigCheckPage;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.CheckBox proxyCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataGridView TestGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox logLocationTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip proxyToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolTip zippedLogsToolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolTip logLocationToolTip;
        private System.Windows.Forms.ToolStrip menuToolStrip;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton configToolStrpButton;
    }
}

