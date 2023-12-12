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


namespace Oci.PsqlService.Models
{
    /// <summary>
    /// Configuration for the PostgreSQL database instance.
    /// </summary>
    public class UpdateDbConfigParams 
    {
                ///
        /// <value>
        /// Whether a configuration update requires a restart of the database instance or a reload of the configuration.
        /// Some configuration changes require a restart of database instances to be applied.
        /// 
        /// </value>
        ///
        public enum ApplyConfigEnum {
            [EnumMember(Value = "RESTART")]
            Restart,
            [EnumMember(Value = "RELOAD")]
            Reload
        };

        /// <value>
        /// Whether a configuration update requires a restart of the database instance or a reload of the configuration.
        /// Some configuration changes require a restart of database instances to be applied.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "applyConfig")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ApplyConfigEnum> ApplyConfig { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the configuration.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ConfigId is required.")]
        [JsonProperty(PropertyName = "configId")]
        public string ConfigId { get; set; }
        
    }
}
