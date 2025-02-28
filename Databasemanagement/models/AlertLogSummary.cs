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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The detail for one alert log entry.
    /// 
    /// </summary>
    public class AlertLogSummary 
    {
                ///
        /// <value>
        /// The level of the alert log.
        /// </value>
        ///
        public enum MessageLevelEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CRITICAL")]
            Critical,
            [EnumMember(Value = "SEVERE")]
            Severe,
            [EnumMember(Value = "IMPORTANT")]
            Important,
            [EnumMember(Value = "NORMAL")]
            Normal
        };

        /// <value>
        /// The level of the alert log.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessageLevel is required.")]
        [JsonProperty(PropertyName = "messageLevel")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MessageLevelEnum> MessageLevel { get; set; }
                ///
        /// <value>
        /// The type of alert log message.
        /// </value>
        ///
        public enum MessageTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "UNKNOWN")]
            Unknown,
            [EnumMember(Value = "INCIDENT_ERROR")]
            IncidentError,
            [EnumMember(Value = "ERROR")]
            Error,
            [EnumMember(Value = "WARNING")]
            Warning,
            [EnumMember(Value = "NOTIFICATION")]
            Notification,
            [EnumMember(Value = "TRACE")]
            Trace
        };

        /// <value>
        /// The type of alert log message.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MessageType is required.")]
        [JsonProperty(PropertyName = "messageType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<MessageTypeEnum> MessageType { get; set; }
        
        /// <value>
        /// The contents of the alert log message.
        /// </value>
        [JsonProperty(PropertyName = "messageContent")]
        public string MessageContent { get; set; }
        
        /// <value>
        /// The date and time the alert log was created.
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// The supplemental details of the alert log.
        /// </value>
        [JsonProperty(PropertyName = "supplementalDetail")]
        public string SupplementalDetail { get; set; }
        
        /// <value>
        /// The alert log file location.
        /// </value>
        [JsonProperty(PropertyName = "fileLocation")]
        public string FileLocation { get; set; }
        
    }
}
