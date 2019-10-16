using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to clear the specified bug links from the application version
  /// </summary>
  [DataContract]
  public class ProjectVersionClearBugLinksRequest {
    /// <summary>
    /// Identifying information for the bug links to be cleared. (The format of an externalBugId depends on the SSC bug tracker plugin which filed the bug)
    /// </summary>
    /// <value>Identifying information for the bug links to be cleared. (The format of an externalBugId depends on the SSC bug tracker plugin which filed the bug)</value>
    [DataMember(Name="externalBugIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalBugIds")]
    public List<string> ExternalBugIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionClearBugLinksRequest {\n");
      sb.Append("  ExternalBugIds: ").Append(ExternalBugIds).Append("\n");
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
