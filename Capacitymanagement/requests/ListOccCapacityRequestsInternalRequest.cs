/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CapacitymanagementService.Models;

namespace Oci.CapacitymanagementService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/capacitymanagement/ListOccCapacityRequestsInternal.cs.html">here</a> to see an example of how to use ListOccCapacityRequestsInternal request.
    /// </example>
    public class ListOccCapacityRequestsInternalRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The ocid of the compartment or tenancy in which resources are to be listed. This will also be used for authorization purposes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The customer group ocid by which we would filter the list.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OccCustomerGroupId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "occCustomerGroupId")]
        public string OccCustomerGroupId { get; set; }
        
        /// <value>
        /// A filter to return the list of capacity requests based on the OCID of the availability catalog against which they were created.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "occAvailabilityCatalogId")]
        public string OccAvailabilityCatalogId { get; set; }
        
        /// <value>
        /// The namespace by which we would filter the list.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "namespace")]
        public System.Nullable<Namespace> Namespace { get; set; }
        
        /// <value>
        /// A filter to return only the resources that match the entire display name. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A filter to return only the resources that match the request type. The match is not case sensitive.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "requestType")]
        public System.Nullable<OccCapacityRequest.RequestTypeEnum> RequestType { get; set; }
        
        /// <value>
        /// A filter to return the list of capacity requests based on the OCID of the capacity request. This is done for the users who have INSPECT permission on the resource but do not have READ permission.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The maximum number of items to return.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// A token representing the position at which to start retrieving results. This must come from `opc-next-page` header field of a previous response.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The client request ID for tracing. The only valid characters for request IDs are letters, numbers,
        /// underscore, and dash.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The sort order to use, either 'ASC' or 'DESC'.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. The default order for display name is ascending. The default order for time created is reverse chronological order(latest date at the top).
        /// 
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "displayName")]
            DisplayName,
            [EnumMember(Value = "timeCreated")]
            TimeCreated
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. The default order for display name is ascending. The default order for time created is reverse chronological order(latest date at the top).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
    }
}
