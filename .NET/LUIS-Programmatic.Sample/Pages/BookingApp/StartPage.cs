﻿namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.BookingApp
{
    using System;
    using System.Threading.Tasks;

    class StartPage : BasePage, IAppVersionPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public StartPage(BaseProgram program) : base("Booking App", program)
        { }

        public override void Display()
        {
            base.Display();

            Console.WriteLine("Booking app placeholder");

            AwaitTask(Task.Delay(2000));

            WaitForNavigateTo<TrainAppPage>();
        }
    }
}
