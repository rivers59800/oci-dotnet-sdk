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


namespace Oci.FleetsoftwareupdateService.Models
{
    /// <summary>
    /// Details of the next Exadata Fleet Update Action to execute in a Maintenance Cycle.
    /// 
    /// </summary>
    public class NextActionToExecuteDetails 
    {
        
        /// <value>
        /// Type of Exadata Fleet Update Action
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<DetailedActionTypes> Type { get; set; }
        
        /// <value>
        /// The date and time the Exadata Fleet Update Action is expected to start. Null if no Action has been scheduled.
        /// [RFC 3339](https://tools.ietf.org/rfc/rfc3339), section 14.29.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeToStart")]
        public System.Nullable<System.DateTime> TimeToStart { get; set; }
        
    }
}
