using Microsoft.Azure.CognitiveServices.Language.LUIS;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Microsoft.Azure.CognitiveServices.LUIS.Tests.Luis
{
    public class PredictionTests: BaseTest
    {
        private readonly string className;

        public PredictionTests()
        {
            className = this.GetType().FullName;
        }

        [Fact]
        public async void Prediction()
        {
            using (MockContext context = MockContext.Start(className))
            {
                HttpMockServer.Initialize(className, nameof(Prediction), mode);
                ILuisRuntimeAPI client = GetClient(HttpMockServer.CreateInstance());
                var utterance = "hello";
                var result = await client.Prediction.GetPredictionsFromEndpointViaGetAsync(region, subscriptionKey, utterance, appId);

                Assert.Equal("Family Intent", result.TopScoringIntent.Intent);
                context.Stop();
            }
        }
    }
}
