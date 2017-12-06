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
    /// Object model for updating a closed list.
    /// </summary>
    public partial class ClosedListModelUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the ClosedListModelUpdateObject
        /// class.
        /// </summary>
        public ClosedListModelUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClosedListModelUpdateObject
        /// class.
        /// </summary>
        /// <param name="subLists">The new sublists for the feature.</param>
        /// <param name="name">The new name of the closed list feature.</param>
        public ClosedListModelUpdateObject(IList<WordListObject> subLists = default(IList<WordListObject>), string name = default(string))
        {
            SubLists = subLists;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new sublists for the feature.
        /// </summary>
        [JsonProperty(PropertyName = "subLists")]
        public IList<WordListObject> SubLists { get; set; }

        /// <summary>
        /// Gets or sets the new name of the closed list feature.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
