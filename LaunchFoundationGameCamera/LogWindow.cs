using System.Diagnostics;

namespace LaunchFoundationGameCamera
{
    public partial class LogWindow : Form
    {
        private string LogFilePath { get; init; }

        public LogWindow(string logFilePath)
        {
            InitializeComponent();
            LogFilePath = logFilePath;
        }

        private void LogWindow_Load(object sender, EventArgs e)
        {
            if (File.Exists(LogFilePath))
            {
                richTextBox_LogData.Text = File.ReadAllText(LogFilePath);
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            File.Copy(LogFilePath, "launcher_log.txt", true);

            if (DialogResult.Yes == MessageBox.Show("Log file saved in the launcher's working directory. Open it?",
                                                   "Information",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Asterisk))
            {
                Process.Start("explorer.exe", Directory.GetCurrentDirectory());
            }
        }
    }
}
