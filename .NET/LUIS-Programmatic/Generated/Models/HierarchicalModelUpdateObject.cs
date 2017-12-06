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

    /// <summary>
    /// A model object containing the properties to update.
    /// </summary>
    public partial class HierarchicalModelUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the HierarchicalModelUpdateObject
        /// class.
        /// </summary>
        public HierarchicalModelUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HierarchicalModelUpdateObject
        /// class.
        /// </summary>
        /// <param name="children">Child entities.</param>
        /// <param name="name">The new entity name.</param>
        public HierarchicalModelUpdateObject(IList<string> children = default(IList<string>), string name = default(string))
        {
            Children = children;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets child entities.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<string> Children { get; set; }

        /// <summary>
        /// Gets or sets the new entity name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
