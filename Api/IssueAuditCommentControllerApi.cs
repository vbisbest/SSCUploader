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
    public interface IIssueAuditCommentControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="q">A full text search query</param>
        /// <param name="fulltextsearch">Only &#39;true&#39; is supported</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <returns>ApiResultListIssueAuditComment</returns>
        ApiResultListIssueAuditComment ListIssueAuditComment (string q, string fulltextsearch, string fields, int? start, int? limit);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueAuditCommentControllerApi : IIssueAuditCommentControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueAuditCommentControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueAuditCommentControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueAuditCommentControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueAuditCommentControllerApi(String basePath)
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
        /// <param name="q">A full text search query</param> 
        /// <param name="fulltextsearch">Only &#39;true&#39; is supported</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <returns>ApiResultListIssueAuditComment</returns>            
        public ApiResultListIssueAuditComment ListIssueAuditComment (string q, string fulltextsearch, string fields, int? start, int? limit)
        {
            
            // verify the required parameter 'q' is set
            if (q == null) throw new ApiException(400, "Missing required parameter 'q' when calling ListIssueAuditComment");
            
            // verify the required parameter 'fulltextsearch' is set
            if (fulltextsearch == null) throw new ApiException(400, "Missing required parameter 'fulltextsearch' when calling ListIssueAuditComment");
            
    
            var path = "/comments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (fulltextsearch != null) queryParams.Add("fulltextsearch", ApiClient.ParameterToString(fulltextsearch)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueAuditComment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueAuditComment: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListIssueAuditComment) ApiClient.Deserialize(response.Content, typeof(ApiResultListIssueAuditComment), response.Headers);
        }
    
    }
}
