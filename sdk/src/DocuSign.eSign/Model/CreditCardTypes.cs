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
    /// CreditCardTypes
    /// </summary>
    [DataContract]
    public partial class CreditCardTypes :  IEquatable<CreditCardTypes>, IValidatableObject
    {
        public CreditCardTypes()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardTypes" /> class.
        /// </summary>
        /// <param name="CardTypes">An array containing supported credit card types..</param>
        public CreditCardTypes(List<string> CardTypes = default(List<string>))
        {
            this.CardTypes = CardTypes;
        }
        
        /// <summary>
        /// An array containing supported credit card types.
        /// </summary>
        /// <value>An array containing supported credit card types.</value>
        [DataMember(Name="cardTypes", EmitDefaultValue=false)]
        public List<string> CardTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardTypes {\n");
            sb.Append("  CardTypes: ").Append(CardTypes).Append("\n");
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
            return this.Equals(obj as CreditCardTypes);
        }

        /// <summary>
        /// Returns true if CreditCardTypes instances are equal
        /// </summary>
        /// <param name="other">Instance of CreditCardTypes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardTypes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardTypes == other.CardTypes ||
                    this.CardTypes != null &&
                    this.CardTypes.SequenceEqual(other.CardTypes)
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
                if (this.CardTypes != null)
                    hash = hash * 59 + this.CardTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
