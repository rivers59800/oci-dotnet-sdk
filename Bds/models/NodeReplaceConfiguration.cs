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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The information about the NodeReplaceConfiguration.
    /// </summary>
    public class NodeReplaceConfiguration 
    {
        
        /// <value>
        /// The unique identifier for the NodeReplaceConfiguration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The OCID of the bdsInstance which is the parent resource id.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BdsInstanceId is required.")]
        [JsonProperty(PropertyName = "bdsInstanceId")]
        public string BdsInstanceId { get; set; }
        
        /// <value>
        /// A user-friendly name. Only ASCII alphanumeric characters with no spaces allowed. The name does not have to be unique, and it may be changed. Avoid entering confidential information.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LevelTypeDetails is required.")]
        [JsonProperty(PropertyName = "levelTypeDetails")]
        public LevelTypeDetails LevelTypeDetails { get; set; }
                ///
        /// <value>
        /// The state of the NodeReplaceConfiguration.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The state of the NodeReplaceConfiguration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The time the NodeReplaceConfiguration was created, shown as an RFC 3339 formatted datetime string.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the NodeReplaceConfiguration was updated, shown as an RFC 3339 formatted datetime string.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
                ///
        /// <value>
        /// Type of compute instance health metric to use for node replacement
        /// </value>
        ///
        public enum MetricTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "INSTANCE_STATUS")]
            InstanceStatus,
            [EnumMember(Value = "INSTANCE_ACCESSIBILITY_STATUS")]
            InstanceAccessibilityStatus
        };

        /// <value>
        /// Type of compute instance health metric to use for node replacement
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricType is required.")]
        [JsonProperty(PropertyName = "metricType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MetricTypeEnum> MetricType { get; set; }
        
        /// <value>
        /// This value is the minimum period of time to wait for metric emission before triggering node replacement. The value is in minutes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DurationInMinutes is required.")]
        [JsonProperty(PropertyName = "durationInMinutes")]
        public System.Nullable<int> DurationInMinutes { get; set; }
        
    }
}
