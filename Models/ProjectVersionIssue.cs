using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application version issue DTO object
  /// </summary>
  [DataContract]
  public class ProjectVersionIssue {
    /// <summary>
    /// Analyzer
    /// </summary>
    /// <value>Analyzer</value>
    [DataMember(Name="analyzer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analyzer")]
    public string Analyzer { get; set; }

    /// <summary>
    /// Flag is set for issues that has been audited and primary tag value was set for this issue.
    /// </summary>
    /// <value>Flag is set for issues that has been audited and primary tag value was set for this issue.</value>
    [DataMember(Name="audited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "audited")]
    public bool? Audited { get; set; }

    /// <summary>
    /// Bug url
    /// </summary>
    /// <value>Bug url</value>
    [DataMember(Name="bugURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugURL")]
    public string BugURL { get; set; }

    /// <summary>
    /// Issue confidence
    /// </summary>
    /// <value>Issue confidence</value>
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidence")]
    public float? Confidence { get; set; }

    /// <summary>
    /// Display name for engine type
    /// </summary>
    /// <value>Display name for engine type</value>
    [DataMember(Name="displayEngineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayEngineType")]
    public string DisplayEngineType { get; set; }

    /// <summary>
    /// Engine category
    /// </summary>
    /// <value>Engine category</value>
    [DataMember(Name="engineCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineCategory")]
    public string EngineCategory { get; set; }

    /// <summary>
    /// Engine type
    /// </summary>
    /// <value>Engine type</value>
    [DataMember(Name="engineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineType")]
    public string EngineType { get; set; }

    /// <summary>
    /// Identifying information for the bug in the external bug tracking system. The actual format depends on the bug tracker plugin which filed the bug.
    /// </summary>
    /// <value>Identifying information for the bug in the external bug tracking system. The actual format depends on the bug tracker plugin which filed the bug.</value>
    [DataMember(Name="externalBugId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalBugId")]
    public string ExternalBugId { get; set; }

    /// <summary>
    /// Issue folder globally unique identifier
    /// </summary>
    /// <value>Issue folder globally unique identifier</value>
    [DataMember(Name="folderGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folderGuid")]
    public string FolderGuid { get; set; }

    /// <summary>
    /// Deprecated - Issue folder identifier.  This may be incorrect or invalid.  Please use folderGuid instead.
    /// </summary>
    /// <value>Deprecated - Issue folder identifier.  This may be incorrect or invalid.  Please use folderGuid instead.</value>
    [DataMember(Name="folderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folderId")]
    public long? FolderId { get; set; }

    /// <summary>
    /// Date when issue found
    /// </summary>
    /// <value>Date when issue found</value>
    [DataMember(Name="foundDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foundDate")]
    public DateTime? FoundDate { get; set; }

    /// <summary>
    /// Friority
    /// </summary>
    /// <value>Friority</value>
    [DataMember(Name="friority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "friority")]
    public string Friority { get; set; }

    /// <summary>
    /// Full file name where issue found
    /// </summary>
    /// <value>Full file name where issue found</value>
    [DataMember(Name="fullFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullFileName")]
    public string FullFileName { get; set; }

    /// <summary>
    /// Set to true if issue has attachments
    /// </summary>
    /// <value>Set to true if issue has attachments</value>
    [DataMember(Name="hasAttachments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasAttachments")]
    public bool? HasAttachments { get; set; }

    /// <summary>
    /// Set to true if issue has other correlated issues
    /// </summary>
    /// <value>Set to true if issue has other correlated issues</value>
    [DataMember(Name="hasCorrelatedIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasCorrelatedIssues")]
    public bool? HasCorrelatedIssues { get; set; }

    /// <summary>
    /// Set to true if issue is hidden
    /// </summary>
    /// <value>Set to true if issue is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Application version issue identifier
    /// </summary>
    /// <value>Application version issue identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Issue impact
    /// </summary>
    /// <value>Issue impact</value>
    [DataMember(Name="impact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "impact")]
    public float? Impact { get; set; }

    /// <summary>
    /// Issue instance identifier
    /// </summary>
    /// <value>Issue instance identifier</value>
    [DataMember(Name="issueInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueInstanceId")]
    public string IssueInstanceId { get; set; }

    /// <summary>
    /// Issue name
    /// </summary>
    /// <value>Issue name</value>
    [DataMember(Name="issueName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueName")]
    public string IssueName { get; set; }

    /// <summary>
    /// Flag represents issue review status and can have 3 types of values: Unreviewed, Under Review, Reviewed.
    /// </summary>
    /// <value>Flag represents issue review status and can have 3 types of values: Unreviewed, Under Review, Reviewed.</value>
    [DataMember(Name="issueStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueStatus")]
    public string IssueStatus { get; set; }

    /// <summary>
    /// Kingdom
    /// </summary>
    /// <value>Kingdom</value>
    [DataMember(Name="kingdom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kingdom")]
    public string Kingdom { get; set; }

    /// <summary>
    /// ID of the latest scan that found the issue
    /// </summary>
    /// <value>ID of the latest scan that found the issue</value>
    [DataMember(Name="lastScanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScanId")]
    public long? LastScanId { get; set; }

    /// <summary>
    /// Likelihood of issue
    /// </summary>
    /// <value>Likelihood of issue</value>
    [DataMember(Name="likelihood", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "likelihood")]
    public float? Likelihood { get; set; }

    /// <summary>
    /// Line number where issue found
    /// </summary>
    /// <value>Line number where issue found</value>
    [DataMember(Name="lineNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineNumber")]
    public int? LineNumber { get; set; }

    /// <summary>
    /// Issue primary location
    /// </summary>
    /// <value>Issue primary location</value>
    [DataMember(Name="primaryLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryLocation")]
    public string PrimaryLocation { get; set; }

    /// <summary>
    /// Primary rule global unique identifier
    /// </summary>
    /// <value>Primary rule global unique identifier</value>
    [DataMember(Name="primaryRuleGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryRuleGuid")]
    public string PrimaryRuleGuid { get; set; }

    /// <summary>
    /// Issue primary tag
    /// </summary>
    /// <value>Issue primary tag</value>
    [DataMember(Name="primaryTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryTag")]
    public string PrimaryTag { get; set; }

    /// <summary>
    /// Flag equals true if value of custom tag was applied automatically
    /// </summary>
    /// <value>Flag equals true if value of custom tag was applied automatically</value>
    [DataMember(Name="primaryTagValueAutoApplied", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryTagValueAutoApplied")]
    public bool? PrimaryTagValueAutoApplied { get; set; }

    /// <summary>
    /// Application name
    /// </summary>
    /// <value>Application name</value>
    [DataMember(Name="projectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectName")]
    public string ProjectName { get; set; }

    /// <summary>
    /// Application version identifier
    /// </summary>
    /// <value>Application version identifier</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Application version name
    /// </summary>
    /// <value>Application version name</value>
    [DataMember(Name="projectVersionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionName")]
    public string ProjectVersionName { get; set; }

    /// <summary>
    /// Set to true if issue is suppressed
    /// </summary>
    /// <value>Set to true if issue is suppressed</value>
    [DataMember(Name="removed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removed")]
    public bool? Removed { get; set; }

    /// <summary>
    /// Date when issue removed
    /// </summary>
    /// <value>Date when issue removed</value>
    [DataMember(Name="removedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removedDate")]
    public DateTime? RemovedDate { get; set; }

    /// <summary>
    /// Issue reviewer
    /// </summary>
    /// <value>Issue reviewer</value>
    [DataMember(Name="reviewed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reviewed")]
    public string Reviewed { get; set; }

    /// <summary>
    /// Application version revision
    /// </summary>
    /// <value>Application version revision</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// Scan status
    /// </summary>
    /// <value>Scan status</value>
    [DataMember(Name="scanStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scanStatus")]
    public string ScanStatus { get; set; }

    /// <summary>
    /// Issue severity
    /// </summary>
    /// <value>Issue severity</value>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public float? Severity { get; set; }

    /// <summary>
    /// Set to true if issue is suppressed
    /// </summary>
    /// <value>Set to true if issue is suppressed</value>
    [DataMember(Name="suppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressed")]
    public bool? Suppressed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionIssue {\n");
      sb.Append("  Analyzer: ").Append(Analyzer).Append("\n");
      sb.Append("  Audited: ").Append(Audited).Append("\n");
      sb.Append("  BugURL: ").Append(BugURL).Append("\n");
      sb.Append("  Confidence: ").Append(Confidence).Append("\n");
      sb.Append("  DisplayEngineType: ").Append(DisplayEngineType).Append("\n");
      sb.Append("  EngineCategory: ").Append(EngineCategory).Append("\n");
      sb.Append("  EngineType: ").Append(EngineType).Append("\n");
      sb.Append("  ExternalBugId: ").Append(ExternalBugId).Append("\n");
      sb.Append("  FolderGuid: ").Append(FolderGuid).Append("\n");
      sb.Append("  FolderId: ").Append(FolderId).Append("\n");
      sb.Append("  FoundDate: ").Append(FoundDate).Append("\n");
      sb.Append("  Friority: ").Append(Friority).Append("\n");
      sb.Append("  FullFileName: ").Append(FullFileName).Append("\n");
      sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
      sb.Append("  HasCorrelatedIssues: ").Append(HasCorrelatedIssues).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Impact: ").Append(Impact).Append("\n");
      sb.Append("  IssueInstanceId: ").Append(IssueInstanceId).Append("\n");
      sb.Append("  IssueName: ").Append(IssueName).Append("\n");
      sb.Append("  IssueStatus: ").Append(IssueStatus).Append("\n");
      sb.Append("  Kingdom: ").Append(Kingdom).Append("\n");
      sb.Append("  LastScanId: ").Append(LastScanId).Append("\n");
      sb.Append("  Likelihood: ").Append(Likelihood).Append("\n");
      sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
      sb.Append("  PrimaryLocation: ").Append(PrimaryLocation).Append("\n");
      sb.Append("  PrimaryRuleGuid: ").Append(PrimaryRuleGuid).Append("\n");
      sb.Append("  PrimaryTag: ").Append(PrimaryTag).Append("\n");
      sb.Append("  PrimaryTagValueAutoApplied: ").Append(PrimaryTagValueAutoApplied).Append("\n");
      sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  ProjectVersionName: ").Append(ProjectVersionName).Append("\n");
      sb.Append("  Removed: ").Append(Removed).Append("\n");
      sb.Append("  RemovedDate: ").Append(RemovedDate).Append("\n");
      sb.Append("  Reviewed: ").Append(Reviewed).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  ScanStatus: ").Append(ScanStatus).Append("\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
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
