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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The request details object to implement the Optimizer Statistics Advisor task recommendations.
    /// </summary>
    public class ImplementOptimizerStatisticsAdvisorRecommendationsDetails 
    {
        
        /// <value>
        /// The name of the task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskName is required.")]
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobDetails is required.")]
        [JsonProperty(PropertyName = "jobDetails")]
        public ImplementOptimizerStatisticsAdvisorRecommendationsJob JobDetails { get; set; }
        
    }
}
