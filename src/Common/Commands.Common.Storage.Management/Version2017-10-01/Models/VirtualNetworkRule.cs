// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Version2017_10_01.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Virtual Network rule.
    /// </summary>
    public partial class VirtualNetworkRule
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        public VirtualNetworkRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkRule class.
        /// </summary>
        /// <param name="virtualNetworkResourceId">Resource ID of a subnet, for
        /// example:
        /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.</param>
        /// <param name="action">The action of virtual network rule. Possible
        /// values include: 'Allow'</param>
        /// <param name="state">Gets the state of virtual network rule.
        /// Possible values include: 'provisioning', 'deprovisioning',
        /// 'succeeded', 'failed', 'networkSourceDeleted'</param>
        public VirtualNetworkRule(string virtualNetworkResourceId, Action? action = default(Action?), State? state = default(State?))
        {
            VirtualNetworkResourceId = virtualNetworkResourceId;
            Action = action;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource ID of a subnet, for example:
        /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string VirtualNetworkResourceId { get; set; }

        /// <summary>
        /// Gets or sets the action of virtual network rule. Possible values
        /// include: 'Allow'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public Action? Action { get; set; }

        /// <summary>
        /// Gets the state of virtual network rule. Possible values include:
        /// 'provisioning', 'deprovisioning', 'succeeded', 'failed',
        /// 'networkSourceDeleted'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public State? State { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VirtualNetworkResourceId");
            }
        }
    }
}
