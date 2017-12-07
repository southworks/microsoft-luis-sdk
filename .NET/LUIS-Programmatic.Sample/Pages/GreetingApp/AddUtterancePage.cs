namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.GreetingApp
{
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using System;

    class AddUtterancePage : BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }
        public string IntentName { get; set; }

        public AddUtterancePage(BaseProgram program) : base("Add utterances", program)
        { }

        public override void Display()
        {
            base.Display();

            var newUtterance = new ExampleLabelObject
            {
                IntentName = IntentName
            };

            var addNew = Input.ReadString("Do you want to add additional utterances? (y/n) ");

            while (addNew.Trim().ToLowerInvariant().StartsWith("y"))
            {
                newUtterance.Text = Input.ReadString("Type new utterance: ");

                var result = AwaitTask(Client.Examples.AddAsync(AppId, VersionId, newUtterance), false);

                Console.WriteLine($"Utterance \"{newUtterance.Text}\" added to the intent {IntentName}\n");

                addNew = Input.ReadString("Do you want to add additional utterances? (y/n) ");
            }

            NavigateWithInitializer<TrainAppPage>((page) => {
                page.AppId = AppId;
                page.VersionId = VersionId;
            });
        }
    }
}
