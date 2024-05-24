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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The Data Guard performance metric details.
    /// </summary>
    public class PerformanceMetrics 
    {
        
        /// <value>
        /// The name of the metric.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The dimensions of the Data Guard performance metrics, such as primary database ID, primary database unique name.
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Object Dimensions { get; set; }
        
        /// <value>
        /// The metadata of the metric, such as Unit.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Object Metadata { get; set; }
        
        /// <value>
        /// The aggregated datapoints of the metric.
        /// </value>
        [JsonProperty(PropertyName = "datapoints")]
        public System.Collections.Generic.List<DataPoints> Datapoints { get; set; }
        
    }
}
