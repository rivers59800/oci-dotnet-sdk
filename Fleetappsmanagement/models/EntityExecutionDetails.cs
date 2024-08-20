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
    /// Activity Resource and execution details including outcome.
    /// </summary>
    public class EntityExecutionDetails 
    {
        
        /// <value>
        /// Resource Identifier associated with the Work Request
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Resource Display Name
        /// </value>
        [JsonProperty(PropertyName = "resourceDisplayName")]
        public string ResourceDisplayName { get; set; }
        
        /// <value>
        /// Description of the Work Request
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The sequence of the Resource
        /// </value>
        [JsonProperty(PropertyName = "sequence")]
        public string Sequence { get; set; }
        
        /// <value>
        /// Targets associated.
        /// </value>
        [JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.List<ActivityResourceTarget> Targets { get; set; }
        
        /// <value>
        /// Status of the Job at Resource Level
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<JobStatus> Status { get; set; }
        
        /// <value>
        /// The time the task started for the resource. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeStarted")]
        public System.Nullable<System.DateTime> TimeStarted { get; set; }
        
        /// <value>
        /// The time the task ended for the resource. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeEnded")]
        public System.Nullable<System.DateTime> TimeEnded { get; set; }
        
    }
}
