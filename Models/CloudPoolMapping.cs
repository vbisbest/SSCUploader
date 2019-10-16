using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application version to CloudScan pool mapping
  /// </summary>
  [DataContract]
  public class CloudPoolMapping {
    /// <summary>
    /// Gets or Sets CloudPool
    /// </summary>
    [DataMember(Name="cloudPool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cloudPool")]
    public CloudPool CloudPool { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPoolMapping {\n");
      sb.Append("  CloudPool: ").Append(CloudPool).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
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
