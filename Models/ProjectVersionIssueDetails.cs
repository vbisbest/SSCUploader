using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Application version issue details DTO object
  /// </summary>
  [DataContract]
  public class ProjectVersionIssueDetails {
    /// <summary>
    /// Vulnerability accuracy
    /// </summary>
    /// <value>Vulnerability accuracy</value>
    [DataMember(Name="accuracy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accuracy")]
    public float? Accuracy { get; set; }

    /// <summary>
    /// Analyzer
    /// </summary>
    /// <value>Analyzer</value>
    [DataMember(Name="analyzer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "analyzer")]
    public string Analyzer { get; set; }

    /// <summary>
    /// A link to access application security training for this issue (available only if the SSC administrator has enabled it)
    /// </summary>
    /// <value>A link to access application security training for this issue (available only if the SSC administrator has enabled it)</value>
    [DataMember(Name="appSecTrainingUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appSecTrainingUrl")]
    public string AppSecTrainingUrl { get; set; }

    /// <summary>
    /// User assigned to issue
    /// </summary>
    /// <value>User assigned to issue</value>
    [DataMember(Name="assignedUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignedUser")]
    public AssignedUser AssignedUser { get; set; }

    /// <summary>
    /// Attack payload
    /// </summary>
    /// <value>Attack payload</value>
    [DataMember(Name="attackPayload", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attackPayload")]
    public string AttackPayload { get; set; }

    /// <summary>
    /// Attack type
    /// </summary>
    /// <value>Attack type</value>
    [DataMember(Name="attackType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attackType")]
    public string AttackType { get; set; }

    /// <summary>
    /// Attribute is set to true if issue is audited (primary tag values is set for this issue)
    /// </summary>
    /// <value>Attribute is set to true if issue is audited (primary tag values is set for this issue)</value>
    [DataMember(Name="audited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "audited")]
    public bool? Audited { get; set; }

    /// <summary>
    /// Issue brief
    /// </summary>
    /// <value>Issue brief</value>
    [DataMember(Name="brief", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "brief")]
    public string Brief { get; set; }

    /// <summary>
    /// Name of class where the vulnerability has been found
    /// </summary>
    /// <value>Name of class where the vulnerability has been found</value>
    [DataMember(Name="className", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "className")]
    public string ClassName { get; set; }

    /// <summary>
    /// Issue confidence
    /// </summary>
    /// <value>Issue confidence</value>
    [DataMember(Name="confidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confidence")]
    public float? Confidence { get; set; }

    /// <summary>
    /// Cookie
    /// </summary>
    /// <value>Cookie</value>
    [DataMember(Name="cookie", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cookie")]
    public string Cookie { get; set; }

    /// <summary>
    /// All the additional custom attributes defined for the issue by parser plugin
    /// </summary>
    /// <value>All the additional custom attributes defined for the issue by parser plugin</value>
    [DataMember(Name="customAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customAttributes")]
    public Object CustomAttributes { get; set; }

    /// <summary>
    /// Custom tag values
    /// </summary>
    /// <value>Custom tag values</value>
    [DataMember(Name="customTagValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customTagValues")]
    public List<CustomTag> CustomTagValues { get; set; }

    /// <summary>
    /// Version of the issue data. This attribute is initialized only for issues parsed by 3rd party parsers and is not set for the issues parsed by standard parsers included in SSC installation.
    /// </summary>
    /// <value>Version of the issue data. This attribute is initialized only for issues parsed by 3rd party parsers and is not set for the issues parsed by standard parsers included in SSC installation.</value>
    [DataMember(Name="dataVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataVersion")]
    public int? DataVersion { get; set; }

    /// <summary>
    /// Issue detail
    /// </summary>
    /// <value>Issue detail</value>
    [DataMember(Name="detail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "detail")]
    public string Detail { get; set; }

    /// <summary>
    /// Display engine type
    /// </summary>
    /// <value>Display engine type</value>
    [DataMember(Name="displayEngineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayEngineType")]
    public string DisplayEngineType { get; set; }

    /// <summary>
    /// Request contains binary or large data
    /// </summary>
    /// <value>Request contains binary or large data</value>
    [DataMember(Name="downloadRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downloadRequest")]
    public bool? DownloadRequest { get; set; }

    /// <summary>
    /// Response contains binary or large data\"
    /// </summary>
    /// <value>Response contains binary or large data\"</value>
    [DataMember(Name="downloadResponse", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "downloadResponse")]
    public bool? DownloadResponse { get; set; }

    /// <summary>
    /// Engine category
    /// </summary>
    /// <value>Engine category</value>
    [DataMember(Name="engineCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineCategory")]
    public string EngineCategory { get; set; }

    /// <summary>
    /// Engine type
    /// </summary>
    /// <value>Engine type</value>
    [DataMember(Name="engineType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "engineType")]
    public string EngineType { get; set; }

    /// <summary>
    /// Issue found date
    /// </summary>
    /// <value>Issue found date</value>
    [DataMember(Name="foundDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "foundDate")]
    public DateTime? FoundDate { get; set; }

    /// <summary>
    /// Fortify priority order (Friority)
    /// </summary>
    /// <value>Fortify priority order (Friority)</value>
    [DataMember(Name="friority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "friority")]
    public string Friority { get; set; }

    /// <summary>
    /// Full file name where issue found
    /// </summary>
    /// <value>Full file name where issue found</value>
    [DataMember(Name="fullFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullFileName")]
    public string FullFileName { get; set; }

    /// <summary>
    /// Name of function located in the file where the vulnerability has been found
    /// </summary>
    /// <value>Name of function located in the file where the vulnerability has been found</value>
    [DataMember(Name="functionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "functionName")]
    public string FunctionName { get; set; }

    /// <summary>
    /// Flag that indicates if there is a view template that should be used to display issue details on UI.
    /// </summary>
    /// <value>Flag that indicates if there is a view template that should be used to display issue details on UI.</value>
    [DataMember(Name="hasViewTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasViewTemplate")]
    public bool? HasViewTemplate { get; set; }

    /// <summary>
    /// Set to true if issue is hidden
    /// </summary>
    /// <value>Set to true if issue is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Identifier
    /// </summary>
    /// <value>Identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// Issue impact
    /// </summary>
    /// <value>Issue impact</value>
    [DataMember(Name="impact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "impact")]
    public float? Impact { get; set; }

    /// <summary>
    /// Issue instance identifier
    /// </summary>
    /// <value>Issue instance identifier</value>
    [DataMember(Name="issueInstanceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueInstanceId")]
    public string IssueInstanceId { get; set; }

    /// <summary>
    /// Name of the issue category
    /// </summary>
    /// <value>Name of the issue category</value>
    [DataMember(Name="issueName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueName")]
    public string IssueName { get; set; }

    /// <summary>
    /// Flag represents issue state and says if issue is not an issue or open issue. Rule to calculate value of thi flag is defined in issue template.
    /// </summary>
    /// <value>Flag represents issue state and says if issue is not an issue or open issue. Rule to calculate value of thi flag is defined in issue template.</value>
    [DataMember(Name="issueState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueState")]
    public string IssueState { get; set; }

    /// <summary>
    /// Flag represents issue review status
    /// </summary>
    /// <value>Flag represents issue review status</value>
    [DataMember(Name="issueStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issueStatus")]
    public string IssueStatus { get; set; }

    /// <summary>
    /// Issue kingdom
    /// </summary>
    /// <value>Issue kingdom</value>
    [DataMember(Name="kingdom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kingdom")]
    public string Kingdom { get; set; }

    /// <summary>
    /// ID of the latest scan that found the issue
    /// </summary>
    /// <value>ID of the latest scan that found the issue</value>
    [DataMember(Name="lastScanId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastScanId")]
    public long? LastScanId { get; set; }

    /// <summary>
    /// Issue likelihood
    /// </summary>
    /// <value>Issue likelihood</value>
    [DataMember(Name="likelihood", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "likelihood")]
    public float? Likelihood { get; set; }

    /// <summary>
    /// Line number in the file where the vulnerability has been found
    /// </summary>
    /// <value>Line number in the file where the vulnerability has been found</value>
    [DataMember(Name="lineNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineNumber")]
    public int? LineNumber { get; set; }

    /// <summary>
    /// Name of the Fortify category of the vulnerability
    /// </summary>
    /// <value>Name of the Fortify category of the vulnerability</value>
    [DataMember(Name="mappedCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mappedCategory")]
    public string MappedCategory { get; set; }

    /// <summary>
    /// Method where issue found
    /// </summary>
    /// <value>Method where issue found</value>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Confidence level which estimates that vulnerability found in virtual (overridden) function will be executed by tainted source
    /// </summary>
    /// <value>Confidence level which estimates that vulnerability found in virtual (overridden) function will be executed by tainted source</value>
    [DataMember(Name="minVirtualCallConfidence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minVirtualCallConfidence")]
    public float? MinVirtualCallConfidence { get; set; }

    /// <summary>
    /// Name of package where the vulnerability has been found
    /// </summary>
    /// <value>Name of package where the vulnerability has been found</value>
    [DataMember(Name="packageName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packageName")]
    public string PackageName { get; set; }

    /// <summary>
    /// Primary rule global unique identifier
    /// </summary>
    /// <value>Primary rule global unique identifier</value>
    [DataMember(Name="primaryRuleGuid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryRuleGuid")]
    public string PrimaryRuleGuid { get; set; }

    /// <summary>
    /// Identifier, name and value of the custom tag that is selected as a primary tag for the application version the issue belongs to.
    /// </summary>
    /// <value>Identifier, name and value of the custom tag that is selected as a primary tag for the application version the issue belongs to.</value>
    [DataMember(Name="primaryTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryTag")]
    public IssuePrimaryTag PrimaryTag { get; set; }

    /// <summary>
    /// Vulnerability probability
    /// </summary>
    /// <value>Vulnerability probability</value>
    [DataMember(Name="probability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "probability")]
    public float? Probability { get; set; }

    /// <summary>
    /// Application version identifier
    /// </summary>
    /// <value>Application version identifier</value>
    [DataMember(Name="projectVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionId")]
    public long? ProjectVersionId { get; set; }

    /// <summary>
    /// Issue recommendation
    /// </summary>
    /// <value>Issue recommendation</value>
    [DataMember(Name="recommendation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommendation")]
    public string Recommendation { get; set; }

    /// <summary>
    /// References
    /// </summary>
    /// <value>References</value>
    [DataMember(Name="references", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "references")]
    public string References { get; set; }

    /// <summary>
    /// Level of complexity to fix this vulnerability
    /// </summary>
    /// <value>Level of complexity to fix this vulnerability</value>
    [DataMember(Name="remediationConstant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "remediationConstant")]
    public float? RemediationConstant { get; set; }

    /// <summary>
    /// Issue removed date
    /// </summary>
    /// <value>Issue removed date</value>
    [DataMember(Name="removedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removedDate")]
    public DateTime? RemovedDate { get; set; }

    /// <summary>
    /// Request body
    /// </summary>
    /// <value>Request body</value>
    [DataMember(Name="requestBody", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestBody")]
    public string RequestBody { get; set; }

    /// <summary>
    /// Request header
    /// </summary>
    /// <value>Request header</value>
    [DataMember(Name="requestHeader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestHeader")]
    public string RequestHeader { get; set; }

    /// <summary>
    /// Request parameter
    /// </summary>
    /// <value>Request parameter</value>
    [DataMember(Name="requestParameter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestParameter")]
    public string RequestParameter { get; set; }

    /// <summary>
    /// Triggers in the request
    /// </summary>
    /// <value>Triggers in the request</value>
    [DataMember(Name="requestTriggers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestTriggers")]
    public List<Trigger> RequestTriggers { get; set; }

    /// <summary>
    /// Response
    /// </summary>
    /// <value>Response</value>
    [DataMember(Name="response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "response")]
    public string Response { get; set; }

    /// <summary>
    /// Response header
    /// </summary>
    /// <value>Response header</value>
    [DataMember(Name="responseHeader", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseHeader")]
    public string ResponseHeader { get; set; }

    /// <summary>
    /// Triggers in the response
    /// </summary>
    /// <value>Triggers in the response</value>
    [DataMember(Name="responseTriggers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "responseTriggers")]
    public List<Trigger> ResponseTriggers { get; set; }

    /// <summary>
    /// Revision number
    /// </summary>
    /// <value>Revision number</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public int? Revision { get; set; }

    /// <summary>
    /// Scan status
    /// </summary>
    /// <value>Scan status</value>
    [DataMember(Name="scanStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scanStatus")]
    public string ScanStatus { get; set; }

    /// <summary>
    /// Issue severity
    /// </summary>
    /// <value>Issue severity</value>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public float? Severity { get; set; }

    /// <summary>
    /// Short file name where issue found
    /// </summary>
    /// <value>Short file name where issue found</value>
    [DataMember(Name="shortFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortFileName")]
    public string ShortFileName { get; set; }

    /// <summary>
    /// Taint sink name
    /// </summary>
    /// <value>Taint sink name</value>
    [DataMember(Name="sink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sink")]
    public string Sink { get; set; }

    /// <summary>
    /// Name of the context that contains vulnerability sink
    /// </summary>
    /// <value>Name of the context that contains vulnerability sink</value>
    [DataMember(Name="sinkContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sinkContext")]
    public string SinkContext { get; set; }

    /// <summary>
    /// Name of the a program point where tainted data enter the program
    /// </summary>
    /// <value>Name of the a program point where tainted data enter the program</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// Name of the context that contains vulnerability sources
    /// </summary>
    /// <value>Name of the context that contains vulnerability sources</value>
    [DataMember(Name="sourceContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceContext")]
    public string SourceContext { get; set; }

    /// <summary>
    /// File name where vulnerability source is located.
    /// </summary>
    /// <value>File name where vulnerability source is located.</value>
    [DataMember(Name="sourceFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceFile")]
    public string SourceFile { get; set; }

    /// <summary>
    /// Line number in the source file where vulnerability source is located
    /// </summary>
    /// <value>Line number in the source file where vulnerability source is located</value>
    [DataMember(Name="sourceLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceLine")]
    public int? SourceLine { get; set; }

    /// <summary>
    /// Set to true if issue is suppressed
    /// </summary>
    /// <value>Set to true if issue is suppressed</value>
    [DataMember(Name="suppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressed")]
    public bool? Suppressed { get; set; }

    /// <summary>
    /// An attribute of tainted data that enables the data flow analyzer to discriminate between different types of taint
    /// </summary>
    /// <value>An attribute of tainted data that enables the data flow analyzer to discriminate between different types of taint</value>
    [DataMember(Name="taintFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taintFlag")]
    public string TaintFlag { get; set; }

    /// <summary>
    /// Issue tips
    /// </summary>
    /// <value>Issue tips</value>
    [DataMember(Name="tips", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tips")]
    public string Tips { get; set; }

    /// <summary>
    /// Issue trace nodes
    /// </summary>
    /// <value>Issue trace nodes</value>
    [DataMember(Name="traceNodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "traceNodes")]
    public List<List<TraceNodeDto>> TraceNodes { get; set; }

    /// <summary>
    /// Trigger string
    /// </summary>
    /// <value>Trigger string</value>
    [DataMember(Name="triggerString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerString")]
    public string TriggerString { get; set; }

    /// <summary>
    /// Issue url
    /// </summary>
    /// <value>Issue url</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Vulnerable parameter
    /// </summary>
    /// <value>Vulnerable parameter</value>
    [DataMember(Name="vulnerableParameter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vulnerableParameter")]
    public string VulnerableParameter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProjectVersionIssueDetails {\n");
      sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
      sb.Append("  Analyzer: ").Append(Analyzer).Append("\n");
      sb.Append("  AppSecTrainingUrl: ").Append(AppSecTrainingUrl).Append("\n");
      sb.Append("  AssignedUser: ").Append(AssignedUser).Append("\n");
      sb.Append("  AttackPayload: ").Append(AttackPayload).Append("\n");
      sb.Append("  AttackType: ").Append(AttackType).Append("\n");
      sb.Append("  Audited: ").Append(Audited).Append("\n");
      sb.Append("  Brief: ").Append(Brief).Append("\n");
      sb.Append("  ClassName: ").Append(ClassName).Append("\n");
      sb.Append("  Confidence: ").Append(Confidence).Append("\n");
      sb.Append("  Cookie: ").Append(Cookie).Append("\n");
      sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
      sb.Append("  CustomTagValues: ").Append(CustomTagValues).Append("\n");
      sb.Append("  DataVersion: ").Append(DataVersion).Append("\n");
      sb.Append("  Detail: ").Append(Detail).Append("\n");
      sb.Append("  DisplayEngineType: ").Append(DisplayEngineType).Append("\n");
      sb.Append("  DownloadRequest: ").Append(DownloadRequest).Append("\n");
      sb.Append("  DownloadResponse: ").Append(DownloadResponse).Append("\n");
      sb.Append("  EngineCategory: ").Append(EngineCategory).Append("\n");
      sb.Append("  EngineType: ").Append(EngineType).Append("\n");
      sb.Append("  FoundDate: ").Append(FoundDate).Append("\n");
      sb.Append("  Friority: ").Append(Friority).Append("\n");
      sb.Append("  FullFileName: ").Append(FullFileName).Append("\n");
      sb.Append("  FunctionName: ").Append(FunctionName).Append("\n");
      sb.Append("  HasViewTemplate: ").Append(HasViewTemplate).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Impact: ").Append(Impact).Append("\n");
      sb.Append("  IssueInstanceId: ").Append(IssueInstanceId).Append("\n");
      sb.Append("  IssueName: ").Append(IssueName).Append("\n");
      sb.Append("  IssueState: ").Append(IssueState).Append("\n");
      sb.Append("  IssueStatus: ").Append(IssueStatus).Append("\n");
      sb.Append("  Kingdom: ").Append(Kingdom).Append("\n");
      sb.Append("  LastScanId: ").Append(LastScanId).Append("\n");
      sb.Append("  Likelihood: ").Append(Likelihood).Append("\n");
      sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
      sb.Append("  MappedCategory: ").Append(MappedCategory).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  MinVirtualCallConfidence: ").Append(MinVirtualCallConfidence).Append("\n");
      sb.Append("  PackageName: ").Append(PackageName).Append("\n");
      sb.Append("  PrimaryRuleGuid: ").Append(PrimaryRuleGuid).Append("\n");
      sb.Append("  PrimaryTag: ").Append(PrimaryTag).Append("\n");
      sb.Append("  Probability: ").Append(Probability).Append("\n");
      sb.Append("  ProjectVersionId: ").Append(ProjectVersionId).Append("\n");
      sb.Append("  Recommendation: ").Append(Recommendation).Append("\n");
      sb.Append("  References: ").Append(References).Append("\n");
      sb.Append("  RemediationConstant: ").Append(RemediationConstant).Append("\n");
      sb.Append("  RemovedDate: ").Append(RemovedDate).Append("\n");
      sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
      sb.Append("  RequestHeader: ").Append(RequestHeader).Append("\n");
      sb.Append("  RequestParameter: ").Append(RequestParameter).Append("\n");
      sb.Append("  RequestTriggers: ").Append(RequestTriggers).Append("\n");
      sb.Append("  Response: ").Append(Response).Append("\n");
      sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
      sb.Append("  ResponseTriggers: ").Append(ResponseTriggers).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  ScanStatus: ").Append(ScanStatus).Append("\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
      sb.Append("  ShortFileName: ").Append(ShortFileName).Append("\n");
      sb.Append("  Sink: ").Append(Sink).Append("\n");
      sb.Append("  SinkContext: ").Append(SinkContext).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  SourceContext: ").Append(SourceContext).Append("\n");
      sb.Append("  SourceFile: ").Append(SourceFile).Append("\n");
      sb.Append("  SourceLine: ").Append(SourceLine).Append("\n");
      sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
      sb.Append("  TaintFlag: ").Append(TaintFlag).Append("\n");
      sb.Append("  Tips: ").Append(Tips).Append("\n");
      sb.Append("  TraceNodes: ").Append(TraceNodes).Append("\n");
      sb.Append("  TriggerString: ").Append(TriggerString).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  VulnerableParameter: ").Append(VulnerableParameter).Append("\n");
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
