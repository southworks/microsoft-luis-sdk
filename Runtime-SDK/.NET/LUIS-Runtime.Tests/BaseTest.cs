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
        private const HttpRecorderMode mode = HttpRecorderMode.Playback;
        protected const AzureRegions region = AzureRegions.Westus;
        protected const string appId = "f8ef55e6-1543-4a36-95da-497c21feea65";
        protected const string subscriptionKey = "42176485494149818968315538ddf05b";

        private string ClassName => GetType().FullName;
        
        private ILuisRuntimeAPI GetClient(DelegatingHandler handler)
        {
            return new LuisRuntimeAPI(handlers: handler);
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
