using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to purge artifacts
  /// </summary>
  [DataContract]
  public class ArtifactPurgeRequest {
    /// <summary>
    /// List containing single artifact ID to purge
    /// </summary>
    /// <value>List containing single artifact ID to purge</value>
    [DataMember(Name="artifactIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactIds")]
    public List<long?> ArtifactIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArtifactPurgeRequest {\n");
      sb.Append("  ArtifactIds: ").Append(ArtifactIds).Append("\n");
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
