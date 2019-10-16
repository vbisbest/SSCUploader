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
    public interface IPerformanceIndicatorHistoryOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <returns>ApiResultListPerformanceIndicatorHistory</returns>
        ApiResultListPerformanceIndicatorHistory ListPerformanceIndicatorHistoryOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultPerformanceIndicatorHistory</returns>
        ApiResultPerformanceIndicatorHistory ReadPerformanceIndicatorHistoryOfProjectVersion (long? parentId, string id, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PerformanceIndicatorHistoryOfProjectVersionControllerApi : IPerformanceIndicatorHistoryOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceIndicatorHistoryOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PerformanceIndicatorHistoryOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceIndicatorHistoryOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PerformanceIndicatorHistoryOfProjectVersionControllerApi(String basePath)
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
        /// <returns>ApiResultListPerformanceIndicatorHistory</returns>            
        public ApiResultListPerformanceIndicatorHistory ListPerformanceIndicatorHistoryOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListPerformanceIndicatorHistoryOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/performanceIndicatorHistories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListPerformanceIndicatorHistoryOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPerformanceIndicatorHistoryOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListPerformanceIndicatorHistory) ApiClient.Deserialize(response.Content, typeof(ApiResultListPerformanceIndicatorHistory), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultPerformanceIndicatorHistory</returns>            
        public ApiResultPerformanceIndicatorHistory ReadPerformanceIndicatorHistoryOfProjectVersion (long? parentId, string id, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ReadPerformanceIndicatorHistoryOfProjectVersion");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadPerformanceIndicatorHistoryOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/performanceIndicatorHistories/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPerformanceIndicatorHistoryOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPerformanceIndicatorHistoryOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultPerformanceIndicatorHistory) ApiClient.Deserialize(response.Content, typeof(ApiResultPerformanceIndicatorHistory), response.Headers);
        }
    
    }
}
