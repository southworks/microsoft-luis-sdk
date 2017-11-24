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

    [Newtonsoft.Json.JsonObject("Entity Extractor")]
    public partial class EntityExtractor : ModelInfo
    {
        /// <summary>
        /// Initializes a new instance of the EntityExtractor class.
        /// </summary>
        public EntityExtractor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityExtractor class.
        /// </summary>
        /// <param name="id">The GUID of the Entity Model.</param>
        /// <param name="name">Name of the Entity Model.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        public EntityExtractor(string id = default(string), string name = default(string), double? typeId = default(double?), string customPrebuiltDomainName = default(string), string customPrebuiltModelName = default(string))
            : base(id, name, typeId)
        {
            CustomPrebuiltDomainName = customPrebuiltDomainName;
            CustomPrebuiltModelName = customPrebuiltModelName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customPrebuiltDomainName")]
        public string CustomPrebuiltDomainName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customPrebuiltModelName")]
        public string CustomPrebuiltModelName { get; set; }

    }
}
