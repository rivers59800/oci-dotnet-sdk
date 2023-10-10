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


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// A pluggable database (PDB) is portable collection of schemas, schema objects, and non-schema objects that appears to an Oracle client as a non-container database. To use a PDB, it needs to be plugged into a CDB.
    /// To use any of the API operations, you must be authorized in an IAM policy. If you are not authorized, talk to a tenancy administrator. If you are an administrator who needs to write policies to give users access, see [Getting Started with Policies](https://docs.cloud.oracle.com/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you supply string values using the API.
    /// 
    /// </summary>
    public class PluggableDatabase 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the pluggable database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the CDB.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ContainerDatabaseId is required.")]
        [JsonProperty(PropertyName = "containerDatabaseId")]
        public string ContainerDatabaseId { get; set; }
        
        /// <value>
        /// The name for the pluggable database (PDB). The name is unique in the context of a {@link Database}. The name must begin with an alphabetic character and can contain a maximum of thirty alphanumeric characters. Special characters are not permitted. The pluggable database name should not be same as the container database name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PdbName is required.")]
        [JsonProperty(PropertyName = "pdbName")]
        public string PdbName { get; set; }
                ///
        /// <value>
        /// The current state of the pluggable database.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "FAILED")]
            Failed,
            [EnumMember(Value = "RELOCATING")]
            Relocating,
            [EnumMember(Value = "RELOCATED")]
            Relocated,
            [EnumMember(Value = "REFRESHING")]
            Refreshing,
            [EnumMember(Value = "RESTORE_IN_PROGRESS")]
            RestoreInProgress,
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "DISABLED")]
            Disabled
        };

        /// <value>
        /// The current state of the pluggable database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Detailed message for the lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The date and time the pluggable database was created.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        [JsonProperty(PropertyName = "connectionStrings")]
        public PluggableDatabaseConnectionStrings ConnectionStrings { get; set; }
                ///
        /// <value>
        /// **Deprecated.** Use {@link #pluggableDatabaseNodeLevelDetails(PluggableDatabaseNodeLevelDetailsRequest) pluggableDatabaseNodeLevelDetails} for OpenMode details.
        /// The mode that pluggable database is in. Open mode can only be changed to READ_ONLY or MIGRATE directly from the backend (within the Oracle Database software).
        /// 
        /// </value>
        ///
        public enum OpenModeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "READ_ONLY")]
            ReadOnly,
            [EnumMember(Value = "READ_WRITE")]
            ReadWrite,
            [EnumMember(Value = "MOUNTED")]
            Mounted,
            [EnumMember(Value = "MIGRATE")]
            Migrate
        };

        /// <value>
        /// **Deprecated.** Use {@link #pluggableDatabaseNodeLevelDetails(PluggableDatabaseNodeLevelDetailsRequest) pluggableDatabaseNodeLevelDetails} for OpenMode details.
        /// The mode that pluggable database is in. Open mode can only be changed to READ_ONLY or MIGRATE directly from the backend (within the Oracle Database software).
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OpenMode is required.")]
        [JsonProperty(PropertyName = "openMode")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<OpenModeEnum> OpenMode { get; set; }
        
        /// <value>
        /// The restricted mode of the pluggable database. If a pluggable database is opened in restricted mode,
        /// the user needs both create a session and have restricted session privileges to connect to it.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRestricted")]
        public System.Nullable<bool> IsRestricted { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        [JsonProperty(PropertyName = "pluggableDatabaseManagementConfig")]
        public PluggableDatabaseManagementConfig PluggableDatabaseManagementConfig { get; set; }
        
        [JsonProperty(PropertyName = "refreshableCloneConfig")]
        public PluggableDatabaseRefreshableCloneConfig RefreshableCloneConfig { get; set; }
        
        /// <value>
        /// Pluggable Database Node Level Details.
        /// Example: [{&quot;nodeName&quot; : &quot;node1&quot;, &quot;openMode&quot; : &quot;READ_WRITE&quot;}, {&quot;nodeName&quot; : &quot;node2&quot;, &quot;openMode&quot; : &quot;READ_ONLY&quot;}]
        /// </value>
        [JsonProperty(PropertyName = "pdbNodeLevelDetails")]
        public System.Collections.Generic.List<PluggableDatabaseNodeLevelDetails> PdbNodeLevelDetails { get; set; }
        
    }
}
