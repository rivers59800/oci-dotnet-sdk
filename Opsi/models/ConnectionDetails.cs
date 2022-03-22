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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Connection details to connect to the database. HostName, protocol, and port should be specified.
    /// </summary>
    public class ConnectionDetails 
    {
        
        /// <value>
        /// Name of the listener host that will be used to create the connect string to the database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HostName is required.")]
        [JsonProperty(PropertyName = "hostName")]
        public string HostName { get; set; }
                ///
        /// <value>
        /// Protocol used for connection requests.
        /// </value>
        ///
        public enum ProtocolEnum {
            [EnumMember(Value = "TCP")]
            Tcp,
            [EnumMember(Value = "TCPS")]
            Tcps
        };

        /// <value>
        /// Protocol used for connection requests.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Protocol is required.")]
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ProtocolEnum> Protocol { get; set; }
        
        /// <value>
        /// Listener port number used for connection requests.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Port is required.")]
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
        /// <value>
        /// Database service name used for connection requests.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceName is required.")]
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
    }
}
