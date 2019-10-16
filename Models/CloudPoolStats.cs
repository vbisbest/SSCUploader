using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan worker pool statistics
  /// </summary>
  [DataContract]
  public class CloudPoolStats {
    /// <summary>
    /// Gets or Sets ActiveWorkerCount
    /// </summary>
    [DataMember(Name="activeWorkerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activeWorkerCount")]
    public long? ActiveWorkerCount { get; set; }

    /// <summary>
    /// Gets or Sets IdleWorkerCount
    /// </summary>
    [DataMember(Name="idleWorkerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idleWorkerCount")]
    public long? IdleWorkerCount { get; set; }

    /// <summary>
    /// Gets or Sets InactiveWorkerCount
    /// </summary>
    [DataMember(Name="inactiveWorkerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inactiveWorkerCount")]
    public long? InactiveWorkerCount { get; set; }

    /// <summary>
    /// Gets or Sets PendingJobCount
    /// </summary>
    [DataMember(Name="pendingJobCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pendingJobCount")]
    public long? PendingJobCount { get; set; }

    /// <summary>
    /// Gets or Sets ProcessingWorkerCount
    /// </summary>
    [DataMember(Name="processingWorkerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingWorkerCount")]
    public long? ProcessingWorkerCount { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionCount
    /// </summary>
    [DataMember(Name="projectVersionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionCount")]
    public long? ProjectVersionCount { get; set; }

    /// <summary>
    /// Gets or Sets RunningJobCount
    /// </summary>
    [DataMember(Name="runningJobCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "runningJobCount")]
    public long? RunningJobCount { get; set; }

    /// <summary>
    /// Gets or Sets StaleWorkerCount
    /// </summary>
    [DataMember(Name="staleWorkerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "staleWorkerCount")]
    public long? StaleWorkerCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalWorkerCount
    /// </summary>
    [DataMember(Name="totalWorkerCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalWorkerCount")]
    public long? TotalWorkerCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPoolStats {\n");
      sb.Append("  ActiveWorkerCount: ").Append(ActiveWorkerCount).Append("\n");
      sb.Append("  IdleWorkerCount: ").Append(IdleWorkerCount).Append("\n");
      sb.Append("  InactiveWorkerCount: ").Append(InactiveWorkerCount).Append("\n");
      sb.Append("  PendingJobCount: ").Append(PendingJobCount).Append("\n");
      sb.Append("  ProcessingWorkerCount: ").Append(ProcessingWorkerCount).Append("\n");
      sb.Append("  ProjectVersionCount: ").Append(ProjectVersionCount).Append("\n");
      sb.Append("  RunningJobCount: ").Append(RunningJobCount).Append("\n");
      sb.Append("  StaleWorkerCount: ").Append(StaleWorkerCount).Append("\n");
      sb.Append("  TotalWorkerCount: ").Append(TotalWorkerCount).Append("\n");
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
