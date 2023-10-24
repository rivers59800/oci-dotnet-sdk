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


namespace Oci.AdmService.Models
{
    /// <summary>
    /// Extends a Verify configuration with appropriate data to reach and use the build service provided by a GitLab Pipeline.
    /// </summary>
    public class GitLabPipelineConfiguration : VerifyConfiguration
    {
        
        /// <value>
        /// The location of the Repository where the GitLab Pipeline will be run.
        /// The expected format is https://gitlab.com/[groupName]/[repoName]
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "RepositoryUrl is required.")]
        [JsonProperty(PropertyName = "repositoryUrl")]
        public string RepositoryUrl { get; set; }
        
        /// <value>
        /// The username that will trigger the GitLab Pipeline.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Username is required.")]
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The Oracle Cloud Identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the Private Access Token (PAT) Secret.
        /// The PAT provides the credentials to access the GitLab pipeline.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PatSecretId is required.")]
        [JsonProperty(PropertyName = "patSecretId")]
        public string PatSecretId { get; set; }
        
        /// <value>
        /// The Oracle Cloud Identifier ([OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)) of the trigger Secret.
        /// The Secret provides access to the trigger for a GitLab pipeline.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TriggerSecretId is required.")]
        [JsonProperty(PropertyName = "triggerSecretId")]
        public string TriggerSecretId { get; set; }
        
        /// <value>
        /// Additional key-value pairs passed as parameters to the build service when running an experiment.
        /// </value>
        [JsonProperty(PropertyName = "additionalParameters")]
        public System.Collections.Generic.Dictionary<string, string> AdditionalParameters { get; set; }
        
        [JsonProperty(PropertyName = "buildServiceType")]
        private readonly string buildServiceType = "GITLAB_PIPELINE";
    }
}
