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

namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// Generic command descriptor defining all attributes common to all querylanguage commands for parse output.
    /// 
    /// </summary>
    [JsonConverter(typeof(AbstractCommandDescriptorModelConverter))]
    public class AbstractCommandDescriptor 
    {
                ///
        /// <value>
        /// Name of querylanguage command
        /// 
        /// </value>
        ///
        public enum NameEnum {
            [EnumMember(Value = "COMMAND")]
            Command,
            [EnumMember(Value = "SEARCH")]
            Search,
            [EnumMember(Value = "STATS")]
            Stats,
            [EnumMember(Value = "GEO_STATS")]
            GeoStats,
            [EnumMember(Value = "TIME_STATS")]
            TimeStats,
            [EnumMember(Value = "SORT")]
            Sort,
            [EnumMember(Value = "FIELDS")]
            Fields,
            [EnumMember(Value = "ADD_FIELDS")]
            AddFields,
            [EnumMember(Value = "LINK")]
            Link,
            [EnumMember(Value = "LINK_DETAILS")]
            LinkDetails,
            [EnumMember(Value = "CLUSTER")]
            Cluster,
            [EnumMember(Value = "CLUSTER_DETAILS")]
            ClusterDetails,
            [EnumMember(Value = "CLUSTER_SPLIT")]
            ClusterSplit,
            [EnumMember(Value = "EVAL")]
            Eval,
            [EnumMember(Value = "EXTRACT")]
            Extract,
            [EnumMember(Value = "JSON_EXTRACT")]
            JsonExtract,
            [EnumMember(Value = "XML_EXTRACT")]
            XmlExtract,
            [EnumMember(Value = "EVENT_STATS")]
            EventStats,
            [EnumMember(Value = "BUCKET")]
            Bucket,
            [EnumMember(Value = "CLASSIFY")]
            Classify,
            [EnumMember(Value = "TOP")]
            Top,
            [EnumMember(Value = "BOTTOM")]
            Bottom,
            [EnumMember(Value = "HEAD")]
            Head,
            [EnumMember(Value = "TAIL")]
            Tail,
            [EnumMember(Value = "FIELD_SUMMARY")]
            FieldSummary,
            [EnumMember(Value = "REGEX")]
            Regex,
            [EnumMember(Value = "RENAME")]
            Rename,
            [EnumMember(Value = "TIME_COMPARE")]
            TimeCompare,
            [EnumMember(Value = "WHERE")]
            Where,
            [EnumMember(Value = "CLUSTER_COMPARE")]
            ClusterCompare,
            [EnumMember(Value = "DELETE")]
            Delete,
            [EnumMember(Value = "DELTA")]
            Delta,
            [EnumMember(Value = "DISTINCT")]
            Distinct,
            [EnumMember(Value = "SEARCH_LOOKUP")]
            SearchLookup,
            [EnumMember(Value = "LOOKUP")]
            Lookup,
            [EnumMember(Value = "DEMO_MODE")]
            DemoMode,
            [EnumMember(Value = "MACRO")]
            Macro,
            [EnumMember(Value = "MODULE")]
            Module,
            [EnumMember(Value = "MULTI_SEARCH")]
            MultiSearch,
            [EnumMember(Value = "HIGHLIGHT")]
            Highlight,
            [EnumMember(Value = "HIGHLIGHT_ROWS")]
            HighlightRows,
            [EnumMember(Value = "HIGHLIGHT_GROUPS")]
            HighlightGroups,
            [EnumMember(Value = "CREATE_VIEW")]
            CreateView,
            [EnumMember(Value = "MAP")]
            Map,
            [EnumMember(Value = "NLP")]
            Nlp,
            [EnumMember(Value = "COMPARE")]
            Compare,
            [EnumMember(Value = "ADD_INSIGHTS")]
            AddInsights,
            [EnumMember(Value = "ANOMALY")]
            Anomaly,
            [EnumMember(Value = "DEDUP")]
            Dedup,
            [EnumMember(Value = "TIME_CLUSTER")]
            TimeCluster,
            [EnumMember(Value = "FREQUENT")]
            Frequent,
            [EnumMember(Value = "RARE")]
            Rare,
            [EnumMember(Value = "OUTLIER")]
            Outlier
        };

        
        /// <value>
        /// Command fragment display string from user specified query string formatted by query builder.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayQueryString is required.")]
        [JsonProperty(PropertyName = "displayQueryString")]
        public string DisplayQueryString { get; set; }
        
        /// <value>
        /// Command fragment internal string from user specified query string formatted by query builder.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InternalQueryString is required.")]
        [JsonProperty(PropertyName = "internalQueryString")]
        public string InternalQueryString { get; set; }
        
        /// <value>
        /// querylanguage command designation for example; reporting vs filtering
        /// 
        /// </value>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }
        
        /// <value>
        /// Fields referenced in command fragment from user specified query string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "referencedFields")]
        public System.Collections.Generic.List<AbstractField> ReferencedFields { get; set; }
        
        /// <value>
        /// Fields declared in command fragment from user specified query string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "declaredFields")]
        public System.Collections.Generic.List<AbstractField> DeclaredFields { get; set; }
        
        /// <value>
        /// Field denoting if this is a hidden command that is not shown in the query string.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
    }

    public class AbstractCommandDescriptorModelConverter : JsonConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(AbstractCommandDescriptor);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(AbstractCommandDescriptor);
            var discriminator = jsonObject["name"].Value<string>();
            switch (discriminator)
            {
                case "TOP":
                    obj = new TopCommandDescriptor();
                    break;
                case "HIGHLIGHT":
                    obj = new HighlightCommandDescriptor();
                    break;
                case "STATS":
                    obj = new StatsCommandDescriptor();
                    break;
                case "TAIL":
                    obj = new TailCommandDescriptor();
                    break;
                case "OUTLIER":
                    obj = new OutlierCommandDescriptor();
                    break;
                case "DEMO_MODE":
                    obj = new DemoModeCommandDescriptor();
                    break;
                case "FIELD_SUMMARY":
                    obj = new FieldSummaryCommandDescriptor();
                    break;
                case "GEO_STATS":
                    obj = new GeoStatsCommandDescriptor();
                    break;
                case "MAP":
                    obj = new MapCommandDescriptor();
                    break;
                case "HIGHLIGHT_GROUPS":
                    obj = new HighlightGroupsCommandDescriptor();
                    break;
                case "DEDUP":
                    obj = new DedupCommandDescriptor();
                    break;
                case "TIME_STATS":
                    obj = new TimeStatsCommandDescriptor();
                    break;
                case "CLUSTER":
                    obj = new ClusterCommandDescriptor();
                    break;
                case "DELETE":
                    obj = new DeleteCommandDescriptor();
                    break;
                case "SEARCH":
                    obj = new SearchCommandDescriptor();
                    break;
                case "BUCKET":
                    obj = new BucketCommandDescriptor();
                    break;
                case "RARE":
                    obj = new RareCommandDescriptor();
                    break;
                case "ADD_INSIGHTS":
                    obj = new AddInsightsCommandDescriptor();
                    break;
                case "LINK":
                    obj = new LinkCommandDescriptor();
                    break;
                case "SORT":
                    obj = new SortCommandDescriptor();
                    break;
                case "HIGHLIGHT_ROWS":
                    obj = new HighlightRowsCommandDescriptor();
                    break;
                case "MACRO":
                    obj = new MacroCommandDescriptor();
                    break;
                case "EVAL":
                    obj = new EvalCommandDescriptor();
                    break;
                case "RENAME":
                    obj = new RenameCommandDescriptor();
                    break;
                case "XML_EXTRACT":
                    obj = new XmlExtractCommandDescriptor();
                    break;
                case "MULTI_SEARCH":
                    obj = new MultiSearchCommandDescriptor();
                    break;
                case "COMPARE":
                    obj = new CompareCommandDescriptor();
                    break;
                case "TIME_COMPARE":
                    obj = new TimeCompareCommandDescriptor();
                    break;
                case "MODULE":
                    obj = new ModuleCommandDescriptor();
                    break;
                case "REGEX":
                    obj = new RegexCommandDescriptor();
                    break;
                case "DELTA":
                    obj = new DeltaCommandDescriptor();
                    break;
                case "LOOKUP":
                    obj = new LookupCommandDescriptor();
                    break;
                case "JSON_EXTRACT":
                    obj = new JsonExtractCommandDescriptor();
                    break;
                case "EVENT_STATS":
                    obj = new EventStatsCommandDescriptor();
                    break;
                case "WHERE":
                    obj = new WhereCommandDescriptor();
                    break;
                case "CLUSTER_SPLIT":
                    obj = new ClusterSplitCommandDescriptor();
                    break;
                case "FREQUENT":
                    obj = new FrequentCommandDescriptor();
                    break;
                case "CLUSTER_DETAILS":
                    obj = new ClusterDetailsCommandDescriptor();
                    break;
                case "CLUSTER_COMPARE":
                    obj = new ClusterCompareCommandDescriptor();
                    break;
                case "COMMAND":
                    obj = new CommandDescriptor();
                    break;
                case "DISTINCT":
                    obj = new DistinctCommandDescriptor();
                    break;
                case "EXTRACT":
                    obj = new ExtractCommandDescriptor();
                    break;
                case "NLP":
                    obj = new NlpCommandDescriptor();
                    break;
                case "BOTTOM":
                    obj = new BottomCommandDescriptor();
                    break;
                case "FIELDS":
                    obj = new FieldsCommandDescriptor();
                    break;
                case "ANOMALY":
                    obj = new AnomalyCommandDescriptor();
                    break;
                case "CLASSIFY":
                    obj = new ClassifyCommandDescriptor();
                    break;
                case "LINK_DETAILS":
                    obj = new LinkDetailsCommandDescriptor();
                    break;
                case "SEARCH_LOOKUP":
                    obj = new SearchLookupCommandDescriptor();
                    break;
                case "HEAD":
                    obj = new HeadCommandDescriptor();
                    break;
                case "CREATE_VIEW":
                    obj = new CreateViewCommandDescriptor();
                    break;
                case "TIME_CLUSTER":
                    obj = new TimeClusterCommandDescriptor();
                    break;
                case "ADD_FIELDS":
                    obj = new AddFieldsCommandDescriptor();
                    break;
            }
            if (obj != null)
            {
                serializer.Populate(jsonObject.CreateReader(), obj);
            }
            else
            {
                logger.Warn($"The type {discriminator} is not present under AbstractCommandDescriptor! Returning null value.");
            }
            return obj;
        }
    }
}
