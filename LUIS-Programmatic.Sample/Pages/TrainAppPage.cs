namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    class TrainAppPage : BasePage, IAppVersionPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public TrainAppPage(BaseProgram program) : base("Train", program)
        { }

        private string[] trainedStatus = new string[] { "UpToDate", "Success" };

        public override void Display()
        {
            base.Display();

            Console.WriteLine("We'll start training your app...");

            AwaitTask(Task.Run(async() => {
                var isTrained = false;
                var result = await Client.Train.TrainVersionAsync(AppId, VersionId);
                isTrained = result.Status.Equals("UpToDate");
                while (!isTrained)
                {
                    await Task.Delay(1000);
                    var status = await Client.Train.GetStatusAsync(AppId, VersionId);
                    isTrained = status.All(m => trainedStatus.Contains(m.Details.Status));
                }
            }));

            Console.WriteLine("Your app is trained. You can now go to the LUIS portal and test it!");

            NavigateWithInitializer<PublishAppPage>(page => {
                page.AppId = AppId;
                page.VersionId = VersionId;
            });
        }
    }
}
