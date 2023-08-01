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
    /// Service Availability Factor batching strategy details to use during PRECHECK and APPLY Cycle Actions.
    /// 
    /// </summary>
    public class CreateServiceAvailabilityFactorBatchingStrategyDetails : CreateBatchingStrategyDetails
    {
        
        /// <value>
        /// Percentage of availability in the service during the Patch operation.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "percentage")]
        public System.Nullable<int> Percentage { get; set; }
        
        /// <value>
        /// True to force rolling patching.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isForceRolling")]
        public System.Nullable<bool> IsForceRolling { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "SERVICE_AVAILABILITY_FACTOR";
    }
}
