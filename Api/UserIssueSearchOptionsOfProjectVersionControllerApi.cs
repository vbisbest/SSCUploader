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
    public interface IUserIssueSearchOptionsOfProjectVersionControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultUserIssueSearchOptions</returns>
        ApiResultUserIssueSearchOptions GetUserIssueSearchOptionsOfProjectVersion (long? parentId, string fields);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultUserIssueSearchOptions</returns>
        ApiResultUserIssueSearchOptions UpdateUserIssueSearchOptionsOfProjectVersion (long? parentId, UserIssueSearchOptions resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UserIssueSearchOptionsOfProjectVersionControllerApi : IUserIssueSearchOptionsOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIssueSearchOptionsOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UserIssueSearchOptionsOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserIssueSearchOptionsOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserIssueSearchOptionsOfProjectVersionControllerApi(String basePath)
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
        /// <param name="parentId">parentId</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultUserIssueSearchOptions</returns>            
        public ApiResultUserIssueSearchOptions GetUserIssueSearchOptionsOfProjectVersion (long? parentId, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling GetUserIssueSearchOptionsOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/userIssueSearchOptions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserIssueSearchOptionsOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserIssueSearchOptionsOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserIssueSearchOptions) ApiClient.Deserialize(response.Content, typeof(ApiResultUserIssueSearchOptions), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultUserIssueSearchOptions</returns>            
        public ApiResultUserIssueSearchOptions UpdateUserIssueSearchOptionsOfProjectVersion (long? parentId, UserIssueSearchOptions resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateUserIssueSearchOptionsOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateUserIssueSearchOptionsOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/userIssueSearchOptions";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserIssueSearchOptionsOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserIssueSearchOptionsOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultUserIssueSearchOptions) ApiClient.Deserialize(response.Content, typeof(ApiResultUserIssueSearchOptions), response.Headers);
        }
    
    }
}
