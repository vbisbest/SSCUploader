using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Response of validating connection credentials and returns bug filing requirements
  /// </summary>
  [DataContract]
  public class BugFilingRequirementsResponse {
    /// <summary>
    /// Requirements to file the bugs
    /// </summary>
    /// <value>Requirements to file the bugs</value>
    [DataMember(Name="bugFilingRequirements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugFilingRequirements")]
    public BugFilingRequirements BugFilingRequirements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugFilingRequirementsResponse {\n");
      sb.Append("  BugFilingRequirements: ").Append(BugFilingRequirements).Append("\n");
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
