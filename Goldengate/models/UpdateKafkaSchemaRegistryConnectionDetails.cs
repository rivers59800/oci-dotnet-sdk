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


namespace Oci.GoldengateService.Models
{
    /// <summary>
    /// The information to update Kafka (e.g. Confluent) Schema Registry Connection.
    /// 
    /// </summary>
    public class UpdateKafkaSchemaRegistryConnectionDetails : UpdateConnectionDetails
    {
        
        /// <value>
        /// Kafka Schema Registry URL.
        /// e.g.: 'https://server1.us.oracle.com:8081'
        /// 
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }
        
        /// <value>
        /// Used authentication mechanism to access Schema Registry.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "authenticationType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<KafkaSchemaRegistryConnection.AuthenticationTypeEnum> AuthenticationType { get; set; }
        
        /// <value>
        /// The username to access Schema Registry using basic authentation.
        /// This value is injected into 'schema.registry.basic.auth.user.info=user:password' configuration property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }
        
        /// <value>
        /// The password to access Schema Registry using basic authentation.
        /// This value is injected into 'schema.registry.basic.auth.user.info=user:password' configuration property.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
        
        /// <value>
        /// The base64 encoded content of the TrustStore file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStore")]
        public string TrustStore { get; set; }
        
        /// <value>
        /// The TrustStore password.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "trustStorePassword")]
        public string TrustStorePassword { get; set; }
        
        /// <value>
        /// The base64 encoded content of the KeyStore file.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStore")]
        public string KeyStore { get; set; }
        
        /// <value>
        /// The KeyStore password.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "keyStorePassword")]
        public string KeyStorePassword { get; set; }
        
        /// <value>
        /// The password for the cert inside the KeyStore.
        /// In case it differs from the KeyStore password, it should be provided.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "sslKeyPassword")]
        public string SslKeyPassword { get; set; }
        
        /// <value>
        /// Deprecated: this field will be removed in future versions. Either specify the private IP in the connectionString or host 
        /// field, or make sure the host name is resolvable in the target VCN.
        /// <br/>
        /// The private IP address of the connection's endpoint in the customer's VCN, typically a
        /// database endpoint or a big data endpoint (e.g. Kafka bootstrap server).
        /// In case the privateIp is provided, the subnetId must also be provided.
        /// In case the privateIp (and the subnetId) is not provided it is assumed the datasource is publicly accessible.
        /// In case the connection is accessible only privately, the lack of privateIp will result in not being able to access the connection.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "privateIp")]
        public string PrivateIp { get; set; }
        
        [JsonProperty(PropertyName = "connectionType")]
        private readonly string connectionType = "KAFKA_SCHEMA_REGISTRY";
    }
}
