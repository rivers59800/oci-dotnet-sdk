/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The summary of a DR plan execution.
    /// </summary>
    public class DrPlanExecutionSummary 
    {
        
        /// <value>
        /// The OCID of the DR plan execution.
        /// <br/>
        /// Example: ocid1.drplanexecution.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing this plan execution.
        /// <br/>
        /// Example: ocid1.compartment.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The display name of the DR plan execution.
        /// <br/>
        /// Example: Execution - EBS Switchover PHX to IAD
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the DR plan for this DR plan execution.
        /// <br/>
        /// Example: ocid1.drplan.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanId is required.")]
        [JsonProperty(PropertyName = "planId")]
        public string PlanId { get; set; }
        
        /// <value>
        /// The type of the DR plan execution.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PlanExecutionType is required.")]
        [JsonProperty(PropertyName = "planExecutionType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanExecutionType> PlanExecutionType { get; set; }
        
        /// <value>
        /// The OCID of the DR protection group to which this DR plan execution belongs.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrProtectionGroupId is required.")]
        [JsonProperty(PropertyName = "drProtectionGroupId")]
        public string DrProtectionGroupId { get; set; }
        
        /// <value>
        /// The OCID of peer DR protection group associated with this DR plan execution's
        /// DR protection group.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerDrProtectionGroupId is required.")]
        [JsonProperty(PropertyName = "peerDrProtectionGroupId")]
        public string PeerDrProtectionGroupId { get; set; }
        
        /// <value>
        /// The region of the peer DR protection group associated with this DR plan execution's
        /// DR protection group.
        /// <br/>
        /// Example: us-ashburn-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PeerRegion is required.")]
        [JsonProperty(PropertyName = "peerRegion")]
        public string PeerRegion { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LogLocation is required.")]
        [JsonProperty(PropertyName = "logLocation")]
        public ObjectStorageLogLocation LogLocation { get; set; }
        
        /// <value>
        /// The date and time at which DR plan execution was created. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The date and time at which DR plan execution began. An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time when this DR plan execution was last updated.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The date and time at which DR plan execution succeeded, failed, was paused, or canceled.
        /// An RFC3339 formatted datetime string.
        /// <br/>
        /// Example: 2019-03-29T09:36:42Z
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
        /// <value>
        /// The total duration in seconds taken to complete the DR plan execution.
        /// <br/>
        /// Example: 750
        /// </value>
        [JsonProperty(PropertyName = "executionDurationInSec")]
        public System.Nullable<int> ExecutionDurationInSec { get; set; }
        
        /// <value>
        /// The current state of the DR plan execution.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DrPlanExecutionLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the DR plan execution's current state in more detail.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "lifeCycleDetails")]
        public string LifeCycleDetails { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// <br/>
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
