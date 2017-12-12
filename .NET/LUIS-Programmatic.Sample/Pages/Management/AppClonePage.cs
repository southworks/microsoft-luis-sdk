namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using System;

    class AppClonePage : BasePage, IAppPage
    {
        public Guid AppId { get; set; }

        public AppClonePage(BaseProgram program) : base("Clone", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Preparing app to clone...");

            var versions = AwaitTask(Client.Versions.ListAsync(AppId));

            Console.WriteLine("Select version to clone");
            var versionId = "";
            var menuVersion = new Menu();
            foreach (var version in versions)
            {
                menuVersion.Add($"v{version.Version} [{version.TrainingStatus}]", () => versionId = version.Version);
            }
            menuVersion.Display();

            var verName = Input.ReadString("Enter the new version tag: ").Trim();

            var versionToClone = new TaskUpdateObject
            {
                Version = verName
            };

            Console.WriteLine("Cloning app...");

            try
            {
                var result = AwaitTask(Client.Versions.CloneAsync(AppId, versionId, versionToClone));
                Console.WriteLine("Your app has been cloned.");
                Print(result);
            }
            catch (Exception ex)
            {
                var message = (ex as ErrorResponseException)?.Body.Message ?? ex.Message;
                Console.WriteLine($"Your app is not ready to be cloned. Err: {message}");
            }

            WaitForGoBack();
        }
    }
}
