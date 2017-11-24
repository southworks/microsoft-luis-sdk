using System.Net.Http;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models;
using System;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Tests
{
    public abstract class BaseTest
    {
        private const HttpRecorderMode mode = HttpRecorderMode.Playback;

        protected const AzureRegions region = AzureRegions.Westus;
        protected const string appId = "f8ef55e6-1543-4a36-95da-497c21feea65";
        protected const string subscriptionKey = "3eff76bb229942899255402725b72941";

        private string ClassName => GetType().FullName;

        private ILuisProgrammaticAPI GetClient(DelegatingHandler handler)
        {
            return new LuisProgrammaticAPI(new ApiKeyServiceClientCredentials(subscriptionKey), handlers: handler);
        }

        protected async void UseClientFor(Func<ILuisProgrammaticAPI, Task> doTest, string className = null, [CallerMemberName] string methodName = "")
        {
            using (MockContext context = MockContext.Start(className ?? ClassName, methodName))
            {
                HttpMockServer.Initialize(className ?? ClassName, methodName, mode);
                ILuisProgrammaticAPI client = GetClient(HttpMockServer.CreateInstance());
                
                await doTest(client);
                context.Stop();
            }
        }
    }
}
