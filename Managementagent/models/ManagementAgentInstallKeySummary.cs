/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// The summary of the Agent Install Key details.
    /// </summary>
    public class ManagementAgentInstallKeySummary 
    {
        
        /// <value>
        /// Agent Install Key identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Management Agent Install Key Name
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Principal id of user who created the Agent Install key
        /// </value>
        [JsonProperty(PropertyName = "createdByPrincipalId")]
        public string CreatedByPrincipalId { get; set; }
        
        /// <value>
        /// Total number of install for this keys
        /// </value>
        [JsonProperty(PropertyName = "allowedKeyInstallCount")]
        public System.Nullable<int> AllowedKeyInstallCount { get; set; }
        
        /// <value>
        /// Total number of install for this keys
        /// </value>
        [JsonProperty(PropertyName = "currentKeyInstallCount")]
        public System.Nullable<int> CurrentKeyInstallCount { get; set; }
        
        /// <value>
        /// Status of Key
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStates> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The time when Management Agent install Key was created. An RFC3339 formatted date time string
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// date after which key would expire after creation
        /// </value>
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
        
        /// <value>
        /// Compartment Identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// If set to true, the install key has no expiration date or usage limit. Properties allowedKeyInstallCount and timeExpires are ignored if set to true. Defaults to false.
        /// </value>
        [JsonProperty(PropertyName = "isUnlimited")]
        public System.Nullable<bool> IsUnlimited { get; set; }
        
    }
}
