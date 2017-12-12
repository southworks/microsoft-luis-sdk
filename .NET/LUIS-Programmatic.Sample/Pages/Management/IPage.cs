using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.CognitiveServices.LUIS.Programmatic.Sample.Pages.Management
{
    interface IAppPage
    {
        Guid AppId { get; set; }
    }

    interface IAppVersionPage : IAppPage
    {
        string VersionId { get; set; }
    }
}
