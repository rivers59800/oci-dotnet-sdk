/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.RecoveryService.Models;

namespace Oci.RecoveryService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/recovery/ListWorkRequests.cs.html">here</a> to see an example of how to use ListWorkRequests request.
    /// </example>
    public class ListWorkRequestsRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The compartment OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier of the work request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "workRequestId")]
        public string WorkRequestId { get; set; }
        
        /// <value>
        /// A filter to return only resources their lifecycleState matches the given OperationStatus.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "status")]
        public System.Nullable<OperationStatus> Status { get; set; }
        
        /// <value>
        /// The ID of the resource affected by the work request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "resourceId")]
        public string ResourceId { get; set; }
        
        /// <value>
        /// Unique identifier for the request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The page token representing the page at which to start retrieving results. This is usually retrieved from a previous list call.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The maximum number of items to return per page.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// The sort order to use, either ascending (ASC) or descending (DESC).
        /// Allowed values are:
        ///   - ASC
        ///   - DESC
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeAccepted is descending.
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeAccepted")]
            TimeAccepted
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeAccepted is descending.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
    }
}
