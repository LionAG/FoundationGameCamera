using System.Diagnostics;

namespace LaunchFoundationGameCamera.Components
{
    internal class ModEntryData
    {
        public string GameExecutable { get; init; }
        public string ModFileResource { get; init; }

        public ModEntryData(string gameExecutable, string modFileResource)
        {
            GameExecutable = gameExecutable;
            ModFileResource = modFileResource;
        }
    }

    internal class ModLauncher
    {
        private string CommonResourcePath => Path.Combine(Path.GetTempPath(), "GameCameraMod.dll");

        private readonly Dictionary<string, ModEntryData[]> SupportedGames = new()
        {
            { "game_camera", new ModEntryData[]
            {
                new ModEntryData("ROTTR.exe", "LaunchFoundationGameCamera.Mod.GameCamera_ROTTR_D3D11.dll") 
            } },

            { "fov_low", new ModEntryData[] 
            {
                new ModEntryData("ROTTR.exe", "LaunchFoundationGameCamera.Mod.FoV_ROTTR_Low.dll"),
                new ModEntryData("SOTTR.exe", "LaunchFoundationGameCamera.Mod.FoV_SOTTR_Low.dll")
            } },

            { "fov_medium", new ModEntryData[]
            {
                new ModEntryData("ROTTR.exe", "LaunchFoundationGameCamera.Mod.FoV_ROTTR_Medium.dll"),
                new ModEntryData("SOTTR.exe", "LaunchFoundationGameCamera.Mod.FoV_SOTTR_Medium.dll")
            } },

            { "fov_high", new ModEntryData[]
            {
                new ModEntryData("ROTTR.exe", "LaunchFoundationGameCamera.Mod.FoV_ROTTR_High.dll"),
                new ModEntryData("SOTTR.exe", "LaunchFoundationGameCamera.Mod.FoV_SOTTR_High.dll")
            } },

            { "expanded_photo_mode", new ModEntryData[]
            {
                new ModEntryData("SOTTR.exe", "LaunchFoundationGameCamera.Mod.ExpandedPhotoMode.dll")
            } },
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns>ID of the game process</returns>
        private bool FindGameProcess(ModEntryData[] data, out ModEntryData foundGame, out int processId)
        {
            // Try to find the game process id.

            foreach (var gameData in data)
            {
                var id = DllInjector.GetProcessId(gameData.GameExecutable);

                if (id != 0)
                {
                    foundGame = gameData;
                    processId = id;

                    return true;
                }
            }

            foundGame = new("Unknown", "Unknown");
            processId = 0;

            return false;
        }

        private bool LoadMod(ModEntryData[] games)
        {
            if (FindGameProcess(games, out var foundGame, out var processId))
            {
                if (!ResourceUnpacker.Unpack(foundGame.ModFileResource, CommonResourcePath))
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

        public bool StartGameCamera()
        {
            Logger.LogLine("Starting Game Camera");

            if (SupportedGames.TryGetValue("game_camera", out var games))
            {
                return LoadMod(games);
            }

            return false;
        }

        public bool StartFoVMediumPreset()
        {
            Logger.LogLine("Starting FoV Mod - Preset Medium");

            if (SupportedGames.TryGetValue("fov_medium", out var games))
            {
                return LoadMod(games);
            }

            return false;
        }

        public bool StartFoVLowPreset()
        {
            Logger.LogLine("Starting FoV Mod - Preset Low");

            if (SupportedGames.TryGetValue("fov_low", out var games))
            {
                return LoadMod(games);
            }

            return false;
        }

        public bool StartFoVHighPreset()
        {
            Logger.LogLine("Starting FoV Mod - Preset High");

            if (SupportedGames.TryGetValue("fov_high", out var games))
            {
                return LoadMod(games);
            }

            return false;
        }

        public bool StartExpandedPhotoMode()
        {
            Logger.LogLine("Starting Expanded Photo Mode");

            if (SupportedGames.TryGetValue("expanded_photo_mode", out var games))
            {
                return LoadMod(games);
            }

            return false;
        }
    }
}
