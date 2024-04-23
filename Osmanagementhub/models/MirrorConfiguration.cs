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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Mirror information used for the management station configuration.
    /// </summary>
    public class MirrorConfiguration 
    {
        
        /// <value>
        /// Path to the data volume on the management station where software source mirrors are stored.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Directory is required.")]
        [JsonProperty(PropertyName = "directory")]
        public string Directory { get; set; }
        
        /// <value>
        /// Default mirror listening port for http.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public string Port { get; set; }
        
        /// <value>
        /// Default mirror listening port for https.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Sslport is required.")]
        [JsonProperty(PropertyName = "sslport")]
        public string Sslport { get; set; }
        
        /// <value>
        /// Path to the SSL cerfificate.
        /// </value>
        [JsonProperty(PropertyName = "sslcert")]
        public string Sslcert { get; set; }
        
    }
}
