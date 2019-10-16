using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Object containing application version and bug tracker related data
  /// </summary>
  [DataContract]
  public class ProjectVersionBugTracker {
    /// <summary>
    /// the short display name of the bug tracker. (will be null if no bugtracker is assigned or if there is no currently installed plugin matching the assigned pluginId.)
    /// </summary>
    /// <value>the short display name of the bug tracker. (will be null if no bugtracker is assigned or if there is no currently installed plugin matching the assigned pluginId.)</value>
    [DataMember(Name="assignedBugtrackerShortNameIfKnown", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignedBugtrackerShortNameIfKnown")]
    public string AssignedBugtrackerShortNameIfKnown { get; set; }

    /// <summary>
    /// identifier of the bug tracker plugin assigned to the application version. (Bug tracker integration will be active only if the plugin is also enabled in the system.)
    /// </summary>
    /// <value>identifier of the bug tracker plugin assigned to the application version. (Bug tracker integration will be active only if the plugin is also enabled in the system.)</value>
    [DataMember(Name="assignedPluginId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignedPluginId")]
    public string AssignedPluginId { get; set; }

    /// <summary>
    /// Bug state management configuration
    /// </summary>
    /// <value>Bug state management configuration</value>
    [DataMember(Name="bugStateManagementConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugStateManagementConfig")]
    public BugStateManagementCfg BugStateManagementConfig { get; set; }

    /// <summary>
    /// Bug tracker (note that this field will be null if the assigned bug tracker is not enabled in the SSC plugin framework.)
    /// </summary>
    /// <value>Bug tracker (note that this field will be null if the assigned bug tracker is not enabled in the SSC plugin framework.)</value>
    [DataMember(Name="bugTracker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTracker")]
    public BugTracker BugTracker { get; set; }

    /// <summary>
    /// indicates whether a bug tracker is assigned to the application version
    /// </summary>
    /// <value>indicates whether a bug tracker is assigned to the application version</value>
    [DataMember(Name="bugtrackerIsAssigned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugtrackerIsAssigned")]
    public bool? BugtrackerIsAssigned { get; set; }

    /// <summary>
    /// Gets or Sets ClearAppVersionBugs
    /// </summary>
    [DataMember(Name="clearAppVersionBugs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clearAppVersionBugs")]
    public bool? ClearAppVersionBugs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionBugTracker {\n");
      sb.Append("  AssignedBugtrackerShortNameIfKnown: ").Append(AssignedBugtrackerShortNameIfKnown).Append("\n");
      sb.Append("  AssignedPluginId: ").Append(AssignedPluginId).Append("\n");
      sb.Append("  BugStateManagementConfig: ").Append(BugStateManagementConfig).Append("\n");
      sb.Append("  BugTracker: ").Append(BugTracker).Append("\n");
      sb.Append("  BugtrackerIsAssigned: ").Append(BugtrackerIsAssigned).Append("\n");
      sb.Append("  ClearAppVersionBugs: ").Append(ClearAppVersionBugs).Append("\n");
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
