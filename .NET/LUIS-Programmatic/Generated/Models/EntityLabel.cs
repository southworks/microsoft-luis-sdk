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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EntityLabel
    {
        /// <summary>
        /// Initializes a new instance of the EntityLabel class.
        /// </summary>
        public EntityLabel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityLabel class.
        /// </summary>
        public EntityLabel(string entityName, double startTokenIndex, double endTokenIndex)
        {
            EntityName = entityName;
            StartTokenIndex = startTokenIndex;
            EndTokenIndex = endTokenIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startTokenIndex")]
        public double StartTokenIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endTokenIndex")]
        public double EndTokenIndex { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EntityName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EntityName");
            }
        }
    }
}
