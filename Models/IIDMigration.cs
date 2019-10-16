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
  public class IIDMigration {
    /// <summary>
    /// Gets or Sets ArtifactId
    /// </summary>
    [DataMember(Name="artifactId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactId")]
    public long? ArtifactId { get; set; }

    /// <summary>
    /// IID migration id
    /// </summary>
    /// <value>IID migration id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets Mappings
    /// </summary>
    [DataMember(Name="mappings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mappings")]
    public List<IidMapping> Mappings { get; set; }

    /// <summary>
    /// Gets or Sets ProcessingDate
    /// </summary>
    [DataMember(Name="processingDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "processingDate")]
    public DateTime? ProcessingDate { get; set; }

    /// <summary>
    /// Gets or Sets ProjectVersionId
    /// </summary>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IIDMigration {\n");
      sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Mappings: ").Append(Mappings).Append("\n");
      sb.Append("  ProcessingDate: ").Append(ProcessingDate).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
