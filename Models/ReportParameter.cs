using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Report Parameter DTO object
  /// </summary>
  [DataContract]
  public class ReportParameter {
    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Report parameter identifier
    /// </summary>
    /// <value>Report parameter identifier</value>
    [DataMember(Name="identifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Order in which the parameter should appear
    /// </summary>
    /// <value>Order in which the parameter should appear</value>
    [DataMember(Name="paramOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paramOrder")]
    public int? ParamOrder { get; set; }

    /// <summary>
    /// Report definition identifier
    /// </summary>
    /// <value>Report definition identifier</value>
    [DataMember(Name="reportDefinitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportDefinitionId")]
    public long? ReportDefinitionId { get; set; }

    /// <summary>
    /// Report parameter options
    /// </summary>
    /// <value>Report parameter options</value>
    [DataMember(Name="reportParameterOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportParameterOptions")]
    public List<ReportParameterOption> ReportParameterOptions { get; set; }

    /// <summary>
    /// Report parameter type
    /// </summary>
    /// <value>Report parameter type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportParameter {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Identifier: ").Append(Identifier).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ParamOrder: ").Append(ParamOrder).Append("\n");
      sb.Append("  ReportDefinitionId: ").Append(ReportDefinitionId).Append("\n");
      sb.Append("  ReportParameterOptions: ").Append(ReportParameterOptions).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
