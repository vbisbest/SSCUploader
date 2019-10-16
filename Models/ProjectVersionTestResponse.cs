using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response of testing whether application version with name and exists in specified application
  /// </summary>
  [DataContract]
  public class ProjectVersionTestResponse {
    /// <summary>
    /// Whether the application version was found
    /// </summary>
    /// <value>Whether the application version was found</value>
    [DataMember(Name="found", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "found")]
    public bool? Found { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionTestResponse {\n");
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
