using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Dynamic Scan Request object
  /// </summary>
  [DataContract]
  public class DynamicScanRequest {
    /// <summary>
    /// Unique identifier of dynamic scan request
    /// </summary>
    /// <value>Unique identifier of dynamic scan request</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The date that the dynamic scan request was updated
    /// </summary>
    /// <value>The date that the dynamic scan request was updated</value>
    [DataMember(Name="lastUpdateDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUpdateDate")]
    public DateTime? LastUpdateDate { get; set; }

    /// <summary>
    /// The object version of the dynamic scan request
    /// </summary>
    /// <value>The object version of the dynamic scan request</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// Parameters that are needed for dynamic scan request
    /// </summary>
    /// <value>Parameters that are needed for dynamic scan request</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<DynamicScanRequestParameter> Parameters { get; set; }

    /// <summary>
    /// The date that the dynamic scan request was submitted
    /// </summary>
    /// <value>The date that the dynamic scan request was submitted</value>
    [DataMember(Name="requestedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestedDate")]
    public DateTime? RequestedDate { get; set; }

    /// <summary>
    /// The status of the dynamic scan request
    /// </summary>
    /// <value>The status of the dynamic scan request</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The id of the user who submitted the dynamic scan request
    /// </summary>
    /// <value>The id of the user who submitted the dynamic scan request</value>
    [DataMember(Name="submitter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "submitter")]
    public string Submitter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicScanRequest {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  RequestedDate: ").Append(RequestedDate).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Submitter: ").Append(Submitter).Append("\n");
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
