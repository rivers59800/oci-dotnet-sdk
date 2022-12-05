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


namespace Oci.AidocumentService.Models
{
    /// <summary>
    /// A single cell in a table.
    /// </summary>
    public class Cell 
    {
        
        /// <value>
        /// The text recognized in the cell.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Text is required.")]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        
        /// <value>
        /// The index of the cell inside the row.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RowIndex is required.")]
        [JsonProperty(PropertyName = "rowIndex")]
        public System.Nullable<int> RowIndex { get; set; }
        
        /// <value>
        /// The index of the cell inside the column.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ColumnIndex is required.")]
        [JsonProperty(PropertyName = "columnIndex")]
        public System.Nullable<int> ColumnIndex { get; set; }
        
        /// <value>
        /// The confidence score between 0 and 1.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Confidence is required.")]
        [JsonProperty(PropertyName = "confidence")]
        public System.Nullable<float> Confidence { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "BoundingPolygon is required.")]
        [JsonProperty(PropertyName = "boundingPolygon")]
        public BoundingPolygon BoundingPolygon { get; set; }
        
        /// <value>
        /// The words detected in the cell.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "WordIndexes is required.")]
        [JsonProperty(PropertyName = "wordIndexes")]
        public System.Collections.Generic.List<int> WordIndexes { get; set; }
        
    }
}
