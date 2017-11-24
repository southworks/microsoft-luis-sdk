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

    public partial class AvailableCulture
    {
        /// <summary>
        /// Initializes a new instance of the AvailableCulture class.
        /// </summary>
        public AvailableCulture()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableCulture class.
        /// </summary>
        public AvailableCulture(string name = default(string), string code = default(string))
        {
            Name = name;
            Code = code;
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
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

    }
}