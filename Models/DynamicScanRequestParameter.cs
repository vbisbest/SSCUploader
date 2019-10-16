using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Dynamic Scan Request Parameter DTO object
  /// </summary>
  [DataContract]
  public class DynamicScanRequestParameter {
    /// <summary>
    /// The file value document info id for an upload file
    /// </summary>
    /// <value>The file value document info id for an upload file</value>
    [DataMember(Name="fileValueDocumentInfoId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileValueDocumentInfoId")]
    public long? FileValueDocumentInfoId { get; set; }

    /// <summary>
    /// The name of an uploaded file
    /// </summary>
    /// <value>The name of an uploaded file</value>
    [DataMember(Name="fileValueName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileValueName")]
    public string FileValueName { get; set; }

    /// <summary>
    /// The id of the parameter
    /// </summary>
    /// <value>The id of the parameter</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The objecct version of this parameter
    /// </summary>
    /// <value>The objecct version of this parameter</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// The definition for this parameter
    /// </summary>
    /// <value>The definition for this parameter</value>
    [DataMember(Name="parameterDefinition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterDefinition")]
    public DynamicScanRequestParameterDefinition ParameterDefinition { get; set; }

    /// <summary>
    /// The value of the parameter
    /// </summary>
    /// <value>The value of the parameter</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// The name of the uploaded file
    /// </summary>
    /// <value>The name of the uploaded file</value>
    [DataMember(Name="valueOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueOptions")]
    public List<DynamicScanRequestParameterOption> ValueOptions { get; set; }

    /// <summary>
    /// A list of possible values for this parameter
    /// </summary>
    /// <value>A list of possible values for this parameter</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public List<DynamicScanRequestParameterOption> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicScanRequestParameter {\n");
      sb.Append("  FileValueDocumentInfoId: ").Append(FileValueDocumentInfoId).Append("\n");
      sb.Append("  FileValueName: ").Append(FileValueName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  ParameterDefinition: ").Append(ParameterDefinition).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  ValueOptions: ").Append(ValueOptions).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
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
