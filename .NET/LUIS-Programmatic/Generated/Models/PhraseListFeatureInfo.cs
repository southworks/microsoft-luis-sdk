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
    using System.Linq;

    public partial class PhraseListFeatureInfo : FeatureInfoObject
    {
        /// <summary>
        /// Initializes a new instance of the PhraseListFeatureInfo class.
        /// </summary>
        public PhraseListFeatureInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhraseListFeatureInfo class.
        /// </summary>
        /// <param name="id">A six-digit ID used for Features.</param>
        /// <param name="name">The name of the Feature.</param>
        /// <param name="phrases">A list of comma-separated values.</param>
        public PhraseListFeatureInfo(double? id = default(double?), string name = default(string), bool? isActive = default(bool?), string phrases = default(string), bool? isExchangeable = default(bool?))
            : base(id, name, isActive)
        {
            Phrases = phrases;
            IsExchangeable = isExchangeable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of comma-separated values.
        /// </summary>
        [JsonProperty(PropertyName = "phrases")]
        public string Phrases { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isExchangeable")]
        public bool? IsExchangeable { get; set; }

    }
}
