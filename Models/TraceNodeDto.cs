using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Issue analysis trace node DTO.
  /// </summary>
  [DataContract]
  public class TraceNodeDto {
    /// <summary>
    /// Child nodes of the current node.
    /// </summary>
    /// <value>Child nodes of the current node.</value>
    [DataMember(Name="childNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childNodes")]
    public List<TraceNodeDto> ChildNodes { get; set; }

    /// <summary>
    /// Detail node marker.
    /// </summary>
    /// <value>Detail node marker.</value>
    [DataMember(Name="detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detail")]
    public bool? Detail { get; set; }

    /// <summary>
    /// Node evidence text.
    /// </summary>
    /// <value>Node evidence text.</value>
    [DataMember(Name="evidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "evidence")]
    public string Evidence { get; set; }

    /// <summary>
    /// Name of the file associated with this node.
    /// </summary>
    /// <value>Name of the file associated with this node.</value>
    [DataMember(Name="file", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "file")]
    public string File { get; set; }

    /// <summary>
    /// Full path to source file associated with this node.
    /// </summary>
    /// <value>Full path to source file associated with this node.</value>
    [DataMember(Name="fullPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullPath")]
    public string FullPath { get; set; }

    /// <summary>
    /// Source file line number where issue was found.
    /// </summary>
    /// <value>Source file line number where issue was found.</value>
    [DataMember(Name="line", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "line")]
    public int? Line { get; set; }

    /// <summary>
    /// Type of the trace node.
    /// </summary>
    /// <value>Type of the trace node.</value>
    [DataMember(Name="nodeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nodeType")]
    public string NodeType { get; set; }

    /// <summary>
    /// Primry node marker.
    /// </summary>
    /// <value>Primry node marker.</value>
    [DataMember(Name="primary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primary")]
    public bool? Primary { get; set; }

    /// <summary>
    /// Node display text.
    /// </summary>
    /// <value>Node display text.</value>
    [DataMember(Name="text", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    /// <summary>
    /// Node description/tooltip.
    /// </summary>
    /// <value>Node description/tooltip.</value>
    [DataMember(Name="toolTip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "toolTip")]
    public string ToolTip { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TraceNodeDto {\n");
      sb.Append("  ChildNodes: ").Append(ChildNodes).Append("\n");
      sb.Append("  Detail: ").Append(Detail).Append("\n");
      sb.Append("  Evidence: ").Append(Evidence).Append("\n");
      sb.Append("  File: ").Append(File).Append("\n");
      sb.Append("  FullPath: ").Append(FullPath).Append("\n");
      sb.Append("  Line: ").Append(Line).Append("\n");
      sb.Append("  NodeType: ").Append(NodeType).Append("\n");
      sb.Append("  Primary: ").Append(Primary).Append("\n");
      sb.Append("  Text: ").Append(Text).Append("\n");
      sb.Append("  ToolTip: ").Append(ToolTip).Append("\n");
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
