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
    public class ActionGroup 
    {
        
        /// <value>
        /// Provide the ID of the resource. Example fleet ID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// ActionGroup Type associated.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifeCycleActionGroupType> Type { get; set; }
        
        /// <value>
        /// Application Type associated.
        /// Only applicable if type is ENVIRONMENT.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applicationType")]
        public string ApplicationType { get; set; }
        
        /// <value>
        /// Product associated.
        /// Only applicable if type is PRODUCT.
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
        /// ID of the runbook
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RunbookId is required.")]
        [JsonProperty(PropertyName = "runbookId")]
        public string RunbookId { get; set; }
        
        /// <value>
        /// Provide the target if schedule is created against the target
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Provide subjects that need to be considered for the schedule.
        /// </value>
        [JsonProperty(PropertyName = "subjects")]
        public System.Collections.Generic.List<string> Subjects { get; set; }
        
    }
}
