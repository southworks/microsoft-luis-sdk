namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.RetailApp
{
    using System;
    using System.Threading.Tasks;

    class StartPage : BasePage
    {
        public StartPage(MainProgram program) : base("Retail App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Retail app placeholder");

            AwaitTask(Task.Delay(2000), false);

            WaitForNavigateTo<TrainAppPage>();
        }
    }
}
