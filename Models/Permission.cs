using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A permission in the server
  /// </summary>
  [DataContract]
  public class Permission {
    /// <summary>
    /// Gets or Sets AssignByDefault
    /// </summary>
    [DataMember(Name="assignByDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignByDefault")]
    public bool? AssignByDefault { get; set; }

    /// <summary>
    /// Set of permissions this permission requires
    /// </summary>
    /// <value>Set of permissions this permission requires</value>
    [DataMember(Name="dependsOnPermission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dependsOnPermission")]
    public List<Permission> DependsOnPermission { get; set; }

    /// <summary>
    /// Permission description
    /// </summary>
    /// <value>Permission description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Permission id
    /// </summary>
    /// <value>Permission id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Permission name
    /// </summary>
    /// <value>Permission name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Actions this permission is allowed to perform
    /// </summary>
    /// <value>Actions this permission is allowed to perform</value>
    [DataMember(Name="permittedActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permittedActions")]
    public List<string> PermittedActions { get; set; }

    /// <summary>
    /// Flag is true if this permission can only be assigned to users, and not groups or organizations
    /// </summary>
    /// <value>Flag is true if this permission can only be assigned to users, and not groups or organizations</value>
    [DataMember(Name="userOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userOnly")]
    public bool? UserOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Permission {\n");
      sb.Append("  AssignByDefault: ").Append(AssignByDefault).Append("\n");
      sb.Append("  DependsOnPermission: ").Append(DependsOnPermission).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PermittedActions: ").Append(PermittedActions).Append("\n");
      sb.Append("  UserOnly: ").Append(UserOnly).Append("\n");
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
