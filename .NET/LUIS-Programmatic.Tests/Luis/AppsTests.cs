namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Tests.Luis
{
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using System;
    using System.Globalization;
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
        public void GetApplicationDomains()
        {
            UseClientFor(async client =>
            {
                var result = await client.Apps.GetApplicationDomainsAsync(region);
                foreach (var domain in result)
                {
                    Assert.False(string.IsNullOrWhiteSpace(domain));
                }
            });
        }

        [Fact]
        public void GetApplicationCultures()
        {
            UseClientFor(async client =>
            {
                var result = await client.Apps.GetApplicationCulturesAsync(region);
                foreach (var culture in result)
                {
                    var cult = new CultureInfo(culture.Code);
                    Assert.Equal(cult.Name.ToLowerInvariant(), culture.Code);
                }
            });
        }

        [Fact]
        public void GetApplicationUsageScenarios()
        {
            UseClientFor(async client =>
            {
                var result = await client.Apps.GetApplicationUsageScenariosAsync(region);
                foreach (var scenario in result)
                {
                    Assert.False(string.IsNullOrWhiteSpace(scenario));
                }
            });
        }
    }
}
