/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.BdsService.Models
{
  /// <summary>
  /// Possible operation types.
  /// </summary>
  public enum OperationTypes {
      [EnumMember(Value = "CREATE_BDS")]
      CreateBds,
      [EnumMember(Value = "UPDATE_BDS")]
      UpdateBds,
      [EnumMember(Value = "DELETE_BDS")]
      DeleteBds,
      [EnumMember(Value = "ADD_BLOCK_STORAGE")]
      AddBlockStorage,
      [EnumMember(Value = "ADD_WORKER_NODES")]
      AddWorkerNodes,
      [EnumMember(Value = "ADD_CLOUD_SQL")]
      AddCloudSql,
      [EnumMember(Value = "REMOVE_CLOUD_SQL")]
      RemoveCloudSql,
      [EnumMember(Value = "CHANGE_COMPARTMENT_FOR_BDS")]
      ChangeCompartmentForBds,
      [EnumMember(Value = "CHANGE_SHAPE")]
      ChangeShape,
      [EnumMember(Value = "UPDATE_INFRA")]
      UpdateInfra,
      [EnumMember(Value = "RESTART_NODE")]
      RestartNode,
      [EnumMember(Value = "AUTOSCALE_CONFIG")]
      AutoscaleConfig,
      [EnumMember(Value = "AUTOSCALE_RUN")]
      AutoscaleRun,
      [EnumMember(Value = "CREATE_API_KEY")]
      CreateApiKey,
      [EnumMember(Value = "DELETE_API_KEY")]
      DeleteApiKey,
      [EnumMember(Value = "TEST_OBJECT_STORE_CONNECTION")]
      TestObjectStoreConnection,
      [EnumMember(Value = "CREATE_METASTORE_CONFIG")]
      CreateMetastoreConfig,
      [EnumMember(Value = "DELETE_METASTORE_CONFIG")]
      DeleteMetastoreConfig,
      [EnumMember(Value = "UPDATE_METASTORE_CONFIG")]
      UpdateMetastoreConfig,
      [EnumMember(Value = "ACTIVATE_METASTORE_CONFIG")]
      ActivateMetastoreConfig,
      [EnumMember(Value = "TEST_METASTORE_CONFIG")]
      TestMetastoreConfig
  }
}
