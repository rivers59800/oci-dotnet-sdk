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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The SQL Firewall related configurations.
    /// 
    /// </summary>
    public class SqlFirewallConfig 
    {
                ///
        /// <value>
        /// Specifies if the firewall is enabled or disabled on the target database.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Specifies if the firewall is enabled or disabled on the target database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
                ///
        /// <value>
        /// Specifies whether Data Safe should automatically purge the violation logs 
        /// from the database after collecting the violation logs and persisting on Data Safe.
        /// 
        /// </value>
        ///
        public enum ViolationLogAutoPurgeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// Specifies whether Data Safe should automatically purge the violation logs 
        /// from the database after collecting the violation logs and persisting on Data Safe.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ViolationLogAutoPurge is required.")]
        [JsonProperty(PropertyName = "violationLogAutoPurge")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ViolationLogAutoPurgeEnum> ViolationLogAutoPurge { get; set; }
                ///
        /// <value>
        /// Specifies whether the firewall should include or exclude the database internal job activities.
        /// </value>
        ///
        public enum ExcludeJobEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EXCLUDED")]
            Excluded,
            [EnumMember(Value = "INCLUDED")]
            Included
        };

        /// <value>
        /// Specifies whether the firewall should include or exclude the database internal job activities.
        /// </value>
        [JsonProperty(PropertyName = "excludeJob")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExcludeJobEnum> ExcludeJob { get; set; }
        
        /// <value>
        /// The most recent time when the firewall status is updated, in the format defined by RFC3339.
        /// </value>
        [JsonProperty(PropertyName = "timeStatusUpdated")]
        public System.Nullable<System.DateTime> TimeStatusUpdated { get; set; }
        
    }
}
