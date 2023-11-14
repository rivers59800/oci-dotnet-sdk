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


namespace Oci.IdentitydomainsService.Models
{
    /// <summary>
    /// References to various images
    /// </summary>
    public class SettingsDefaultImages 
    {
        
        /// <value>
        /// Image URI
        /// <br/>
        /// **Added In:** 18.2.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: default
        ///  - type: reference
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Value is required.")]
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
        
        /// <value>
        /// Indicates the image type
        /// <br/>
        /// **Added In:** 18.2.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: true
        ///  - returned: default
        ///  - type: string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// A human-readable name, primarily used for display purposes
        /// <br/>
        /// **Added In:** 18.2.2
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - multiValued: false
        ///  - mutability: readOnly
        ///  - required: false
        ///  - returned: default
        ///  - type: string
        /// </value>
        [JsonProperty(PropertyName = "display")]
        public string Display { get; set; }
        
    }
}
