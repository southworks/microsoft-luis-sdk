// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Channel
    {
        /// <summary>
        /// Initializes a new instance of the Channel class.
        /// </summary>
        public Channel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Channel class.
        /// </summary>
        public Channel(IList<Setting> settings = default(IList<Setting>), string name = default(string), string method = default(string))
        {
            Settings = settings;
            Name = name;
            Method = method;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Settings")]
        public IList<Setting> Settings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Method")]
        public string Method { get; set; }

    }
}
