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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The details of the Optimizer Statistics Collection task.
    /// </summary>
    public class OptimizerStatisticsOperationTask 
    {
        
        /// <value>
        /// The name of the target object for which statistics are gathered.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Target is required.")]
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }
                ///
        /// <value>
        /// The type of target object.
        /// </value>
        ///
        public enum TargetTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "TABLE")]
            Table,
            [EnumMember(Value = "GLOBAL_TABLE")]
            GlobalTable,
            [EnumMember(Value = "COORDINATOR_TABLE")]
            CoordinatorTable,
            [EnumMember(Value = "TABLE_PARTITION")]
            TablePartition,
            [EnumMember(Value = "TABLE_SUBPARTITION")]
            TableSubpartition,
            [EnumMember(Value = "INDEX")]
            Index,
            [EnumMember(Value = "INDEX_PARTITION")]
            IndexPartition,
            [EnumMember(Value = "INDEX_SUBPARTITION")]
            IndexSubpartition
        };

        /// <value>
        /// The type of target object.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetType is required.")]
        [JsonProperty(PropertyName = "targetType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TargetTypeEnum> TargetType { get; set; }
        
        /// <value>
        /// The start time of the Optimizer Statistics Collection task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStart is required.")]
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The end time of the Optimizer Statistics Collection task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnd is required.")]
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
                ///
        /// <value>
        /// The status of the Optimizer Statistics Collection task.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "SKIPPED")]
            Skipped,
            [EnumMember(Value = "TIMED_OUT")]
            TimedOut,
            [EnumMember(Value = "COMPLETED")]
            Completed,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The status of the Optimizer Statistics Collection task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
    }
}
