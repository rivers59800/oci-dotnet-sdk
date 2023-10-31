/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.DisasterrecoveryService.Models;

namespace Oci.DisasterrecoveryService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/disasterrecovery/ListDrPlans.cs.html">here</a> to see an example of how to use ListDrPlans request.
    /// </example>
    public class ListDrPlansRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the DR protection group. Mandatory query param.
        /// <br/>
        /// Example: ocid1.drprotectiongroup.oc1..uniqueID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DrProtectionGroupId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "drProtectionGroupId")]
        public string DrProtectionGroupId { get; set; }
        
        /// <value>
        /// A filter to return only DR plans that match the given lifecycle state.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "lifecycleState")]
        public System.Nullable<DrPlanLifecycleState> LifecycleState { get; set; }
        
        /// <value>
        /// The OCID of the DR plan.
        /// <br/>
        /// Example: ocid1.drplan.oc1..uniqueID
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "drPlanId")]
        public string DrPlanId { get; set; }
        
        /// <value>
        /// The DR plan type.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "drPlanType")]
        public System.Nullable<DrPlanType> DrPlanType { get; set; }
        
        /// <value>
        /// A filter to return only resources that match the given display name.
        /// <br/>
        /// Example: MyResourceDisplayName
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// For list pagination. The maximum number of results per page,
        /// or items to return in a paginated \"List\" call.
        /// 1 is the minimum, 1000 is the maximum.
        /// <br/>
        /// For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// <br/>
        /// Example: 100
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "limit")]
        public System.Nullable<int> Limit { get; set; }
        
        /// <value>
        /// For list pagination. The value of the `opc-next-page` response
        /// header from the previous \"List\" call.
        /// <br/>
        /// For important details about how pagination works,
        /// see [List Pagination](https://docs.cloud.oracle.com/iaas/Content/API/Concepts/usingapi.htm#nine).
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "page")]
        public string Page { get; set; }
        
        /// <value>
        /// The sort order to use, either 'asc' or 'desc'.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortOrder")]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        ///
        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending.
        /// Default order for displayName is ascending. If no value is specified timeCreated is default.
        /// <br/>
        /// Example: MyResourceDisplayName
        /// </value>
        ///
        public enum SortByEnum {
            [EnumMember(Value = "timeCreated")]
            TimeCreated,
            [EnumMember(Value = "displayName")]
            DisplayName
        };

        /// <value>
        /// The field to sort by. Only one sort order may be provided. Default order for timeCreated is descending.
        /// Default order for displayName is ascending. If no value is specified timeCreated is default.
        /// <br/>
        /// Example: MyResourceDisplayName
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "sortBy")]
        public System.Nullable<SortByEnum> SortBy { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
