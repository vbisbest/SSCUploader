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
  public class AlertTriggerDto {
    /// <summary>
    /// Gets or Sets AlertDefinitionId
    /// </summary>
    [DataMember(Name="alertDefinitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alertDefinitionId")]
    public long? AlertDefinitionId { get; set; }

    /// <summary>
    /// Gets or Sets MonitoredAttribute
    /// </summary>
    [DataMember(Name="monitoredAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "monitoredAttribute")]
    public string MonitoredAttribute { get; set; }

    /// <summary>
    /// Gets or Sets ResetAfterTriggering
    /// </summary>
    [DataMember(Name="resetAfterTriggering", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resetAfterTriggering")]
    public bool? ResetAfterTriggering { get; set; }

    /// <summary>
    /// Gets or Sets TriggeredValue
    /// </summary>
    [DataMember(Name="triggeredValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggeredValue")]
    public string TriggeredValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AlertTriggerDto {\n");
      sb.Append("  AlertDefinitionId: ").Append(AlertDefinitionId).Append("\n");
      sb.Append("  MonitoredAttribute: ").Append(MonitoredAttribute).Append("\n");
      sb.Append("  ResetAfterTriggering: ").Append(ResetAfterTriggering).Append("\n");
      sb.Append("  TriggeredValue: ").Append(TriggeredValue).Append("\n");
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
