using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Role used by the server to determine user permissions
  /// </summary>
  [DataContract]
  public class Role {
    /// <summary>
    /// True if a user with this Role has access to all Application Versions
    /// </summary>
    /// <value>True if a user with this Role has access to all Application Versions</value>
    [DataMember(Name="allApplicationRole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allApplicationRole")]
    public bool? AllApplicationRole { get; set; }

    /// <summary>
    /// True if this Role is currently assigned to entities that are not users(groups, organizations, etc.)
    /// </summary>
    /// <value>True if this Role is currently assigned to entities that are not users(groups, organizations, etc.)</value>
    [DataMember(Name="assignedToNonUsers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignedToNonUsers")]
    public bool? AssignedToNonUsers { get; set; }

    /// <summary>
    /// True if this Role is a default Fortify Role
    /// </summary>
    /// <value>True if this Role is a default Fortify Role</value>
    [DataMember(Name="builtIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "builtIn")]
    public bool? BuiltIn { get; set; }

    /// <summary>
    /// Gets or Sets Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public bool? Default { get; set; }

    /// <summary>
    /// Gets or Sets Deletable
    /// </summary>
    [DataMember(Name="deletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deletable")]
    public bool? Deletable { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

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
    /// Ids of the permissions this Role has
    /// </summary>
    /// <value>Ids of the permissions this Role has</value>
    [DataMember(Name="permissionIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissionIds")]
    public List<string> PermissionIds { get; set; }

    /// <summary>
    /// Gets or Sets PublishVersion
    /// </summary>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }

    /// <summary>
    /// True if this Role can only be assigned to entities that are users
    /// </summary>
    /// <value>True if this Role can only be assigned to entities that are users</value>
    [DataMember(Name="userOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userOnly")]
    public bool? UserOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Role {\n");
      sb.Append("  AllApplicationRole: ").Append(AllApplicationRole).Append("\n");
      sb.Append("  AssignedToNonUsers: ").Append(AssignedToNonUsers).Append("\n");
      sb.Append("  BuiltIn: ").Append(BuiltIn).Append("\n");
      sb.Append("  Default: ").Append(Default).Append("\n");
      sb.Append("  Deletable: ").Append(Deletable).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  PermissionIds: ").Append(PermissionIds).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
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
