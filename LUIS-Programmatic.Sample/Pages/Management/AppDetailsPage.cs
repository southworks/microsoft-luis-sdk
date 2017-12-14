namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using Language.LUIS.Programmatic;
    using System;

    class AppDetailsPage : BasePage, IAppPage
    {
        public Guid AppId { get; set; }

        public AppDetailsPage(BaseProgram program) : base("Details", program)
        { }

        public override void Display()
        {
            base.Display();

            var info = AwaitTask(Client.Apps.GetAsync(AppId), true);

            Print(info);

            WaitForGoBack();
        }
    }
}
