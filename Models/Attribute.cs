using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Attribute DTO object.
  /// </summary>
  [DataContract]
  public class Attribute {
    /// <summary>
    /// ID required when referencing an existing Attribute Definition.
    /// </summary>
    /// <value>ID required when referencing an existing Attribute Definition.</value>
    [DataMember(Name="attributeDefinitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeDefinitionId")]
    public long? AttributeDefinitionId { get; set; }

    /// <summary>
    /// ID required when referencing an existing Attribute.
    /// </summary>
    /// <value>ID required when referencing an existing Attribute.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Attribute value - should be set if Attribute Definition type is NUMBER/STRING/BOOLEAN/DATE/FILE
    /// </summary>
    /// <value>Attribute value - should be set if Attribute Definition type is NUMBER/STRING/BOOLEAN/DATE/FILE</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Attribute Options associated with Attribute Definition with type=SINGLE/MULTIPLE
    /// </summary>
    /// <value>Attribute Options associated with Attribute Definition with type=SINGLE/MULTIPLE</value>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public List<AttributeOption> Values { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Attribute {\n");
      sb.Append("  AttributeDefinitionId: ").Append(AttributeDefinitionId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
