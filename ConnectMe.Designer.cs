
namespace ConnectMe
{
    partial class ConnectMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectMe));
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ControlBoxPnl = new System.Windows.Forms.Panel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExitBtn = new System.Windows.Forms.ToolStripButton();
            this.MinimizeBtn = new System.Windows.Forms.ToolStripButton();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.HIdeToTray = new System.Windows.Forms.ToolStripButton();
            this.BtnOpenUptadeFrm = new System.Windows.Forms.ToolStripButton();
            this.BtnPingFormOpen = new System.Windows.Forms.ToolStripButton();
            this.DnsBox = new System.Windows.Forms.ComboBox();
            this.BtnCurrentDns = new System.Windows.Forms.Button();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.CmStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlBoxPnl.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.CmStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.CmStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "ConnectMe";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // ControlBoxPnl
            // 
            this.ControlBoxPnl.BackColor = System.Drawing.Color.Gray;
            this.ControlBoxPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlBoxPnl.Controls.Add(this.ToolStrip);
            this.ControlBoxPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBoxPnl.Location = new System.Drawing.Point(0, 0);
            this.ControlBoxPnl.Name = "ControlBoxPnl";
            this.ControlBoxPnl.Size = new System.Drawing.Size(202, 21);
            this.ControlBoxPnl.TabIndex = 9;
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitBtn,
            this.MinimizeBtn,
            this.Separator,
            this.HIdeToTray,
            this.BtnOpenUptadeFrm,
            this.BtnPingFormOpen});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip.Size = new System.Drawing.Size(200, 23);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
            this.ToolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitBtn.Image = global::ConnectMe.Properties.Resources.Logout_16;
            this.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(23, 20);
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MinimizeBtn.Image = global::ConnectMe.Properties.Resources.Compress_16;
            this.MinimizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(23, 20);
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(6, 23);
            // 
            // HIdeToTray
            // 
            this.HIdeToTray.BackColor = System.Drawing.Color.Transparent;
            this.HIdeToTray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HIdeToTray.Image = global::ConnectMe.Properties.Resources.Pin_16;
            this.HIdeToTray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HIdeToTray.Name = "HIdeToTray";
            this.HIdeToTray.Size = new System.Drawing.Size(23, 20);
            this.HIdeToTray.Click += new System.EventHandler(this.HIdeToTray_Click);
            // 
            // BtnOpenUptadeFrm
            // 
            this.BtnOpenUptadeFrm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnOpenUptadeFrm.Image = global::ConnectMe.Properties.Resources.Update_16;
            this.BtnOpenUptadeFrm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOpenUptadeFrm.Name = "BtnOpenUptadeFrm";
            this.BtnOpenUptadeFrm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnOpenUptadeFrm.Size = new System.Drawing.Size(23, 20);
            this.BtnOpenUptadeFrm.Click += new System.EventHandler(this.BtnOpenUptadeFrm_Click);
            // 
            // BtnPingFormOpen
            // 
            this.BtnPingFormOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnPingFormOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPingFormOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnPingFormOpen.Image")));
            this.BtnPingFormOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPingFormOpen.Name = "BtnPingFormOpen";
            this.BtnPingFormOpen.Size = new System.Drawing.Size(35, 19);
            this.BtnPingFormOpen.Text = "Ping";
            this.BtnPingFormOpen.Click += new System.EventHandler(this.BtnPingFormOpen_Click);
            // 
            // DnsBox
            // 
            this.DnsBox.FormattingEnabled = true;
            this.DnsBox.Items.AddRange(new object[] {
            "Cloudflare",
            "Cisco",
            "Google",
            "Electro",
            "Custom"});
            this.DnsBox.Location = new System.Drawing.Point(49, 41);
            this.DnsBox.Name = "DnsBox";
            this.DnsBox.Size = new System.Drawing.Size(114, 21);
            this.DnsBox.TabIndex = 10;
            // 
            // BtnCurrentDns
            // 
            this.BtnCurrentDns.Location = new System.Drawing.Point(1, 160);
            this.BtnCurrentDns.Name = "BtnCurrentDns";
            this.BtnCurrentDns.Size = new System.Drawing.Size(199, 23);
            this.BtnCurrentDns.TabIndex = 12;
            this.BtnCurrentDns.Text = "Refresh";
            this.BtnCurrentDns.UseVisualStyleBackColor = true;
            this.BtnCurrentDns.Click += new System.EventHandler(this.BtnCurrentDns_Click);
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.Location = new System.Drawing.Point(49, 199);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(114, 53);
            this.ConnectionBtn.TabIndex = 13;
            this.ConnectionBtn.Text = "Connect";
            this.ConnectionBtn.UseVisualStyleBackColor = true;
            // 
            // CmStrip
            // 
            this.CmStrip.BackColor = System.Drawing.Color.White;
            this.CmStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CmStrip.Name = "CmStrip";
            this.CmStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ConnectMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(202, 277);
            this.Controls.Add(this.ConnectionBtn);
            this.Controls.Add(this.BtnCurrentDns);
            this.Controls.Add(this.DnsBox);
            this.Controls.Add(this.ControlBoxPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectMe";
            this.Text = "ConnectMe";
            this.Load += new System.EventHandler(this.ConnectMe_Load);
            this.ControlBoxPnl.ResumeLayout(false);
            this.ControlBoxPnl.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.CmStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Panel ControlBoxPnl;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ExitBtn;
        private System.Windows.Forms.ToolStripButton MinimizeBtn;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripButton HIdeToTray;
        private System.Windows.Forms.ComboBox DnsBox;
        private System.Windows.Forms.ToolStripButton BtnPingFormOpen;
        private System.Windows.Forms.Button BtnCurrentDns;
        private System.Windows.Forms.ToolStripButton BtnOpenUptadeFrm;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.ContextMenuStrip CmStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

