/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FusionappsService.Models
{
    /// <summary>
    /// Quarterly upgrade details.
    /// </summary>
    public class UpgradeAction : Action
    {
        
        /// <value>
        /// name of the repo
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// month qualifier
        /// </value>
        [JsonProperty(PropertyName = "qualifier")]
        public string Qualifier { get; set; }
        
        [JsonProperty(PropertyName = "actionType")]
        private readonly string actionType = "QUARTERLY_UPGRADE";
    }
}
