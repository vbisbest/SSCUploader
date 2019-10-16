using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Token to upload or download files
  /// </summary>
  [DataContract]
  public class FileToken {
    /// <summary>
    /// Type of single-use file token
    /// </summary>
    /// <value>Type of single-use file token</value>
    [DataMember(Name="fileTokenType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileTokenType")]
    public string FileTokenType { get; set; }

    /// <summary>
    /// Value of single-use token to be used as the 'mat' URL parameter during a file operation
    /// </summary>
    /// <value>Value of single-use token to be used as the 'mat' URL parameter during a file operation</value>
    [DataMember(Name="token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileToken {\n");
      sb.Append("  FileTokenType: ").Append(FileTokenType).Append("\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
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
