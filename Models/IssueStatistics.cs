using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue Statistics DTO object
  /// </summary>
  [DataContract]
  public class IssueStatistics {
    /// <summary>
    /// Filter set identifier
    /// </summary>
    /// <value>Filter set identifier</value>
    [DataMember(Name="filterSetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterSetId")]
    public long? FilterSetId { get; set; }

    /// <summary>
    /// Total number of hidden issues in the application version
    /// </summary>
    /// <value>Total number of hidden issues in the application version</value>
    [DataMember(Name="hiddenCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hiddenCount")]
    public int? HiddenCount { get; set; }

    /// <summary>
    /// Number of displayable hidden issues in the application version
    /// </summary>
    /// <value>Number of displayable hidden issues in the application version</value>
    [DataMember(Name="hiddenDisplayableCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hiddenDisplayableCount")]
    public int? HiddenDisplayableCount { get; set; }

    /// <summary>
    /// Application version identifier
    /// </summary>
    /// <value>Application version identifier</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Total number of removed issues 
    /// </summary>
    /// <value>Total number of removed issues </value>
    [DataMember(Name="removedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removedCount")]
    public int? RemovedCount { get; set; }

    /// <summary>
    /// Number of displayable removed issues  in the application version
    /// </summary>
    /// <value>Number of displayable removed issues  in the application version</value>
    [DataMember(Name="removedDisplayableCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removedDisplayableCount")]
    public int? RemovedDisplayableCount { get; set; }

    /// <summary>
    /// Total number of suppressed issues in the application version
    /// </summary>
    /// <value>Total number of suppressed issues in the application version</value>
    [DataMember(Name="suppressedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressedCount")]
    public int? SuppressedCount { get; set; }

    /// <summary>
    /// Number of displayable suppressed issues in the application version
    /// </summary>
    /// <value>Number of displayable suppressed issues in the application version</value>
    [DataMember(Name="suppressedDisplayableCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressedDisplayableCount")]
    public int? SuppressedDisplayableCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueStatistics {\n");
      sb.Append("  FilterSetId: ").Append(FilterSetId).Append("\n");
      sb.Append("  HiddenCount: ").Append(HiddenCount).Append("\n");
      sb.Append("  HiddenDisplayableCount: ").Append(HiddenDisplayableCount).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  RemovedCount: ").Append(RemovedCount).Append("\n");
      sb.Append("  RemovedDisplayableCount: ").Append(RemovedDisplayableCount).Append("\n");
      sb.Append("  SuppressedCount: ").Append(SuppressedCount).Append("\n");
      sb.Append("  SuppressedDisplayableCount: ").Append(SuppressedDisplayableCount).Append("\n");
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
