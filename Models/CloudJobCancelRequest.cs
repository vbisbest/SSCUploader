using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to cancel cloudscan jobs
  /// </summary>
  [DataContract]
  public class CloudJobCancelRequest {
    /// <summary>
    /// List containing single cloud job token to cancel
    /// </summary>
    /// <value>List containing single cloud job token to cancel</value>
    [DataMember(Name="jobTokens", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobTokens")]
    public List<string> JobTokens { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudJobCancelRequest {\n");
      sb.Append("  JobTokens: ").Append(JobTokens).Append("\n");
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
