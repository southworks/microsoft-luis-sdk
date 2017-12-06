namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.GreetingApp
{
    using System;
    using System.Threading.Tasks;

    class StartPage : BasePage
    {
        public StartPage(MainProgram program) : base("Greeting App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Greeting app placeholder");

            AwaitTask(Task.Delay(2000), false);

            WaitForNavigateTo<TrainAppPage>();
        }
    }
}
