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
    /// A target that is discovered by the Software discovery process.
    /// 
    /// </summary>
    public class DiscoveredTarget 
    {
        
        /// <value>
        /// ID of the Target. Can be the target name if a separate ID is not available.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Target Name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetName is required.")]
        [JsonProperty(PropertyName = "targetName")]
        public string TargetName { get; set; }
        
        /// <value>
        /// Product that the target belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Product is required.")]
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }
        
        /// <value>
        /// Unique key that identifies the resource that the target belongs to.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ResourceId is required.")]
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Current version of the target.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
    }
}
