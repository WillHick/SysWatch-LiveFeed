using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            SelectPathPane.Hide();

            string path = "C:/";
            SysWatchLiveFeedComp.Path = path;
            SysWatchLiveFeedComp.EnableRaisingEvents = true;
            SysWatchLiveFeedComp.IncludeSubdirectories = true;

            WatchingOutput.Text = "Currently Watching : " + SysWatchLiveFeedComp.Path.ToString();

            //Hide UI Elements
            Underline.Hide();
            OptionsMenu.Hide();
        }

        private int _eventcount = 0;

        private void SysWatchLiveFeed_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            RichTextBox output = this.Output;
            output.Text = string.Concat(new string[]
            {
                output.Text,
                Environment.NewLine,
                "  - File Changed - ",
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
                "  - File Created - ",
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
                "  - File Deleted - ",
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
                "  - File Renamed - ",
                e.Name,
                e.FullPath
            });
            Output.Text += Environment.NewLine;

            this._eventcount++;
            EventHeader.Text = "Events Logged : " + this._eventcount.ToString();
        }

        private void More_Click(object sender, EventArgs e)
        {
            if (OptionsMenu.Visible == false)
            {
                OptionsMenu.Visible = true;
                OptionsMenu.Show();

                Underline.Show();
            }
            else if (OptionsMenu.Visible == true)
            {
                OptionsMenu.Visible = false;
                OptionsMenu.Hide();

                Underline.Hide();
            }
        }

        private void EventToggle_Click(object sender, EventArgs e)
        {
            if (SysWatchLiveFeedComp.EnableRaisingEvents == true)
            {
                SysWatchLiveFeedComp.EnableRaisingEvents = false;
                EventToggle.BackgroundImage = SysWatchLiveFeed.Properties.Resources.icons8_toggle_off_96;
            }
            else if (SysWatchLiveFeedComp.EnableRaisingEvents == false)
            {
                SysWatchLiveFeedComp.EnableRaisingEvents = true;
                EventToggle.BackgroundImage = SysWatchLiveFeed.Properties.Resources.icons8_toggle_on_96;
            }
        }
        private void SubToggle_Click(object sender, EventArgs e)
        {
            if (SysWatchLiveFeedComp.IncludeSubdirectories == true)
            {
                SysWatchLiveFeedComp.IncludeSubdirectories = false;
                SubToggle.BackgroundImage = SysWatchLiveFeed.Properties.Resources.icons8_toggle_off_96;
            }
            else if (SysWatchLiveFeedComp.IncludeSubdirectories == false)
            {
                SysWatchLiveFeedComp.IncludeSubdirectories = true;
                SubToggle.BackgroundImage = SysWatchLiveFeed.Properties.Resources.icons8_toggle_on_96;
            }
        }

        private void MenuRoundedLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://icons8.com/icon/36389/menu-rounded");
        }
        private void ToggleOnLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://icons8.com/icon/88034/toggle-on");
        }
        private void ToggleOffLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://icons8.com/icon/20006/toggle-off");
        }

        private void ChangePath_Click(object sender, EventArgs e)
        {
            SelectPathPane.Show();

            SelectPathPane.BringToFront();
            SelectPathPane.Visible = true;
        }
        private void UpdatePath_Click(object sender, EventArgs e)
        {
            //Hide In Menu Pane
            SelectPathPane.Hide();

            SelectPathPane.SendToBack();
            SelectPathPane.Visible = false;

            //Update Path
            if (NewPathInput.Text == string.Empty)
            {
                if (NewPathInput.Visible == false)
                {
                    MessageBox.Show("Please Enter A Valid Path");
                    return;
                }
            }
            SysWatchLiveFeedComp.Path = NewPathInput.Text;
            WatchingOutput.Text = "Currently Watching : " + NewPathInput.Text;
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            _eventcount = 0;

            Output.Clear();
            EventHeader.Text = "Events Logged : " + this._eventcount.ToString();
        }
        private void CopyFeed_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Copied At  : " + DateTime.Now.ToShortTimeString() + Environment.NewLine + Output.Text.ToString());
        }
    }
}
