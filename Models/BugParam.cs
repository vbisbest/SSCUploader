using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class BugParam {
    /// <summary>
    /// Gets or Sets BugParamType
    /// </summary>
    [DataMember(Name="bugParamType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugParamType")]
    public string BugParamType { get; set; }

    /// <summary>
    /// Gets or Sets ChoiceList
    /// </summary>
    [DataMember(Name="choiceList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "choiceList")]
    public List<string> ChoiceList { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DisplayLabel
    /// </summary>
    [DataMember(Name="displayLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayLabel")]
    public string DisplayLabel { get; set; }

    /// <summary>
    /// Gets or Sets HasDependentParams
    /// </summary>
    [DataMember(Name="hasDependentParams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasDependentParams")]
    public bool? HasDependentParams { get; set; }

    /// <summary>
    /// Gets or Sets Identifier
    /// </summary>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets MaxLength
    /// </summary>
    [DataMember(Name="maxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLength")]
    public int? MaxLength { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugParam {\n");
      sb.Append("  BugParamType: ").Append(BugParamType).Append("\n");
      sb.Append("  ChoiceList: ").Append(ChoiceList).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayLabel: ").Append(DisplayLabel).Append("\n");
      sb.Append("  HasDependentParams: ").Append(HasDependentParams).Append("\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
