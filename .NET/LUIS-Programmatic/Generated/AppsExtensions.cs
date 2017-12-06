// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Apps.
    /// </summary>
    public static partial class AppsExtensions
    {
            /// <summary>
            /// Creates a new LUIS app.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='applicationCreateObject'>
            /// A model containing Name, Description (optional), Culture, Usage Scenario
            /// (optional), Domain (optional) and initial version ID (optional) of the
            /// application. Default value for the version ID is 0.1. Note: the culture
            /// cannot be changed after the app is created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Guid> AddAsync(this IApps operations, ApplicationCreateObject applicationCreateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(applicationCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the user applications.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='skip'>
            /// The number of entries to skip. Default value is 0.
            /// </param>
            /// <param name='take'>
            /// The number of entries to return. Maximum page size is 500. Default is 100.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ApplicationInfoResponse>> ListAsync(this IApps operations, int? skip = 0, int? take = 100, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(skip, take, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports an application to LUIS, the application's structure should be
            /// included in in the request body.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='luisApp'>
            /// A LUIS application structure.
            /// </param>
            /// <param name='appName'>
            /// The application name to create. If not specified, the application name will
            /// be read from the imported object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Guid> ImportAsync(this IApps operations, LuisApp luisApp, string appName = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ImportWithHttpMessagesAsync(luisApp, appName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the endpoint URLs for the prebuilt Cortana applications.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersonalAssistantsResponse> ListCortanaEndpointsAsync(this IApps operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListCortanaEndpointsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the available application domains.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ListDomainsAsync(this IApps operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDomainsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the application available usage scenarios.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ListUsageScenariosAsync(this IApps operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListUsageScenariosWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the supported application cultures.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<AvailableCulture>> ListSupportedCulturesAsync(this IApps operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSupportedCulturesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the query logs of the past month for the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> DownloadQueryLogsAsync(this IApps operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.DownloadQueryLogsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Gets the application info.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInfoResponse> GetAsync(this IApps operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the name or description of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='applicationUpdateObject'>
            /// A model containing Name and Description of the application.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IApps operations, System.Guid appId, ApplicationUpdateObject applicationUpdateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(appId, applicationUpdateObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Deletes an application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IApps operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Publishes a specific version of the application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='applicationPublishObject'>
            /// The application publish object. The region is the target region that the
            /// application is published to.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ProductionOrStagingEndpointInfo> PublishAsync(this IApps operations, System.Guid appId, ApplicationPublishObject applicationPublishObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PublishWithHttpMessagesAsync(appId, applicationPublishObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the application settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationSettings> GetSettingsAsync(this IApps operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSettingsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the application settings.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='applicationSettingUpdateObject'>
            /// An object containing the new application settings.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateSettingsAsync(this IApps operations, System.Guid appId, ApplicationSettingUpdateObject applicationSettingUpdateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateSettingsWithHttpMessagesAsync(appId, applicationSettingUpdateObject, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns the available endpoint deployment regions and URLs.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The application ID.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableEndpoints> ListEndpointsAsync(this IApps operations, System.Guid appId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEndpointsWithHttpMessagesAsync(appId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the available custom prebuilt domains for all cultures.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PrebuiltDomain>> ListAvailableCustomPrebuiltDomainsAsync(this IApps operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableCustomPrebuiltDomainsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a prebuilt domain along with its models as a new application.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='prebuiltDomainCreateObject'>
            /// A prebuilt domain create object containing the name and culture of the
            /// domain.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<System.Guid> AddCustomPrebuiltDomainAsync(this IApps operations, PrebuiltDomainCreateObject prebuiltDomainCreateObject, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddCustomPrebuiltDomainWithHttpMessagesAsync(prebuiltDomainCreateObject, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all the available custom prebuilt domains for a specific culture.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='culture'>
            /// Culture.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PrebuiltDomain>> ListAvailableCustomPrebuiltDomainsForCultureAsync(this IApps operations, string culture, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAvailableCustomPrebuiltDomainsForCultureWithHttpMessagesAsync(culture, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
