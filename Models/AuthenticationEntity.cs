using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A user account that can be used to authenticate in SSC. There are currently two types of user accounts that fall into this category: SSC users and LDAP users registered with SSC.
  /// </summary>
  [DataContract]
  public class AuthenticationEntity {
    /// <summary>
    /// Gets or Sets Embed
    /// </summary>
    [DataMember(Name="_embed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_embed")]
    public EmbeddedRoles Embed { get; set; }

    /// <summary>
    /// Display Name supports the use of wildcard matching. So, for example, \"L*\" will match Lando Calrissian and Lara Croft.
    /// </summary>
    /// <value>Display Name supports the use of wildcard matching. So, for example, \"L*\" will match Lando Calrissian and Lara Croft.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets EntityName
    /// </summary>
    [DataMember(Name="entityName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityName")]
    public string EntityName { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Authentication entity id
    /// </summary>
    /// <value>Authentication entity id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsLdap
    /// </summary>
    [DataMember(Name="isLdap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isLdap")]
    public bool? IsLdap { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Distinguished Name (DN) that is only set for LDAP user accounts
    /// </summary>
    /// <value>Distinguished Name (DN) that is only set for LDAP user accounts</value>
    [DataMember(Name="ldapDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ldapDn")]
    public string LdapDn { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets UserPhoto
    /// </summary>
    [DataMember(Name="userPhoto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userPhoto")]
    public UserPhoto UserPhoto { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationEntity {\n");
      sb.Append("  Embed: ").Append(Embed).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  EntityName: ").Append(EntityName).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsLdap: ").Append(IsLdap).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  LdapDn: ").Append(LdapDn).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UserPhoto: ").Append(UserPhoto).Append("\n");
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
