using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application version artifact that contains scan results.
  /// </summary>
  [DataContract]
  public class Artifact {
    /// <summary>
    /// Gets or Sets Embed
    /// </summary>
    [DataMember(Name="_embed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_embed")]
    public EmbeddedScans Embed { get; set; }

    /// <summary>
    /// Gets or Sets AllowApprove
    /// </summary>
    [DataMember(Name="allowApprove", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowApprove")]
    public bool? AllowApprove { get; set; }

    /// <summary>
    /// Gets or Sets AllowDelete
    /// </summary>
    [DataMember(Name="allowDelete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowDelete")]
    public bool? AllowDelete { get; set; }

    /// <summary>
    /// Gets or Sets AllowPurge
    /// </summary>
    [DataMember(Name="allowPurge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowPurge")]
    public bool? AllowPurge { get; set; }

    /// <summary>
    /// Gets or Sets ApprovalComment
    /// </summary>
    [DataMember(Name="approvalComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approvalComment")]
    public string ApprovalComment { get; set; }

    /// <summary>
    /// Gets or Sets ApprovalDate
    /// </summary>
    [DataMember(Name="approvalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approvalDate")]
    public DateTime? ApprovalDate { get; set; }

    /// <summary>
    /// Gets or Sets ApprovalUsername
    /// </summary>
    [DataMember(Name="approvalUsername", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "approvalUsername")]
    public string ApprovalUsername { get; set; }

    /// <summary>
    /// Gets or Sets ArtifactType
    /// </summary>
    [DataMember(Name="artifactType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactType")]
    public string ArtifactType { get; set; }

    /// <summary>
    /// Gets or Sets AuditUpdated
    /// </summary>
    [DataMember(Name="auditUpdated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auditUpdated")]
    public bool? AuditUpdated { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets FileSize
    /// </summary>
    [DataMember(Name="fileSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileSize")]
    public long? FileSize { get; set; }

    /// <summary>
    /// Gets or Sets FileURL
    /// </summary>
    [DataMember(Name="fileURL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileURL")]
    public string FileURL { get; set; }

    /// <summary>
    /// Artifact id
    /// </summary>
    /// <value>Artifact id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets InModifyingStatus
    /// </summary>
    [DataMember(Name="inModifyingStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inModifyingStatus")]
    public bool? InModifyingStatus { get; set; }

    /// <summary>
    /// Gets or Sets Indexed
    /// </summary>
    [DataMember(Name="indexed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indexed")]
    public bool? Indexed { get; set; }

    /// <summary>
    /// Gets or Sets LastScanDate
    /// </summary>
    [DataMember(Name="lastScanDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScanDate")]
    public DateTime? LastScanDate { get; set; }

    /// <summary>
    /// Gets or Sets MessageCount
    /// </summary>
    [DataMember(Name="messageCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageCount")]
    public long? MessageCount { get; set; }

    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [DataMember(Name="messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messages")]
    public string Messages { get; set; }

    /// <summary>
    /// Gets or Sets OriginalFileName
    /// </summary>
    [DataMember(Name="originalFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalFileName")]
    public string OriginalFileName { get; set; }

    /// <summary>
    /// Gets or Sets OtherStatus
    /// </summary>
    [DataMember(Name="otherStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otherStatus")]
    public string OtherStatus { get; set; }

    /// <summary>
    /// Gets or Sets Purged
    /// </summary>
    [DataMember(Name="purged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "purged")]
    public bool? Purged { get; set; }

    /// <summary>
    /// Gets or Sets RuntimeStatus
    /// </summary>
    [DataMember(Name="runtimeStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runtimeStatus")]
    public string RuntimeStatus { get; set; }

    /// <summary>
    /// Gets or Sets ScaStatus
    /// </summary>
    [DataMember(Name="scaStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaStatus")]
    public string ScaStatus { get; set; }

    /// <summary>
    /// Gets or Sets ScanErrorsCount
    /// </summary>
    [DataMember(Name="scanErrorsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scanErrorsCount")]
    public long? ScanErrorsCount { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets UploadDate
    /// </summary>
    [DataMember(Name="uploadDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadDate")]
    public DateTime? UploadDate { get; set; }

    /// <summary>
    /// Gets or Sets UploadIP
    /// </summary>
    [DataMember(Name="uploadIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadIP")]
    public string UploadIP { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Gets or Sets VersionNumber
    /// </summary>
    [DataMember(Name="versionNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionNumber")]
    public int? VersionNumber { get; set; }

    /// <summary>
    /// Gets or Sets WebInspectStatus
    /// </summary>
    [DataMember(Name="webInspectStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webInspectStatus")]
    public string WebInspectStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Artifact {\n");
      sb.Append("  Embed: ").Append(Embed).Append("\n");
      sb.Append("  AllowApprove: ").Append(AllowApprove).Append("\n");
      sb.Append("  AllowDelete: ").Append(AllowDelete).Append("\n");
      sb.Append("  AllowPurge: ").Append(AllowPurge).Append("\n");
      sb.Append("  ApprovalComment: ").Append(ApprovalComment).Append("\n");
      sb.Append("  ApprovalDate: ").Append(ApprovalDate).Append("\n");
      sb.Append("  ApprovalUsername: ").Append(ApprovalUsername).Append("\n");
      sb.Append("  ArtifactType: ").Append(ArtifactType).Append("\n");
      sb.Append("  AuditUpdated: ").Append(AuditUpdated).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  FileSize: ").Append(FileSize).Append("\n");
      sb.Append("  FileURL: ").Append(FileURL).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InModifyingStatus: ").Append(InModifyingStatus).Append("\n");
      sb.Append("  Indexed: ").Append(Indexed).Append("\n");
      sb.Append("  LastScanDate: ").Append(LastScanDate).Append("\n");
      sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
      sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
      sb.Append("  OtherStatus: ").Append(OtherStatus).Append("\n");
      sb.Append("  Purged: ").Append(Purged).Append("\n");
      sb.Append("  RuntimeStatus: ").Append(RuntimeStatus).Append("\n");
      sb.Append("  ScaStatus: ").Append(ScaStatus).Append("\n");
      sb.Append("  ScanErrorsCount: ").Append(ScanErrorsCount).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UploadDate: ").Append(UploadDate).Append("\n");
      sb.Append("  UploadIP: ").Append(UploadIP).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  VersionNumber: ").Append(VersionNumber).Append("\n");
      sb.Append("  WebInspectStatus: ").Append(WebInspectStatus).Append("\n");
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
