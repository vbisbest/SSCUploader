using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// basic info on a filter set (does not include filters)
  /// </summary>
  [DataContract]
  public class FilterSet {
    /// <summary>
    /// whether this filter set is the default within its issue template
    /// </summary>
    /// <value>whether this filter set is the default within its issue template</value>
    [DataMember(Name="defaultFilterSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultFilterSet")]
    public bool? DefaultFilterSet { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// List of folders defined in filter set
    /// </summary>
    /// <value>List of folders defined in filter set</value>
    [DataMember(Name="folders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "folders")]
    public List<FolderDto> Folders { get; set; }

    /// <summary>
    /// GUID of filter set
    /// </summary>
    /// <value>GUID of filter set</value>
    [DataMember(Name="guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guid")]
    public string Guid { get; set; }

    /// <summary>
    /// name of filter set
    /// </summary>
    /// <value>name of filter set</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FilterSet {\n");
      sb.Append("  DefaultFilterSet: ").Append(DefaultFilterSet).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Folders: ").Append(Folders).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
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
