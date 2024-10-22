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
    /// The details of the output variable that will be used for mapping.
    /// </summary>
    public class OutputVariableDetails 
    {
        
        /// <value>
        /// The name of the task step the output variable belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StepName is required.")]
        [JsonProperty(PropertyName = "stepName")]
        public string StepName { get; set; }
        
        /// <value>
        /// The name of the output variable whose value has to be mapped.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OutputVariableName is required.")]
        [JsonProperty(PropertyName = "outputVariableName")]
        public string OutputVariableName { get; set; }
        
    }
}
