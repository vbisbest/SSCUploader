using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan system poll status
  /// </summary>
  [DataContract]
  public class CloudSystemPollStatus {
    /// <summary>
    /// Gets or Sets LastPollSuccessful
    /// </summary>
    [DataMember(Name="lastPollSuccessful", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPollSuccessful")]
    public bool? LastPollSuccessful { get; set; }

    /// <summary>
    /// Gets or Sets LastPollTime
    /// </summary>
    [DataMember(Name="lastPollTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastPollTime")]
    public DateTime? LastPollTime { get; set; }

    /// <summary>
    /// Gets or Sets LastSuccessfulPollTime
    /// </summary>
    [DataMember(Name="lastSuccessfulPollTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSuccessfulPollTime")]
    public DateTime? LastSuccessfulPollTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudSystemPollStatus {\n");
      sb.Append("  LastPollSuccessful: ").Append(LastPollSuccessful).Append("\n");
      sb.Append("  LastPollTime: ").Append(LastPollTime).Append("\n");
      sb.Append("  LastSuccessfulPollTime: ").Append(LastSuccessfulPollTime).Append("\n");
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
