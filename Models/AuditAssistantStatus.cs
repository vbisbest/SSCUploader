using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// AuditAssistantStatus DTO object
  /// </summary>
  [DataContract]
  public class AuditAssistantStatus {
    /// <summary>
    /// Gets or Sets FprFilePath
    /// </summary>
    [DataMember(Name="fprFilePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fprFilePath")]
    public string FprFilePath { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Gets or Sets ServerId
    /// </summary>
    [DataMember(Name="serverId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverId")]
    public long? ServerId { get; set; }

    /// <summary>
    /// Gets or Sets ServerStatus
    /// </summary>
    [DataMember(Name="serverStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverStatus")]
    public int? ServerStatus { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuditAssistantStatus {\n");
      sb.Append("  FprFilePath: ").Append(FprFilePath).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  ServerId: ").Append(ServerId).Append("\n");
      sb.Append("  ServerStatus: ").Append(ServerStatus).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
