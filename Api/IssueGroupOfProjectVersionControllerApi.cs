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
    public interface IIssueGroupOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">An issue query expression, must be used together with the &#39;qm&#39; parameter</param>
        /// <param name="qm">Syntax mode for the &#39;q&#39; parameter, mandatory if the &#39;q&#39; parameter is used</param>
        /// <param name="filterset">Filter set to use</param>
        /// <param name="fields">Output fields</param>
        /// <param name="showhidden">If &#39;true&#39;, include hidden issues in search results. If &#39;false&#39;, exclude hidden issues from search results. If no options are set, use application version profile settings to get value of this option.</param>
        /// <param name="showremoved">If &#39;true&#39;, include removed issues in search results. If &#39;false&#39;, exclude removed issues from search results. If no options are set, use application version profile settings to get value of this option.</param>
        /// <param name="showsuppressed">If &#39;true&#39;, include suppressed issues in search results. If &#39;false&#39;, exclude suppressed issues from search results. If no options are set, use application version profile settings to get value of this option.</param>
        /// <param name="showshortfilenames">If &#39;true&#39;, only short file names will be displayed in issues list.</param>
        /// <param name="filter">filter</param>
        /// <param name="groupingtype">groupingtype</param>
        /// <returns>ApiResultListProjectVersionIssueGroup</returns>
        ApiResultListProjectVersionIssueGroup ListIssueGroupOfProjectVersion (long? parentId, int? start, int? limit, string q, string qm, string filterset, string fields, bool? showhidden, bool? showremoved, bool? showsuppressed, bool? showshortfilenames, string filter, string groupingtype);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueGroupOfProjectVersionControllerApi : IIssueGroupOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueGroupOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueGroupOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueGroupOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueGroupOfProjectVersionControllerApi(String basePath)
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
        /// <param name="parentId">parentId</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">An issue query expression, must be used together with the &#39;qm&#39; parameter</param> 
        /// <param name="qm">Syntax mode for the &#39;q&#39; parameter, mandatory if the &#39;q&#39; parameter is used</param> 
        /// <param name="filterset">Filter set to use</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="showhidden">If &#39;true&#39;, include hidden issues in search results. If &#39;false&#39;, exclude hidden issues from search results. If no options are set, use application version profile settings to get value of this option.</param> 
        /// <param name="showremoved">If &#39;true&#39;, include removed issues in search results. If &#39;false&#39;, exclude removed issues from search results. If no options are set, use application version profile settings to get value of this option.</param> 
        /// <param name="showsuppressed">If &#39;true&#39;, include suppressed issues in search results. If &#39;false&#39;, exclude suppressed issues from search results. If no options are set, use application version profile settings to get value of this option.</param> 
        /// <param name="showshortfilenames">If &#39;true&#39;, only short file names will be displayed in issues list.</param> 
        /// <param name="filter">filter</param> 
        /// <param name="groupingtype">groupingtype</param> 
        /// <returns>ApiResultListProjectVersionIssueGroup</returns>            
        public ApiResultListProjectVersionIssueGroup ListIssueGroupOfProjectVersion (long? parentId, int? start, int? limit, string q, string qm, string filterset, string fields, bool? showhidden, bool? showremoved, bool? showsuppressed, bool? showshortfilenames, string filter, string groupingtype)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListIssueGroupOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issueGroups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (qm != null) queryParams.Add("qm", ApiClient.ParameterToString(qm)); // query parameter
 if (filterset != null) queryParams.Add("filterset", ApiClient.ParameterToString(filterset)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (showhidden != null) queryParams.Add("showhidden", ApiClient.ParameterToString(showhidden)); // query parameter
 if (showremoved != null) queryParams.Add("showremoved", ApiClient.ParameterToString(showremoved)); // query parameter
 if (showsuppressed != null) queryParams.Add("showsuppressed", ApiClient.ParameterToString(showsuppressed)); // query parameter
 if (showshortfilenames != null) queryParams.Add("showshortfilenames", ApiClient.ParameterToString(showshortfilenames)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (groupingtype != null) queryParams.Add("groupingtype", ApiClient.ParameterToString(groupingtype)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueGroupOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueGroupOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListProjectVersionIssueGroup) ApiClient.Deserialize(response.Content, typeof(ApiResultListProjectVersionIssueGroup), response.Headers);
        }
    
    }
}
