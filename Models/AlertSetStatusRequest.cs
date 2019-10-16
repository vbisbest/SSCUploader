using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to set status for alerts
  /// </summary>
  [DataContract]
  public class AlertSetStatusRequest {
    /// <summary>
    /// Alert history ids to set status
    /// </summary>
    /// <value>Alert history ids to set status</value>
    [DataMember(Name="alertHistoryIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertHistoryIds")]
    public List<long?> AlertHistoryIds { get; set; }

    /// <summary>
    /// Status of alerts, classified as read or unread
    /// </summary>
    /// <value>Status of alerts, classified as read or unread</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AlertSetStatusRequest {\n");
      sb.Append("  AlertHistoryIds: ").Append(AlertHistoryIds).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
