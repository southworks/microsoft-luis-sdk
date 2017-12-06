using Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic;
using Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages;

namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample
{
    public class Program : EasyConsole.Program
    {
        public ILuisProgrammaticAPI Client { get; private set; }

        public Program(ILuisProgrammaticAPI client) : base("LUIS Programmatic API Demo", true)
        {
            Client = client;
            AddPage(new MainPage(this));
            AddPage(new ListAppsPage(this));
            SetPage<MainPage>();
        }
    }
}
