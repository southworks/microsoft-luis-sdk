namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages
{
    using System;

    class BaseStartPage : BasePage
    {
        public BaseStartPage(string title, BaseProgram program) : base(title, program)
        { }

        public Guid AppId { get; set; }
        public string VersionId { get; set; }
    }
}