using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Custom tag value
  /// </summary>
  [DataContract]
  public class CustomTagLookup {
    /// <summary>
    /// Flag that should be used to mark values that mean \"not an issue\" or \"false positive\".
    /// </summary>
    /// <value>Flag that should be used to mark values that mean \"not an issue\" or \"false positive\".</value>
    [DataMember(Name="consideredIssue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consideredIssue")]
    public bool? ConsideredIssue { get; set; }

    /// <summary>
    /// GUID of the parent custom tag this value belongs to.
    /// </summary>
    /// <value>GUID of the parent custom tag this value belongs to.</value>
    [DataMember(Name="customTagGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagGuid")]
    public string CustomTagGuid { get; set; }

    /// <summary>
    /// Flag that says if this value is default custom tag value and should be selected automatically in the values list on issue audit screen.
    /// </summary>
    /// <value>Flag that says if this value is default custom tag value and should be selected automatically in the values list on issue audit screen.</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public bool? DefaultValue { get; set; }

    /// <summary>
    /// Flag that says if this value can be removed from custom tag. Value cannot be removed if it is selected for some issue in the system.
    /// </summary>
    /// <value>Flag that says if this value can be removed from custom tag. Value cannot be removed if it is selected for some issue in the system.</value>
    [DataMember(Name="deletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletable")]
    public bool? Deletable { get; set; }

    /// <summary>
    /// Custom tag value description.
    /// </summary>
    /// <value>Custom tag value description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Flag that says that this value is hidden and cannot be selected in issue audit mode.
    /// </summary>
    /// <value>Flag that says that this value is hidden and cannot be selected in issue audit mode.</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Current value index in values list.
    /// </summary>
    /// <value>Current value index in values list.</value>
    [DataMember(Name="lookupIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lookupIndex")]
    public int? LookupIndex { get; set; }

    /// <summary>
    /// Plain text custom tag value.
    /// </summary>
    /// <value>Plain text custom tag value.</value>
    [DataMember(Name="lookupValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lookupValue")]
    public string LookupValue { get; set; }

    /// <summary>
    /// List of relying custom tags and their values this value depends on. This list should be set to automatically reflect relying custom tags values changes to this custom tag value
    /// </summary>
    /// <value>List of relying custom tags and their values this value depends on. This list should be set to automatically reflect relying custom tags values changes to this custom tag value</value>
    [DataMember(Name="relyingCustomTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relyingCustomTags")]
    public List<CustomTagInfo> RelyingCustomTags { get; set; }

    /// <summary>
    /// Custom tag value sequence number.
    /// </summary>
    /// <value>Custom tag value sequence number.</value>
    [DataMember(Name="seqNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seqNumber")]
    public int? SeqNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomTagLookup {\n");
      sb.Append("  ConsideredIssue: ").Append(ConsideredIssue).Append("\n");
      sb.Append("  CustomTagGuid: ").Append(CustomTagGuid).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Deletable: ").Append(Deletable).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  LookupIndex: ").Append(LookupIndex).Append("\n");
      sb.Append("  LookupValue: ").Append(LookupValue).Append("\n");
      sb.Append("  RelyingCustomTags: ").Append(RelyingCustomTags).Append("\n");
      sb.Append("  SeqNumber: ").Append(SeqNumber).Append("\n");
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
