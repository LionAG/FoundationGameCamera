using System.Diagnostics;
using System.Reflection;

namespace LaunchFoundationGameCamera.Components
{
    // Very simple logging class.
    internal class Logger
    {
        private static string Assembly_filename => $"{Assembly.GetExecutingAssembly().GetName().Name}";
        public static string FilePath => Path.Combine(Path.GetTempPath(), $"{Assembly_filename}_log.txt");

        public static bool OpenLogFile()
        {
            if (File.Exists(FilePath) == false)
            {
                return false;
            }

            Process.Start("notepad.exe", FilePath);

            return true;
        }

        public static void ClearLogFile()
        {
            File.WriteAllText(FilePath, string.Empty);
        }

        public static void Log(string text)
        {
            var line = $"[{DateTime.Now}] {text}";
            File.AppendAllText(FilePath, line);
        }

        public static void LogLine(string text)
        {
            var line = $"[{DateTime.Now}] {text}\n";
            File.AppendAllText(FilePath, line);
        }
    }
}
