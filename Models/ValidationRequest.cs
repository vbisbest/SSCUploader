using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Validation Request DTO object
  /// </summary>
  [DataContract]
  public class ValidationRequest {
    /// <summary>
    /// String to validate
    /// </summary>
    /// <value>String to validate</value>
    [DataMember(Name="stringToValidate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stringToValidate")]
    public string StringToValidate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValidationRequest {\n");
      sb.Append("  StringToValidate: ").Append(StringToValidate).Append("\n");
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
