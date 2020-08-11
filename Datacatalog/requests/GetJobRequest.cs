/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DatacatalogService.Models;

namespace Oci.DatacatalogService.Requests
{
    public class GetJobRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// Unique catalog identifier.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CatalogId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "catalogId")]
        public string CatalogId { get; set; }
        
        /// <value>
        /// Unique job key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "jobKey")]
        public string JobKey { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a job response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "catalogId")]
            CatalogId,
            [EnumMember(Value = "lifecycleState")]
            LifecycleState,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "timeUpdated")]
            TimeUpdated,
            [EnumMember(Value = "jobType")]
            JobType,
            [EnumMember(Value = "scheduleCronExpression")]
            ScheduleCronExpression,
            [EnumMember(Value = "timeScheduleBegin")]
            TimeScheduleBegin,
            [EnumMember(Value = "timeScheduleEnd")]
            TimeScheduleEnd,
            [EnumMember(Value = "scheduleType")]
            ScheduleType,
            [EnumMember(Value = "connectionKey")]
            ConnectionKey,
            [EnumMember(Value = "jobDefinitionKey")]
            JobDefinitionKey,
            [EnumMember(Value = "internalVersion")]
            InternalVersion,
            [EnumMember(Value = "executionCount")]
            ExecutionCount,
            [EnumMember(Value = "timeOfLatestExecution")]
            TimeOfLatestExecution,
            [EnumMember(Value = "executions")]
            Executions,
            [EnumMember(Value = "createdById")]
            CreatedById,
            [EnumMember(Value = "updatedById")]
            UpdatedById,
            [EnumMember(Value = "uri")]
            Uri,
            [EnumMember(Value = "jobDefinitionName")]
            JobDefinitionName,
            [EnumMember(Value = "errorCode")]
            ErrorCode,
            [EnumMember(Value = "errorMessage")]
            ErrorMessage
        };

        /// <value>
        /// Specifies the fields to return in a job response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}