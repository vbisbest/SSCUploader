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
    public interface IUserIssueSearchOptionsControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <returns>ApiResultUserIssueSearchOptions</returns>
        ApiResultUserIssueSearchOptions GetUserIssueSearchOptions ();
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultUserIssueSearchOptions</returns>
        ApiResultUserIssueSearchOptions UpdateUserIssueSearchOptions (UserIssueSearchOptions resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserIssueSearchOptionsControllerApi : IUserIssueSearchOptionsControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIssueSearchOptionsControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserIssueSearchOptionsControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIssueSearchOptionsControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserIssueSearchOptionsControllerApi(String basePath)
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
        /// <returns>ApiResultUserIssueSearchOptions</returns>            
        public ApiResultUserIssueSearchOptions GetUserIssueSearchOptions ()
        {
            
    
            var path = "/userIssueSearchOptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserIssueSearchOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserIssueSearchOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserIssueSearchOptions) ApiClient.Deserialize(response.Content, typeof(ApiResultUserIssueSearchOptions), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultUserIssueSearchOptions</returns>            
        public ApiResultUserIssueSearchOptions UpdateUserIssueSearchOptions (UserIssueSearchOptions resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateUserIssueSearchOptions");
            
    
            var path = "/userIssueSearchOptions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserIssueSearchOptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserIssueSearchOptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserIssueSearchOptions) ApiClient.Deserialize(response.Content, typeof(ApiResultUserIssueSearchOptions), response.Headers);
        }
    
    }
}
