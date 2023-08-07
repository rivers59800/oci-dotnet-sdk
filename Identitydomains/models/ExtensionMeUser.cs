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
    /// Oracle Identity Cloud Service self service schema extension
    /// </summary>
    public class ExtensionMeUser 
    {
        
        /// <value>
        /// The current password is required if the user attempts to change the values of attributes that are used in recovering or verifying the user's own identity.  If the current password is specified, it will be used to authenticate the user regardless of any change in these attribute values
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - idcsSearchable: false
        ///  - idcsSensitive: hash
        ///  - multiValued: false
        ///  - mutability: writeOnly
        ///  - required: false
        ///  - returned: never
        ///  - type: string
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "currentPassword")]
        public string CurrentPassword { get; set; }
        
    }
}
