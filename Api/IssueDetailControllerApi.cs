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
    public interface IIssueDetailControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="projectName">projectName</param>
        /// <param name="projectVersionName">projectVersionName</param>
        /// <param name="instanceId">instanceId</param>
        /// <returns>ApiResultListProjectVersionIssueDetails</returns>
        ApiResultListProjectVersionIssueDetails ListIssueDetail (string projectName, string projectVersionName, string instanceId);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="filterset">Filter set to use</param>
        /// <returns>ApiResultProjectVersionIssueDetails</returns>
        ApiResultProjectVersionIssueDetails ReadIssueDetail (long? id, string filterset);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueDetailControllerApi : IIssueDetailControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueDetailControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueDetailControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueDetailControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueDetailControllerApi(String basePath)
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
        /// <param name="projectName">projectName</param> 
        /// <param name="projectVersionName">projectVersionName</param> 
        /// <param name="instanceId">instanceId</param> 
        /// <returns>ApiResultListProjectVersionIssueDetails</returns>            
        public ApiResultListProjectVersionIssueDetails ListIssueDetail (string projectName, string projectVersionName, string instanceId)
        {
            
            // verify the required parameter 'projectName' is set
            if (projectName == null) throw new ApiException(400, "Missing required parameter 'projectName' when calling ListIssueDetail");
            
            // verify the required parameter 'projectVersionName' is set
            if (projectVersionName == null) throw new ApiException(400, "Missing required parameter 'projectVersionName' when calling ListIssueDetail");
            
            // verify the required parameter 'instanceId' is set
            if (instanceId == null) throw new ApiException(400, "Missing required parameter 'instanceId' when calling ListIssueDetail");
            
    
            var path = "/issueDetails";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (projectName != null) queryParams.Add("projectName", ApiClient.ParameterToString(projectName)); // query parameter
 if (projectVersionName != null) queryParams.Add("projectVersionName", ApiClient.ParameterToString(projectVersionName)); // query parameter
 if (instanceId != null) queryParams.Add("instanceId", ApiClient.ParameterToString(instanceId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueDetail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueDetail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListProjectVersionIssueDetails) ApiClient.Deserialize(response.Content, typeof(ApiResultListProjectVersionIssueDetails), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="filterset">Filter set to use</param> 
        /// <returns>ApiResultProjectVersionIssueDetails</returns>            
        public ApiResultProjectVersionIssueDetails ReadIssueDetail (long? id, string filterset)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadIssueDetail");
            
    
            var path = "/issueDetails/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (filterset != null) queryParams.Add("filterset", ApiClient.ParameterToString(filterset)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadIssueDetail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadIssueDetail: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersionIssueDetails) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersionIssueDetails), response.Headers);
        }
    
    }
}
