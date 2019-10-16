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
    public interface ISourceFileOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="q">The url-encoded value of a source file query expression \&quot;path:&amp;lt;path_to_file_in_quotes&amp;gt;+AND+scan_id:&amp;lt;s_id&amp;gt;\&quot;. For example, \&quot;q&#x3D;path:%22JavaSource%2Forg%2Fowasp%2Fwebgoat%2Flessons%2FCSRF.java%22%2Band%2Bscan_id:1\&quot;. If &#39;scan_id&#39; is not provided, the search defaults to the latest scan of the application version.</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultListSourceFileDto</returns>
        ApiResultListSourceFileDto ListSourceFileOfProjectVersion (long? parentId, string q, string fields);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SourceFileOfProjectVersionControllerApi : ISourceFileOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFileOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SourceFileOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceFileOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SourceFileOfProjectVersionControllerApi(String basePath)
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
        /// <param name="q">The url-encoded value of a source file query expression \&quot;path:&amp;lt;path_to_file_in_quotes&amp;gt;+AND+scan_id:&amp;lt;s_id&amp;gt;\&quot;. For example, \&quot;q&#x3D;path:%22JavaSource%2Forg%2Fowasp%2Fwebgoat%2Flessons%2FCSRF.java%22%2Band%2Bscan_id:1\&quot;. If &#39;scan_id&#39; is not provided, the search defaults to the latest scan of the application version.</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultListSourceFileDto</returns>            
        public ApiResultListSourceFileDto ListSourceFileOfProjectVersion (long? parentId, string q, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListSourceFileOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/sourceFiles";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSourceFileOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSourceFileOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListSourceFileDto) ApiClient.Deserialize(response.Content, typeof(ApiResultListSourceFileDto), response.Headers);
        }
    
    }
}
