using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// SSC application configuration property
  /// </summary>
  [DataContract]
  public class ConfigProperty {
    /// <summary>
    /// Should the SSC server be restarted after changing value of the property to apply the changes.
    /// </summary>
    /// <value>Should the SSC server be restarted after changing value of the property to apply the changes.</value>
    [DataMember(Name="appliedAfterRestarting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appliedAfterRestarting")]
    public bool? AppliedAfterRestarting { get; set; }

    /// <summary>
    /// Meta information about how the property's value should be validated on the client side.
    /// </summary>
    /// <value>Meta information about how the property's value should be validated on the client side.</value>
    [DataMember(Name="configPropertyValueValidation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configPropertyValueValidation")]
    public ConfigPropertyValueValidation ConfigPropertyValueValidation { get; set; }

    /// <summary>
    /// Property description.
    /// </summary>
    /// <value>Property description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Parent group name the property belongs to.
    /// </summary>
    /// <value>Parent group name the property belongs to.</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// Flag is set to TRUE if property is allowed to be edited on UI.
    /// </summary>
    /// <value>Flag is set to TRUE if property is allowed to be edited on UI.</value>
    [DataMember(Name="groupSwitchEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupSwitchEnabled")]
    public bool? GroupSwitchEnabled { get; set; }

    /// <summary>
    /// Configuration property unique name.
    /// </summary>
    /// <value>Configuration property unique name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Property value type.
    /// </summary>
    /// <value>Property value type.</value>
    [DataMember(Name="propertyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyType")]
    public string PropertyType { get; set; }

    /// <summary>
    /// If special permission is required to get value of this property.
    /// </summary>
    /// <value>If special permission is required to get value of this property.</value>
    [DataMember(Name="protectedOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "protectedOption")]
    public bool? ProtectedOption { get; set; }

    /// <summary>
    /// Flag is set to TRUE if this property is required and always must have non empty value.
    /// </summary>
    /// <value>Flag is set to TRUE if this property is required and always must have non empty value.</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Parent subgroup name the property belongs to.
    /// </summary>
    /// <value>Parent subgroup name the property belongs to.</value>
    [DataMember(Name="subGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subGroup")]
    public string SubGroup { get; set; }

    /// <summary>
    /// Configuration property value.
    /// </summary>
    /// <value>Configuration property value.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// List of allowed property values if property type is OPTIONLIST or DYNAMIC_OPTIONLIST.
    /// </summary>
    /// <value>List of allowed property values if property type is OPTIONLIST or DYNAMIC_OPTIONLIST.</value>
    [DataMember(Name="valuesList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valuesList")]
    public List<ConfigPropertyValueItem> ValuesList { get; set; }

    /// <summary>
    /// Configuration property version stored on the server. This value is used for optimistic locking of the property object to prevent concurrent changes of the property value by different users at the same time.
    /// </summary>
    /// <value>Configuration property version stored on the server. This value is used for optimistic locking of the property object to prevent concurrent changes of the property value by different users at the same time.</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public int? Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigProperty {\n");
      sb.Append("  AppliedAfterRestarting: ").Append(AppliedAfterRestarting).Append("\n");
      sb.Append("  ConfigPropertyValueValidation: ").Append(ConfigPropertyValueValidation).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  GroupSwitchEnabled: ").Append(GroupSwitchEnabled).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
      sb.Append("  ProtectedOption: ").Append(ProtectedOption).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  SubGroup: ").Append(SubGroup).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  ValuesList: ").Append(ValuesList).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
