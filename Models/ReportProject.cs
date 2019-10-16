using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Report application DTO object
  /// </summary>
  [DataContract]
  public class ReportProject {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Count of application versions
    /// </summary>
    /// <value>Count of application versions</value>
    [DataMember(Name="projectVersionsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionsCount")]
    public int? ProjectVersionsCount { get; set; }

    /// <summary>
    /// List of report application versions
    /// </summary>
    /// <value>List of report application versions</value>
    [DataMember(Name="versions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versions")]
    public List<ReportProjectVersion> Versions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportProject {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProjectVersionsCount: ").Append(ProjectVersionsCount).Append("\n");
      sb.Append("  Versions: ").Append(Versions).Append("\n");
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
