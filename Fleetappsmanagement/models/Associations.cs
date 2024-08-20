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
    /// JSON content with required associations
    /// </summary>
    public class Associations 
    {
        
        /// <value>
        /// A set of tasks to execute in the runbook
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Tasks is required.")]
        [JsonProperty(PropertyName = "tasks")]
        public System.Collections.Generic.List<Task> Tasks { get; set; }
        
        /// <value>
        /// The groups of the runbook
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Groups is required.")]
        [JsonProperty(PropertyName = "groups")]
        public System.Collections.Generic.List<Group> Groups { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionWorkflowDetails is required.")]
        [JsonProperty(PropertyName = "executionWorkflowDetails")]
        public ExecutionWorkflowDetails ExecutionWorkflowDetails { get; set; }
        
        /// <value>
        /// The version of the runbook.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
    }
}
