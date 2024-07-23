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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Host Containers details
    /// 
    /// </summary>
    public class HostContainers : HostPerformanceMetricGroup
    {
        
        /// <value>
        /// Container Id (full)
        /// </value>
        [JsonProperty(PropertyName = "containerId")]
        public string ContainerId { get; set; }
        
        /// <value>
        /// Container Name
        /// </value>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }
        
        /// <value>
        /// Container Image (may include tag version)
        /// </value>
        [JsonProperty(PropertyName = "containerImage")]
        public string ContainerImage { get; set; }
        
        /// <value>
        /// Container open ports
        /// </value>
        [JsonProperty(PropertyName = "containerPorts")]
        public string ContainerPorts { get; set; }
        
        [JsonProperty(PropertyName = "metricName")]
        private readonly string metricName = "HOST_CONTAINERS";
    }
}
