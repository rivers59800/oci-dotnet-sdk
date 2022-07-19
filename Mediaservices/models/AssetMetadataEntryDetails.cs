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
    /// Asset Metadata entry information.
    /// </summary>
    public class AssetMetadataEntryDetails : IngestStreamDistributionChannelDetails
    {
        
        /// <value>
        /// The Media Asset ID to ingest into the Distribution Channel.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "MediaAssetId is required.")]
        [JsonProperty(PropertyName = "mediaAssetId")]
        public string MediaAssetId { get; set; }
        
        /// <value>
        /// The compartment ID where the Ingest Workflow Job will be run.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "ingestPayloadType")]
        private readonly string ingestPayloadType = "ASSET_METADATA_MEDIA_ASSET";
    }
}
