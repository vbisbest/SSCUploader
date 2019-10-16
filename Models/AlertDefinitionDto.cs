using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Alert definitions can include variable or performance indicator to determine when Software Security Center is to generate an alert notification in the Todo List on the Dashboard.
  /// </summary>
  [DataContract]
  public class AlertDefinitionDto {
    /// <summary>
    /// Gets or Sets AlertAllChildren
    /// </summary>
    [DataMember(Name="alertAllChildren", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertAllChildren")]
    public bool? AlertAllChildren { get; set; }

    /// <summary>
    /// Gets or Sets AlertStakeholders
    /// </summary>
    [DataMember(Name="alertStakeholders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertStakeholders")]
    public bool? AlertStakeholders { get; set; }

    /// <summary>
    /// Gets or Sets AlertTriggers
    /// </summary>
    [DataMember(Name="alertTriggers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertTriggers")]
    public List<AlertTriggerDto> AlertTriggers { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or Sets CreationDate
    /// </summary>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Required field for Scheduled alerts, Optional for other types
    /// </summary>
    /// <value>Required field for Scheduled alerts, Optional for other types</value>
    [DataMember(Name="customMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customMessage")]
    public string CustomMessage { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [DataMember(Name="endDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDate")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets MonitorAllApps
    /// </summary>
    [DataMember(Name="monitorAllApps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitorAllApps")]
    public bool? MonitorAllApps { get; set; }

    /// <summary>
    /// Gets or Sets MonitoredEntityName
    /// </summary>
    [DataMember(Name="monitoredEntityName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitoredEntityName")]
    public string MonitoredEntityName { get; set; }

    /// <summary>
    /// Gets or Sets MonitoredEntityType
    /// </summary>
    [DataMember(Name="monitoredEntityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitoredEntityType")]
    public string MonitoredEntityType { get; set; }

    /// <summary>
    /// Gets or Sets MonitoredInstanceId
    /// </summary>
    [DataMember(Name="monitoredInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitoredInstanceId")]
    public long? MonitoredInstanceId { get; set; }

    /// <summary>
    /// Gets or Sets MonitorsProjectVersions
    /// </summary>
    [DataMember(Name="monitorsProjectVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitorsProjectVersions")]
    public bool? MonitorsProjectVersions { get; set; }

    /// <summary>
    /// Gets or Sets MonitorsRuntimeApp
    /// </summary>
    [DataMember(Name="monitorsRuntimeApp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitorsRuntimeApp")]
    public bool? MonitorsRuntimeApp { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionIds
    /// </summary>
    [DataMember(Name="projectVersionIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionIds")]
    public List<long?> ProjectVersionIds { get; set; }

    /// <summary>
    /// Gets or Sets RecipientType
    /// </summary>
    [DataMember(Name="recipientType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipientType")]
    public string RecipientType { get; set; }

    /// <summary>
    /// Gets or Sets RemindPeriodically
    /// </summary>
    [DataMember(Name="remindPeriodically", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remindPeriodically")]
    public bool? RemindPeriodically { get; set; }

    /// <summary>
    /// Gets or Sets ReminderPeriod
    /// </summary>
    [DataMember(Name="reminderPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderPeriod")]
    public int? ReminderPeriod { get; set; }

    /// <summary>
    /// Gets or Sets StartAtDueDate
    /// </summary>
    [DataMember(Name="startAtDueDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startAtDueDate")]
    public bool? StartAtDueDate { get; set; }

    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [DataMember(Name="startDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDate")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Gets or Sets TriggerDescription
    /// </summary>
    [DataMember(Name="triggerDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDescription")]
    public string TriggerDescription { get; set; }

    /// <summary>
    /// Gets or Sets TriggerDescriptionName
    /// </summary>
    [DataMember(Name="triggerDescriptionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDescriptionName")]
    public string TriggerDescriptionName { get; set; }

    /// <summary>
    /// Gets or Sets TriggerDescriptionOperation
    /// </summary>
    [DataMember(Name="triggerDescriptionOperation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDescriptionOperation")]
    public string TriggerDescriptionOperation { get; set; }

    /// <summary>
    /// Gets or Sets TriggerDescriptionValue
    /// </summary>
    [DataMember(Name="triggerDescriptionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDescriptionValue")]
    public string TriggerDescriptionValue { get; set; }

    /// <summary>
    /// Gets or Sets UserCanModify
    /// </summary>
    [DataMember(Name="userCanModify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userCanModify")]
    public bool? UserCanModify { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AlertDefinitionDto {\n");
      sb.Append("  AlertAllChildren: ").Append(AlertAllChildren).Append("\n");
      sb.Append("  AlertStakeholders: ").Append(AlertStakeholders).Append("\n");
      sb.Append("  AlertTriggers: ").Append(AlertTriggers).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  CustomMessage: ").Append(CustomMessage).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MonitorAllApps: ").Append(MonitorAllApps).Append("\n");
      sb.Append("  MonitoredEntityName: ").Append(MonitoredEntityName).Append("\n");
      sb.Append("  MonitoredEntityType: ").Append(MonitoredEntityType).Append("\n");
      sb.Append("  MonitoredInstanceId: ").Append(MonitoredInstanceId).Append("\n");
      sb.Append("  MonitorsProjectVersions: ").Append(MonitorsProjectVersions).Append("\n");
      sb.Append("  MonitorsRuntimeApp: ").Append(MonitorsRuntimeApp).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProjectVersionIds: ").Append(ProjectVersionIds).Append("\n");
      sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
      sb.Append("  RemindPeriodically: ").Append(RemindPeriodically).Append("\n");
      sb.Append("  ReminderPeriod: ").Append(ReminderPeriod).Append("\n");
      sb.Append("  StartAtDueDate: ").Append(StartAtDueDate).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  TriggerDescription: ").Append(TriggerDescription).Append("\n");
      sb.Append("  TriggerDescriptionName: ").Append(TriggerDescriptionName).Append("\n");
      sb.Append("  TriggerDescriptionOperation: ").Append(TriggerDescriptionOperation).Append("\n");
      sb.Append("  TriggerDescriptionValue: ").Append(TriggerDescriptionValue).Append("\n");
      sb.Append("  UserCanModify: ").Append(UserCanModify).Append("\n");
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
