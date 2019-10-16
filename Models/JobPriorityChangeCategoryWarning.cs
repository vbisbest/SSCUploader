using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Job priority change warning
  /// </summary>
  [DataContract]
  public class JobPriorityChangeCategoryWarning {
    /// <summary>
    /// Job priority change warning category.
    /// </summary>
    /// <value>Job priority change warning category.</value>
    [DataMember(Name="warningCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warningCategory")]
    public string WarningCategory { get; set; }

    /// <summary>
    /// Detailed information about job priority change.
    /// </summary>
    /// <value>Detailed information about job priority change.</value>
    [DataMember(Name="warningList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warningList")]
    public List<JobPriorityChangeInfo> WarningList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class JobPriorityChangeCategoryWarning {\n");
      sb.Append("  WarningCategory: ").Append(WarningCategory).Append("\n");
      sb.Append("  WarningList: ").Append(WarningList).Append("\n");
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
