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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// The summary of information about the user profiles. It includes details such as profile name, failed login attempts,
    /// sessions per user, inactive account time, password lock time, user created, target id, and the compartment id.
    /// 
    /// </summary>
    public class ProfileSummary 
    {
        
        /// <value>
        /// The OCID of the latest user assessment corresponding to the target under consideration. A compartment 
        /// type assessment can also be passed to profiles from all the targets from the corresponding compartment.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UserAssessmentId is required.")]
        [JsonProperty(PropertyName = "userAssessmentId")]
        public string UserAssessmentId { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the user assessment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The OCID of the target database.
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// The name of the profile.
        /// </value>
        [JsonProperty(PropertyName = "profileName")]
        public string ProfileName { get; set; }
        
        /// <value>
        /// The number of users having a given profile.
        /// </value>
        [JsonProperty(PropertyName = "userCount")]
        public System.Nullable<int> UserCount { get; set; }
        
        /// <value>
        /// Maximum times the user is allowed to fail login before the user account is locked.
        /// </value>
        [JsonProperty(PropertyName = "failedLoginAttempts")]
        public string FailedLoginAttempts { get; set; }
        
        /// <value>
        /// PL/SQL that can be used for password verification.
        /// </value>
        [JsonProperty(PropertyName = "passwordVerificationFunction")]
        public string PasswordVerificationFunction { get; set; }
        
        /// <value>
        /// The maximum number of sessions a user is allowed to create.
        /// </value>
        [JsonProperty(PropertyName = "sessionsPerUser")]
        public string SessionsPerUser { get; set; }
        
        /// <value>
        /// The permitted periods of continuous inactive time during a session, expressed in minutes.
        /// Long-running queries and other operations are not subjected to this limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "inactiveAccountTime")]
        public string InactiveAccountTime { get; set; }
        
        /// <value>
        /// Number of days the user account remains locked after failed login
        /// </value>
        [JsonProperty(PropertyName = "passwordLockTime")]
        public string PasswordLockTime { get; set; }
        
        /// <value>
        /// Represents if the profile is created by user.
        /// </value>
        [JsonProperty(PropertyName = "isUserCreated")]
        public System.Nullable<bool> IsUserCreated { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm)
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
