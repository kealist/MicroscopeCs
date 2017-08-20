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
            this.NewGameButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameListBox
            // 
            this.GameListBox.FormattingEnabled = true;
            this.GameListBox.ItemHeight = 17;
            this.GameListBox.Location = new System.Drawing.Point(135, 53);
            this.GameListBox.Name = "GameListBox";
            this.GameListBox.Size = new System.Drawing.Size(243, 310);
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
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(16, 53);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(113, 34);
            this.NewGameButton.TabIndex = 3;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Location = new System.Drawing.Point(16, 93);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(113, 34);
            this.LoadGameButton.TabIndex = 3;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            // 
            // MicroscopeGameMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 368);
            this.Controls.Add(this.LoadGameButton);
            this.Controls.Add(this.NewGameButton);
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
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button LoadGameButton;
    }
}