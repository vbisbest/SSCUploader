using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Performance indicators enable you to combine variables into metrics that are normalized across application version boundaries
  /// </summary>
  [DataContract]
  public class PerformanceIndicator {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Equation
    /// </summary>
    [DataMember(Name="equation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "equation")]
    public string Equation { get; set; }

    /// <summary>
    /// Gets or Sets Guid
    /// </summary>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets InUse
    /// </summary>
    [DataMember(Name="inUse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inUse")]
    public bool? InUse { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ObjectVersion
    /// </summary>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// Gets or Sets PublishVersion
    /// </summary>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }

    /// <summary>
    /// Gets or Sets Range
    /// </summary>
    [DataMember(Name="range", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range")]
    public string Range { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [DataMember(Name="variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variables")]
    public List<Variable> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PerformanceIndicator {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Equation: ").Append(Equation).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InUse: ").Append(InUse).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
      sb.Append("  Range: ").Append(Range).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Variables: ").Append(Variables).Append("\n");
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
