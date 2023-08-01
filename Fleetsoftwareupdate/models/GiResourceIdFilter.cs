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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Related resource Ids to include in the discovery.
    /// 
    /// </summary>
    public class GiResourceIdFilter : GiFleetDiscoveryFilter
    {
                ///
        /// <value>
        /// Type of resource to match in the discovery.
        /// 
        /// </value>
        ///
        public enum EntityTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EXADATAINFRASTRUCTURE")]
            Exadatainfrastructure,
            [EnumMember(Value = "CLOUDEXADATAINFRASTRUCTURE")]
            Cloudexadatainfrastructure,
            [EnumMember(Value = "VMCLUSTER")]
            Vmcluster,
            [EnumMember(Value = "CLOUDVMCLUSTER")]
            Cloudvmcluster,
            [EnumMember(Value = "FSUCOLLECTION")]
            Fsucollection
        };

        /// <value>
        /// Type of resource to match in the discovery.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EntityType is required.")]
        [JsonProperty(PropertyName = "entityType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<EntityTypeEnum> EntityType { get; set; }
        
        /// <value>
        /// Related resource Ids to include in the discovery.
        /// All must match the specified entityType.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifiers is required.")]
        [JsonProperty(PropertyName = "identifiers")]
        public System.Collections.Generic.List<string> Identifiers { get; set; }
        
        /// <value>
        /// Type of join for each element in this filter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<FleetDiscoveryOperators> Operator { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "RESOURCE_ID";
    }
}
