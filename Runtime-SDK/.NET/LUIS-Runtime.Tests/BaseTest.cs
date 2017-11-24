using System.Net.Http;
using Microsoft.Azure.CognitiveServices.Language.LUIS;
using Microsoft.Azure.Test.HttpRecorder;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Models;

namespace Microsoft.Azure.CognitiveServices.LUIS.Tests
{
    public abstract class BaseTest
    {
        protected const HttpRecorderMode mode = HttpRecorderMode.Playback;
        protected const AzureRegions region = AzureRegions.Westus;
        protected const string appId = "f8ef55e6-1543-4a36-95da-497c21feea65";
        protected const string subscriptionKey = "42176485494149818968315538ddf05b";

        protected string ClassName => GetType().FullName;

        protected ILuisRuntimeAPI GetClient(DelegatingHandler handler)
        {
            return new LuisRuntimeAPI(new ApiKeyServiceClientCredentials(subscriptionKey), handlers: handler);
        }
    }
}
