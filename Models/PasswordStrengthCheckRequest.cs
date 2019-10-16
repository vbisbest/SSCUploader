using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Password strength check request
  /// </summary>
  [DataContract]
  public class PasswordStrengthCheckRequest {
    /// <summary>
    /// Get additional words to add to dictionary. If null, current user data will be added (for example: username, first name, last name, email).
    /// </summary>
    /// <value>Get additional words to add to dictionary. If null, current user data will be added (for example: username, first name, last name, email).</value>
    [DataMember(Name="extraDictionary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraDictionary")]
    public List<string> ExtraDictionary { get; set; }

    /// <summary>
    /// Get password or its part from input
    /// </summary>
    /// <value>Get password or its part from input</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PasswordStrengthCheckRequest {\n");
      sb.Append("  ExtraDictionary: ").Append(ExtraDictionary).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
