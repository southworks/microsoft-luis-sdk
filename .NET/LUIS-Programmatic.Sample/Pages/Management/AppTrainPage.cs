namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using Language.LUIS.Programmatic;
    using System;
    using System.Threading.Tasks;

    class AppTrainPage : BasePage, IAppPage
    {
        public Guid AppId { get; set; }

        public AppTrainPage(BaseProgram program) : base("Train", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Preparing app to train...");

            var versions = AwaitTask(Client.Versions.ListAsync(AppId));

            Console.WriteLine("Select version to train");
            var versionId = "";
            var menuVersion = new Menu();
            foreach (var version in versions)
            {
                menuVersion.Add($"v{version.Version} [{version.TrainingStatus}]", () => versionId = version.Version);
            }
            menuVersion.Display();

            AwaitTask(Task.Run(async () => {
                var result = await Client.Train.TrainVersionAsync(AppId, versionId);
                while (!result.Status.Equals("UpToDate"))
                {
                    await Task.Delay(1000);
                    result = await Client.Train.TrainVersionAsync(AppId, versionId);
                }
            }));

            Console.WriteLine("Your app is trained.");

            WaitForGoBack();
        }
    }
}
