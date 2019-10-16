using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application state DTO object
  /// </summary>
  [DataContract]
  public class ApplicationState {
    /// <summary>
    /// Indicates whether SSC application is in auto configuration mode
    /// </summary>
    /// <value>Indicates whether SSC application is in auto configuration mode</value>
    [DataMember(Name="autoConfigurationMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoConfigurationMode")]
    public bool? AutoConfigurationMode { get; set; }

    /// <summary>
    /// Indicates whether a config visit is needed
    /// </summary>
    /// <value>Indicates whether a config visit is needed</value>
    [DataMember(Name="configVisitRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configVisitRequired")]
    public bool? ConfigVisitRequired { get; set; }

    /// <summary>
    /// Indicates whether SSC application is in maintenance mode
    /// </summary>
    /// <value>Indicates whether SSC application is in maintenance mode</value>
    [DataMember(Name="maintenanceMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maintenanceMode")]
    public bool? MaintenanceMode { get; set; }

    /// <summary>
    /// Indicates whether a restart is needed
    /// </summary>
    /// <value>Indicates whether a restart is needed</value>
    [DataMember(Name="restartRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restartRequired")]
    public bool? RestartRequired { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationState {\n");
      sb.Append("  AutoConfigurationMode: ").Append(AutoConfigurationMode).Append("\n");
      sb.Append("  ConfigVisitRequired: ").Append(ConfigVisitRequired).Append("\n");
      sb.Append("  MaintenanceMode: ").Append(MaintenanceMode).Append("\n");
      sb.Append("  RestartRequired: ").Append(RestartRequired).Append("\n");
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
