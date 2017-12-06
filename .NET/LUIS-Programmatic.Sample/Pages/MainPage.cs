namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using EasyConsole;
    using System;

    class MainPage : BaseMenuPage
    {
        public MainPage(MainProgram program)
            : base("Main Page", program, 
                  new Option("Show all apps", () => program.NavigateTo<ListAppsPage>()),
                  new Option("Exit", () => Environment.Exit(0)))
        { }
    }
}
