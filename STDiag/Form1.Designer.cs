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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FileDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.ConfigCheckPage = new System.Windows.Forms.TabPage();
            this.LogCheckPage = new System.Windows.Forms.TabPage();
            this.LicenseCheckPage = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.TabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDown});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FileDropDown
            // 
            this.FileDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileDropDown.Image = ((System.Drawing.Image)(resources.GetObject("FileDropDown.Image")));
            this.FileDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileDropDown.Name = "FileDropDown";
            this.FileDropDown.Size = new System.Drawing.Size(38, 22);
            this.FileDropDown.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.HomePage);
            this.TabMenu.Controls.Add(this.ConfigCheckPage);
            this.TabMenu.Controls.Add(this.LogCheckPage);
            this.TabMenu.Controls.Add(this.LicenseCheckPage);
            this.TabMenu.Controls.Add(this.tabPage3);
            this.TabMenu.Controls.Add(this.tabPage4);
            this.TabMenu.Controls.Add(this.tabPage5);
            this.TabMenu.Location = new System.Drawing.Point(0, 28);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(498, 495);
            this.TabMenu.TabIndex = 1;
            // 
            // HomePage
            // 
            this.HomePage.Location = new System.Drawing.Point(4, 22);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(490, 469);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // ConfigCheckPage
            // 
            this.ConfigCheckPage.Location = new System.Drawing.Point(4, 22);
            this.ConfigCheckPage.Name = "ConfigCheckPage";
            this.ConfigCheckPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConfigCheckPage.Size = new System.Drawing.Size(490, 469);
            this.ConfigCheckPage.TabIndex = 1;
            this.ConfigCheckPage.Text = "Config Check";
            this.ConfigCheckPage.UseVisualStyleBackColor = true;
            // 
            // LogCheckPage
            // 
            this.LogCheckPage.Location = new System.Drawing.Point(4, 22);
            this.LogCheckPage.Name = "LogCheckPage";
            this.LogCheckPage.Size = new System.Drawing.Size(490, 469);
            this.LogCheckPage.TabIndex = 2;
            this.LogCheckPage.Text = "Log Check";
            this.LogCheckPage.UseVisualStyleBackColor = true;
            // 
            // LicenseCheckPage
            // 
            this.LicenseCheckPage.Location = new System.Drawing.Point(4, 22);
            this.LicenseCheckPage.Name = "LicenseCheckPage";
            this.LicenseCheckPage.Size = new System.Drawing.Size(490, 469);
            this.LicenseCheckPage.TabIndex = 3;
            this.LicenseCheckPage.Text = "License Check";
            this.LicenseCheckPage.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(490, 469);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(490, 469);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(490, 469);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 524);
            this.Controls.Add(this.TabMenu);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainWindow";
            this.Text = "Shavlik Diagnostic Tool";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TabMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FileDropDown;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage ConfigCheckPage;
        private System.Windows.Forms.TabPage LogCheckPage;
        private System.Windows.Forms.TabPage LicenseCheckPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

