namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using Language.LUIS.Programmatic;
    using System;

    class AppVersionDetailsPage : BasePage, IAppVersionPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public AppVersionDetailsPage(BaseProgram program) : base("Details", program)
        { }

        public override void Display()
        {
            base.Display();

            var info = AwaitTask(Client.Versions.GetAsync(AppId, VersionId), true);

            Print(info);

            WaitForGoBack();
        }
    }
}
