using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// user assigned to issue
  /// </summary>
  [DataContract]
  public class AssignedUser {
    /// <summary>
    /// whether the assigned user currently has access to the application version in current context
    /// </summary>
    /// <value>whether the assigned user currently has access to the application version in current context</value>
    [DataMember(Name="hasAccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasAccess")]
    public bool? HasAccess { get; set; }

    /// <summary>
    /// username assigned to issue
    /// </summary>
    /// <value>username assigned to issue</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssignedUser {\n");
      sb.Append("  HasAccess: ").Append(HasAccess).Append("\n");
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
