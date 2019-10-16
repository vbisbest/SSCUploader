using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to check whether a application version already exists in the system
  /// </summary>
  [DataContract]
  public class ProjectVersionTestRequest {
    /// <summary>
    /// Application name to search
    /// </summary>
    /// <value>Application name to search</value>
    [DataMember(Name="projectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectName")]
    public string ProjectName { get; set; }

    /// <summary>
    /// Application version name to search
    /// </summary>
    /// <value>Application version name to search</value>
    [DataMember(Name="projectVersionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionName")]
    public string ProjectVersionName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionTestRequest {\n");
      sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
      sb.Append("  ProjectVersionName: ").Append(ProjectVersionName).Append("\n");
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
