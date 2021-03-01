namespace RCPSystems
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.tsbUsers = new System.Windows.Forms.ToolStripButton();
            this.tsbTimeAtt = new System.Windows.Forms.ToolStripButton();
            this.tsbDay = new System.Windows.Forms.ToolStripButton();
            this.tsbHarmo = new System.Windows.Forms.ToolStripButton();
            this.tsbDict = new System.Windows.Forms.ToolStripButton();
            this.tsbManage = new System.Windows.Forms.ToolStripButton();
            this.tsbTA = new System.Windows.Forms.ToolStripButton();
            this.tsbOrder = new System.Windows.Forms.ToolStripButton();
            this.tsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.AutoSize = false;
            this.tsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsers,
            this.tsbTimeAtt,
            this.tsbDay,
            this.tsbHarmo,
            this.tsbDict,
            this.tsbManage,
            this.tsbTA,
            this.tsbOrder});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(1434, 75);
            this.tsMainMenu.TabIndex = 1;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // tsbUsers
            // 
            this.tsbUsers.AutoSize = false;
            this.tsbUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUsers.Enabled = false;
            this.tsbUsers.Image = global::RCPSystems.Properties.Resources.User;
            this.tsbUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsers.Name = "tsbUsers";
            this.tsbUsers.Size = new System.Drawing.Size(72, 72);
            this.tsbUsers.Text = "Użytkownicy";
            this.tsbUsers.Click += new System.EventHandler(this.tsbUsers_Click);
            // 
            // tsbTimeAtt
            // 
            this.tsbTimeAtt.AutoSize = false;
            this.tsbTimeAtt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTimeAtt.Enabled = false;
            this.tsbTimeAtt.Image = global::RCPSystems.Properties.Resources.Clock;
            this.tsbTimeAtt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTimeAtt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTimeAtt.Name = "tsbTimeAtt";
            this.tsbTimeAtt.Size = new System.Drawing.Size(72, 72);
            this.tsbTimeAtt.Text = "Czas pracy";
            this.tsbTimeAtt.Click += new System.EventHandler(this.tsbTimeAtt_Click);
            // 
            // tsbDay
            // 
            this.tsbDay.AutoSize = false;
            this.tsbDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDay.Enabled = false;
            this.tsbDay.Image = global::RCPSystems.Properties.Resources.Calender;
            this.tsbDay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDay.Name = "tsbDay";
            this.tsbDay.Size = new System.Drawing.Size(72, 72);
            this.tsbDay.Text = "Dniówki";
            this.tsbDay.Click += new System.EventHandler(this.tsbDay_Click);
            // 
            // tsbHarmo
            // 
            this.tsbHarmo.AutoSize = false;
            this.tsbHarmo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHarmo.Enabled = false;
            this.tsbHarmo.Image = global::RCPSystems.Properties.Resources.Paste;
            this.tsbHarmo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHarmo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHarmo.Name = "tsbHarmo";
            this.tsbHarmo.Size = new System.Drawing.Size(72, 72);
            this.tsbHarmo.Text = "Harmonogramy";
            this.tsbHarmo.Click += new System.EventHandler(this.tsbHarmo_Click);
            // 
            // tsbDict
            // 
            this.tsbDict.AutoSize = false;
            this.tsbDict.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDict.Enabled = false;
            this.tsbDict.Image = global::RCPSystems.Properties.Resources.Address_Book;
            this.tsbDict.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDict.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDict.Name = "tsbDict";
            this.tsbDict.Size = new System.Drawing.Size(72, 72);
            this.tsbDict.Text = "Słowniki";
            this.tsbDict.Click += new System.EventHandler(this.tsbDict_Click);
            // 
            // tsbManage
            // 
            this.tsbManage.AutoSize = false;
            this.tsbManage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbManage.Enabled = false;
            this.tsbManage.Image = global::RCPSystems.Properties.Resources.Tools;
            this.tsbManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbManage.Name = "tsbManage";
            this.tsbManage.Size = new System.Drawing.Size(72, 72);
            this.tsbManage.Text = "Konfiguracja";
            this.tsbManage.Click += new System.EventHandler(this.tsbManage_Click);
            // 
            // tsbTA
            // 
            this.tsbTA.AutoSize = false;
            this.tsbTA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTA.Enabled = false;
            this.tsbTA.Image = global::RCPSystems.Properties.Resources.Stationery;
            this.tsbTA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbTA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTA.Name = "tsbTA";
            this.tsbTA.Size = new System.Drawing.Size(72, 72);
            this.tsbTA.Text = "Czas pracy";
            this.tsbTA.Click += new System.EventHandler(this.tsbTA_Click);
            // 
            // tsbOrder
            // 
            this.tsbOrder.AutoSize = false;
            this.tsbOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOrder.Enabled = false;
            this.tsbOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrder.Image")));
            this.tsbOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrder.Name = "tsbOrder";
            this.tsbOrder.Size = new System.Drawing.Size(68, 72);
            this.tsbOrder.Text = "Zamówienia";
            this.tsbOrder.Click += new System.EventHandler(this.tsbOrder_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 791);
            this.Controls.Add(this.tsMainMenu);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "RCP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton tsbUsers;
        private System.Windows.Forms.ToolStripButton tsbTimeAtt;
        private System.Windows.Forms.ToolStripButton tsbDay;
        private System.Windows.Forms.ToolStripButton tsbHarmo;
        private System.Windows.Forms.ToolStripButton tsbDict;
        private System.Windows.Forms.ToolStripButton tsbManage;
        private System.Windows.Forms.ToolStripButton tsbTA;
        private System.Windows.Forms.ToolStripButton tsbOrder;
    }
}

