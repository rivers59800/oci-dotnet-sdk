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


namespace Oci.IntegrationService.Models
{
    /// <summary>
    /// Information for IDCS access
    /// </summary>
    public class IdcsInfoDetails 
    {
        
        /// <value>
        /// URL for the location of the IDCS Application (used by IDCS APIs)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsAppLocationUrl is required.")]
        [JsonProperty(PropertyName = "idcsAppLocationUrl")]
        public string IdcsAppLocationUrl { get; set; }
        
        /// <value>
        /// The IDCS application display name associated with the instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsAppDisplayName is required.")]
        [JsonProperty(PropertyName = "idcsAppDisplayName")]
        public string IdcsAppDisplayName { get; set; }
        
        /// <value>
        /// The IDCS application ID associated with the instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsAppId is required.")]
        [JsonProperty(PropertyName = "idcsAppId")]
        public string IdcsAppId { get; set; }
        
        /// <value>
        /// The IDCS application name associated with the instance
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IdcsAppName is required.")]
        [JsonProperty(PropertyName = "idcsAppName")]
        public string IdcsAppName { get; set; }
        
        /// <value>
        /// The URL used as the primary audience for integration flows in this instance
        /// type: string   
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstancePrimaryAudienceUrl is required.")]
        [JsonProperty(PropertyName = "instancePrimaryAudienceUrl")]
        public string InstancePrimaryAudienceUrl { get; set; }
        
    }
}
