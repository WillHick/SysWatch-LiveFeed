using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysWatchLiveFeed
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }
        private void UI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            string path = "C:/";
            SysWatchLiveFeed.Path = path;
            SysWatchLiveFeed.EnableRaisingEvents = true;
            SysWatchLiveFeed.IncludeSubdirectories = true;
        }

        private int _eventcount = 0;

        private void SysWatchLiveFeed_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Changed - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            EventHeader.Text = "Events Logged : " + this._eventcount.ToString();
        }

        private void SysWatchLiveFeed_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Created - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            EventHeader.Text = "Events Logged : " + this._eventcount.ToString();
        }

        private void SysWatchLiveFeed_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Deleted - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            EventHeader.Text = "Events Logged : " + this._eventcount.ToString();
        }

        private void SysWatchLiveFeed_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                " File Renamed - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            EventHeader.Text = "Events Logged : " + this._eventcount.ToString();
        }
    }
}
