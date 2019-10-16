using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIssueAgingControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="filterby">filterby</param>
        /// <param name="aggregateby">aggregateby</param>
        /// <param name="groupguid">groupguid</param>
        /// <param name="groupvalue">groupvalue</param>
        /// <param name="name">name</param>
        /// <param name="numberOfApplicationVersions">numberOfApplicationVersions</param>
        /// <param name="linesOfCode">linesOfCode</param>
        /// <param name="issuesPendingReview">issuesPendingReview</param>
        /// <param name="openIssues">openIssues</param>
        /// <param name="filesScanned">filesScanned</param>
        /// <param name="bugDensity">bugDensity</param>
        /// <param name="averageDaysToReview">averageDaysToReview</param>
        /// <param name="averageDaysToRemediate">averageDaysToRemediate</param>
        /// <returns>ApiResultListIssueAgingDto</returns>
        ApiResultListIssueAgingDto ListIssueAging (string orderby, string fields, int? start, int? limit, string filterby, string aggregateby, string groupguid, string groupvalue, string name, string numberOfApplicationVersions, string linesOfCode, string issuesPendingReview, string openIssues, string filesScanned, string bugDensity, string averageDaysToReview, string averageDaysToRemediate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueAgingControllerApi : IIssueAgingControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueAgingControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueAgingControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueAgingControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueAgingControllerApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="orderby">Fields to order by</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="filterby">filterby</param> 
        /// <param name="aggregateby">aggregateby</param> 
        /// <param name="groupguid">groupguid</param> 
        /// <param name="groupvalue">groupvalue</param> 
        /// <param name="name">name</param> 
        /// <param name="numberOfApplicationVersions">numberOfApplicationVersions</param> 
        /// <param name="linesOfCode">linesOfCode</param> 
        /// <param name="issuesPendingReview">issuesPendingReview</param> 
        /// <param name="openIssues">openIssues</param> 
        /// <param name="filesScanned">filesScanned</param> 
        /// <param name="bugDensity">bugDensity</param> 
        /// <param name="averageDaysToReview">averageDaysToReview</param> 
        /// <param name="averageDaysToRemediate">averageDaysToRemediate</param> 
        /// <returns>ApiResultListIssueAgingDto</returns>            
        public ApiResultListIssueAgingDto ListIssueAging (string orderby, string fields, int? start, int? limit, string filterby, string aggregateby, string groupguid, string groupvalue, string name, string numberOfApplicationVersions, string linesOfCode, string issuesPendingReview, string openIssues, string filesScanned, string bugDensity, string averageDaysToReview, string averageDaysToRemediate)
        {
            
    
            var path = "/issueaging";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (filterby != null) queryParams.Add("filterby", ApiClient.ParameterToString(filterby)); // query parameter
 if (aggregateby != null) queryParams.Add("aggregateby", ApiClient.ParameterToString(aggregateby)); // query parameter
 if (groupguid != null) queryParams.Add("groupguid", ApiClient.ParameterToString(groupguid)); // query parameter
 if (groupvalue != null) queryParams.Add("groupvalue", ApiClient.ParameterToString(groupvalue)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (numberOfApplicationVersions != null) queryParams.Add("numberOfApplicationVersions", ApiClient.ParameterToString(numberOfApplicationVersions)); // query parameter
 if (linesOfCode != null) queryParams.Add("linesOfCode", ApiClient.ParameterToString(linesOfCode)); // query parameter
 if (issuesPendingReview != null) queryParams.Add("issuesPendingReview", ApiClient.ParameterToString(issuesPendingReview)); // query parameter
 if (openIssues != null) queryParams.Add("openIssues", ApiClient.ParameterToString(openIssues)); // query parameter
 if (filesScanned != null) queryParams.Add("filesScanned", ApiClient.ParameterToString(filesScanned)); // query parameter
 if (bugDensity != null) queryParams.Add("bugDensity", ApiClient.ParameterToString(bugDensity)); // query parameter
 if (averageDaysToReview != null) queryParams.Add("averageDaysToReview", ApiClient.ParameterToString(averageDaysToReview)); // query parameter
 if (averageDaysToRemediate != null) queryParams.Add("averageDaysToRemediate", ApiClient.ParameterToString(averageDaysToRemediate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueAging: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueAging: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListIssueAgingDto) ApiClient.Deserialize(response.Content, typeof(ApiResultListIssueAgingDto), response.Headers);
        }
    
    }
}
