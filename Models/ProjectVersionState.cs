using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application Version State DTO object
  /// </summary>
  [DataContract]
  public class ProjectVersionState {
    /// <summary>
    /// Gets or Sets AnalysisResultsExist
    /// </summary>
    [DataMember(Name="analysisResultsExist", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analysisResultsExist")]
    public bool? AnalysisResultsExist { get; set; }

    /// <summary>
    /// Gets or Sets AnalysisUploadEnabled
    /// </summary>
    [DataMember(Name="analysisUploadEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analysisUploadEnabled")]
    public bool? AnalysisUploadEnabled { get; set; }

    /// <summary>
    /// Gets or Sets AttentionRequired
    /// </summary>
    [DataMember(Name="attentionRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attentionRequired")]
    public bool? AttentionRequired { get; set; }

    /// <summary>
    /// Gets or Sets AuditEnabled
    /// </summary>
    [DataMember(Name="auditEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auditEnabled")]
    public bool? AuditEnabled { get; set; }

    /// <summary>
    /// Gets or Sets BatchBugSubmissionExists
    /// </summary>
    [DataMember(Name="batchBugSubmissionExists", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batchBugSubmissionExists")]
    public bool? BatchBugSubmissionExists { get; set; }

    /// <summary>
    /// False if application version is in an incomplete state
    /// </summary>
    /// <value>False if application version is in an incomplete state</value>
    [DataMember(Name="committed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "committed")]
    public bool? Committed { get; set; }

    /// <summary>
    /// Gets or Sets CriticalPriorityIssueCountDelta
    /// </summary>
    [DataMember(Name="criticalPriorityIssueCountDelta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "criticalPriorityIssueCountDelta")]
    public int? CriticalPriorityIssueCountDelta { get; set; }

    /// <summary>
    /// Gets or Sets DeltaPeriod
    /// </summary>
    [DataMember(Name="deltaPeriod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deltaPeriod")]
    public int? DeltaPeriod { get; set; }

    /// <summary>
    /// Gets or Sets ExtraMessage
    /// </summary>
    [DataMember(Name="extraMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraMessage")]
    public string ExtraMessage { get; set; }

    /// <summary>
    /// Gets or Sets HasCustomIssues
    /// </summary>
    [DataMember(Name="hasCustomIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasCustomIssues")]
    public bool? HasCustomIssues { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets IssueCountDelta
    /// </summary>
    [DataMember(Name="issueCountDelta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueCountDelta")]
    public int? IssueCountDelta { get; set; }

    /// <summary>
    /// Gets or Sets LastFprUploadDate
    /// </summary>
    [DataMember(Name="lastFprUploadDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastFprUploadDate")]
    public DateTime? LastFprUploadDate { get; set; }

    /// <summary>
    /// Gets or Sets MetricEvaluationDate
    /// </summary>
    [DataMember(Name="metricEvaluationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metricEvaluationDate")]
    public DateTime? MetricEvaluationDate { get; set; }

    /// <summary>
    /// Gets or Sets PercentAuditedDelta
    /// </summary>
    [DataMember(Name="percentAuditedDelta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentAuditedDelta")]
    public float? PercentAuditedDelta { get; set; }

    /// <summary>
    /// Gets or Sets PercentCriticalPriorityIssuesAuditedDelta
    /// </summary>
    [DataMember(Name="percentCriticalPriorityIssuesAuditedDelta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentCriticalPriorityIssuesAuditedDelta")]
    public float? PercentCriticalPriorityIssuesAuditedDelta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionState {\n");
      sb.Append("  AnalysisResultsExist: ").Append(AnalysisResultsExist).Append("\n");
      sb.Append("  AnalysisUploadEnabled: ").Append(AnalysisUploadEnabled).Append("\n");
      sb.Append("  AttentionRequired: ").Append(AttentionRequired).Append("\n");
      sb.Append("  AuditEnabled: ").Append(AuditEnabled).Append("\n");
      sb.Append("  BatchBugSubmissionExists: ").Append(BatchBugSubmissionExists).Append("\n");
      sb.Append("  Committed: ").Append(Committed).Append("\n");
      sb.Append("  CriticalPriorityIssueCountDelta: ").Append(CriticalPriorityIssueCountDelta).Append("\n");
      sb.Append("  DeltaPeriod: ").Append(DeltaPeriod).Append("\n");
      sb.Append("  ExtraMessage: ").Append(ExtraMessage).Append("\n");
      sb.Append("  HasCustomIssues: ").Append(HasCustomIssues).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IssueCountDelta: ").Append(IssueCountDelta).Append("\n");
      sb.Append("  LastFprUploadDate: ").Append(LastFprUploadDate).Append("\n");
      sb.Append("  MetricEvaluationDate: ").Append(MetricEvaluationDate).Append("\n");
      sb.Append("  PercentAuditedDelta: ").Append(PercentAuditedDelta).Append("\n");
      sb.Append("  PercentCriticalPriorityIssuesAuditedDelta: ").Append(PercentCriticalPriorityIssuesAuditedDelta).Append("\n");
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
