using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An LDAP entity like user, group or organization
  /// </summary>
  [DataContract]
  public class LDAPEntity {
    /// <summary>
    /// Distinguished name of LDAP entity
    /// </summary>
    /// <value>Distinguished name of LDAP entity</value>
    [DataMember(Name="distinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distinguishedName")]
    public string DistinguishedName { get; set; }

    /// <summary>
    /// Email of LDAP entity
    /// </summary>
    /// <value>Email of LDAP entity</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// First name of LDAP entity
    /// </summary>
    /// <value>First name of LDAP entity</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// LDAP entity identifier
    /// </summary>
    /// <value>LDAP entity identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Last name of LDAP entity
    /// </summary>
    /// <value>Last name of LDAP entity</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Type of LDAP entity.
    /// </summary>
    /// <value>Type of LDAP entity.</value>
    [DataMember(Name="ldapType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ldapType")]
    public string LdapType { get; set; }

    /// <summary>
    /// LDAP entity name
    /// </summary>
    /// <value>LDAP entity name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// List of roles pertaining to this LDAP entity
    /// </summary>
    /// <value>List of roles pertaining to this LDAP entity</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<Role> Roles { get; set; }

    /// <summary>
    /// Photo object if LDAP entity is user
    /// </summary>
    /// <value>Photo object if LDAP entity is user</value>
    [DataMember(Name="userPhoto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userPhoto")]
    public UserPhoto UserPhoto { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LDAPEntity {\n");
      sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  LdapType: ").Append(LdapType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
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
