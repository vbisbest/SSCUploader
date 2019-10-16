using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Attribute Definition DTO object.
  /// </summary>
  [DataContract]
  public class DynamicScanRequestParameterDefinition {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Unique string identifier for this parameter definition
    /// </summary>
    /// <value>Unique string identifier for this parameter definition</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Unique id for this parameter definition
    /// </summary>
    /// <value>Unique id for this parameter definition</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Set to true if required
    /// </summary>
    /// <value>Set to true if required</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Gets or Sets SequenceNumber
    /// </summary>
    [DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sequenceNumber")]
    public long? SequenceNumber { get; set; }

    /// <summary>
    /// Attribute Definition Type from which this parameter definition is based on
    /// </summary>
    /// <value>Attribute Definition Type from which this parameter definition is based on</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicScanRequestParameterDefinition {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
