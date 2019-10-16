using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// attachment (such as screenshot) associated with issue
  /// </summary>
  [DataContract]
  public class IssueAttachment {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// document ID referencing the attachment
    /// </summary>
    /// <value>document ID referencing the attachment</value>
    [DataMember(Name="fileDocId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileDocId")]
    public long? FileDocId { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public byte[] Image { get; set; }

    /// <summary>
    /// Gets or Sets OriginalFileName
    /// </summary>
    [DataMember(Name="originalFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalFileName")]
    public string OriginalFileName { get; set; }

    /// <summary>
    /// Gets or Sets UpdateTime
    /// </summary>
    [DataMember(Name="updateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updateTime")]
    public DateTime? UpdateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAttachment {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FileDocId: ").Append(FileDocId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
      sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
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
