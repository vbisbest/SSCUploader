using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Cloudscan worker pool
  /// </summary>
  [DataContract]
  public class CloudPool {
    /// <summary>
    /// Gets or Sets ChildOfGlobalPool
    /// </summary>
    [DataMember(Name="childOfGlobalPool", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childOfGlobalPool")]
    public bool? ChildOfGlobalPool { get; set; }

    /// <summary>
    /// Cloudscan pool description
    /// </summary>
    /// <value>Cloudscan pool description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets IsDeletable
    /// </summary>
    [DataMember(Name="isDeletable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isDeletable")]
    public bool? IsDeletable { get; set; }

    /// <summary>
    /// Cloudscan pool name
    /// </summary>
    /// <value>Cloudscan pool name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Cloudscan pool path
    /// </summary>
    /// <value>Cloudscan pool path</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public CloudPoolStats Stats { get; set; }

    /// <summary>
    /// Cloudscan pool UUID
    /// </summary>
    /// <value>Cloudscan pool UUID</value>
    [DataMember(Name="uuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uuid")]
    public string Uuid { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPool {\n");
      sb.Append("  ChildOfGlobalPool: ").Append(ChildOfGlobalPool).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsDeletable: ").Append(IsDeletable).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
