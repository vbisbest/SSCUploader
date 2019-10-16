using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Object containing user session information
  /// </summary>
  [DataContract]
  public class UserSessionInformation {
    /// <summary>
    /// Application context path
    /// </summary>
    /// <value>Application context path</value>
    [DataMember(Name="applicationContextPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationContextPath")]
    public string ApplicationContextPath { get; set; }

    /// <summary>
    /// Cloud scan configuration
    /// </summary>
    /// <value>Cloud scan configuration</value>
    [DataMember(Name="cloudScanConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cloudScanConfig")]
    public CloudScanConfig CloudScanConfig { get; set; }

    /// <summary>
    /// Set to true if collaboration module is enabled
    /// </summary>
    /// <value>Set to true if collaboration module is enabled</value>
    [DataMember(Name="collabModuleEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collabModuleEnabled")]
    public bool? CollabModuleEnabled { get; set; }

    /// <summary>
    /// Display user details if set to true
    /// </summary>
    /// <value>Display user details if set to true</value>
    [DataMember(Name="displayUserDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayUserDetails")]
    public bool? DisplayUserDetails { get; set; }

    /// <summary>
    /// User email
    /// </summary>
    /// <value>User email</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// User first name
    /// </summary>
    /// <value>User first name</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Fortify user type eg. LOCAL
    /// </summary>
    /// <value>Fortify user type eg. LOCAL</value>
    [DataMember(Name="fortifyUserType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fortifyUserType")]
    public string FortifyUserType { get; set; }

    /// <summary>
    /// User last name
    /// </summary>
    /// <value>User last name</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// List of license capabilities
    /// </summary>
    /// <value>List of license capabilities</value>
    [DataMember(Name="licenseCapabilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "licenseCapabilities")]
    public List<LicenseCapability> LicenseCapabilities { get; set; }

    /// <summary>
    /// Set to true if on demand mode is enabled
    /// </summary>
    /// <value>Set to true if on demand mode is enabled</value>
    [DataMember(Name="onDemandMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "onDemandMode")]
    public bool? OnDemandMode { get; set; }

    /// <summary>
    /// User permissions
    /// </summary>
    /// <value>User permissions</value>
    [DataMember(Name="permissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissions")]
    public List<string> Permissions { get; set; }

    /// <summary>
    /// User preferences
    /// </summary>
    /// <value>User preferences</value>
    [DataMember(Name="preferences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "preferences")]
    public UserPreferences Preferences { get; set; }

    /// <summary>
    /// User roles
    /// </summary>
    /// <value>User roles</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<Role> Roles { get; set; }

    /// <summary>
    /// User session id
    /// </summary>
    /// <value>User session id</value>
    [DataMember(Name="sessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionId")]
    public string SessionId { get; set; }

    /// <summary>
    /// User Photo
    /// </summary>
    /// <value>User Photo</value>
    [DataMember(Name="userPhoto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userPhoto")]
    public UserPhoto UserPhoto { get; set; }

    /// <summary>
    /// User Type integer eg. 0 for Local
    /// </summary>
    /// <value>User Type integer eg. 0 for Local</value>
    [DataMember(Name="userType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userType")]
    public int? UserType { get; set; }

    /// <summary>
    /// User name
    /// </summary>
    /// <value>User name</value>
    [DataMember(Name="username", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }

    /// <summary>
    /// Web application version
    /// </summary>
    /// <value>Web application version</value>
    [DataMember(Name="webappVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webappVersion")]
    public string WebappVersion { get; set; }

    /// <summary>
    /// WebInspect enterprise configuration
    /// </summary>
    /// <value>WebInspect enterprise configuration</value>
    [DataMember(Name="wieConfig", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wieConfig")]
    public WIEConfiguration WieConfig { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserSessionInformation {\n");
      sb.Append("  ApplicationContextPath: ").Append(ApplicationContextPath).Append("\n");
      sb.Append("  CloudScanConfig: ").Append(CloudScanConfig).Append("\n");
      sb.Append("  CollabModuleEnabled: ").Append(CollabModuleEnabled).Append("\n");
      sb.Append("  DisplayUserDetails: ").Append(DisplayUserDetails).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  FortifyUserType: ").Append(FortifyUserType).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  LicenseCapabilities: ").Append(LicenseCapabilities).Append("\n");
      sb.Append("  OnDemandMode: ").Append(OnDemandMode).Append("\n");
      sb.Append("  Permissions: ").Append(Permissions).Append("\n");
      sb.Append("  Preferences: ").Append(Preferences).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  UserPhoto: ").Append(UserPhoto).Append("\n");
      sb.Append("  UserType: ").Append(UserType).Append("\n");
      sb.Append("  Username: ").Append(Username).Append("\n");
      sb.Append("  WebappVersion: ").Append(WebappVersion).Append("\n");
      sb.Append("  WieConfig: ").Append(WieConfig).Append("\n");
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
