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
  /// The execution statuses for a DR plan step.
    /// - QUEUED - DR plan step execution has been queued.
    /// - DISABLED - DR plan step execution has been disabled.
    /// - IN_PROGRESS - DR plan step execution is in progress.
    /// - SUCCEEDED - DR plan step execution has succeeded.
    /// - FAILED - DR plan step execution has failed.
    /// - FAILED_IGNORED - DR plan step execution has failed, but was ignored.
    /// - TIMED_OUT - DR plan step execution has timed out.
    /// - TIMED_OUT_IGNORED - DR plan step execution has timed out, but was ignored.
    /// - PAUSED - DR plan step execution has paused.
    /// - CANCELED - DR plan step execution has been canceled.
    /// 
  /// </summary>
  public enum DrPlanStepExecutionStatus {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "QUEUED")]
      Queued,
      [EnumMember(Value = "DISABLED")]
      Disabled,
      [EnumMember(Value = "IN_PROGRESS")]
      InProgress,
      [EnumMember(Value = "SUCCEEDED")]
      Succeeded,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "FAILED_IGNORED")]
      FailedIgnored,
      [EnumMember(Value = "TIMED_OUT")]
      TimedOut,
      [EnumMember(Value = "TIMED_OUT_IGNORED")]
      TimedOutIgnored,
      [EnumMember(Value = "PAUSED")]
      Paused,
      [EnumMember(Value = "CANCELED")]
      Canceled
  }
}
