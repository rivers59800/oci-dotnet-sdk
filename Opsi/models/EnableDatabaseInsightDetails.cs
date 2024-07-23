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

namespace Oci.OpsiService.Models
{
    /// <summary>
    /// The information about database to be analyzed.
    /// </summary>
    [JsonConverter(typeof(EnableDatabaseInsightDetailsModelConverter))]
    public class EnableDatabaseInsightDetails 
    {
        
        
    }

    public class EnableDatabaseInsightDetailsModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(EnableDatabaseInsightDetails);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(EnableDatabaseInsightDetails);
            var discriminator = jsonObject["entitySource"].Value<string>();
            switch (discriminator)
            {
                case "EM_MANAGED_EXTERNAL_DATABASE":
                    obj = new EnableEmManagedExternalDatabaseInsightDetails();
                    break;
                case "MDS_MYSQL_DATABASE_SYSTEM":
                    obj = new EnableMdsMySqlDatabaseInsightDetails();
                    break;
                case "PE_COMANAGED_DATABASE":
                    obj = new EnablePeComanagedDatabaseInsightDetails();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
