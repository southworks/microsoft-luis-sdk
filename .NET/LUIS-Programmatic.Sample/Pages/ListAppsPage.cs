namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Newtonsoft.Json;
    using System;

    class ListAppsPage : BasePage
    {
        public ListAppsPage(MainProgram program)
            : base("Apps list", program)
        { }

        public override void Display()
        {
            base.Display();

            var apps = AwaitTask(Client.Apps.ListAsync());
            var json = JsonConvert.SerializeObject(apps, Formatting.Indented);

            Console.WriteLine(json);

            WaitForGoBack();
        }
    }
}
