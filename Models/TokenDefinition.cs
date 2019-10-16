using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Metadata of a Software Security Center token
  /// </summary>
  [DataContract]
  public class TokenDefinition {
    /// <summary>
    /// Describes what tokens generated from this token specification can be used for. Note that these capabilities are subordinate to the actual roles/permissions granted to the owner of the token
    /// </summary>
    /// <value>Describes what tokens generated from this token specification can be used for. Note that these capabilities are subordinate to the actual roles/permissions granted to the owner of the token</value>
    [DataMember(Name="capabilityDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilityDescription")]
    public string CapabilityDescription { get; set; }

    /// <summary>
    /// Maximum allowable lifetime (in nominal days) of token. At the time of token creation/edit, the exact value for its max expiration is calculated by adding maxDaysToLive * MilliSecondsPerDay to the current datetime
    /// </summary>
    /// <value>Maximum allowable lifetime (in nominal days) of token. At the time of token creation/edit, the exact value for its max expiration is calculated by adding maxDaysToLive * MilliSecondsPerDay to the current datetime</value>
    [DataMember(Name="maxDaysToLive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxDaysToLive")]
    public int? MaxDaysToLive { get; set; }

    /// <summary>
    /// Maximum number of api calls that can be made using this token type. A value of -1 denotes unlimited number of calls.
    /// </summary>
    /// <value>Maximum number of api calls that can be made using this token type. A value of -1 denotes unlimited number of calls.</value>
    [DataMember(Name="maxUsages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxUsages")]
    public int? MaxUsages { get; set; }

    /// <summary>
    /// Token type
    /// </summary>
    /// <value>Token type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TokenDefinition {\n");
      sb.Append("  CapabilityDescription: ").Append(CapabilityDescription).Append("\n");
      sb.Append("  MaxDaysToLive: ").Append(MaxDaysToLive).Append("\n");
      sb.Append("  MaxUsages: ").Append(MaxUsages).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
