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


namespace Oci.CloudguardService.Models
{
    /// <summary>
    /// Problem history definition.
    /// </summary>
    public class ProblemHistorySummary 
    {
        
        /// <value>
        /// Unique identifier for the history record
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Problem ID with which history is associated
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProblemId is required.")]
        [JsonProperty(PropertyName = "problemId")]
        public string ProblemId { get; set; }
        
        /// <value>
        /// Type of actor who performed the operation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActorType is required.")]
        [JsonProperty(PropertyName = "actorType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActorType> ActorType { get; set; }
        
        /// <value>
        /// Resource name who performed the activity
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActorName is required.")]
        [JsonProperty(PropertyName = "actorName")]
        public string ActorName { get; set; }
        
        /// <value>
        /// Activity explanation details
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Explanation is required.")]
        [JsonProperty(PropertyName = "explanation")]
        public string Explanation { get; set; }
        
        /// <value>
        /// Additional details on the substate of the lifecycle state
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleDetail is required.")]
        [JsonProperty(PropertyName = "lifecycleDetail")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ProblemLifecycleDetail> LifecycleDetail { get; set; }
        
        /// <value>
        /// Event status
        /// </value>
        [JsonProperty(PropertyName = "eventStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EventStatus> EventStatus { get; set; }
        
        /// <value>
        /// Date and time the problem was created
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Impacted resource names in a comma-separated string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Delta is required.")]
        [JsonProperty(PropertyName = "delta")]
        public string Delta { get; set; }
        
        /// <value>
        /// User-defined comments
        /// </value>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }
        
        /// <value>
        /// Locks associated with this resource.
        /// </value>
        [JsonProperty(PropertyName = "locks")]
        public System.Collections.Generic.List<ResourceLock> Locks { get; set; }
        
    }
}
