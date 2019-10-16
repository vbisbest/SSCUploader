using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan system settings
  /// </summary>
  [DataContract]
  public class CloudSystemSettings {
    /// <summary>
    /// Gets or Sets CleanupPeriodSeconds
    /// </summary>
    [DataMember(Name="cleanupPeriodSeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cleanupPeriodSeconds")]
    public long? CleanupPeriodSeconds { get; set; }

    /// <summary>
    /// Gets or Sets ControllerMaxUploadSize
    /// </summary>
    [DataMember(Name="controllerMaxUploadSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controllerMaxUploadSize")]
    public long? ControllerMaxUploadSize { get; set; }

    /// <summary>
    /// Gets or Sets ControllerSystemUrl
    /// </summary>
    [DataMember(Name="controllerSystemUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controllerSystemUrl")]
    public string ControllerSystemUrl { get; set; }

    /// <summary>
    /// Gets or Sets IsSscLockdownMode
    /// </summary>
    [DataMember(Name="isSscLockdownMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isSscLockdownMode")]
    public bool? IsSscLockdownMode { get; set; }

    /// <summary>
    /// Gets or Sets JobExpiryDelaySeconds
    /// </summary>
    [DataMember(Name="jobExpiryDelaySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobExpiryDelaySeconds")]
    public long? JobExpiryDelaySeconds { get; set; }

    /// <summary>
    /// Gets or Sets PoolMappingMode
    /// </summary>
    [DataMember(Name="poolMappingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "poolMappingMode")]
    public string PoolMappingMode { get; set; }

    /// <summary>
    /// Gets or Sets SmtpFromAddress
    /// </summary>
    [DataMember(Name="smtpFromAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smtpFromAddress")]
    public string SmtpFromAddress { get; set; }

    /// <summary>
    /// Gets or Sets SmtpHost
    /// </summary>
    [DataMember(Name="smtpHost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smtpHost")]
    public string SmtpHost { get; set; }

    /// <summary>
    /// Gets or Sets SmtpPort
    /// </summary>
    [DataMember(Name="smtpPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smtpPort")]
    public int? SmtpPort { get; set; }

    /// <summary>
    /// Gets or Sets SscUrl
    /// </summary>
    [DataMember(Name="sscUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sscUrl")]
    public string SscUrl { get; set; }

    /// <summary>
    /// Gets or Sets WorkerExpiryDelaySeconds
    /// </summary>
    [DataMember(Name="workerExpiryDelaySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerExpiryDelaySeconds")]
    public long? WorkerExpiryDelaySeconds { get; set; }

    /// <summary>
    /// Gets or Sets WorkerInactiveDelaySeconds
    /// </summary>
    [DataMember(Name="workerInactiveDelaySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerInactiveDelaySeconds")]
    public long? WorkerInactiveDelaySeconds { get; set; }

    /// <summary>
    /// Gets or Sets WorkerStaleDelaySeconds
    /// </summary>
    [DataMember(Name="workerStaleDelaySeconds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerStaleDelaySeconds")]
    public long? WorkerStaleDelaySeconds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudSystemSettings {\n");
      sb.Append("  CleanupPeriodSeconds: ").Append(CleanupPeriodSeconds).Append("\n");
      sb.Append("  ControllerMaxUploadSize: ").Append(ControllerMaxUploadSize).Append("\n");
      sb.Append("  ControllerSystemUrl: ").Append(ControllerSystemUrl).Append("\n");
      sb.Append("  IsSscLockdownMode: ").Append(IsSscLockdownMode).Append("\n");
      sb.Append("  JobExpiryDelaySeconds: ").Append(JobExpiryDelaySeconds).Append("\n");
      sb.Append("  PoolMappingMode: ").Append(PoolMappingMode).Append("\n");
      sb.Append("  SmtpFromAddress: ").Append(SmtpFromAddress).Append("\n");
      sb.Append("  SmtpHost: ").Append(SmtpHost).Append("\n");
      sb.Append("  SmtpPort: ").Append(SmtpPort).Append("\n");
      sb.Append("  SscUrl: ").Append(SscUrl).Append("\n");
      sb.Append("  WorkerExpiryDelaySeconds: ").Append(WorkerExpiryDelaySeconds).Append("\n");
      sb.Append("  WorkerInactiveDelaySeconds: ").Append(WorkerInactiveDelaySeconds).Append("\n");
      sb.Append("  WorkerStaleDelaySeconds: ").Append(WorkerStaleDelaySeconds).Append("\n");
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
