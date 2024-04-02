/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ApigatewayService.Models;

namespace Oci.ApigatewayService.Responses
{
    public class ChangeUsagePlanCompartmentResponse : Oci.Common.OciResponse
    {

        /// <value>
        /// The OCID of the work request. Use
        /// {@link #getWorkRequest(GetWorkRequestRequest) getWorkRequest} with
        /// this id to track the status
        /// of the request.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-work-request-id")]
        public string OpcWorkRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to
        /// contact Oracle about a particular request, please provide the request
        /// id.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }



    }
}
