namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using Language.LUIS.Programmatic;
    using Newtonsoft.Json;
    using System;

    class AppEntitiesPage : BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public AppEntitiesPage(BaseProgram program) : base("Entities", program)
        { }

        public override void Display()
        {
            base.Display();

            var info = AwaitTask(Client.Model.ListEntitiesAsync(AppId, VersionId), true);

            var json = JsonConvert.SerializeObject(info, Formatting.Indented);

            Console.WriteLine(json);

            WaitForGoBack();
        }
    }
}
