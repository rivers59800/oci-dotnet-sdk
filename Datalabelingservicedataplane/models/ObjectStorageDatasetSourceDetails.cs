/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatalabelingservicedataplaneService.Models
{
    /// <summary>
    /// Specifies the dataset location in object storage. This requires that all records are in this bucket, and under this prefix. We do not support a dataset with objects in arbitrary locations across buckets or prefixes.
    /// 
    /// </summary>
    public class ObjectStorageDatasetSourceDetails : DatasetSourceDetails
    {
        
        /// <value>
        /// The namespace of the bucket that contains the dataset data source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// The object storage bucket that contains the dataset data source.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Bucket is required.")]
        [JsonProperty(PropertyName = "bucket")]
        public string Bucket { get; set; }
        
        /// <value>
        /// A common path prefix shared by the objects that make up the dataset. Except for the CSV file type, records are not generated for the objects whose names exactly match with the prefix.
        /// </value>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "OBJECT_STORAGE";
    }
}
