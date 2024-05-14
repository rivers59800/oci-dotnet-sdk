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
    /// Description of Offer.
    /// </summary>
    public class Offer 
    {
        
        /// <value>
        /// Unique identifier that is immutable on creation
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Offer Identifier, can be renamed
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// OCID of the seller's tenancy (root compartment).
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SellerCompartmentId is required.")]
        [JsonProperty(PropertyName = "sellerCompartmentId")]
        public string SellerCompartmentId { get; set; }
        
        /// <value>
        /// OCID of the buyer's tenancy (root compartment).
        /// </value>
        [JsonProperty(PropertyName = "buyerCompartmentId")]
        public string BuyerCompartmentId { get; set; }
        
        /// <value>
        /// The description of the offer
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The time the Offer will become active after it has been accepted by the Buyer. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeStartDate")]
        public System.Nullable<System.DateTime> TimeStartDate { get; set; }
        
        /// <value>
        /// Duration the Offer will be active after its start date. An ISO8601 extended formatted string.
        /// </value>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        
        /// <value>
        /// The time the the Offer was created. An RFC3339 formatted datetime string
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The time the Offer was updated. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
        /// <value>
        /// The time the Offer must be accepted by the Buyer before the Offer becomes invalid. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeAcceptBy")]
        public System.Nullable<System.DateTime> TimeAcceptBy { get; set; }
        
        /// <value>
        /// The time the Offer was accepted by the Buyer of the Offer. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeAccepted")]
        public System.Nullable<System.DateTime> TimeAccepted { get; set; }
        
        /// <value>
        /// The time the accepted Offer will end. An RFC3339 formatted datetime string
        /// </value>
        [JsonProperty(PropertyName = "timeOfferEnd")]
        public System.Nullable<System.DateTime> TimeOfferEnd { get; set; }
                ///
        /// <value>
        /// The current state of the Offer.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CREATING")]
            Creating,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "DELETING")]
            Deleting,
            [EnumMember(Value = "DELETED")]
            Deleted,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// The current state of the Offer.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// A message describing the current state in more detail. For example, can be used to provide actionable information for a resource in Failed state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
                ///
        /// <value>
        /// A substate for lifeCycleStatus to give a more human readable version of the offer
        /// </value>
        ///
        public enum OfferStatusEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DRAFT")]
            Draft,
            [EnumMember(Value = "PENDING_MARKETPLACE")]
            PendingMarketplace,
            [EnumMember(Value = "PENDING_BUYER")]
            PendingBuyer,
            [EnumMember(Value = "EXPIRED")]
            Expired,
            [EnumMember(Value = "ACCEPTED")]
            Accepted,
            [EnumMember(Value = "ACTIVE")]
            Active,
            [EnumMember(Value = "ENDED")]
            Ended,
            [EnumMember(Value = "FAILED_SEND")]
            FailedSend,
            [EnumMember(Value = "FAILED_ACCEPT")]
            FailedAccept
        };

        /// <value>
        /// A substate for lifeCycleStatus to give a more human readable version of the offer
        /// </value>
        [JsonProperty(PropertyName = "offerStatus")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OfferStatusEnum> OfferStatus { get; set; }
        
        [JsonProperty(PropertyName = "publisherSummary")]
        public PublisherSummary PublisherSummary { get; set; }
        
        [JsonProperty(PropertyName = "pricing")]
        public Pricing Pricing { get; set; }
        
        [JsonProperty(PropertyName = "buyerInformation")]
        public BuyerInformation BuyerInformation { get; set; }
        
        [JsonProperty(PropertyName = "sellerInformation")]
        public SellerInformation SellerInformation { get; set; }
        
        /// <value>
        /// A list of Resource Bundles associated with an Offer.
        /// </value>
        [JsonProperty(PropertyName = "resourceBundles")]
        public System.Collections.Generic.List<ResourceBundle> ResourceBundles { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "FreeformTags is required.")]
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DefinedTags is required.")]
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
