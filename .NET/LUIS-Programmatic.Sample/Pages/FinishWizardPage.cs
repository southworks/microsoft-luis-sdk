namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using EasyConsole;
    using System;

    class FinishWizardPage : BaseMenuPage
    {
        public FinishWizardPage(MainProgram program) : base("End of wizard", program,
            new Option("Go to the start page", () => program.NavigateHome()),
            new Option("Close wizard", () => Environment.Exit(0)))
        { }
    }
}
