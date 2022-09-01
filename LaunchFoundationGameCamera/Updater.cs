using Octokit;
using System.Diagnostics;

namespace LaunchFoundationGameCamera
{
    internal class Updater
    {
        private string RepositoryName { get; init; }
        private string RepositoryOwner { get; init; }
        private GitHubClient GitHub { get; init; }

        public Updater(string repositoryName, string repositoryOwner)
        {
            GitHub = new GitHubClient(new ProductHeaderValue("FoundationGameCamera"));
            RepositoryName = repositoryName;
            RepositoryOwner = repositoryOwner;
        }

        public string? GetLatestVersionFromTag()
        {
            var releases = GitHub.Repository.Release.GetAll(RepositoryOwner, RepositoryName).Result;

            if (releases.Count > 0)
            {
                var latest = releases[0];
                return latest.TagName;
            }

            return null;
        }

        public bool IsUpdateAvailable()
        {
            var latestVersion = GetLatestVersionFromTag();

            if (latestVersion != null)
            {
                if (!latestVersion.Equals(AppInformation.ApplicationVersion, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        public bool TryUpdateApplication()
        {
            try
            {
                if (IsUpdateAvailable())
                {
                    var releases = GitHub.Repository.Release.GetAll(RepositoryOwner, RepositoryName).Result;

                    if (releases.Count > 0)
                    {
                        var latest = releases[0];

                        var launcherAsset = latest.Assets.FirstOrDefault(a => a.Name.Contains(AppInformation.AssemblyName, StringComparison.OrdinalIgnoreCase));

                        if (launcherAsset != default)
                        {
                            // Rename the old version

                            var currentExecutableName = Path.GetFileName(System.Windows.Forms.Application.ExecutablePath);
                            var currentExecutableNewName = Path.GetRandomFileName();
                            var currentExecutableNewPath = Path.Combine(Directory.GetCurrentDirectory(), currentExecutableNewName);

                            File.Move(currentExecutableName, currentExecutableNewName);

                            // Download the new version.

                            var destinationFileName = launcherAsset.Name;

                            using var client = new HttpClient();
                            using var stream = client.GetStreamAsync(launcherAsset.BrowserDownloadUrl).Result;
                            using var fileStream = new FileStream(destinationFileName, System.IO.FileMode.Create);

                            stream.CopyTo(fileStream);
                            fileStream.Close();

                            // Start the new version, schedule deleting of the old version to clean the user directory
                            // and close the current instance.

                            Process.Start(destinationFileName);

                            Process.Start(new ProcessStartInfo()
                            {
                                Arguments = "/C choice /C Y /N /D Y /T 2 & Del \"" + currentExecutableNewPath + "\"",
                                WindowStyle = ProcessWindowStyle.Hidden,
                                CreateNoWindow = true,
                                FileName = "cmd.exe"
                            });

                            System.Windows.Forms.Application.Exit();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.LogLine(e.Message);
            }

            return false;
        }
    }
}