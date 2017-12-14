namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using Newtonsoft.Json;
    using System;
    using System.IO;

    class AppExportPage : BasePage, IAppPage
    {
        public Guid AppId { get; set; }

        public AppExportPage(BaseProgram program) : base("Export", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Preparing app to export...");

            var versions = AwaitTask(Client.Versions.ListAsync(AppId));

            Console.WriteLine("Select version to export");
            var versionId = "";
            var menuVersion = new Menu();
            foreach (var version in versions)
            {
                menuVersion.Add($"v{version.Version} [{version.TrainingStatus}]", () => versionId = version.Version);
            }
            menuVersion.Display();

            Console.WriteLine("Exporting app...");

            try
            {
                var result = AwaitTask(Client.Versions.ExportAsync(AppId, versionId));
                var export = JsonConvert.SerializeObject(result, Formatting.Indented);

                var defaultPath = Path.Combine(Directory.GetCurrentDirectory(), $"luis-{DateTime.UtcNow.Ticks}.json");

                var path = Input.ReadString($"Enter the location to export: (default {defaultPath}) ").Trim();

                if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(Path.GetDirectoryName(path)))
                {
                    path = defaultPath;
                }

                File.WriteAllText(path, export);

                Console.WriteLine("Your app has been exported.");
                Print(result);
            }
            catch (Exception ex)
            {
                var message = (ex as ErrorResponseException)?.Body.Message ?? ex.Message;
                Console.WriteLine($"Error importing the application. Err: {message}");
            }

            WaitForGoBack();
        }
    }
}
