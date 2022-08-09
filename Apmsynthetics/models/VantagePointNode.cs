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


namespace Oci.ApmsyntheticsService.Models
{
    /// <summary>
    /// Vantage Point Node
    /// </summary>
    public class VantagePointNode 
    {
        
        /// <value>
        /// id of Vantage Point node
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// name of Vantage Point node
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// display name of Vantage Point node
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// geo info
        /// </value>
        [JsonProperty(PropertyName = "geoInfo")]
        public string GeoInfo { get; set; }
        
        /// <value>
        /// links outgoing from this Vantage Point node
        /// </value>
        [JsonProperty(PropertyName = "outgoingLinks")]
        public System.Collections.Generic.List<string> OutgoingLinks { get; set; }
        
    }
}
