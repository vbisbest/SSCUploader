using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan system metrics
  /// </summary>
  [DataContract]
  public class CloudSystemMetrics {
    /// <summary>
    /// Free disk space in controller's job directory [bytes]
    /// </summary>
    /// <value>Free disk space in controller's job directory [bytes]</value>
    [DataMember(Name="controllerDiskFree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controllerDiskFree")]
    public long? ControllerDiskFree { get; set; }

    /// <summary>
    /// Disk space used by files in controller's job directory [bytes]
    /// </summary>
    /// <value>Disk space used by files in controller's job directory [bytes]</value>
    [DataMember(Name="controllerDiskUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controllerDiskUsed")]
    public long? ControllerDiskUsed { get; set; }

    /// <summary>
    /// Gets or Sets ControllerStartTime
    /// </summary>
    [DataMember(Name="controllerStartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controllerStartTime")]
    public DateTime? ControllerStartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudSystemMetrics {\n");
      sb.Append("  ControllerDiskFree: ").Append(ControllerDiskFree).Append("\n");
      sb.Append("  ControllerDiskUsed: ").Append(ControllerDiskUsed).Append("\n");
      sb.Append("  ControllerStartTime: ").Append(ControllerStartTime).Append("\n");
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
