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


namespace Oci.DisasterrecoveryService.Models
{
    /// <summary>
    /// The properties for a Base Database or Exadata Database member of a DR protection group.
    /// 
    /// </summary>
    public class DrProtectionGroupMemberDatabase : DrProtectionGroupMember
    {
        
        /// <value>
        /// The OCID of the vault secret where the database SYSDBA password is stored.
        /// This password is used for performing database DR operations.
        /// <br/>
        /// Example: ocid1.vaultsecret.oc1..uniqueID
        /// </value>
        [JsonProperty(PropertyName = "passwordVaultSecretId")]
        public string PasswordVaultSecretId { get; set; }
        
        [JsonProperty(PropertyName = "memberType")]
        private readonly string memberType = "DATABASE";
    }
}
