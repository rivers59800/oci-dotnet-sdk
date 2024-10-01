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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The summary of the Exadata system infrastructure discovery.
    /// </summary>
    public class ExternalExadataInfrastructureDiscoverySummary : EntityDiscovered
    {
                ///
        /// <value>
        /// The size of the Exadata infrastructure.
        /// </value>
        ///
        public enum RackSizeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "FULL")]
            Full,
            [EnumMember(Value = "HALF")]
            Half,
            [EnumMember(Value = "QUARTER")]
            Quarter,
            [EnumMember(Value = "EIGHTH")]
            Eighth
        };

        /// <value>
        /// The size of the Exadata infrastructure.
        /// </value>
        [JsonProperty(PropertyName = "rackSize")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<RackSizeEnum> RackSize { get; set; }
        
        [JsonProperty(PropertyName = "entityType")]
        private readonly string entityType = "INFRASTRUCTURE_DISCOVER_SUMMARY";
    }
}
