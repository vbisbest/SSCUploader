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
    public interface IAuthTokenControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="authToken">authToken</param>
        /// <returns>ApiResultAuthenticationToken</returns>
        ApiResultAuthenticationToken CreateAuthToken (AuthenticationToken authToken);
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteAuthToken (long? id);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListAuthenticationToken</returns>
        ApiResultListAuthenticationToken ListAuthToken (string fields, int? start, int? limit, string q, string orderby);
        /// <summary>
        /// Revoke authentication tokens using ONE of two choices: (1) all tokens owned by the requesting user, OR (2) list of token ids. 
        /// </summary>
        /// <param name="all">Specify value &#39;true&#39; to revoke all authentication tokens of current logged-in user. This parameter can only be used if the &#39;ids&#39; parameter is not being used.</param>
        /// <param name="ids">A comma-separated list of resource identifiers</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid MultiDeleteAuthToken (bool? all, string ids);
        /// <summary>
        /// Revoke authentication tokens by value 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid RevokeAuthToken (AuthTokenRevokeRequest resource);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultAuthenticationToken</returns>
        ApiResultAuthenticationToken UpdateAuthToken (long? id, AuthenticationToken resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AuthTokenControllerApi : IAuthTokenControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AuthTokenControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthTokenControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthTokenControllerApi(String basePath)
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
        /// <param name="authToken">authToken</param> 
        /// <returns>ApiResultAuthenticationToken</returns>            
        public ApiResultAuthenticationToken CreateAuthToken (AuthenticationToken authToken)
        {
            
            // verify the required parameter 'authToken' is set
            if (authToken == null) throw new ApiException(400, "Missing required parameter 'authToken' when calling CreateAuthToken");
            
    
            var path = "/tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(authToken); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Basic" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultAuthenticationToken) ApiClient.Deserialize(response.Content, typeof(ApiResultAuthenticationToken), response.Headers);
        }
    
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DeleteAuthToken (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAuthToken");
            
    
            var path = "/tokens/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Basic" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <returns>ApiResultListAuthenticationToken</returns>            
        public ApiResultListAuthenticationToken ListAuthToken (string fields, int? start, int? limit, string q, string orderby)
        {
            
    
            var path = "/tokens";
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
            String[] authSettings = new String[] { "Basic" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListAuthenticationToken) ApiClient.Deserialize(response.Content, typeof(ApiResultListAuthenticationToken), response.Headers);
        }
    
        /// <summary>
        /// Revoke authentication tokens using ONE of two choices: (1) all tokens owned by the requesting user, OR (2) list of token ids. 
        /// </summary>
        /// <param name="all">Specify value &#39;true&#39; to revoke all authentication tokens of current logged-in user. This parameter can only be used if the &#39;ids&#39; parameter is not being used.</param> 
        /// <param name="ids">A comma-separated list of resource identifiers</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid MultiDeleteAuthToken (bool? all, string ids)
        {
            
    
            var path = "/tokens";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (all != null) queryParams.Add("all", ApiClient.ParameterToString(all)); // query parameter
 if (ids != null) queryParams.Add("ids", ApiClient.ParameterToString(ids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Basic" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// Revoke authentication tokens by value 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid RevokeAuthToken (AuthTokenRevokeRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling RevokeAuthToken");
            
    
            var path = "/tokens/action/revoke";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Basic" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RevokeAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RevokeAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultAuthenticationToken</returns>            
        public ApiResultAuthenticationToken UpdateAuthToken (long? id, AuthenticationToken resource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateAuthToken");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateAuthToken");
            
    
            var path = "/tokens/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "Basic" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAuthToken: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateAuthToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultAuthenticationToken) ApiClient.Deserialize(response.Content, typeof(ApiResultAuthenticationToken), response.Headers);
        }
    
    }
}
