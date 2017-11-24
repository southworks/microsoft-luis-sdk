// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Versions operations.
    /// </summary>
    public partial interface IVersions
    {
        /// <summary>
        /// Creates a new version equivalent to the current snapshot of the
        /// selected application version.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='taskUpdateObject'>
        /// An object containing the new version ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> CloneVersionWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, TaskUpdateObject taskUpdateObject = default(TaskUpdateObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the application versions info.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='skip'>
        /// The number of entries to skip. Default value is 0.
        /// </param>
        /// <param name='take'>
        /// The number of entries to return. Maximum page size is 500. Default
        /// is 100.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> GetApplicationVersionsWithHttpMessagesAsync(AzureRegions azureRegion, string appId, int skip = 0, int take = 100, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the task info.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> GetApplicationVersionWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the name or description of the application version.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='taskUpdateObject'>
        /// A JSON object containing Name and Description of the application.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> RenameApplicationVersionWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, TaskUpdateObject taskUpdateObject = default(TaskUpdateObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an application version.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteApplicationVersionWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Exports a LUIS application to JSON format.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ExportApplicationVersionWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the given application version's subscription key.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> GetApplicationVersionSubscriptionKeyWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Assigns a subscription key to the given application version.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='keyValue'>
        /// The value of the endpoint key to assign to the application.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> AssignSubscriptionKeyToVersionWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, string keyValue = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Assigns an external API key to the given application according to
        /// the specified key type.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='externalKeyUpdateObject'>
        /// The external api key to be assigned.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateApplicationVersionExternalKeyWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, ExternalKeyUpdateObject externalKeyUpdateObject = default(ExternalKeyUpdateObject), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the given application versions's external keys.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> GetApplicationVersionExternalApiKeysWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an external API key currently associated to the given
        /// application according for the specified key type.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='keyType'>
        /// The external key type.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteApplicationVersionExternalKeyWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, string keyType, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Imports a new version into a LUIS application, the version's JSON
        /// should be included in in the request body.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The imported versionId.
        /// </param>
        /// <param name='jSONApp'>
        /// A JSON representing the LUIS application structure.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> ImportVersionToApplicationWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId = default(string), JSONApp jSONApp = default(JSONApp), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deleted an unlabelled utterance.
        /// </summary>
        /// <param name='azureRegion'>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope'
        /// </param>
        /// <param name='appId'>
        /// Format - guid. The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID of the task.
        /// </param>
        /// <param name='body'>
        /// The utterance text to delete
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteUnlabelledUtteranceWithHttpMessagesAsync(AzureRegions azureRegion, string appId, string versionId, object body = default(object), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
