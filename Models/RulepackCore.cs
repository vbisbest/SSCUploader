using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Rulepack Core DTO object
  /// </summary>
  [DataContract]
  public class RulepackCore {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets Locale
    /// </summary>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets RulepackGUID
    /// </summary>
    [DataMember(Name="rulepackGUID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rulepackGUID")]
    public string RulepackGUID { get; set; }

    /// <summary>
    /// Gets or Sets RulepackType
    /// </summary>
    [DataMember(Name="rulepackType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rulepackType")]
    public string RulepackType { get; set; }

    /// <summary>
    /// Gets or Sets Sku
    /// </summary>
    [DataMember(Name="sku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets Versions
    /// </summary>
    [DataMember(Name="versions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versions")]
    public List<RulepackCore> Versions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RulepackCore {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RulepackGUID: ").Append(RulepackGUID).Append("\n");
      sb.Append("  RulepackType: ").Append(RulepackType).Append("\n");
      sb.Append("  Sku: ").Append(Sku).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Versions: ").Append(Versions).Append("\n");
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
