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


namespace Oci.QueueService.Models
{
    /// <summary>
    /// A list of the messages published to a queue.
    /// </summary>
    public class PutMessages 
    {
        
        /// <value>
        /// The messages that have been published to a queue.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Messages is required.")]
        [JsonProperty(PropertyName = "messages")]
        public System.Collections.Generic.List<PutMessage> Messages { get; set; }
        
    }
}
