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


namespace Oci.UsageService.Models
{
    /// <summary>
    /// The SKU Product Id details for a resource.
    /// 
    /// </summary>
    public class SkuProducts 
    {
        
        /// <value>
        /// The Sku Id for the resource.
        /// </value>
        [JsonProperty(PropertyName = "skuId")]
        public string SkuId { get; set; }
        
        /// <value>
        /// The Sku type for the resource.
        /// </value>
        [JsonProperty(PropertyName = "skuType")]
        public string SkuType { get; set; }
        
        /// <value>
        /// The cloud credit type for the resource.
        /// </value>
        [JsonProperty(PropertyName = "cloudCreditType")]
        public string CloudCreditType { get; set; }
        
    }
}
