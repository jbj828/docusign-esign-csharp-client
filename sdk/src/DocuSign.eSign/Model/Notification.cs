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
    /// A complex element that specifies the notification options for the envelope. It consists of:  * useAccountDefaults - When set to **true**, the account default notification settings are used for the envelope.  * reminders - A complex element that specifies reminder settings for the envelope. It consists of:      * reminderEnabled - When set to **true**, a reminder message is sent to the recipient.    * reminderDelay - An interger that sets the number of days after the recipient receives the envelope that reminder emails are sent to the recipient.     * reminderFrequency - An interger that sets the interval, in days, between reminder emails.   * expirations - A complex element that specifies the expiration settings for the envelope. It consists of:     * expireEnabled - When set to **true**, the envelope expires (is no longer available for signing) in the set number of days. If false, the account default setting is used. If the account does not have an expiration setting, the DocuSign default value of 120 days is used.     * expireAfter - An integer that sets the number of days the envelope is active.    * expireWarn - An integer that sets the number of days before envelope expiration that an expiration warning email is sent to the recipient. If set to 0 (zero), no warning email is sent.
    /// </summary>
    [DataContract]
    public partial class Notification :  IEquatable<Notification>, IValidatableObject
    {
        public Notification()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="Expirations">Expirations.</param>
        /// <param name="Reminders">Reminders.</param>
        /// <param name="UseAccountDefaults">When set to **true**, the account default notification settings are used for the envelope..</param>
        public Notification(Expirations Expirations = default(Expirations), Reminders Reminders = default(Reminders), string UseAccountDefaults = default(string))
        {
            this.Expirations = Expirations;
            this.Reminders = Reminders;
            this.UseAccountDefaults = UseAccountDefaults;
        }
        
        /// <summary>
        /// Gets or Sets Expirations
        /// </summary>
        [DataMember(Name="expirations", EmitDefaultValue=false)]
        public Expirations Expirations { get; set; }
        /// <summary>
        /// Gets or Sets Reminders
        /// </summary>
        [DataMember(Name="reminders", EmitDefaultValue=false)]
        public Reminders Reminders { get; set; }
        /// <summary>
        /// When set to **true**, the account default notification settings are used for the envelope.
        /// </summary>
        /// <value>When set to **true**, the account default notification settings are used for the envelope.</value>
        [DataMember(Name="useAccountDefaults", EmitDefaultValue=false)]
        public string UseAccountDefaults { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Expirations: ").Append(Expirations).Append("\n");
            sb.Append("  Reminders: ").Append(Reminders).Append("\n");
            sb.Append("  UseAccountDefaults: ").Append(UseAccountDefaults).Append("\n");
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
            return this.Equals(obj as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="other">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Expirations == other.Expirations ||
                    this.Expirations != null &&
                    this.Expirations.Equals(other.Expirations)
                ) && 
                (
                    this.Reminders == other.Reminders ||
                    this.Reminders != null &&
                    this.Reminders.Equals(other.Reminders)
                ) && 
                (
                    this.UseAccountDefaults == other.UseAccountDefaults ||
                    this.UseAccountDefaults != null &&
                    this.UseAccountDefaults.Equals(other.UseAccountDefaults)
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
                if (this.Expirations != null)
                    hash = hash * 59 + this.Expirations.GetHashCode();
                if (this.Reminders != null)
                    hash = hash * 59 + this.Reminders.GetHashCode();
                if (this.UseAccountDefaults != null)
                    hash = hash * 59 + this.UseAccountDefaults.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
