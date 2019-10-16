using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Object represents rulepack processing status. This is readonly object.
  /// </summary>
  [DataContract]
  public class RulepacksBatchProcessStatus {
    /// <summary>
    /// Numeric processing code.
    /// </summary>
    /// <value>Numeric processing code.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public int? Code { get; set; }

    /// <summary>
    /// Processing message.
    /// </summary>
    /// <value>Processing message.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Child rulepacks processing statuses.
    /// </summary>
    /// <value>Child rulepacks processing statuses.</value>
    [DataMember(Name="statuses", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statuses")]
    public List<RulepacksBatchProcessStatus> Statuses { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RulepacksBatchProcessStatus {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Statuses: ").Append(Statuses).Append("\n");
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
