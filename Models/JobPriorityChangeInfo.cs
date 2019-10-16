using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Job priority change information
  /// </summary>
  [DataContract]
  public class JobPriorityChangeInfo {
    /// <summary>
    /// Number of the warnings of for the specific job class.
    /// </summary>
    /// <value>Number of the warnings of for the specific job class.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Job class name.
    /// </summary>
    /// <value>Job class name.</value>
    [DataMember(Name="jobClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "jobClassName")]
    public string JobClassName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobPriorityChangeInfo {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  JobClassName: ").Append(JobClassName).Append("\n");
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
