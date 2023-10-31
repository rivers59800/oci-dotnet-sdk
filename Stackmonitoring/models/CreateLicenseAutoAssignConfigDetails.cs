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


namespace Oci.StackmonitoringService.Models
{
    /// <summary>
    /// The details of a LICENSE_AUTO_ASSIGN configuration.
    /// 
    /// </summary>
    public class CreateLicenseAutoAssignConfigDetails : CreateConfigDetails
    {
        
        /// <value>
        /// License edition.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "License is required.")]
        [JsonProperty(PropertyName = "license")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseType> License { get; set; }
        
        [JsonProperty(PropertyName = "configType")]
        private readonly string configType = "LICENSE_AUTO_ASSIGN";
    }
}
