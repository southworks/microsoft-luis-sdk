namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using System;

    class AppDeletePage : BaseMenuPage
    {
        public AppDeletePage(BaseProgram program) : base("Delete", program)
        { }

        public override void Display()
        {
            Menu = new Menu();
            var apps = AwaitTask(Client.Apps.ListAsync());
            foreach (var app in apps)
            {
                SafeAddToMenu(new Option(app.Name, () => DeleteApp(app.Id.Value)));
            }

            base.Display();
        }

        private void DeleteApp(Guid appId)
        {
            AwaitTask(Client.Apps.DeleteAsync(appId));
            Console.WriteLine("App deleted!\n");
            WaitForGoBack();
        }
    }
}
