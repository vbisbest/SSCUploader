using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Source file content where vulnerabilities were found.
  /// </summary>
  [DataContract]
  public class SourceFileDto {
    /// <summary>
    /// Source file checksum.
    /// </summary>
    /// <value>Source file checksum.</value>
    [DataMember(Name="checksum", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checksum")]
    public string Checksum { get; set; }

    /// <summary>
    /// Source file encoding.
    /// </summary>
    /// <value>Source file encoding.</value>
    [DataMember(Name="encoding", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encoding")]
    public string Encoding { get; set; }

    /// <summary>
    /// Scanned source file content.
    /// </summary>
    /// <value>Scanned source file content.</value>
    [DataMember(Name="fileContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileContent")]
    public string FileContent { get; set; }

    /// <summary>
    /// Full path to source file on the machine where scan was performed.
    /// </summary>
    /// <value>Full path to source file on the machine where scan was performed.</value>
    [DataMember(Name="filePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filePath")]
    public string FilePath { get; set; }

    /// <summary>
    /// Source file programming language name.
    /// </summary>
    /// <value>Source file programming language name.</value>
    [DataMember(Name="languageName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "languageName")]
    public string LanguageName { get; set; }

    /// <summary>
    /// Application version identifier that contains this source file.
    /// </summary>
    /// <value>Application version identifier that contains this source file.</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SourceFileDto {\n");
      sb.Append("  Checksum: ").Append(Checksum).Append("\n");
      sb.Append("  Encoding: ").Append(Encoding).Append("\n");
      sb.Append("  FileContent: ").Append(FileContent).Append("\n");
      sb.Append("  FilePath: ").Append(FilePath).Append("\n");
      sb.Append("  LanguageName: ").Append(LanguageName).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
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
