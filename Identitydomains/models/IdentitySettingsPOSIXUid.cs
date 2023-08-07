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
    /// A list of Posix Uid settings.
    /// <br/>
    /// **Added In:** 17.4.6
    /// <br/>
    /// **SCIM++ Properties:**
    ///  - caseExact: false
    ///  - multiValued: false
    ///  - required: false
    ///  - type: complex
    ///  - uniqueness: none
    /// </summary>
    public class IdentitySettingsPOSIXUid 
    {
        
        /// <value>
        /// The number from which the Posix Uid Manual assignment starts.
        /// <br/>
        /// **Added In:** 17.4.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "manualAssignmentStartsFrom")]
        public System.Nullable<int> ManualAssignmentStartsFrom { get; set; }
        
        /// <value>
        /// The number at which the Posix Uid Manual assignment ends.
        /// <br/>
        /// **Added In:** 17.4.6
        /// <br/>
        /// **SCIM++ Properties:**
        ///  - caseExact: false
        ///  - multiValued: false
        ///  - mutability: readWrite
        ///  - required: false
        ///  - returned: default
        ///  - type: integer
        ///  - uniqueness: none
        /// </value>
        [JsonProperty(PropertyName = "manualAssignmentEndsAt")]
        public System.Nullable<int> ManualAssignmentEndsAt { get; set; }
        
    }
}
