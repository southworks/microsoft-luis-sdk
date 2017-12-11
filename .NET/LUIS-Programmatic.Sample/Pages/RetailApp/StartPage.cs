namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.RetailApp
{
    using System;
    using System.Threading.Tasks;

    class StartPage : BaseStartPage
    {
        public StartPage(BaseProgram program) : base("Retail App", program)
        { }

        public override void Display()
        {
            base.Display();


            Console.WriteLine("We’ll create a new Retail app to send flower arrangements.");

            AwaitTask(Task.Delay(2000));

            WaitForNavigateTo<TrainAppPage>();
        }
    }
}
