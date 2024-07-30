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


namespace Oci.NetworkfirewallService.Models
{
    /// <summary>
    /// Vxlan Tunnel Inspection Rule used on the firewall policy rules.
    /// 
    /// </summary>
    public class VxlanInspectionRule : TunnelInspectionRule
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Condition is required.")]
        [JsonProperty(PropertyName = "condition")]
        public VxlanInspectionRuleMatchCriteria Condition { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Profile is required.")]
        [JsonProperty(PropertyName = "profile")]
        public VxlanInspectionRuleProfile Profile { get; set; }
        
        [JsonProperty(PropertyName = "protocol")]
        private readonly string protocol = "VXLAN";
    }
}
