using System.Reflection;

namespace LaunchFoundationGameCamera.Components
{
    // Very simple logging class.
    internal class Logger
    {
        private static string assembly_filename => $"{Assembly.GetExecutingAssembly().GetName().Name}";
        private static string filename => assembly_filename == null ? "log.txt" : $"{assembly_filename}_log.txt";

        public static void ClearLogFile()
        {
            File.WriteAllText(filename, string.Empty);
        }

        public static void Log(string text)
        {
            var line = $"[{DateTime.Now}] {text}";
            File.AppendAllText(filename, line);
        }

        public static void LogLine(string text)
        {
            var line = $"[{DateTime.Now}] {text}\n";
            File.AppendAllText(filename, line);
        }
    }
}
