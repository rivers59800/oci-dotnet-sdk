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
    /// The list of one or more BYOIPv6 CIDR blocks for the VCN that meets the following criteria:
    /// - The CIDR must from a BYOIPv6 range.
    /// - The IPv6 CIDR blocks must be valid.
    /// - Multiple CIDR blocks must not overlap each other or the on-premises network CIDR block.
    /// - The number of CIDR blocks must not exceed the limit of IPv6 CIDR blocks allowed to a VCN.
    /// 
    /// </summary>
    public class Byoipv6CidrDetails 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the `ByoipRange` resource to which the CIDR block belongs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Byoipv6RangeId is required.")]
        [JsonProperty(PropertyName = "byoipv6RangeId")]
        public string Byoipv6RangeId { get; set; }
        
        /// <value>
        /// An IPv6 CIDR block required to create a VCN with a BYOIP prefix. It could be the whole CIDR block identified in `byoipv6RangeId`, or a subrange.
        /// Example: 2001:0db8:0123::/48
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ipv6CidrBlock is required.")]
        [JsonProperty(PropertyName = "ipv6CidrBlock")]
        public string Ipv6CidrBlock { get; set; }
        
    }
}
