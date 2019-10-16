using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// DTO object that holds the information about specific issue attribute that can be used for filtering issues list.
  /// </summary>
  [DataContract]
  public class IssueFilterSelector {
    /// <summary>
    /// Selector set's description.
    /// </summary>
    /// <value>Selector set's description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Selector set's display name.
    /// </summary>
    /// <value>Selector set's display name.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Type of the issue attriute that can be used for ordering or filtering.
    /// </summary>
    /// <value>Type of the issue attriute that can be used for ordering or filtering.</value>
    [DataMember(Name="entityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityType")]
    public string EntityType { get; set; }

    /// <summary>
    /// If value of the selector can be chose from the list of predefined values, or if it can contain any value defined by user.
    /// </summary>
    /// <value>If value of the selector can be chose from the list of predefined values, or if it can contain any value defined by user.</value>
    [DataMember(Name="filterSelectorType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterSelectorType")]
    public string FilterSelectorType { get; set; }

    /// <summary>
    /// Selector set's GUID.
    /// </summary>
    /// <value>Selector set's GUID.</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Selector set's options.
    /// </summary>
    /// <value>Selector set's options.</value>
    [DataMember(Name="selectorOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selectorOptions")]
    public List<SelectorOption> SelectorOptions { get; set; }

    /// <summary>
    /// Selector set's value that must be sent to backend when this option is selected.
    /// </summary>
    /// <value>Selector set's value that must be sent to backend when this option is selected.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueFilterSelector {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  EntityType: ").Append(EntityType).Append("\n");
      sb.Append("  FilterSelectorType: ").Append(FilterSelectorType).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  SelectorOptions: ").Append(SelectorOptions).Append("\n");
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
