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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// Defines the maintenance configuration for update operation.
    /// 
    /// </summary>
    public class UpdateMaintenanceConfigurationDetails 
    {
        
        /// <value>
        /// By default auto upgrade for interim releases are not enabled. If auto-upgrade is enabled for interim release, 
        /// you have to specify interimReleaseUpgradePeriodInDays too.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isInterimReleaseAutoUpgradeEnabled")]
        public System.Nullable<bool> IsInterimReleaseAutoUpgradeEnabled { get; set; }
        
        /// <value>
        /// Defines auto upgrade period for interim releases. This period must be shorter or equal to bundle release upgrade period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "interimReleaseUpgradePeriodInDays")]
        public System.Nullable<int> InterimReleaseUpgradePeriodInDays { get; set; }
        
        /// <value>
        /// Defines auto upgrade period for bundle releases. Manually configured period cannot be longer than service defined period for bundle releases.
        /// This period must be shorter or equal to major release upgrade period. Not passing this field during create will equate to using the service default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bundleReleaseUpgradePeriodInDays")]
        public System.Nullable<int> BundleReleaseUpgradePeriodInDays { get; set; }
        
        /// <value>
        /// Defines auto upgrade period for major releases. Manually configured period cannot be longer than service defined period for major releases.
        /// Not passing this field during create will equate to using the service default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "majorReleaseUpgradePeriodInDays")]
        public System.Nullable<int> MajorReleaseUpgradePeriodInDays { get; set; }
        
        /// <value>
        /// Defines auto upgrade period for releases with security fix. Manually configured period cannot be longer than service defined period for security releases.
        /// Not passing this field during create will equate to using the service default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "securityPatchUpgradePeriodInDays")]
        public System.Nullable<int> SecurityPatchUpgradePeriodInDays { get; set; }
        
    }
}
