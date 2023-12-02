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


namespace Oci.OcvpService.Models
{
    /// <summary>
    /// Details of SDDC initial configuration
    /// </summary>
    public class InitialConfiguration 
    {
        
        /// <value>
        /// The configurations for Clusters initially created in the SDDC.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InitialClusterConfigurations is required.")]
        [JsonProperty(PropertyName = "initialClusterConfigurations")]
        public System.Collections.Generic.List<InitialClusterConfiguration> InitialClusterConfigurations { get; set; }
        
    }
}
