using Microsoft.Azure.CognitiveServices.Language.LUIS;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Microsoft.Azure.CognitiveServices.LUIS.Tests.Luis
{
    public class PredictionTests: BaseTest
    {
        [Fact]
        public async void Prediction()
        {
            using (MockContext context = MockContext.Start(ClassName))
            {
                HttpMockServer.Initialize(ClassName, nameof(Prediction), mode);
                ILuisRuntimeAPI client = GetClient(HttpMockServer.CreateInstance());

                var utterance = "hello";
                var result = await client.Prediction.GetPredictionsFromEndpointViaGetAsync(region, subscriptionKey, appId, utterance);

                Assert.Equal("Family Intent", result.TopScoringIntent.Intent);
                context.Stop();
            }
        }
    }
}
