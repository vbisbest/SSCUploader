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
    public interface IProjectVersionOfProjectControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultProjectVersion</returns>
        ApiResultProjectVersion CreateProjectVersionOfProject (long? parentId, ProjectVersion resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search-spec of full text search query (see fulltextsearch parameter)</param>
        /// <param name="fulltextsearch">If &#39;true&#39;, interpret &#39;q&#39; parameter as full text search query, defaults to &#39;false&#39;</param>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="includeInactive">includeInactive</param>
        /// <param name="myAssignedIssues">myAssignedIssues</param>
        /// <returns>ApiResultListProjectVersion</returns>
        ApiResultListProjectVersion ListProjectVersionOfProject (long? parentId, string fields, int? start, int? limit, string q, bool? fulltextsearch, string orderby, bool? includeInactive, bool? myAssignedIssues);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProjectVersionOfProjectControllerApi : IProjectVersionOfProjectControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVersionOfProjectControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProjectVersionOfProjectControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVersionOfProjectControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProjectVersionOfProjectControllerApi(String basePath)
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
        /// create 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultProjectVersion</returns>            
        public ApiResultProjectVersion CreateProjectVersionOfProject (long? parentId, ProjectVersion resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling CreateProjectVersionOfProject");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateProjectVersionOfProject");
            
    
            var path = "/projects/{parentId}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateProjectVersionOfProject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateProjectVersionOfProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersion), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search-spec of full text search query (see fulltextsearch parameter)</param> 
        /// <param name="fulltextsearch">If &#39;true&#39;, interpret &#39;q&#39; parameter as full text search query, defaults to &#39;false&#39;</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <param name="includeInactive">includeInactive</param> 
        /// <param name="myAssignedIssues">myAssignedIssues</param> 
        /// <returns>ApiResultListProjectVersion</returns>            
        public ApiResultListProjectVersion ListProjectVersionOfProject (long? parentId, string fields, int? start, int? limit, string q, bool? fulltextsearch, string orderby, bool? includeInactive, bool? myAssignedIssues)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListProjectVersionOfProject");
            
    
            var path = "/projects/{parentId}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
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
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (includeInactive != null) queryParams.Add("includeInactive", ApiClient.ParameterToString(includeInactive)); // query parameter
 if (myAssignedIssues != null) queryParams.Add("myAssignedIssues", ApiClient.ParameterToString(myAssignedIssues)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListProjectVersionOfProject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListProjectVersionOfProject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListProjectVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultListProjectVersion), response.Headers);
        }
    
    }
}
