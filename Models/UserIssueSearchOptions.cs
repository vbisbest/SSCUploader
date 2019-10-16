using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User specific options that can be used for customizing issue search result.
  /// </summary>
  [DataContract]
  public class UserIssueSearchOptions {
    /// <summary>
    /// If 'true', comments are included in issue audit history. Used only by flex UI.
    /// </summary>
    /// <value>If 'true', comments are included in issue audit history. Used only by flex UI.</value>
    [DataMember(Name="includeCommentsInHistory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeCommentsInHistory")]
    public bool? IncludeCommentsInHistory { get; set; }

    /// <summary>
    /// Application version ID the option values belong to. Value is empty for default options that can be applied to any application version user has access to if application version specific options are not defined.
    /// </summary>
    /// <value>Application version ID the option values belong to. Value is empty for default options that can be applied to any application version user has access to if application version specific options are not defined.</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// If 'true', include hidden issues in search results. If 'false', exclude hidden issues from search results. If no options are set, use application version profile settings to get value of this option.
    /// </summary>
    /// <value>If 'true', include hidden issues in search results. If 'false', exclude hidden issues from search results. If no options are set, use application version profile settings to get value of this option.</value>
    [DataMember(Name="showHidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showHidden")]
    public bool? ShowHidden { get; set; }

    /// <summary>
    /// If 'true', include removed issues in search results. If 'false', exclude removed issues from search results. If no options are set, use application version profile settings to get value of this option.
    /// </summary>
    /// <value>If 'true', include removed issues in search results. If 'false', exclude removed issues from search results. If no options are set, use application version profile settings to get value of this option.</value>
    [DataMember(Name="showRemoved", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showRemoved")]
    public bool? ShowRemoved { get; set; }

    /// <summary>
    /// If 'true', only short file names will be displayed in issues list.
    /// </summary>
    /// <value>If 'true', only short file names will be displayed in issues list.</value>
    [DataMember(Name="showShortFileNames", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showShortFileNames")]
    public bool? ShowShortFileNames { get; set; }

    /// <summary>
    /// If 'true', include suppressed issues in search results. If 'false', exclude suppressed issues from search results. If no options are set, use application version profile settings to get value of this option.
    /// </summary>
    /// <value>If 'true', include suppressed issues in search results. If 'false', exclude suppressed issues from search results. If no options are set, use application version profile settings to get value of this option.</value>
    [DataMember(Name="showSuppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showSuppressed")]
    public bool? ShowSuppressed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserIssueSearchOptions {\n");
      sb.Append("  IncludeCommentsInHistory: ").Append(IncludeCommentsInHistory).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  ShowHidden: ").Append(ShowHidden).Append("\n");
      sb.Append("  ShowRemoved: ").Append(ShowRemoved).Append("\n");
      sb.Append("  ShowShortFileNames: ").Append(ShowShortFileNames).Append("\n");
      sb.Append("  ShowSuppressed: ").Append(ShowSuppressed).Append("\n");
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
