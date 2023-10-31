/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// The lifecycle states of a DR protection group.
    /// - CREATING - DR protection group is being created.
    /// - ACTIVE - DR protection group is active and available for operations.
    /// - UPDATING - DR protection group is being updated and is not available for operations.
    /// - INACTIVE - The DR protection group is locked because a DR drill is in progress.
    /// - NEEDS_ATTENTION - DR protection group needs user attention.
    /// - DELETING - DR protection group is being deleted.
    /// - DELETED - DR protection group has been deleted.
    /// - FAILED - DR protection group is in a failed state.
    /// 
  /// </summary>
  public enum DrProtectionGroupLifecycleState {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATING")]
      Creating,
      [EnumMember(Value = "ACTIVE")]
      Active,
      [EnumMember(Value = "UPDATING")]
      Updating,
      [EnumMember(Value = "INACTIVE")]
      Inactive,
      [EnumMember(Value = "NEEDS_ATTENTION")]
      NeedsAttention,
      [EnumMember(Value = "DELETING")]
      Deleting,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "FAILED")]
      Failed
  }
}
