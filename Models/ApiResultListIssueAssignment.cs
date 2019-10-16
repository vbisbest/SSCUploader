using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ApiResultListIssueAssignment {
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public long? Count { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public List<IssueAssignment> Data { get; set; }

    /// <summary>
    /// Gets or Sets ErrorCode
    /// </summary>
    [DataMember(Name="errorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCode")]
    public int? ErrorCode { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [DataMember(Name="links", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "links")]
    public Object Links { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets ResponseCode
    /// </summary>
    [DataMember(Name="responseCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseCode")]
    public int? ResponseCode { get; set; }

    /// <summary>
    /// Gets or Sets StackTrace
    /// </summary>
    [DataMember(Name="stackTrace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackTrace")]
    public string StackTrace { get; set; }

    /// <summary>
    /// Gets or Sets SuccessCount
    /// </summary>
    [DataMember(Name="successCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "successCount")]
    public long? SuccessCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiResultListIssueAssignment {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  Links: ").Append(Links).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
      sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
      sb.Append("  SuccessCount: ").Append(SuccessCount).Append("\n");
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
