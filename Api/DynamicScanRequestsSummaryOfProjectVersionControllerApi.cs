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
    public interface IDynamicScanRequestsSummaryOfProjectVersionControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <returns>ApiResultDynamicScanRequestsSummary</returns>
        ApiResultDynamicScanRequestsSummary GetDynamicScanRequestsSummaryOfProjectVersion (long? parentId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DynamicScanRequestsSummaryOfProjectVersionControllerApi : IDynamicScanRequestsSummaryOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicScanRequestsSummaryOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DynamicScanRequestsSummaryOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicScanRequestsSummaryOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DynamicScanRequestsSummaryOfProjectVersionControllerApi(String basePath)
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
        /// <returns>ApiResultDynamicScanRequestsSummary</returns>            
        public ApiResultDynamicScanRequestsSummary GetDynamicScanRequestsSummaryOfProjectVersion (long? parentId)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling GetDynamicScanRequestsSummaryOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/dynamicScanRequestsSummary";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetDynamicScanRequestsSummaryOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDynamicScanRequestsSummaryOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultDynamicScanRequestsSummary) ApiClient.Deserialize(response.Content, typeof(ApiResultDynamicScanRequestsSummary), response.Headers);
        }
    
    }
}
