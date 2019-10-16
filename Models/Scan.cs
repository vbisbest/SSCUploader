using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// provides high-level information on the result of a single Fortify analysis, usually embedded inside an Artifact object
  /// </summary>
  [DataContract]
  public class Scan {
    /// <summary>
    /// identifier of parent artifact object which contains this scan object
    /// </summary>
    /// <value>identifier of parent artifact object which contains this scan object</value>
    [DataMember(Name="artifactId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "artifactId")]
    public long? ArtifactId { get; set; }

    /// <summary>
    /// optional string identifier provided by the user when scanning
    /// </summary>
    /// <value>optional string identifier provided by the user when scanning</value>
    [DataMember(Name="buildId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildId")]
    public string BuildId { get; set; }

    /// <summary>
    /// optional string identifier provided by the user when scanning
    /// </summary>
    /// <value>optional string identifier provided by the user when scanning</value>
    [DataMember(Name="buildLabel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildLabel")]
    public string BuildLabel { get; set; }

    /// <summary>
    /// optional string identifier provided by the user when scanning
    /// </summary>
    /// <value>optional string identifier provided by the user when scanning</value>
    [DataMember(Name="buildProject", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildProject")]
    public string BuildProject { get; set; }

    /// <summary>
    /// optional string identifier provided by the user when scanning
    /// </summary>
    /// <value>optional string identifier provided by the user when scanning</value>
    [DataMember(Name="buildVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buildVersion")]
    public string BuildVersion { get; set; }

    /// <summary>
    /// indicates whether the checksum on the analysis result is valid
    /// </summary>
    /// <value>indicates whether the checksum on the analysis result is valid</value>
    [DataMember(Name="certification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "certification")]
    public string Certification { get; set; }

    /// <summary>
    /// analysis duration
    /// </summary>
    /// <value>analysis duration</value>
    [DataMember(Name="elapsedTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elapsedTime")]
    public string ElapsedTime { get; set; }

    /// <summary>
    /// version of analysis engine
    /// </summary>
    /// <value>version of analysis engine</value>
    [DataMember(Name="engineVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineVersion")]
    public string EngineVersion { get; set; }

    /// <summary>
    /// total executable lines of code included in sources (excluding comments etc.)
    /// </summary>
    /// <value>total executable lines of code included in sources (excluding comments etc.)</value>
    [DataMember(Name="execLOC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "execLOC")]
    public int? ExecLOC { get; set; }

    /// <summary>
    /// lines of code with annotations
    /// </summary>
    /// <value>lines of code with annotations</value>
    [DataMember(Name="fortifyAnnotationsLOC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fortifyAnnotationsLOC")]
    public int? FortifyAnnotationsLOC { get; set; }

    /// <summary>
    /// globally unique id of scan object
    /// </summary>
    /// <value>globally unique id of scan object</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// Gets or Sets Hostname
    /// </summary>
    [DataMember(Name="hostname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// number of source files included in scan
    /// </summary>
    /// <value>number of source files included in scan</value>
    [DataMember(Name="noOfFiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noOfFiles")]
    public int? NoOfFiles { get; set; }

    /// <summary>
    /// total lines of code included in sources (includes comments etc.)
    /// </summary>
    /// <value>total lines of code included in sources (includes comments etc.)</value>
    [DataMember(Name="totalLOC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalLOC")]
    public int? TotalLOC { get; set; }

    /// <summary>
    /// indicates the type of analyzer that produced it, such as SCA or WEBINSPECT
    /// </summary>
    /// <value>indicates the type of analyzer that produced it, such as SCA or WEBINSPECT</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets UploadDate
    /// </summary>
    [DataMember(Name="uploadDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uploadDate")]
    public DateTime? UploadDate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Scan {\n");
      sb.Append("  ArtifactId: ").Append(ArtifactId).Append("\n");
      sb.Append("  BuildId: ").Append(BuildId).Append("\n");
      sb.Append("  BuildLabel: ").Append(BuildLabel).Append("\n");
      sb.Append("  BuildProject: ").Append(BuildProject).Append("\n");
      sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
      sb.Append("  Certification: ").Append(Certification).Append("\n");
      sb.Append("  ElapsedTime: ").Append(ElapsedTime).Append("\n");
      sb.Append("  EngineVersion: ").Append(EngineVersion).Append("\n");
      sb.Append("  ExecLOC: ").Append(ExecLOC).Append("\n");
      sb.Append("  FortifyAnnotationsLOC: ").Append(FortifyAnnotationsLOC).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Hostname: ").Append(Hostname).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  NoOfFiles: ").Append(NoOfFiles).Append("\n");
      sb.Append("  TotalLOC: ").Append(TotalLOC).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UploadDate: ").Append(UploadDate).Append("\n");
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
