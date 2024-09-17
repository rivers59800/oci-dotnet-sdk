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


namespace Oci.LockboxService.Models
{
    /// <summary>
    /// An access request to a customer's resource.
    /// An access request is a subsidiary resource of the Lockbox entity.
    /// 
    /// </summary>
    public class AccessRequest 
    {
        
        /// <value>
        /// The unique identifier (OCID) of the access request, which can't be changed after creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The unique identifier (OCID) of the lockbox box that the access request is associated with, which can't be changed after creation.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LockboxId is required.")]
        [JsonProperty(PropertyName = "lockboxId")]
        public string LockboxId { get; set; }
        
        /// <value>
        /// The name of the access request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The rationale for requesting the access request and any other related details..
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Description is required.")]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The unique identifier of the requestor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestorId is required.")]
        [JsonProperty(PropertyName = "requestorId")]
        public string RequestorId { get; set; }
                ///
        /// <value>
        /// Possible access request lifecycle states.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            [EnumMember(Value = "WAITING")]
            Waiting,
            [EnumMember(Value = "SUCCEEDED")]
            Succeeded,
            [EnumMember(Value = "CANCELING")]
            Canceling,
            [EnumMember(Value = "CANCELED")]
            Canceled,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Possible access request lifecycle states.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
                ///
        /// <value>
        /// Details of access request lifecycle state.
        /// </value>
        ///
        public enum LifecycleStateDetailsEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROCESSING")]
            Processing,
            [EnumMember(Value = "WAITING_FOR_APPROVALS")]
            WaitingForApprovals,
            [EnumMember(Value = "APPROVED")]
            Approved,
            [EnumMember(Value = "AUTO_APPROVED")]
            AutoApproved,
            [EnumMember(Value = "CANCELLING_ACCESS")]
            CancellingAccess,
            [EnumMember(Value = "EXPIRED")]
            Expired,
            [EnumMember(Value = "REVOKED")]
            Revoked,
            [EnumMember(Value = "DENIED")]
            Denied,
            [EnumMember(Value = "ERROR")]
            Error
        };

        /// <value>
        /// Details of access request lifecycle state.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleStateDetails is required.")]
        [JsonProperty(PropertyName = "lifecycleStateDetails")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateDetailsEnum> LifecycleStateDetails { get; set; }
        
        /// <value>
        /// The maximum amount of time operator has access to associated resources.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AccessDuration is required.")]
        [JsonProperty(PropertyName = "accessDuration")]
        public string AccessDuration { get; set; }
        
        /// <value>
        /// The context object containing the access request specific details.
        /// </value>
        [JsonProperty(PropertyName = "context")]
        public System.Collections.Generic.Dictionary<string, string> Context { get; set; }
        
        /// <value>
        /// The actions taken by different persona on the access request, e.g. approve/deny/revoke
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ActivityLogs is required.")]
        [JsonProperty(PropertyName = "activityLogs")]
        public System.Collections.Generic.List<ActivityLog> ActivityLogs { get; set; }
        
        /// <value>
        /// The time the access request was created. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the access request was last updated. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeUpdated is required.")]
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time the access request expired. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeExpired is required.")]
        [JsonProperty(PropertyName = "timeExpired")]
        public System.Nullable<System.DateTime> TimeExpired { get; set; }
        
        /// <value>
        /// The time the access request was last reminded. Format is defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// Example: 2020-01-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeReminded is required.")]
        [JsonProperty(PropertyName = "timeReminded")]
        public System.Nullable<System.DateTime> TimeReminded { get; set; }
        
        /// <value>
        /// The count of times the access request was reminded.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReminderCount is required.")]
        [JsonProperty(PropertyName = "reminderCount")]
        public System.Nullable<int> ReminderCount { get; set; }
        
        /// <value>
        /// The location of the requestor. Format with be two letters indicatiog operator's country code defined by https://jira-sd.mc1.oracleiaas.com/browse/SSD-17880
        /// Example: US
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RequestorLocation is required.")]
        [JsonProperty(PropertyName = "requestorLocation")]
        public string RequestorLocation { get; set; }
        
        /// <value>
        /// The ticket number raised by external customers 
        /// Example: 3-37509643121
        /// </value>
        [JsonProperty(PropertyName = "ticketNumber")]
        public string TicketNumber { get; set; }
        
    }
}
