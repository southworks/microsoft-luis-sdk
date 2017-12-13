namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Sample
{
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.IO;

    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        private static AzureRegions AzureRegion;
        private static string ProgrammaticKey;

        static void Main(string[] args)
        {
            ReadConfiguration();

            var client = new LuisProgrammaticAPI(new ApiKeyServiceClientCredentials(ProgrammaticKey))
            {
                AzureRegion = AzureRegions.Westus
            };

            var program = new BaseProgram(client);

            program.Run();
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
            ProgrammaticKey = Configuration["LUIS.ProgrammaticKey"];

            if (string.IsNullOrWhiteSpace(ProgrammaticKey))
            {
                throw new ArgumentException("Missing \"LUIS.ProgrammaticKey\" in appsettings.json");
            }
        }
    }
}
