/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.CloudguardService.Models
{
  /// <summary>
  /// Type of information in the managed list.
  /// </summary>
  public enum ManagedListType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CIDR_BLOCK")]
      CidrBlock,
      [EnumMember(Value = "USERS")]
      Users,
      [EnumMember(Value = "GROUPS")]
      Groups,
      [EnumMember(Value = "IPV4ADDRESS")]
      Ipv4Address,
      [EnumMember(Value = "IPV6ADDRESS")]
      Ipv6Address,
      [EnumMember(Value = "RESOURCE_OCID")]
      ResourceOcid,
      [EnumMember(Value = "REGION")]
      Region,
      [EnumMember(Value = "COUNTRY")]
      Country,
      [EnumMember(Value = "STATE")]
      State,
      [EnumMember(Value = "CITY")]
      City,
      [EnumMember(Value = "TAGS")]
      Tags,
      [EnumMember(Value = "GENERIC")]
      Generic,
      [EnumMember(Value = "FUSION_APPS_ROLE")]
      FusionAppsRole,
      [EnumMember(Value = "FUSION_APPS_PERMISSION")]
      FusionAppsPermission
  }
}
