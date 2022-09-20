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


namespace Oci.CloudmigrationsService.Models
{
    /// <summary>
    /// Sumarized information about a shape.
    /// </summary>
    public class AvailableShapeSummary 
    {
        
        /// <value>
        /// Availability domain of the shape.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "AvailabilityDomain is required.")]
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// Shape name and availability domain.  Used for pagination.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PaginationToken is required.")]
        [JsonProperty(PropertyName = "paginationToken")]
        public string PaginationToken { get; set; }
        
        /// <value>
        /// Minimum CPUs required.
        /// </value>
        [JsonProperty(PropertyName = "minTotalBaselineOcpusRequired")]
        public System.Nullable<decimal> MinTotalBaselineOcpusRequired { get; set; }
        
        /// <value>
        /// Name of the shape.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Shape is required.")]
        [JsonProperty(PropertyName = "shape")]
        public string Shape { get; set; }
        
        /// <value>
        /// Description of the processor.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProcessorDescription is required.")]
        [JsonProperty(PropertyName = "processorDescription")]
        public string ProcessorDescription { get; set; }
        
        /// <value>
        /// Number of CPUs.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ocpus is required.")]
        [JsonProperty(PropertyName = "ocpus")]
        public System.Nullable<float> Ocpus { get; set; }
        
        /// <value>
        /// Amount of memory for the shape.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MemoryInGBs is required.")]
        [JsonProperty(PropertyName = "memoryInGBs")]
        public System.Nullable<float> MemoryInGBs { get; set; }
        
        /// <value>
        /// Shape bandwidth.
        /// </value>
        [JsonProperty(PropertyName = "networkingBandwidthInGbps")]
        public System.Nullable<float> NetworkingBandwidthInGbps { get; set; }
        
        /// <value>
        /// Maximum number of virtual network interfaces that can be attached.
        /// </value>
        [JsonProperty(PropertyName = "maxVnicAttachments")]
        public System.Nullable<int> MaxVnicAttachments { get; set; }
        
        /// <value>
        /// Number of GPUs.
        /// </value>
        [JsonProperty(PropertyName = "gpus")]
        public System.Nullable<int> Gpus { get; set; }
        
        /// <value>
        /// Description of the GPUs.
        /// </value>
        [JsonProperty(PropertyName = "gpuDescription")]
        public string GpuDescription { get; set; }
        
        /// <value>
        /// Number of local disks.
        /// </value>
        [JsonProperty(PropertyName = "localDisks")]
        public System.Nullable<int> LocalDisks { get; set; }
        
        /// <value>
        /// Total size of local disks for shape.
        /// </value>
        [JsonProperty(PropertyName = "localDisksTotalSizeInGBs")]
        public System.Nullable<float> LocalDisksTotalSizeInGBs { get; set; }
        
        /// <value>
        /// Description of local disks.
        /// </value>
        [JsonProperty(PropertyName = "localDiskDescription")]
        public string LocalDiskDescription { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. It exists only for cross-compatibility.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
