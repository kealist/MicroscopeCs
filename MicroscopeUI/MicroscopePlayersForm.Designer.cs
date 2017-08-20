namespace MicroscopeUI
{
    partial class MicroscopePlayersForm
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
            this.RemovePlayerButton = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.PlayersListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RemovePlayerButton
            // 
            this.RemovePlayerButton.Location = new System.Drawing.Point(7, 69);
            this.RemovePlayerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemovePlayerButton.Name = "RemovePlayerButton";
            this.RemovePlayerButton.Size = new System.Drawing.Size(103, 32);
            this.RemovePlayerButton.TabIndex = 24;
            this.RemovePlayerButton.Text = "Remove Player";
            this.RemovePlayerButton.UseVisualStyleBackColor = true;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(196, 33);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(98, 25);
            this.LastNameTextBox.TabIndex = 21;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(126, 33);
            this.FirstNameTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(68, 25);
            this.FirstNameTextbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Current Players";
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(8, 33);
            this.AddPlayerButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(103, 32);
            this.AddPlayerButton.TabIndex = 24;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            // 
            // PlayersListbox
            // 
            this.PlayersListbox.FormattingEnabled = true;
            this.PlayersListbox.ItemHeight = 17;
            this.PlayersListbox.Location = new System.Drawing.Point(126, 64);
            this.PlayersListbox.Name = "PlayersListbox";
            this.PlayersListbox.Size = new System.Drawing.Size(168, 242);
            this.PlayersListbox.TabIndex = 25;
            // 
            // MicroscopePlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 313);
            this.Controls.Add(this.PlayersListbox);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.RemovePlayerButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MicroscopePlayersForm";
            this.Text = "Microscope Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemovePlayerButton;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.ListBox PlayersListbox;
    }
}