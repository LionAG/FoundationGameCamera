using System.Reflection;

namespace LaunchFoundationGameCamera
{
    internal static class AppInformation
    {
        public static readonly string Prerelease = "";

        public static string AssemblyName
        {
            get
            {
                var name = Assembly.GetExecutingAssembly().GetName().Name;

                if (name == null)
                    throw new Exception("Cannot retrieve assembly name!");

                return name;
            }
        }
        public static string? AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version?.ToString(3);

        public static string? ApplicationVersion
        {
            get
            {
                if (!string.IsNullOrEmpty(Prerelease))
                {
                    return $"{AssemblyVersion}-{Prerelease}";
                }

                return AssemblyVersion;
            }
        }
    }
}
