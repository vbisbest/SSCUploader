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
    public interface IApplicationStateControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <returns>ApiResultApplicationState</returns>
        ApiResultApplicationState GetApplicationState ();
        /// <summary>
        /// put 
        /// </summary>
        /// <param name="applicationState">applicationState</param>
        /// <returns>ApiResultApplicationState</returns>
        ApiResultApplicationState PutApplicationState (ApplicationState applicationState);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ApplicationStateControllerApi : IApplicationStateControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationStateControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ApplicationStateControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationStateControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApplicationStateControllerApi(String basePath)
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
        /// get 
        /// </summary>
        /// <returns>ApiResultApplicationState</returns>            
        public ApiResultApplicationState GetApplicationState ()
        {
            
    
            var path = "/applicationState";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApplicationState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetApplicationState: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultApplicationState) ApiClient.Deserialize(response.Content, typeof(ApiResultApplicationState), response.Headers);
        }
    
        /// <summary>
        /// put 
        /// </summary>
        /// <param name="applicationState">applicationState</param> 
        /// <returns>ApiResultApplicationState</returns>            
        public ApiResultApplicationState PutApplicationState (ApplicationState applicationState)
        {
            
            // verify the required parameter 'applicationState' is set
            if (applicationState == null) throw new ApiException(400, "Missing required parameter 'applicationState' when calling PutApplicationState");
            
    
            var path = "/applicationState";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(applicationState); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PutApplicationState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PutApplicationState: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultApplicationState) ApiClient.Deserialize(response.Content, typeof(ApiResultApplicationState), response.Headers);
        }
    
    }
}
