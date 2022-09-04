using System.Diagnostics;

namespace LaunchFoundationGameCamera.Components
{
    internal class ModLauncher
    {
        private string CommonResourcePath => Path.Combine(Path.GetTempPath(), "GameCameraMod.dll");

        private readonly Dictionary<string, string[]> SupportedGames = new()
        {
            { "gamecamera", new string[] { "ROTTR.exe" } },

            { "fov", new string[] { "ROTTR.exe", "SOTTR.exe" } },

            { "expandedphotomode", new string[] { "SOTTR.exe" } },
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns>ID of the game process</returns>
        private int FindGameProcess(string[] processes)
        {
            // Try to find the game process id.

            foreach (var process in processes)
            {
                var processId = DllInjector.GetProcessId(process);

                if (processId != 0)
                    return processId;
            }

            return 0;
        }

        public bool StartGameCamera()
        {
            Logger.LogLine("Starting Game Camera");

            if (SupportedGames.TryGetValue("gamecamera", out var games))
            {
                int processId = FindGameProcess(games);

                if (processId != 0)
                {
                    if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.Mod.GameCamera_ROTTR_D3D11.dll", CommonResourcePath))
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
            }

            return false;
        }

        public bool StartFoV()
        {
            Logger.LogLine("Starting FoV Mod");

            if (SupportedGames.TryGetValue("fov", out var games))
            {
                int processId = FindGameProcess(games);

                if (processId != 0)
                {
                    if (Process.GetProcessById(processId).MainModule?.ModuleName == "ROTTR.exe")
                    {
                        if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.Mod.FoV_ROTTR.dll", CommonResourcePath))
                        {
                            Logger.LogLine("Cannot unpack the resource");
                            return false;
                        }
                    }
                    else if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.Mod.FoV_SOTTR.dll", CommonResourcePath))
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
            }

            return false;
        }

        public bool StartExpandedPhotoMode()
        {
            Logger.LogLine("Starting Expanded Photo Mode");

            if (SupportedGames.TryGetValue("expandedphotomode", out var games))
            {
                int processId = FindGameProcess(games);

                if (processId != 0)
                {
                    if (!ResourceUnpacker.Unpack("LaunchFoundationGameCamera.Mod.ExpandedPhotoMode.dll", CommonResourcePath))
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
            }

            return false;
        }
    }
}
