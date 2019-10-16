using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue audit history record.
  /// </summary>
  [DataContract]
  public class IssueAuditHistoryDto {
    /// <summary>
    /// Changed attribute name.
    /// </summary>
    /// <value>Changed attribute name.</value>
    [DataMember(Name="attributeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeName")]
    public string AttributeName { get; set; }

    /// <summary>
    /// Date and time when audit was performed.
    /// </summary>
    /// <value>Date and time when audit was performed.</value>
    [DataMember(Name="auditDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auditDateTime")]
    public DateTime? AuditDateTime { get; set; }

    /// <summary>
    /// Flag that indicates if there were any conflicts when audit information was merged.
    /// </summary>
    /// <value>Flag that indicates if there were any conflicts when audit information was merged.</value>
    [DataMember(Name="conflict", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "conflict")]
    public bool? Conflict { get; set; }

    /// <summary>
    /// ID of the issue the history record belongs to
    /// </summary>
    /// <value>ID of the issue the history record belongs to</value>
    [DataMember(Name="issueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueId")]
    public long? IssueId { get; set; }

    /// <summary>
    /// Attribute value after audit.
    /// </summary>
    /// <value>Attribute value after audit.</value>
    [DataMember(Name="newValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newValue")]
    public string NewValue { get; set; }

    /// <summary>
    /// Attribute value before audit.
    /// </summary>
    /// <value>Attribute value before audit.</value>
    [DataMember(Name="oldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oldValue")]
    public string OldValue { get; set; }

    /// <summary>
    /// Sequence number of the history record in the list of all audit history records for the issue.
    /// </summary>
    /// <value>Sequence number of the history record in the list of all audit history records for the issue.</value>
    [DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sequenceNumber")]
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Name of the user who performed the audit.
    /// </summary>
    /// <value>Name of the user who performed the audit.</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }

    /// <summary>
    /// Attribute type.
    /// </summary>
    /// <value>Attribute type.</value>
    [DataMember(Name="valueType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueType")]
    public string ValueType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAuditHistoryDto {\n");
      sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
      sb.Append("  AuditDateTime: ").Append(AuditDateTime).Append("\n");
      sb.Append("  Conflict: ").Append(Conflict).Append("\n");
      sb.Append("  IssueId: ").Append(IssueId).Append("\n");
      sb.Append("  NewValue: ").Append(NewValue).Append("\n");
      sb.Append("  OldValue: ").Append(OldValue).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
