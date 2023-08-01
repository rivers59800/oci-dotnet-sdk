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
    /// Fifty-Fifty batching strategy details to use during PRECHECK and APPLY Cycle Actions.
    /// 
    /// </summary>
    public class UpdateFiftyFiftyBatchingStrategyDetails : UpdateBatchingStrategyDetails
    {
        
        /// <value>
        /// True to wait for customer to resume the Apply Action once the first half is done.
        /// False to automatically patch the second half.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isWaitForBatchResume")]
        public System.Nullable<bool> IsWaitForBatchResume { get; set; }
        
        /// <value>
        /// True to force rolling patching.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isForceRolling")]
        public System.Nullable<bool> IsForceRolling { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "FIFTY_FIFTY";
    }
}
