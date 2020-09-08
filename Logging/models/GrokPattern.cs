/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.LoggingService.Models
{
    /// <summary>
    /// grok pattern object
    /// </summary>
    public class GrokPattern 
    {
        
        /// <value>
        /// The grok pattern
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Pattern is required.")]
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <value>
        /// The name key to tag this grok pattern
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <value>
        /// Specify time field for event time. If the event doesn't have this field, current time is used.
        /// </value>
        [JsonProperty(PropertyName = "fieldTimeKey")]
        public string FieldTimeKey { get; set; }

        /// <value>
        /// Process value using specified format. This is available only when time_type is string.
        /// </value>
        [JsonProperty(PropertyName = "fieldTimeFormat")]
        public string FieldTimeFormat { get; set; }

        /// <value>
        /// Use specified timezone. One can parse/format the time value in the specified timezone.
        /// </value>
        [JsonProperty(PropertyName = "fieldTimeZone")]
        public string FieldTimeZone { get; set; }
    }
}
