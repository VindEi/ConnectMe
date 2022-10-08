
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
            this.SecendDnstxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.MainDnsTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ConnectBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // SecendDnstxt
            // 
            this.SecendDnstxt.Location = new System.Drawing.Point(13, 62);
            this.SecendDnstxt.Name = "SecendDnstxt";
            this.SecendDnstxt.Size = new System.Drawing.Size(100, 23);
            this.SecendDnstxt.TabIndex = 9;
            this.SecendDnstxt.Text = "149.112.112.112";
            // 
            // MainDnsTxt
            // 
            this.MainDnsTxt.Location = new System.Drawing.Point(13, 33);
            this.MainDnsTxt.Name = "MainDnsTxt";
            this.MainDnsTxt.Size = new System.Drawing.Size(100, 23);
            this.MainDnsTxt.TabIndex = 8;
            this.MainDnsTxt.Text = "9.9.9.9";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom3;
            this.ConnectBtn.Location = new System.Drawing.Point(28, 111);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.ConnectBtn.Size = new System.Drawing.Size(65, 25);
            this.ConnectBtn.TabIndex = 10;
            this.ConnectBtn.Values.Text = "Connect";
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Custom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(125, 158);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.SecendDnstxt);
            this.Controls.Add(this.MainDnsTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Custom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Custom_FormClosed);
            this.Load += new System.EventHandler(this.Custom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox SecendDnstxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox MainDnsTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ConnectBtn;
    }
}