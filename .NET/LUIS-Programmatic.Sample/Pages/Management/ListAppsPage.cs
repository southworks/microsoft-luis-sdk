namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using Language.LUIS.Programmatic;
    using System;

    class ListAppsPage : BaseMenuPage
    {
        public ListAppsPage(BaseProgram program) : base("Select App", program)
        { }

        public override void Display()
        {
            var apps = AwaitTask(Client.Apps.ListAsync(), false);
            foreach (var app in apps)
            {
                SafeAddToMenu(new Option(app.Name, () => NavigateWithInitializer<AppInfoPage>((page) => page.AppId = app.Id.Value)));
            }
            base.Display();
        }
    }
}
