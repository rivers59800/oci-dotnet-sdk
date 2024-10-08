/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.StackmonitoringService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "CREATE_RESOURCES")]
      CreateResources,
      [EnumMember(Value = "UPDATE_RESOURCES")]
      UpdateResources,
      [EnumMember(Value = "DELETE_RESOURCES")]
      DeleteResources,
      [EnumMember(Value = "MOVE_RESOURCES")]
      MoveResources,
      [EnumMember(Value = "ENABLE_EXTERNAL_DATABASE")]
      EnableExternalDatabase,
      [EnumMember(Value = "DISABLE_EXTERNAL_DATABASE")]
      DisableExternalDatabase,
      [EnumMember(Value = "ADD_SOURCES_TO_AGENT")]
      AddSourcesToAgent,
      [EnumMember(Value = "ENABLE_METRIC_EXTENSION")]
      EnableMetricExtension,
      [EnumMember(Value = "DISABLE_METRIC_EXTENSION")]
      DisableMetricExtension,
      [EnumMember(Value = "TEST_METRIC_EXTENSION")]
      TestMetricExtension,
      [EnumMember(Value = "BULK_ADD_RESOURCES")]
      BulkAddResources,
      [EnumMember(Value = "BULK_DELETE_RESOURCES")]
      BulkDeleteResources,
      [EnumMember(Value = "UPDATE_AND_PROPAGATE_TAGS")]
      UpdateAndPropagateTags,
      [EnumMember(Value = "IMPORT_RESOURCES")]
      ImportResources,
      [EnumMember(Value = "CREATE_MAINTENANCE_WINDOW")]
      CreateMaintenanceWindow,
      [EnumMember(Value = "UPDATE_MAINTENANCE_WINDOW")]
      UpdateMaintenanceWindow,
      [EnumMember(Value = "DELETE_MAINTENANCE_WINDOW")]
      DeleteMaintenanceWindow,
      [EnumMember(Value = "STOP_MAINTENANCE_WINDOW")]
      StopMaintenanceWindow
  }
}
