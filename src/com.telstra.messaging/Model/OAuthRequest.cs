/* 
 * Telstra Messaging API
 *
 *  The Telstra SMS Messaging API allows your applications to send and receive SMS text messages from Australia's leading network operator.  It also allows your application to track the delivery status of both sent and received SMS messages. 
 *
 * OpenAPI spec version: 2.2.4
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = com.telstra.messaging.Client.SwaggerDateConverter;

namespace com.telstra.messaging.Model
{
    /// <summary>
    /// OAuthRequest
    /// </summary>
    [DataContract]
    public partial class OAuthRequest :  IEquatable<OAuthRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthRequest" /> class.
        /// </summary>
        /// <param name="ClientId">Client id (required).</param>
        /// <param name="ClientSecret">Client secret (required).</param>
        /// <param name="GrantType">OAuth grant type (required).</param>
        /// <param name="Scopes">OAuth scope (required).</param>
        public OAuthRequest(string ClientId = default(string), string ClientSecret = default(string), string GrantType = default(string), string Scopes = default(string))
        {
            // to ensure "ClientId" is required (not null)
            if (ClientId == null)
            {
                throw new InvalidDataException("ClientId is a required property for OAuthRequest and cannot be null");
            }
            else
            {
                this.ClientId = ClientId;
            }
            // to ensure "ClientSecret" is required (not null)
            if (ClientSecret == null)
            {
                throw new InvalidDataException("ClientSecret is a required property for OAuthRequest and cannot be null");
            }
            else
            {
                this.ClientSecret = ClientSecret;
            }
            // to ensure "GrantType" is required (not null)
            if (GrantType == null)
            {
                throw new InvalidDataException("GrantType is a required property for OAuthRequest and cannot be null");
            }
            else
            {
                this.GrantType = GrantType;
            }
            // to ensure "Scopes" is required (not null)
            if (Scopes == null)
            {
                throw new InvalidDataException("Scopes is a required property for OAuthRequest and cannot be null");
            }
            else
            {
                this.Scopes = Scopes;
            }
        }
        
        /// <summary>
        /// Client id
        /// </summary>
        /// <value>Client id</value>
        [DataMember(Name="client_id", EmitDefaultValue=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Client secret
        /// </summary>
        /// <value>Client secret</value>
        [DataMember(Name="client_secret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// OAuth grant type
        /// </summary>
        /// <value>OAuth grant type</value>
        [DataMember(Name="grant_type", EmitDefaultValue=false)]
        public string GrantType { get; set; }

        /// <summary>
        /// OAuth scope
        /// </summary>
        /// <value>OAuth scope</value>
        [DataMember(Name="scopes", EmitDefaultValue=false)]
        public string Scopes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OAuthRequest);
        }

        /// <summary>
        /// Returns true if OAuthRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
                ) && 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.Scopes == input.Scopes ||
                    (this.Scopes != null &&
                    this.Scopes.Equals(input.Scopes))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                if (this.GrantType != null)
                    hashCode = hashCode * 59 + this.GrantType.GetHashCode();
                if (this.Scopes != null)
                    hashCode = hashCode * 59 + this.Scopes.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
