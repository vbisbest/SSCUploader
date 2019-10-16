using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Object containing user preferences such as date/time format
  /// </summary>
  [DataContract]
  public class UserPreferences {
    /// <summary>
    /// Preferred date format
    /// </summary>
    /// <value>Preferred date format</value>
    [DataMember(Name="dateFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateFormat")]
    public string DateFormat { get; set; }

    /// <summary>
    /// User email
    /// </summary>
    /// <value>User email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Receive email alerts if set to true
    /// </summary>
    /// <value>Receive email alerts if set to true</value>
    [DataMember(Name="emailAlerts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailAlerts")]
    public bool? EmailAlerts { get; set; }

    /// <summary>
    /// Monitors all runtime applications if set to true
    /// </summary>
    /// <value>Monitors all runtime applications if set to true</value>
    [DataMember(Name="monitorAllRuntimeApps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitorAllRuntimeApps")]
    public bool? MonitorAllRuntimeApps { get; set; }

    /// <summary>
    /// Enum for ProjectVersionListMode with values DEFAULT, CUSTOM, ALL
    /// </summary>
    /// <value>Enum for ProjectVersionListMode with values DEFAULT, CUSTOM, ALL</value>
    [DataMember(Name="projectVersionListMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionListMode")]
    public string ProjectVersionListMode { get; set; }

    /// <summary>
    /// Receive runtime alerts if set to true
    /// </summary>
    /// <value>Receive runtime alerts if set to true</value>
    [DataMember(Name="receiveRuntimeAlerts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "receiveRuntimeAlerts")]
    public bool? ReceiveRuntimeAlerts { get; set; }

    /// <summary>
    /// Runtime alert definition identifier
    /// </summary>
    /// <value>Runtime alert definition identifier</value>
    [DataMember(Name="runtimeAlertDefinitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runtimeAlertDefinitionId")]
    public long? RuntimeAlertDefinitionId { get; set; }

    /// <summary>
    /// Preferred time format
    /// </summary>
    /// <value>Preferred time format</value>
    [DataMember(Name="timeFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeFormat")]
    public string TimeFormat { get; set; }

    /// <summary>
    /// User name
    /// </summary>
    /// <value>User name</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserPreferences {\n");
      sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  EmailAlerts: ").Append(EmailAlerts).Append("\n");
      sb.Append("  MonitorAllRuntimeApps: ").Append(MonitorAllRuntimeApps).Append("\n");
      sb.Append("  ProjectVersionListMode: ").Append(ProjectVersionListMode).Append("\n");
      sb.Append("  ReceiveRuntimeAlerts: ").Append(ReceiveRuntimeAlerts).Append("\n");
      sb.Append("  RuntimeAlertDefinitionId: ").Append(RuntimeAlertDefinitionId).Append("\n");
      sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
