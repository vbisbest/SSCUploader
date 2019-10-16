using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue aging object contains application metrics.
  /// </summary>
  [DataContract]
  public class IssueAgingDto {
    /// <summary>
    /// Average number of days to fix issues in application versions.
    /// </summary>
    /// <value>Average number of days to fix issues in application versions.</value>
    [DataMember(Name="averageDaysToRemediate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageDaysToRemediate")]
    public int? AverageDaysToRemediate { get; set; }

    /// <summary>
    /// Average number of days to review issues in application versions.
    /// </summary>
    /// <value>Average number of days to review issues in application versions.</value>
    [DataMember(Name="averageDaysToReview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageDaysToReview")]
    public int? AverageDaysToReview { get; set; }

    /// <summary>
    /// Bug density per 10 000 of scanned lines of code.
    /// </summary>
    /// <value>Bug density per 10 000 of scanned lines of code.</value>
    [DataMember(Name="bugDensity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugDensity")]
    public double? BugDensity { get; set; }

    /// <summary>
    /// Number of files that were scanned in all application versions.
    /// </summary>
    /// <value>Number of files that were scanned in all application versions.</value>
    [DataMember(Name="filesScanned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filesScanned")]
    public long? FilesScanned { get; set; }

    /// <summary>
    /// This is dynamic attribute which value depend of the aggregation attribute. It can be application ID, application version ID or application version attribute GUID.
    /// </summary>
    /// <value>This is dynamic attribute which value depend of the aggregation attribute. It can be application ID, application version ID or application version attribute GUID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Number of issues that are pending review in all application versions.
    /// </summary>
    /// <value>Number of issues that are pending review in all application versions.</value>
    [DataMember(Name="issuesPendingReview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuesPendingReview")]
    public long? IssuesPendingReview { get; set; }

    /// <summary>
    /// Number of lines of code that were scanned by scans which results are stored in the application versions.
    /// </summary>
    /// <value>Number of lines of code that were scanned by scans which results are stored in the application versions.</value>
    [DataMember(Name="linesOfCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linesOfCode")]
    public long? LinesOfCode { get; set; }

    /// <summary>
    /// This is dynamic attribute which value depend of the aggregation attribute. It can be application name, application version name or application version attribute name.
    /// </summary>
    /// <value>This is dynamic attribute which value depend of the aggregation attribute. It can be application name, application version name or application version attribute name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Number of application versions in the application.
    /// </summary>
    /// <value>Number of application versions in the application.</value>
    [DataMember(Name="numberOfApplicationVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberOfApplicationVersions")]
    public int? NumberOfApplicationVersions { get; set; }

    /// <summary>
    /// Issue audites that have been done after this date have been taken into account for average days to review calculation.
    /// </summary>
    /// <value>Issue audites that have been done after this date have been taken into account for average days to review calculation.</value>
    [DataMember(Name="oldestScanDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oldestScanDate")]
    public DateTime? OldestScanDate { get; set; }

    /// <summary>
    /// Number of not remediated issues in all application versions.
    /// </summary>
    /// <value>Number of not remediated issues in all application versions.</value>
    [DataMember(Name="openIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openIssues")]
    public long? OpenIssues { get; set; }

    /// <summary>
    /// Flag that indicates that application metrics state was changed and it metrics are going to be recalculated.
    /// </summary>
    /// <value>Flag that indicates that application metrics state was changed and it metrics are going to be recalculated.</value>
    [DataMember(Name="snapshotOutOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "snapshotOutOfDate")]
    public bool? SnapshotOutOfDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueAgingDto {\n");
      sb.Append("  AverageDaysToRemediate: ").Append(AverageDaysToRemediate).Append("\n");
      sb.Append("  AverageDaysToReview: ").Append(AverageDaysToReview).Append("\n");
      sb.Append("  BugDensity: ").Append(BugDensity).Append("\n");
      sb.Append("  FilesScanned: ").Append(FilesScanned).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IssuesPendingReview: ").Append(IssuesPendingReview).Append("\n");
      sb.Append("  LinesOfCode: ").Append(LinesOfCode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumberOfApplicationVersions: ").Append(NumberOfApplicationVersions).Append("\n");
      sb.Append("  OldestScanDate: ").Append(OldestScanDate).Append("\n");
      sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
      sb.Append("  SnapshotOutOfDate: ").Append(SnapshotOutOfDate).Append("\n");
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
