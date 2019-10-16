using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Result of cloud scan workers related actions
  /// </summary>
  [DataContract]
  public class CloudPoolWorkerActionResponse {
    /// <summary>
    /// Cloud scan worker uuids
    /// </summary>
    /// <value>Cloud scan worker uuids</value>
    [DataMember(Name="workerUuids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workerUuids")]
    public List<string> WorkerUuids { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPoolWorkerActionResponse {\n");
      sb.Append("  WorkerUuids: ").Append(WorkerUuids).Append("\n");
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
