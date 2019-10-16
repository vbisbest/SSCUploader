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
    public interface IPluginControllerApi
    {
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeletePlugin (long? id);
        /// <summary>
        /// Disable a plugin 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DisablePlugin (PluginDisableRequest resource);
        /// <summary>
        /// Enable a plugin 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid EnablePlugin (PluginEnableRequest resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListPluginMetaData</returns>
        ApiResultListPluginMetaData ListPlugin (string fields, int? start, int? limit, string q, string orderby);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultPluginMetaData</returns>
        ApiResultPluginMetaData ReadPlugin (long? id, string fields);
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="file">file</param>
        /// <returns>ApiResultPluginMetaData</returns>
        ApiResultPluginMetaData UploadPlugin (System.IO.Stream file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PluginControllerApi : IPluginControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PluginControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PluginControllerApi(String basePath)
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
        public ApiResultVoid DeletePlugin (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeletePlugin");
            
    
            var path = "/plugins/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePlugin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeletePlugin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// Disable a plugin 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DisablePlugin (PluginDisableRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling DisablePlugin");
            
    
            var path = "/plugins/action/disable";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DisablePlugin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DisablePlugin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// Enable a plugin 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid EnablePlugin (PluginEnableRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling EnablePlugin");
            
    
            var path = "/plugins/action/enable";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EnablePlugin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnablePlugin: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <returns>ApiResultListPluginMetaData</returns>            
        public ApiResultListPluginMetaData ListPlugin (string fields, int? start, int? limit, string q, string orderby)
        {
            
    
            var path = "/plugins";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListPlugin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPlugin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListPluginMetaData) ApiClient.Deserialize(response.Content, typeof(ApiResultListPluginMetaData), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultPluginMetaData</returns>            
        public ApiResultPluginMetaData ReadPlugin (long? id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadPlugin");
            
    
            var path = "/plugins/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPlugin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPlugin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultPluginMetaData) ApiClient.Deserialize(response.Content, typeof(ApiResultPluginMetaData), response.Headers);
        }
    
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="file">file</param> 
        /// <returns>ApiResultPluginMetaData</returns>            
        public ApiResultPluginMetaData UploadPlugin (System.IO.Stream file)
        {
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UploadPlugin");
            
    
            var path = "/plugins";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UploadPlugin: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadPlugin: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultPluginMetaData) ApiClient.Deserialize(response.Content, typeof(ApiResultPluginMetaData), response.Headers);
        }
    
    }
}
