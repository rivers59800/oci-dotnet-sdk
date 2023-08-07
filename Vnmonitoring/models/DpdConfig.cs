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


namespace Oci.VnmonitoringService.Models
{
    /// <summary>
    /// These configuration details are used for dead peer detection (DPD). DPD periodically checks the stability of the connection to the customer premises (CPE), and may be used to detect that the link to the CPE has gone down.
    /// 
    /// </summary>
    public class DpdConfig 
    {
                ///
        /// <value>
        /// This option defines whether DPD can be initiated from the Oracle side of the connection.
        /// 
        /// </value>
        ///
        public enum DpdModeEnum {
            [EnumMember(Value = "INITIATE_AND_RESPOND")]
            InitiateAndRespond,
            [EnumMember(Value = "RESPOND_ONLY")]
            RespondOnly
        };

        /// <value>
        /// This option defines whether DPD can be initiated from the Oracle side of the connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dpdMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DpdModeEnum> DpdMode { get; set; }
        
        /// <value>
        /// DPD timeout in seconds. This sets the longest interval between CPE device health messages before the IPSec connection indicates it has lost contact with the CPE. The default is 20 seconds.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dpdTimeoutInSec")]
        public System.Nullable<int> DpdTimeoutInSec { get; set; }
        
    }
}
