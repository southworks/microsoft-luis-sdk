using System.Net.Http;
using Microsoft.Azure.CognitiveServices.Language.LUIS;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Models;
using System;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Microsoft.Azure.CognitiveServices.LUIS.Tests
{
    public abstract class BaseTest
    {
        protected const HttpRecorderMode mode = HttpRecorderMode.Playback;

        protected const AzureRegions region = AzureRegions.Westus;
        protected const string appId = "7ce0ddf9-b4c4-4784-929e-a05d2bef6560";
        protected const string subscriptionKey = "3eff76bb229942899255402725b72941";

        protected string ClassName => GetType().FullName;

        protected ILuisRuntimeAPI GetClient(DelegatingHandler handler, string subscriptionKey = subscriptionKey)
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
