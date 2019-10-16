using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An audit comment associated with an issue
  /// </summary>
  [DataContract]
  public class IssueAuditComment {
    /// <summary>
    /// Gets or Sets AuditTime
    /// </summary>
    [DataMember(Name="auditTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auditTime")]
    public DateTime? AuditTime { get; set; }

    /// <summary>
    /// Gets or Sets Comment
    /// </summary>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets IssueEngineType
    /// </summary>
    [DataMember(Name="issueEngineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueEngineType")]
    public string IssueEngineType { get; set; }

    /// <summary>
    /// Gets or Sets IssueId
    /// </summary>
    [DataMember(Name="issueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueId")]
    public long? IssueId { get; set; }

    /// <summary>
    /// Gets or Sets IssueInstanceId
    /// </summary>
    [DataMember(Name="issueInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueInstanceId")]
    public string IssueInstanceId { get; set; }

    /// <summary>
    /// Gets or Sets IssueName
    /// </summary>
    [DataMember(Name="issueName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueName")]
    public string IssueName { get; set; }

    /// <summary>
    /// Gets or Sets ProjectName
    /// </summary>
    [DataMember(Name="projectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectName")]
    public string ProjectName { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionName
    /// </summary>
    [DataMember(Name="projectVersionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionName")]
    public string ProjectVersionName { get; set; }

    /// <summary>
    /// Gets or Sets SeqNumber
    /// </summary>
    [DataMember(Name="seqNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seqNumber")]
    public int? SeqNumber { get; set; }

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
      sb.Append("class IssueAuditComment {\n");
      sb.Append("  AuditTime: ").Append(AuditTime).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  IssueEngineType: ").Append(IssueEngineType).Append("\n");
      sb.Append("  IssueId: ").Append(IssueId).Append("\n");
      sb.Append("  IssueInstanceId: ").Append(IssueInstanceId).Append("\n");
      sb.Append("  IssueName: ").Append(IssueName).Append("\n");
      sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  ProjectVersionName: ").Append(ProjectVersionName).Append("\n");
      sb.Append("  SeqNumber: ").Append(SeqNumber).Append("\n");
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
