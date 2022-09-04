using LaunchFoundationGameCamera.Components;
using LaunchFoundationGameCamera.Styling;
using System.Diagnostics;
using System.Drawing.Text;

namespace LaunchFoundationGameCamera
{
    public partial class LauncherWindow : Form
    {
        private readonly PrivateFontCollection Fonts = new();
        private readonly ModLauncher Launcher = new();

        public readonly string RepositoryOwner = "Nesae-avi";
        public readonly string RepositoryName = "FoundationGameCamera";
        private readonly string DiscordInvite = "discord.gg/tugaUeTvUP";

        private string DiscordInviteLink => DiscordInvite.Insert(0, "https://");
        private string GithubRepositoryLink => $"https://github.com/{RepositoryOwner}/{RepositoryName}";

        enum Website
        {
            Github,
            Discord
        }

        public LauncherWindow()
        {
            InitializeComponent();
        }

        // wingdi.h
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont,
                                                          uint cbFont,
                                                          IntPtr pdv,
                                                          [System.Runtime.InteropServices.In] ref uint pcFonts);

        protected Font GetFontFromMemory(byte[] data, float size, FontStyle style = FontStyle.Regular)
        {
            // Loading fonts, credits to knighter (https://stackoverflow.com/questions/556147/how-do-i-embed-my-own-fonts-in-a-winforms-app)

            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
            System.Runtime.InteropServices.Marshal.Copy(data, 0, fontPtr, data.Length);

            uint dummy = 0;
            Fonts.AddMemoryFont(fontPtr, data.Length);
            AddFontMemResourceEx(fontPtr, (uint)data.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(Fonts.Families[0], size, style);
        }

        private void OpenWebsite(Website site)
        {
            string link = GithubRepositoryLink;

            switch (site)
            {
                case Website.Github: link = GithubRepositoryLink; break;
                case Website.Discord: link = DiscordInviteLink; break;
                default: break;
            }

            ProcessStartInfo psi = new(link)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void OpenLicense()
        {
            var licenseFile = "License.txt";
            var licenseFilePath = Path.Combine(Path.GetTempPath(), licenseFile);

            if (File.Exists(licenseFile) == false)
            {
                ResourceUnpacker.Unpack("LaunchFoundationGameCamera.License.txt", licenseFilePath);
            }

            Process.Start("notepad.exe", licenseFilePath);
        }

        private void LauncherWindow_Load(object sender, EventArgs e)
        {
            Text = $"Foundation Game Camera Launcher v{AppInformation.AssemblyVersion}";

            label_Header.Font = GetFontFromMemory(FontResource.PatrickHandSC_Regular, 14.0f, FontStyle.Bold);
            label_ClickHere.Font = GetFontFromMemory(FontResource.Lato_Bold, 10.0f, FontStyle.Bold);
            label_LoadingInfo.Font = GetFontFromMemory(FontResource.Lato_Regular, 10.0f);
            label_Supportinfo.Font = GetFontFromMemory(FontResource.Lato_Regular, 10.0f);

            menuStrip1.Renderer = new TopMenuRenderer();
            
            Logger.ClearLogFile();
            Logger.LogLine($"{AppInformation.AssemblyName} v{AppInformation.ApplicationVersion} started!");
        }

        private void Label_Supportinfo_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Discord);
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (!Launcher.StartGameCamera())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LauncherWindow_Shown(object sender, EventArgs e)
        {
#if !DEBUG
            var updater = new Updater(RepositoryName, RepositoryOwner);

            try
            {
                if (updater.IsUpdateAvailable())
                {
                    updater.TryUpdateApplication();
                }
            }
            catch (Exception ex)
            {
                Logger.LogLine($"Update error: {ex.Message}");
            }
#endif
        }

        private void Label_ClickHere_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Discord);
        }

        private void ToolStripMenuItem_OpenGithub_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Github);
        }

        private void OpenDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Discord);
        }

        private void ViewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLicense();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updater = new Updater(RepositoryName, RepositoryOwner);

            try
            {
                if (updater.IsUpdateAvailable())
                {
                    if (MessageBox.Show($"Update to version {updater.GetLatestVersionFromTag()} is available. Do you want to download it now?",
                                    "Update check",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        updater.TryUpdateApplication();
                    }
                }
                else
                {
                    MessageBox.Show("No updates are available.", "Update check", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                Logger.LogLine($"Update error: {ex.Message}");
            }
        }

        private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoVMediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Launcher.StartFoVMediumPreset())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExpandedPhotoModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Launcher.StartExpandedPhotoMode())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FoVLowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Launcher.StartFoVLowPreset())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FoVHighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Launcher.StartFoVHighPreset())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}