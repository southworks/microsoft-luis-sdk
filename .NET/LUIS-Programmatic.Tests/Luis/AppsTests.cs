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

        [Fact]
        public void GetApplicationsList()
        {
            UseClientFor(async client =>
            {
                var result = await client.Apps.GetApplicationsListAsync(region);

                Assert.Equal(12, result.Count);
                foreach (var app in result)
                {
                    Assert.True(Guid.TryParse(app.Id, out Guid id));
                }
            });
        }
    }
}
