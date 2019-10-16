using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Holds the details about existed list custom tag value that is assigned or linked with some other entity
  /// </summary>
  [DataContract]
  public class CustomTagLookupInfo {
    /// <summary>
    /// Current value index in values list
    /// </summary>
    /// <value>Current value index in values list</value>
    [DataMember(Name="lookupIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lookupIndex")]
    public int? LookupIndex { get; set; }

    /// <summary>
    /// Plain text custom tag value
    /// </summary>
    /// <value>Plain text custom tag value</value>
    [DataMember(Name="lookupValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lookupValue")]
    public string LookupValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomTagLookupInfo {\n");
      sb.Append("  LookupIndex: ").Append(LookupIndex).Append("\n");
      sb.Append("  LookupValue: ").Append(LookupValue).Append("\n");
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
