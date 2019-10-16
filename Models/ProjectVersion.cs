using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A version of an application on the server
  /// </summary>
  [DataContract]
  public class ProjectVersion {
    /// <summary>
    /// True if this version is active
    /// </summary>
    /// <value>True if this version is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets AssignedIssuesCount
    /// </summary>
    [DataMember(Name="assignedIssuesCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignedIssuesCount")]
    public long? AssignedIssuesCount { get; set; }

    /// <summary>
    /// Gets or Sets AttachmentsOutOfDate
    /// </summary>
    [DataMember(Name="attachmentsOutOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attachmentsOutOfDate")]
    public bool? AttachmentsOutOfDate { get; set; }

    /// <summary>
    /// true if auto-prediction is enabled for this application version; false otherwise. This property modification is protected by AUDITASSISTANT_MANAGE permission.
    /// </summary>
    /// <value>true if auto-prediction is enabled for this application version; false otherwise. This property modification is protected by AUDITASSISTANT_MANAGE permission.</value>
    [DataMember(Name="autoPredict", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoPredict")]
    public bool? AutoPredict { get; set; }

    /// <summary>
    /// true if the bug tracker plugin assigned to the application version is currently enabled in the system
    /// </summary>
    /// <value>true if the bug tracker plugin assigned to the application version is currently enabled in the system</value>
    [DataMember(Name="bugTrackerEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTrackerEnabled")]
    public bool? BugTrackerEnabled { get; set; }

    /// <summary>
    /// identifier of the bug tracker plugin (if any) assigned to this application version
    /// </summary>
    /// <value>identifier of the bug tracker plugin (if any) assigned to this application version</value>
    [DataMember(Name="bugTrackerPluginId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTrackerPluginId")]
    public string BugTrackerPluginId { get; set; }

    /// <summary>
    /// True if this version is committed and ready to be used
    /// </summary>
    /// <value>True if this version is committed and ready to be used</value>
    [DataMember(Name="committed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committed")]
    public bool? Committed { get; set; }

    /// <summary>
    /// User that created this version
    /// </summary>
    /// <value>User that created this version</value>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Date this version was created
    /// </summary>
    /// <value>Date this version was created</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Gets or Sets CurrentState
    /// </summary>
    [DataMember(Name="currentState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentState")]
    public ProjectVersionState CurrentState { get; set; }

    /// <summary>
    /// true if custom tag values auto-apply is enabled for this application version; false otherwise. This property modification is protected by AUDITASSISTANT_MANAGE permission.
    /// </summary>
    /// <value>true if custom tag values auto-apply is enabled for this application version; false otherwise. This property modification is protected by AUDITASSISTANT_MANAGE permission.</value>
    [DataMember(Name="customTagValuesAutoApply", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagValuesAutoApply")]
    public bool? CustomTagValuesAutoApply { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    /// <value>Description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Id
    /// </summary>
    /// <value>Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Id of the Issue Template used by this version
    /// </summary>
    /// <value>Id of the Issue Template used by this version</value>
    [DataMember(Name="issueTemplateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueTemplateId")]
    public string IssueTemplateId { get; set; }

    /// <summary>
    /// Last time the Issue Template was modified
    /// </summary>
    /// <value>Last time the Issue Template was modified</value>
    [DataMember(Name="issueTemplateModifiedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueTemplateModifiedTime")]
    public long? IssueTemplateModifiedTime { get; set; }

    /// <summary>
    /// Name of the Issue Template used by this version
    /// </summary>
    /// <value>Name of the Issue Template used by this version</value>
    [DataMember(Name="issueTemplateName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueTemplateName")]
    public string IssueTemplateName { get; set; }

    /// <summary>
    /// id of the latest scan uploaded to application version
    /// </summary>
    /// <value>id of the latest scan uploaded to application version</value>
    [DataMember(Name="latestScanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestScanId")]
    public long? LatestScanId { get; set; }

    /// <summary>
    /// Gets or Sets LoadProperties
    /// </summary>
    [DataMember(Name="loadProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loadProperties")]
    public string LoadProperties { get; set; }

    /// <summary>
    /// Guid of the primary custom tag for this version
    /// </summary>
    /// <value>Guid of the primary custom tag for this version</value>
    [DataMember(Name="masterAttrGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masterAttrGuid")]
    public string MasterAttrGuid { get; set; }

    /// <summary>
    /// Gets or Sets MigrationVersion
    /// </summary>
    [DataMember(Name="migrationVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "migrationVersion")]
    public float? MigrationVersion { get; set; }

    /// <summary>
    /// Gets or Sets Mode
    /// </summary>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ObfuscatedId
    /// </summary>
    [DataMember(Name="obfuscatedId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obfuscatedId")]
    public string ObfuscatedId { get; set; }

    /// <summary>
    /// Owner of this version
    /// </summary>
    /// <value>Owner of this version</value>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public string Owner { get; set; }

    /// <summary>
    /// Name of the policy to be used for predictions for this application version. Modification of this property is protected by AUDITASSISTANT_MANAGE permission.
    /// </summary>
    /// <value>Name of the policy to be used for predictions for this application version. Modification of this property is protected by AUDITASSISTANT_MANAGE permission.</value>
    [DataMember(Name="predictionPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predictionPolicy")]
    public string PredictionPolicy { get; set; }

    /// <summary>
    /// Gets or Sets Project
    /// </summary>
    [DataMember(Name="project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project")]
    public Project Project { get; set; }

    /// <summary>
    /// Gets or Sets RefreshRequired
    /// </summary>
    [DataMember(Name="refreshRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refreshRequired")]
    public bool? RefreshRequired { get; set; }

    /// <summary>
    /// Gets or Sets SecurityGroup
    /// </summary>
    [DataMember(Name="securityGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityGroup")]
    public string SecurityGroup { get; set; }

    /// <summary>
    /// Server version this version's data supports
    /// </summary>
    /// <value>Server version this version's data supports</value>
    [DataMember(Name="serverVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverVersion")]
    public float? ServerVersion { get; set; }

    /// <summary>
    /// Gets or Sets SiteId
    /// </summary>
    [DataMember(Name="siteId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "siteId")]
    public string SiteId { get; set; }

    /// <summary>
    /// True if the most recent snapshot is not accurate
    /// </summary>
    /// <value>True if the most recent snapshot is not accurate</value>
    [DataMember(Name="snapshotOutOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "snapshotOutOfDate")]
    public bool? SnapshotOutOfDate { get; set; }

    /// <summary>
    /// Gets or Sets SourceBasePath
    /// </summary>
    [DataMember(Name="sourceBasePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceBasePath")]
    public string SourceBasePath { get; set; }

    /// <summary>
    /// True if this version's Issue Template has changed or been modified
    /// </summary>
    /// <value>True if this version's Issue Template has changed or been modified</value>
    [DataMember(Name="staleIssueTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staleIssueTemplate")]
    public bool? StaleIssueTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets TracesOutOfDate
    /// </summary>
    [DataMember(Name="tracesOutOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tracesOutOfDate")]
    public bool? TracesOutOfDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersion {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  AssignedIssuesCount: ").Append(AssignedIssuesCount).Append("\n");
      sb.Append("  AttachmentsOutOfDate: ").Append(AttachmentsOutOfDate).Append("\n");
      sb.Append("  AutoPredict: ").Append(AutoPredict).Append("\n");
      sb.Append("  BugTrackerEnabled: ").Append(BugTrackerEnabled).Append("\n");
      sb.Append("  BugTrackerPluginId: ").Append(BugTrackerPluginId).Append("\n");
      sb.Append("  Committed: ").Append(Committed).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
      sb.Append("  CustomTagValuesAutoApply: ").Append(CustomTagValuesAutoApply).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IssueTemplateId: ").Append(IssueTemplateId).Append("\n");
      sb.Append("  IssueTemplateModifiedTime: ").Append(IssueTemplateModifiedTime).Append("\n");
      sb.Append("  IssueTemplateName: ").Append(IssueTemplateName).Append("\n");
      sb.Append("  LatestScanId: ").Append(LatestScanId).Append("\n");
      sb.Append("  LoadProperties: ").Append(LoadProperties).Append("\n");
      sb.Append("  MasterAttrGuid: ").Append(MasterAttrGuid).Append("\n");
      sb.Append("  MigrationVersion: ").Append(MigrationVersion).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObfuscatedId: ").Append(ObfuscatedId).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  PredictionPolicy: ").Append(PredictionPolicy).Append("\n");
      sb.Append("  Project: ").Append(Project).Append("\n");
      sb.Append("  RefreshRequired: ").Append(RefreshRequired).Append("\n");
      sb.Append("  SecurityGroup: ").Append(SecurityGroup).Append("\n");
      sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
      sb.Append("  SiteId: ").Append(SiteId).Append("\n");
      sb.Append("  SnapshotOutOfDate: ").Append(SnapshotOutOfDate).Append("\n");
      sb.Append("  SourceBasePath: ").Append(SourceBasePath).Append("\n");
      sb.Append("  StaleIssueTemplate: ").Append(StaleIssueTemplate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  TracesOutOfDate: ").Append(TracesOutOfDate).Append("\n");
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
