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


namespace Oci.JmsjavadownloadsService.Models
{
    /// <summary>
    /// Attributes to create a Java download report.
    /// </summary>
    public class CreateJavaDownloadReportDetails 
    {
        
        /// <value>
        /// The compartment [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) here should be
        /// the tenancy OCID.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// The start time from when download records have to be included (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// The end time until when the download records have to be included (formatted according to [RFC3339](https://datatracker.ietf.org/doc/html/rfc3339)).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The property to be used for sorting the records.
        /// </value>
        [JsonProperty(PropertyName = "sortBy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JavaDownloadRecordSortBy> SortBy { get; set; }
        
        /// <value>
        /// The sort order for the records.
        /// </value>
        [JsonProperty(PropertyName = "sortOrder")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<SortOrder> SortOrder { get; set; }
        
        /// <value>
        /// The format of the report that is generated.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Format is required.")]
        [JsonProperty(PropertyName = "format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<JavaDownloadReportFormat> Format { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type, or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}. (See [Managing Tags and Tag Namespaces](https://docs.cloud.oracle.com/Content/Tagging/Concepts/understandingfreeformtags.htm).)
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}. (See [Understanding Free-form Tags](https://docs.cloud.oracle.com/Content/Tagging/Tasks/managingtagsandtagnamespaces.htm)).
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
