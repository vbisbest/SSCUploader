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
    public interface IBulkControllerApi
    {
        /// <summary>
        /// post 
        /// </summary>
        /// <param name="apiBulkRequestData">apiBulkRequestData</param>
        /// <returns>ApiResultListBulkResponseItem</returns>
        ApiResultListBulkResponseItem PostBulk (BulkRequestData apiBulkRequestData);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BulkControllerApi : IBulkControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BulkControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BulkControllerApi(String basePath)
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
        /// post 
        /// </summary>
        /// <param name="apiBulkRequestData">apiBulkRequestData</param> 
        /// <returns>ApiResultListBulkResponseItem</returns>            
        public ApiResultListBulkResponseItem PostBulk (BulkRequestData apiBulkRequestData)
        {
            
            // verify the required parameter 'apiBulkRequestData' is set
            if (apiBulkRequestData == null) throw new ApiException(400, "Missing required parameter 'apiBulkRequestData' when calling PostBulk");
            
    
            var path = "/bulk";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(apiBulkRequestData); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostBulk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostBulk: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListBulkResponseItem) ApiClient.Deserialize(response.Content, typeof(ApiResultListBulkResponseItem), response.Headers);
        }
    
    }
}
