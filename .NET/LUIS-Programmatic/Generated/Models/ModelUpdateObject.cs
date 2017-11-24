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

    public partial class ModelUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the ModelUpdateObject class.
        /// </summary>
        public ModelUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelUpdateObject class.
        /// </summary>
        public ModelUpdateObject(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}
