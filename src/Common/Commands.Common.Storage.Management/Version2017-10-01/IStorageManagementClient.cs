// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Version2017_10_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Azure Storage Management API.
    /// </summary>
    public partial interface IStorageManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Gets subscription credentials which uniquely identify the Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the ISkusOperations.
        /// </summary>
        ISkusOperations Skus { get; }

        /// <summary>
        /// Gets the IStorageAccountsOperations.
        /// </summary>
        IStorageAccountsOperations StorageAccounts { get; }

        /// <summary>
        /// Gets the IUsageOperations.
        /// </summary>
        IUsageOperations Usage { get; }

    }
}
