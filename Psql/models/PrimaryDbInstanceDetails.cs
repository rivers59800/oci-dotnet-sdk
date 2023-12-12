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
    /// The primary database instance node details.
    /// </summary>
    public class PrimaryDbInstanceDetails 
    {
        
        /// <value>
        /// A unique identifier for the primary database instance node.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbInstanceId is required.")]
        [JsonProperty(PropertyName = "dbInstanceId")]
        public string DbInstanceId { get; set; }
        
    }
}
