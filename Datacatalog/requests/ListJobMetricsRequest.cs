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
    public class ListJobMetricsRequest : Oci.Common.IOciRequest
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
        
        /// <value>
        /// The key of the job execution.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JobExecutionKey is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "jobExecutionKey")]
        public string JobExecutionKey { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the entire display name given. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A filter to return only resources that match display name pattern given. The match is not case sensitive.
        /// For Example : /folders?displayNameContains=Cu.*
        /// The above would match all folders with display name that starts with \"Cu\".
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayNameContains")]
        public string DisplayNameContains { get; set; }
        
        /// <value>
        /// Category of this metric.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "category")]
        public string Category { get; set; }
        
        /// <value>
        /// Sub category of this metric under the category. Used for aggregating values. May be null.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "subCategory")]
        public string SubCategory { get; set; }
        
        /// <value>
        /// Unit of this metric.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "unit")]
        public string Unit { get; set; }
        
        /// <value>
        /// Value of this metric.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Batch key for grouping, may be null.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "batchKey")]
        public string BatchKey { get; set; }
        
        /// <value>
        /// Time that the resource was created. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// Time that the resource was updated. An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time the metric was logged or captured in the system where the job executed.
        /// An [RFC3339](https://tools.ietf.org/html/rfc3339) formatted datetime string.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "timeInserted")]
        public System.Nullable<System.DateTime> TimeInserted { get; set; }
        
        /// <value>
        /// OCID of the user who created the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "createdById")]
        public string CreatedById { get; set; }
        
        /// <value>
        /// OCID of the user who updated the resource.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "updatedById")]
        public string UpdatedById { get; set; }
        
        ///
        /// <value>
        /// Specifies the fields to return in a job metric summary response.
        /// 
        /// </value>
        ///
        public enum FieldsEnum {
            [EnumMember(Value = "key")]
            Key,
            [EnumMember(Value = "description")]
            Description,
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "timeInserted")]
            TimeInserted,
            [EnumMember(Value = "category")]
            Category,
            [EnumMember(Value = "subCategory")]
            SubCategory,
            [EnumMember(Value = "unit")]
            Unit,
            [EnumMember(Value = "value")]
            Value,
            [EnumMember(Value = "batchKey")]
            BatchKey,
            [EnumMember(Value = "jobExecutionKey")]
            JobExecutionKey,
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "uri")]
            Uri
        };

        /// <value>
        /// Specifies the fields to return in a job metric summary response.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "fields")]
        public System.Collections.Generic.List<FieldsEnum> Fields { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for TIMECREATED is descending. Default order for DISPLAYNAME is ascending. If no value is specified TIMECREATED is default.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "TIMECREATED")]
            Timecreated,
            [EnumMember(Value = "DISPLAYNAME")]
            Displayname
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for TIMECREATED is descending. Default order for DISPLAYNAME is ascending. If no value is specified TIMECREATED is default.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        ///
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        ///
        public enum SortOrderEnum {
            [EnumMember(Value = "ASC")]
            Asc,
            [EnumMember(Value = "DESC")]
            Desc
        };

        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrderEnum> SortOrder { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}