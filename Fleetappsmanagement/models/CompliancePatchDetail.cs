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
    /// Details of the Patch
    /// </summary>
    public class CompliancePatchDetail 
    {
        
        /// <value>
        /// patch OCID.
        /// </value>
        [JsonProperty(PropertyName = "patchId")]
        public string PatchId { get; set; }
        
        /// <value>
        /// patch Name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchName is required.")]
        [JsonProperty(PropertyName = "patchName")]
        public string PatchName { get; set; }
        
        /// <value>
        /// Patch Description.
        /// </value>
        [JsonProperty(PropertyName = "patchDescription")]
        public string PatchDescription { get; set; }
        
        /// <value>
        /// Date on which patch was released
        /// </value>
        [JsonProperty(PropertyName = "timeReleased")]
        public System.Nullable<System.DateTime> TimeReleased { get; set; }
        
        /// <value>
        /// Type of patch.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatchType is required.")]
        [JsonProperty(PropertyName = "patchType")]
        public string PatchType { get; set; }
        
        /// <value>
        /// Patch Severity.
        /// </value>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatchSeverity> Severity { get; set; }
        
        [JsonProperty(PropertyName = "product")]
        public ComplianceDetailProduct Product { get; set; }
        
    }
}
