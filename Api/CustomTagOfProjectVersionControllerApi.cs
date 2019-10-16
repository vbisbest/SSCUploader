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
    public interface ICustomTagOfProjectVersionControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultCustomTag</returns>
        ApiResultCustomTag CreateCustomTagOfProjectVersion (long? parentId, CustomTag resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="includeall">includeall</param>
        /// <returns>ApiResultListCustomTag</returns>
        ApiResultListCustomTag ListCustomTagOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q, string orderby, bool? includeall);
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="data">data</param>
        /// <returns>ApiResultListCustomTag</returns>
        ApiResultListCustomTag UpdateCollectionCustomTagOfProjectVersion (long? parentId, List<CustomTag> data);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="id">id</param>
        /// <param name="data">data</param>
        /// <returns>ApiResultCustomTag</returns>
        ApiResultCustomTag UpdateCustomTagOfProjectVersion (long? parentId, long? id, CustomTag data);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CustomTagOfProjectVersionControllerApi : ICustomTagOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CustomTagOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTagOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomTagOfProjectVersionControllerApi(String basePath)
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
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultCustomTag</returns>            
        public ApiResultCustomTag CreateCustomTagOfProjectVersion (long? parentId, CustomTag resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling CreateCustomTagOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateCustomTagOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/customTags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCustomTagOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateCustomTagOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCustomTag) ApiClient.Deserialize(response.Content, typeof(ApiResultCustomTag), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search query</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <param name="includeall">includeall</param> 
        /// <returns>ApiResultListCustomTag</returns>            
        public ApiResultListCustomTag ListCustomTagOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q, string orderby, bool? includeall)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListCustomTagOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/customTags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
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
 if (includeall != null) queryParams.Add("includeall", ApiClient.ParameterToString(includeall)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCustomTagOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListCustomTagOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListCustomTag) ApiClient.Deserialize(response.Content, typeof(ApiResultListCustomTag), response.Headers);
        }
    
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="data">data</param> 
        /// <returns>ApiResultListCustomTag</returns>            
        public ApiResultListCustomTag UpdateCollectionCustomTagOfProjectVersion (long? parentId, List<CustomTag> data)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateCollectionCustomTagOfProjectVersion");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling UpdateCollectionCustomTagOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/customTags";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(data); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionCustomTagOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionCustomTagOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListCustomTag) ApiClient.Deserialize(response.Content, typeof(ApiResultListCustomTag), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="id">id</param> 
        /// <param name="data">data</param> 
        /// <returns>ApiResultCustomTag</returns>            
        public ApiResultCustomTag UpdateCustomTagOfProjectVersion (long? parentId, long? id, CustomTag data)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateCustomTagOfProjectVersion");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCustomTagOfProjectVersion");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling UpdateCustomTagOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/customTags/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(data); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCustomTagOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCustomTagOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultCustomTag) ApiClient.Deserialize(response.Content, typeof(ApiResultCustomTag), response.Headers);
        }
    
    }
}
