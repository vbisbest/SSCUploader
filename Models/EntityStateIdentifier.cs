using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Simple API entity that contains only ID and revision.
  /// </summary>
  [DataContract]
  public class EntityStateIdentifier {
    /// <summary>
    /// API entity identifier.
    /// </summary>
    /// <value>API entity identifier.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// API entity revision.
    /// </summary>
    /// <value>API entity revision.</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public int? Revision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EntityStateIdentifier {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
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
