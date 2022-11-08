using LaunchFoundationGameCamera.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunchFoundationGameCamera
{
    public partial class ChangelogWindow : Form
    {
        private Updater Updater { get; init; }

        public ChangelogWindow(Updater updater)
        {
            InitializeComponent();
            Updater = updater;
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        private void ChangelogWindow_Load(object sender, EventArgs e)
        {
            try
            {
                richTextBox_Changelog.Text = Updater.GetChangelog();
            }
            catch
            {
                richTextBox_Changelog.Text = "Changelog unavailable.";
            }

            richTextBox_Changelog.ReadOnly = false;
            richTextBox_Changelog.TabStop = false;

            HideCaret(richTextBox_Changelog.Handle);
        }

        private void RichTextBox_Changelog_Click(object sender, EventArgs e)
        {
            HideCaret(richTextBox_Changelog.Handle);
        }

        private void RichTextBox_Changelog_SelectionChanged(object sender, EventArgs e)
        {
            ((RichTextBox)sender).SelectionLength = 0;
        }
    }
}
