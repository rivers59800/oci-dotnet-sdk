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


namespace Oci.BdsService.Models
{
    /// <summary>
    /// The request body when creating BDS metastore configuration.
    /// </summary>
    public class CreateBdsMetastoreConfigurationDetails 
    {
        
        /// <value>
        /// The display name of the metastore configuration
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The OCID of the Data Catalog metastore.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetastoreId is required.")]
        [JsonProperty(PropertyName = "metastoreId")]
        public string MetastoreId { get; set; }
        
        /// <value>
        /// The ID of BDS Api Key used for Data Catalog metastore integration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BdsApiKeyId is required.")]
        [JsonProperty(PropertyName = "bdsApiKeyId")]
        public string BdsApiKeyId { get; set; }
        
        /// <value>
        /// Base-64 encoded passphrase of the BDS Api Key.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BdsApiKeyPassphrase is required.")]
        [JsonProperty(PropertyName = "bdsApiKeyPassphrase")]
        public string BdsApiKeyPassphrase { get; set; }
        
        /// <value>
        /// Base-64 encoded password for the cluster admin user.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ClusterAdminPassword is required.")]
        [JsonProperty(PropertyName = "clusterAdminPassword")]
        public string ClusterAdminPassword { get; set; }
        
    }
}
