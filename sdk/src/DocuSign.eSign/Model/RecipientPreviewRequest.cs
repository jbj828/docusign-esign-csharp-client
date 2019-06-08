/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// RecipientPreviewRequest
    /// </summary>
    [DataContract]
    public partial class RecipientPreviewRequest :  IEquatable<RecipientPreviewRequest>, IValidatableObject
    {
        public RecipientPreviewRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientPreviewRequest" /> class.
        /// </summary>
        /// <param name="AssertionId">.</param>
        /// <param name="AuthenticationInstant">.</param>
        /// <param name="AuthenticationMethod">.</param>
        /// <param name="PingFrequency">.</param>
        /// <param name="PingUrl">.</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="ReturnUrl">.</param>
        /// <param name="SecurityDomain">.</param>
        /// <param name="XFrameOptions">.</param>
        /// <param name="XFrameOptionsAllowFromUrl">.</param>
        public RecipientPreviewRequest(string AssertionId = default(string), string AuthenticationInstant = default(string), string AuthenticationMethod = default(string), string PingFrequency = default(string), string PingUrl = default(string), string RecipientId = default(string), string ReturnUrl = default(string), string SecurityDomain = default(string), string XFrameOptions = default(string), string XFrameOptionsAllowFromUrl = default(string))
        {
            this.AssertionId = AssertionId;
            this.AuthenticationInstant = AuthenticationInstant;
            this.AuthenticationMethod = AuthenticationMethod;
            this.PingFrequency = PingFrequency;
            this.PingUrl = PingUrl;
            this.RecipientId = RecipientId;
            this.ReturnUrl = ReturnUrl;
            this.SecurityDomain = SecurityDomain;
            this.XFrameOptions = XFrameOptions;
            this.XFrameOptionsAllowFromUrl = XFrameOptionsAllowFromUrl;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="assertionId", EmitDefaultValue=false)]
        public string AssertionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="authenticationInstant", EmitDefaultValue=false)]
        public string AuthenticationInstant { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
        public string AuthenticationMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pingFrequency", EmitDefaultValue=false)]
        public string PingFrequency { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pingUrl", EmitDefaultValue=false)]
        public string PingUrl { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="returnUrl", EmitDefaultValue=false)]
        public string ReturnUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="securityDomain", EmitDefaultValue=false)]
        public string SecurityDomain { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="xFrameOptions", EmitDefaultValue=false)]
        public string XFrameOptions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="xFrameOptionsAllowFromUrl", EmitDefaultValue=false)]
        public string XFrameOptionsAllowFromUrl { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientPreviewRequest {\n");
            sb.Append("  AssertionId: ").Append(AssertionId).Append("\n");
            sb.Append("  AuthenticationInstant: ").Append(AuthenticationInstant).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
            sb.Append("  PingFrequency: ").Append(PingFrequency).Append("\n");
            sb.Append("  PingUrl: ").Append(PingUrl).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  SecurityDomain: ").Append(SecurityDomain).Append("\n");
            sb.Append("  XFrameOptions: ").Append(XFrameOptions).Append("\n");
            sb.Append("  XFrameOptionsAllowFromUrl: ").Append(XFrameOptionsAllowFromUrl).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecipientPreviewRequest);
        }

        /// <summary>
        /// Returns true if RecipientPreviewRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientPreviewRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientPreviewRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssertionId == other.AssertionId ||
                    this.AssertionId != null &&
                    this.AssertionId.Equals(other.AssertionId)
                ) && 
                (
                    this.AuthenticationInstant == other.AuthenticationInstant ||
                    this.AuthenticationInstant != null &&
                    this.AuthenticationInstant.Equals(other.AuthenticationInstant)
                ) && 
                (
                    this.AuthenticationMethod == other.AuthenticationMethod ||
                    this.AuthenticationMethod != null &&
                    this.AuthenticationMethod.Equals(other.AuthenticationMethod)
                ) && 
                (
                    this.PingFrequency == other.PingFrequency ||
                    this.PingFrequency != null &&
                    this.PingFrequency.Equals(other.PingFrequency)
                ) && 
                (
                    this.PingUrl == other.PingUrl ||
                    this.PingUrl != null &&
                    this.PingUrl.Equals(other.PingUrl)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.ReturnUrl == other.ReturnUrl ||
                    this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(other.ReturnUrl)
                ) && 
                (
                    this.SecurityDomain == other.SecurityDomain ||
                    this.SecurityDomain != null &&
                    this.SecurityDomain.Equals(other.SecurityDomain)
                ) && 
                (
                    this.XFrameOptions == other.XFrameOptions ||
                    this.XFrameOptions != null &&
                    this.XFrameOptions.Equals(other.XFrameOptions)
                ) && 
                (
                    this.XFrameOptionsAllowFromUrl == other.XFrameOptionsAllowFromUrl ||
                    this.XFrameOptionsAllowFromUrl != null &&
                    this.XFrameOptionsAllowFromUrl.Equals(other.XFrameOptionsAllowFromUrl)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AssertionId != null)
                    hash = hash * 59 + this.AssertionId.GetHashCode();
                if (this.AuthenticationInstant != null)
                    hash = hash * 59 + this.AuthenticationInstant.GetHashCode();
                if (this.AuthenticationMethod != null)
                    hash = hash * 59 + this.AuthenticationMethod.GetHashCode();
                if (this.PingFrequency != null)
                    hash = hash * 59 + this.PingFrequency.GetHashCode();
                if (this.PingUrl != null)
                    hash = hash * 59 + this.PingUrl.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.ReturnUrl != null)
                    hash = hash * 59 + this.ReturnUrl.GetHashCode();
                if (this.SecurityDomain != null)
                    hash = hash * 59 + this.SecurityDomain.GetHashCode();
                if (this.XFrameOptions != null)
                    hash = hash * 59 + this.XFrameOptions.GetHashCode();
                if (this.XFrameOptionsAllowFromUrl != null)
                    hash = hash * 59 + this.XFrameOptionsAllowFromUrl.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
