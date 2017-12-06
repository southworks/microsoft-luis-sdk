using EasyConsole;
using System;

namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    class MainPage : MenuPage
    {
        public MainPage(Program program)
            : base("Main Page", program, 
                  new Option("Show all apps", () => program.NavigateTo<ListAppsPage>()),
                  new Option("Exit", () => Environment.Exit(0)))
        {
        }
    }
}
