namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample
{
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages;
    using BookingApp = Pages.BookingApp;
    using GreetingApp = Pages.GreetingApp;
    using RetailApp = Pages.RetailApp;
    using Management = Pages.Management;

    public class BaseProgram : Program
    {
        public ILuisProgrammaticAPI Client { get; private set; }

        public BaseProgram(ILuisProgrammaticAPI client) : base("LUIS Programmatic API Demo", true)
        {
            Client = client;
            AddPage(new WelcomePage(this));

            AddPage(new Management.ListAppsPage(this));
            AddPage(new Management.AppInfoPage(this));
            AddPage(new Management.AppDetailsPage(this));
            AddPage(new Management.AppIntentsPage(this));
            AddPage(new Management.AppEntitiesPage(this));
            AddPage(new Management.AppTrainPage(this));
            AddPage(new Management.AppDeletePage(this));

            AddPage(new GreetingApp.StartPage(this));
            AddPage(new GreetingApp.AddUtterancePage(this));

            AddPage(new BookingApp.StartPage(this));

            AddPage(new RetailApp.StartPage(this));

            AddPage(new TemplateSelectorPage(this));
            AddPage(new TrainAppPage(this));
            AddPage(new PublishAppPage(this));
            AddPage(new ShareAppPage(this));

            SetPage<WelcomePage>();
        }
    }
}
