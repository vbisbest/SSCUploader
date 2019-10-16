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
    public interface IRulepackUpdateControllerApi
    {
        /// <summary>
        /// DoImport 
        /// </summary>
        /// <returns>ApiResultListRulepacksBatchProcessStatus</returns>
        ApiResultListRulepacksBatchProcessStatus DoRulepackUpdate ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RulepackUpdateControllerApi : IRulepackUpdateControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulepackUpdateControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RulepackUpdateControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RulepackUpdateControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RulepackUpdateControllerApi(String basePath)
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
        /// DoImport 
        /// </summary>
        /// <returns>ApiResultListRulepacksBatchProcessStatus</returns>            
        public ApiResultListRulepacksBatchProcessStatus DoRulepackUpdate ()
        {
            
    
            var path = "/updateRulepacks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DoRulepackUpdate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DoRulepackUpdate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListRulepacksBatchProcessStatus) ApiClient.Deserialize(response.Content, typeof(ApiResultListRulepacksBatchProcessStatus), response.Headers);
        }
    
    }
}
