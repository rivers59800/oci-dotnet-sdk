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
    
    public class InstanceSourceViaImageDetails : InstanceSourceDetails
    {
        
        /// <value>
        /// The size of the boot volume in GBs. The minimum value is 50 GB and the maximum value is 32,768 GB (32 TB).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bootVolumeSizeInGBs")]
        public System.Nullable<long> BootVolumeSizeInGBs { get; set; }
        
        /// <value>
        /// The OCID of the image used to boot the instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ImageId is required.")]
        [JsonProperty(PropertyName = "imageId")]
        public string ImageId { get; set; }
        
        /// <value>
        /// The OCID of the key management key to assign as the master encryption key for the boot volume.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The number of volume performance units (VPUs) that will be applied to this volume per GB that
        /// represents the Block Volume service's elastic performance options.
        /// See [Block Volume Performance Levels](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/blockvolumeperformance.htm#perf_levels) for more information.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `10`: Represents Balanced option.
        /// <br/>
        ///   * `20`: Represents Higher Performance option.
        /// <br/>
        ///   * `30`-`120`: Represents the Ultra High Performance option.
        /// <br/>
        /// For volumes with the auto-tuned performance feature enabled, this is set to the default (minimum) VPUs/GB.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bootVolumeVpusPerGB")]
        public System.Nullable<long> BootVolumeVpusPerGB { get; set; }
        
        [JsonProperty(PropertyName = "sourceType")]
        private readonly string sourceType = "image";
    }
}
