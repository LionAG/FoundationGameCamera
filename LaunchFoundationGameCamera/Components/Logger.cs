using System.Reflection;

namespace LaunchFoundationGameCamera.Components
{
    // Very simple logging class.
    internal class Logger
    {
        private static string Assembly_filename => $"{Assembly.GetExecutingAssembly().GetName().Name}";
        private static string Filename => Assembly_filename == null ? "log.txt" : $"{Assembly_filename}_log.txt";

        public static void ClearLogFile()
        {
            File.WriteAllText(Filename, string.Empty);
        }

        public static void Log(string text)
        {
            var line = $"[{DateTime.Now}] {text}";
            File.AppendAllText(Filename, line);
        }

        public static void LogLine(string text)
        {
            var line = $"[{DateTime.Now}] {text}\n";
            File.AppendAllText(Filename, line);
        }
    }
}
