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


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// Virtual machine related properties.
    /// </summary>
    public class VmProperties 
    {
        
        /// <value>
        /// Hypervisor vendor.
        /// </value>
        [JsonProperty(PropertyName = "hypervisorVendor")]
        public string HypervisorVendor { get; set; }
        
        /// <value>
        /// Hypervisor version.
        /// </value>
        [JsonProperty(PropertyName = "hypervisorVersion")]
        public string HypervisorVersion { get; set; }
        
        /// <value>
        /// Host name/IP address of VM on which the host is running.
        /// </value>
        [JsonProperty(PropertyName = "hypervisorHost")]
        public string HypervisorHost { get; set; }
        
    }
}
