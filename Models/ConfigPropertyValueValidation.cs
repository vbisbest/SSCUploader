using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// SSC configuration property value validation type
  /// </summary>
  [DataContract]
  public class ConfigPropertyValueValidation {
    /// <summary>
    /// Gets or Sets ValidationType
    /// </summary>
    [DataMember(Name="validationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationType")]
    public string ValidationType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigPropertyValueValidation {\n");
      sb.Append("  ValidationType: ").Append(ValidationType).Append("\n");
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
