using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
using Xunit;

namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Tests.Luis
{
    public class AppsTests: BaseTest
    {
        [Fact]
        public void GetApplicationInfo()
        {
            UseClientFor(async client => {
                var result = await client.Apps.GetApplicationInfoAsync(region, appId);

                Assert.Equal(appId, result.Id);
            });
        }
    }
}
