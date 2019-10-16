using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to audit issues
  /// </summary>
  [DataContract]
  public class IssueAuditRequest {
    /// <summary>
    /// Comment
    /// </summary>
    /// <value>Comment</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Custom tag values that are set for the issue.
    /// </summary>
    /// <value>Custom tag values that are set for the issue.</value>
    [DataMember(Name="customTagAudit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagAudit")]
    public List<CustomTag> CustomTagAudit { get; set; }

    /// <summary>
    /// Issues to audit
    /// </summary>
    /// <value>Issues to audit</value>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public List<EntityStateIdentifier> Issues { get; set; }

    /// <summary>
    /// Will suppress the issue
    /// </summary>
    /// <value>Will suppress the issue</value>
    [DataMember(Name="suppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressed")]
    public bool? Suppressed { get; set; }

    /// <summary>
    /// Username to assign
    /// </summary>
    /// <value>Username to assign</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "user")]
    public string User { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAuditRequest {\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  CustomTagAudit: ").Append(CustomTagAudit).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
      sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
      sb.Append("  User: ").Append(User).Append("\n");
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
