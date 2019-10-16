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
    public interface IRulepackCoreControllerApi
    {
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteRulepackCore (long? id);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListRulepackCore</returns>
        ApiResultListRulepackCore ListRulepackCore (string fields, int? start, int? limit, string q, string orderby);
        /// <summary>
        /// multiDelete 
        /// </summary>
        /// <param name="ids">A comma-separated list of resource identifiers</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid MultiDeleteRulepackCore (string ids);
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="file">file</param>
        /// <returns>ApiResultListRulepackStatus</returns>
        ApiResultListRulepackStatus UploadRulepackCore (System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RulepackCoreControllerApi : IRulepackCoreControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RulepackCoreControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RulepackCoreControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RulepackCoreControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RulepackCoreControllerApi(String basePath)
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
        /// delete 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DeleteRulepackCore (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteRulepackCore");
            
    
            var path = "/coreRulepacks/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRulepackCore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteRulepackCore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search query</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <returns>ApiResultListRulepackCore</returns>            
        public ApiResultListRulepackCore ListRulepackCore (string fields, int? start, int? limit, string q, string orderby)
        {
            
    
            var path = "/coreRulepacks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListRulepackCore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListRulepackCore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListRulepackCore) ApiClient.Deserialize(response.Content, typeof(ApiResultListRulepackCore), response.Headers);
        }
    
        /// <summary>
        /// multiDelete 
        /// </summary>
        /// <param name="ids">A comma-separated list of resource identifiers</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid MultiDeleteRulepackCore (string ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MultiDeleteRulepackCore");
            
    
            var path = "/coreRulepacks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteRulepackCore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteRulepackCore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="file">file</param> 
        /// <returns>ApiResultListRulepackStatus</returns>            
        public ApiResultListRulepackStatus UploadRulepackCore (System.IO.Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UploadRulepackCore");
            
    
            var path = "/coreRulepacks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadRulepackCore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadRulepackCore: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListRulepackStatus) ApiClient.Deserialize(response.Content, typeof(ApiResultListRulepackStatus), response.Headers);
        }
    
    }
}
