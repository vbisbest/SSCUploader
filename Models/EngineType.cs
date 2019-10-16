using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Types of the analyzers (engines) that produces issues
  /// </summary>
  [DataContract]
  public class EngineType {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ServedByPlugin
    /// </summary>
    [DataMember(Name="servedByPlugin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "servedByPlugin")]
    public bool? ServedByPlugin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EngineType {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ServedByPlugin: ").Append(ServedByPlugin).Append("\n");
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
