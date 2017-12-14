namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using System;
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;

    class AppVersionSelector : BaseMenuPage, IAppPage
    {
        public Guid AppId { get; set; }

        public AppVersionSelector(BaseProgram program) : base("Version", program)
        { }

        public override void Display()
        {
            Menu = new Menu();
            var versions = AwaitTask(Client.Versions.ListAsync(AppId));
            foreach (var version in versions)
            {
                SafeAddToMenu($"v{version.Version} [{version.TrainingStatus}]", () => NavigateToVersion(version.Version));
            }

            base.Display();
        }

        private void NavigateToVersion(string versionId)
        {
            NavigateWithInitializer<AppVersionInfoPage>(page => {
                page.AppId = AppId;
                page.VersionId = versionId;
            });
        }
    }
}
