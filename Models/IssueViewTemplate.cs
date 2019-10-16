using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue view template DTO object.
  /// </summary>
  [DataContract]
  public class IssueViewTemplate {
    /// <summary>
    /// Issue data version for which template is created.
    /// </summary>
    /// <value>Issue data version for which template is created.</value>
    [DataMember(Name="dataVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataVersion")]
    public long? DataVersion { get; set; }

    /// <summary>
    /// Template description.
    /// </summary>
    /// <value>Template description.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Engine type for which template is created.
    /// </summary>
    /// <value>Engine type for which template is created.</value>
    [DataMember(Name="engineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineType")]
    public string EngineType { get; set; }

    /// <summary>
    /// Unique identifier of the issue view template.
    /// </summary>
    /// <value>Unique identifier of the issue view template.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Id of the plugin meta data for which template is created.
    /// </summary>
    /// <value>Id of the plugin meta data for which template is created.</value>
    [DataMember(Name="metadataId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadataId")]
    public long? MetadataId { get; set; }

    /// <summary>
    /// Object version.
    /// </summary>
    /// <value>Object version.</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// Actual template JSON data.
    /// </summary>
    /// <value>Actual template JSON data.</value>
    [DataMember(Name="templateData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateData")]
    public List<List<TemplateItem>> TemplateData { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueViewTemplate {\n");
      sb.Append("  DataVersion: ").Append(DataVersion).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EngineType: ").Append(EngineType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MetadataId: ").Append(MetadataId).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  TemplateData: ").Append(TemplateData).Append("\n");
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
