using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Alert history entry contains information about firede alert, like trigger date, user name for which alert was triggered, information abotu alert definition.
  /// </summary>
  [DataContract]
  public class AlertHistoryEntry {
    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Gets or Sets AlertCustomMessage
    /// </summary>
    [DataMember(Name="alertCustomMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertCustomMessage")]
    public string AlertCustomMessage { get; set; }

    /// <summary>
    /// Gets or Sets AlertDefinitionName
    /// </summary>
    [DataMember(Name="alertDefinitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertDefinitionName")]
    public string AlertDefinitionName { get; set; }

    /// <summary>
    /// Gets or Sets AlertMessage
    /// </summary>
    [DataMember(Name="alertMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertMessage")]
    public string AlertMessage { get; set; }

    /// <summary>
    /// alert history id
    /// </summary>
    /// <value>alert history id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets MonitoredEntityType
    /// </summary>
    [DataMember(Name="monitoredEntityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitoredEntityType")]
    public string MonitoredEntityType { get; set; }

    /// <summary>
    /// Gets or Sets ProjectAndVersionLabel
    /// </summary>
    [DataMember(Name="projectAndVersionLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectAndVersionLabel")]
    public string ProjectAndVersionLabel { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Gets or Sets TriggeredDate
    /// </summary>
    [DataMember(Name="triggeredDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggeredDate")]
    public DateTime? TriggeredDate { get; set; }

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
      sb.Append("class AlertHistoryEntry {\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  AlertCustomMessage: ").Append(AlertCustomMessage).Append("\n");
      sb.Append("  AlertDefinitionName: ").Append(AlertDefinitionName).Append("\n");
      sb.Append("  AlertMessage: ").Append(AlertMessage).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MonitoredEntityType: ").Append(MonitoredEntityType).Append("\n");
      sb.Append("  ProjectAndVersionLabel: ").Append(ProjectAndVersionLabel).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  TriggeredDate: ").Append(TriggeredDate).Append("\n");
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
