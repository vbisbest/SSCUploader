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
    public interface IAuthEntityOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="embed">Fields to embed</param>
        /// <param name="extractusersfromgroups">extractusersfromgroups</param>
        /// <param name="includeuniversalaccessentities">includeuniversalaccessentities</param>
        /// <param name="entityname">entityname</param>
        /// <returns>ApiResultListAuthenticationEntity</returns>
        ApiResultListAuthenticationEntity ListAuthEntityOfProjectVersion (long? parentId, string fields, string embed, bool? extractusersfromgroups, bool? includeuniversalaccessentities, string entityname);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <param name="embed">Fields to embed</param>
        /// <returns>ApiResultAuthenticationEntity</returns>
        ApiResultAuthenticationEntity ReadAuthEntityOfProjectVersion (long? parentId, long? id, string fields, string embed);
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="data">data</param>
        /// <returns>ApiResultListAuthenticationEntity</returns>
        ApiResultListAuthenticationEntity UpdateCollectionAuthEntityOfProjectVersion (long? parentId, List<AuthenticationEntity> data);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthEntityOfProjectVersionControllerApi : IAuthEntityOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthEntityOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthEntityOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthEntityOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthEntityOfProjectVersionControllerApi(String basePath)
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
        /// <param name="embed">Fields to embed</param> 
        /// <param name="extractusersfromgroups">extractusersfromgroups</param> 
        /// <param name="includeuniversalaccessentities">includeuniversalaccessentities</param> 
        /// <param name="entityname">entityname</param> 
        /// <returns>ApiResultListAuthenticationEntity</returns>            
        public ApiResultListAuthenticationEntity ListAuthEntityOfProjectVersion (long? parentId, string fields, string embed, bool? extractusersfromgroups, bool? includeuniversalaccessentities, string entityname)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListAuthEntityOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/authEntities";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
 if (extractusersfromgroups != null) queryParams.Add("extractusersfromgroups", ApiClient.ParameterToString(extractusersfromgroups)); // query parameter
 if (includeuniversalaccessentities != null) queryParams.Add("includeuniversalaccessentities", ApiClient.ParameterToString(includeuniversalaccessentities)); // query parameter
 if (entityname != null) queryParams.Add("entityname", ApiClient.ParameterToString(entityname)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAuthEntityOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAuthEntityOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListAuthenticationEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultListAuthenticationEntity), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="embed">Fields to embed</param> 
        /// <returns>ApiResultAuthenticationEntity</returns>            
        public ApiResultAuthenticationEntity ReadAuthEntityOfProjectVersion (long? parentId, long? id, string fields, string embed)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ReadAuthEntityOfProjectVersion");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadAuthEntityOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/authEntities/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAuthEntityOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadAuthEntityOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultAuthenticationEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultAuthenticationEntity), response.Headers);
        }
    
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="data">data</param> 
        /// <returns>ApiResultListAuthenticationEntity</returns>            
        public ApiResultListAuthenticationEntity UpdateCollectionAuthEntityOfProjectVersion (long? parentId, List<AuthenticationEntity> data)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateCollectionAuthEntityOfProjectVersion");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling UpdateCollectionAuthEntityOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/authEntities";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionAuthEntityOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionAuthEntityOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListAuthenticationEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultListAuthenticationEntity), response.Headers);
        }
    
    }
}
