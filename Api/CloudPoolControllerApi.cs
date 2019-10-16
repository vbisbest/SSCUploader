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
    public interface ICloudPoolControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultCloudPool</returns>
        ApiResultCloudPool CreateCloudPool (CloudPool resource);
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="uuid">uuid</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteCloudPool (string uuid);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search-spec of full text search query (see fulltextsearch parameter)</param>
        /// <param name="fulltextsearch">If &#39;true&#39;, interpret &#39;q&#39; parameter as full text search query, defaults to &#39;false&#39;</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListCloudPool</returns>
        ApiResultListCloudPool ListCloudPool (string fields, int? start, int? limit, string q, bool? fulltextsearch, string orderby);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="uuid">uuid</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultCloudPool</returns>
        ApiResultCloudPool ReadCloudPool (string uuid, string fields);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="uuid">uuid</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultCloudPool</returns>
        ApiResultCloudPool UpdateCloudPool (string uuid, CloudPool resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CloudPoolControllerApi : ICloudPoolControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPoolControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CloudPoolControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPoolControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CloudPoolControllerApi(String basePath)
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
        /// create 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultCloudPool</returns>            
        public ApiResultCloudPool CreateCloudPool (CloudPool resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateCloudPool");
            
    
            var path = "/cloudpools";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPool) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPool), response.Headers);
        }
    
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="uuid">uuid</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DeleteCloudPool (string uuid)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling DeleteCloudPool");
            
    
            var path = "/cloudpools/{uuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search-spec of full text search query (see fulltextsearch parameter)</param> 
        /// <param name="fulltextsearch">If &#39;true&#39;, interpret &#39;q&#39; parameter as full text search query, defaults to &#39;false&#39;</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <returns>ApiResultListCloudPool</returns>            
        public ApiResultListCloudPool ListCloudPool (string fields, int? start, int? limit, string q, bool? fulltextsearch, string orderby)
        {
            
    
            var path = "/cloudpools";
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
 if (fulltextsearch != null) queryParams.Add("fulltextsearch", ApiClient.ParameterToString(fulltextsearch)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListCloudPool) ApiClient.Deserialize(response.Content, typeof(ApiResultListCloudPool), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="uuid">uuid</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultCloudPool</returns>            
        public ApiResultCloudPool ReadCloudPool (string uuid, string fields)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling ReadCloudPool");
            
    
            var path = "/cloudpools/{uuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPool) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPool), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="uuid">uuid</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultCloudPool</returns>            
        public ApiResultCloudPool UpdateCloudPool (string uuid, CloudPool resource)
        {
            
            // verify the required parameter 'uuid' is set
            if (uuid == null) throw new ApiException(400, "Missing required parameter 'uuid' when calling UpdateCloudPool");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateCloudPool");
            
    
            var path = "/cloudpools/{uuid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "uuid" + "}", ApiClient.ParameterToString(uuid));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCloudPool: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCloudPool: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCloudPool) ApiClient.Deserialize(response.Content, typeof(ApiResultCloudPool), response.Headers);
        }
    
    }
}
