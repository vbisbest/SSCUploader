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
  public class EmbeddedReportDefinition {
    /// <summary>
    /// Gets or Sets FieldsToNullWithExclusions
    /// </summary>
    [DataMember(Name="fieldsToNullWithExclusions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldsToNullWithExclusions")]
    public List<string> FieldsToNullWithExclusions { get; set; }

    /// <summary>
    /// Gets or Sets ReportDefinition
    /// </summary>
    [DataMember(Name="reportDefinition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportDefinition")]
    public ReportDefinition ReportDefinition { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmbeddedReportDefinition {\n");
      sb.Append("  FieldsToNullWithExclusions: ").Append(FieldsToNullWithExclusions).Append("\n");
      sb.Append("  ReportDefinition: ").Append(ReportDefinition).Append("\n");
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
