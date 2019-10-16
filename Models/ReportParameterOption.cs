using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Report Parameter Option DTO object
  /// </summary>
  [DataContract]
  public class ReportParameterOption {
    /// <summary>
    /// Indicates whether option is the default value
    /// </summary>
    /// <value>Indicates whether option is the default value</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public bool? DefaultValue { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Report parameter option display value
    /// </summary>
    /// <value>Report parameter option display value</value>
    [DataMember(Name="displayValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayValue")]
    public string DisplayValue { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Order in which the parameter option should appear
    /// </summary>
    /// <value>Order in which the parameter option should appear</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }

    /// <summary>
    /// Report parameter option report value
    /// </summary>
    /// <value>Report parameter option report value</value>
    [DataMember(Name="reportValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reportValue")]
    public string ReportValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportParameterOption {\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  ReportValue: ").Append(ReportValue).Append("\n");
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
