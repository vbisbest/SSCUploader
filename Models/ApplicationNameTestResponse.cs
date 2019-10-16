using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response of testing whether application exists
  /// </summary>
  [DataContract]
  public class ApplicationNameTestResponse {
    /// <summary>
    /// If application founds
    /// </summary>
    /// <value>If application founds</value>
    [DataMember(Name="found", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "found")]
    public bool? Found { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationNameTestResponse {\n");
      sb.Append("  Found: ").Append(Found).Append("\n");
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
