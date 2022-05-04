
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
            this.SysWatchLiveFeed = new System.IO.FileSystemWatcher();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.UIHeader = new System.Windows.Forms.Label();
            this.BuildHeader = new System.Windows.Forms.Label();
            this.EventHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // SysWatchLiveFeed
            // 
            this.SysWatchLiveFeed.EnableRaisingEvents = true;
            this.SysWatchLiveFeed.IncludeSubdirectories = true;
            this.SysWatchLiveFeed.SynchronizingObject = this;
            this.SysWatchLiveFeed.Changed += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Changed);
            this.SysWatchLiveFeed.Created += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Created);
            this.SysWatchLiveFeed.Deleted += new System.IO.FileSystemEventHandler(this.SysWatchLiveFeed_Deleted);
            this.SysWatchLiveFeed.Renamed += new System.IO.RenamedEventHandler(this.SysWatchLiveFeed_Renamed);
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
            this.Output.Size = new System.Drawing.Size(1025, 545);
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
            this.BuildHeader.Text = "Feed Build Version 1.0.0.1";
            // 
            // EventHeader
            // 
            this.EventHeader.AutoSize = true;
            this.EventHeader.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Bold);
            this.EventHeader.ForeColor = System.Drawing.Color.White;
            this.EventHeader.Location = new System.Drawing.Point(12, 610);
            this.EventHeader.Name = "EventHeader";
            this.EventHeader.Size = new System.Drawing.Size(211, 30);
            this.EventHeader.TabIndex = 23;
            this.EventHeader.Text = "Events Logged : 0";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1030, 652);
            this.Controls.Add(this.EventHeader);
            this.Controls.Add(this.BuildHeader);
            this.Controls.Add(this.UIHeader);
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Opacity = 0.9D;
            this.Text = "SysWatch Feed";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SysWatchLiveFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher SysWatchLiveFeed;
        private System.Windows.Forms.Label UIHeader;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Label BuildHeader;
        private System.Windows.Forms.Label EventHeader;
    }
}

