using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan worker
  /// </summary>
  [DataContract]
  public class CloudWorker {
    /// <summary>
    /// Gets or Sets AvailableProcessors
    /// </summary>
    [DataMember(Name="availableProcessors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableProcessors")]
    public int? AvailableProcessors { get; set; }

    /// <summary>
    /// Gets or Sets CloudPool
    /// </summary>
    [DataMember(Name="cloudPool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cloudPool")]
    public CloudPool CloudPool { get; set; }

    /// <summary>
    /// Gets or Sets HostName
    /// </summary>
    [DataMember(Name="hostName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostName")]
    public string HostName { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name="ipAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ipAddress")]
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets LastActivity
    /// </summary>
    [DataMember(Name="lastActivity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastActivity")]
    public string LastActivity { get; set; }

    /// <summary>
    /// Gets or Sets LastSeen
    /// </summary>
    [DataMember(Name="lastSeen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSeen")]
    public DateTime? LastSeen { get; set; }

    /// <summary>
    /// Gets or Sets OsArchitecture
    /// </summary>
    [DataMember(Name="osArchitecture", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osArchitecture")]
    public string OsArchitecture { get; set; }

    /// <summary>
    /// Gets or Sets OsName
    /// </summary>
    [DataMember(Name="osName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osName")]
    public string OsName { get; set; }

    /// <summary>
    /// Gets or Sets OsVersion
    /// </summary>
    [DataMember(Name="osVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "osVersion")]
    public string OsVersion { get; set; }

    /// <summary>
    /// Gets or Sets ProcessUuid
    /// </summary>
    [DataMember(Name="processUuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processUuid")]
    public string ProcessUuid { get; set; }

    /// <summary>
    /// Gets or Sets ScaVersion
    /// </summary>
    [DataMember(Name="scaVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaVersion")]
    public string ScaVersion { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets TotalPhysicalMemory
    /// </summary>
    [DataMember(Name="totalPhysicalMemory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalPhysicalMemory")]
    public long? TotalPhysicalMemory { get; set; }

    /// <summary>
    /// Gets or Sets Uuid
    /// </summary>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }

    /// <summary>
    /// Gets or Sets VmName
    /// </summary>
    [DataMember(Name="vmName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vmName")]
    public string VmName { get; set; }

    /// <summary>
    /// Gets or Sets WorkerExpiryTime
    /// </summary>
    [DataMember(Name="workerExpiryTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerExpiryTime")]
    public DateTime? WorkerExpiryTime { get; set; }

    /// <summary>
    /// Gets or Sets WorkerStartTime
    /// </summary>
    [DataMember(Name="workerStartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerStartTime")]
    public DateTime? WorkerStartTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudWorker {\n");
      sb.Append("  AvailableProcessors: ").Append(AvailableProcessors).Append("\n");
      sb.Append("  CloudPool: ").Append(CloudPool).Append("\n");
      sb.Append("  HostName: ").Append(HostName).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  LastActivity: ").Append(LastActivity).Append("\n");
      sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
      sb.Append("  OsArchitecture: ").Append(OsArchitecture).Append("\n");
      sb.Append("  OsName: ").Append(OsName).Append("\n");
      sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
      sb.Append("  ProcessUuid: ").Append(ProcessUuid).Append("\n");
      sb.Append("  ScaVersion: ").Append(ScaVersion).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  TotalPhysicalMemory: ").Append(TotalPhysicalMemory).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
      sb.Append("  VmName: ").Append(VmName).Append("\n");
      sb.Append("  WorkerExpiryTime: ").Append(WorkerExpiryTime).Append("\n");
      sb.Append("  WorkerStartTime: ").Append(WorkerStartTime).Append("\n");
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
