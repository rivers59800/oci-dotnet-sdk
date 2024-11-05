/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CimsService.Models;

namespace Oci.CimsService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/cims/ValidateUser.cs.html">here</a> to see an example of how to use ValidateUser request.
    /// </example>
    public class ValidateUserRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The Customer Support Identifier (CSI) number associated with the support account.
        /// The CSI is required for technical support tickets and optional for limits and billing tickets.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "csi")]
        public string Csi { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request, please provide the request ID.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The kind of support request.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "problemType")]
        public System.Nullable<ProblemType> ProblemType { get; set; }
        
        /// <value>
        /// User OCID for Oracle Identity Cloud Service (IDCS) users who also have a federated Oracle Cloud Infrastructure account.
        /// User OCID is mandatory for OCI Users and optional for Multicloud users.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "ocid")]
        public string Ocid { get; set; }
        
        /// <value>
        /// The region of the tenancy.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "homeregion")]
        public string Homeregion { get; set; }
        
        /// <value>
        /// Token type that determine which cloud provider the request come from.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "bearertokentype")]
        public string Bearertokentype { get; set; }
        
        /// <value>
        /// Token that provided by multi cloud provider, which help to validate the email.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "bearertoken")]
        public string Bearertoken { get; set; }
        
        /// <value>
        /// IdToken that provided by multi cloud provider, which help to validate the email.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "idtoken")]
        public string Idtoken { get; set; }
        
        /// <value>
        /// The OCID of identity domain.
        /// DomainID is mandatory if the user is part of Non Default Identity domain.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "domainid")]
        public string Domainid { get; set; }
    }
}
