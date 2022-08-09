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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// Public endpoint configuration details.
    /// 
    /// </summary>
    public class PublicEndpointDetails : NetworkEndpointDetails
    {
        
        /// <value>
        /// Source IP addresses or IP address ranges ingress rules. (ex: \"168.122.59.5\", \"10.20.30.0/26\")
        /// An invalid IP or CIDR block will result in a 400 response.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowlistedHttpIps")]
        public System.Collections.Generic.List<string> AllowlistedHttpIps { get; set; }
        
        /// <value>
        /// Virtual Cloud Networks allowed to access this network endpoint.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "allowlistedHttpVcns")]
        public System.Collections.Generic.List<VirtualCloudNetwork> AllowlistedHttpVcns { get; set; }
        
        /// <value>
        /// The Integration service's VCN is allow-listed to allow integrations to call back into other integrations
        /// </value>
        [JsonProperty(PropertyName = "isIntegrationVcnAllowlisted")]
        public System.Nullable<bool> IsIntegrationVcnAllowlisted { get; set; }
        
        [JsonProperty(PropertyName = "networkEndpointType")]
        private readonly string networkEndpointType = "PUBLIC";
    }
}
