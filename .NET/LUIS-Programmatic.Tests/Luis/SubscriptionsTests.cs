namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Tests.Luis
{
    using System;
    using System.Linq;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
    using Xunit;

    public class SubscriptionsTests : BaseTest
    {
        [Fact]
        public void GetSubscriptionsList()
        {
            UseClientFor(async client =>
            {
                var result = await client.User.GetUserSubscriptionKeysAsync(BaseTest.region);

                Assert.Equal(2, result.Count);
                foreach (var subscriptionKeyInfo in result)
                {
                    Assert.True(Guid.TryParse(subscriptionKeyInfo.SubscriptionKey, out Guid id));
                }
            });
        }

        [Fact]
        public void RenameSubscription()
        {
            var subscriptionName = $"LUIS Subscription name updated ({Guid.NewGuid().ToString()})";
            UseClientFor(async client =>
            {
                await client.User.RenameSubscriptionKeyAsync(region, new UserSubscriptionCreateObject
                {
                    SubscriptionKey = BaseTest.subscriptionKey,
                    SubscriptionName = subscriptionName,
                });

                var subscriptionList = await client.User.GetUserSubscriptionKeysAsync(BaseTest.region);

                Assert.Contains(subscriptionList, s => s.SubscriptionKey == BaseTest.subscriptionKey);
                var subscription = subscriptionList.Single(s => s.SubscriptionKey == BaseTest.subscriptionKey);
                Assert.Equal(subscriptionName, subscription.SubscriptionName);
            });
        }

        [Fact]
        public void AddSubscription()
        {
            var subscriptionName = $"LUIS Subscription name ({Guid.NewGuid().ToString()})";
            UseClientFor(async client =>
            {
                await client.User.AddSubscriptionKeyAsync(region, new UserSubscriptionCreateObject
                {
                    SubscriptionName = subscriptionName
                });

                var subscriptionList = await client.User.GetUserSubscriptionKeysAsync(BaseTest.region);

                Assert.Contains(subscriptionList, s => s.SubscriptionName == subscriptionName);
            });
        }
    }
}