using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A Responsibility that a user in SSC is assigned to. There are currently a few responsibilities like Project Manager, Security Manager, Developer etc per Application.
  /// </summary>
  [DataContract]
  public class ResponsibilityAssignment {
    /// <summary>
    /// Email of user assigned to responsibility
    /// </summary>
    /// <value>Email of user assigned to responsibility</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// First name of user assigned to responsibility
    /// </summary>
    /// <value>First name of user assigned to responsibility</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of user assigned to responsibility
    /// </summary>
    /// <value>Last name of user assigned to responsibility</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Responsibility description
    /// </summary>
    /// <value>Responsibility description</value>
    [DataMember(Name="responsibilityDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responsibilityDescription")]
    public string ResponsibilityDescription { get; set; }

    /// <summary>
    /// Responsibility global unique identifier
    /// </summary>
    /// <value>Responsibility global unique identifier</value>
    [DataMember(Name="responsibilityGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responsibilityGuid")]
    public string ResponsibilityGuid { get; set; }

    /// <summary>
    /// Responsibility name
    /// </summary>
    /// <value>Responsibility name</value>
    [DataMember(Name="responsibilityName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responsibilityName")]
    public string ResponsibilityName { get; set; }

    /// <summary>
    /// ID of user assigned to responsibility
    /// </summary>
    /// <value>ID of user assigned to responsibility</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public long? UserId { get; set; }

    /// <summary>
    /// Name of user assigned to responsibility
    /// </summary>
    /// <value>Name of user assigned to responsibility</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ResponsibilityAssignment {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  ResponsibilityDescription: ").Append(ResponsibilityDescription).Append("\n");
      sb.Append("  ResponsibilityGuid: ").Append(ResponsibilityGuid).Append("\n");
      sb.Append("  ResponsibilityName: ").Append(ResponsibilityName).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
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
