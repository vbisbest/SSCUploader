using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BugFilingRequirements {
    /// <summary>
    /// Gets or Sets BugParams
    /// </summary>
    [DataMember(Name="bugParams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugParams")]
    public List<BugParam> BugParams { get; set; }

    /// <summary>
    /// Gets or Sets BugTrackerLongDisplayName
    /// </summary>
    [DataMember(Name="bugTrackerLongDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTrackerLongDisplayName")]
    public string BugTrackerLongDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets BugTrackerShortDisplayName
    /// </summary>
    [DataMember(Name="bugTrackerShortDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTrackerShortDisplayName")]
    public string BugTrackerShortDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets RequiresAuthentication
    /// </summary>
    [DataMember(Name="requiresAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requiresAuthentication")]
    public bool? RequiresAuthentication { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugFilingRequirements {\n");
      sb.Append("  BugParams: ").Append(BugParams).Append("\n");
      sb.Append("  BugTrackerLongDisplayName: ").Append(BugTrackerLongDisplayName).Append("\n");
      sb.Append("  BugTrackerShortDisplayName: ").Append(BugTrackerShortDisplayName).Append("\n");
      sb.Append("  RequiresAuthentication: ").Append(RequiresAuthentication).Append("\n");
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
