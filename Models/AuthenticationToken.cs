using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Token to use for authentication
  /// </summary>
  [DataContract]
  public class AuthenticationToken {
    /// <summary>
    /// Date and time the token was created (in ISO 8601 format)
    /// </summary>
    /// <value>Date and time the token was created (in ISO 8601 format)</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// Purpose for which the token was requested.
    /// </summary>
    /// <value>Purpose for which the token was requested.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Unique identifier of token
    /// </summary>
    /// <value>Unique identifier of token</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The remaining number of api calls that can be made using this token. A value of -1 denotes unlimited number of calls.
    /// </summary>
    /// <value>The remaining number of api calls that can be made using this token. A value of -1 denotes unlimited number of calls.</value>
    [DataMember(Name="remainingUsages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remainingUsages")]
    public int? RemainingUsages { get; set; }

    /// <summary>
    /// Date and time the token expires (in ISO 8601 format). If not specified, it will default to the maximum lifetime for this token type.
    /// </summary>
    /// <value>Date and time the token expires (in ISO 8601 format). If not specified, it will default to the maximum lifetime for this token type.</value>
    [DataMember(Name="terminalDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminalDate")]
    public DateTime? TerminalDate { get; set; }

    /// <summary>
    /// String that represents the authentication token. (For security reasons, this value is null except for a successful token creation response.)
    /// </summary>
    /// <value>String that represents the authentication token. (For security reasons, this value is null except for a successful token creation response.)</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Token type
    /// </summary>
    /// <value>Token type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Username of token owner
    /// </summary>
    /// <value>Username of token owner</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthenticationToken {\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RemainingUsages: ").Append(RemainingUsages).Append("\n");
      sb.Append("  TerminalDate: ").Append(TerminalDate).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
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
