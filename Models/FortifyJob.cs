using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Fortify job DTO object, carries less information than the main Job DTO. Used primarily for the snapshot refresh which be initiated by a non-admin user
  /// </summary>
  [DataContract]
  public class FortifyJob {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// SSC username which initiated the job
    /// </summary>
    /// <value>SSC username which initiated the job</value>
    [DataMember(Name="invokingUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invokingUserName")]
    public string InvokingUserName { get; set; }

    /// <summary>
    /// Gets or Sets JobState
    /// </summary>
    [DataMember(Name="jobState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobState")]
    public int? JobState { get; set; }

    /// <summary>
    /// Gets or Sets JobType
    /// </summary>
    [DataMember(Name="jobType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobType")]
    public int? JobType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FortifyJob {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvokingUserName: ").Append(InvokingUserName).Append("\n");
      sb.Append("  JobState: ").Append(JobState).Append("\n");
      sb.Append("  JobType: ").Append(JobType).Append("\n");
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
