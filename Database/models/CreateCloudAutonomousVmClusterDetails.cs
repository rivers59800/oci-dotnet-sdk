/*
 * Copyright (c) 2020, 2024, Oracle and/or its affiliates. All rights reserved.
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
    /// Details for the create cloud Autonomous VM cluster operation.
    /// 
    /// </summary>
    public class CreateCloudAutonomousVmClusterDetails 
    {
        
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
        /// User defined description of the cloud Autonomous VM cluster.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the cloud Autonomous VM Cluster is associated with.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SubnetId is required.")]
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// The user-friendly name for the cloud Autonomous VM cluster. The name does not need to be unique.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the cloud Exadata infrastructure.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CloudExadataInfrastructureId is required.")]
        [JsonProperty(PropertyName = "cloudExadataInfrastructureId")]
        public string CloudExadataInfrastructureId { get; set; }
        
        /// <value>
        /// The total number of Autonomous Container Databases that can be created.
        /// </value>
        [JsonProperty(PropertyName = "totalContainerDatabases")]
        public System.Nullable<int> TotalContainerDatabases { get; set; }
        
        /// <value>
        /// The number of CPU cores to be enabled per VM cluster node.
        /// </value>
        [JsonProperty(PropertyName = "cpuCoreCountPerNode")]
        public System.Nullable<int> CpuCoreCountPerNode { get; set; }
        
        /// <value>
        /// The amount of memory (in GBs) to be enabled per OCPU or ECPU.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "memoryPerOracleComputeUnitInGBs")]
        public System.Nullable<int> MemoryPerOracleComputeUnitInGBs { get; set; }
        
        /// <value>
        /// The data disk group size to be allocated for Autonomous Databases, in TBs.
        /// </value>
        [JsonProperty(PropertyName = "autonomousDataStorageSizeInTBs")]
        public System.Double AutonomousDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The time zone to use for the Cloud Autonomous VM cluster. For details, see [DB System Time Zones](https://docs.cloud.oracle.com/Content/Database/References/timezones.htm).
        /// </value>
        [JsonProperty(PropertyName = "clusterTimeZone")]
        public string ClusterTimeZone { get; set; }
                ///
        /// <value>
        /// The compute model of the Cloud Autonomous VM Cluster. ECPU compute model is the recommended model and OCPU compute model is legacy.
        /// 
        /// </value>
        ///
        public enum ComputeModelEnum {
            [EnumMember(Value = "ECPU")]
            Ecpu,
            [EnumMember(Value = "OCPU")]
            Ocpu
        };

        /// <value>
        /// The compute model of the Cloud Autonomous VM Cluster. ECPU compute model is the recommended model and OCPU compute model is legacy.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "computeModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ComputeModelEnum> ComputeModel { get; set; }
        
        /// <value>
        /// Enable mutual TLS(mTLS) authentication for database at time of provisioning a VMCluster. This is applicable to database TLS Certificates only. Default is TLS
        /// </value>
        [JsonProperty(PropertyName = "isMtlsEnabledVmCluster")]
        public System.Nullable<bool> IsMtlsEnabledVmCluster { get; set; }
        
        /// <value>
        /// The list of database servers.
        /// </value>
        [JsonProperty(PropertyName = "dbServers")]
        public System.Collections.Generic.List<string> DbServers { get; set; }
        
        [JsonProperty(PropertyName = "maintenanceWindowDetails")]
        public MaintenanceWindow MaintenanceWindowDetails { get; set; }
        
        /// <value>
        /// The SCAN Listener TLS port. Default is 2484.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortTls")]
        public System.Nullable<int> ScanListenerPortTls { get; set; }
        
        /// <value>
        /// The SCAN Listener Non TLS port. Default is 1521.
        /// </value>
        [JsonProperty(PropertyName = "scanListenerPortNonTls")]
        public System.Nullable<int> ScanListenerPortNonTls { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Oracle Database service.
        /// Note that when provisioning an [Autonomous Database on dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null. It is already set at the
        /// Autonomous Exadata Infrastructure level. When provisioning an [Autonomous Database Serverless] (https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) database, if a value is not specified, the system defaults the value to `BRING_YOUR_OWN_LICENSE`. Bring your own license (BYOL) also allows you to select the DB edition using the optional parameter.
        /// <br/>
        /// This cannot be updated in parallel with any of the following: cpuCoreCount, computeCount, dataStorageSizeInTBs, adminPassword, isMTLSConnectionRequired, dbWorkload, privateEndpointLabel, nsgIds, dbVersion, dbName, scheduledOperations, dbToolsDetails, or isFreeTier.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Oracle Database service.
        /// Note that when provisioning an [Autonomous Database on dedicated Exadata infrastructure](https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html), this attribute must be null. It is already set at the
        /// Autonomous Exadata Infrastructure level. When provisioning an [Autonomous Database Serverless] (https://docs.oracle.com/en/cloud/paas/autonomous-database/index.html) database, if a value is not specified, the system defaults the value to `BRING_YOUR_OWN_LICENSE`. Bring your own license (BYOL) also allows you to select the DB edition using the optional parameter.
        /// <br/>
        /// This cannot be updated in parallel with any of the following: cpuCoreCount, computeCount, dataStorageSizeInTBs, adminPassword, isMTLSConnectionRequired, dbWorkload, privateEndpointLabel, nsgIds, dbVersion, dbName, scheduledOperations, dbToolsDetails, or isFreeTier.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) for the network security groups (NSGs) to which this resource belongs. Setting this to an empty list removes all resources from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - A network security group (NSG) is optional for Autonomous Databases with private access. The nsgIds list can be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
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
        
        /// <value>
        /// Security Attributes for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// Example: {&quot;Oracle-ZPR&quot;: {&quot;MaxEgressCount&quot;: {&quot;value&quot;: &quot;42&quot;, &quot;mode&quot;: &quot;audit&quot;}}}
        /// </value>
        [JsonProperty(PropertyName = "securityAttributes")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SecurityAttributes { get; set; }
        
    }
}
