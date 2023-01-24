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


namespace Oci.DatascienceService.Models
{
    /// <summary>
    /// Override details of the step. Only Step Configuration is allowed to be overridden.
    /// </summary>
    public class PipelineStepOverrideDetails 
    {
        
        /// <value>
        /// The name of the step.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepName is required.")]
        [JsonProperty(PropertyName = "stepName")]
        public string StepName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepConfigurationDetails is required.")]
        [JsonProperty(PropertyName = "stepConfigurationDetails")]
        public PipelineStepConfigurationDetails StepConfigurationDetails { get; set; }
        
    }
}
