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
    public interface IResponsibilityAssignmentOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <returns>ApiResultListResponsibilityAssignment</returns>
        ApiResultListResponsibilityAssignment ListResponsibilityAssignmentOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="guid">guid</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultResponsibilityAssignment</returns>
        ApiResultResponsibilityAssignment ReadResponsibilityAssignmentOfProjectVersion (long? parentId, string guid, string fields);
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="data">data</param>
        /// <returns>ApiResultListResponsibilityAssignment</returns>
        ApiResultListResponsibilityAssignment UpdateCollectionResponsibilityAssignmentOfProjectVersion (long? parentId, List<ResponsibilityAssignment> data);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ResponsibilityAssignmentOfProjectVersionControllerApi : IResponsibilityAssignmentOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsibilityAssignmentOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ResponsibilityAssignmentOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsibilityAssignmentOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResponsibilityAssignmentOfProjectVersionControllerApi(String basePath)
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
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search query</param> 
        /// <returns>ApiResultListResponsibilityAssignment</returns>            
        public ApiResultListResponsibilityAssignment ListResponsibilityAssignmentOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListResponsibilityAssignmentOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/responsibilities";
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
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListResponsibilityAssignmentOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListResponsibilityAssignmentOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListResponsibilityAssignment) ApiClient.Deserialize(response.Content, typeof(ApiResultListResponsibilityAssignment), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="guid">guid</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultResponsibilityAssignment</returns>            
        public ApiResultResponsibilityAssignment ReadResponsibilityAssignmentOfProjectVersion (long? parentId, string guid, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ReadResponsibilityAssignmentOfProjectVersion");
            
            // verify the required parameter 'guid' is set
            if (guid == null) throw new ApiException(400, "Missing required parameter 'guid' when calling ReadResponsibilityAssignmentOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/responsibilities/{guid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
path = path.Replace("{" + "guid" + "}", ApiClient.ParameterToString(guid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadResponsibilityAssignmentOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadResponsibilityAssignmentOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultResponsibilityAssignment) ApiClient.Deserialize(response.Content, typeof(ApiResultResponsibilityAssignment), response.Headers);
        }
    
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="data">data</param> 
        /// <returns>ApiResultListResponsibilityAssignment</returns>            
        public ApiResultListResponsibilityAssignment UpdateCollectionResponsibilityAssignmentOfProjectVersion (long? parentId, List<ResponsibilityAssignment> data)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateCollectionResponsibilityAssignmentOfProjectVersion");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling UpdateCollectionResponsibilityAssignmentOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/responsibilities";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(data); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionResponsibilityAssignmentOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionResponsibilityAssignmentOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListResponsibilityAssignment) ApiClient.Deserialize(response.Content, typeof(ApiResultListResponsibilityAssignment), response.Headers);
        }
    
    }
}
