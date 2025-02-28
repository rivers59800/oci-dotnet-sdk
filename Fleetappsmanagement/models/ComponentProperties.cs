/*
 * Copyright (c) 2020, 2025, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// The properties of the component.
    /// </summary>
    public class ComponentProperties 
    {
        
        /// <value>
        /// The runOn condition for the task/group/container.
        /// Build task execution conditions if applicable to product and product-specific components.
        /// This condition is relevant when handling product stack workflows.
        /// Example: target.product.name = Oracle WebLogic Server OR target.product.name = Oracle HTTP Server
        /// </value>
        [JsonProperty(PropertyName = "runOn")]
        public string RunOn { get; set; }
        
        /// <value>
        /// Build control flow conditions that determine the relevance of the task execution.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }
                ///
        /// <value>
        /// The action to be taken in case of a failure.
        /// </value>
        ///
        public enum ActionOnFailureEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "ABORT")]
            Abort,
            [EnumMember(Value = "CONTINUE")]
            Continue,
            [EnumMember(Value = "ROLLBACK")]
            Rollback
        };

        /// <value>
        /// The action to be taken in case of a failure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActionOnFailure is required.")]
        [JsonProperty(PropertyName = "actionOnFailure")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ActionOnFailureEnum> ActionOnFailure { get; set; }
        
        [JsonProperty(PropertyName = "pauseDetails")]
        public PauseDetails PauseDetails { get; set; }
        
        [JsonProperty(PropertyName = "notificationPreferences")]
        public TaskNotificationPreferences NotificationPreferences { get; set; }
        
    }
}
