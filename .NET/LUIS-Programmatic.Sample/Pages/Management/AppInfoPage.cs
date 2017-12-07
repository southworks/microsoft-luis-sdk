namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using System;

    class AppInfoPage : BaseMenuPage
    {
        public Guid AppId { get; set; }
        public AppInfoPage(MainProgram program) : base("Details", program)
        { }

        public override void Display()
        {
            SafeAddToMenu(new Option("View Details", () => NavigateWithInitializer<AppDetailsPage>((page) => page.AppId = AppId)));
            base.Display();
        }
    }
}
