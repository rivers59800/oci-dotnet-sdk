/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CloudbridgeService.Models;

namespace Oci.CloudbridgeService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/cloudbridge/ImportInventory.cs.html">here</a> to see an example of how to use ImportInventory request.
    /// </example>
    public class ImportInventoryRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The file input to create resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImportInventoryDetails is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Body)]
        public ImportInventoryDetails ImportInventoryDetails { get; set; }
        
        /// <value>
        /// Inventory OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InventoryId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "inventoryId")]
        public string InventoryId { get; set; }
        
        /// <value>
        /// A token that uniquely identifies a request so it can be retried in case of a timeout or
        /// server error without risk of executing the same action again. Retry tokens expire after 24
        /// hours, but can be invalidated before 24 hours due to conflicting operations. For example, if a resource
        /// has been deleted and purged from the system, a retry of the original creation request
        /// might be rejected.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-retry-token")]
        public string OpcRetryToken { get; set; }
        
        /// <value>
        /// The client request ID for tracing.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
    }
}
