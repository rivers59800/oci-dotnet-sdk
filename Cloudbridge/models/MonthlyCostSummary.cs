/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.CloudbridgeService.Models
{
    /// <summary>
    /// Cost information for monthly maintenance.
    /// </summary>
    public class MonthlyCostSummary 
    {
        
        /// <value>
        /// Monthly costs for maintenance of this asset.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Amount is required.")]
        [JsonProperty(PropertyName = "amount")]
        public System.Double Amount { get; set; }
        
        /// <value>
        /// Currency code as defined by ISO-4217.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CurrencyCode is required.")]
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }
        
    }
}
