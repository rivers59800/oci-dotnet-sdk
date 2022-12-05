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

namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Auth endpoint details.
    /// </summary>
    [JsonConverter(typeof(SourceUriDetailsModelConverter))]
    public class SourceUriDetails 
    {
                ///
        /// <value>
        /// Type of the Uri detail.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "DISCOVERY_URI")]
            DiscoveryUri,
            [EnumMember(Value = "VALIDATION_BLOCK")]
            ValidationBlock
        };

        
    }

    public class SourceUriDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(SourceUriDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(SourceUriDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "DISCOVERY_URI":
                    obj = new DiscoveryUriSourceUriDetails();
                    break;
                case "VALIDATION_BLOCK":
                    obj = new ValidationBlockSourceUriDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under SourceUriDetails! Returning null value.");
            }
            return obj;
        }
    }
}
