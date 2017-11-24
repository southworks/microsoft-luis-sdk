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

    public partial class HierarchicalModel
    {
        /// <summary>
        /// Initializes a new instance of the HierarchicalModel class.
        /// </summary>
        public HierarchicalModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HierarchicalModel class.
        /// </summary>
        public HierarchicalModel(string name = default(string), IList<string> children = default(IList<string>))
        {
            Name = name;
            Children = children;
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

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Children")]
        public IList<string> Children { get; set; }

    }
}
