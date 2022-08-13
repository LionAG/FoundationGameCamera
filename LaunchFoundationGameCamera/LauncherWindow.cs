using System.Diagnostics;
using System.Drawing.Text;

namespace LaunchFoundationGameCamera
{
    public partial class LauncherWindow : Form
    {
        // wingdi.h
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont,
                                                          uint cbFont,
                                                          IntPtr pdv,
                                                          [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new();
        protected Font GetFontFromMemory(byte[] data, float size, FontStyle style = FontStyle.Regular)
        {
            // Loading fonts, credits to knighter (https://stackoverflow.com/questions/556147/how-do-i-embed-my-own-fonts-in-a-winforms-app)

            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(data.Length);
            System.Runtime.InteropServices.Marshal.Copy(data, 0, fontPtr, data.Length);

            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, data.Length);
            AddFontMemResourceEx(fontPtr, (uint)data.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return new Font(fonts.Families[0], size, style);
        }

        enum Website
        {
            Github,
            Element
        }

        private readonly string ElementInvite = "matrix.to/#/!RkOTHGOlafTBzYSfzC:matrix.org?via=matrix.org";
        private string ElementInviteLink => ElementInvite.Insert(0, "https://");

        public readonly string RepositoryOwner = "Nesae-avi";
        public readonly string RepositoryName = "FoundationGameCamera";
        private string GithubRepositoryLink => $"https://github.com/{RepositoryOwner}/{RepositoryName}";

        private readonly List<string> SupportedGames = new()
        {
            "ROTTR.exe",
            "SOTTR.exe" // Keep this only for the FOV Fix.
        };

        public LauncherWindow()
        {
            InitializeComponent();
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
                case Website.Element: link = ElementInviteLink; break;
                default: break;
            }

            ProcessStartInfo psi = new(link)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void StartFGC()
        {
            Logger.LogLine("Starting FGC");

            int processId = FindGameProcess();

            if (processId != 0)
            {
                var dllPath = Path.Combine(Path.GetTempPath(), "FoundationGameCamera.dll");

                if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.GameCamera.dll", dllPath))
                {
                    Logger.LogLine("Cannot unpack the resource");
                    return;
                }

                if (DllInjector.Inject(processId, dllPath))
                {
                    Logger.LogLine("Finished successfully");
                }
            }
            else
            {
                Logger.LogLine("No supported game is running");
                return;
            }
        }

        private void StartFovFix()
        {
            Logger.LogLine("Starting FoV fix");

            // Try to find the game process id.

            int processId = FindGameProcess();

            if (processId != 0)
            {
                var dllPath = Path.Combine(Path.GetTempPath(), "FoVFix.dll");

                if(Process.GetProcessById(processId).MainModule?.ModuleName == "ROTTR.exe")
                {
                    if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.FoV_ROTTR.dll", dllPath))
                    {
                        Logger.LogLine("Cannot unpack the resource");
                        return;
                    }
                }
                else if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.FoV_SOTTR.dll", dllPath))
                {
                    Logger.LogLine("Cannot unpack the resource");
                    return;
                }


                if (DllInjector.Inject(processId, dllPath))
                {
                    Logger.LogLine("Finished successfully");
                }
            }
            else
            {
                Logger.LogLine("No supported game is running");
                return;
            }
        }

        private void LauncherWindow_Load(object sender, EventArgs e)
        {
            Text = $"Foundation Game Camera Launcher v{AppInformation.AssemblyVersion}";

            label_Header.Font = GetFontFromMemory(FontResource.PatrickHandSC_Regular, 14.0f, FontStyle.Bold);
            label_LoadingInfo.Font = GetFontFromMemory(FontResource.Lato_Regular, 10.0f);
            label_Supportinfo.Font = GetFontFromMemory(FontResource.Lato_Regular, 10.0f);

            label_Supportinfo.Text = $"For support, troubleshooting and sharing screen captures join the element chat: [CLICK HERE]";
        }

        private void PictureBox_Github_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Github);
        }

        private void Label_Supportinfo_Click(object sender, EventArgs e)
        {
            OpenWebsite(Website.Element);
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            StartFGC();
        }

        private void Button_LoadFovFix_Click(object sender, EventArgs e)
        {
            StartFovFix();
        }

        private void LauncherWindow_Shown(object sender, EventArgs e)
        {
            var updater = new Updater(RepositoryName, RepositoryOwner);

            try
            {
                if (updater.IsUpdateAvailable())
                {
                    var latestVersion = updater.GetLatestVersionFromTag();

                    if (MessageBox.Show($"Select OK to update the application to version {latestVersion}. The program will restart automatically.",
                                        "Update check",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        updater.TryUpdateApplication();
                    }

                    System.Windows.Forms.Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Logger.LogLine($"Update error: {ex.Message}");
            }
        }

        private void pictureBox_License_Click(object sender, EventArgs e)
        {
            var licenseFile = "License.txt";

            if (System.IO.File.Exists(licenseFile) == false)
            {
                ResourceUnpacker.Unpack("LaunchFoundationGameCamera.License.txt", licenseFile);
            }

            Process.Start("notepad.exe", licenseFile);
        }
    }
}