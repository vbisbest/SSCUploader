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
    public interface IJobPriorityChangeCategoryWarningOfJobControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="priority">priority</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultListJobPriorityChangeCategoryWarning</returns>
        ApiResultListJobPriorityChangeCategoryWarning ListJobPriorityChangeCategoryWarningOfJob (string parentId, string priority, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobPriorityChangeCategoryWarningOfJobControllerApi : IJobPriorityChangeCategoryWarningOfJobControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobPriorityChangeCategoryWarningOfJobControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public JobPriorityChangeCategoryWarningOfJobControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobPriorityChangeCategoryWarningOfJobControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobPriorityChangeCategoryWarningOfJobControllerApi(String basePath)
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
        /// <param name="priority">priority</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultListJobPriorityChangeCategoryWarning</returns>            
        public ApiResultListJobPriorityChangeCategoryWarning ListJobPriorityChangeCategoryWarningOfJob (string parentId, string priority, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListJobPriorityChangeCategoryWarningOfJob");
            
            // verify the required parameter 'priority' is set
            if (priority == null) throw new ApiException(400, "Missing required parameter 'priority' when calling ListJobPriorityChangeCategoryWarningOfJob");
            
    
            var path = "/jobs/{parentId}/warnings";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (priority != null) queryParams.Add("priority", ApiClient.ParameterToString(priority)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListJobPriorityChangeCategoryWarningOfJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListJobPriorityChangeCategoryWarningOfJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListJobPriorityChangeCategoryWarning) ApiClient.Deserialize(response.Content, typeof(ApiResultListJobPriorityChangeCategoryWarning), response.Headers);
        }
    
    }
}
