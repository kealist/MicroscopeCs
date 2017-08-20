namespace MicroscopeUI
{
    partial class MicroscopeGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MicroscopeGameForm));
            this.Panel = new System.Windows.Forms.Panel();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.ExportLabel = new System.Windows.Forms.Label();
            this.PlayLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.GameMenuLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Overview = new System.Windows.Forms.Label();
            this.SaveLabel = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Black;
            this.Panel.Controls.Add(this.SettingsLabel);
            this.Panel.Controls.Add(this.ExportLabel);
            this.Panel.Controls.Add(this.Overview);
            this.Panel.Controls.Add(this.SaveLabel);
            this.Panel.Controls.Add(this.PlayLabel);
            this.Panel.Controls.Add(this.PlayerLabel);
            this.Panel.Controls.Add(this.GameMenuLabel);
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(200, 564);
            this.Panel.TabIndex = 0;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Location = new System.Drawing.Point(56, 525);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(87, 30);
            this.SettingsLabel.TabIndex = 5;
            this.SettingsLabel.Text = "Settings";
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Location = new System.Drawing.Point(38, 486);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(122, 30);
            this.ExportLabel.TabIndex = 4;
            this.ExportLabel.Text = "Export View";
            // 
            // PlayLabel
            // 
            this.PlayLabel.AutoSize = true;
            this.PlayLabel.Location = new System.Drawing.Point(74, 378);
            this.PlayLabel.Name = "PlayLabel";
            this.PlayLabel.Size = new System.Drawing.Size(51, 30);
            this.PlayLabel.TabIndex = 3;
            this.PlayLabel.Text = "Play";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(60, 326);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(78, 30);
            this.PlayerLabel.TabIndex = 2;
            this.PlayerLabel.Text = "Players";
            this.PlayerLabel.Click += new System.EventHandler(this.PlayerLabel_Click);
            // 
            // GameMenuLabel
            // 
            this.GameMenuLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameMenuLabel.AutoSize = true;
            this.GameMenuLabel.BackColor = System.Drawing.Color.Black;
            this.GameMenuLabel.Location = new System.Drawing.Point(36, 239);
            this.GameMenuLabel.Name = "GameMenuLabel";
            this.GameMenuLabel.Size = new System.Drawing.Size(127, 30);
            this.GameMenuLabel.TabIndex = 1;
            this.GameMenuLabel.Text = "Game Menu";
            this.GameMenuLabel.Click += new System.EventHandler(this.GameMenuLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Overview
            // 
            this.Overview.AutoSize = true;
            this.Overview.Location = new System.Drawing.Point(50, 277);
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(98, 30);
            this.Overview.TabIndex = 3;
            this.Overview.Text = "Overview";
            this.Overview.Click += new System.EventHandler(this.Overview_Click);
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(46, 428);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(106, 30);
            this.SaveLabel.TabIndex = 3;
            this.SaveLabel.Text = "Save Data";
            // 
            // MicroscopeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(199, 564);
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MicroscopeGameForm";
            this.Text = "Microscope Game";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label PlayLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label GameMenuLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Label ExportLabel;
        private System.Windows.Forms.Label Overview;
        private System.Windows.Forms.Label SaveLabel;
    }
}