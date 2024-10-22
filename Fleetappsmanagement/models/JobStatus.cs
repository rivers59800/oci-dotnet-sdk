/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.FleetappsmanagementService.Models
{
  /// <summary>
  /// Possible Job status.
  /// </summary>
  public enum JobStatus {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "ACCEPTED")]
      Accepted,
      [EnumMember(Value = "WAITING")]
      Waiting,
      [EnumMember(Value = "IN_PROGRESS")]
      InProgress,
      [EnumMember(Value = "FAILED")]
      Failed,
      [EnumMember(Value = "SUCCEEDED")]
      Succeeded,
      [EnumMember(Value = "CANCELED")]
      Canceled,
      [EnumMember(Value = "SKIPPED")]
      Skipped,
      [EnumMember(Value = "IGNORED")]
      Ignored,
      [EnumMember(Value = "NOT_APPLICABLE")]
      NotApplicable,
      [EnumMember(Value = "ABORTED")]
      Aborted,
      [EnumMember(Value = "TIMED_OUT")]
      TimedOut,
      [EnumMember(Value = "PAUSED")]
      Paused
  }
}
