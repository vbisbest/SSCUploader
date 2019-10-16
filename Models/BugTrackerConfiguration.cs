using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Bug tracker Configuration DTO object
  /// </summary>
  [DataContract]
  public class BugTrackerConfiguration {
    /// <summary>
    /// Description
    /// </summary>
    /// <value>Description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Configuration name
    /// </summary>
    /// <value>Configuration name</value>
    [DataMember(Name="displayLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayLabel")]
    public string DisplayLabel { get; set; }

    /// <summary>
    /// Identifier
    /// </summary>
    /// <value>Identifier</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Set to true if configuration is required
    /// </summary>
    /// <value>Set to true if configuration is required</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Configuration value
    /// </summary>
    /// <value>Configuration value</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugTrackerConfiguration {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
