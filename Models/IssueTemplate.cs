using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue Template DTO object.
  /// </summary>
  [DataContract]
  public class IssueTemplate {
    /// <summary>
    /// Deprecated - value is always null.
    /// </summary>
    /// <value>Deprecated - value is always null.</value>
    [DataMember(Name="customTagIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagIds")]
    public List<long?> CustomTagIds { get; set; }

    /// <summary>
    /// Gets or Sets DefaultTemplate
    /// </summary>
    [DataMember(Name="defaultTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultTemplate")]
    public bool? DefaultTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Issue template id
    /// </summary>
    /// <value>Issue template id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Is the template in use
    /// </summary>
    /// <value>Is the template in use</value>
    [DataMember(Name="inUse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inUse")]
    public bool? InUse { get; set; }

    /// <summary>
    /// Gets or Sets MasterAttrGuid
    /// </summary>
    [DataMember(Name="masterAttrGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "masterAttrGuid")]
    public string MasterAttrGuid { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ObjectVersion
    /// </summary>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// Gets or Sets Obsolete
    /// </summary>
    [DataMember(Name="obsolete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obsolete")]
    public bool? Obsolete { get; set; }

    /// <summary>
    /// Gets or Sets OriginalFileName
    /// </summary>
    [DataMember(Name="originalFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalFileName")]
    public string OriginalFileName { get; set; }

    /// <summary>
    /// Gets or Sets PublishVersion
    /// </summary>
    [DataMember(Name="publishVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishVersion")]
    public int? PublishVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueTemplate {\n");
      sb.Append("  CustomTagIds: ").Append(CustomTagIds).Append("\n");
      sb.Append("  DefaultTemplate: ").Append(DefaultTemplate).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InUse: ").Append(InUse).Append("\n");
      sb.Append("  MasterAttrGuid: ").Append(MasterAttrGuid).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  Obsolete: ").Append(Obsolete).Append("\n");
      sb.Append("  OriginalFileName: ").Append(OriginalFileName).Append("\n");
      sb.Append("  PublishVersion: ").Append(PublishVersion).Append("\n");
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
