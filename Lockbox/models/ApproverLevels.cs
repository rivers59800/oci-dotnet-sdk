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


namespace Oci.LockboxService.Models
{
    /// <summary>
    /// The approver levels.
    /// </summary>
    public class ApproverLevels 
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Level1 is required.")]
        [JsonProperty(PropertyName = "level1")]
        public ApproverInfo Level1 { get; set; }
        
        [JsonProperty(PropertyName = "level2")]
        public ApproverInfo Level2 { get; set; }
        
        [JsonProperty(PropertyName = "level3")]
        public ApproverInfo Level3 { get; set; }
        
    }
}
