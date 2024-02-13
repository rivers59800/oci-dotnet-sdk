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

namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Generic column defining all attributes common to all querylanguage columns.
    /// 
    /// </summary>
    [JsonConverter(typeof(AbstractColumnModelConverter))]
    public class AbstractColumn 
    {
                ///
        /// <value>
        /// Column classification when column requires special designation.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "COLUMN")]
            Column,
            [EnumMember(Value = "CHART_COLUMN")]
            ChartColumn,
            [EnumMember(Value = "CHART_DATA_COLUMN")]
            ChartDataColumn,
            [EnumMember(Value = "TIME_STATS_COLUMN")]
            TimeStatsColumn,
            [EnumMember(Value = "TIME_STATS_DATA_COLUMN")]
            TimeStatsDataColumn,
            [EnumMember(Value = "TIME_CLUSTER_COLUMN")]
            TimeClusterColumn,
            [EnumMember(Value = "TIME_CLUSTER_DATA_COLUMN")]
            TimeClusterDataColumn,
            [EnumMember(Value = "TABLE_COLUMN")]
            TableColumn,
            [EnumMember(Value = "TIME_COLUMN")]
            TimeColumn,
            [EnumMember(Value = "TREND_COLUMN")]
            TrendColumn,
            [EnumMember(Value = "CLASSIFY_COLUMN")]
            ClassifyColumn
        };

        
        /// <value>
        /// Column display name - will be alias if column is renamed by queryStrng.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Subsystem column belongs to.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subSystem")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<SubSystemName> SubSystem { get; set; }
        
        /// <value>
        /// If the column is a 'List of Values' column, this array contains the field values that are applicable to query results or all if no filters applied.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.List<FieldValue> Values { get; set; }
        
        /// <value>
        /// Identifies if all values in this column come from a pre-defined list of values.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isListOfValues")]
        public System.Nullable<bool> IsListOfValues { get; set; }
        
        /// <value>
        /// Identifies if this column allows multiple values to exist in a single row.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMultiValued")]
        public System.Nullable<bool> IsMultiValued { get; set; }
        
        /// <value>
        /// A flag indicating whether or not the field is a case sensitive field.  Only applies to string fields.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isCaseSensitive")]
        public System.Nullable<bool> IsCaseSensitive { get; set; }
        
        /// <value>
        /// Identifies if this column can be used as a grouping field in any grouping command.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isGroupable")]
        public System.Nullable<bool> IsGroupable { get; set; }
        
        /// <value>
        /// Identifies if this column can be used as an expression parameter in any command that accepts querylanguage expressions.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEvaluable")]
        public System.Nullable<bool> IsEvaluable { get; set; }
        
        /// <value>
        /// Identifies if this column should be hidden by default but can be displayed in the UI on demand.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// Field denoting column data type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "valueType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ValueType> ValueType { get; set; }
        
        /// <value>
        /// Same as displayName unless column renamed in which case this will hold the original display name for the column.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "originalDisplayName")]
        public string OriginalDisplayName { get; set; }
        
        /// <value>
        /// Internal identifier for the column.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "internalName")]
        public string InternalName { get; set; }
        
    }

    public class AbstractColumnModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AbstractColumn);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AbstractColumn);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "TIME_COLUMN":
                    obj = new TimeColumn();
                    break;
                case "CLASSIFY_COLUMN":
                    obj = new ClassifyColumn();
                    break;
                case "TREND_COLUMN":
                    obj = new TrendColumn();
                    break;
                case "TIME_STATS_COLUMN":
                    obj = new TimeStatsColumn();
                    break;
                case "TIME_CLUSTER_COLUMN":
                    obj = new TimeClusterColumn();
                    break;
                case "COLUMN":
                    obj = new Column();
                    break;
                case "TIME_CLUSTER_DATA_COLUMN":
                    obj = new TimeClusterDataColumn();
                    break;
                case "TIME_STATS_DATA_COLUMN":
                    obj = new TimeStatsDataColumn();
                    break;
                case "TABLE_COLUMN":
                    obj = new TableColumn();
                    break;
                case "CHART_COLUMN":
                    obj = new ChartColumn();
                    break;
                case "CHART_DATA_COLUMN":
                    obj = new ChartDataColumn();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under AbstractColumn! Returning null value.");
            }
            return obj;
        }
    }
}
