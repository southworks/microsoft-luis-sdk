// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Collection of endpoint URLs the selected application is deployed to.
    /// </summary>
    public partial class AvailableEndpoints
    {
        /// <summary>
        /// Initializes a new instance of the AvailableEndpoints class.
        /// </summary>
        public AvailableEndpoints()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableEndpoints class.
        /// </summary>
        public AvailableEndpoints(string westus = default(string), string eastus2 = default(string), string westcentralus = default(string), string southeastasia = default(string), string westeurope = default(string))
        {
            Westus = westus;
            Eastus2 = eastus2;
            Westcentralus = westcentralus;
            Southeastasia = southeastasia;
            Westeurope = westeurope;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "westus")]
        public string Westus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eastus2")]
        public string Eastus2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "westcentralus")]
        public string Westcentralus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "southeastasia")]
        public string Southeastasia { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "westeurope")]
        public string Westeurope { get; set; }

    }
}