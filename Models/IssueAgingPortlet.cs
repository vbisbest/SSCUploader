using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue aging portlet object contains application and issue metrics.
  /// </summary>
  [DataContract]
  public class IssueAgingPortlet {
    /// <summary>
    /// Gets or Sets ApplicationVersions
    /// </summary>
    [DataMember(Name="applicationVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationVersions")]
    public int? ApplicationVersions { get; set; }

    /// <summary>
    /// Gets or Sets AverageDaysToRemediate
    /// </summary>
    [DataMember(Name="averageDaysToRemediate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageDaysToRemediate")]
    public int? AverageDaysToRemediate { get; set; }

    /// <summary>
    /// Gets or Sets AverageDaysToReview
    /// </summary>
    [DataMember(Name="averageDaysToReview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageDaysToReview")]
    public int? AverageDaysToReview { get; set; }

    /// <summary>
    /// Gets or Sets FilesScanned
    /// </summary>
    [DataMember(Name="filesScanned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filesScanned")]
    public long? FilesScanned { get; set; }

    /// <summary>
    /// Gets or Sets IssuesPendingReview
    /// </summary>
    [DataMember(Name="issuesPendingReview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuesPendingReview")]
    public long? IssuesPendingReview { get; set; }

    /// <summary>
    /// Gets or Sets IssuesRemediated
    /// </summary>
    [DataMember(Name="issuesRemediated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuesRemediated")]
    public long? IssuesRemediated { get; set; }

    /// <summary>
    /// Gets or Sets LinesOfCode
    /// </summary>
    [DataMember(Name="linesOfCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linesOfCode")]
    public long? LinesOfCode { get; set; }

    /// <summary>
    /// Gets or Sets OpenIssues
    /// </summary>
    [DataMember(Name="openIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openIssues")]
    public long? OpenIssues { get; set; }

    /// <summary>
    /// Gets or Sets OpenIssuesReviewed
    /// </summary>
    [DataMember(Name="openIssuesReviewed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openIssuesReviewed")]
    public long? OpenIssuesReviewed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAgingPortlet {\n");
      sb.Append("  ApplicationVersions: ").Append(ApplicationVersions).Append("\n");
      sb.Append("  AverageDaysToRemediate: ").Append(AverageDaysToRemediate).Append("\n");
      sb.Append("  AverageDaysToReview: ").Append(AverageDaysToReview).Append("\n");
      sb.Append("  FilesScanned: ").Append(FilesScanned).Append("\n");
      sb.Append("  IssuesPendingReview: ").Append(IssuesPendingReview).Append("\n");
      sb.Append("  IssuesRemediated: ").Append(IssuesRemediated).Append("\n");
      sb.Append("  LinesOfCode: ").Append(LinesOfCode).Append("\n");
      sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
      sb.Append("  OpenIssuesReviewed: ").Append(OpenIssuesReviewed).Append("\n");
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
