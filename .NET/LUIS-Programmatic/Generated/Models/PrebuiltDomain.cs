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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PrebuiltDomain
    {
        /// <summary>
        /// Initializes a new instance of the PrebuiltDomain class.
        /// </summary>
        public PrebuiltDomain()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrebuiltDomain class.
        /// </summary>
        public PrebuiltDomain(string name = default(string), string culture = default(string), string description = default(string), string examples = default(string), IList<PrebuiltDomainModel> intents = default(IList<PrebuiltDomainModel>), IList<PrebuiltDomainModel> entities = default(IList<PrebuiltDomainModel>))
        {
            Name = name;
            Culture = culture;
            Description = description;
            Examples = examples;
            Intents = intents;
            Entities = entities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "culture")]
        public string Culture { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "examples")]
        public string Examples { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intents")]
        public IList<PrebuiltDomainModel> Intents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<PrebuiltDomainModel> Entities { get; set; }

    }
}
