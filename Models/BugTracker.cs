using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Bug tracker DTO object
  /// </summary>
  [DataContract]
  public class BugTracker {
    /// <summary>
    /// Authentication required
    /// </summary>
    /// <value>Authentication required</value>
    [DataMember(Name="authenticationRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationRequired")]
    public bool? AuthenticationRequired { get; set; }

    /// <summary>
    /// Bug tracker configuration
    /// </summary>
    /// <value>Bug tracker configuration</value>
    [DataMember(Name="bugTrackerConfigs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bugTrackerConfigs")]
    public List<BugTrackerConfiguration> BugTrackerConfigs { get; set; }

    /// <summary>
    /// Bug tracker identifier
    /// </summary>
    /// <value>Bug tracker identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Long display name
    /// </summary>
    /// <value>Long display name</value>
    [DataMember(Name="longDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longDisplayName")]
    public string LongDisplayName { get; set; }

    /// <summary>
    /// Class name
    /// </summary>
    /// <value>Class name</value>
    [DataMember(Name="pluginClassName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginClassName")]
    public string PluginClassName { get; set; }

    /// <summary>
    /// Bug tracker plugin identifier
    /// </summary>
    /// <value>Bug tracker plugin identifier</value>
    [DataMember(Name="pluginId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginId")]
    public string PluginId { get; set; }

    /// <summary>
    /// Short display name
    /// </summary>
    /// <value>Short display name</value>
    [DataMember(Name="shortDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortDisplayName")]
    public string ShortDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BugTracker {\n");
      sb.Append("  AuthenticationRequired: ").Append(AuthenticationRequired).Append("\n");
      sb.Append("  BugTrackerConfigs: ").Append(BugTrackerConfigs).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LongDisplayName: ").Append(LongDisplayName).Append("\n");
      sb.Append("  PluginClassName: ").Append(PluginClassName).Append("\n");
      sb.Append("  PluginId: ").Append(PluginId).Append("\n");
      sb.Append("  ShortDisplayName: ").Append(ShortDisplayName).Append("\n");
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
