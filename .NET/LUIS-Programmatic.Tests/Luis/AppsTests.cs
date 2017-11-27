namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Tests.Luis
{
    using System;
    using System.Linq;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using Xunit;

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

        [Fact]
        public void AddApplication()
        {
            UseClientFor(async client =>
            {
                var appId = await client.Apps.AddApplicationAsync(region, new ApplicationCreateObject
                {
                    Name = "New LUIS App",
                    Description = "New LUIS App",
                    Culture = "en-us",
                    Domain = "Comics",
                    UsageScenario = "IoT"
                });

                Guid appGuid;
                Assert.True(Guid.TryParse(appId, out appGuid));
                Assert.Equal(new Guid("9e6703ec-56fe-48ce-8a72-10d592f6056d"), appGuid);
            });
        }
    }
}
