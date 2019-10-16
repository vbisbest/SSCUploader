using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Composite object that holds information about issue attributes that can be used for issue list filtering and grouping.
  /// </summary>
  [DataContract]
  public class IssueFilterSelectorSet {
    /// <summary>
    /// List of all possible issues filterring attributes.
    /// </summary>
    /// <value>List of all possible issues filterring attributes.</value>
    [DataMember(Name="filterBySet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filterBySet")]
    public List<IssueFilterSelector> FilterBySet { get; set; }

    /// <summary>
    /// List of all possible issues grouping attributes.
    /// </summary>
    /// <value>List of all possible issues grouping attributes.</value>
    [DataMember(Name="groupBySet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupBySet")]
    public List<IssueSelector> GroupBySet { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IssueFilterSelectorSet {\n");
      sb.Append("  FilterBySet: ").Append(FilterBySet).Append("\n");
      sb.Append("  GroupBySet: ").Append(GroupBySet).Append("\n");
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
