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
    public interface IAuditAssistantStatusOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultListAuditAssistantStatus</returns>
        ApiResultListAuditAssistantStatus ListAuditAssistantStatusOfProjectVersion (long? parentId, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuditAssistantStatusOfProjectVersionControllerApi : IAuditAssistantStatusOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditAssistantStatusOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuditAssistantStatusOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditAssistantStatusOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditAssistantStatusOfProjectVersionControllerApi(String basePath)
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
        /// <returns>ApiResultListAuditAssistantStatus</returns>            
        public ApiResultListAuditAssistantStatus ListAuditAssistantStatusOfProjectVersion (long? parentId, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListAuditAssistantStatusOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/auditAssistantStatus";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAuditAssistantStatusOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAuditAssistantStatusOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListAuditAssistantStatus) ApiClient.Deserialize(response.Content, typeof(ApiResultListAuditAssistantStatus), response.Headers);
        }
    
    }
}
