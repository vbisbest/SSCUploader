using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to assign user to the issues
  /// </summary>
  [DataContract]
  public class IssueAssignUserRequest {
    /// <summary>
    /// Issues to audit
    /// </summary>
    /// <value>Issues to audit</value>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public List<EntityStateIdentifier> Issues { get; set; }

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
      sb.Append("class IssueAssignUserRequest {\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
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
