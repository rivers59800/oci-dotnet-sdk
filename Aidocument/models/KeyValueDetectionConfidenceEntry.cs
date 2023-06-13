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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// Key Value Detection Confidence Entry.
    /// </summary>
    public class KeyValueDetectionConfidenceEntry 
    {
        
        /// <value>
        /// Threshold used to calculate precision and recall.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Threshold is required.")]
        [JsonProperty(PropertyName = "threshold")]
        public System.Nullable<float> Threshold { get; set; }
        
        /// <value>
        /// Precision under the threshold
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Precision is required.")]
        [JsonProperty(PropertyName = "precision")]
        public System.Nullable<float> Precision { get; set; }
        
        /// <value>
        /// Recall under the threshold
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Recall is required.")]
        [JsonProperty(PropertyName = "recall")]
        public System.Nullable<float> Recall { get; set; }
        
        /// <value>
        /// f1Score under the threshold
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "F1Score is required.")]
        [JsonProperty(PropertyName = "f1Score")]
        public System.Nullable<float> F1Score { get; set; }
        
        /// <value>
        /// accuracy under the threshold
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Accuracy is required.")]
        [JsonProperty(PropertyName = "accuracy")]
        public System.Nullable<float> Accuracy { get; set; }
        
    }
}
