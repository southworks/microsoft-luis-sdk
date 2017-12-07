namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using Language.LUIS.Programmatic;
    using Newtonsoft.Json;
    using System;

    class AppIntentsPage : BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public AppIntentsPage(BaseProgram program) : base("Intents", program)
        { }

        public override void Display()
        {
            base.Display();

            var info = AwaitTask(Client.Model.ListIntentsAsync(AppId, VersionId), true);

            var json = JsonConvert.SerializeObject(info, Formatting.Indented);

            Console.WriteLine(json);

            WaitForGoBack();
        }
    }
}
