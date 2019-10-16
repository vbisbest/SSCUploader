using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Report Definition DTO object
  /// </summary>
  [DataContract]
  public class ReportDefinition {
    /// <summary>
    /// True if report applies to multiple application versions
    /// </summary>
    /// <value>True if report applies to multiple application versions</value>
    [DataMember(Name="crossApp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "crossApp")]
    public bool? CrossApp { get; set; }

    /// <summary>
    /// Report description
    /// </summary>
    /// <value>Report description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the report definition file
    /// </summary>
    /// <value>The name of the report definition file</value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Report definition GUID
    /// </summary>
    /// <value>Report definition GUID</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Report definition identifier
    /// </summary>
    /// <value>Report definition identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Indicates whether the report definition is in use
    /// </summary>
    /// <value>Indicates whether the report definition is in use</value>
    [DataMember(Name="inUse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inUse")]
    public bool? InUse { get; set; }

    /// <summary>
    /// Report name
    /// </summary>
    /// <value>Report name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Object version
    /// </summary>
    /// <value>Object version</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// List of report parameters
    /// </summary>
    /// <value>List of report parameters</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<ReportParameter> Parameters { get; set; }

    /// <summary>
    /// Publish version
    /// </summary>
    /// <value>Publish version</value>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }

    /// <summary>
    /// The engine used to render the report, e.g. BIRT
    /// </summary>
    /// <value>The engine used to render the report, e.g. BIRT</value>
    [DataMember(Name="renderingEngine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renderingEngine")]
    public string RenderingEngine { get; set; }

    /// <summary>
    /// Template doc identifier
    /// </summary>
    /// <value>Template doc identifier</value>
    [DataMember(Name="templateDocId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateDocId")]
    public long? TemplateDocId { get; set; }

    /// <summary>
    /// Type of report
    /// </summary>
    /// <value>Type of report</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Report type default text
    /// </summary>
    /// <value>Report type default text</value>
    [DataMember(Name="typeDefaultText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeDefaultText")]
    public string TypeDefaultText { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportDefinition {\n");
      sb.Append("  CrossApp: ").Append(CrossApp).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InUse: ").Append(InUse).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
      sb.Append("  RenderingEngine: ").Append(RenderingEngine).Append("\n");
      sb.Append("  TemplateDocId: ").Append(TemplateDocId).Append("\n");
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
