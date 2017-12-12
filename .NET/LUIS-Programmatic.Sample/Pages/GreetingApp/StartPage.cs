﻿namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.GreetingApp
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;

    class StartPage : BaseStartPage
    {
        public StartPage(BaseProgram program) : base("Greeting App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine();
            Console.WriteLine("We'll create a new app with a single \"intent\" including the following utterances:");
            Console.WriteLine(" - Hi");
            Console.WriteLine(" - Hello");

            var greetingIntent = new ModelCreateObject
            {
                Name = "Greeting"
            };

            var intentId = AwaitTask(Client.Model.AddIntentAsync(this.AppId, this.VersionId, greetingIntent));

            Console.WriteLine($"{greetingIntent.Name} intent created with the id {intentId}");

            var utterances = new List<ExampleLabelObject>
            {
                new ExampleLabelObject("Hi", null, greetingIntent.Name),
                new ExampleLabelObject("Hello", null, greetingIntent.Name)
            };

            var utterancesResult = AwaitTask(Client.Examples.BatchAsync(this.AppId, this.VersionId, utterances));

            Console.WriteLine("Utterances added to the intent");

            NavigateWithInitializer<AddUtterancePage>((page) => {
                page.AppId = this.AppId;
                page.VersionId = this.VersionId;
                page.IntentName = greetingIntent.Name;
            });
        }
    }
}
