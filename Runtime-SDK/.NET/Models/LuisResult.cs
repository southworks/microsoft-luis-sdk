// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.LUIS.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LuisResult
    {
        /// <summary>
        /// Initializes a new instance of the LuisResult class.
        /// </summary>
        public LuisResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LuisResult class.
        /// </summary>
        /// <param name="compositeEntities">The composite entities extracted
        /// from the utterance.</param>
        public LuisResult(string query = default(string), IntentModel topScoringIntent = default(IntentModel), IList<IntentModel> intents = default(IList<IntentModel>), IList<EntityModel> entities = default(IList<EntityModel>), IList<CompositeEntityModel> compositeEntities = default(IList<CompositeEntityModel>))
        {
            Query = query;
            TopScoringIntent = topScoringIntent;
            Intents = intents;
            Entities = entities;
            CompositeEntities = compositeEntities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "topScoringIntent")]
        public IntentModel TopScoringIntent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "intents")]
        public IList<IntentModel> Intents { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entities")]
        public IList<EntityModel> Entities { get; set; }

        /// <summary>
        /// Gets or sets the composite entities extracted from the utterance.
        /// </summary>
        [JsonProperty(PropertyName = "compositeEntities")]
        public IList<CompositeEntityModel> CompositeEntities { get; set; }

    }
}
