/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Fleet credential details.
    /// </summary>
    public class FleetCredentialEntitySpecificDetails : CredentialEntitySpecificDetails
    {
        
        /// <value>
        /// List of fleet credential variables.
        /// </value>
        [JsonProperty(PropertyName = "variables")]
        public System.Collections.Generic.List<Variable> Variables { get; set; }
        
        [JsonProperty(PropertyName = "credentialLevel")]
        private readonly string credentialLevel = "FLEET";
    }
}
