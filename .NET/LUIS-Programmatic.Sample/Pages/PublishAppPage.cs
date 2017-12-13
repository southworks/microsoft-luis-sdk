namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using EasyConsole;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using System;

    class PublishAppPage : BasePage, IAppVersionPage
    {
        public Guid AppId { get; set; }
        public string VersionId { get; set; }

        public PublishAppPage(BaseProgram program) : base("Publish", program)
        { }

        public override void Display()
        {
            base.Display();

            var response = Input.ReadString("Do you want to publish your App? (y/n) ");

            if (response.Trim().ToLowerInvariant().StartsWith("y"))
            {
                Console.WriteLine("We'll start publishing your app...");

                var publishOptions = new ApplicationPublishObject
                {
                    VersionId = VersionId,
                    IsStaging = false,
                    Region = "westus"
                };

                try
                {
                    var result = AwaitTask(Client.Apps.PublishAsync(AppId, publishOptions));

                    Console.WriteLine($"Your app is published. You can now go to test it on {result.EndpointUrl}");
                }
                catch (Exception ex)
                {
                    var message = (ex as ErrorResponseException)?.Body.Message ?? ex.Message;
                    Console.WriteLine($"Your app is not ready to be published. Err: {message}");
                }
            }

            NavigateWithInitializer<ShareAppPage>(page => {
                page.AppId = AppId;
                page.VersionId = VersionId;
            });
        }
    }
}
