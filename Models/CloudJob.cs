using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan job
  /// </summary>
  [DataContract]
  public class CloudJob {
    /// <summary>
    /// Gets or Sets CloudPool
    /// </summary>
    [DataMember(Name="cloudPool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cloudPool")]
    public CloudPool CloudPool { get; set; }

    /// <summary>
    /// Gets or Sets CloudWorker
    /// </summary>
    [DataMember(Name="cloudWorker", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cloudWorker")]
    public CloudWorker CloudWorker { get; set; }

    /// <summary>
    /// Gets or Sets JobCancellable
    /// </summary>
    [DataMember(Name="jobCancellable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobCancellable")]
    public bool? JobCancellable { get; set; }

    /// <summary>
    /// Gets or Sets JobDuration
    /// </summary>
    [DataMember(Name="jobDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobDuration")]
    public long? JobDuration { get; set; }

    /// <summary>
    /// Gets or Sets JobExpiryTime
    /// </summary>
    [DataMember(Name="jobExpiryTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobExpiryTime")]
    public DateTime? JobExpiryTime { get; set; }

    /// <summary>
    /// Gets or Sets JobFinishedTime
    /// </summary>
    [DataMember(Name="jobFinishedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobFinishedTime")]
    public DateTime? JobFinishedTime { get; set; }

    /// <summary>
    /// Gets or Sets JobHasFpr
    /// </summary>
    [DataMember(Name="jobHasFpr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobHasFpr")]
    public bool? JobHasFpr { get; set; }

    /// <summary>
    /// Gets or Sets JobHasLog
    /// </summary>
    [DataMember(Name="jobHasLog", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobHasLog")]
    public bool? JobHasLog { get; set; }

    /// <summary>
    /// Gets or Sets JobQueuedTime
    /// </summary>
    [DataMember(Name="jobQueuedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobQueuedTime")]
    public DateTime? JobQueuedTime { get; set; }

    /// <summary>
    /// Gets or Sets JobStartedTime
    /// </summary>
    [DataMember(Name="jobStartedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobStartedTime")]
    public DateTime? JobStartedTime { get; set; }

    /// <summary>
    /// Gets or Sets JobState
    /// </summary>
    [DataMember(Name="jobState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobState")]
    public string JobState { get; set; }

    /// <summary>
    /// Gets or Sets JobToken
    /// </summary>
    [DataMember(Name="jobToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobToken")]
    public string JobToken { get; set; }

    /// <summary>
    /// Gets or Sets ProjectId
    /// </summary>
    [DataMember(Name="projectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectId")]
    public long? ProjectId { get; set; }

    /// <summary>
    /// Gets or Sets ProjectName
    /// </summary>
    [DataMember(Name="projectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectName")]
    public string ProjectName { get; set; }

    /// <summary>
    /// Gets or Sets PvId
    /// </summary>
    [DataMember(Name="pvId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pvId")]
    public long? PvId { get; set; }

    /// <summary>
    /// Gets or Sets PvName
    /// </summary>
    [DataMember(Name="pvName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pvName")]
    public string PvName { get; set; }

    /// <summary>
    /// Gets or Sets QueuedDuration
    /// </summary>
    [DataMember(Name="queuedDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "queuedDuration")]
    public long? QueuedDuration { get; set; }

    /// <summary>
    /// Gets or Sets ScaArgs
    /// </summary>
    [DataMember(Name="scaArgs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaArgs")]
    public string ScaArgs { get; set; }

    /// <summary>
    /// Gets or Sets ScaBuildId
    /// </summary>
    [DataMember(Name="scaBuildId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaBuildId")]
    public string ScaBuildId { get; set; }

    /// <summary>
    /// Gets or Sets ScaVersion
    /// </summary>
    [DataMember(Name="scaVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scaVersion")]
    public string ScaVersion { get; set; }

    /// <summary>
    /// Gets or Sets ScanDuration
    /// </summary>
    [DataMember(Name="scanDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scanDuration")]
    public long? ScanDuration { get; set; }

    /// <summary>
    /// Gets or Sets SubmitterEmail
    /// </summary>
    [DataMember(Name="submitterEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submitterEmail")]
    public string SubmitterEmail { get; set; }

    /// <summary>
    /// Gets or Sets SubmitterIpAddress
    /// </summary>
    [DataMember(Name="submitterIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submitterIpAddress")]
    public string SubmitterIpAddress { get; set; }

    /// <summary>
    /// Gets or Sets SubmitterUserName
    /// </summary>
    [DataMember(Name="submitterUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submitterUserName")]
    public string SubmitterUserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudJob {\n");
      sb.Append("  CloudPool: ").Append(CloudPool).Append("\n");
      sb.Append("  CloudWorker: ").Append(CloudWorker).Append("\n");
      sb.Append("  JobCancellable: ").Append(JobCancellable).Append("\n");
      sb.Append("  JobDuration: ").Append(JobDuration).Append("\n");
      sb.Append("  JobExpiryTime: ").Append(JobExpiryTime).Append("\n");
      sb.Append("  JobFinishedTime: ").Append(JobFinishedTime).Append("\n");
      sb.Append("  JobHasFpr: ").Append(JobHasFpr).Append("\n");
      sb.Append("  JobHasLog: ").Append(JobHasLog).Append("\n");
      sb.Append("  JobQueuedTime: ").Append(JobQueuedTime).Append("\n");
      sb.Append("  JobStartedTime: ").Append(JobStartedTime).Append("\n");
      sb.Append("  JobState: ").Append(JobState).Append("\n");
      sb.Append("  JobToken: ").Append(JobToken).Append("\n");
      sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
      sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
      sb.Append("  PvId: ").Append(PvId).Append("\n");
      sb.Append("  PvName: ").Append(PvName).Append("\n");
      sb.Append("  QueuedDuration: ").Append(QueuedDuration).Append("\n");
      sb.Append("  ScaArgs: ").Append(ScaArgs).Append("\n");
      sb.Append("  ScaBuildId: ").Append(ScaBuildId).Append("\n");
      sb.Append("  ScaVersion: ").Append(ScaVersion).Append("\n");
      sb.Append("  ScanDuration: ").Append(ScanDuration).Append("\n");
      sb.Append("  SubmitterEmail: ").Append(SubmitterEmail).Append("\n");
      sb.Append("  SubmitterIpAddress: ").Append(SubmitterIpAddress).Append("\n");
      sb.Append("  SubmitterUserName: ").Append(SubmitterUserName).Append("\n");
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
