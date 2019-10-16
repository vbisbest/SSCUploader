using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Data Export DTO object
  /// </summary>
  [DataContract]
  public class DataExport {
    /// <summary>
    /// Application version id - required if DatasetName = \"Audit\"
    /// </summary>
    /// <value>Application version id - required if DatasetName = \"Audit\"</value>
    [DataMember(Name="appVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appVersionId")]
    public long? AppVersionId { get; set; }

    /// <summary>
    /// Application version name
    /// </summary>
    /// <value>Application version name</value>
    [DataMember(Name="appVersionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appVersionName")]
    public string AppVersionName { get; set; }

    /// <summary>
    /// Dataset name - e.g. \"Audit\", \"Issue Stats\" - corresponds to page from which data is exported
    /// </summary>
    /// <value>Dataset name - e.g. \"Audit\", \"Issue Stats\" - corresponds to page from which data is exported</value>
    [DataMember(Name="datasetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "datasetName")]
    public string DatasetName { get; set; }

    /// <summary>
    /// Document Info id for file blob
    /// </summary>
    /// <value>Document Info id for file blob</value>
    [DataMember(Name="documentInfoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentInfoId")]
    public long? DocumentInfoId { get; set; }

    /// <summary>
    /// Data export file expiration in days
    /// </summary>
    /// <value>Data export file expiration in days</value>
    [DataMember(Name="expiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration")]
    public int? Expiration { get; set; }

    /// <summary>
    /// Export date
    /// </summary>
    /// <value>Export date</value>
    [DataMember(Name="exportDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exportDate")]
    public DateTime? ExportDate { get; set; }

    /// <summary>
    /// Name of data export file
    /// </summary>
    /// <value>Name of data export file</value>
    [DataMember(Name="fileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileName")]
    public string FileName { get; set; }

    /// <summary>
    /// File type, e.g. CSV
    /// </summary>
    /// <value>File type, e.g. CSV</value>
    [DataMember(Name="fileType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileType")]
    public string FileType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Note, i.e. comments or info related to data being exported
    /// </summary>
    /// <value>Note, i.e. comments or info related to data being exported</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// Data export status
    /// </summary>
    /// <value>Data export status</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// User name of user who initiated the data export
    /// </summary>
    /// <value>User name of user who initiated the data export</value>
    [DataMember(Name="userName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userName")]
    public string UserName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DataExport {\n");
      sb.Append("  AppVersionId: ").Append(AppVersionId).Append("\n");
      sb.Append("  AppVersionName: ").Append(AppVersionName).Append("\n");
      sb.Append("  DatasetName: ").Append(DatasetName).Append("\n");
      sb.Append("  DocumentInfoId: ").Append(DocumentInfoId).Append("\n");
      sb.Append("  Expiration: ").Append(Expiration).Append("\n");
      sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  FileType: ").Append(FileType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
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
