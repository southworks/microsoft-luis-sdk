namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Tests.Luis
{
    using System;
    using System.Globalization;
    using System.Linq;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using Xunit;

    public class AppsTests: BaseTest
    {
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

                Assert.True(Guid.TryParse(appId, out Guid appGuid));
                Assert.Equal(new Guid("9e6703ec-56fe-48ce-8a72-10d592f6056d"), appGuid);
            });
        }

        [Fact]
        public void GetApplicationInfo()
        {
            UseClientFor(async client =>
            {
                var result = await client.Apps.GetApplicationInfoAsync(region, appId);
                Assert.Equal(appId, result.Id);
            });
        }

        [Fact]
        public void RenameApplication()
        {
            UseClientFor(async client =>
            {
                await client.Apps.RenameApplicationAsync(region, appId, new ApplicationUpdateObject
                {
                    Name = "LUIS App name updated",
                    Description = "LUIS App description updated"
                });

                var app = await client.Apps.GetApplicationInfoAsync(region, appId);

                Assert.Equal("LUIS App name updated", app.Name);
                Assert.Equal("LUIS App description updated", app.Description);
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
    }
}
