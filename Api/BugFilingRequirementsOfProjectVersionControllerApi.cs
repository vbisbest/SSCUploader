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
    public interface IBugFilingRequirementsOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultListBugFilingRequirements</returns>
        ApiResultListBugFilingRequirements ListBugFilingRequirementsOfProjectVersion (long? parentId, string fields);
        /// <summary>
        /// Authenticate to the bug tracking system and return the initial set of bug filing requirements 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultBugFilingRequirementsResponse</returns>
        ApiResultBugFilingRequirementsResponse LoginBugFilingRequirementsOfProjectVersion (long? parentId, BugFilingRequirementsRequest resource);
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="data">data</param>
        /// <param name="changedParamIdentifier">changedParamIdentifier</param>
        /// <returns>ApiResultListBugFilingRequirements</returns>
        ApiResultListBugFilingRequirements UpdateCollectionBugFilingRequirementsOfProjectVersion (long? parentId, List<BugFilingRequirements> data, string changedParamIdentifier);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BugFilingRequirementsOfProjectVersionControllerApi : IBugFilingRequirementsOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BugFilingRequirementsOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BugFilingRequirementsOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BugFilingRequirementsOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BugFilingRequirementsOfProjectVersionControllerApi(String basePath)
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
        /// <returns>ApiResultListBugFilingRequirements</returns>            
        public ApiResultListBugFilingRequirements ListBugFilingRequirementsOfProjectVersion (long? parentId, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListBugFilingRequirementsOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/bugfilingrequirements";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListBugFilingRequirementsOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBugFilingRequirementsOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListBugFilingRequirements) ApiClient.Deserialize(response.Content, typeof(ApiResultListBugFilingRequirements), response.Headers);
        }
    
        /// <summary>
        /// Authenticate to the bug tracking system and return the initial set of bug filing requirements 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultBugFilingRequirementsResponse</returns>            
        public ApiResultBugFilingRequirementsResponse LoginBugFilingRequirementsOfProjectVersion (long? parentId, BugFilingRequirementsRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling LoginBugFilingRequirementsOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling LoginBugFilingRequirementsOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/bugfilingrequirements/action/login";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LoginBugFilingRequirementsOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LoginBugFilingRequirementsOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultBugFilingRequirementsResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultBugFilingRequirementsResponse), response.Headers);
        }
    
        /// <summary>
        /// updateCollection 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="data">data</param> 
        /// <param name="changedParamIdentifier">changedParamIdentifier</param> 
        /// <returns>ApiResultListBugFilingRequirements</returns>            
        public ApiResultListBugFilingRequirements UpdateCollectionBugFilingRequirementsOfProjectVersion (long? parentId, List<BugFilingRequirements> data, string changedParamIdentifier)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateCollectionBugFilingRequirementsOfProjectVersion");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling UpdateCollectionBugFilingRequirementsOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/bugfilingrequirements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (changedParamIdentifier != null) queryParams.Add("changedParamIdentifier", ApiClient.ParameterToString(changedParamIdentifier)); // query parameter
                                    postBody = ApiClient.Serialize(data); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionBugFilingRequirementsOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCollectionBugFilingRequirementsOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListBugFilingRequirements) ApiClient.Deserialize(response.Content, typeof(ApiResultListBugFilingRequirements), response.Headers);
        }
    
    }
}
