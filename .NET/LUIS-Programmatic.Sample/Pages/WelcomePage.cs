namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using EasyConsole;
    using System;

    class WelcomePage : BaseMenuPage
    {
        public WelcomePage(MainProgram program) : base("Welcome Page", program,
            new Option("Start wizard", () => program.NavigateTo<TemplateSelectorPage>()),
            new Option("Manage Apps", () => program.NavigateTo<Management.ListAppsPage>()),
            new Option("Exit", () => Environment.Exit(0)))
        { }
    }
}
