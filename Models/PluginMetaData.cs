using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// plugin meta data holds attributes of the plugins installed in the application.
  /// </summary>
  [DataContract]
  public class PluginMetaData {
    /// <summary>
    /// Version string of the SSC plugin api used to develop the plugin
    /// </summary>
    /// <value>Version string of the SSC plugin api used to develop the plugin</value>
    [DataMember(Name="apiVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "apiVersion")]
    public string ApiVersion { get; set; }

    /// <summary>
    /// An integer used to tag the set of issue attributes provided by this plugin.
    /// </summary>
    /// <value>An integer used to tag the set of issue attributes provided by this plugin.</value>
    [DataMember(Name="dataVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataVersion")]
    public int? DataVersion { get; set; }

    /// <summary>
    /// Plugin description
    /// </summary>
    /// <value>Plugin description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Name of the scan engine supported by the plugin. Value is defined for parser plugins only
    /// </summary>
    /// <value>Name of the scan engine supported by the plugin. Value is defined for parser plugins only</value>
    [DataMember(Name="engineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineType")]
    public string EngineType { get; set; }

    /// <summary>
    /// Plugin unique identifier
    /// </summary>
    /// <value>Plugin unique identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Tracks whether this plugin instance was the most recently used of its kind
    /// </summary>
    /// <value>Tracks whether this plugin instance was the most recently used of its kind</value>
    [DataMember(Name="lastUsedOfKind", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastUsedOfKind")]
    public bool? LastUsedOfKind { get; set; }

    /// <summary>
    /// Additional configuration properties used by the plugin
    /// </summary>
    /// <value>Additional configuration properties used by the plugin</value>
    [DataMember(Name="pluginConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginConfiguration")]
    public List<PluginConfiguration> PluginConfiguration { get; set; }

    /// <summary>
    /// Identifier of the plugin, usually a fully-qualified classname. Non-unique when multiple versions of same plugin exist
    /// </summary>
    /// <value>Identifier of the plugin, usually a fully-qualified classname. Non-unique when multiple versions of same plugin exist</value>
    [DataMember(Name="pluginId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginId")]
    public string PluginId { get; set; }

    /// <summary>
    /// A string name for the plugin
    /// </summary>
    /// <value>A string name for the plugin</value>
    [DataMember(Name="pluginName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginName")]
    public string PluginName { get; set; }

    /// <summary>
    /// State of the plugin instance
    /// </summary>
    /// <value>State of the plugin instance</value>
    [DataMember(Name="pluginState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginState")]
    public string PluginState { get; set; }

    /// <summary>
    /// Denotes functionality of the plugin instance, such as scan parsing, bugtracker integration.
    /// </summary>
    /// <value>Denotes functionality of the plugin instance, such as scan parsing, bugtracker integration.</value>
    [DataMember(Name="pluginType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginType")]
    public string PluginType { get; set; }

    /// <summary>
    /// A version string of the implementation code of the plugin
    /// </summary>
    /// <value>A version string of the implementation code of the plugin</value>
    [DataMember(Name="pluginVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pluginVersion")]
    public string PluginVersion { get; set; }

    /// <summary>
    /// Versions of the scan engine results supported by the plugin. Value is defined for parser plugins only
    /// </summary>
    /// <value>Versions of the scan engine results supported by the plugin. Value is defined for parser plugins only</value>
    [DataMember(Name="supportedEngineVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportedEngineVersions")]
    public string SupportedEngineVersions { get; set; }

    /// <summary>
    /// whether the plugin instance was installed by adding the jar to a special system folder
    /// </summary>
    /// <value>whether the plugin instance was installed by adding the jar to a special system folder</value>
    [DataMember(Name="systemInstalled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "systemInstalled")]
    public bool? SystemInstalled { get; set; }

    /// <summary>
    /// Name of the company / organization that developed the plugin
    /// </summary>
    /// <value>Name of the company / organization that developed the plugin</value>
    [DataMember(Name="vendorName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorName")]
    public string VendorName { get; set; }

    /// <summary>
    /// Plugin vendor's web site URL
    /// </summary>
    /// <value>Plugin vendor's web site URL</value>
    [DataMember(Name="vendorUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendorUrl")]
    public string VendorUrl { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PluginMetaData {\n");
      sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
      sb.Append("  DataVersion: ").Append(DataVersion).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EngineType: ").Append(EngineType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastUsedOfKind: ").Append(LastUsedOfKind).Append("\n");
      sb.Append("  PluginConfiguration: ").Append(PluginConfiguration).Append("\n");
      sb.Append("  PluginId: ").Append(PluginId).Append("\n");
      sb.Append("  PluginName: ").Append(PluginName).Append("\n");
      sb.Append("  PluginState: ").Append(PluginState).Append("\n");
      sb.Append("  PluginType: ").Append(PluginType).Append("\n");
      sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
      sb.Append("  SupportedEngineVersions: ").Append(SupportedEngineVersions).Append("\n");
      sb.Append("  SystemInstalled: ").Append(SystemInstalled).Append("\n");
      sb.Append("  VendorName: ").Append(VendorName).Append("\n");
      sb.Append("  VendorUrl: ").Append(VendorUrl).Append("\n");
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
