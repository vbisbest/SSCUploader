using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Dynamic Scan Requests Summary object
  /// </summary>
  [DataContract]
  public class DynamicScanRequestsSummary {
    /// <summary>
    /// Flag that indicates whether the user may edit or cancel the dynamic scan request
    /// </summary>
    /// <value>Flag that indicates whether the user may edit or cancel the dynamic scan request</value>
    [DataMember(Name="canEditOrCancel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canEditOrCancel")]
    public bool? CanEditOrCancel { get; set; }

    /// <summary>
    /// Flag that indicates whether the user can submit dynamic scan requests
    /// </summary>
    /// <value>Flag that indicates whether the user can submit dynamic scan requests</value>
    [DataMember(Name="canSubmit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canSubmit")]
    public bool? CanSubmit { get; set; }

    /// <summary>
    /// Flag that indicates whether dynamic scan request is disabled
    /// </summary>
    /// <value>Flag that indicates whether dynamic scan request is disabled</value>
    [DataMember(Name="dynamicScanDisabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicScanDisabled")]
    public bool? DynamicScanDisabled { get; set; }

    /// <summary>
    /// A message indicating the reason for why dynamic scan is disabled
    /// </summary>
    /// <value>A message indicating the reason for why dynamic scan is disabled</value>
    [DataMember(Name="dynamicScanDisabledMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dynamicScanDisabledMessage")]
    public string DynamicScanDisabledMessage { get; set; }

    /// <summary>
    /// The id of the last dynamic scan request
    /// </summary>
    /// <value>The id of the last dynamic scan request</value>
    [DataMember(Name="lastScanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScanId")]
    public long? LastScanId { get; set; }

    /// <summary>
    /// Holds information about the last dynamic scan request
    /// </summary>
    /// <value>Holds information about the last dynamic scan request</value>
    [DataMember(Name="lastScanSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScanSummary")]
    public string LastScanSummary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicScanRequestsSummary {\n");
      sb.Append("  CanEditOrCancel: ").Append(CanEditOrCancel).Append("\n");
      sb.Append("  CanSubmit: ").Append(CanSubmit).Append("\n");
      sb.Append("  DynamicScanDisabled: ").Append(DynamicScanDisabled).Append("\n");
      sb.Append("  DynamicScanDisabledMessage: ").Append(DynamicScanDisabledMessage).Append("\n");
      sb.Append("  LastScanId: ").Append(LastScanId).Append("\n");
      sb.Append("  LastScanSummary: ").Append(LastScanSummary).Append("\n");
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
