namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using Language.LUIS.Programmatic;
    using Newtonsoft.Json;
    using System;

    class AppVersionIntentsPage : BasePage, IAppVersionPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public AppVersionIntentsPage(BaseProgram program) : base("Intents", program)
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
