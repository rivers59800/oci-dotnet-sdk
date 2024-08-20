/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Summary of the FleetResource.
    /// </summary>
    public class FleetResourceSummary 
    {
        
        /// <value>
        /// The unique id of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// OCID of the tenancy to which the resource belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TenancyId is required.")]
        [JsonProperty(PropertyName = "tenancyId")]
        public string TenancyId { get; set; }
        
        /// <value>
        /// Associated region
        /// </value>
        [JsonProperty(PropertyName = "resourceRegion")]
        public string ResourceRegion { get; set; }
        
        /// <value>
        /// The time this resource was created. An RFC3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time this resource was last updated. An RFC3339 formatted datetime string.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// OCID of the compartment to which the resource belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My new resource
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Compliance State of the Resource
        /// </value>
        [JsonProperty(PropertyName = "complianceState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ComplianceState> ComplianceState { get; set; }
        
        /// <value>
        /// Resource Tenancy Name
        /// </value>
        [JsonProperty(PropertyName = "tenancyName")]
        public string TenancyName { get; set; }
        
        /// <value>
        /// Resource Compartment
        /// </value>
        [JsonProperty(PropertyName = "compartment")]
        public string Compartment { get; set; }
        
        /// <value>
        /// Type of the Resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceType is required.")]
        [JsonProperty(PropertyName = "resourceType")]
        public string ResourceType { get; set; }
        
        /// <value>
        /// Count of products within the resource.
        /// </value>
        [JsonProperty(PropertyName = "productCount")]
        public System.Nullable<int> ProductCount { get; set; }
        
        /// <value>
        /// Count of targets  within the resource.
        /// </value>
        [JsonProperty(PropertyName = "targetCount")]
        public System.Nullable<int> TargetCount { get; set; }
        
        /// <value>
        /// Product associated with the resource when resource type is fleet.Will only be returned for PRODUCT fleets that are part of a GROUP Fleet
        /// </value>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }
        
        /// <value>
        /// Application Type associated with the resource when resource type is fleet.Will only be returned for ENVIRONMENT fleets that are part of a GROUP Fleet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationType")]
        public string ApplicationType { get; set; }
        
        /// <value>
        /// Environment Type associated with the Fleet when resource type is fleet.Will only be returned for ENVIRONMENT fleets that are part of a GROUP Fleet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "environmentType")]
        public string EnvironmentType { get; set; }
        
        /// <value>
        /// The current state of the FleetResource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FleetResource.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
