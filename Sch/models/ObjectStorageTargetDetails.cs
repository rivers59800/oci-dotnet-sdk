/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.SchService.Models
{
    /// <summary>
    /// The bucket used for the Object Storage target.
    /// For configuration instructions, see
    /// [To create a service connector](https://docs.cloud.oracle.com/iaas/Content/service-connector-hub/managingconnectors.htm#create).
    /// 
    /// </summary>
    public class ObjectStorageTargetDetails : TargetDetails
    {
        
        /// <value>
        /// The namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The name of the bucket. Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BucketName is required.")]
        [JsonProperty(PropertyName = "bucketName")]
        public string BucketName { get; set; }
        
        /// <value>
        /// The prefix of the objects. Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectNamePrefix")]
        public string ObjectNamePrefix { get; set; }
        
        /// <value>
        /// The batch rollover size in megabytes.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "batchRolloverSizeInMBs")]
        public System.Nullable<int> BatchRolloverSizeInMBs { get; set; }
        
        /// <value>
        /// The batch rollover time in milliseconds.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "batchRolloverTimeInMs")]
        public System.Nullable<int> BatchRolloverTimeInMs { get; set; }
        
        [JsonProperty(PropertyName = "kind")]
        private readonly string kind = "objectStorage";
    }
}
