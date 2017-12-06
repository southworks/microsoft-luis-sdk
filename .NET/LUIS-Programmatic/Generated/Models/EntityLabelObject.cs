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

    /// <summary>
    /// Defines the entity type and position of the extracted entity within the
    /// example.
    /// </summary>
    public partial class EntityLabelObject
    {
        /// <summary>
        /// Initializes a new instance of the EntityLabelObject class.
        /// </summary>
        public EntityLabelObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityLabelObject class.
        /// </summary>
        /// <param name="entityName">The entity type.</param>
        /// <param name="startCharIndex">The index within the utterance where
        /// the extracted entity starts.</param>
        /// <param name="endCharIndex">The index within the utterance where the
        /// extracted entity ends.</param>
        public EntityLabelObject(string entityName = default(string), int? startCharIndex = default(int?), int? endCharIndex = default(int?))
        {
            EntityName = entityName;
            StartCharIndex = startCharIndex;
            EndCharIndex = endCharIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the entity type.
        /// </summary>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or sets the index within the utterance where the extracted
        /// entity starts.
        /// </summary>
        [JsonProperty(PropertyName = "startCharIndex")]
        public int? StartCharIndex { get; set; }

        /// <summary>
        /// Gets or sets the index within the utterance where the extracted
        /// entity ends.
        /// </summary>
        [JsonProperty(PropertyName = "endCharIndex")]
        public int? EndCharIndex { get; set; }

    }
}
