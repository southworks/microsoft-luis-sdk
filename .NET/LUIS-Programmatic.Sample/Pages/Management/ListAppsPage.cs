﻿namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
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
            Menu = new Menu();
            var apps = AwaitTask(Client.Apps.ListAsync());
            foreach (var app in apps)
            {
                SafeAddToMenu(new Option($"App: {app.Name}", () => NavigateWithInitializer<AppInfoPage>((page) => page.AppId = app.Id.Value)));
            }
            SafeAddToMenu(new Option("Delete app", () => Program.NavigateTo<AppDeletePage>() ));
            base.Display();
        }
    }
}
