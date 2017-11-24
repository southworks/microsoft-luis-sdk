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

    public partial class PrebuiltDomainModelCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the PrebuiltDomainModelCreateObject
        /// class.
        /// </summary>
        public PrebuiltDomainModelCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrebuiltDomainModelCreateObject
        /// class.
        /// </summary>
        public PrebuiltDomainModelCreateObject(string domainName = default(string), string modelName = default(string))
        {
            DomainName = domainName;
            ModelName = modelName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DomainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ModelName")]
        public string ModelName { get; set; }

    }
}
