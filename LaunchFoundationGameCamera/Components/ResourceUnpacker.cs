using System.Reflection;

namespace LaunchFoundationGameCamera.Components
{
    internal class ResourceUnpacker
    {
        public static bool Unpack(string resourceName, string filePath)
        {
            using var s = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);

            if (s is Stream stream)
            {
                try
                {
                    using var fileStream = new FileStream(filePath, FileMode.Create);

                    byte[] buf = new byte[stream.Length];
                    stream.Read(buf, 0, buf.Length);

                    fileStream.Write(buf, 0, buf.Length);
                }
                catch (Exception e)
                {
                    Logger.LogLine($"Cannot unpack: {e.Message}");
                    return false;
                }
            }
            else
            {
                Logger.LogLine($"Cannot find the requested resource: {resourceName}");
                return false;
            }

            return true;
        }
    }
}
