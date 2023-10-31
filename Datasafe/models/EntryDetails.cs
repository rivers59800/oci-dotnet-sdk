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
using Newtonsoft.Json.Linq;

namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details specific to the security policy entry.
    /// </summary>
    [JsonConverter(typeof(EntryDetailsModelConverter))]
    public class EntryDetails 
    {
                ///
        /// <value>
        /// The security policy entry type. Allowed values:
        /// - FIREWALL_POLICY - The SQL firewall policy entry type.
        /// 
        /// </value>
        ///
        public enum EntryTypeEnum {
            [EnumMember(Value = "FIREWALL_POLICY")]
            FirewallPolicy
        };

        
    }

    public class EntryDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(EntryDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(EntryDetails);
            var discriminator = jsonObject["entryType"].Value<string>();
            switch (discriminator)
            {
                case "FIREWALL_POLICY":
                    obj = new FirewallPolicyEntryDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under EntryDetails! Returning null value.");
            }
            return obj;
        }
    }
}
