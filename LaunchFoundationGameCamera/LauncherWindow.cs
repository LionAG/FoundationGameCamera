using System.Diagnostics;
using System.Drawing.Text;

namespace LaunchFoundationGameCamera
{
    public partial class LauncherWindow : Form
    {
        private readonly PrivateFontCollection Fonts = new();

        public readonly string RepositoryOwner = "Nesae-avi";
        public readonly string RepositoryName = "FoundationGameCamera";
        private readonly string DiscordInvite = "discord.gg/VkskjDfJ";

        private string DiscordInviteLink => DiscordInvite.Insert(0, "https://");
        private string GithubRepositoryLink => $"https://github.com/{RepositoryOwner}/{RepositoryName}";
        private string CommonResourcePath => Path.Combine(Path.GetTempPath(), "GameCameraMod.dll");

        enum Website
        {
            Github,
            Discord
        }

        private readonly List<string> SupportedGames = new()
        {
            "ROTTR.exe",
            "SOTTR.exe" // Keep this only for the FOV Fix.
        };

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Game process id</returns>
        private int FindGameProcess()
        {
            // Try to find the game process id.

            foreach (var game in SupportedGames)
            {
                var processId = DllInjector.GetProcessId(game);

                if (processId != 0)
                    return processId;
            }

            return 0;
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

        private bool StartGameCamera()
        {
            Logger.LogLine("Starting Game Camera");

            int processId = FindGameProcess();

            if (processId != 0)
            {
                if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.GameCamera.dll", CommonResourcePath))
                {
                    Logger.LogLine("Cannot unpack the resource");
                    return false;
                }

                if (DllInjector.Inject(processId, CommonResourcePath))
                {
                    Logger.LogLine("Finished successfully");
                    return true;
                }
            }
            else
            {
                Logger.LogLine("No supported game is running");
            }

            return false;
        }

        private bool StartFoVFix()
        {
            Logger.LogLine("Starting FoV Fix");

            // Try to find the game process id.

            int processId = FindGameProcess();

            if (processId != 0)
            {
                if(Process.GetProcessById(processId).MainModule?.ModuleName == "ROTTR.exe")
                {
                    if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.FoV_ROTTR.dll", CommonResourcePath))
                    {
                        Logger.LogLine("Cannot unpack the resource");
                        return false;
                    }
                }
                else if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.FoV_SOTTR.dll", CommonResourcePath))
                {
                    Logger.LogLine("Cannot unpack the resource");
                    return false;
                }


                if (DllInjector.Inject(processId, CommonResourcePath))
                {
                    Logger.LogLine("Finished successfully");
                    return true;
                }
            }
            else
            {
                Logger.LogLine("No supported game is running");
            }

            return false;
        }

        private void LauncherWindow_Load(object sender, EventArgs e)
        {
            Text = $"Foundation Game Camera Launcher v{AppInformation.AssemblyVersion}";

            label_Header.Font = GetFontFromMemory(FontResource.PatrickHandSC_Regular, 14.0f, FontStyle.Bold);
            label_ClickHere.Font = GetFontFromMemory(FontResource.Lato_Bold, 10.0f, FontStyle.Bold);
            label_LoadingInfo.Font = GetFontFromMemory(FontResource.Lato_Regular, 10.0f);
            label_Supportinfo.Font = GetFontFromMemory(FontResource.Lato_Regular, 10.0f);
        }

        private void PictureBox_Github_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Github);
        }

        private void Label_Supportinfo_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Discord);
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if(!StartGameCamera())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_LoadFovFix_Click(object sender, EventArgs e)
        {
            if(!StartFoVFix())
            {
                MessageBox.Show("Process failed, check the log file for details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LauncherWindow_Shown(object sender, EventArgs e)
        {
            var updater = new Updater(RepositoryName, RepositoryOwner);

            try
            {
                if (updater.IsUpdateAvailable())
                {
                    var latestVersion = updater.GetLatestVersionFromTag();

                    if (MessageBox.Show($"The application will update to version {latestVersion} and restart automatically.",
                                        "Update check",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        updater.TryUpdateApplication();
                    }

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Logger.LogLine($"Update error: {ex.Message}");
            }
        }

        private void PictureBox_License_Click(object sender, EventArgs e)
        {
            var licenseFile = "License.txt";

            if (File.Exists(licenseFile) == false)
            {
                ResourceUnpacker.Unpack("LaunchFoundationGameCamera.License.txt", licenseFile);
            }

            Process.Start("notepad.exe", licenseFile);
        }

        private void Label_ClickHere_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Discord);
        }
    }
}