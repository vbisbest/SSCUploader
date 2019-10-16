using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue audit result contains the most rescent issue audit information after performing issue audit.
  /// </summary>
  [DataContract]
  public class IssueAuditResult {
    /// <summary>
    /// Custom tag values that are set for the issue.
    /// </summary>
    /// <value>Custom tag values that are set for the issue.</value>
    [DataMember(Name="customTagValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagValues")]
    public List<CustomTag> CustomTagValues { get; set; }

    /// <summary>
    /// Audited issue ID.
    /// </summary>
    /// <value>Audited issue ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Issue instance ID.
    /// </summary>
    /// <value>Issue instance ID.</value>
    [DataMember(Name="issueInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueInstanceId")]
    public string IssueInstanceId { get; set; }

    /// <summary>
    /// ID of the application version the audited issue belongs to.
    /// </summary>
    /// <value>ID of the application version the audited issue belongs to.</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Audited issue revision.
    /// </summary>
    /// <value>Audited issue revision.</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// Is issue suppressed.
    /// </summary>
    /// <value>Is issue suppressed.</value>
    [DataMember(Name="suppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressed")]
    public bool? Suppressed { get; set; }

    /// <summary>
    /// User assigned to the audited issue.
    /// </summary>
    /// <value>User assigned to the audited issue.</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAuditResult {\n");
      sb.Append("  CustomTagValues: ").Append(CustomTagValues).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IssueInstanceId: ").Append(IssueInstanceId).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
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
