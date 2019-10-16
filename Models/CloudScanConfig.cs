using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloud Scan Config DTO object
  /// </summary>
  [DataContract]
  public class CloudScanConfig {
    /// <summary>
    /// Gets or Sets CloudScanEnabled
    /// </summary>
    [DataMember(Name="cloudScanEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cloudScanEnabled")]
    public bool? CloudScanEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudScanConfig {\n");
      sb.Append("  CloudScanEnabled: ").Append(CloudScanEnabled).Append("\n");
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
