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
  public class ApiBulkResponseItemResponse {
    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="body", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "body")]
    public ApiBulkResponseData Body { get; set; }

    /// <summary>
    /// Gets or Sets Headers
    /// </summary>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public Dictionary<string, string> Headers { get; set; }

    /// <summary>
    /// Gets or Sets RequestUrl
    /// </summary>
    [DataMember(Name="requestUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestUrl")]
    public string RequestUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiBulkResponseItemResponse {\n");
      sb.Append("  Body: ").Append(Body).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
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
