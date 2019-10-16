using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;
using SSCAtribute = IO.Swagger.Model.Attribute;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAttributeOfProjectVersionControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultAttribute</returns>
        ApiResultAttribute CreateAttributeOfProjectVersion (long? parentId, SSCAtribute resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultListAttribute</returns>
        ApiResultListAttribute ListAttributeOfProjectVersion (long? parentId, string fields);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultAttribute</returns>
        ApiResultAttribute ReadAttributeOfProjectVersion (long? parentId, long? id, string fields);
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="data">data</param>
        /// <returns>ApiResultListAttribute</returns>
        ApiResultListAttribute UpdateCollectionAttributeOfProjectVersion (long? parentId, List<SSCAtribute> data);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttributeOfProjectVersionControllerApi : IAttributeOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttributeOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttributeOfProjectVersionControllerApi(String basePath)
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
        /// <returns>ApiResultAttribute</returns>            
        public ApiResultAttribute CreateAttributeOfProjectVersion (long? parentId, SSCAtribute resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling CreateAttributeOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateAttributeOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/attributes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAttributeOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAttributeOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultAttribute) ApiClient.Deserialize(response.Content, typeof(ApiResultAttribute), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultListAttribute</returns>            
        public ApiResultListAttribute ListAttributeOfProjectVersion (long? parentId, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListAttributeOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/attributes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAttributeOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAttributeOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListAttribute) ApiClient.Deserialize(response.Content, typeof(ApiResultListAttribute), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultAttribute</returns>            
        public ApiResultAttribute ReadAttributeOfProjectVersion (long? parentId, long? id, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ReadAttributeOfProjectVersion");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadAttributeOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/attributes/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAttributeOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAttributeOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultAttribute) ApiClient.Deserialize(response.Content, typeof(ApiResultAttribute), response.Headers);
        }
    
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="data">data</param> 
        /// <returns>ApiResultListAttribute</returns>            
        public ApiResultListAttribute UpdateCollectionAttributeOfProjectVersion (long? parentId, List<SSCAtribute> data)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateCollectionAttributeOfProjectVersion");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling UpdateCollectionAttributeOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/attributes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionAttributeOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionAttributeOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListAttribute) ApiClient.Deserialize(response.Content, typeof(ApiResultListAttribute), response.Headers);
        }
    
    }
}
