namespace Microsoft.Azure.CognitiveServices.LUIS.Tests
{
    using System;
    using System.Net.Http;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using Microsoft.Azure.CognitiveServices.Language.LUIS;
    using Microsoft.Azure.CognitiveServices.Language.LUIS.Models;
    using Microsoft.Azure.Test.HttpRecorder;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;

    public abstract class BaseTest
    {
        private const HttpRecorderMode mode = HttpRecorderMode.Playback;

        protected const AzureRegions region = AzureRegions.Westus;
        protected const string appId = "7ce0ddf9-b4c4-4784-929e-a05d2bef6560";
        protected const string subscriptionKey = "3eff76bb229942899255402725b72941";

        private string ClassName => GetType().FullName;

        private ILuisRuntimeAPI GetClient(DelegatingHandler handler, string subscriptionKey = subscriptionKey)
        {
            return new LuisRuntimeAPI(new ApiKeyServiceClientCredentials(subscriptionKey), handlers: handler);
        }

        protected async void UseClientFor(Func<ILuisRuntimeAPI, Task> doTest, string className = null, [CallerMemberName] string methodName = "")
        {
            using (MockContext context = MockContext.Start(className ?? ClassName, methodName))
            {
                HttpMockServer.Initialize(className ?? ClassName, methodName, mode);
                ILuisRuntimeAPI client = GetClient(HttpMockServer.CreateInstance());
                await doTest(client);
                context.Stop();
            }
        }
    }
}
