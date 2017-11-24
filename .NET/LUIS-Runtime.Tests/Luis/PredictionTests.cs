using Microsoft.Azure.CognitiveServices.Language.LUIS;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Models;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;

namespace Microsoft.Azure.CognitiveServices.LUIS.Tests.Luis
{
    public class PredictionTests: BaseTest
    {
        [Fact]
        public void PredictionGet()
        {
            UseClientFor(async client => {
                var utterance = "this is a test";
                var result = await client.Prediction.GetPredictionsFromEndpointViaGetAsync(region, appId, utterance);

                Assert.Equal("None", result.TopScoringIntent.Intent);
                Assert.Equal(utterance, result.Query);
            });
        }

        [Fact]
        public void PredictionPost()
        {
            UseClientFor(async client => {
                var utterance = "this is a test with post";
                var result = await client.Prediction.GetPredictionsFromEndpointViaPostAsync(region, appId, utterance);

                Assert.Equal("None", result.TopScoringIntent.Intent);
                Assert.Equal(utterance, result.Query);
            });
        }
        
        [Fact]
        public async void PredictionInvalidKey()
        {
            using (MockContext context = MockContext.Start(ClassName))
            {
                HttpMockServer.Initialize(ClassName, nameof(PredictionInvalidKey), mode);
                ILuisRuntimeAPI client = GetClient(HttpMockServer.CreateInstance(), "invalid-key");

                var ex = await Assert.ThrowsAsync<APIErrorException>(async () 
                    => await client.Prediction.GetPredictionsFromEndpointViaGetAsync(region, appId, "test"));

                Assert.Equal("401", ex.Body.StatusCode);

                context.Stop();
            }
        }
    }
}
