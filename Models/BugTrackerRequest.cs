using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to test bugtracker plugin connection
  /// </summary>
  [DataContract]
  public class BugTrackerRequest {
    /// <summary>
    /// Bugtracker plugin information to test connection
    /// </summary>
    /// <value>Bugtracker plugin information to test connection</value>
    [DataMember(Name="testPlugin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "testPlugin")]
    public ProjectVersionBugTracker TestPlugin { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugTrackerRequest {\n");
      sb.Append("  TestPlugin: ").Append(TestPlugin).Append("\n");
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
