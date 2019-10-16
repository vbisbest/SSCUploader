using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Request to export audit information to CSV file
  /// </summary>
  [DataContract]
  public class ExportAuditToCSVRequest {
    /// <summary>
    /// Aggregateby
    /// </summary>
    /// <value>Aggregateby</value>
    [DataMember(Name="aggregateBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aggregateBy")]
    public string AggregateBy { get; set; }

    /// <summary>
    /// Will collapse issues in exported files
    /// </summary>
    /// <value>Will collapse issues in exported files</value>
    [DataMember(Name="collapseIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collapseIssues")]
    public bool? CollapseIssues { get; set; }

    /// <summary>
    /// Dataset name (Audit)
    /// </summary>
    /// <value>Dataset name (Audit)</value>
    [DataMember(Name="datasetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasetName")]
    public string DatasetName { get; set; }

    /// <summary>
    /// File name to save
    /// </summary>
    /// <value>File name to save</value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Filter
    /// </summary>
    /// <value>Filter</value>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter")]
    public string Filter { get; set; }

    /// <summary>
    /// Filterby
    /// </summary>
    /// <value>Filterby</value>
    [DataMember(Name="filterBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterBy")]
    public string FilterBy { get; set; }

    /// <summary>
    /// Filterset
    /// </summary>
    /// <value>Filterset</value>
    [DataMember(Name="filterSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterSet")]
    public string FilterSet { get; set; }

    /// <summary>
    /// Will include comments in history
    /// </summary>
    /// <value>Will include comments in history</value>
    [DataMember(Name="includeCommentsInHistory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeCommentsInHistory")]
    public bool? IncludeCommentsInHistory { get; set; }

    /// <summary>
    /// Will include hidden issues
    /// </summary>
    /// <value>Will include hidden issues</value>
    [DataMember(Name="includeHidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeHidden")]
    public bool? IncludeHidden { get; set; }

    /// <summary>
    /// Will include removed issues
    /// </summary>
    /// <value>Will include removed issues</value>
    [DataMember(Name="includeRemoved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeRemoved")]
    public bool? IncludeRemoved { get; set; }

    /// <summary>
    /// Will include suppressed issues
    /// </summary>
    /// <value>Will include suppressed issues</value>
    [DataMember(Name="includeSuppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeSuppressed")]
    public bool? IncludeSuppressed { get; set; }

    /// <summary>
    /// Search issue query
    /// </summary>
    /// <value>Search issue query</value>
    [DataMember(Name="issueSearch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueSearch")]
    public string IssueSearch { get; set; }

    /// <summary>
    /// Limit
    /// </summary>
    /// <value>Limit</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    /// <value>Note</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Orderby
    /// </summary>
    /// <value>Orderby</value>
    [DataMember(Name="orderBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderBy")]
    public string OrderBy { get; set; }

    /// <summary>
    /// Application version id to export audit data
    /// </summary>
    /// <value>Application version id to export audit data</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// will restrict to user issues
    /// </summary>
    /// <value>will restrict to user issues</value>
    [DataMember(Name="restrictToUsersIssues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restrictToUsersIssues")]
    public bool? RestrictToUsersIssues { get; set; }

    /// <summary>
    /// Start
    /// </summary>
    /// <value>Start</value>
    [DataMember(Name="start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start")]
    public int? Start { get; set; }

    /// <summary>
    /// Will use short file names
    /// </summary>
    /// <value>Will use short file names</value>
    [DataMember(Name="useShortFileNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useShortFileNames")]
    public bool? UseShortFileNames { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExportAuditToCSVRequest {\n");
      sb.Append("  AggregateBy: ").Append(AggregateBy).Append("\n");
      sb.Append("  CollapseIssues: ").Append(CollapseIssues).Append("\n");
      sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      sb.Append("  FilterBy: ").Append(FilterBy).Append("\n");
      sb.Append("  FilterSet: ").Append(FilterSet).Append("\n");
      sb.Append("  IncludeCommentsInHistory: ").Append(IncludeCommentsInHistory).Append("\n");
      sb.Append("  IncludeHidden: ").Append(IncludeHidden).Append("\n");
      sb.Append("  IncludeRemoved: ").Append(IncludeRemoved).Append("\n");
      sb.Append("  IncludeSuppressed: ").Append(IncludeSuppressed).Append("\n");
      sb.Append("  IssueSearch: ").Append(IssueSearch).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  OrderBy: ").Append(OrderBy).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  RestrictToUsersIssues: ").Append(RestrictToUsersIssues).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  UseShortFileNames: ").Append(UseShortFileNames).Append("\n");
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
