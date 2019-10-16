using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Saved Report DTO object
  /// </summary>
  [DataContract]
  public class SavedReport {
    /// <summary>
    /// Gets or Sets Embed
    /// </summary>
    [DataMember(Name="_embed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "_embed")]
    public EmbeddedReportDefinition Embed { get; set; }

    /// <summary>
    /// The Fortify User or Ldap User associated with the report
    /// </summary>
    /// <value>The Fortify User or Ldap User associated with the report</value>
    [DataMember(Name="authEntity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authEntity")]
    public ReportAuthEntity AuthEntity { get; set; }

    /// <summary>
    /// Saved report output format
    /// </summary>
    /// <value>Saved report output format</value>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public string Format { get; set; }

    /// <summary>
    /// Saved report output format default text
    /// </summary>
    /// <value>Saved report output format default text</value>
    [DataMember(Name="formatDefaultText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatDefaultText")]
    public string FormatDefaultText { get; set; }

    /// <summary>
    /// Generation date
    /// </summary>
    /// <value>Generation date</value>
    [DataMember(Name="generationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "generationDate")]
    public DateTime? GenerationDate { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// List of report parameters
    /// </summary>
    /// <value>List of report parameters</value>
    [DataMember(Name="inputReportParameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inputReportParameters")]
    public List<InputReportParameter> InputReportParameters { get; set; }

    /// <summary>
    /// Indicates whether saved report is published
    /// </summary>
    /// <value>Indicates whether saved report is published</value>
    [DataMember(Name="isPublished", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublished")]
    public bool? IsPublished { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Saved report notes
    /// </summary>
    /// <value>Saved report notes</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// List of application versions
    /// </summary>
    /// <value>List of application versions</value>
    [DataMember(Name="projects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projects")]
    public List<ReportProject> Projects { get; set; }

    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [DataMember(Name="published", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "published")]
    public bool? Published { get; set; }

    /// <summary>
    /// Report definition identifier
    /// </summary>
    /// <value>Report definition identifier</value>
    [DataMember(Name="reportDefinitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportDefinitionId")]
    public long? ReportDefinitionId { get; set; }

    /// <summary>
    /// Count of report applications
    /// </summary>
    /// <value>Count of report applications</value>
    [DataMember(Name="reportProjectsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportProjectsCount")]
    public int? ReportProjectsCount { get; set; }

    /// <summary>
    /// Saved report status
    /// </summary>
    /// <value>Saved report status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Saved report status default text
    /// </summary>
    /// <value>Saved report status default text</value>
    [DataMember(Name="statusDefaultText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "statusDefaultText")]
    public string StatusDefaultText { get; set; }

    /// <summary>
    /// Saved report type
    /// </summary>
    /// <value>Saved report type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Saved report type default text
    /// </summary>
    /// <value>Saved report type default text</value>
    [DataMember(Name="typeDefaultText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeDefaultText")]
    public string TypeDefaultText { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SavedReport {\n");
      sb.Append("  Embed: ").Append(Embed).Append("\n");
      sb.Append("  AuthEntity: ").Append(AuthEntity).Append("\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  FormatDefaultText: ").Append(FormatDefaultText).Append("\n");
      sb.Append("  GenerationDate: ").Append(GenerationDate).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InputReportParameters: ").Append(InputReportParameters).Append("\n");
      sb.Append("  IsPublished: ").Append(IsPublished).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Projects: ").Append(Projects).Append("\n");
      sb.Append("  Published: ").Append(Published).Append("\n");
      sb.Append("  ReportDefinitionId: ").Append(ReportDefinitionId).Append("\n");
      sb.Append("  ReportProjectsCount: ").Append(ReportProjectsCount).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StatusDefaultText: ").Append(StatusDefaultText).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TypeDefaultText: ").Append(TypeDefaultText).Append("\n");
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
