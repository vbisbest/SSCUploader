using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Status of search index
  /// </summary>
  [DataContract]
  public class SearchIndexStatus {
    /// <summary>
    /// Is index configured
    /// </summary>
    /// <value>Is index configured</value>
    [DataMember(Name="configured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configured")]
    public bool? Configured { get; set; }

    /// <summary>
    /// Is the index Healthy
    /// </summary>
    /// <value>Is the index Healthy</value>
    [DataMember(Name="healthyIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "healthyIndex")]
    public bool? HealthyIndex { get; set; }

    /// <summary>
    /// Is the indexing job running
    /// </summary>
    /// <value>Is the indexing job running</value>
    [DataMember(Name="indexingJobRunning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "indexingJobRunning")]
    public bool? IndexingJobRunning { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SearchIndexStatus {\n");
      sb.Append("  Configured: ").Append(Configured).Append("\n");
      sb.Append("  HealthyIndex: ").Append(HealthyIndex).Append("\n");
      sb.Append("  IndexingJobRunning: ").Append(IndexingJobRunning).Append("\n");
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
