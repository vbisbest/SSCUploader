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
  public class Folder {
    /// <summary>
    /// Color that should be used to represent folder on UI
    /// </summary>
    /// <value>Color that should be used to represent folder on UI</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// Folder description
    /// </summary>
    /// <value>Folder description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Is folder editable
    /// </summary>
    /// <value>Is folder editable</value>
    [DataMember(Name="editable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editable")]
    public bool? Editable { get; set; }

    /// <summary>
    /// Folder GUID. Guid is unique across all the folders defined for a application version
    /// </summary>
    /// <value>Folder GUID. Guid is unique across all the folders defined for a application version</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Folder id
    /// </summary>
    /// <value>Folder id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Folder name
    /// </summary>
    /// <value>Folder name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Numeric value used for ordering folder from the most important to the least important
    /// </summary>
    /// <value>Numeric value used for ordering folder from the most important to the least important</value>
    [DataMember(Name="orderIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderIndex")]
    public int? OrderIndex { get; set; }

    /// <summary>
    /// ID of the application version for which folder is defined
    /// </summary>
    /// <value>ID of the application version for which folder is defined</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Folder {\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Editable: ").Append(Editable).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OrderIndex: ").Append(OrderIndex).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
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
