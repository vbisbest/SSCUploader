using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to cancel jobs
  /// </summary>
  [DataContract]
  public class JobCancelRequest {
    /// <summary>
    /// List containing single job ID to cancel
    /// </summary>
    /// <value>List containing single job ID to cancel</value>
    [DataMember(Name="jobIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobIds")]
    public List<string> JobIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobCancelRequest {\n");
      sb.Append("  JobIds: ").Append(JobIds).Append("\n");
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
