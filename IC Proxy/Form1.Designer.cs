namespace IC_Proxy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AppTitle = new System.Windows.Forms.Label();
            this.GetButton = new System.Windows.Forms.Button();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LogTitle = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ServerTitle = new System.Windows.Forms.Label();
            this.PortTitle = new System.Windows.Forms.Label();
            this.SecretTitle = new System.Windows.Forms.Label();
            this.ServerField = new System.Windows.Forms.TextBox();
            this.PortField = new System.Windows.Forms.TextBox();
            this.SecretField = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TGLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("MS Outlook", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.Location = new System.Drawing.Point(12, 9);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(237, 21);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "IC Telegram MTProto Finder";
            this.AppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(12, 174);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(94, 30);
            this.GetButton.TabIndex = 1;
            this.GetButton.Text = "GET Proxy";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.SystemColors.Window;
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.Location = new System.Drawing.Point(187, 63);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.Size = new System.Drawing.Size(321, 185);
            this.LogBox.TabIndex = 2;
            this.LogBox.Text = "";
            // 
            // LogTitle
            // 
            this.LogTitle.AutoSize = true;
            this.LogTitle.Location = new System.Drawing.Point(187, 47);
            this.LogTitle.Name = "LogTitle";
            this.LogTitle.Size = new System.Drawing.Size(36, 13);
            this.LogTitle.TabIndex = 3;
            this.LogTitle.Text = "Logs :";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(112, 174);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(69, 30);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ServerTitle
            // 
            this.ServerTitle.AutoSize = true;
            this.ServerTitle.Location = new System.Drawing.Point(9, 47);
            this.ServerTitle.Name = "ServerTitle";
            this.ServerTitle.Size = new System.Drawing.Size(68, 13);
            this.ServerTitle.TabIndex = 5;
            this.ServerTitle.Text = "Server / IP : ";
            // 
            // PortTitle
            // 
            this.PortTitle.AutoSize = true;
            this.PortTitle.Location = new System.Drawing.Point(9, 88);
            this.PortTitle.Name = "PortTitle";
            this.PortTitle.Size = new System.Drawing.Size(35, 13);
            this.PortTitle.TabIndex = 6;
            this.PortTitle.Text = "Port : ";
            // 
            // SecretTitle
            // 
            this.SecretTitle.AutoSize = true;
            this.SecretTitle.Location = new System.Drawing.Point(9, 129);
            this.SecretTitle.Name = "SecretTitle";
            this.SecretTitle.Size = new System.Drawing.Size(47, 13);
            this.SecretTitle.TabIndex = 7;
            this.SecretTitle.Text = "Secret  :";
            // 
            // ServerField
            // 
            this.ServerField.Location = new System.Drawing.Point(12, 63);
            this.ServerField.Name = "ServerField";
            this.ServerField.Size = new System.Drawing.Size(169, 20);
            this.ServerField.TabIndex = 8;
            // 
            // PortField
            // 
            this.PortField.Location = new System.Drawing.Point(12, 104);
            this.PortField.Name = "PortField";
            this.PortField.Size = new System.Drawing.Size(169, 20);
            this.PortField.TabIndex = 9;
            // 
            // SecretField
            // 
            this.SecretField.Location = new System.Drawing.Point(12, 145);
            this.SecretField.Name = "SecretField";
            this.SecretField.Size = new System.Drawing.Size(169, 20);
            this.SecretField.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 210);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(169, 38);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save Proxy";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TGLink
            // 
            this.TGLink.AutoSize = true;
            this.TGLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGLink.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.TGLink.Location = new System.Drawing.Point(369, 15);
            this.TGLink.Name = "TGLink";
            this.TGLink.Size = new System.Drawing.Size(139, 15);
            this.TGLink.TabIndex = 12;
            this.TGLink.TabStop = true;
            this.TGLink.Text = "Join Developer Channel";
            this.TGLink.Click += new System.EventHandler(this.TGLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 260);
            this.Controls.Add(this.TGLink);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SecretField);
            this.Controls.Add(this.PortField);
            this.Controls.Add(this.ServerField);
            this.Controls.Add(this.SecretTitle);
            this.Controls.Add(this.PortTitle);
            this.Controls.Add(this.ServerTitle);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.LogTitle);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.AppTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IC Proxy - for Microsoft Windows";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Label LogTitle;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label ServerTitle;
        private System.Windows.Forms.Label PortTitle;
        private System.Windows.Forms.Label SecretTitle;
        private System.Windows.Forms.TextBox ServerField;
        private System.Windows.Forms.TextBox PortField;
        private System.Windows.Forms.TextBox SecretField;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.LinkLabel TGLink;
    }
}

