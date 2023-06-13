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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Details of the request to start JFR recordings.
    /// When the targets aren't specified, then all managed instances currently in the Fleet are selected.
    /// 
    /// </summary>
    public class RequestJfrRecordingsDetails 
    {
        
        /// <value>
        /// The attachment targets to start JFR.
        /// </value>
        [JsonProperty(PropertyName = "targets")]
        public System.Collections.Generic.List<JfrAttachmentTarget> Targets { get; set; }
        
        /// <value>
        /// The profile used for JFR events selection. If the name isn't recognized, the settings from jfcV1 or jfcV2
        /// will be used depending on the JVM version.
        /// Both jfcV2 and jfcV1 should be provided to ensure JFR collection on different JVM versions.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "JfcProfileName is required.")]
        [JsonProperty(PropertyName = "jfcProfileName")]
        public string JfcProfileName { get; set; }
        
        /// <value>
        /// The BASE64 encoded string of JFR settings XML with schema used by JDK 8.
        /// </value>
        [JsonProperty(PropertyName = "jfcV1")]
        public string JfcV1 { get; set; }
        
        /// <value>
        /// The BASE64 encoded string of JFR settings XML with [schema used by JDK 9 and after](https://raw.githubusercontent.com/openjdk/jdk/master/src/jdk.jfr/share/classes/jdk/jfr/internal/jfc/jfc.xsd).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "jfcV2")]
        public string JfcV2 { get; set; }
        
        /// <value>
        /// Duration of the JFR recording in minutes.
        /// </value>
        [JsonProperty(PropertyName = "recordingDurationInMinutes")]
        public System.Nullable<int> RecordingDurationInMinutes { get; set; }
        
        /// <value>
        /// The maximum size limit for the JFR file collected.
        /// </value>
        [JsonProperty(PropertyName = "recordingSizeInMb")]
        public System.Nullable<int> RecordingSizeInMb { get; set; }
        
        /// <value>
        /// Period to looking for JVMs. In addition to attach to running JVMs when given the command,
        /// JVM started within the waiting period will also be attached for JFR. The value should be
        /// larger than the agent polling interval setting for the fleet to ensure agent can get the
        /// instructions. If not specified, the agent polling interval for the fleet is used.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "waitingPeriodInMinutes")]
        public System.Nullable<int> WaitingPeriodInMinutes { get; set; }
        
    }
}
