using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// External Bug Info DTO object
  /// </summary>
  [DataContract]
  public class ExternalBugInfo {
    /// <summary>
    /// Link to a bug the user can navigate to by clicking the link
    /// </summary>
    /// <value>Link to a bug the user can navigate to by clicking the link</value>
    [DataMember(Name="externalBugDeepLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalBugDeepLink")]
    public string ExternalBugDeepLink { get; set; }

    /// <summary>
    /// ID of the bug
    /// </summary>
    /// <value>ID of the bug</value>
    [DataMember(Name="externalBugId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalBugId")]
    public string ExternalBugId { get; set; }

    /// <summary>
    /// True if user wants to file a bug for all selected issues in UI
    /// </summary>
    /// <value>True if user wants to file a bug for all selected issues in UI</value>
    [DataMember(Name="fileBugForSelectAll", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileBugForSelectAll")]
    public bool? FileBugForSelectAll { get; set; }

    /// <summary>
    /// Count of issues for which a bug is filed
    /// </summary>
    /// <value>Count of issues for which a bug is filed</value>
    [DataMember(Name="issueCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueCount")]
    public long? IssueCount { get; set; }

    /// <summary>
    /// List of Issue Instance IDs
    /// </summary>
    /// <value>List of Issue Instance IDs</value>
    [DataMember(Name="issueInstanceIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueInstanceIds")]
    public List<string> IssueInstanceIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExternalBugInfo {\n");
      sb.Append("  ExternalBugDeepLink: ").Append(ExternalBugDeepLink).Append("\n");
      sb.Append("  ExternalBugId: ").Append(ExternalBugId).Append("\n");
      sb.Append("  FileBugForSelectAll: ").Append(FileBugForSelectAll).Append("\n");
      sb.Append("  IssueCount: ").Append(IssueCount).Append("\n");
      sb.Append("  IssueInstanceIds: ").Append(IssueInstanceIds).Append("\n");
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
