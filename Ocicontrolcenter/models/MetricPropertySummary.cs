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


namespace Oci.OcicontrolcenterService.Models
{
    /// <summary>
    /// A summary of the properties that define a metric.
    /// 
    /// </summary>
    public class MetricPropertySummary 
    {
        
        /// <value>
        /// The name of the metric.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MetricName is required.")]
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }
        
        /// <value>
        /// Qualifiers provided in a metric definition. Available dimensions vary by metric namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dimensions")]
        public System.Collections.Generic.Dictionary<string, DimensionValue> Dimensions { get; set; }
        
    }
}
