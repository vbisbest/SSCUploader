using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to test whether application with provided name exists
  /// </summary>
  [DataContract]
  public class ApplicationNameTestRequest {
    /// <summary>
    /// application name to test
    /// </summary>
    /// <value>application name to test</value>
    [DataMember(Name="applicationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationName")]
    public string ApplicationName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationNameTestRequest {\n");
      sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
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
