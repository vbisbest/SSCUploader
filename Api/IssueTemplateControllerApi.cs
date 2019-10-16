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
    public interface IIssueTemplateControllerApi
    {
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteIssueTemplate (string id);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListIssueTemplate</returns>
        ApiResultListIssueTemplate ListIssueTemplate (string fields, int? start, int? limit, string q, string orderby);
        /// <summary>
        /// multiDelete 
        /// </summary>
        /// <param name="ids">A comma-separated list of resource identifiers</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid MultiDeleteIssueTemplate (string ids);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultIssueTemplate</returns>
        ApiResultIssueTemplate ReadIssueTemplate (string id, string fields);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultIssueTemplate</returns>
        ApiResultIssueTemplate UpdateIssueTemplate (string id, IssueTemplate resource);
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="file">file</param>
        /// <param name="name">name</param>
        /// <param name="description">description</param>
        /// <param name="confirmIgnoreCustomTagUpdates">confirmIgnoreCustomTagUpdates</param>
        /// <returns>ApiResultIssueTemplate</returns>
        ApiResultIssueTemplate UploadIssueTemplate (System.IO.Stream file, string name, string description, bool? confirmIgnoreCustomTagUpdates);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueTemplateControllerApi : IIssueTemplateControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTemplateControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueTemplateControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueTemplateControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueTemplateControllerApi(String basePath)
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
        public ApiResultVoid DeleteIssueTemplate (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteIssueTemplate");
            
    
            var path = "/issueTemplates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIssueTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteIssueTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <returns>ApiResultListIssueTemplate</returns>            
        public ApiResultListIssueTemplate ListIssueTemplate (string fields, int? start, int? limit, string q, string orderby)
        {
            
    
            var path = "/issueTemplates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListIssueTemplate) ApiClient.Deserialize(response.Content, typeof(ApiResultListIssueTemplate), response.Headers);
        }
    
        /// <summary>
        /// multiDelete 
        /// </summary>
        /// <param name="ids">A comma-separated list of resource identifiers</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid MultiDeleteIssueTemplate (string ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling MultiDeleteIssueTemplate");
            
    
            var path = "/issueTemplates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteIssueTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MultiDeleteIssueTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultIssueTemplate</returns>            
        public ApiResultIssueTemplate ReadIssueTemplate (string id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadIssueTemplate");
            
    
            var path = "/issueTemplates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadIssueTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadIssueTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueTemplate) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueTemplate), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultIssueTemplate</returns>            
        public ApiResultIssueTemplate UpdateIssueTemplate (string id, IssueTemplate resource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateIssueTemplate");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateIssueTemplate");
            
    
            var path = "/issueTemplates/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateIssueTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateIssueTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueTemplate) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueTemplate), response.Headers);
        }
    
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="file">file</param> 
        /// <param name="name">name</param> 
        /// <param name="description">description</param> 
        /// <param name="confirmIgnoreCustomTagUpdates">confirmIgnoreCustomTagUpdates</param> 
        /// <returns>ApiResultIssueTemplate</returns>            
        public ApiResultIssueTemplate UploadIssueTemplate (System.IO.Stream file, string name, string description, bool? confirmIgnoreCustomTagUpdates)
        {
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UploadIssueTemplate");
            
    
            var path = "/issueTemplates";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (description != null) queryParams.Add("description", ApiClient.ParameterToString(description)); // query parameter
 if (confirmIgnoreCustomTagUpdates != null) queryParams.Add("confirmIgnoreCustomTagUpdates", ApiClient.ParameterToString(confirmIgnoreCustomTagUpdates)); // query parameter
                        if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadIssueTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadIssueTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueTemplate) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueTemplate), response.Headers);
        }
    
    }
}
