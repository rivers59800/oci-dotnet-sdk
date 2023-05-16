/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Information about the service attachment to be created.
    /// </summary>
    public class CreateServiceAttachmentDetails 
    {
        
        /// <value>
        /// Type of the ServiceInstance being attached.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceInstanceType is required.")]
        [JsonProperty(PropertyName = "serviceInstanceType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ServiceAttachment.ServiceInstanceTypeEnum> ServiceInstanceType { get; set; }
        
        /// <value>
        /// The service instance OCID of the instance being attached
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ServiceInstanceId is required.")]
        [JsonProperty(PropertyName = "serviceInstanceId")]
        public string ServiceInstanceId { get; set; }
        
    }
}
