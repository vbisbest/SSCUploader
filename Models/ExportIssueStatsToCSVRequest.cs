using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to export issue stats to CSV file
  /// </summary>
  [DataContract]
  public class ExportIssueStatsToCSVRequest {
    /// <summary>
    /// Dataset name (Issue Stat)
    /// </summary>
    /// <value>Dataset name (Issue Stat)</value>
    [DataMember(Name="datasetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasetName")]
    public string DatasetName { get; set; }

    /// <summary>
    /// Csv file name
    /// </summary>
    /// <value>Csv file name</value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Limit
    /// </summary>
    /// <value>Limit</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Note for csv export
    /// </summary>
    /// <value>Note for csv export</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Start
    /// </summary>
    /// <value>Start</value>
    [DataMember(Name="start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start")]
    public int? Start { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExportIssueStatsToCSVRequest {\n");
      sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
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
