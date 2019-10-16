using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application version issue group DTO object
  /// </summary>
  [DataContract]
  public class ProjectVersionIssueGroup {
    /// <summary>
    /// Audited issue count
    /// </summary>
    /// <value>Audited issue count</value>
    [DataMember(Name="auditedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auditedCount")]
    public int? AuditedCount { get; set; }

    /// <summary>
    /// Issue group name not containing count, dashes etc
    /// </summary>
    /// <value>Issue group name not containing count, dashes etc</value>
    [DataMember(Name="cleanName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanName")]
    public string CleanName { get; set; }

    /// <summary>
    /// Identifier
    /// </summary>
    /// <value>Identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Issue group name
    /// </summary>
    /// <value>Issue group name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Issue total count
    /// </summary>
    /// <value>Issue total count</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Visible issues count
    /// </summary>
    /// <value>Visible issues count</value>
    [DataMember(Name="visibleCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibleCount")]
    public int? VisibleCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionIssueGroup {\n");
      sb.Append("  AuditedCount: ").Append(AuditedCount).Append("\n");
      sb.Append("  CleanName: ").Append(CleanName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  VisibleCount: ").Append(VisibleCount).Append("\n");
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
