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


namespace Oci.MarketplaceprivateofferService.Models
{
    /// <summary>
    /// the internal details of an offer that are only visible to the seller
    /// </summary>
    public class OfferInternalDetail 
    {
        
        /// <value>
        /// A list of key value pairs specified by the seller
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CustomFields is required.")]
        [JsonProperty(PropertyName = "customFields")]
        public System.Collections.Generic.List<CustomField> CustomFields { get; set; }
        
        /// <value>
        /// Internal notes only intended for the Publisher of the Offer
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InternalNotes is required.")]
        [JsonProperty(PropertyName = "internalNotes")]
        public string InternalNotes { get; set; }
        
    }
}
