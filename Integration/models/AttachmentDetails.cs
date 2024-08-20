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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// Description of an attachments for this instance
    /// </summary>
    public class AttachmentDetails 
    {
                ///
        /// <value>
        /// The role of the target attachment.
        ///    * `PARENT` - The target instance is the parent of this attachment.
        ///    * `CHILD` - The target instance is the child of this attachment.
        /// 
        /// </value>
        ///
        public enum TargetRoleEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PARENT")]
            Parent,
            [EnumMember(Value = "CHILD")]
            Child
        };

        /// <value>
        /// The role of the target attachment.
        ///    * `PARENT` - The target instance is the parent of this attachment.
        ///    * `CHILD` - The target instance is the child of this attachment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetRole is required.")]
        [JsonProperty(PropertyName = "targetRole")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<TargetRoleEnum> TargetRole { get; set; }
        
        /// <value>
        /// * If role == `PARENT`, the attached instance was created by this service instance
        /// * If role == `CHILD`, this instance was created from attached instance on behalf of a user
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsImplicit is required.")]
        [JsonProperty(PropertyName = "isImplicit")]
        public System.Nullable<bool> IsImplicit { get; set; }
        
        /// <value>
        /// The OCID of the target instance (which could be any other OCI PaaS/SaaS resource), to which this instance is attached.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetId is required.")]
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The dataplane instance URL of the attached instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetInstanceUrl is required.")]
        [JsonProperty(PropertyName = "targetInstanceUrl")]
        public string TargetInstanceUrl { get; set; }
        
        /// <value>
        /// The type of the target instance, such as \"FUSION\".
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TargetServiceType is required.")]
        [JsonProperty(PropertyName = "targetServiceType")]
        public string TargetServiceType { get; set; }
        
    }
}
