namespace ConnectMe
{
    partial class Custom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Custom));
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.MainDnsTxt = new System.Windows.Forms.TextBox();
            this.SecendDnstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(12, 83);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(96, 34);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.CustomBtn_Click);
            // 
            // MainDnsTxt
            // 
            this.MainDnsTxt.Location = new System.Drawing.Point(8, 12);
            this.MainDnsTxt.Name = "MainDnsTxt";
            this.MainDnsTxt.Size = new System.Drawing.Size(100, 20);
            this.MainDnsTxt.TabIndex = 1;
            // 
            // SecendDnstxt
            // 
            this.SecendDnstxt.Location = new System.Drawing.Point(8, 38);
            this.SecendDnstxt.Name = "SecendDnstxt";
            this.SecendDnstxt.Size = new System.Drawing.Size(100, 20);
            this.SecendDnstxt.TabIndex = 2;
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(120, 128);
            this.Controls.Add(this.SecendDnstxt);
            this.Controls.Add(this.MainDnsTxt);
            this.Controls.Add(this.ConnectBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Custom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Dns";
            this.Load += new System.EventHandler(this.Custom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox MainDnsTxt;
        private System.Windows.Forms.TextBox SecendDnstxt;
    }
}