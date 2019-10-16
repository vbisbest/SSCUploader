using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Job DTO object
  /// </summary>
  [DataContract]
  public class Job {
    /// <summary>
    /// Artifact name related to this job
    /// </summary>
    /// <value>Artifact name related to this job</value>
    [DataMember(Name="artifactName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactName")]
    public string ArtifactName { get; set; }

    /// <summary>
    /// Set to true if job is cancelable
    /// </summary>
    /// <value>Set to true if job is cancelable</value>
    [DataMember(Name="cancellable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancellable")]
    public bool? Cancellable { get; set; }

    /// <summary>
    /// Job execution order
    /// </summary>
    /// <value>Job execution order</value>
    [DataMember(Name="executionOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "executionOrder")]
    public double? ExecutionOrder { get; set; }

    /// <summary>
    /// End time of job
    /// </summary>
    /// <value>End time of job</value>
    [DataMember(Name="finishTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finishTime")]
    public DateTime? FinishTime { get; set; }

    /// <summary>
    /// Job class
    /// </summary>
    /// <value>Job class</value>
    [DataMember(Name="jobClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobClass")]
    public string JobClass { get; set; }

    /// <summary>
    /// Job data
    /// </summary>
    /// <value>Job data</value>
    [DataMember(Name="jobData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobData")]
    public Object JobData { get; set; }

    /// <summary>
    /// Job group
    /// </summary>
    /// <value>Job group</value>
    [DataMember(Name="jobGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobGroup")]
    public string JobGroup { get; set; }

    /// <summary>
    /// identifier of job
    /// </summary>
    /// <value>identifier of job</value>
    [DataMember(Name="jobName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobName")]
    public string JobName { get; set; }

    /// <summary>
    /// Job priority
    /// </summary>
    /// <value>Job priority</value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Application name related to this job
    /// </summary>
    /// <value>Application name related to this job</value>
    [DataMember(Name="projectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectName")]
    public string ProjectName { get; set; }

    /// <summary>
    /// Application version identifier related to this job
    /// </summary>
    /// <value>Application version identifier related to this job</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Application version name related to this job
    /// </summary>
    /// <value>Application version name related to this job</value>
    [DataMember(Name="projectVersionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionName")]
    public string ProjectVersionName { get; set; }

    /// <summary>
    /// Start time of job
    /// </summary>
    /// <value>Start time of job</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Job State
    /// </summary>
    /// <value>Job State</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Name of user this job was created by
    /// </summary>
    /// <value>Name of user this job was created by</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Job {\n");
      sb.Append("  ArtifactName: ").Append(ArtifactName).Append("\n");
      sb.Append("  Cancellable: ").Append(Cancellable).Append("\n");
      sb.Append("  ExecutionOrder: ").Append(ExecutionOrder).Append("\n");
      sb.Append("  FinishTime: ").Append(FinishTime).Append("\n");
      sb.Append("  JobClass: ").Append(JobClass).Append("\n");
      sb.Append("  JobData: ").Append(JobData).Append("\n");
      sb.Append("  JobGroup: ").Append(JobGroup).Append("\n");
      sb.Append("  JobName: ").Append(JobName).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  ProjectVersionName: ").Append(ProjectVersionName).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
