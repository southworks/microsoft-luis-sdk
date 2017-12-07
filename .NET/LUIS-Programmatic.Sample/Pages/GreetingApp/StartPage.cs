namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.GreetingApp
{
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using System;
    using System.Collections.Generic;

    class StartPage : BasePage
    {
        public StartPage(BaseProgram program) : base("Greeting App", program)
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

            Console.WriteLine();
            Console.WriteLine("We'll create a new app with a single \"intent\" including the following utterances:");
            Console.WriteLine(" - Hi");
            Console.WriteLine(" - Hello");

            var newApp = new ApplicationCreateObject
            {
                Name = appName,
                InitialVersionId = versionId,
                Description = "GreetingApp created with LUIS SDK wizard",
                Culture = "en-us",
                Domain = "",
                UsageScenario = ""
            };

            var appId = AwaitTask(Client.Apps.AddAsync(newApp));

            Console.WriteLine($"{appName} app created with the id {appId}");

            var greetingIntent = new ModelCreateObject
            {
                Name = "Greeting"
            };

            var intentId = AwaitTask(Client.Model.AddIntentAsync(appId, versionId, greetingIntent));

            Console.WriteLine($"{greetingIntent.Name} intent created with the id {intentId}");

            var utterances = new List<ExampleLabelObject>
            {
                new ExampleLabelObject("Hi", null, greetingIntent.Name),
                new ExampleLabelObject("Hello", null, greetingIntent.Name)
            };

            var utterancesResult = AwaitTask(Client.Examples.BatchAsync(appId, versionId, utterances));

            Console.WriteLine("Utterances added to the intent");

            NavigateWithInitializer<AddUtterancePage>((page) => {
                page.AppId = appId;
                page.VersionId = versionId;
                page.IntentName = greetingIntent.Name;
            });
        }
    }
}
