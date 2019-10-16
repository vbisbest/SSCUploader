using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to approve artifact
  /// </summary>
  [DataContract]
  public class ArtifactApproveRequest {
    /// <summary>
    /// List containing single artifact ID to approve
    /// </summary>
    /// <value>List containing single artifact ID to approve</value>
    [DataMember(Name="artifactIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactIds")]
    public List<long?> ArtifactIds { get; set; }

    /// <summary>
    /// Approval comments
    /// </summary>
    /// <value>Approval comments</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArtifactApproveRequest {\n");
      sb.Append("  ArtifactIds: ").Append(ArtifactIds).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
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
