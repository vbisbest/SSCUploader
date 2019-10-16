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
    public interface IUserSessionStateControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <returns>ApiResultListUserSessionState</returns>
        ApiResultListUserSessionState ListUserSessionState (int? start, int? limit, string q);
        /// <summary>
        /// put 
        /// </summary>
        /// <param name="resources">resources</param>
        /// <returns>ApiResultListUserSessionState</returns>
        ApiResultListUserSessionState PutUserSessionState (List<UserSessionState> resources);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserSessionStateControllerApi : IUserSessionStateControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionStateControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserSessionStateControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionStateControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserSessionStateControllerApi(String basePath)
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
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search query</param> 
        /// <returns>ApiResultListUserSessionState</returns>            
        public ApiResultListUserSessionState ListUserSessionState (int? start, int? limit, string q)
        {
            
    
            var path = "/userSession/state";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListUserSessionState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListUserSessionState: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListUserSessionState) ApiClient.Deserialize(response.Content, typeof(ApiResultListUserSessionState), response.Headers);
        }
    
        /// <summary>
        /// put 
        /// </summary>
        /// <param name="resources">resources</param> 
        /// <returns>ApiResultListUserSessionState</returns>            
        public ApiResultListUserSessionState PutUserSessionState (List<UserSessionState> resources)
        {
            
            // verify the required parameter 'resources' is set
            if (resources == null) throw new ApiException(400, "Missing required parameter 'resources' when calling PutUserSessionState");
            
    
            var path = "/userSession/state";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resources); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUserSessionState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutUserSessionState: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListUserSessionState) ApiClient.Deserialize(response.Content, typeof(ApiResultListUserSessionState), response.Headers);
        }
    
    }
}
