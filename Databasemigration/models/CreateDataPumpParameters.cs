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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Optional parameters for Data Pump Export and Import.
    /// </summary>
    public class CreateDataPumpParameters 
    {
        
        /// <value>
        /// Set to false to force Data Pump worker process to run on one instance.
        /// </value>
        [JsonProperty(PropertyName = "isCluster")]
        public System.Nullable<bool> IsCluster { get; set; }
        
        /// <value>
        /// Estimate size of dumps that will be generated.
        /// </value>
        [JsonProperty(PropertyName = "estimate")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataPumpEstimate> Estimate { get; set; }
        
        /// <value>
        /// IMPORT: Specifies the action to be performed when data is loaded into a preexisting table.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tableExistsAction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataPumpTableExistsAction> TableExistsAction { get; set; }
        
        /// <value>
        /// Exclude paratemers for Export and Import.
        /// </value>
        [JsonProperty(PropertyName = "excludeParameters")]
        public System.Collections.Generic.List<DataPumpExcludeParameters> ExcludeParameters { get; set; }
        
        /// <value>
        /// Maximum number of worker processes that can be used for a Data Pump Import job.
        /// For an Autonomous Database, ODMS will automatically query its CPU core count and set this property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "importParallelismDegree")]
        public System.Nullable<int> ImportParallelismDegree { get; set; }
        
        /// <value>
        /// Maximum number of worker processes that can be used for a Data Pump Export job.
        /// </value>
        [JsonProperty(PropertyName = "exportParallelismDegree")]
        public System.Nullable<int> ExportParallelismDegree { get; set; }
        
    }
}
