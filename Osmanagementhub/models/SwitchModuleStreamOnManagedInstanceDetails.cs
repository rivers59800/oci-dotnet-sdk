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


namespace Oci.OsmanagementhubService.Models
{
    /// <summary>
    /// Provides the information used to switch module streams on a managed instance.
    /// </summary>
    public class SwitchModuleStreamOnManagedInstanceDetails 
    {
        
        [JsonProperty(PropertyName = "workRequestDetails")]
        public WorkRequestDetails WorkRequestDetails { get; set; }
        
        /// <value>
        /// The name of a module.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ModuleName is required.")]
        [JsonProperty(PropertyName = "moduleName")]
        public string ModuleName { get; set; }
        
        /// <value>
        /// The name of a stream of the specified module.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamName is required.")]
        [JsonProperty(PropertyName = "streamName")]
        public string StreamName { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/identifiers.htm) of the software source that contains the module stream.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "softwareSourceId")]
        public string SoftwareSourceId { get; set; }
        
    }
}
