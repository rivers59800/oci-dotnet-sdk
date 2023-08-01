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
    /// List of Compartments to include in the discovery.
    /// 
    /// </summary>
    public class GiCompartmentIdFilter : GiFleetDiscoveryFilter
    {
        
        /// <value>
        /// List of Compartments OCIDs to include in the discovery.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Identifiers is required.")]
        [JsonProperty(PropertyName = "identifiers")]
        public System.Collections.Generic.List<string> Identifiers { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "COMPARTMENT_ID";
    }
}
