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
    public interface IArtifactOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="embed">Fields to embed</param>
        /// <returns>ApiResultListArtifact</returns>
        ApiResultListArtifact ListArtifactOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q, string embed);
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="file">file</param>
        /// <param name="engineType">engineType</param>
        /// <returns>ApiResultArtifact</returns>
        ApiResultArtifact UploadArtifactOfProjectVersion (long? parentId, System.IO.Stream file, string engineType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ArtifactOfProjectVersionControllerApi : IArtifactOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ArtifactOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ArtifactOfProjectVersionControllerApi(String basePath)
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
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">A search query</param> 
        /// <param name="embed">Fields to embed</param> 
        /// <returns>ApiResultListArtifact</returns>            
        public ApiResultListArtifact ListArtifactOfProjectVersion (long? parentId, string fields, int? start, int? limit, string q, string embed)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListArtifactOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/artifacts";
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
 if (embed != null) queryParams.Add("embed", ApiClient.ParameterToString(embed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListArtifactOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListArtifactOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListArtifact) ApiClient.Deserialize(response.Content, typeof(ApiResultListArtifact), response.Headers);
        }
    
        /// <summary>
        /// upload 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="file">file</param> 
        /// <param name="engineType">engineType</param> 
        /// <returns>ApiResultArtifact</returns>            
        public ApiResultArtifact UploadArtifactOfProjectVersion (long? parentId, System.IO.Stream file, string engineType)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UploadArtifactOfProjectVersion");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling UploadArtifactOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/artifacts";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (engineType != null) queryParams.Add("engineType", ApiClient.ParameterToString(engineType)); // query parameter
                        if (file != null) fileParams.Add("file", ApiClient.ParameterToFile("file", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadArtifactOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadArtifactOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultArtifact) ApiClient.Deserialize(response.Content, typeof(ApiResultArtifact), response.Headers);
        }
    
    }
}
