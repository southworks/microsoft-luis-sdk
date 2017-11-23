namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Sample
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Models;
    using Newtonsoft.Json;

    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        private static AzureRegions AzureRegion;
        private static string SubscriptionKey;
        private static string ApplicationId;

        static void Main(string[] args)
        {
            ReadConfiguration();

            // ShowIntro();

            RecognizeUserInput().Wait();
        }

        static async Task RecognizeUserInput()
        {
            while (true)
            {
                // Read the text to recognize
                Console.WriteLine("Enter the text to recognize:");
                string input = Console.ReadLine().Trim();

                if (input.ToLower() == "exit")
                {
                    // Close application if user types "exit"
                    break;
                }
                else
                {
                    if (input.Length > 0)
                    {
                        // Analize
                        var result = await Recognize(input);

                        // Print result
                        var json = JsonConvert.SerializeObject(result, Formatting.Indented);
                        Console.WriteLine(json);
                        Console.WriteLine();
                    }
                }
            }
        }

        static async Task<LuisResult> Recognize(string input)
        {
            var client = new LuisRuntimeAPI();
            return await client.Prediction.GetPredictionsFromEndpointViaGetAsync(AzureRegion, SubscriptionKey, input, ApplicationId);
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

            AzureRegion = (AzureRegions)Enum.Parse(typeof(AzureRegions), region);
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
