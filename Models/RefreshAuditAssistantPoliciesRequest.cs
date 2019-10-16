using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Audit Assistant server configuration (mandatory) and policy replacement mapping (optional)
  /// </summary>
  [DataContract]
  public class RefreshAuditAssistantPoliciesRequest {
    /// <summary>
    /// A list with current policy names from Audit Assistant server.
    /// </summary>
    /// <value>A list with current policy names from Audit Assistant server.</value>
    [DataMember(Name="currentPolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPolicies")]
    public List<string> CurrentPolicies { get; set; }

    /// <summary>
    /// A list of policy objects containing existing obsolete AV policy names as a result of comparison with current server policies.
    /// </summary>
    /// <value>A list of policy objects containing existing obsolete AV policy names as a result of comparison with current server policies.</value>
    [DataMember(Name="obsoletePolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obsoletePolicies")]
    public List<ObsoletePolicy> ObsoletePolicies { get; set; }

    /// <summary>
    /// Mapping between old (obsolete) and new (existing) policy names; current AV policies and/or system default policy are to be replaced
    /// </summary>
    /// <value>Mapping between old (obsolete) and new (existing) policy names; current AV policies and/or system default policy are to be replaced</value>
    [DataMember(Name="policyReplacements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "policyReplacements")]
    public List<PolicyReplacement> PolicyReplacements { get; set; }

    /// <summary>
    /// Audit Assistant server configuration properties to be used policies retrieval from Fortify Scan Analytics server 
    /// </summary>
    /// <value>Audit Assistant server configuration properties to be used policies retrieval from Fortify Scan Analytics server </value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ConfigProperty> Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RefreshAuditAssistantPoliciesRequest {\n");
      sb.Append("  CurrentPolicies: ").Append(CurrentPolicies).Append("\n");
      sb.Append("  ObsoletePolicies: ").Append(ObsoletePolicies).Append("\n");
      sb.Append("  PolicyReplacements: ").Append(PolicyReplacements).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
