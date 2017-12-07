namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using System;

    class AppInfoPage : BaseMenuPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public AppInfoPage(BaseProgram program) : base("Details", program)
        { }

        public override void Display()
        {
            Menu = new Menu();
            SafeAddToMenu(new Option("View Details", () => NavigateWithInitializer<AppDetailsPage>(page => page.AppId = AppId)));
            SafeAddToMenu(new Option("View Intents", () => NavigateWithInitializer<AppIntentsPage>(page =>
            {
                page.AppId = AppId;
                page.VersionId = VersionId;
            })));
            SafeAddToMenu(new Option("View Entites", () => NavigateWithInitializer<AppEntitiesPage>(page =>
            {
                page.AppId = AppId;
                page.VersionId = VersionId;
            })));
            SafeAddToMenu(new Option("Train", () => NavigateWithInitializer<AppTrainPage>(page =>
            {
                page.AppId = AppId;
                page.VersionId = VersionId;
            })));

            base.Display();
        }
    }
}
