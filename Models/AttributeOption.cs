using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Attribute Option DTO object
  /// </summary>
  [DataContract]
  public class AttributeOption {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Unique string identifier for an Attribute Option
    /// </summary>
    /// <value>Unique string identifier for an Attribute Option</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Set to true if this option is to be hidden
    /// </summary>
    /// <value>Set to true if this option is to be hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// ID required with referencing an existing Attribute Option
    /// </summary>
    /// <value>ID required with referencing an existing Attribute Option</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Set to true if this option is being used
    /// </summary>
    /// <value>Set to true if this option is being used</value>
    [DataMember(Name="inUse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inUse")]
    public bool? InUse { get; set; }

    /// <summary>
    /// Index of this option in list of options
    /// </summary>
    /// <value>Index of this option in list of options</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    /// <value>Name</value>
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
    /// ID of Attribute Definition this option is associated with
    /// </summary>
    /// <value>ID of Attribute Definition this option is associated with</value>
    [DataMember(Name="projectMetaDataDefId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectMetaDataDefId")]
    public long? ProjectMetaDataDefId { get; set; }

    /// <summary>
    /// Gets or Sets PublishVersion
    /// </summary>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AttributeOption {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InUse: ").Append(InUse).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  ProjectMetaDataDefId: ").Append(ProjectMetaDataDefId).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
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
