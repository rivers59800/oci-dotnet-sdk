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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// An export settings for JMS fleets.
    /// 
    /// </summary>
    public class ExportSetting 
    {
        
        /// <value>
        /// The internal identifier of the export setting.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportSettingKey")]
        public string ExportSettingKey { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the fleet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "fleetId")]
        public string FleetId { get; set; }
        
        /// <value>
        /// The duration of data to be exported for fleets.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportDuration")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExportDuration> ExportDuration { get; set; }
        
        /// <value>
        /// Resource to export data associated from the fleets.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportResources")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExportResources> ExportResources { get; set; }
        
        /// <value>
        /// Acknowledgement for cross region target bucket configuration.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCrossRegionAcknowledged")]
        public System.Nullable<bool> IsCrossRegionAcknowledged { get; set; }
        
        /// <value>
        /// The name of the bucket where data will be exported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetBucketName")]
        public string TargetBucketName { get; set; }
        
        /// <value>
        /// The namespace of the bucket where data will be exported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetBucketNamespace")]
        public string TargetBucketNamespace { get; set; }
        
        /// <value>
        /// The namespace of the bucket where data will be exported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetBucketRegion")]
        public string TargetBucketRegion { get; set; }
        
        /// <value>
        /// Schedule at which data will be exported.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "exportFrequency")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExportFrequency> ExportFrequency { get; set; }
        
        /// <value>
        /// ExportSetting flag to store enabled or disabled status.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IsEnabled is required.")]
        [JsonProperty(PropertyName = "isEnabled")]
        public System.Nullable<bool> IsEnabled { get; set; }
        
        /// <value>
        /// The creation date and time of the export setting (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The update date and time of the export setting (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastModified")]
        public System.Nullable<System.DateTime> TimeLastModified { get; set; }
        
    }
}
