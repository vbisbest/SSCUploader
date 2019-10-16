using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Variables count issues, conditions, and other categories of numeric data.
  /// </summary>
  [DataContract]
  public class Variable {
    /// <summary>
    /// Gets or Sets AttributeForOperation
    /// </summary>
    [DataMember(Name="attributeForOperation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeForOperation")]
    public string AttributeForOperation { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Select a folder from the default filter set to associate with the variable.
    /// </summary>
    /// <value>Select a folder from the default filter set to associate with the variable.</value>
    [DataMember(Name="folderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folderName")]
    public string FolderName { get; set; }

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
    /// Gets or Sets Operation
    /// </summary>
    [DataMember(Name="operation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operation")]
    public string Operation { get; set; }

    /// <summary>
    /// Gets or Sets PublishVersion
    /// </summary>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }

    /// <summary>
    /// Gets or Sets SearchString
    /// </summary>
    [DataMember(Name="searchString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchString")]
    public string SearchString { get; set; }

    /// <summary>
    /// Gets or Sets VariableType
    /// </summary>
    [DataMember(Name="variableType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableType")]
    public string VariableType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Variable {\n");
      sb.Append("  AttributeForOperation: ").Append(AttributeForOperation).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FolderName: ").Append(FolderName).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InUse: ").Append(InUse).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  Operation: ").Append(Operation).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
      sb.Append("  SearchString: ").Append(SearchString).Append("\n");
      sb.Append("  VariableType: ").Append(VariableType).Append("\n");
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
