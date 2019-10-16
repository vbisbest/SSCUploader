using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// additional configuration needed for a plugin.
  /// </summary>
  [DataContract]
  public class PluginConfiguration {
    /// <summary>
    /// Gets or Sets ParameterName
    /// </summary>
    [DataMember(Name="parameterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterName")]
    public string ParameterName { get; set; }

    /// <summary>
    /// Gets or Sets ParameterType
    /// </summary>
    [DataMember(Name="parameterType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterType")]
    public string ParameterType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PluginConfiguration {\n");
      sb.Append("  ParameterName: ").Append(ParameterName).Append("\n");
      sb.Append("  ParameterType: ").Append(ParameterType).Append("\n");
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
