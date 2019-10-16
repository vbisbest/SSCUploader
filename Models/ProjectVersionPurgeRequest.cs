using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to purge the artifacts in application versions
  /// </summary>
  [DataContract]
  public class ProjectVersionPurgeRequest {
    /// <summary>
    /// List containing single application version ID to purge
    /// </summary>
    /// <value>List containing single application version ID to purge</value>
    [DataMember(Name="projectVersionIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionIds")]
    public List<long?> ProjectVersionIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionPurgeRequest {\n");
      sb.Append("  ProjectVersionIds: ").Append(ProjectVersionIds).Append("\n");
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
