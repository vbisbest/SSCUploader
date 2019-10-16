using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Local User DTO object
  /// </summary>
  [DataContract]
  public class LocalUser {
    /// <summary>
    /// Gets or Sets AdminPassword
    /// </summary>
    [DataMember(Name="adminPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adminPassword")]
    public string AdminPassword { get; set; }

    /// <summary>
    /// Gets or Sets ClearPassword
    /// </summary>
    [DataMember(Name="clearPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clearPassword")]
    public string ClearPassword { get; set; }

    /// <summary>
    /// Date user's account was frozen
    /// </summary>
    /// <value>Date user's account was frozen</value>
    [DataMember(Name="dateFrozen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dateFrozen")]
    public DateTime? DateFrozen { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Number of failed login attempts
    /// </summary>
    /// <value>Number of failed login attempts</value>
    [DataMember(Name="failedLoginAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failedLoginAttempts")]
    public int? FailedLoginAttempts { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// ID required when referencing an existing Local User
    /// </summary>
    /// <value>ID required when referencing an existing Local User</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// True if user's password never expires
    /// </summary>
    /// <value>True if user's password never expires</value>
    [DataMember(Name="passwordNeverExpire", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordNeverExpire")]
    public bool? PasswordNeverExpire { get; set; }

    /// <summary>
    /// Is user required to change password on first login?
    /// </summary>
    /// <value>Is user required to change password on first login?</value>
    [DataMember(Name="requirePasswordChange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requirePasswordChange")]
    public bool? RequirePasswordChange { get; set; }

    /// <summary>
    /// List of Roles assigned to user
    /// </summary>
    /// <value>List of Roles assigned to user</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<Role> Roles { get; set; }

    /// <summary>
    /// True if user's account is locked
    /// </summary>
    /// <value>True if user's account is locked</value>
    [DataMember(Name="suspended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suspended")]
    public bool? Suspended { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LocalUser {\n");
      sb.Append("  AdminPassword: ").Append(AdminPassword).Append("\n");
      sb.Append("  ClearPassword: ").Append(ClearPassword).Append("\n");
      sb.Append("  DateFrozen: ").Append(DateFrozen).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FailedLoginAttempts: ").Append(FailedLoginAttempts).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  PasswordNeverExpire: ").Append(PasswordNeverExpire).Append("\n");
      sb.Append("  RequirePasswordChange: ").Append(RequirePasswordChange).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  Suspended: ").Append(Suspended).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
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
