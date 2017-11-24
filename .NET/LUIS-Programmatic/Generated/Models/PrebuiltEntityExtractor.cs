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

    [Newtonsoft.Json.JsonObject("Prebuilt Entity Extractor")]
    public partial class PrebuiltEntityExtractor : ModelInfo
    {
        /// <summary>
        /// Initializes a new instance of the PrebuiltEntityExtractor class.
        /// </summary>
        public PrebuiltEntityExtractor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrebuiltEntityExtractor class.
        /// </summary>
        /// <param name="id">The GUID of the Entity Model.</param>
        /// <param name="name">Name of the Entity Model.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        public PrebuiltEntityExtractor(string id = default(string), string name = default(string), double? typeId = default(double?))
            : base(id, name, typeId)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
