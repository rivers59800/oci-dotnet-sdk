/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DnsService.Models
{
    
    public class SteeringPolicyHealthRuleCase 
    {
        
        /// <value>
        /// An expression that uses conditions at the time of a DNS query to indicate
        /// whether a case matches. Conditions may include the geographical location, IP
        /// subnet, or ASN the DNS query originated. **Example: ** If you have anoffice that uses the subnet 192.0.2.0/24 you could use a caseConditionexpression query.client.address in ('192.0.2.0/24') to define a case thatmatches queries from that office.
        /// </value>
        [JsonProperty(PropertyName = "caseCondition")]
        public string CaseCondition { get; set; }
        
    }
}
