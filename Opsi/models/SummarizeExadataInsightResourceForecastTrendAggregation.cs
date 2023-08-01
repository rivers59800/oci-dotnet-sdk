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


namespace Oci.OpsiService.Models
{
    /// <summary>
    /// Usage and Forecast results from the selected time period.
    /// </summary>
    public class SummarizeExadataInsightResourceForecastTrendAggregation 
    {
        
        /// <value>
        /// The start timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalStart is required.")]
        [JsonProperty(PropertyName = "timeIntervalStart")]
        public System.Nullable<System.DateTime> TimeIntervalStart { get; set; }
        
        /// <value>
        /// The end timestamp that was passed into the request.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeIntervalEnd is required.")]
        [JsonProperty(PropertyName = "timeIntervalEnd")]
        public System.Nullable<System.DateTime> TimeIntervalEnd { get; set; }
                ///
        /// <value>
        /// Defines the type of exadata resource metric (Example: CPU, STORAGE)
        /// </value>
        ///
        public enum ExadataResourceMetricEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CPU")]
            Cpu,
            [EnumMember(Value = "STORAGE")]
            Storage,
            [EnumMember(Value = "IO")]
            Io,
            [EnumMember(Value = "MEMORY")]
            Memory,
            [EnumMember(Value = "IOPS")]
            Iops,
            [EnumMember(Value = "THROUGHPUT")]
            Throughput
        };

        /// <value>
        /// Defines the type of exadata resource metric (Example: CPU, STORAGE)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataResourceMetric is required.")]
        [JsonProperty(PropertyName = "exadataResourceMetric")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExadataResourceMetricEnum> ExadataResourceMetric { get; set; }
                ///
        /// <value>
        /// Defines the resource type for an exadata  (Example: DATABASE, STORAGE_SERVER, HOST, DISKGROUP)
        /// </value>
        ///
        public enum ExadataResourceTypeEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "DATABASE")]
            Database,
            [EnumMember(Value = "HOST")]
            Host,
            [EnumMember(Value = "STORAGE_SERVER")]
            StorageServer,
            [EnumMember(Value = "DISKGROUP")]
            Diskgroup
        };

        /// <value>
        /// Defines the resource type for an exadata  (Example: DATABASE, STORAGE_SERVER, HOST, DISKGROUP)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ExadataResourceType is required.")]
        [JsonProperty(PropertyName = "exadataResourceType")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<ExadataResourceTypeEnum> ExadataResourceType { get; set; }
                ///
        /// <value>
        /// Displays usage unit ( CORES, GB , PERCENT, MBPS)
        /// </value>
        ///
        public enum UsageUnitEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "CORES")]
            Cores,
            [EnumMember(Value = "GB")]
            Gb,
            [EnumMember(Value = "MBPS")]
            Mbps,
            [EnumMember(Value = "IOPS")]
            Iops,
            [EnumMember(Value = "PERCENT")]
            Percent
        };

        /// <value>
        /// Displays usage unit ( CORES, GB , PERCENT, MBPS)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UsageUnit is required.")]
        [JsonProperty(PropertyName = "usageUnit")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<UsageUnitEnum> UsageUnit { get; set; }
        
        /// <value>
        /// Auto-ML algorithm leveraged for the forecast. Only applicable for Auto-ML forecast.
        /// </value>
        [JsonProperty(PropertyName = "selectedForecastAlgorithm")]
        public string SelectedForecastAlgorithm { get; set; }
                ///
        /// <value>
        /// Time series patterns used in the forecasting.
        /// </value>
        ///
        public enum PatternEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LINEAR")]
            Linear,
            [EnumMember(Value = "MONTHLY_SEASONS")]
            MonthlySeasons,
            [EnumMember(Value = "MONTHLY_AND_YEARLY_SEASONS")]
            MonthlyAndYearlySeasons,
            [EnumMember(Value = "WEEKLY_SEASONS")]
            WeeklySeasons,
            [EnumMember(Value = "WEEKLY_AND_MONTHLY_SEASONS")]
            WeeklyAndMonthlySeasons,
            [EnumMember(Value = "WEEKLY_MONTHLY_AND_YEARLY_SEASONS")]
            WeeklyMonthlyAndYearlySeasons,
            [EnumMember(Value = "WEEKLY_AND_YEARLY_SEASONS")]
            WeeklyAndYearlySeasons,
            [EnumMember(Value = "YEARLY_SEASONS")]
            YearlySeasons
        };

        /// <value>
        /// Time series patterns used in the forecasting.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Pattern is required.")]
        [JsonProperty(PropertyName = "pattern")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<PatternEnum> Pattern { get; set; }
        
        /// <value>
        /// Days to reach capacity for a storage server
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DaysToReachCapacity is required.")]
        [JsonProperty(PropertyName = "daysToReachCapacity")]
        public System.Nullable<int> DaysToReachCapacity { get; set; }
        
        /// <value>
        /// Time series data used for the forecast analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HistoricalData is required.")]
        [JsonProperty(PropertyName = "historicalData")]
        public System.Collections.Generic.List<HistoricalDataItem> HistoricalData { get; set; }
        
        /// <value>
        /// Time series data result of the forecasting analysis.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ProjectedData is required.")]
        [JsonProperty(PropertyName = "projectedData")]
        public System.Collections.Generic.List<ProjectedDataItem> ProjectedData { get; set; }
        
    }
}
