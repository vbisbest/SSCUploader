using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to replace application versions in the cloud pool
  /// </summary>
  [DataContract]
  public class CloudPoolProjectVersionReplaceRequest {
    /// <summary>
    /// List of application version ids to replace in cloud pool
    /// </summary>
    /// <value>List of application version ids to replace in cloud pool</value>
    [DataMember(Name="projectVersionIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionIds")]
    public List<long?> ProjectVersionIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPoolProjectVersionReplaceRequest {\n");
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
