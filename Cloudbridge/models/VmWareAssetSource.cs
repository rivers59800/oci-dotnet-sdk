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
    /// Description of an asset source.
    /// </summary>
    public class VmWareAssetSource : AssetSource
    {
        
        /// <value>
        /// Endpoint for VMware asset discovery and replication in the form of ```https://<host>:<port>/sdk```
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "VcenterEndpoint is required.")]
        [JsonProperty(PropertyName = "vcenterEndpoint")]
        public string VcenterEndpoint { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DiscoveryCredentials is required.")]
        [JsonProperty(PropertyName = "discoveryCredentials")]
        public AssetSourceCredentials DiscoveryCredentials { get; set; }
        
        [JsonProperty(PropertyName = "replicationCredentials")]
        public AssetSourceCredentials ReplicationCredentials { get; set; }
        
        /// <value>
        /// Flag indicating whether historical metrics are collected for assets, originating from this asset source.
        /// </value>
        [JsonProperty(PropertyName = "areHistoricalMetricsCollected")]
        public System.Nullable<bool> AreHistoricalMetricsCollected { get; set; }
        
        /// <value>
        /// Flag indicating whether real-time metrics are collected for assets, originating from this asset source.
        /// </value>
        [JsonProperty(PropertyName = "areRealtimeMetricsCollected")]
        public System.Nullable<bool> AreRealtimeMetricsCollected { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "VMWARE";
    }
}
