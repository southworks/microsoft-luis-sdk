namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using Language.LUIS.Programmatic;
    using Newtonsoft.Json;
    using System;
    using System.Threading.Tasks;

    class AppTrainPage : BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public AppTrainPage(BaseProgram program) : base("Train", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Training app...");

            AwaitTask(Task.Run(async () => {
                var result = await Client.Train.TrainVersionAsync(AppId, VersionId);
                while (!result.Status.Equals("UpToDate"))
                {
                    await Task.Delay(1000);
                    result = await Client.Train.TrainVersionAsync(AppId, VersionId);
                }
            }));

            Console.WriteLine("Your app is trained.");

            WaitForGoBack();
        }
    }
}
