using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Validation Status DTO object
  /// </summary>
  [DataContract]
  public class ValidationStatus {
    /// <summary>
    /// Validation status message
    /// </summary>
    /// <value>Validation status message</value>
    [DataMember(Name="msg", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "msg")]
    public string Msg { get; set; }

    /// <summary>
    /// Indicates whether validation was successful
    /// </summary>
    /// <value>Indicates whether validation was successful</value>
    [DataMember(Name="valid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valid")]
    public bool? Valid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValidationStatus {\n");
      sb.Append("  Msg: ").Append(Msg).Append("\n");
      sb.Append("  Valid: ").Append(Valid).Append("\n");
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
