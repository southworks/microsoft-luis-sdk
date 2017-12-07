namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using System;
    using System.Threading.Tasks;

    class TrainAppPage : BasePage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public TrainAppPage(BaseProgram program) : base("Train App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("We'll start training your app...");

            AwaitTask(Task.Run(async() => {
                var result = await Client.Train.TrainVersionAsync(AppId, VersionId);
                while (!result.Status.Equals("UpToDate"))
                {
                    await Task.Delay(1500);
                    result = await Client.Train.TrainVersionAsync(AppId, VersionId);
                }
            }), false);

            Console.WriteLine("Your app is trained. You can now go to the LUIS portal and test it!");
            
            WaitForNavigateHome();
        }
    }
}
