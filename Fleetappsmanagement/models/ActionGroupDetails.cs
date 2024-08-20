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
    /// Action Group.
    /// </summary>
    public class ActionGroupDetails 
    {
        
        /// <value>
        /// The ID of the ActionGroup resource .
        /// Ex:fleetId.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Name of the ActionGroup.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Type of the ActionGroup
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifeCycleActionGroupType> Type { get; set; }
        
        /// <value>
        /// Application Type associated.
        /// Only applicable if actionGroup type is ENVIRONMENT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationType")]
        public string ApplicationType { get; set; }
        
        /// <value>
        /// Product associated.
        /// Only applicable if actionGroup type is PRODUCT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }
        
        /// <value>
        /// LifeCycle Operation
        /// </value>
        [JsonProperty(PropertyName = "lifecycleOperation")]
        public string LifecycleOperation { get; set; }
        
        /// <value>
        /// Unique producer Id at Action Group Level
        /// </value>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }
        
        /// <value>
        /// Status of the Job at Action Group Level
        /// </value>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JobStatus> Status { get; set; }
        
        /// <value>
        /// The time the the Scheduler Job started. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time the Scheduler Job ended. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// ID of the runbook
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunbookId is required.")]
        [JsonProperty(PropertyName = "runbookId")]
        public string RunbookId { get; set; }
        
    }
}
