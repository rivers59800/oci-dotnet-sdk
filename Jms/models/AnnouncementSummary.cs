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
    /// A summary of a announcement on Console Overview page
    /// </summary>
    public class AnnouncementSummary 
    {
        
        /// <value>
        /// Unique id of the announcement
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Key is required.")]
        [JsonProperty(PropertyName = "key")]
        public System.Nullable<int> Key { get; set; }
        
        /// <value>
        /// Summary text of the announcement
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Summary is required.")]
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// URL to the announcement web page
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Url is required.")]
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// Date time on which the announcement was released
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeReleased is required.")]
        [JsonProperty(PropertyName = "timeReleased")]
        public System.Nullable<System.DateTime> TimeReleased { get; set; }
        
    }
}
