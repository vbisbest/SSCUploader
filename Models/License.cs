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
  public class License {
    /// <summary>
    /// List of all license capabilities
    /// </summary>
    /// <value>List of all license capabilities</value>
    [DataMember(Name="capabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "capabilities")]
    public List<LicenseCapability> Capabilities { get; set; }

    /// <summary>
    /// Date when license was created
    /// </summary>
    /// <value>Date when license was created</value>
    [DataMember(Name="creationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creationDate")]
    public DateTime? CreationDate { get; set; }

    /// <summary>
    /// License description
    /// </summary>
    /// <value>License description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Date when license is going to be expired
    /// </summary>
    /// <value>Date when license is going to be expired</value>
    [DataMember(Name="expirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Name of the license owner
    /// </summary>
    /// <value>Name of the license owner</value>
    [DataMember(Name="ownerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerName")]
    public string OwnerName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class License {\n");
      sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
      sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
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
