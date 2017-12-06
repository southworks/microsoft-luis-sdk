namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using EasyConsole;

    class TemplateSelectorPage : BaseMenuPage
    {
        public TemplateSelectorPage(MainProgram program) : base("Template Selector", program,
            new Option("Greeting App", () => program.NavigateTo<GreetingApp.StartPage>()),
            new Option("Retail App", () => program.NavigateTo<RetailApp.StartPage>()),
            new Option("Booking App", () => program.NavigateTo<BookingApp.StartPage>()))
        { }
    }
}
