using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Bugfield Template Group
  /// </summary>
  [DataContract]
  public class BugfieldTemplateGroupDto {
    /// <summary>
    /// Identifier of the bug tracker plugin associated with this template group.
    /// </summary>
    /// <value>Identifier of the bug tracker plugin associated with this template group.</value>
    [DataMember(Name="bugTrackerPluginId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTrackerPluginId")]
    public string BugTrackerPluginId { get; set; }

    /// <summary>
    /// Flag that says if bugfield template group can be deleted.
    /// </summary>
    /// <value>Flag that says if bugfield template group can be deleted.</value>
    [DataMember(Name="deletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletable")]
    public bool? Deletable { get; set; }

    /// <summary>
    /// description for bugfield template group.
    /// </summary>
    /// <value>description for bugfield template group.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// unique identifier of bugfield template group.
    /// </summary>
    /// <value>unique identifier of bugfield template group.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// short name of associated bug tracker plugin. (May be null if plugin is not currently enabled.)
    /// </summary>
    /// <value>short name of associated bug tracker plugin. (May be null if plugin is not currently enabled.)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// version of bugfield template group stored on the server. This value is used for optimistic locking to prevent concurrent modification by different users at the same time.
    /// </summary>
    /// <value>version of bugfield template group stored on the server. This value is used for optimistic locking to prevent concurrent modification by different users at the same time.</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// Collection of all templates belonging to this bugfield template group.
    /// </summary>
    /// <value>Collection of all templates belonging to this bugfield template group.</value>
    [DataMember(Name="valueList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueList")]
    public List<BugfieldTemplateDto> ValueList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugfieldTemplateGroupDto {\n");
      sb.Append("  BugTrackerPluginId: ").Append(BugTrackerPluginId).Append("\n");
      sb.Append("  Deletable: ").Append(Deletable).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  ValueList: ").Append(ValueList).Append("\n");
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
