using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// WebInspect enterprise configuration object
  /// </summary>
  [DataContract]
  public class WIEConfiguration {
    /// <summary>
    /// WebInspect Enterprise url
    /// </summary>
    /// <value>WebInspect Enterprise url</value>
    [DataMember(Name="wieInstanceUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wieInstanceUrl")]
    public string WieInstanceUrl { get; set; }

    /// <summary>
    /// Set to true if WebInspect Enterprise is registered
    /// </summary>
    /// <value>Set to true if WebInspect Enterprise is registered</value>
    [DataMember(Name="wieRegistered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wieRegistered")]
    public bool? WieRegistered { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WIEConfiguration {\n");
      sb.Append("  WieInstanceUrl: ").Append(WieInstanceUrl).Append("\n");
      sb.Append("  WieRegistered: ").Append(WieRegistered).Append("\n");
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
