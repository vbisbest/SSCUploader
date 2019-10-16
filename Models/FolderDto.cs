using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issues folder. This is a readonly object, it cannot be created using SSC API.
  /// </summary>
  [DataContract]
  public class FolderDto {
    /// <summary>
    /// Folder color. Folder will be marked by this color on UI
    /// </summary>
    /// <value>Folder color. Folder will be marked by this color on UI</value>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public string Color { get; set; }

    /// <summary>
    /// Folder GUID.
    /// </summary>
    /// <value>Folder GUID.</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Unique identifier of the folder.
    /// </summary>
    /// <value>Unique identifier of the folder.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Folder unique name.
    /// </summary>
    /// <value>Folder unique name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FolderDto {\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
