namespace MicroscopeUI
{
    partial class MicroscopeGameMenuForm
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
            this.GameListBox = new System.Windows.Forms.ListBox();
            this.CurrentGameLabel = new System.Windows.Forms.Label();
            this.CurrentGameDataLabel = new System.Windows.Forms.Label();
            this.CreateGameButton = new System.Windows.Forms.Button();
            this.BigPictureTextbox = new System.Windows.Forms.TextBox();
            this.BigPictureLabel = new System.Windows.Forms.Label();
            this.LoadSelectedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameListBox
            // 
            this.GameListBox.FormattingEnabled = true;
            this.GameListBox.ItemHeight = 17;
            this.GameListBox.Location = new System.Drawing.Point(16, 91);
            this.GameListBox.Name = "GameListBox";
            this.GameListBox.Size = new System.Drawing.Size(496, 310);
            this.GameListBox.TabIndex = 0;
            // 
            // CurrentGameLabel
            // 
            this.CurrentGameLabel.AutoSize = true;
            this.CurrentGameLabel.Location = new System.Drawing.Point(13, 13);
            this.CurrentGameLabel.Name = "CurrentGameLabel";
            this.CurrentGameLabel.Size = new System.Drawing.Size(92, 17);
            this.CurrentGameLabel.TabIndex = 1;
            this.CurrentGameLabel.Text = "Current Game:";
            // 
            // CurrentGameDataLabel
            // 
            this.CurrentGameDataLabel.AutoSize = true;
            this.CurrentGameDataLabel.Location = new System.Drawing.Point(112, 13);
            this.CurrentGameDataLabel.Name = "CurrentGameDataLabel";
            this.CurrentGameDataLabel.Size = new System.Drawing.Size(129, 17);
            this.CurrentGameDataLabel.TabIndex = 2;
            this.CurrentGameDataLabel.Text = "<Game.Description>";
            // 
            // CreateGameButton
            // 
            this.CreateGameButton.Location = new System.Drawing.Point(518, 60);
            this.CreateGameButton.Name = "CreateGameButton";
            this.CreateGameButton.Size = new System.Drawing.Size(113, 25);
            this.CreateGameButton.TabIndex = 3;
            this.CreateGameButton.Text = "Create Game";
            this.CreateGameButton.UseVisualStyleBackColor = true;
            this.CreateGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // BigPictureTextbox
            // 
            this.BigPictureTextbox.Location = new System.Drawing.Point(16, 60);
            this.BigPictureTextbox.Name = "BigPictureTextbox";
            this.BigPictureTextbox.Size = new System.Drawing.Size(496, 25);
            this.BigPictureTextbox.TabIndex = 4;
            // 
            // BigPictureLabel
            // 
            this.BigPictureLabel.AutoSize = true;
            this.BigPictureLabel.Location = new System.Drawing.Point(13, 40);
            this.BigPictureLabel.Name = "BigPictureLabel";
            this.BigPictureLabel.Size = new System.Drawing.Size(161, 17);
            this.BigPictureLabel.TabIndex = 5;
            this.BigPictureLabel.Text = "Big Picture for New Game:";
            // 
            // LoadSelectedButton
            // 
            this.LoadSelectedButton.Location = new System.Drawing.Point(518, 91);
            this.LoadSelectedButton.Name = "LoadSelectedButton";
            this.LoadSelectedButton.Size = new System.Drawing.Size(113, 25);
            this.LoadSelectedButton.TabIndex = 3;
            this.LoadSelectedButton.Text = "Load Selected";
            this.LoadSelectedButton.UseVisualStyleBackColor = true;
            this.LoadSelectedButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // MicroscopeGameMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 409);
            this.Controls.Add(this.BigPictureLabel);
            this.Controls.Add(this.BigPictureTextbox);
            this.Controls.Add(this.LoadSelectedButton);
            this.Controls.Add(this.CreateGameButton);
            this.Controls.Add(this.CurrentGameDataLabel);
            this.Controls.Add(this.CurrentGameLabel);
            this.Controls.Add(this.GameListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MicroscopeGameMenuForm";
            this.Text = "Game Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GameListBox;
        private System.Windows.Forms.Label CurrentGameLabel;
        private System.Windows.Forms.Label CurrentGameDataLabel;
        private System.Windows.Forms.Button CreateGameButton;
        private System.Windows.Forms.TextBox BigPictureTextbox;
        private System.Windows.Forms.Label BigPictureLabel;
        private System.Windows.Forms.Button LoadSelectedButton;
    }
}