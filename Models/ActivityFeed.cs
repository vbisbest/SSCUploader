using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Activity Feed DTO object
  /// </summary>
  [DataContract]
  public class ActivityFeed {
    /// <summary>
    /// Entity
    /// </summary>
    /// <value>Entity</value>
    [DataMember(Name="authEntity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authEntity")]
    public AuthenticationEntity AuthEntity { get; set; }

    /// <summary>
    /// Gets or Sets DetailedNote
    /// </summary>
    [DataMember(Name="detailedNote", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detailedNote")]
    public string DetailedNote { get; set; }

    /// <summary>
    /// Gets or Sets EntityId
    /// </summary>
    [DataMember(Name="entityId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityId")]
    public long? EntityId { get; set; }

    /// <summary>
    /// Gets or Sets EventDate
    /// </summary>
    [DataMember(Name="eventDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventDate")]
    public DateTime? EventDate { get; set; }

    /// <summary>
    /// Gets or Sets EventType
    /// </summary>
    [DataMember(Name="eventType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventType")]
    public string EventType { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    /// <value>Description</value>
    [DataMember(Name="eventTypeDesc", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eventTypeDesc")]
    public string EventTypeDesc { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

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
      sb.Append("class ActivityFeed {\n");
      sb.Append("  AuthEntity: ").Append(AuthEntity).Append("\n");
      sb.Append("  DetailedNote: ").Append(DetailedNote).Append("\n");
      sb.Append("  EntityId: ").Append(EntityId).Append("\n");
      sb.Append("  EventDate: ").Append(EventDate).Append("\n");
      sb.Append("  EventType: ").Append(EventType).Append("\n");
      sb.Append("  EventTypeDesc: ").Append(EventTypeDesc).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
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
