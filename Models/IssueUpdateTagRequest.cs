using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to update custom tag for the issues
  /// </summary>
  [DataContract]
  public class IssueUpdateTagRequest {
    /// <summary>
    /// Custom tag values that are set for the issue.
    /// </summary>
    /// <value>Custom tag values that are set for the issue.</value>
    [DataMember(Name="customTagAudit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagAudit")]
    public CustomTag CustomTagAudit { get; set; }

    /// <summary>
    /// Issues to audit
    /// </summary>
    /// <value>Issues to audit</value>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public List<EntityStateIdentifier> Issues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueUpdateTagRequest {\n");
      sb.Append("  CustomTagAudit: ").Append(CustomTagAudit).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
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
