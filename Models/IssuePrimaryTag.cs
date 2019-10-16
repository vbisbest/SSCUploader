using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Store the information about issue primary custom tag
  /// </summary>
  [DataContract]
  public class IssuePrimaryTag {
    /// <summary>
    /// Gets or Sets TagGuid
    /// </summary>
    [DataMember(Name="tagGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagGuid")]
    public string TagGuid { get; set; }

    /// <summary>
    /// Gets or Sets TagId
    /// </summary>
    [DataMember(Name="tagId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagId")]
    public long? TagId { get; set; }

    /// <summary>
    /// Gets or Sets TagName
    /// </summary>
    [DataMember(Name="tagName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagName")]
    public string TagName { get; set; }

    /// <summary>
    /// Gets or Sets TagValue
    /// </summary>
    [DataMember(Name="tagValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tagValue")]
    public string TagValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssuePrimaryTag {\n");
      sb.Append("  TagGuid: ").Append(TagGuid).Append("\n");
      sb.Append("  TagId: ").Append(TagId).Append("\n");
      sb.Append("  TagName: ").Append(TagName).Append("\n");
      sb.Append("  TagValue: ").Append(TagValue).Append("\n");
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
