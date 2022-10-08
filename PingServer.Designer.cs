namespace ConnectMe
{
    partial class PingServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingServer));
            this.BtnCheckPing = new System.Windows.Forms.Button();
            this.ServerAddresslbl = new System.Windows.Forms.Label();
            this.TxtHost = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCheckPing
            // 
            this.BtnCheckPing.Location = new System.Drawing.Point(54, 51);
            this.BtnCheckPing.Name = "BtnCheckPing";
            this.BtnCheckPing.Size = new System.Drawing.Size(75, 44);
            this.BtnCheckPing.TabIndex = 1;
            this.BtnCheckPing.Text = "Ping";
            this.BtnCheckPing.UseVisualStyleBackColor = true;
            this.BtnCheckPing.Click += new System.EventHandler(this.BtnCheckPing_Click);
            // 
            // ServerAddresslbl
            // 
            this.ServerAddresslbl.AutoSize = true;
            this.ServerAddresslbl.Location = new System.Drawing.Point(12, 9);
            this.ServerAddresslbl.Name = "ServerAddresslbl";
            this.ServerAddresslbl.Size = new System.Drawing.Size(85, 13);
            this.ServerAddresslbl.TabIndex = 3;
            this.ServerAddresslbl.Text = "Server Address :";
            // 
            // TxtHost
            // 
            this.TxtHost.AllowDrop = true;
            this.TxtHost.Location = new System.Drawing.Point(38, 25);
            this.TxtHost.Name = "TxtHost";
            this.TxtHost.Size = new System.Drawing.Size(100, 20);
            this.TxtHost.TabIndex = 4;
            this.TxtHost.Text = "Google.com";
            this.TxtHost.TextChanged += new System.EventHandler(this.TxtHost_TextChanged);
            this.TxtHost.Validated += new System.EventHandler(this.TxtHost_Validated);
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResult.Location = new System.Drawing.Point(0, 110);
            this.lblResult.Multiline = true;
            this.lblResult.Name = "lblResult";
            this.lblResult.ReadOnly = true;
            this.lblResult.Size = new System.Drawing.Size(179, 62);
            this.lblResult.TabIndex = 5;
            // 
            // PingServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(179, 172);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.TxtHost);
            this.Controls.Add(this.ServerAddresslbl);
            this.Controls.Add(this.BtnCheckPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PingServer";
            this.Text = "PingServer";
            this.Load += new System.EventHandler(this.PingServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCheckPing;
        private System.Windows.Forms.Label ServerAddresslbl;
        private System.Windows.Forms.TextBox TxtHost;
        private System.Windows.Forms.TextBox lblResult;
    }
}