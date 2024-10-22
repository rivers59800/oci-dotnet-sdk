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
using Newtonsoft.Json.Linq;

namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// Config Category Details.
    /// </summary>
    [JsonConverter(typeof(ConfigCategoryDetailsModelConverter))]
    public class ConfigCategoryDetails 
    {
                ///
        /// <value>
        /// Category of configuration
        /// </value>
        ///
        public enum ConfigCategoryEnum {
            [EnumMember(Value = "PRODUCT")]
            Product,
            [EnumMember(Value = "PRODUCT_STACK")]
            ProductStack,
            [EnumMember(Value = "ENVIRONMENT")]
            Environment,
            [EnumMember(Value = "PATCH_TYPE")]
            PatchType,
            [EnumMember(Value = "CREDENTIAL")]
            Credential
        };

        
    }

    public class ConfigCategoryDetailsModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(ConfigCategoryDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(ConfigCategoryDetails);
            var discriminator = jsonObject["configCategory"].Value<string>();
            switch (discriminator)
            {
                case "PRODUCT_STACK":
                    obj = new ProductStackConfigCategoryDetails();
                    break;
                case "ENVIRONMENT":
                    obj = new EnvironmentConfigCategoryDetails();
                    break;
                case "CREDENTIAL":
                    obj = new CredentialConfigCategoryDetails();
                    break;
                case "PATCH_TYPE":
                    obj = new PatchTypeConfigCategoryDetails();
                    break;
                case "PRODUCT":
                    obj = new ProductConfigCategoryDetails();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under ConfigCategoryDetails! Returning null value.");
            }
            return obj;
        }
    }
}
