using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class IidMapping {
    /// <summary>
    /// Gets or Sets FromIid
    /// </summary>
    [DataMember(Name="fromIid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromIid")]
    public string FromIid { get; set; }

    /// <summary>
    /// Gets or Sets ToIid
    /// </summary>
    [DataMember(Name="toIid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toIid")]
    public string ToIid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IidMapping {\n");
      sb.Append("  FromIid: ").Append(FromIid).Append("\n");
      sb.Append("  ToIid: ").Append(ToIid).Append("\n");
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
