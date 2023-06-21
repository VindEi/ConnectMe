
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
            this.CmStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectCmStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.defualtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Item5 = new System.Windows.Forms.ToolStripMenuItem();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExitBtn = new System.Windows.Forms.ToolStripButton();
            this.MinimizeBtn = new System.Windows.Forms.ToolStripButton();
            this.SettingBtn = new System.Windows.Forms.ToolStripButton();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.BtnPingFormOpen = new System.Windows.Forms.ToolStripButton();
            this.DnsBox = new System.Windows.Forms.ComboBox();
            this.BtnCurrentDns = new System.Windows.Forms.Button();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmStrip.SuspendLayout();
            this.ConnectCmStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.CmStrip;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "ConnectMe";
            this.NotifyIcon.Click += new System.EventHandler(this.NotifyIcon_Click);
            this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // CmStrip
            // 
            this.CmStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.CmStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.pingToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CmStrip.Name = "CmStrip";
            this.CmStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CmStrip.ShowImageMargin = false;
            this.CmStrip.Size = new System.Drawing.Size(95, 92);
            this.CmStrip.Opening += new System.ComponentModel.CancelEventHandler(this.CmStrip_Opening);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectToolStripMenuItem.DropDown = this.ConnectCmStrip;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // ConnectCmStrip
            // 
            this.ConnectCmStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(74)))), ((int)(((byte)(86)))));
            this.ConnectCmStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ConnectCmStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ConnectCmStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defualtToolStripMenuItem,
            this.Item1,
            this.Item2,
            this.Item3,
            this.Item4,
            this.Item5});
            this.ConnectCmStrip.Name = "CmStrip";
            this.ConnectCmStrip.OwnerItem = this.connectToolStripMenuItem;
            this.ConnectCmStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ConnectCmStrip.ShowImageMargin = false;
            this.ConnectCmStrip.Size = new System.Drawing.Size(88, 136);
            // 
            // defualtToolStripMenuItem
            // 
            this.defualtToolStripMenuItem.Name = "defualtToolStripMenuItem";
            this.defualtToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.defualtToolStripMenuItem.Text = "Default";
            this.defualtToolStripMenuItem.Click += new System.EventHandler(this.defualtToolStripMenuItem_Click);
            // 
            // Item1
            // 
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(87, 22);
            this.Item1.Text = "Item1";
            this.Item1.Click += new System.EventHandler(this.Item1_Click);
            // 
            // Item2
            // 
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(87, 22);
            this.Item2.Text = "Item2";
            this.Item2.Click += new System.EventHandler(this.Item2_Click);
            // 
            // Item3
            // 
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(87, 22);
            this.Item3.Text = "Item3";
            this.Item3.Click += new System.EventHandler(this.Item3_Click);
            // 
            // Item4
            // 
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(87, 22);
            this.Item4.Text = "Item4";
            this.Item4.Click += new System.EventHandler(this.Item4_Click);
            // 
            // Item5
            // 
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(87, 22);
            this.Item5.Text = "Item5";
            this.Item5.Click += new System.EventHandler(this.Item5_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.MainToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitBtn,
            this.MinimizeBtn,
            this.SettingBtn,
            this.Separator,
            this.BtnPingFormOpen});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainToolStrip.Size = new System.Drawing.Size(202, 25);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolStrip_ItemClicked);
            this.MainToolStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ToolStrip_MouseDown);
            // 
            // ExitBtn
            // 
            this.ExitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExitBtn.Image = global::ConnectMe.Properties.Resources.Logout_16;
            this.ExitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(23, 22);
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MinimizeBtn.Image = global::ConnectMe.Properties.Resources.Compress_16;
            this.MinimizeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(23, 22);
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingBtn.Image = global::ConnectMe.Properties.Resources.settings_144px;
            this.SettingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(23, 22);
            this.SettingBtn.Text = "Setting";
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(6, 25);
            // 
            // BtnPingFormOpen
            // 
            this.BtnPingFormOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnPingFormOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPingFormOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnPingFormOpen.Image")));
            this.BtnPingFormOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPingFormOpen.Name = "BtnPingFormOpen";
            this.BtnPingFormOpen.Size = new System.Drawing.Size(35, 22);
            this.BtnPingFormOpen.Text = "Ping";
            this.BtnPingFormOpen.Click += new System.EventHandler(this.BtnPingFormOpen_Click);
            // 
            // DnsBox
            // 
            this.DnsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.DnsBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DnsBox.ForeColor = System.Drawing.Color.Black;
            this.DnsBox.FormattingEnabled = true;
            this.DnsBox.Location = new System.Drawing.Point(12, 43);
            this.DnsBox.Name = "DnsBox";
            this.DnsBox.Size = new System.Drawing.Size(178, 21);
            this.DnsBox.TabIndex = 10;
            this.DnsBox.SelectedIndexChanged += new System.EventHandler(this.DnsBox_SelectedIndexChanged);
            // 
            // BtnCurrentDns
            // 
            this.BtnCurrentDns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.BtnCurrentDns.FlatAppearance.BorderSize = 0;
            this.BtnCurrentDns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCurrentDns.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCurrentDns.Location = new System.Drawing.Point(0, 160);
            this.BtnCurrentDns.Name = "BtnCurrentDns";
            this.BtnCurrentDns.Size = new System.Drawing.Size(202, 23);
            this.BtnCurrentDns.TabIndex = 12;
            this.BtnCurrentDns.Text = "Refresh";
            this.BtnCurrentDns.UseVisualStyleBackColor = false;
            this.BtnCurrentDns.Click += new System.EventHandler(this.BtnCurrentDns_Click);
            // 
            // ConnectionBtn
            // 
            this.ConnectionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(110)))), ((int)(((byte)(142)))));
            this.ConnectionBtn.FlatAppearance.BorderSize = 0;
            this.ConnectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectionBtn.ForeColor = System.Drawing.Color.White;
            this.ConnectionBtn.Location = new System.Drawing.Point(52, 203);
            this.ConnectionBtn.Name = "ConnectionBtn";
            this.ConnectionBtn.Size = new System.Drawing.Size(101, 50);
            this.ConnectionBtn.TabIndex = 13;
            this.ConnectionBtn.Text = "Connect";
            this.ConnectionBtn.UseVisualStyleBackColor = false;
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 23);
            this.panel1.TabIndex = 14;
            // 
            // ConnectMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(202, 277);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnectionBtn);
            this.Controls.Add(this.BtnCurrentDns);
            this.Controls.Add(this.DnsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectMe";
            this.Text = "ConnectMe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectMe_FormClosing);
            this.Load += new System.EventHandler(this.ConnectMe_Load);
            this.Move += new System.EventHandler(this.ConnectMe_Move);
            this.Resize += new System.EventHandler(this.ConnectMe_Resize);
            this.CmStrip.ResumeLayout(false);
            this.ConnectCmStrip.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ExitBtn;
        private System.Windows.Forms.ToolStripButton MinimizeBtn;
        private System.Windows.Forms.ToolStripButton SettingBtn;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripButton BtnPingFormOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem defualtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Item1;
        private System.Windows.Forms.ToolStripMenuItem Item2;
        private System.Windows.Forms.ToolStripMenuItem Item3;
        private System.Windows.Forms.ToolStripMenuItem Item4;
        private System.Windows.Forms.ToolStripMenuItem Item5;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.ComboBox DnsBox;
        private System.Windows.Forms.Button BtnCurrentDns;
        private System.Windows.Forms.ContextMenuStrip CmStrip;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ContextMenuStrip ConnectCmStrip;
    }
}

