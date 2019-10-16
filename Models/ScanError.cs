using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// error reported by SCA during the scan
  /// </summary>
  [DataContract]
  public class ScanError {
    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="errorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCode")]
    public string ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets ErrorDescription
    /// </summary>
    [DataMember(Name="errorDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorDescription")]
    public string ErrorDescription { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// id of scan associated with the error
    /// </summary>
    /// <value>id of scan associated with the error</value>
    [DataMember(Name="scanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scanId")]
    public long? ScanId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScanError {\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ScanId: ").Append(ScanId).Append("\n");
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
