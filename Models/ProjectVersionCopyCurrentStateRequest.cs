using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to copy the current state from one application version to another
  /// </summary>
  [DataContract]
  public class ProjectVersionCopyCurrentStateRequest {
    /// <summary>
    /// Will copy current state fpr
    /// </summary>
    /// <value>Will copy current state fpr</value>
    [DataMember(Name="copyCurrentStateFpr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copyCurrentStateFpr")]
    public bool? CopyCurrentStateFpr { get; set; }

    /// <summary>
    /// Previous application version id
    /// </summary>
    /// <value>Previous application version id</value>
    [DataMember(Name="previousProjectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousProjectVersionId")]
    public long? PreviousProjectVersionId { get; set; }

    /// <summary>
    /// Application version id
    /// </summary>
    /// <value>Application version id</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionCopyCurrentStateRequest {\n");
      sb.Append("  CopyCurrentStateFpr: ").Append(CopyCurrentStateFpr).Append("\n");
      sb.Append("  PreviousProjectVersionId: ").Append(PreviousProjectVersionId).Append("\n");
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
