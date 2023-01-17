
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
            this.defualtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloudflareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciscoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shecanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlBoxPnl = new System.Windows.Forms.Panel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ExitBtn = new System.Windows.Forms.ToolStripButton();
            this.MinimizeBtn = new System.Windows.Forms.ToolStripButton();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.BtnPingFormOpen = new System.Windows.Forms.ToolStripButton();
            this.DnsBox = new System.Windows.Forms.ComboBox();
            this.BtnCurrentDns = new System.Windows.Forms.Button();
            this.ConnectionBtn = new System.Windows.Forms.Button();
            this.pingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmStrip.SuspendLayout();
            this.ControlBoxPnl.SuspendLayout();
            this.ToolStrip.SuspendLayout();
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
            this.CmStrip.BackColor = System.Drawing.Color.White;
            this.CmStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CmStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.pingToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.CmStrip.Name = "CmStrip";
            this.CmStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defualtToolStripMenuItem,
            this.cloudflareToolStripMenuItem,
            this.ciscoToolStripMenuItem,
            this.googleToolStripMenuItem,
            this.electroToolStripMenuItem,
            this.shecanToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // defualtToolStripMenuItem
            // 
            this.defualtToolStripMenuItem.Name = "defualtToolStripMenuItem";
            this.defualtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defualtToolStripMenuItem.Text = "Defualt";
            this.defualtToolStripMenuItem.Click += new System.EventHandler(this.defualtToolStripMenuItem_Click);
            // 
            // cloudflareToolStripMenuItem
            // 
            this.cloudflareToolStripMenuItem.Name = "cloudflareToolStripMenuItem";
            this.cloudflareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cloudflareToolStripMenuItem.Text = "Cloudflare";
            this.cloudflareToolStripMenuItem.Click += new System.EventHandler(this.cloudflareToolStripMenuItem_Click);
            // 
            // ciscoToolStripMenuItem
            // 
            this.ciscoToolStripMenuItem.Name = "ciscoToolStripMenuItem";
            this.ciscoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ciscoToolStripMenuItem.Text = "Cisco";
            this.ciscoToolStripMenuItem.Click += new System.EventHandler(this.ciscoToolStripMenuItem_Click);
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.googleToolStripMenuItem.Text = "Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // electroToolStripMenuItem
            // 
            this.electroToolStripMenuItem.Name = "electroToolStripMenuItem";
            this.electroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.electroToolStripMenuItem.Text = "Electro";
            this.electroToolStripMenuItem.Click += new System.EventHandler(this.electroToolStripMenuItem_Click);
            // 
            // shecanToolStripMenuItem
            // 
            this.shecanToolStripMenuItem.Name = "shecanToolStripMenuItem";
            this.shecanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shecanToolStripMenuItem.Text = "toolStripMenuItem1";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            "Shecan",
            "Custom"});
            this.DnsBox.Location = new System.Drawing.Point(12, 43);
            this.DnsBox.Name = "DnsBox";
            this.DnsBox.Size = new System.Drawing.Size(178, 21);
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
            this.ConnectionBtn.Click += new System.EventHandler(this.ConnectionBtn_Click);
            // 
            // pingToolStripMenuItem
            // 
            this.pingToolStripMenuItem.Name = "pingToolStripMenuItem";
            this.pingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pingToolStripMenuItem.Text = "Ping";
            this.pingToolStripMenuItem.Click += new System.EventHandler(this.pingToolStripMenuItem_Click);
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
            this.Move += new System.EventHandler(this.ConnectMe_Move);
            this.Resize += new System.EventHandler(this.ConnectMe_Resize);
            this.CmStrip.ResumeLayout(false);
            this.ControlBoxPnl.ResumeLayout(false);
            this.ControlBoxPnl.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Panel ControlBoxPnl;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton ExitBtn;
        private System.Windows.Forms.ToolStripButton MinimizeBtn;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ComboBox DnsBox;
        private System.Windows.Forms.ToolStripButton BtnPingFormOpen;
        private System.Windows.Forms.Button BtnCurrentDns;
        private System.Windows.Forms.Button ConnectionBtn;
        private System.Windows.Forms.ContextMenuStrip CmStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defualtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloudflareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciscoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shecanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pingToolStripMenuItem;
    }
}

