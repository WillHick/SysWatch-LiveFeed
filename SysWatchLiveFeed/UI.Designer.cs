
namespace SysWatchLiveFeed
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.SysWatchLiveFeedComp = new System.IO.FileSystemWatcher();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.UIHeader = new System.Windows.Forms.Label();
            this.BuildHeader = new System.Windows.Forms.Label();
            this.EventHeader = new System.Windows.Forms.Label();
            this.OptionsMenu = new System.Windows.Forms.Panel();
            this.CopyFeed = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.ChangePath = new System.Windows.Forms.Button();
            this.ToggleOffLink = new System.Windows.Forms.Label();
            this.ToggleOnLink = new System.Windows.Forms.Label();
            this.MenuRoundedLink = new System.Windows.Forms.Label();
            this.IconsByIcons8 = new System.Windows.Forms.Label();
            this.WatchingOutput = new System.Windows.Forms.Label();
            this.EventToggle = new System.Windows.Forms.Button();
            this.RaisingEvents = new System.Windows.Forms.Label();
            this.SubToggle = new System.Windows.Forms.Button();
            this.MenuIcon = new System.Windows.Forms.Button();
            this.SubDirect = new System.Windows.Forms.Label();
            this.SelectPathPane = new System.Windows.Forms.Panel();
            this.Note = new System.Windows.Forms.Label();
            this.NewPathInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdatePath = new System.Windows.Forms.Button();
            this.NewHelp = new System.Windows.Forms.Label();
            this.NewPath = new System.Windows.Forms.Label();
            this.Underline = new System.Windows.Forms.Panel();
            this.More = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeedComp)).BeginInit();
            this.OptionsMenu.SuspendLayout();
            this.SelectPathPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // SysWatchLiveFeedComp
            // 
            this.SysWatchLiveFeedComp.EnableRaisingEvents = true;
            this.SysWatchLiveFeedComp.IncludeSubdirectories = true;
            this.SysWatchLiveFeedComp.SynchronizingObject = this;
            this.SysWatchLiveFeedComp.Changed += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Changed);
            this.SysWatchLiveFeedComp.Created += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Created);
            this.SysWatchLiveFeedComp.Deleted += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Deleted);
            this.SysWatchLiveFeedComp.Renamed += new System.IO.RenamedEventHandler(this.SysWatchLiveFeed_Renamed);
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.DetectUrls = false;
            this.Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.White;
            this.Output.Location = new System.Drawing.Point(4, 51);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Output.Size = new System.Drawing.Size(1052, 545);
            this.Output.TabIndex = 1;
            this.Output.Text = "";
            // 
            // UIHeader
            // 
            this.UIHeader.AutoSize = true;
            this.UIHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UIHeader.ForeColor = System.Drawing.Color.White;
            this.UIHeader.Location = new System.Drawing.Point(12, 10);
            this.UIHeader.Name = "UIHeader";
            this.UIHeader.Size = new System.Drawing.Size(121, 30);
            this.UIHeader.TabIndex = 3;
            this.UIHeader.Text = "SysWatch";
            // 
            // BuildHeader
            // 
            this.BuildHeader.AutoSize = true;
            this.BuildHeader.Font = new System.Drawing.Font("Microsoft YaHei", 7F, System.Drawing.FontStyle.Bold);
            this.BuildHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.BuildHeader.Location = new System.Drawing.Point(129, 21);
            this.BuildHeader.Name = "BuildHeader";
            this.BuildHeader.Size = new System.Drawing.Size(191, 19);
            this.BuildHeader.TabIndex = 4;
            this.BuildHeader.Text = "Feed Build Version 1.0.0.3";
            // 
            // EventHeader
            // 
            this.EventHeader.AutoSize = true;
            this.EventHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.EventHeader.ForeColor = System.Drawing.Color.White;
            this.EventHeader.Location = new System.Drawing.Point(14, 608);
            this.EventHeader.Name = "EventHeader";
            this.EventHeader.Size = new System.Drawing.Size(211, 30);
            this.EventHeader.TabIndex = 23;
            this.EventHeader.Text = "Events Logged : 0";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.OptionsMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsMenu.Controls.Add(this.CopyFeed);
            this.OptionsMenu.Controls.Add(this.ClearAll);
            this.OptionsMenu.Controls.Add(this.ChangePath);
            this.OptionsMenu.Controls.Add(this.ToggleOffLink);
            this.OptionsMenu.Controls.Add(this.ToggleOnLink);
            this.OptionsMenu.Controls.Add(this.MenuRoundedLink);
            this.OptionsMenu.Controls.Add(this.IconsByIcons8);
            this.OptionsMenu.Controls.Add(this.WatchingOutput);
            this.OptionsMenu.Controls.Add(this.EventToggle);
            this.OptionsMenu.Controls.Add(this.RaisingEvents);
            this.OptionsMenu.Controls.Add(this.SubToggle);
            this.OptionsMenu.Controls.Add(this.MenuIcon);
            this.OptionsMenu.Controls.Add(this.SubDirect);
            this.OptionsMenu.Controls.Add(this.SelectPathPane);
            this.OptionsMenu.Location = new System.Drawing.Point(550, 98);
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(467, 505);
            this.OptionsMenu.TabIndex = 42;
            this.OptionsMenu.Visible = false;
            // 
            // CopyFeed
            // 
            this.CopyFeed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CopyFeed.FlatAppearance.BorderSize = 0;
            this.CopyFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyFeed.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CopyFeed.ForeColor = System.Drawing.Color.White;
            this.CopyFeed.Location = new System.Drawing.Point(23, 304);
            this.CopyFeed.Name = "CopyFeed";
            this.CopyFeed.Size = new System.Drawing.Size(420, 53);
            this.CopyFeed.TabIndex = 64;
            this.CopyFeed.Text = "Copy Feed To Clipboard";
            this.CopyFeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyFeed.UseVisualStyleBackColor = true;
            this.CopyFeed.Click += new System.EventHandler(this.CopyFeed_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClearAll.FlatAppearance.BorderSize = 0;
            this.ClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ClearAll.ForeColor = System.Drawing.Color.White;
            this.ClearAll.Location = new System.Drawing.Point(23, 254);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(420, 53);
            this.ClearAll.TabIndex = 63;
            this.ClearAll.Text = "Clear Feed and Log Count";
            this.ClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // ChangePath
            // 
            this.ChangePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ChangePath.FlatAppearance.BorderSize = 0;
            this.ChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ChangePath.ForeColor = System.Drawing.Color.White;
            this.ChangePath.Location = new System.Drawing.Point(23, 202);
            this.ChangePath.Name = "ChangePath";
            this.ChangePath.Size = new System.Drawing.Size(420, 53);
            this.ChangePath.TabIndex = 62;
            this.ChangePath.Text = "Change Watch Path";
            this.ChangePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePath.UseVisualStyleBackColor = true;
            this.ChangePath.Click += new System.EventHandler(this.ChangePath_Click);
            // 
            // ToggleOffLink
            // 
            this.ToggleOffLink.AutoSize = true;
            this.ToggleOffLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleOffLink.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold);
            this.ToggleOffLink.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ToggleOffLink.Location = new System.Drawing.Point(24, 454);
            this.ToggleOffLink.Name = "ToggleOffLink";
            this.ToggleOffLink.Size = new System.Drawing.Size(368, 24);
            this.ToggleOffLink.TabIndex = 61;
            this.ToggleOffLink.Text = "https://icons8.com/icon/20006/toggle-off";
            this.ToggleOffLink.Click += new System.EventHandler(this.ToggleOffLink_Click);
            // 
            // ToggleOnLink
            // 
            this.ToggleOnLink.AutoSize = true;
            this.ToggleOnLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleOnLink.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold);
            this.ToggleOnLink.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ToggleOnLink.Location = new System.Drawing.Point(24, 426);
            this.ToggleOnLink.Name = "ToggleOnLink";
            this.ToggleOnLink.Size = new System.Drawing.Size(365, 24);
            this.ToggleOnLink.TabIndex = 60;
            this.ToggleOnLink.Text = "https://icons8.com/icon/88034/toggle-on";
            this.ToggleOnLink.Click += new System.EventHandler(this.ToggleOnLink_Click);
            // 
            // MenuRoundedLink
            // 
            this.MenuRoundedLink.AutoSize = true;
            this.MenuRoundedLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuRoundedLink.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold);
            this.MenuRoundedLink.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MenuRoundedLink.Location = new System.Drawing.Point(24, 398);
            this.MenuRoundedLink.Name = "MenuRoundedLink";
            this.MenuRoundedLink.Size = new System.Drawing.Size(409, 24);
            this.MenuRoundedLink.TabIndex = 59;
            this.MenuRoundedLink.Text = "https://icons8.com/icon/36389/menu-rounded";
            this.MenuRoundedLink.Click += new System.EventHandler(this.MenuRoundedLink_Click);
            // 
            // IconsByIcons8
            // 
            this.IconsByIcons8.AutoSize = true;
            this.IconsByIcons8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.IconsByIcons8.ForeColor = System.Drawing.Color.White;
            this.IconsByIcons8.Location = new System.Drawing.Point(25, 364);
            this.IconsByIcons8.Name = "IconsByIcons8";
            this.IconsByIcons8.Size = new System.Drawing.Size(172, 30);
            this.IconsByIcons8.TabIndex = 58;
            this.IconsByIcons8.Text = "Icons By Icons8";
            // 
            // WatchingOutput
            // 
            this.WatchingOutput.AutoSize = true;
            this.WatchingOutput.Font = new System.Drawing.Font("Microsoft YaHei", 7.3F, System.Drawing.FontStyle.Bold);
            this.WatchingOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.WatchingOutput.Location = new System.Drawing.Point(30, 171);
            this.WatchingOutput.Name = "WatchingOutput";
            this.WatchingOutput.Size = new System.Drawing.Size(168, 19);
            this.WatchingOutput.TabIndex = 42;
            this.WatchingOutput.Text = "Currently Watching : ";
            // 
            // EventToggle
            // 
            this.EventToggle.BackgroundImage = global::SysWatchLiveFeed.Properties.Resources.icons8_toggle_on_96;
            this.EventToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EventToggle.FlatAppearance.BorderSize = 0;
            this.EventToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.EventToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventToggle.Location = new System.Drawing.Point(384, 72);
            this.EventToggle.Name = "EventToggle";
            this.EventToggle.Size = new System.Drawing.Size(49, 49);
            this.EventToggle.TabIndex = 40;
            this.EventToggle.UseVisualStyleBackColor = true;
            this.EventToggle.Click += new System.EventHandler(this.EventToggle_Click);
            // 
            // RaisingEvents
            // 
            this.RaisingEvents.AutoSize = true;
            this.RaisingEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.RaisingEvents.ForeColor = System.Drawing.Color.White;
            this.RaisingEvents.Location = new System.Drawing.Point(31, 82);
            this.RaisingEvents.Name = "RaisingEvents";
            this.RaisingEvents.Size = new System.Drawing.Size(109, 30);
            this.RaisingEvents.TabIndex = 41;
            this.RaisingEvents.Text = "Live Feed";
            // 
            // SubToggle
            // 
            this.SubToggle.BackgroundImage = global::SysWatchLiveFeed.Properties.Resources.icons8_toggle_on_96;
            this.SubToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubToggle.FlatAppearance.BorderSize = 0;
            this.SubToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SubToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubToggle.Location = new System.Drawing.Point(384, 127);
            this.SubToggle.Name = "SubToggle";
            this.SubToggle.Size = new System.Drawing.Size(49, 49);
            this.SubToggle.TabIndex = 28;
            this.SubToggle.UseVisualStyleBackColor = true;
            this.SubToggle.Click += new System.EventHandler(this.SubToggle_Click);
            // 
            // MenuIcon
            // 
            this.MenuIcon.BackgroundImage = global::SysWatchLiveFeed.Properties.Resources.icons8_menu_rounded_100;
            this.MenuIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuIcon.FlatAppearance.BorderSize = 0;
            this.MenuIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MenuIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuIcon.Location = new System.Drawing.Point(32, 26);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(30, 30);
            this.MenuIcon.TabIndex = 29;
            this.MenuIcon.UseVisualStyleBackColor = true;
            // 
            // SubDirect
            // 
            this.SubDirect.AutoSize = true;
            this.SubDirect.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SubDirect.ForeColor = System.Drawing.Color.White;
            this.SubDirect.Location = new System.Drawing.Point(31, 137);
            this.SubDirect.Name = "SubDirect";
            this.SubDirect.Size = new System.Drawing.Size(245, 30);
            this.SubDirect.TabIndex = 29;
            this.SubDirect.Text = "Include Subdirectories";
            // 
            // SelectPathPane
            // 
            this.SelectPathPane.Controls.Add(this.Note);
            this.SelectPathPane.Controls.Add(this.NewPathInput);
            this.SelectPathPane.Controls.Add(this.button2);
            this.SelectPathPane.Controls.Add(this.UpdatePath);
            this.SelectPathPane.Controls.Add(this.NewHelp);
            this.SelectPathPane.Controls.Add(this.NewPath);
            this.SelectPathPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectPathPane.Location = new System.Drawing.Point(0, 0);
            this.SelectPathPane.Name = "SelectPathPane";
            this.SelectPathPane.Size = new System.Drawing.Size(465, 503);
            this.SelectPathPane.TabIndex = 65;
            this.SelectPathPane.Visible = false;
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Note.Location = new System.Drawing.Point(26, 275);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(390, 120);
            this.Note.TabIndex = 68;
            this.Note.Text = "Note:\r\nIf The Feed Isnt Updating, You Have \r\nHave Entered Your Choosen Path\r\nIn W" +
    "rong Or Its Inncorrect.\r\n";
            // 
            // NewPathInput
            // 
            this.NewPathInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NewPathInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPathInput.Font = new System.Drawing.Font("Microsoft YaHei", 11.5F);
            this.NewPathInput.ForeColor = System.Drawing.Color.White;
            this.NewPathInput.Location = new System.Drawing.Point(34, 160);
            this.NewPathInput.Name = "NewPathInput";
            this.NewPathInput.Size = new System.Drawing.Size(399, 31);
            this.NewPathInput.TabIndex = 67;
            this.NewPathInput.Text = "C:/";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SysWatchLiveFeed.Properties.Resources.icons8_menu_rounded_100;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(32, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 66;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UpdatePath
            // 
            this.UpdatePath.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.UpdatePath.FlatAppearance.BorderSize = 0;
            this.UpdatePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.UpdatePath.ForeColor = System.Drawing.Color.White;
            this.UpdatePath.Location = new System.Drawing.Point(23, 211);
            this.UpdatePath.Name = "UpdatePath";
            this.UpdatePath.Size = new System.Drawing.Size(420, 53);
            this.UpdatePath.TabIndex = 65;
            this.UpdatePath.Text = "Update Path";
            this.UpdatePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdatePath.UseVisualStyleBackColor = true;
            this.UpdatePath.Click += new System.EventHandler(this.UpdatePath_Click);
            // 
            // NewHelp
            // 
            this.NewHelp.AutoSize = true;
            this.NewHelp.Font = new System.Drawing.Font("Microsoft YaHei", 7.3F, System.Drawing.FontStyle.Bold);
            this.NewHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.NewHelp.Location = new System.Drawing.Point(30, 115);
            this.NewHelp.Name = "NewHelp";
            this.NewHelp.Size = new System.Drawing.Size(178, 19);
            this.NewHelp.TabIndex = 64;
            this.NewHelp.Text = "Input New Path Below";
            // 
            // NewPath
            // 
            this.NewPath.AutoSize = true;
            this.NewPath.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.NewPath.ForeColor = System.Drawing.Color.White;
            this.NewPath.Location = new System.Drawing.Point(30, 81);
            this.NewPath.Name = "NewPath";
            this.NewPath.Size = new System.Drawing.Size(229, 30);
            this.NewPath.TabIndex = 63;
            this.NewPath.Text = "Change Current Path";
            // 
            // Underline
            // 
            this.Underline.BackColor = System.Drawing.Color.White;
            this.Underline.Location = new System.Drawing.Point(943, 649);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(87, 4);
            this.Underline.TabIndex = 55;
            // 
            // More
            // 
            this.More.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.More.FlatAppearance.BorderSize = 0;
            this.More.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.More.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("Microsoft YaHei", 8.6F, System.Drawing.FontStyle.Bold);
            this.More.ForeColor = System.Drawing.Color.White;
            this.More.Location = new System.Drawing.Point(943, 603);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(87, 45);
            this.More.TabIndex = 54;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = true;
            this.More.Click += new System.EventHandler(this.More_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1030, 652);
            this.Controls.Add(this.Underline);
            this.Controls.Add(this.OptionsMenu);
            this.Controls.Add(this.EventHeader);
            this.Controls.Add(this.BuildHeader);
            this.Controls.Add(this.UIHeader);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.More);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Opacity = 0.97D;
            this.Text = "SysWatch Feed";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeedComp)).EndInit();
            this.OptionsMenu.ResumeLayout(false);
            this.OptionsMenu.PerformLayout();
            this.SelectPathPane.ResumeLayout(false);
            this.SelectPathPane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher SysWatchLiveFeedComp;
        private System.Windows.Forms.Label UIHeader;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label BuildHeader;
        private System.Windows.Forms.Label EventHeader;
        private System.Windows.Forms.Panel OptionsMenu;
        private System.Windows.Forms.Button SubToggle;
        private System.Windows.Forms.Button MenuIcon;
        private System.Windows.Forms.Label SubDirect;
        private System.Windows.Forms.Button EventToggle;
        private System.Windows.Forms.Label RaisingEvents;
        private System.Windows.Forms.Panel Underline;
        private System.Windows.Forms.Button More;
        private System.Windows.Forms.Label WatchingOutput;
        private System.Windows.Forms.Label ToggleOffLink;
        private System.Windows.Forms.Label ToggleOnLink;
        private System.Windows.Forms.Label MenuRoundedLink;
        private System.Windows.Forms.Label IconsByIcons8;
        private System.Windows.Forms.Button ChangePath;
        private System.Windows.Forms.Button CopyFeed;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Panel SelectPathPane;
        private System.Windows.Forms.TextBox NewPathInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdatePath;
        private System.Windows.Forms.Label NewHelp;
        private System.Windows.Forms.Label NewPath;
        private System.Windows.Forms.Label Note;
    }
}

