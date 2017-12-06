namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Sample
{
    using System;
    using System.IO;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using Microsoft.Extensions.Configuration;
    using DotSpinners;
    using System.Threading.Tasks;
    using Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample;

    class Application
    {
        public static IConfigurationRoot Configuration { get; set; }

        private static AzureRegions AzureRegion;
        private static string SubscriptionKey;
        private static string ApplicationId;

        static void Main(string[] args)
        {
            ReadConfiguration();

            var client = new LuisProgrammaticAPI(new ApiKeyServiceClientCredentials(SubscriptionKey))
            {
                AzureRegion = AzureRegions.Westus
            };

            var program = new Program(client);

            program.Run();
        }

        private static T WaitFor<T>(Task<T> task)
        {
            new DotSpinner(SpinnerTypes.Ping, task).Center().Start();
            Console.Clear();
            return task.Result;
        }

        static void ReadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            var region = Configuration["LUIS.Region"];
            if (string.IsNullOrWhiteSpace(region))
            {
                throw new ArgumentException("Missing \"LUIS.Region\" in appsettings.json");
            }

            AzureRegion = (AzureRegions)Enum.Parse(typeof(AzureRegions), region, true);
            SubscriptionKey = Configuration["LUIS.SubscriptionKey"];
            ApplicationId = Configuration["LUIS.ApplicationId"];

            if (string.IsNullOrWhiteSpace(SubscriptionKey))
            {
                throw new ArgumentException("Missing \"LUIS.SubscriptionKey\" in appsettings.json");
            }

            if (string.IsNullOrWhiteSpace(ApplicationId))
            {
                throw new ArgumentException("Missing \"LUIS.ApplicationId\" in appsettings.json");
            }
        }
    }
}
