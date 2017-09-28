namespace MicroscopeUI
{
    partial class MicroscopeMainForm
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
            this.Panel = new System.Windows.Forms.Panel();
            this.GameMenuButton = new System.Windows.Forms.Button();
            this.Panelxxx = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddCharacterButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.AddSceneButton = new System.Windows.Forms.Button();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.AddPeriodButton = new System.Windows.Forms.Button();
            this.CharacterInfoBox = new System.Windows.Forms.GroupBox();
            this.EventInfoBox = new System.Windows.Forms.GroupBox();
            this.EventInfoTextbox = new System.Windows.Forms.TextBox();
            this.SceneInfoBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PeriodInfoBox = new System.Windows.Forms.GroupBox();
            this.PeriodInfoUpdateButton = new System.Windows.Forms.Button();
            this.DarkRadioButton = new System.Windows.Forms.RadioButton();
            this.PeriodDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.LightRadioButton = new System.Windows.Forms.RadioButton();
            this.GameTreeView = new System.Windows.Forms.TreeView();
            this.GameContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPeriodContext = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEventContext = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSceneContext = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContext = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.Panelxxx.SuspendLayout();
            this.EventInfoBox.SuspendLayout();
            this.SceneInfoBox.SuspendLayout();
            this.PeriodInfoBox.SuspendLayout();
            this.GameContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Black;
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.GameMenuButton);
            this.Panel.Controls.Add(this.Panelxxx);
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Controls.Add(this.menuStrip1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1305, 724);
            this.Panel.TabIndex = 1;
            // 
            // GameMenuButton
            // 
            this.GameMenuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameMenuButton.Location = new System.Drawing.Point(9, 248);
            this.GameMenuButton.Name = "GameMenuButton";
            this.GameMenuButton.Size = new System.Drawing.Size(215, 25);
            this.GameMenuButton.TabIndex = 8;
            this.GameMenuButton.Text = "New / Load Game";
            this.GameMenuButton.UseVisualStyleBackColor = true;
            this.GameMenuButton.Click += new System.EventHandler(this.GameMenuButton_Click);
            // 
            // Panelxxx
            // 
            this.Panelxxx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panelxxx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panelxxx.Controls.Add(this.button5);
            this.Panelxxx.Controls.Add(this.button4);
            this.Panelxxx.Controls.Add(this.button3);
            this.Panelxxx.Controls.Add(this.button1);
            this.Panelxxx.Controls.Add(this.button2);
            this.Panelxxx.Controls.Add(this.AddCharacterButton);
            this.Panelxxx.Controls.Add(this.DeleteSelectedButton);
            this.Panelxxx.Controls.Add(this.AddSceneButton);
            this.Panelxxx.Controls.Add(this.AddEventButton);
            this.Panelxxx.Controls.Add(this.AddPeriodButton);
            this.Panelxxx.Controls.Add(this.CharacterInfoBox);
            this.Panelxxx.Controls.Add(this.EventInfoBox);
            this.Panelxxx.Controls.Add(this.SceneInfoBox);
            this.Panelxxx.Controls.Add(this.PeriodInfoBox);
            this.Panelxxx.Controls.Add(this.GameTreeView);
            this.Panelxxx.Location = new System.Drawing.Point(234, 28);
            this.Panelxxx.Name = "Panelxxx";
            this.Panelxxx.Size = new System.Drawing.Size(1069, 694);
            this.Panelxxx.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(918, 617);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 30);
            this.button5.TabIndex = 12;
            this.button5.Text = "<Unused>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(772, 617);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "<Unused>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(626, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 30);
            this.button3.TabIndex = 14;
            this.button3.Text = "<Unused>";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(918, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "<Unused>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(480, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "<Unused>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddCharacterButton
            // 
            this.AddCharacterButton.ForeColor = System.Drawing.Color.Black;
            this.AddCharacterButton.Location = new System.Drawing.Point(772, 581);
            this.AddCharacterButton.Name = "AddCharacterButton";
            this.AddCharacterButton.Size = new System.Drawing.Size(140, 30);
            this.AddCharacterButton.TabIndex = 17;
            this.AddCharacterButton.Text = "Add Character";
            this.AddCharacterButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteSelectedButton.Location = new System.Drawing.Point(334, 617);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(140, 30);
            this.DeleteSelectedButton.TabIndex = 18;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // AddSceneButton
            // 
            this.AddSceneButton.ForeColor = System.Drawing.Color.Black;
            this.AddSceneButton.Location = new System.Drawing.Point(626, 581);
            this.AddSceneButton.Name = "AddSceneButton";
            this.AddSceneButton.Size = new System.Drawing.Size(140, 30);
            this.AddSceneButton.TabIndex = 19;
            this.AddSceneButton.Text = "Add Scene";
            this.AddSceneButton.UseVisualStyleBackColor = true;
            // 
            // AddEventButton
            // 
            this.AddEventButton.ForeColor = System.Drawing.Color.Black;
            this.AddEventButton.Location = new System.Drawing.Point(480, 581);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(140, 30);
            this.AddEventButton.TabIndex = 20;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            // 
            // AddPeriodButton
            // 
            this.AddPeriodButton.ForeColor = System.Drawing.Color.Black;
            this.AddPeriodButton.Location = new System.Drawing.Point(334, 581);
            this.AddPeriodButton.Name = "AddPeriodButton";
            this.AddPeriodButton.Size = new System.Drawing.Size(140, 30);
            this.AddPeriodButton.TabIndex = 21;
            this.AddPeriodButton.Text = "Add Period";
            this.AddPeriodButton.UseVisualStyleBackColor = true;
            // 
            // CharacterInfoBox
            // 
            this.CharacterInfoBox.Location = new System.Drawing.Point(699, 292);
            this.CharacterInfoBox.Name = "CharacterInfoBox";
            this.CharacterInfoBox.Size = new System.Drawing.Size(359, 283);
            this.CharacterInfoBox.TabIndex = 11;
            this.CharacterInfoBox.TabStop = false;
            this.CharacterInfoBox.Text = "Character info???";
            // 
            // EventInfoBox
            // 
            this.EventInfoBox.Controls.Add(this.EventInfoTextbox);
            this.EventInfoBox.Location = new System.Drawing.Point(699, 3);
            this.EventInfoBox.Name = "EventInfoBox";
            this.EventInfoBox.Size = new System.Drawing.Size(359, 283);
            this.EventInfoBox.TabIndex = 9;
            this.EventInfoBox.TabStop = false;
            this.EventInfoBox.Text = "Event Info";
            // 
            // EventInfoTextbox
            // 
            this.EventInfoTextbox.Location = new System.Drawing.Point(29, 24);
            this.EventInfoTextbox.Multiline = true;
            this.EventInfoTextbox.Name = "EventInfoTextbox";
            this.EventInfoTextbox.Size = new System.Drawing.Size(300, 63);
            this.EventInfoTextbox.TabIndex = 2;
            // 
            // SceneInfoBox
            // 
            this.SceneInfoBox.Controls.Add(this.textBox1);
            this.SceneInfoBox.Location = new System.Drawing.Point(334, 292);
            this.SceneInfoBox.Name = "SceneInfoBox";
            this.SceneInfoBox.Size = new System.Drawing.Size(359, 283);
            this.SceneInfoBox.TabIndex = 8;
            this.SceneInfoBox.TabStop = false;
            this.SceneInfoBox.Text = "Scene Info";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 63);
            this.textBox1.TabIndex = 2;
            // 
            // PeriodInfoBox
            // 
            this.PeriodInfoBox.Controls.Add(this.PeriodInfoUpdateButton);
            this.PeriodInfoBox.Controls.Add(this.DarkRadioButton);
            this.PeriodInfoBox.Controls.Add(this.PeriodDescriptionTextbox);
            this.PeriodInfoBox.Controls.Add(this.LightRadioButton);
            this.PeriodInfoBox.Location = new System.Drawing.Point(334, 3);
            this.PeriodInfoBox.Name = "PeriodInfoBox";
            this.PeriodInfoBox.Size = new System.Drawing.Size(359, 282);
            this.PeriodInfoBox.TabIndex = 10;
            this.PeriodInfoBox.TabStop = false;
            this.PeriodInfoBox.Text = "Period Info";
            // 
            // PeriodInfoUpdateButton
            // 
            this.PeriodInfoUpdateButton.ForeColor = System.Drawing.Color.Black;
            this.PeriodInfoUpdateButton.Location = new System.Drawing.Point(278, 247);
            this.PeriodInfoUpdateButton.Name = "PeriodInfoUpdateButton";
            this.PeriodInfoUpdateButton.Size = new System.Drawing.Size(75, 29);
            this.PeriodInfoUpdateButton.TabIndex = 1;
            this.PeriodInfoUpdateButton.Text = "Update";
            this.PeriodInfoUpdateButton.UseVisualStyleBackColor = true;
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.AutoSize = true;
            this.DarkRadioButton.ForeColor = System.Drawing.Color.Black;
            this.DarkRadioButton.Location = new System.Drawing.Point(153, 101);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(53, 21);
            this.DarkRadioButton.TabIndex = 3;
            this.DarkRadioButton.TabStop = true;
            this.DarkRadioButton.Text = "Dark";
            this.DarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // PeriodDescriptionTextbox
            // 
            this.PeriodDescriptionTextbox.Location = new System.Drawing.Point(35, 24);
            this.PeriodDescriptionTextbox.Multiline = true;
            this.PeriodDescriptionTextbox.Name = "PeriodDescriptionTextbox";
            this.PeriodDescriptionTextbox.Size = new System.Drawing.Size(300, 63);
            this.PeriodDescriptionTextbox.TabIndex = 2;
            // 
            // LightRadioButton
            // 
            this.LightRadioButton.AutoSize = true;
            this.LightRadioButton.ForeColor = System.Drawing.Color.Black;
            this.LightRadioButton.Location = new System.Drawing.Point(93, 101);
            this.LightRadioButton.Name = "LightRadioButton";
            this.LightRadioButton.Size = new System.Drawing.Size(54, 21);
            this.LightRadioButton.TabIndex = 3;
            this.LightRadioButton.TabStop = true;
            this.LightRadioButton.Text = "Light";
            this.LightRadioButton.UseVisualStyleBackColor = true;
            // 
            // GameTreeView
            // 
            this.GameTreeView.ContextMenuStrip = this.GameContextMenu;
            this.GameTreeView.LineColor = System.Drawing.Color.BurlyWood;
            this.GameTreeView.Location = new System.Drawing.Point(3, 3);
            this.GameTreeView.Name = "GameTreeView";
            this.GameTreeView.Size = new System.Drawing.Size(325, 684);
            this.GameTreeView.TabIndex = 7;
            this.GameTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.GameTreeView_AfterSelect);
            // 
            // GameContextMenu
            // 
            this.GameContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPeriodToolStripMenuItem,
            this.EditContext});
            this.GameContextMenu.Name = "contextMenuStrip1";
            this.GameContextMenu.Size = new System.Drawing.Size(103, 48);
            // 
            // addPeriodToolStripMenuItem
            // 
            this.addPeriodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPeriodContext,
            this.AddEventContext,
            this.AddSceneContext});
            this.addPeriodToolStripMenuItem.Name = "addPeriodToolStripMenuItem";
            this.addPeriodToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.addPeriodToolStripMenuItem.Text = "Add..";
            // 
            // AddPeriodContext
            // 
            this.AddPeriodContext.Name = "AddPeriodContext";
            this.AddPeriodContext.Size = new System.Drawing.Size(108, 22);
            this.AddPeriodContext.Text = "Period";
            this.AddPeriodContext.Click += new System.EventHandler(this.AddPeriodContext_Click);
            // 
            // AddEventContext
            // 
            this.AddEventContext.Name = "AddEventContext";
            this.AddEventContext.Size = new System.Drawing.Size(108, 22);
            this.AddEventContext.Text = "Event";
            this.AddEventContext.Click += new System.EventHandler(this.AddEventContext_Click);
            // 
            // AddSceneContext
            // 
            this.AddSceneContext.Name = "AddSceneContext";
            this.AddSceneContext.Size = new System.Drawing.Size(108, 22);
            this.AddSceneContext.Text = "Scene";
            this.AddSceneContext.Click += new System.EventHandler(this.AddSceneContext_Click);
            // 
            // EditContext
            // 
            this.EditContext.Name = "EditContext";
            this.EditContext.Size = new System.Drawing.Size(102, 22);
            this.EditContext.Text = "Edit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 214);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1305, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.loadGameToolStripMenuItem,
            this.exportViewToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            // 
            // exportViewToolStripMenuItem
            // 
            this.exportViewToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exportViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTMLToolStripMenuItem});
            this.exportViewToolStripMenuItem.Name = "exportViewToolStripMenuItem";
            this.exportViewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exportViewToolStripMenuItem.Text = "Export View";
            // 
            // hTMLToolStripMenuItem
            // 
            this.hTMLToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.hTMLToolStripMenuItem.Name = "hTMLToolStripMenuItem";
            this.hTMLToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.hTMLToolStripMenuItem.Text = "HTML";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Microscope";
            // 
            // MicroscopeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 724);
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MicroscopeMainForm";
            this.Text = "MicroscopeMainForm";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.Panelxxx.ResumeLayout(false);
            this.EventInfoBox.ResumeLayout(false);
            this.EventInfoBox.PerformLayout();
            this.SceneInfoBox.ResumeLayout(false);
            this.SceneInfoBox.PerformLayout();
            this.PeriodInfoBox.ResumeLayout(false);
            this.PeriodInfoBox.PerformLayout();
            this.GameContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.Panel Panelxxx;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddCharacterButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button AddSceneButton;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.Button AddPeriodButton;
        private System.Windows.Forms.GroupBox CharacterInfoBox;
        private System.Windows.Forms.GroupBox EventInfoBox;
        private System.Windows.Forms.TextBox EventInfoTextbox;
        private System.Windows.Forms.GroupBox SceneInfoBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox PeriodInfoBox;
        private System.Windows.Forms.Button PeriodInfoUpdateButton;
        private System.Windows.Forms.RadioButton DarkRadioButton;
        private System.Windows.Forms.TextBox PeriodDescriptionTextbox;
        private System.Windows.Forms.RadioButton LightRadioButton;
        private System.Windows.Forms.TreeView GameTreeView;
        private System.Windows.Forms.ToolStripMenuItem exportViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLToolStripMenuItem;
        private System.Windows.Forms.Button GameMenuButton;
        private System.Windows.Forms.ContextMenuStrip GameContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPeriodContext;
        private System.Windows.Forms.ToolStripMenuItem AddEventContext;
        private System.Windows.Forms.ToolStripMenuItem AddSceneContext;
        private System.Windows.Forms.ToolStripMenuItem EditContext;
        private System.Windows.Forms.Label label1;
    }
}