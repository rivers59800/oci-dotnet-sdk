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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// The details for replacing ESXi host.
    /// 
    /// </summary>
    public class ReplaceHostDetails 
    {
        
        /// <value>
        /// The ESXi software bundle to install on the ESXi host. 
        /// Only versions under the same vmwareSoftwareVersion and have been validate by Oracle Cloud VMware Solution will be accepted.
        /// To get a list of the available versions, use
        /// {@link #listSupportedVmwareSoftwareVersions(ListSupportedVmwareSoftwareVersionsRequest) listSupportedVmwareSoftwareVersions}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "esxiSoftwareVersion")]
        public string EsxiSoftwareVersion { get; set; }
        
    }
}
