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
    public interface IUserPreferencesControllerApi
    {
        /// <summary>
        /// Retrieve the current user&#39;s session preferences. (The &#39;username&#39; parameter is not yet supported) 
        /// </summary>
        /// <param name="username">username</param>
        /// <returns>ApiResultUserPreferences</returns>
        ApiResultUserPreferences PostUserPreferences (string username);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultUserPreferences</returns>
        ApiResultUserPreferences UpdateUserPreferences (UserPreferences resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserPreferencesControllerApi : IUserPreferencesControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserPreferencesControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserPreferencesControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserPreferencesControllerApi(String basePath)
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
        /// Retrieve the current user&#39;s session preferences. (The &#39;username&#39; parameter is not yet supported) 
        /// </summary>
        /// <param name="username">username</param> 
        /// <returns>ApiResultUserPreferences</returns>            
        public ApiResultUserPreferences PostUserPreferences (string username)
        {
            
            // verify the required parameter 'username' is set
            if (username == null) throw new ApiException(400, "Missing required parameter 'username' when calling PostUserPreferences");
            
    
            var path = "/userSession/prefs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(username); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserPreferences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostUserPreferences: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserPreferences) ApiClient.Deserialize(response.Content, typeof(ApiResultUserPreferences), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultUserPreferences</returns>            
        public ApiResultUserPreferences UpdateUserPreferences (UserPreferences resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateUserPreferences");
            
    
            var path = "/userSession/prefs";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserPreferences: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserPreferences: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserPreferences) ApiClient.Deserialize(response.Content, typeof(ApiResultUserPreferences), response.Headers);
        }
    
    }
}
