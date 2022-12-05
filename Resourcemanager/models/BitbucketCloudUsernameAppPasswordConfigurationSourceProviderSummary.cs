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


namespace Oci.ResourcemanagerService.Models
{
    /// <summary>
    /// Summary information for a configuration source provider of the type `BITBUCKET_CLOUD_USERNAME_APPPASSWORD`.
    /// This type corresponds to a configuration source provider in Bitbucket cloud that is authenticated with a username and app password.
    /// 
    /// </summary>
    public class BitbucketCloudUsernameAppPasswordConfigurationSourceProviderSummary : ConfigurationSourceProviderSummary
    {
        
        /// <value>
        /// The Bitbucket cloud service endpoint.
        /// Example: https://bitbucket.org/
        /// </value>
        [JsonProperty(PropertyName = "apiEndpoint")]
        public string ApiEndpoint { get; set; }
        
        [JsonProperty(PropertyName = "configSourceProviderType")]
        private readonly string configSourceProviderType = "BITBUCKET_CLOUD_USERNAME_APPPASSWORD";
    }
}
