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
    public interface IBugTrackerControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultListBugTracker</returns>
        ApiResultListBugTracker ListBugTracker (string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BugTrackerControllerApi : IBugTrackerControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BugTrackerControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BugTrackerControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BugTrackerControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BugTrackerControllerApi(String basePath)
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
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultListBugTracker</returns>            
        public ApiResultListBugTracker ListBugTracker (string fields)
        {
            
    
            var path = "/bugtrackers";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListBugTracker: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBugTracker: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListBugTracker) ApiClient.Deserialize(response.Content, typeof(ApiResultListBugTracker), response.Headers);
        }
    
    }
}
