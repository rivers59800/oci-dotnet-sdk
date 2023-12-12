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


namespace Oci.DataintegrationService.Models
{
    /// <summary>
    /// Data Entity clause for Incremental Read operation.
    /// </summary>
    public class IncrementalDataEntityClause 
    {
        
        /// <value>
        /// Name of incremental data entity filter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncrementalDataEntityName is required.")]
        [JsonProperty(PropertyName = "incrementalDataEntityName")]
        public string IncrementalDataEntityName { get; set; }
        
        /// <value>
        /// Value of incremental data entity filter.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncrementalDataEntityValue is required.")]
        [JsonProperty(PropertyName = "incrementalDataEntityValue")]
        public System.Collections.Generic.Dictionary<string, string> IncrementalDataEntityValue { get; set; }
                ///
        /// <value>
        /// Incremental comparator symbol.
        /// </value>
        ///
        public enum IncrementalComparatorEnum {
            /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
            [EnumMember(Value = null)]
            UnknownEnumValue,
            [EnumMember(Value = "LESSTHAN")]
            Lessthan,
            [EnumMember(Value = "GREATERTHAN")]
            Greaterthan,
            [EnumMember(Value = "EQUALS")]
            Equals,
            [EnumMember(Value = "LESSTHANEQUALS")]
            Lessthanequals,
            [EnumMember(Value = "GREATERTHANEQUALS")]
            Greaterthanequals,
            [EnumMember(Value = "STARTSWITH")]
            Startswith,
            [EnumMember(Value = "CONTAINS")]
            Contains
        };

        /// <value>
        /// Incremental comparator symbol.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "IncrementalComparator is required.")]
        [JsonProperty(PropertyName = "incrementalComparator")]
        [JsonConverter(typeof(Oci.Common.Utils.ResponseEnumConverter))]
        public System.Nullable<IncrementalComparatorEnum> IncrementalComparator { get; set; }
        
    }
}
