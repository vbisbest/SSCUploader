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
  public class ApiBulkRequestItem {
    /// <summary>
    /// Gets or Sets HttpVerb
    /// </summary>
    [DataMember(Name="httpVerb", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "httpVerb")]
    public string HttpVerb { get; set; }

    /// <summary>
    /// Gets or Sets PostData
    /// </summary>
    [DataMember(Name="postData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postData")]
    public Object PostData { get; set; }

    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name="uri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uri")]
    public string Uri { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApiBulkRequestItem {\n");
      sb.Append("  HttpVerb: ").Append(HttpVerb).Append("\n");
      sb.Append("  PostData: ").Append(PostData).Append("\n");
      sb.Append("  Uri: ").Append(Uri).Append("\n");
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
