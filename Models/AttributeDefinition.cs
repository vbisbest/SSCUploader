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
  public class AttributeDefinition {
    /// <summary>
    /// Application Entity Type
    /// </summary>
    /// <value>Application Entity Type</value>
    [DataMember(Name="appEntityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appEntityType")]
    public string AppEntityType { get; set; }

    /// <summary>
    /// Attribute Definition Category
    /// </summary>
    /// <value>Attribute Definition Category</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Unique string identifier for this Attribute Definition
    /// </summary>
    /// <value>Unique string identifier for this Attribute Definition</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Set to true if this Attribute Definition should be the default
    /// </summary>
    /// <value>Set to true if this Attribute Definition should be the default</value>
    [DataMember(Name="hasDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasDefault")]
    public bool? HasDefault { get; set; }

    /// <summary>
    /// Set to true if this Attribute Definition is hidden
    /// </summary>
    /// <value>Set to true if this Attribute Definition is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// ID required when referencing an existing Attribute Definition
    /// </summary>
    /// <value>ID required when referencing an existing Attribute Definition</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Can Attribute Definition be deleted
    /// </summary>
    /// <value>Can Attribute Definition be deleted</value>
    [DataMember(Name="isDeletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDeletable")]
    public bool? IsDeletable { get; set; }

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
    /// List of options (i.e. values) associated with this Attribute Definition
    /// </summary>
    /// <value>List of options (i.e. values) associated with this Attribute Definition</value>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public List<AttributeOption> Options { get; set; }

    /// <summary>
    /// Gets or Sets PublishVersion
    /// </summary>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }

    /// <summary>
    /// Set to true if this Attribute Definition is required
    /// </summary>
    /// <value>Set to true if this Attribute Definition is required</value>
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
    /// System Usage Type
    /// </summary>
    /// <value>System Usage Type</value>
    [DataMember(Name="systemUsage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systemUsage")]
    public string SystemUsage { get; set; }

    /// <summary>
    /// Attribute Definition Type
    /// </summary>
    /// <value>Attribute Definition Type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AttributeDefinition {\n");
      sb.Append("  AppEntityType: ").Append(AppEntityType).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  HasDefault: ").Append(HasDefault).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsDeletable: ").Append(IsDeletable).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
      sb.Append("  SystemUsage: ").Append(SystemUsage).Append("\n");
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
