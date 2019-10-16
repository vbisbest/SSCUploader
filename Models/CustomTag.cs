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
  public class CustomTag {
    /// <summary>
    /// Custom tag type.
    /// </summary>
    /// <value>Custom tag type.</value>
    [DataMember(Name="customTagType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagType")]
    public string CustomTagType { get; set; }

    /// <summary>
    /// Default value of the custom tag. Actual string value is presented here.
    /// </summary>
    /// <value>Default value of the custom tag. Actual string value is presented here.</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// Index of default value of the custom tag. This is ordinal number of the item in CustomTagLookup collection.
    /// </summary>
    /// <value>Index of default value of the custom tag. This is ordinal number of the item in CustomTagLookup collection.</value>
    [DataMember(Name="defaultValueIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValueIndex")]
    public int? DefaultValueIndex { get; set; }

    /// <summary>
    /// Flag that says if custom tag can be deleted. Custom tag which values are currently in use cannot be deleted.
    /// </summary>
    /// <value>Flag that says if custom tag can be deleted. Custom tag which values are currently in use cannot be deleted.</value>
    [DataMember(Name="deletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletable")]
    public bool? Deletable { get; set; }

    /// <summary>
    /// Custom tag description.
    /// </summary>
    /// <value>Custom tag description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Flag that says if custom tag is extensible or not.
    /// </summary>
    /// <value>Flag that says if custom tag is extensible or not.</value>
    [DataMember(Name="extensible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extensible")]
    public bool? Extensible { get; set; }

    /// <summary>
    /// Custom tag GUID.
    /// </summary>
    /// <value>Custom tag GUID.</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Is custom tag hidden or not.
    /// </summary>
    /// <value>Is custom tag hidden or not.</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Custom tag id
    /// </summary>
    /// <value>Custom tag id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Is custom tag values are selected for any issues in the system.
    /// </summary>
    /// <value>Is custom tag values are selected for any issues in the system.</value>
    [DataMember(Name="inUse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inUse")]
    public bool? InUse { get; set; }

    /// <summary>
    /// Custom tag unique name.
    /// </summary>
    /// <value>Custom tag unique name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Custom tag version stored on the server. This value is used for optimistic locking of the custom tag object to prevent concurrent modification of the custom tag by different users at the same time.
    /// </summary>
    /// <value>Custom tag version stored on the server. This value is used for optimistic locking of the custom tag object to prevent concurrent modification of the custom tag by different users at the same time.</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// If this custom tag is set as primary tag for a specific application version. This value is initialized only if custom tags for specific application version are requested.
    /// </summary>
    /// <value>If this custom tag is set as primary tag for a specific application version. This value is initialized only if custom tags for specific application version are requested.</value>
    [DataMember(Name="primaryTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryTag")]
    public bool? PrimaryTag { get; set; }

    /// <summary>
    /// Flag is set to true if special permission is required to set values of this custom tag.
    /// </summary>
    /// <value>Flag is set to true if special permission is required to set values of this custom tag.</value>
    [DataMember(Name="restriction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restriction")]
    public bool? Restriction { get; set; }

    /// <summary>
    /// Special permission type if restriction is set to TRUE.
    /// </summary>
    /// <value>Special permission type if restriction is set to TRUE.</value>
    [DataMember(Name="restrictionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrictionType")]
    public string RestrictionType { get; set; }

    /// <summary>
    /// Collection of all possible custom tag values.
    /// </summary>
    /// <value>Collection of all possible custom tag values.</value>
    [DataMember(Name="valueList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueList")]
    public List<CustomTagLookup> ValueList { get; set; }

    /// <summary>
    /// Custom tag value type.
    /// </summary>
    /// <value>Custom tag value type.</value>
    [DataMember(Name="valueType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueType")]
    public string ValueType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CustomTag {\n");
      sb.Append("  CustomTagType: ").Append(CustomTagType).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  DefaultValueIndex: ").Append(DefaultValueIndex).Append("\n");
      sb.Append("  Deletable: ").Append(Deletable).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Extensible: ").Append(Extensible).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InUse: ").Append(InUse).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  PrimaryTag: ").Append(PrimaryTag).Append("\n");
      sb.Append("  Restriction: ").Append(Restriction).Append("\n");
      sb.Append("  RestrictionType: ").Append(RestrictionType).Append("\n");
      sb.Append("  ValueList: ").Append(ValueList).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
