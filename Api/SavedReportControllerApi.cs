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
    public interface ISavedReportControllerApi
    {
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultSavedReport</returns>
        ApiResultSavedReport CreateSavedReport (SavedReport resource);
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteSavedReport (long? id);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search-spec of full text search query (see fulltextsearch parameter)</param>
        /// <param name="fulltextsearch">If &#39;true&#39;, interpret &#39;q&#39; parameter as full text search query, defaults to &#39;false&#39;</param>
        /// <param name="embed">Fields to embed</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListSavedReport</returns>
        ApiResultListSavedReport ListSavedReport (string fields, int? start, int? limit, string q, bool? fulltextsearch, string embed, string orderby);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <param name="embed">Fields to embed</param>
        /// <returns>ApiResultSavedReport</returns>
        ApiResultSavedReport ReadSavedReport (long? id, string fields, string embed);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SavedReportControllerApi : ISavedReportControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedReportControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SavedReportControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SavedReportControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SavedReportControllerApi(String basePath)
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
        /// <returns>ApiResultSavedReport</returns>            
        public ApiResultSavedReport CreateSavedReport (SavedReport resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateSavedReport");
            
    
            var path = "/reports";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSavedReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateSavedReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultSavedReport) ApiClient.Deserialize(response.Content, typeof(ApiResultSavedReport), response.Headers);
        }
    
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DeleteSavedReport (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSavedReport");
            
    
            var path = "/reports/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSavedReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSavedReport: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <param name="embed">Fields to embed</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <returns>ApiResultListSavedReport</returns>            
        public ApiResultListSavedReport ListSavedReport (string fields, int? start, int? limit, string q, bool? fulltextsearch, string embed, string orderby)
        {
            
    
            var path = "/reports";
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
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSavedReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSavedReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListSavedReport) ApiClient.Deserialize(response.Content, typeof(ApiResultListSavedReport), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="embed">Fields to embed</param> 
        /// <returns>ApiResultSavedReport</returns>            
        public ApiResultSavedReport ReadSavedReport (long? id, string fields, string embed)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadSavedReport");
            
    
            var path = "/reports/{id}";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadSavedReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadSavedReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultSavedReport) ApiClient.Deserialize(response.Content, typeof(ApiResultSavedReport), response.Headers);
        }
    
    }
}
