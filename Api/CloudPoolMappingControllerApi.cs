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
    public interface ICloudPoolMappingControllerApi
    {
        /// <summary>
        /// mapByVersionId 
        /// </summary>
        /// <param name="projectVersionId">projectVersionId</param>
        /// <returns>ApiResultCloudPoolMapping</returns>
        ApiResultCloudPoolMapping MapByVersionIdCloudPoolMapping (long? projectVersionId);
        /// <summary>
        /// mapByVersionIds 
        /// </summary>
        /// <param name="projectVersionIds">projectVersionIds</param>
        /// <returns>ApiResultListCloudPoolMapping</returns>
        ApiResultListCloudPoolMapping MapByVersionIdsCloudPoolMapping (List<long?> projectVersionIds);
        /// <summary>
        /// mapByVersionName 
        /// </summary>
        /// <param name="projectName">projectName</param>
        /// <param name="projectVersionName">projectVersionName</param>
        /// <returns>ApiResultCloudPoolMapping</returns>
        ApiResultCloudPoolMapping MapByVersionNameCloudPoolMapping (string projectName, string projectVersionName);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CloudPoolMappingControllerApi : ICloudPoolMappingControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPoolMappingControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CloudPoolMappingControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPoolMappingControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CloudPoolMappingControllerApi(String basePath)
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
        /// mapByVersionId 
        /// </summary>
        /// <param name="projectVersionId">projectVersionId</param> 
        /// <returns>ApiResultCloudPoolMapping</returns>            
        public ApiResultCloudPoolMapping MapByVersionIdCloudPoolMapping (long? projectVersionId)
        {
            
            // verify the required parameter 'projectVersionId' is set
            if (projectVersionId == null) throw new ApiException(400, "Missing required parameter 'projectVersionId' when calling MapByVersionIdCloudPoolMapping");
            
    
            var path = "/cloudmappings/mapByVersionId";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (projectVersionId != null) queryParams.Add("projectVersionId", ApiClient.ParameterToString(projectVersionId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MapByVersionIdCloudPoolMapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MapByVersionIdCloudPoolMapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPoolMapping) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPoolMapping), response.Headers);
        }
    
        /// <summary>
        /// mapByVersionIds 
        /// </summary>
        /// <param name="projectVersionIds">projectVersionIds</param> 
        /// <returns>ApiResultListCloudPoolMapping</returns>            
        public ApiResultListCloudPoolMapping MapByVersionIdsCloudPoolMapping (List<long?> projectVersionIds)
        {
            
            // verify the required parameter 'projectVersionIds' is set
            if (projectVersionIds == null) throw new ApiException(400, "Missing required parameter 'projectVersionIds' when calling MapByVersionIdsCloudPoolMapping");
            
    
            var path = "/cloudmappings/mapByVersionIds";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(projectVersionIds); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MapByVersionIdsCloudPoolMapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MapByVersionIdsCloudPoolMapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListCloudPoolMapping) ApiClient.Deserialize(response.Content, typeof(ApiResultListCloudPoolMapping), response.Headers);
        }
    
        /// <summary>
        /// mapByVersionName 
        /// </summary>
        /// <param name="projectName">projectName</param> 
        /// <param name="projectVersionName">projectVersionName</param> 
        /// <returns>ApiResultCloudPoolMapping</returns>            
        public ApiResultCloudPoolMapping MapByVersionNameCloudPoolMapping (string projectName, string projectVersionName)
        {
            
            // verify the required parameter 'projectName' is set
            if (projectName == null) throw new ApiException(400, "Missing required parameter 'projectName' when calling MapByVersionNameCloudPoolMapping");
            
            // verify the required parameter 'projectVersionName' is set
            if (projectVersionName == null) throw new ApiException(400, "Missing required parameter 'projectVersionName' when calling MapByVersionNameCloudPoolMapping");
            
    
            var path = "/cloudmappings/mapByVersionName";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (projectName != null) queryParams.Add("projectName", ApiClient.ParameterToString(projectName)); // query parameter
 if (projectVersionName != null) queryParams.Add("projectVersionName", ApiClient.ParameterToString(projectVersionName)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MapByVersionNameCloudPoolMapping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MapByVersionNameCloudPoolMapping: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPoolMapping) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPoolMapping), response.Headers);
        }
    
    }
}
