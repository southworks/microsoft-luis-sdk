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

    public partial class JSONModelFeature
    {
        /// <summary>
        /// Initializes a new instance of the JSONModelFeature class.
        /// </summary>
        public JSONModelFeature()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONModelFeature class.
        /// </summary>
        public JSONModelFeature(bool? activated = default(bool?), string name = default(string), string words = default(string), bool? mode = default(bool?))
        {
            Activated = activated;
            Name = name;
            Words = words;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activated")]
        public bool? Activated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "words")]
        public string Words { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public bool? Mode { get; set; }

    }
}
