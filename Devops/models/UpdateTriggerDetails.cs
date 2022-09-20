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
using Newtonsoft.Json.Linq;

namespace Oci.DevopsService.Models
{
    /// <summary>
    /// The information to be updated.
    /// </summary>
    [JsonConverter(typeof(UpdateTriggerDetailsModelConverter))]
    public class UpdateTriggerDetails 
    {
        
        /// <value>
        /// Trigger display name. Avoid entering confidential information.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Optional description about the trigger.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        
        /// <value>
        /// The list of actions that are to be performed for this trigger.
        /// </value>
        [JsonProperty(PropertyName = "actions")]
        public System.Collections.Generic.List<TriggerAction> Actions { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.  See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace. See [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm). Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }

    public class UpdateTriggerDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(UpdateTriggerDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(UpdateTriggerDetails);
            var discriminator = jsonObject["triggerSource"].Value<string>();
            switch (discriminator)
            {
                case "BITBUCKET_SERVER":
                    obj = new UpdateBitbucketServerTriggerDetails();
                    break;
                case "VBS":
                    obj = new UpdateVbsTriggerDetails();
                    break;
                case "GITLAB_SERVER":
                    obj = new UpdateGitlabServerTriggerDetails();
                    break;
                case "DEVOPS_CODE_REPOSITORY":
                    obj = new UpdateDevopsCodeRepositoryTriggerDetails();
                    break;
                case "GITHUB":
                    obj = new UpdateGithubTriggerDetails();
                    break;
                case "GITLAB":
                    obj = new UpdateGitlabTriggerDetails();
                    break;
                case "BITBUCKET_CLOUD":
                    obj = new UpdateBitbucketCloudTriggerDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
