using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Audit Assistant obsolete prediction policy
  /// </summary>
  [DataContract]
  public class ObsoletePolicy {
    /// <summary>
    /// True if this obsolete policy is also configured as system default policy
    /// </summary>
    /// <value>True if this obsolete policy is also configured as system default policy</value>
    [DataMember(Name="defaultPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultPolicy")]
    public bool? DefaultPolicy { get; set; }

    /// <summary>
    /// Count of application versions where this obsolete policy has been found
    /// </summary>
    /// <value>Count of application versions where this obsolete policy has been found</value>
    [DataMember(Name="obsoleteAvCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obsoleteAvCount")]
    public long? ObsoleteAvCount { get; set; }

    /// <summary>
    /// Obsolete prediction policy name found in application version
    /// </summary>
    /// <value>Obsolete prediction policy name found in application version</value>
    [DataMember(Name="policyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyName")]
    public string PolicyName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ObsoletePolicy {\n");
      sb.Append("  DefaultPolicy: ").Append(DefaultPolicy).Append("\n");
      sb.Append("  ObsoleteAvCount: ").Append(ObsoleteAvCount).Append("\n");
      sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
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
