using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Dynamic Scan Request Template object
  /// </summary>
  [DataContract]
  public class DynamicScanRequestTemplate {
    /// <summary>
    /// Parameters that are needed for dynamic scan request
    /// </summary>
    /// <value>Parameters that are needed for dynamic scan request</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<DynamicScanRequestParameter> Parameters { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicScanRequestTemplate {\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
