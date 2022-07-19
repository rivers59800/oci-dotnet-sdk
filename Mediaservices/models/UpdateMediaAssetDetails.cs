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


namespace Oci.MediaservicesService.Models
{
    /// <summary>
    /// The information to be updated.
    /// </summary>
    public class UpdateMediaAssetDetails 
    {
        
        /// <value>
        /// Display name for the Media Asset. Does not have to be unique. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The type of the media asset.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AssetType> Type { get; set; }
        
        /// <value>
        /// The ID of the parent asset from which this asset is derived.
        /// </value>
        [JsonProperty(PropertyName = "parentMediaAssetId")]
        public string ParentMediaAssetId { get; set; }
        
        /// <value>
        /// The ID of the senior most asset from which this asset is derived.
        /// </value>
        [JsonProperty(PropertyName = "masterMediaAssetId")]
        public string MasterMediaAssetId { get; set; }
        
        /// <value>
        /// List of Metadata.
        /// </value>
        [JsonProperty(PropertyName = "metadata")]
        public System.Collections.Generic.List<Metadata> Metadata { get; set; }
        
        /// <value>
        /// List of tags for the MediaAsset.
        /// </value>
        [JsonProperty(PropertyName = "mediaAssetTags")]
        public System.Collections.Generic.List<MediaAssetTag> MediaAssetTags { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
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
        
    }
}
