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

namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information about canceling.
    /// </summary>
    [JsonConverter(typeof(RescheduleDeploymentUpgradeDetailsModelConverter))]
    public class RescheduleDeploymentUpgradeDetails 
    {
        
        
    }

    public class RescheduleDeploymentUpgradeDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(RescheduleDeploymentUpgradeDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(RescheduleDeploymentUpgradeDetails);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "RESCHEDULE_TO_DATE":
                    obj = new RescheduleDeploymentUpgradeToDateDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
