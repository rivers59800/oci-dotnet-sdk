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
    /// The information about the OCI Function.
    /// </summary>
    public class OciFunction 
    {
        
        /// <value>
        /// Ocid of the OCI Function.
        /// </value>
        [JsonProperty(PropertyName = "functionId")]
        public string FunctionId { get; set; }
        
        /// <value>
        /// Region where the OCI Function is deployed.
        /// </value>
        [JsonProperty(PropertyName = "regionId")]
        public string RegionId { get; set; }
        
        [JsonProperty(PropertyName = "fnConfigDefinition")]
        public ConfigDefinition FnConfigDefinition { get; set; }
        
        [JsonProperty(PropertyName = "inputShape")]
        public Shape InputShape { get; set; }
        
        [JsonProperty(PropertyName = "outputShape")]
        public Shape OutputShape { get; set; }
                ///
        /// <value>
        /// The type of the OCI Function object.
        /// </value>
        ///
        public enum ModelTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "OCI_FUNCTION")]
            OciFunction
        };

        /// <value>
        /// The type of the OCI Function object.
        /// </value>
        [JsonProperty(PropertyName = "modelType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ModelTypeEnum> ModelType { get; set; }
        
        /// <value>
        /// The key identifying the OCI Function operator object, use this to identiy this instance within the dataflow.
        /// </value>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }
        
        [JsonProperty(PropertyName = "parentRef")]
        public ParentReference ParentRef { get; set; }
        
        /// <value>
        /// The model version of an object.
        /// </value>
        [JsonProperty(PropertyName = "modelVersion")]
        public string ModelVersion { get; set; }
        
        /// <value>
        /// The version of the object that is used to track changes in the object instance.
        /// </value>
        [JsonProperty(PropertyName = "objectVersion")]
        public System.Nullable<int> ObjectVersion { get; set; }
                ///
        /// <value>
        /// The OCI Function payload format.
        /// </value>
        ///
        public enum PayloadFormatEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "JSON")]
            Json,
            [EnumMember(Value = "AVRO")]
            Avro,
            [EnumMember(Value = "JSONBYTES")]
            Jsonbytes
        };

        /// <value>
        /// The OCI Function payload format.
        /// </value>
        [JsonProperty(PropertyName = "payloadFormat")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PayloadFormatEnum> PayloadFormat { get; set; }
        
        [JsonProperty(PropertyName = "fnConfigDef")]
        public FunctionConfigurationDefinition FnConfigDef { get; set; }
        
    }
}
