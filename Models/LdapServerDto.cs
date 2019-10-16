using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LdapServerDto {
    /// <summary>
    /// Gets or Sets AttributeDistinguishedName
    /// </summary>
    [DataMember(Name="attributeDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeDistinguishedName")]
    public string AttributeDistinguishedName { get; set; }

    /// <summary>
    /// Gets or Sets AttributeEmail
    /// </summary>
    [DataMember(Name="attributeEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeEmail")]
    public string AttributeEmail { get; set; }

    /// <summary>
    /// Gets or Sets AttributeFirstName
    /// </summary>
    [DataMember(Name="attributeFirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeFirstName")]
    public string AttributeFirstName { get; set; }

    /// <summary>
    /// Gets or Sets AttributeGroupname
    /// </summary>
    [DataMember(Name="attributeGroupname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeGroupname")]
    public string AttributeGroupname { get; set; }

    /// <summary>
    /// Gets or Sets AttributeLastName
    /// </summary>
    [DataMember(Name="attributeLastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeLastName")]
    public string AttributeLastName { get; set; }

    /// <summary>
    /// Gets or Sets AttributeMember
    /// </summary>
    [DataMember(Name="attributeMember", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeMember")]
    public string AttributeMember { get; set; }

    /// <summary>
    /// Gets or Sets AttributeMemberOf
    /// </summary>
    [DataMember(Name="attributeMemberOf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeMemberOf")]
    public string AttributeMemberOf { get; set; }

    /// <summary>
    /// Gets or Sets AttributeObjectClass
    /// </summary>
    [DataMember(Name="attributeObjectClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeObjectClass")]
    public string AttributeObjectClass { get; set; }

    /// <summary>
    /// Gets or Sets AttributeObjectSid
    /// </summary>
    [DataMember(Name="attributeObjectSid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeObjectSid")]
    public string AttributeObjectSid { get; set; }

    /// <summary>
    /// Gets or Sets AttributeOrgunitName
    /// </summary>
    [DataMember(Name="attributeOrgunitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeOrgunitName")]
    public string AttributeOrgunitName { get; set; }

    /// <summary>
    /// Gets or Sets AttributePassword
    /// </summary>
    [DataMember(Name="attributePassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributePassword")]
    public string AttributePassword { get; set; }

    /// <summary>
    /// Gets or Sets AttributeThumbnailMimeDefault
    /// </summary>
    [DataMember(Name="attributeThumbnailMimeDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeThumbnailMimeDefault")]
    public string AttributeThumbnailMimeDefault { get; set; }

    /// <summary>
    /// Gets or Sets AttributeThumbnailPhoto
    /// </summary>
    [DataMember(Name="attributeThumbnailPhoto", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeThumbnailPhoto")]
    public string AttributeThumbnailPhoto { get; set; }

    /// <summary>
    /// Gets or Sets AttributeUserName
    /// </summary>
    [DataMember(Name="attributeUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributeUserName")]
    public string AttributeUserName { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticatorType
    /// </summary>
    [DataMember(Name="authenticatorType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticatorType")]
    public string AuthenticatorType { get; set; }

    /// <summary>
    /// Distinguished name (DN) of root (base) LDAP entity SSC has access to. If value is set to not empty entity's DN, SSC has access only to this entity and all its children. If value of this attribute is an empty string, SSC has access to whole LDAP entities tree
    /// </summary>
    /// <value>Distinguished name (DN) of root (base) LDAP entity SSC has access to. If value is set to not empty entity's DN, SSC has access only to this entity and all its children. If value of this attribute is an empty string, SSC has access to whole LDAP entities tree</value>
    [DataMember(Name="baseDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseDn")]
    public string BaseDn { get; set; }

    /// <summary>
    /// Gets or Sets BaseObjectSid
    /// </summary>
    [DataMember(Name="baseObjectSid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseObjectSid")]
    public string BaseObjectSid { get; set; }

    /// <summary>
    /// Gets or Sets CacheEnabled
    /// </summary>
    [DataMember(Name="cacheEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cacheEnabled")]
    public bool? CacheEnabled { get; set; }

    /// <summary>
    /// Gets or Sets CacheEvictionTime
    /// </summary>
    [DataMember(Name="cacheEvictionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cacheEvictionTime")]
    public int? CacheEvictionTime { get; set; }

    /// <summary>
    /// Gets or Sets CacheExecutorPoolSize
    /// </summary>
    [DataMember(Name="cacheExecutorPoolSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cacheExecutorPoolSize")]
    public int? CacheExecutorPoolSize { get; set; }

    /// <summary>
    /// Gets or Sets CacheExecutorPoolSizeMax
    /// </summary>
    [DataMember(Name="cacheExecutorPoolSizeMax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cacheExecutorPoolSizeMax")]
    public int? CacheExecutorPoolSizeMax { get; set; }

    /// <summary>
    /// Gets or Sets CacheMaxThreadsPerCache
    /// </summary>
    [DataMember(Name="cacheMaxThreadsPerCache", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cacheMaxThreadsPerCache")]
    public int? CacheMaxThreadsPerCache { get; set; }

    /// <summary>
    /// Gets or Sets CheckSslHostname
    /// </summary>
    [DataMember(Name="checkSslHostname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkSslHostname")]
    public bool? CheckSslHostname { get; set; }

    /// <summary>
    /// Gets or Sets CheckSslTrust
    /// </summary>
    [DataMember(Name="checkSslTrust", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkSslTrust")]
    public bool? CheckSslTrust { get; set; }

    /// <summary>
    /// Gets or Sets ClassGroup
    /// </summary>
    [DataMember(Name="classGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classGroup")]
    public string ClassGroup { get; set; }

    /// <summary>
    /// Gets or Sets ClassOrgunit
    /// </summary>
    [DataMember(Name="classOrgunit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classOrgunit")]
    public string ClassOrgunit { get; set; }

    /// <summary>
    /// Gets or Sets ClassUser
    /// </summary>
    [DataMember(Name="classUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classUser")]
    public string ClassUser { get; set; }

    /// <summary>
    /// Boolean flag that marks LDAP server as default. Default means the server which configuration was imported from ldap.properties legacy configuration file
    /// </summary>
    /// <value>Boolean flag that marks LDAP server as default. Default means the server which configuration was imported from ldap.properties legacy configuration file</value>
    [DataMember(Name="defaultServer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultServer")]
    public bool? DefaultServer { get; set; }

    /// <summary>
    /// Flag that marks server as enabled. All enabled servers are used by SSC. Server can be temporary disabled if it is temporary down.
    /// </summary>
    /// <value>Flag that marks server as enabled. All enabled servers are used by SSC. Server can be temporary disabled if it is temporary down.</value>
    [DataMember(Name="enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// LDAP Server id
    /// </summary>
    /// <value>LDAP Server id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Gets or Sets IgnorePartialResultException
    /// </summary>
    [DataMember(Name="ignorePartialResultException", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ignorePartialResultException")]
    public bool? IgnorePartialResultException { get; set; }

    /// <summary>
    /// Gets or Sets NestedGroupsEnabled
    /// </summary>
    [DataMember(Name="nestedGroupsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nestedGroupsEnabled")]
    public bool? NestedGroupsEnabled { get; set; }

    /// <summary>
    /// Version of the LDAP server entity to support editing LDAP server entity by multiply administrators
    /// </summary>
    /// <value>Version of the LDAP server entity to support editing LDAP server entity by multiply administrators</value>
    [DataMember(Name="objectVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectVersion")]
    public int? ObjectVersion { get; set; }

    /// <summary>
    /// Gets or Sets PageSize
    /// </summary>
    [DataMember(Name="pageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageSize")]
    public int? PageSize { get; set; }

    /// <summary>
    /// Gets or Sets PagingEnabled
    /// </summary>
    [DataMember(Name="pagingEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pagingEnabled")]
    public bool? PagingEnabled { get; set; }

    /// <summary>
    /// Gets or Sets PasswordEncoderType
    /// </summary>
    [DataMember(Name="passwordEncoderType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passwordEncoderType")]
    public string PasswordEncoderType { get; set; }

    /// <summary>
    /// Gets or Sets ReferralsProcessingStrategy
    /// </summary>
    [DataMember(Name="referralsProcessingStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referralsProcessingStrategy")]
    public string ReferralsProcessingStrategy { get; set; }

    /// <summary>
    /// Gets or Sets SaveWithoutValidation
    /// </summary>
    [DataMember(Name="saveWithoutValidation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saveWithoutValidation")]
    public bool? SaveWithoutValidation { get; set; }

    /// <summary>
    /// Gets or Sets SearchDns
    /// </summary>
    [DataMember(Name="searchDns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchDns")]
    public string SearchDns { get; set; }

    /// <summary>
    /// Name of the LDAP server to distinguish it from other servers
    /// </summary>
    /// <value>Name of the LDAP server to distinguish it from other servers</value>
    [DataMember(Name="serverName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serverName")]
    public string ServerName { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gets or Sets UserDn
    /// </summary>
    [DataMember(Name="userDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userDn")]
    public string UserDn { get; set; }

    /// <summary>
    /// Gets or Sets UserPassword
    /// </summary>
    [DataMember(Name="userPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userPassword")]
    public string UserPassword { get; set; }

    /// <summary>
    /// Gets or Sets UserPhotoEnabled
    /// </summary>
    [DataMember(Name="userPhotoEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userPhotoEnabled")]
    public bool? UserPhotoEnabled { get; set; }

    /// <summary>
    /// Gets or Sets ValidationIdleTime
    /// </summary>
    [DataMember(Name="validationIdleTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationIdleTime")]
    public int? ValidationIdleTime { get; set; }

    /// <summary>
    /// Gets or Sets ValidationTimeLimit
    /// </summary>
    [DataMember(Name="validationTimeLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validationTimeLimit")]
    public int? ValidationTimeLimit { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LdapServerDto {\n");
      sb.Append("  AttributeDistinguishedName: ").Append(AttributeDistinguishedName).Append("\n");
      sb.Append("  AttributeEmail: ").Append(AttributeEmail).Append("\n");
      sb.Append("  AttributeFirstName: ").Append(AttributeFirstName).Append("\n");
      sb.Append("  AttributeGroupname: ").Append(AttributeGroupname).Append("\n");
      sb.Append("  AttributeLastName: ").Append(AttributeLastName).Append("\n");
      sb.Append("  AttributeMember: ").Append(AttributeMember).Append("\n");
      sb.Append("  AttributeMemberOf: ").Append(AttributeMemberOf).Append("\n");
      sb.Append("  AttributeObjectClass: ").Append(AttributeObjectClass).Append("\n");
      sb.Append("  AttributeObjectSid: ").Append(AttributeObjectSid).Append("\n");
      sb.Append("  AttributeOrgunitName: ").Append(AttributeOrgunitName).Append("\n");
      sb.Append("  AttributePassword: ").Append(AttributePassword).Append("\n");
      sb.Append("  AttributeThumbnailMimeDefault: ").Append(AttributeThumbnailMimeDefault).Append("\n");
      sb.Append("  AttributeThumbnailPhoto: ").Append(AttributeThumbnailPhoto).Append("\n");
      sb.Append("  AttributeUserName: ").Append(AttributeUserName).Append("\n");
      sb.Append("  AuthenticatorType: ").Append(AuthenticatorType).Append("\n");
      sb.Append("  BaseDn: ").Append(BaseDn).Append("\n");
      sb.Append("  BaseObjectSid: ").Append(BaseObjectSid).Append("\n");
      sb.Append("  CacheEnabled: ").Append(CacheEnabled).Append("\n");
      sb.Append("  CacheEvictionTime: ").Append(CacheEvictionTime).Append("\n");
      sb.Append("  CacheExecutorPoolSize: ").Append(CacheExecutorPoolSize).Append("\n");
      sb.Append("  CacheExecutorPoolSizeMax: ").Append(CacheExecutorPoolSizeMax).Append("\n");
      sb.Append("  CacheMaxThreadsPerCache: ").Append(CacheMaxThreadsPerCache).Append("\n");
      sb.Append("  CheckSslHostname: ").Append(CheckSslHostname).Append("\n");
      sb.Append("  CheckSslTrust: ").Append(CheckSslTrust).Append("\n");
      sb.Append("  ClassGroup: ").Append(ClassGroup).Append("\n");
      sb.Append("  ClassOrgunit: ").Append(ClassOrgunit).Append("\n");
      sb.Append("  ClassUser: ").Append(ClassUser).Append("\n");
      sb.Append("  DefaultServer: ").Append(DefaultServer).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IgnorePartialResultException: ").Append(IgnorePartialResultException).Append("\n");
      sb.Append("  NestedGroupsEnabled: ").Append(NestedGroupsEnabled).Append("\n");
      sb.Append("  ObjectVersion: ").Append(ObjectVersion).Append("\n");
      sb.Append("  PageSize: ").Append(PageSize).Append("\n");
      sb.Append("  PagingEnabled: ").Append(PagingEnabled).Append("\n");
      sb.Append("  PasswordEncoderType: ").Append(PasswordEncoderType).Append("\n");
      sb.Append("  ReferralsProcessingStrategy: ").Append(ReferralsProcessingStrategy).Append("\n");
      sb.Append("  SaveWithoutValidation: ").Append(SaveWithoutValidation).Append("\n");
      sb.Append("  SearchDns: ").Append(SearchDns).Append("\n");
      sb.Append("  ServerName: ").Append(ServerName).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  UserDn: ").Append(UserDn).Append("\n");
      sb.Append("  UserPassword: ").Append(UserPassword).Append("\n");
      sb.Append("  UserPhotoEnabled: ").Append(UserPhotoEnabled).Append("\n");
      sb.Append("  ValidationIdleTime: ").Append(ValidationIdleTime).Append("\n");
      sb.Append("  ValidationTimeLimit: ").Append(ValidationTimeLimit).Append("\n");
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
