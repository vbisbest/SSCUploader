using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// counts of issues assigned to user
  /// </summary>
  [DataContract]
  public class IssueAssignment {
    /// <summary>
    /// total number of issues assigned to user across all application versions
    /// </summary>
    /// <value>total number of issues assigned to user across all application versions</value>
    [DataMember(Name="issueCountAllProjectVer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueCountAllProjectVer")]
    public int? IssueCountAllProjectVer { get; set; }

    /// <summary>
    /// number of issues assigned to user in current application version
    /// </summary>
    /// <value>number of issues assigned to user in current application version</value>
    [DataMember(Name="issueCountCertainProjectVer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueCountCertainProjectVer")]
    public int? IssueCountCertainProjectVer { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAssignment {\n");
      sb.Append("  IssueCountAllProjectVer: ").Append(IssueCountAllProjectVer).Append("\n");
      sb.Append("  IssueCountCertainProjectVer: ").Append(IssueCountCertainProjectVer).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
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
