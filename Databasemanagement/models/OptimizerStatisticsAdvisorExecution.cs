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
    /// The summary of the Optimizer Statistics Advisor execution, which includes information about the Managed Database
    /// and a comprehensive execution report.
    /// 
    /// </summary>
    public class OptimizerStatisticsAdvisorExecution 
    {
        
        [JsonProperty(PropertyName = "database")]
        public OptimizerDatabase Database { get; set; }
        
        [JsonProperty(PropertyName = "report")]
        public OptimizerStatisticsAdvisorExecutionReport Report { get; set; }
        
        /// <value>
        /// The name of the Optimizer Statistics Advisor task.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskName is required.")]
        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }
        
        /// <value>
        /// The name of the Optimizer Statistics Advisor execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExecutionName is required.")]
        [JsonProperty(PropertyName = "executionName")]
        public string ExecutionName { get; set; }
        
        /// <value>
        /// The start time of the time range to retrieve the Optimizer Statistics Advisor execution of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeStart is required.")]
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The end time of the time range to retrieve the Optimizer Statistics Advisor execution of a Managed Database
        /// in UTC in ISO-8601 format, which is \"yyyy-MM-dd'T'hh:mm:ss.sss'Z'\".
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeEnd is required.")]
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
                ///
        /// <value>
        /// The status of the Optimizer Statistics Advisor execution.
        /// </value>
        ///
        public enum StatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "EXECUTING")]
            Executing,
            [EnumMember(Value = "COMPLETED")]
            Completed,
            [EnumMember(Value = "INTERRUPTED")]
            Interrupted,
            [EnumMember(Value = "CANCELLED")]
            Cancelled,
            [EnumMember(Value = "FATAL_ERROR")]
            FatalError
        };

        /// <value>
        /// The status of the Optimizer Statistics Advisor execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Status is required.")]
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<StatusEnum> Status { get; set; }
        
        /// <value>
        /// The Optimizer Statistics Advisor execution status message, if any.
        /// </value>
        [JsonProperty(PropertyName = "statusMessage")]
        public string StatusMessage { get; set; }
        
        /// <value>
        /// The errors in the Optimizer Statistics Advisor execution, if any.
        /// </value>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        
        /// <value>
        /// The number of findings generated by the Optimizer Statistics Advisor execution.
        /// </value>
        [JsonProperty(PropertyName = "findings")]
        public System.Nullable<int> Findings { get; set; }
        
    }
}
