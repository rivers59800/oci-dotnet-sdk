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


namespace Oci.ObjectstorageService.Models
{
    
    public class CreatePreauthenticatedRequestDetails 
    {
        
        /// <value>
        /// A user-specified name for the pre-authenticated request. Names can be helpful in managing pre-authenticated requests.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The name of the object that is being granted access to by the pre-authenticated request. Avoid entering confidential
        /// information. The object name can be null and if so, the pre-authenticated request grants access to the entire bucket.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
                ///
        /// <value>
        /// The operation that can be performed on this resource.
        /// </value>
        ///
        public enum AccessTypeEnum {
            [EnumMember(Value = "ObjectRead")]
            ObjectRead,
            [EnumMember(Value = "ObjectWrite")]
            ObjectWrite,
            [EnumMember(Value = "ObjectReadWrite")]
            ObjectReadWrite,
            [EnumMember(Value = "AnyObjectWrite")]
            AnyObjectWrite
        };

        /// <value>
        /// The operation that can be performed on this resource.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessType is required.")]
        [JsonProperty(PropertyName = "accessType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AccessTypeEnum> AccessType { get; set; }
        
        /// <value>
        /// The expiration date for the pre-authenticated request as per [RFC 3339](https://tools.ietf.org/html/rfc3339).
        /// After this date the pre-authenticated request will no longer be valid.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeExpires is required.")]
        [JsonProperty(PropertyName = "timeExpires")]
        public System.Nullable<System.DateTime> TimeExpires { get; set; }
        
    }
}
