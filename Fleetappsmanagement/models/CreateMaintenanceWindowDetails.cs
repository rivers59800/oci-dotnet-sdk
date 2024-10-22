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


namespace Oci.FleetappsmanagementService.Models
{
    /// <summary>
    /// The information about the new MaintenanceWindow.
    /// </summary>
    public class CreateMaintenanceWindowDetails 
    {
        
        /// <value>
        /// Tenancy OCID
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// Example: My new resource
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// A user-friendly description. To provide some insight about the resource.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Does the maintenenace window cause outage?
        /// An outage indicates whether a maintenance window can consider operations that require downtime.
        /// It means a period when the application is not accessible.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isOutage")]
        public System.Nullable<bool> IsOutage { get; set; }
        
        /// <value>
        /// Type of maintenenace window
        /// </value>
        [JsonProperty(PropertyName = "maintenanceWindowType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MaintenanceWindowType> MaintenanceWindowType { get; set; }
        
        /// <value>
        /// Specify the date and time of the day that the maintenance window starts.
        /// </value>
        [JsonProperty(PropertyName = "timeScheduleStart")]
        public System.Nullable<System.DateTime> TimeScheduleStart { get; set; }
        
        /// <value>
        /// Duration of the maintenance window.
        /// Specify how long the maintenance window remains open.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Duration is required.")]
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }
        
        /// <value>
        /// Is this a recurring maintenance window?
        /// </value>
        [JsonProperty(PropertyName = "isRecurring")]
        public System.Nullable<bool> IsRecurring { get; set; }
        
        /// <value>
        /// Recurrence rule specification if maintenance window recurring.
        /// Specify the frequency of running the maintenance window.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "recurrences")]
        public string Recurrences { get; set; }
        
        /// <value>
        /// Task initiation cutoff time for the maintenance window.
        /// </value>
        [JsonProperty(PropertyName = "taskInitiationCutoff")]
        public System.Nullable<int> TaskInitiationCutoff { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
