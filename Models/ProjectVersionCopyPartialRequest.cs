using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to copy data selectively from one application version to another
  /// </summary>
  [DataContract]
  public class ProjectVersionCopyPartialRequest {
    /// <summary>
    /// Will copy analysis processing rules
    /// </summary>
    /// <value>Will copy analysis processing rules</value>
    [DataMember(Name="copyAnalysisProcessingRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copyAnalysisProcessingRules")]
    public bool? CopyAnalysisProcessingRules { get; set; }

    /// <summary>
    /// Will copy bugtracker configuration
    /// </summary>
    /// <value>Will copy bugtracker configuration</value>
    [DataMember(Name="copyBugTrackerConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copyBugTrackerConfiguration")]
    public bool? CopyBugTrackerConfiguration { get; set; }

    /// <summary>
    /// Will copy current state fpr
    /// </summary>
    /// <value>Will copy current state fpr</value>
    [DataMember(Name="copyCurrentStateFpr", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copyCurrentStateFpr")]
    public bool? CopyCurrentStateFpr { get; set; }

    /// <summary>
    /// Will copy custom tags
    /// </summary>
    /// <value>Will copy custom tags</value>
    [DataMember(Name="copyCustomTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "copyCustomTags")]
    public bool? CopyCustomTags { get; set; }

    /// <summary>
    /// Previous application version id
    /// </summary>
    /// <value>Previous application version id</value>
    [DataMember(Name="previousProjectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousProjectVersionId")]
    public long? PreviousProjectVersionId { get; set; }

    /// <summary>
    /// Application version id
    /// </summary>
    /// <value>Application version id</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionCopyPartialRequest {\n");
      sb.Append("  CopyAnalysisProcessingRules: ").Append(CopyAnalysisProcessingRules).Append("\n");
      sb.Append("  CopyBugTrackerConfiguration: ").Append(CopyBugTrackerConfiguration).Append("\n");
      sb.Append("  CopyCurrentStateFpr: ").Append(CopyCurrentStateFpr).Append("\n");
      sb.Append("  CopyCustomTags: ").Append(CopyCustomTags).Append("\n");
      sb.Append("  PreviousProjectVersionId: ").Append(PreviousProjectVersionId).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
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
