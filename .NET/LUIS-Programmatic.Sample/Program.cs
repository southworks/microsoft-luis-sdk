namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample
{
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages;
    using BookingApp = Pages.BookingApp;
    using GreetingApp = Pages.GreetingApp;
    using RetailApp = Pages.RetailApp;

    public class MainProgram : Program
    {
        public ILuisProgrammaticAPI Client { get; private set; }

        public MainProgram(ILuisProgrammaticAPI client) : base("LUIS Programmatic API Demo", true)
        {
            Client = client;
            AddPage(new WelcomePage(this));
            AddPage(new TemplateSelectorPage(this));
            AddPage(new BookingApp.StartPage(this));
            AddPage(new GreetingApp.StartPage(this));
            AddPage(new RetailApp.StartPage(this));
            AddPage(new TrainAppPage(this));
            AddPage(new FinishWizardPage(this));
            SetPage<WelcomePage>();
        }
    }
}
