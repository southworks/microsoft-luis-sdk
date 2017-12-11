namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using System;
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;

    class CreateAppPage<StartPageType>: BasePage where StartPageType : BaseStartPage
    {
        public CreateAppPage(BaseProgram program) : base("Create App", program)
        { }

        public override void Display()
        {
            base.Display();

            var defaultAppName = $"Contoso-{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
            var versionId = "0.1";

            var appName = Input.ReadString($"Enter your App's name: (default {defaultAppName})");

            if (string.IsNullOrWhiteSpace(appName))
            {
                appName = defaultAppName;
            }

            var newApp = new ApplicationCreateObject
            {
                Name = appName,
                InitialVersionId = versionId,
                Description = "New App created with LUIS SDK wizard",
                Culture = "en-us",
                Domain = "",
                UsageScenario = ""
            };

            var appId = AwaitTask(Client.Apps.AddAsync(newApp));

            Console.WriteLine($"{appName} app created with the id {appId}");

            NavigateWithInitializer<StartPageType>((page) => {
                page.AppId = appId;
                page.VersionId = versionId;
            });
        }
    }
}