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
    /// Identifier for an existing detector recipe to use to create
    /// a new detector recipe (TargetDetectorRecipe resource) to be
    /// attached to a target.
    /// 
    /// </summary>
    public class AttachTargetDetectorRecipeDetails 
    {
        
        /// <value>
        /// Detector recipe unique identifier
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DetectorRecipeId is required.")]
        [JsonProperty(PropertyName = "detectorRecipeId")]
        public string DetectorRecipeId { get; set; }
        
    }
}
