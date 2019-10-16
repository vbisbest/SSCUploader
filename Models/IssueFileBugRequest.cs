using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to file the bug from the issues
  /// </summary>
  [DataContract]
  public class IssueFileBugRequest {
    /// <summary>
    /// Bug param to file the bug
    /// </summary>
    /// <value>Bug param to file the bug</value>
    [DataMember(Name="bugParams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugParams")]
    public List<BugParam> BugParams { get; set; }

    /// <summary>
    /// Filter by property
    /// </summary>
    /// <value>Filter by property</value>
    [DataMember(Name="filterBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterBy")]
    public List<string> FilterBy { get; set; }

    /// <summary>
    /// Filterset
    /// </summary>
    /// <value>Filterset</value>
    [DataMember(Name="filterSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterSet")]
    public string FilterSet { get; set; }

    /// <summary>
    /// Instance id of issues that need to be filed as bugs
    /// </summary>
    /// <value>Instance id of issues that need to be filed as bugs</value>
    [DataMember(Name="issueInstanceIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueInstanceIds")]
    public List<string> IssueInstanceIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueFileBugRequest {\n");
      sb.Append("  BugParams: ").Append(BugParams).Append("\n");
      sb.Append("  FilterBy: ").Append(FilterBy).Append("\n");
      sb.Append("  FilterSet: ").Append(FilterSet).Append("\n");
      sb.Append("  IssueInstanceIds: ").Append(IssueInstanceIds).Append("\n");
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
