/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Child reference contains application configuration information.
    /// </summary>
    public class ChildReference 
    {
        
        /// <value>
        /// The reference's key, key of the object that is being used by a published object or its dependents.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        /// <value>
        /// The name of reference object.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The identifier of reference object.
        /// </value>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }
        
        /// <value>
        /// The identifier path of reference object.
        /// </value>
        [JsonProperty(PropertyName = "identifierPath")]
        public string IdentifierPath { get; set; }
        
        /// <value>
        /// The description of reference object.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// The type of the reference object.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ORACLEDB_CONNECTION")]
            OracledbConnection,
            [EnumMember(Value = "ORACLE_OBJECT_STORAGE_CONNECTION")]
            OracleObjectStorageConnection,
            [EnumMember(Value = "ORACLE_ATP_CONNECTION")]
            OracleAtpConnection,
            [EnumMember(Value = "ORACLE_ADWC_CONNECTION")]
            OracleAdwcConnection,
            [EnumMember(Value = "MYSQL_CONNECTION")]
            MysqlConnection,
            [EnumMember(Value = "GENERIC_JDBC_CONNECTION")]
            GenericJdbcConnection,
            [EnumMember(Value = "BIP_CONNECTION")]
            BipConnection,
            [EnumMember(Value = "BICC_CONNECTION")]
            BiccConnection,
            [EnumMember(Value = "AMAZON_S3_CONNECTION")]
            AmazonS3Connection
        };

        /// <value>
        /// The type of the reference object.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The new reference object to use instead of the original reference. For example, this can be a data asset reference.
        /// </value>
        [JsonProperty(PropertyName = "targetObject")]
        public System.Object TargetObject { get; set; }
        
        /// <value>
        /// The aggregator key of the child reference object. For example, this can be a data asset key.
        /// </value>
        [JsonProperty(PropertyName = "aggregatorKey")]
        public string AggregatorKey { get; set; }
        
        /// <value>
        /// List of published objects where this is used.
        /// </value>
        [JsonProperty(PropertyName = "usedBy")]
        public System.Collections.Generic.List<ReferenceUsedBy> UsedBy { get; set; }
        
    }
}
