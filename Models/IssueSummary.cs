using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Used to chart variable and performance indicators of application version&#39;s issues.
  /// </summary>
  [DataContract]
  public class IssueSummary {
    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Series
    /// </summary>
    [DataMember(Name="series", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "series")]
    public List<Object> Series { get; set; }

    /// <summary>
    /// Gets or Sets TotalIssueCount
    /// </summary>
    [DataMember(Name="totalIssueCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalIssueCount")]
    public long? TotalIssueCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueSummary {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Series: ").Append(Series).Append("\n");
      sb.Append("  TotalIssueCount: ").Append(TotalIssueCount).Append("\n");
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
