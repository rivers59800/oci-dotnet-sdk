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


namespace Oci.DatacatalogService.Models
{
    /// <summary>
    /// Details about the job which performs an export.
    /// </summary>
    public class AsynchronousExportGlossaryResult 
    {
        
        /// <value>
        /// Display name of the export job.
        /// </value>
        [JsonProperty(PropertyName = "jobDefinitionName")]
        public string JobDefinitionName { get; set; }
        
        /// <value>
        /// Unique key of the export job definition.
        /// </value>
        [JsonProperty(PropertyName = "jobDefinitionKey")]
        public string JobDefinitionKey { get; set; }
        
        /// <value>
        /// Unique key of the export job.
        /// </value>
        [JsonProperty(PropertyName = "jobKey")]
        public string JobKey { get; set; }
        
        /// <value>
        /// Unique key of the job execution.
        /// </value>
        [JsonProperty(PropertyName = "jobExecutionKey")]
        public string JobExecutionKey { get; set; }
        
        /// <value>
        /// Unique key of the object being exported.
        /// </value>
        [JsonProperty(PropertyName = "sourceKey")]
        public string SourceKey { get; set; }
        
    }
}
