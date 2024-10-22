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
    /// The details of the Input argument.
    /// </summary>
    [JsonConverter(typeof(InputArgumentModelConverter))]
    public class InputArgument 
    {
                ///
        /// <value>
        /// Input argument Type.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "STRING")]
            String,
            [EnumMember(Value = "OUTPUT_VARIABLE")]
            OutputVariable
        };

        
        /// <value>
        /// The name of the argument.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The description of the argument.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
    }

    public class InputArgumentModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(InputArgument);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(InputArgument);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "OUTPUT_VARIABLE":
                    obj = new OutputVariableInputArgument();
                    break;
                case "STRING":
                    obj = new StringInputArgument();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under InputArgument! Returning null value.");
            }
            return obj;
        }
    }
}
