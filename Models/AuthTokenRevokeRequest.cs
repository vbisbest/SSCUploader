using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request for revoking tokens by value
  /// </summary>
  [DataContract]
  public class AuthTokenRevokeRequest {
    /// <summary>
    /// A list of tokens (atleast one) to revoke
    /// </summary>
    /// <value>A list of tokens (atleast one) to revoke</value>
    [DataMember(Name="tokens", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tokens")]
    public List<string> Tokens { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthTokenRevokeRequest {\n");
      sb.Append("  Tokens: ").Append(Tokens).Append("\n");
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
