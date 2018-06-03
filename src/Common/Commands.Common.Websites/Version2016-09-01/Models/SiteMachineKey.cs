// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// MachineKey of an app.
    /// </summary>
    public partial class SiteMachineKey
    {
        /// <summary>
        /// Initializes a new instance of the SiteMachineKey class.
        /// </summary>
        public SiteMachineKey()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteMachineKey class.
        /// </summary>
        /// <param name="validation">MachineKey validation.</param>
        /// <param name="validationKey">Validation key.</param>
        /// <param name="decryption">Algorithm used for decryption.</param>
        /// <param name="decryptionKey">Decryption key.</param>
        public SiteMachineKey(string validation = default(string), string validationKey = default(string), string decryption = default(string), string decryptionKey = default(string))
        {
            Validation = validation;
            ValidationKey = validationKey;
            Decryption = decryption;
            DecryptionKey = decryptionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets machineKey validation.
        /// </summary>
        [JsonProperty(PropertyName = "validation")]
        public string Validation { get; set; }

        /// <summary>
        /// Gets or sets validation key.
        /// </summary>
        [JsonProperty(PropertyName = "validationKey")]
        public string ValidationKey { get; set; }

        /// <summary>
        /// Gets or sets algorithm used for decryption.
        /// </summary>
        [JsonProperty(PropertyName = "decryption")]
        public string Decryption { get; set; }

        /// <summary>
        /// Gets or sets decryption key.
        /// </summary>
        [JsonProperty(PropertyName = "decryptionKey")]
        public string DecryptionKey { get; set; }

    }
}
