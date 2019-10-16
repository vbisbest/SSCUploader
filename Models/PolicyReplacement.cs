using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Audit Assistant prediction policy replacement mapping
  /// </summary>
  [DataContract]
  public class PolicyReplacement {
    /// <summary>
    /// Gets or Sets FromPolicy
    /// </summary>
    [DataMember(Name="fromPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromPolicy")]
    public string FromPolicy { get; set; }

    /// <summary>
    /// Gets or Sets ToPolicy
    /// </summary>
    [DataMember(Name="toPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toPolicy")]
    public string ToPolicy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyReplacement {\n");
      sb.Append("  FromPolicy: ").Append(FromPolicy).Append("\n");
      sb.Append("  ToPolicy: ").Append(ToPolicy).Append("\n");
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
