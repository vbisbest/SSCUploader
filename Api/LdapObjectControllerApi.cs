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
    public interface ILdapObjectControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultLDAPEntity</returns>
        ApiResultLDAPEntity CreateLdapObject (LDAPEntity resource);
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteLdapObject (long? id);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="ldaptype">ldaptype</param>
        /// <param name="viewby">viewby</param>
        /// <returns>ApiResultListLDAPEntity</returns>
        ApiResultListLDAPEntity ListLdapObject (string fields, int? start, int? limit, string q, string orderby, string ldaptype, string viewby);
        /// <summary>
        /// multiDelete 
        /// </summary>
        /// <param name="ids">A comma-separated list of resource identifiers</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid MultiDeleteLdapObject (string ids);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultLDAPEntity</returns>
        ApiResultLDAPEntity ReadLdapObject (long? id, string fields);
        /// <summary>
        /// Refresh the ldap cache 
        /// </summary>
        /// <returns>ApiResultLdapRefreshResponse</returns>
        ApiResultLdapRefreshResponse RefreshLdapObject ();
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultLDAPEntity</returns>
        ApiResultLDAPEntity UpdateLdapObject (long? id, LDAPEntity resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LdapObjectControllerApi : ILdapObjectControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LdapObjectControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LdapObjectControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LdapObjectControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LdapObjectControllerApi(String basePath)
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
        /// <returns>ApiResultLDAPEntity</returns>            
        public ApiResultLDAPEntity CreateLdapObject (LDAPEntity resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateLdapObject");
            
    
            var path = "/ldapObjects";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultLDAPEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultLDAPEntity), response.Headers);
        }
    
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DeleteLdapObject (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteLdapObject");
            
    
            var path = "/ldapObjects/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <param name="ldaptype">ldaptype</param> 
        /// <param name="viewby">viewby</param> 
        /// <returns>ApiResultListLDAPEntity</returns>            
        public ApiResultListLDAPEntity ListLdapObject (string fields, int? start, int? limit, string q, string orderby, string ldaptype, string viewby)
        {
            
    
            var path = "/ldapObjects";
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
 if (ldaptype != null) queryParams.Add("ldaptype", ApiClient.ParameterToString(ldaptype)); // query parameter
 if (viewby != null) queryParams.Add("viewby", ApiClient.ParameterToString(viewby)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListLDAPEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultListLDAPEntity), response.Headers);
        }
    
        /// <summary>
        /// multiDelete 
        /// </summary>
        /// <param name="ids">A comma-separated list of resource identifiers</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid MultiDeleteLdapObject (string ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MultiDeleteLdapObject");
            
    
            var path = "/ldapObjects";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultLDAPEntity</returns>            
        public ApiResultLDAPEntity ReadLdapObject (long? id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadLdapObject");
            
    
            var path = "/ldapObjects/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultLDAPEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultLDAPEntity), response.Headers);
        }
    
        /// <summary>
        /// Refresh the ldap cache 
        /// </summary>
        /// <returns>ApiResultLdapRefreshResponse</returns>            
        public ApiResultLdapRefreshResponse RefreshLdapObject ()
        {
            
    
            var path = "/ldapObjects/action/refresh";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultLdapRefreshResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultLdapRefreshResponse), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultLDAPEntity</returns>            
        public ApiResultLDAPEntity UpdateLdapObject (long? id, LDAPEntity resource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateLdapObject");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateLdapObject");
            
    
            var path = "/ldapObjects/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLdapObject: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateLdapObject: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultLDAPEntity) ApiClient.Deserialize(response.Content, typeof(ApiResultLDAPEntity), response.Headers);
        }
    
    }
}
