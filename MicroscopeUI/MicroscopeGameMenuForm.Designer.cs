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
            this.CreateGameButton = new System.Windows.Forms.Button();
            this.BigPictureTextbox = new System.Windows.Forms.TextBox();
            this.BigPictureLabel = new System.Windows.Forms.Label();
            this.LoadSelectedButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentlySelectedDescriptionLabel = new System.Windows.Forms.Label();
            this.CurrrentDescriptionLabelData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentNumPeriodsLabelData = new System.Windows.Forms.Label();
            this.CurrentDateModifiedLabelData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameListBox
            // 
            this.GameListBox.FormattingEnabled = true;
            this.GameListBox.ItemHeight = 17;
            this.GameListBox.Location = new System.Drawing.Point(16, 173);
            this.GameListBox.Name = "GameListBox";
            this.GameListBox.Size = new System.Drawing.Size(496, 310);
            this.GameListBox.TabIndex = 0;
            this.GameListBox.SelectedIndexChanged += new System.EventHandler(this.GameListBox_SelectedIndexChanged);
            // 
            // CreateGameButton
            // 
            this.CreateGameButton.Location = new System.Drawing.Point(518, 142);
            this.CreateGameButton.Name = "CreateGameButton";
            this.CreateGameButton.Size = new System.Drawing.Size(113, 25);
            this.CreateGameButton.TabIndex = 3;
            this.CreateGameButton.Text = "Create Game";
            this.CreateGameButton.UseVisualStyleBackColor = true;
            this.CreateGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // BigPictureTextbox
            // 
            this.BigPictureTextbox.Location = new System.Drawing.Point(16, 142);
            this.BigPictureTextbox.Name = "BigPictureTextbox";
            this.BigPictureTextbox.Size = new System.Drawing.Size(496, 25);
            this.BigPictureTextbox.TabIndex = 4;
            // 
            // BigPictureLabel
            // 
            this.BigPictureLabel.AutoSize = true;
            this.BigPictureLabel.Location = new System.Drawing.Point(13, 122);
            this.BigPictureLabel.Name = "BigPictureLabel";
            this.BigPictureLabel.Size = new System.Drawing.Size(161, 17);
            this.BigPictureLabel.TabIndex = 5;
            this.BigPictureLabel.Text = "Big Picture for New Game:";
            // 
            // LoadSelectedButton
            // 
            this.LoadSelectedButton.Location = new System.Drawing.Point(518, 173);
            this.LoadSelectedButton.Name = "LoadSelectedButton";
            this.LoadSelectedButton.Size = new System.Drawing.Size(113, 25);
            this.LoadSelectedButton.TabIndex = 3;
            this.LoadSelectedButton.Text = "Load Selected";
            this.LoadSelectedButton.UseVisualStyleBackColor = true;
            this.LoadSelectedButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CurrentDateModifiedLabelData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CurrentNumPeriodsLabelData);
            this.groupBox1.Controls.Add(this.CurrrentDescriptionLabelData);
            this.groupBox1.Controls.Add(this.CurrentlySelectedDescriptionLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currently Selected:";
            // 
            // CurrentlySelectedDescriptionLabel
            // 
            this.CurrentlySelectedDescriptionLabel.AutoSize = true;
            this.CurrentlySelectedDescriptionLabel.Location = new System.Drawing.Point(15, 21);
            this.CurrentlySelectedDescriptionLabel.Name = "CurrentlySelectedDescriptionLabel";
            this.CurrentlySelectedDescriptionLabel.Size = new System.Drawing.Size(77, 17);
            this.CurrentlySelectedDescriptionLabel.TabIndex = 0;
            this.CurrentlySelectedDescriptionLabel.Text = "Description:";
            // 
            // CurrrentDescriptionLabelData
            // 
            this.CurrrentDescriptionLabelData.AutoSize = true;
            this.CurrrentDescriptionLabelData.Location = new System.Drawing.Point(140, 21);
            this.CurrrentDescriptionLabelData.Name = "CurrrentDescriptionLabelData";
            this.CurrrentDescriptionLabelData.Size = new System.Drawing.Size(92, 17);
            this.CurrrentDescriptionLabelData.TabIndex = 0;
            this.CurrrentDescriptionLabelData.Text = "<Description>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Periods:";
            // 
            // CurrentNumPeriodsLabelData
            // 
            this.CurrentNumPeriodsLabelData.AutoSize = true;
            this.CurrentNumPeriodsLabelData.Location = new System.Drawing.Point(140, 47);
            this.CurrentNumPeriodsLabelData.Name = "CurrentNumPeriodsLabelData";
            this.CurrentNumPeriodsLabelData.Size = new System.Drawing.Size(34, 17);
            this.CurrentNumPeriodsLabelData.TabIndex = 0;
            this.CurrentNumPeriodsLabelData.Text = "<#>";
            // 
            // CurrentDateModifiedLabelData
            // 
            this.CurrentDateModifiedLabelData.AutoSize = true;
            this.CurrentDateModifiedLabelData.Location = new System.Drawing.Point(140, 73);
            this.CurrentDateModifiedLabelData.Name = "CurrentDateModifiedLabelData";
            this.CurrentDateModifiedLabelData.Size = new System.Drawing.Size(54, 17);
            this.CurrentDateModifiedLabelData.TabIndex = 0;
            this.CurrentDateModifiedLabelData.Text = "<Time>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Modified:";
            // 
            // MicroscopeGameMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BigPictureLabel);
            this.Controls.Add(this.BigPictureTextbox);
            this.Controls.Add(this.LoadSelectedButton);
            this.Controls.Add(this.CreateGameButton);
            this.Controls.Add(this.GameListBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MicroscopeGameMenuForm";
            this.Text = "Game Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GameListBox;
        private System.Windows.Forms.Button CreateGameButton;
        private System.Windows.Forms.TextBox BigPictureTextbox;
        private System.Windows.Forms.Label BigPictureLabel;
        private System.Windows.Forms.Button LoadSelectedButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CurrentlySelectedDescriptionLabel;
        private System.Windows.Forms.Label CurrrentDescriptionLabelData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentNumPeriodsLabelData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentDateModifiedLabelData;
    }
}