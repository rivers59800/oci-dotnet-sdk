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
    /// A virtual network interface card. Each VNIC resides in a subnet in a VCN.
    /// An instance attaches to a VNIC to obtain a network connection into the VCN
    /// through that subnet. Each instance has a *primary VNIC* that is automatically
    /// created and attached during launch. You can add *secondary VNICs* to an
    /// instance after it's launched. For more information, see
    /// [Virtual Network Interface Cards (VNICs)](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingVNICs.htm).
    /// <br/>
    /// Each VNIC has a *primary private IP* that is automatically assigned during launch.
    /// You can add *secondary private IPs* to a VNIC after it's created. For more
    /// information, see {@link #createPrivateIp(CreatePrivateIpRequest) createPrivateIp} and
    /// [IP Addresses](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingIPaddresses.htm).
    /// <br/>
    /// 
    /// If you are an Oracle Cloud VMware Solution customer, you will have secondary VNICs
    /// that reside in a VLAN instead of a subnet. These VNICs have other differences, which
    /// are called out in the descriptions of the relevant attributes in the `Vnic` object.
    /// Also see {@link Vlan}.
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// 
    /// </summary>
    public class Vnic 
    {
        
        /// <value>
        /// The VNIC's availability domain.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the compartment containing the VNIC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The hostname for the VNIC's primary private IP. Used for DNS. The value is the hostname
        /// portion of the primary private IP's fully qualified domain name (FQDN)
        /// (for example, `bminstance1` in FQDN `bminstance1.subnet123.vcn1.oraclevcn.com`).
        /// Must be unique across all VNICs in the subnet and comply with
        /// [RFC 952](https://tools.ietf.org/html/rfc952) and
        /// [RFC 1123](https://tools.ietf.org/html/rfc1123).
        /// <br/>
        /// For more information, see
        /// [DNS in Your Virtual Cloud Network](https://docs.cloud.oracle.com/iaas/Content/Network/Concepts/dns.htm).
        /// <br/>
        /// Example: bminstance1
        /// </value>
        [JsonProperty(PropertyName = "hostnameLabel")]
        public string HostnameLabel { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VNIC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Whether the VNIC is the primary VNIC (the VNIC that is automatically created
        /// and attached during instance launch).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isPrimary")]
        public System.Nullable<bool> IsPrimary { get; set; }
                ///
        /// <value>
        /// The current state of the VNIC.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated
        };

        /// <value>
        /// The current state of the VNIC.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The MAC address of the VNIC.
        /// <br/>
        /// If the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution,
        /// the MAC address is learned. If the VNIC belongs to a subnet, the
        /// MAC address is a static, Oracle-provided value.
        /// <br/>
        /// Example: 00:00:00:00:00:01
        /// </value>
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; set; }
        
        /// <value>
        /// A list of the OCIDs of the network security groups that the VNIC belongs to.
        /// <br/>
        /// If the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution (instead of
        /// belonging to a subnet), the value of the `nsgIds` attribute is ignored. Instead, the
        /// VNIC belongs to the NSGs that are associated with the VLAN itself. See {@link Vlan}.
        /// <br/>
        /// For more information about NSGs, see
        /// {@link NetworkSecurityGroup}.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// If the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution (instead of
        /// belonging to a subnet), the `vlanId` is the [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the VLAN the VNIC is in. See
        /// {@link Vlan}. If the VNIC is instead in a subnet, `subnetId` has a value.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vlanId")]
        public string VlanId { get; set; }
        
        /// <value>
        /// The private IP address of the primary `privateIp` object on the VNIC.
        /// The address is within the CIDR of the VNIC's subnet.
        /// <br/>
        /// Example: 10.0.3.3
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
        
        /// <value>
        /// The public IP address of the VNIC, if one is assigned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicIp")]
        public string PublicIp { get; set; }
        
        /// <value>
        /// Whether the source/destination check is disabled on the VNIC.
        /// Defaults to `false`, which means the check is performed. For information
        /// about why you would skip the source/destination check, see
        /// [Using a Private IP as a Route Target](https://docs.cloud.oracle.com/iaas/Content/Network/Tasks/managingroutetables.htm#privateip).
        /// <br/>
        /// 
        /// If the VNIC belongs to a VLAN as part of the Oracle Cloud VMware Solution (instead of
        /// belonging to a subnet), the `skipSourceDestCheck` attribute is `true`.
        /// This is because the source/destination check is always disabled for VNICs in a VLAN.
        /// <br/>
        /// Example: true
        /// </value>
        [JsonProperty(PropertyName = "skipSourceDestCheck")]
        public System.Nullable<bool> SkipSourceDestCheck { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the subnet the VNIC is in.
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The date and time the VNIC was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
