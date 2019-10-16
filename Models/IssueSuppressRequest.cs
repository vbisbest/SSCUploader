using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to suppress issues
  /// </summary>
  [DataContract]
  public class IssueSuppressRequest {
    /// <summary>
    /// Issues to suppress
    /// </summary>
    /// <value>Issues to suppress</value>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public List<EntityStateIdentifier> Issues { get; set; }

    /// <summary>
    /// Will suppress the issue
    /// </summary>
    /// <value>Will suppress the issue</value>
    [DataMember(Name="suppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressed")]
    public bool? Suppressed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueSuppressRequest {\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
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
