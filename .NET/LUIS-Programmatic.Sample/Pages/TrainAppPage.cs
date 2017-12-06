namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using System;
    using System.Threading.Tasks;

    class TrainAppPage : BasePage
    {
        public TrainAppPage(MainProgram program) : base("Train App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Training App");

            AwaitTask(Task.Delay(500), false);

            WaitForNavigateHome();
        }
    }
}
