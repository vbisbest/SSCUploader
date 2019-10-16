using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Bugfield Template
  /// </summary>
  [DataContract]
  public class BugfieldTemplateDto {
    /// <summary>
    /// unique name of bugfield template.
    /// </summary>
    /// <value>unique name of bugfield template.</value>
    [DataMember(Name="fieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// description for bugfield template .
    /// </summary>
    /// <value>description for bugfield template .</value>
    [DataMember(Name="fieldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldValue")]
    public string FieldValue { get; set; }

    /// <summary>
    /// unique identifier of bugfield template.
    /// </summary>
    /// <value>unique identifier of bugfield template.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugfieldTemplateDto {\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
