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

namespace Oci.AispeechService.Models
{
    /// <summary>
    /// Model specific properties to use with Oracle model for TTS.
    /// </summary>
    [JsonConverter(typeof(TtsOracleModelDetailsModelConverter))]
    public class TtsOracleModelDetails 
    {
                ///
        /// <value>
        /// The fully qualified name of model to use for speech generation. The available models are:
        /// - TTS_1_STANDARD
        /// - TTS_2_NATURAL
        /// 
        /// </value>
        ///
        public enum ModelNameEnum {
            [EnumMember(Value = "TTS_1_STANDARD")]
            Tts1Standard,
            [EnumMember(Value = "TTS_2_NATURAL")]
            Tts2Natural
        };

        
    }

    public class TtsOracleModelDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(TtsOracleModelDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(TtsOracleModelDetails);
            var discriminator = jsonObject["modelName"].Value<string>();
            switch (discriminator)
            {
                case "TTS_2_NATURAL":
                    obj = new TtsOracleTts2NaturalModelDetails();
                    break;
                case "TTS_1_STANDARD":
                    obj = new TtsOracleTts1StandardModelDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
