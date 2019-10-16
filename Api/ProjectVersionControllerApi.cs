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
    public interface IProjectVersionControllerApi
    {
        /// <summary>
        /// Send issue data to Audit Assistant for assessment 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid AuditByAuditAssistantProjectVersion (ProjectVersionAuditByAssistantRequest resource);
        /// <summary>
        /// Copy current audit state from one project version into another 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid CopyCurrentStateForProjectVersion (ProjectVersionCopyCurrentStateRequest resource);
        /// <summary>
        /// Copy selected data from one project version into another 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid CopyProjectVersion (ProjectVersionCopyPartialRequest resource);
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultProjectVersion</returns>
        ApiResultProjectVersion CreateProjectVersion (ProjectVersion resource);
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid DeleteProjectVersion (long? id);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search-spec of full text search query (see fulltextsearch parameter)</param>
        /// <param name="fulltextsearch">If &#39;true&#39;, interpret &#39;q&#39; parameter as full text search query, defaults to &#39;false&#39;</param>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="includeInactive">includeInactive</param>
        /// <param name="myAssignedIssues">myAssignedIssues</param>
        /// <param name="onlyIfHasIssues">onlyIfHasIssues</param>
        /// <returns>ApiResultListProjectVersion</returns>
        ApiResultListProjectVersion ListProjectVersion (string fields, int? start, int? limit, string q, bool? fulltextsearch, string orderby, bool? includeInactive, bool? myAssignedIssues, bool? onlyIfHasIssues);
        /// <summary>
        /// Purge the specified project version from the system and remove all its data 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid PurgeProjectVersion (ProjectVersionPurgeRequest resource);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultProjectVersion</returns>
        ApiResultProjectVersion ReadProjectVersion (long? id, string fields);
        /// <summary>
        /// Re-calculate the metrics for the project version 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultProjectVersionRefreshResponse</returns>
        ApiResultProjectVersionRefreshResponse RefreshProjectVersion (ProjectVersionRefreshRequest resource);
        /// <summary>
        /// Check whether the specified application version is already defined in the system 
        /// </summary>
        /// <param name="projectVersionTestRequest">projectVersionTestRequest</param>
        /// <returns>ApiResultProjectVersionTestResponse</returns>
        ApiResultProjectVersionTestResponse TestProjectVersion (ProjectVersionTestRequest projectVersionTestRequest);
        /// <summary>
        /// Send audited issue data to Audit Assistant to help train the engine 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid TrainAuditAssistantProjectVersion (ProjectVersionTrainAuditAssistantRequest resource);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultProjectVersion</returns>
        ApiResultProjectVersion UpdateProjectVersion (long? id, ProjectVersion resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProjectVersionControllerApi : IProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProjectVersionControllerApi(String basePath)
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
        /// Send issue data to Audit Assistant for assessment 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid AuditByAuditAssistantProjectVersion (ProjectVersionAuditByAssistantRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling AuditByAuditAssistantProjectVersion");
            
    
            var path = "/projectVersions/action/auditByAuditAssistant";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditByAuditAssistantProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditByAuditAssistantProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// Copy current audit state from one project version into another 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid CopyCurrentStateForProjectVersion (ProjectVersionCopyCurrentStateRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CopyCurrentStateForProjectVersion");
            
    
            var path = "/projectVersions/action/copyCurrentState";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CopyCurrentStateForProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CopyCurrentStateForProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// Copy selected data from one project version into another 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid CopyProjectVersion (ProjectVersionCopyPartialRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CopyProjectVersion");
            
    
            var path = "/projectVersions/action/copyFromPartial";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CopyProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CopyProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// create 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultProjectVersion</returns>            
        public ApiResultProjectVersion CreateProjectVersion (ProjectVersion resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CreateProjectVersion");
            
    
            var path = "/projectVersions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersion), response.Headers);
        }
    
        /// <summary>
        /// delete 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid DeleteProjectVersion (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteProjectVersion");
            
    
            var path = "/projectVersions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <param name="orderby">Fields to order by</param> 
        /// <param name="includeInactive">includeInactive</param> 
        /// <param name="myAssignedIssues">myAssignedIssues</param> 
        /// <param name="onlyIfHasIssues">onlyIfHasIssues</param> 
        /// <returns>ApiResultListProjectVersion</returns>            
        public ApiResultListProjectVersion ListProjectVersion (string fields, int? start, int? limit, string q, bool? fulltextsearch, string orderby, bool? includeInactive, bool? myAssignedIssues, bool? onlyIfHasIssues)
        {
            
    
            var path = "/projectVersions";
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
             if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
             if (includeInactive != null) queryParams.Add("includeInactive", ApiClient.ParameterToString(includeInactive)); // query parameter
             if (myAssignedIssues != null) queryParams.Add("myAssignedIssues", ApiClient.ParameterToString(myAssignedIssues)); // query parameter
             if (onlyIfHasIssues != null) queryParams.Add("onlyIfHasIssues", ApiClient.ParameterToString(onlyIfHasIssues)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListProjectVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultListProjectVersion), response.Headers);
        }
    
        /// <summary>
        /// Purge the specified project version from the system and remove all its data 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid PurgeProjectVersion (ProjectVersionPurgeRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling PurgeProjectVersion");
            
    
            var path = "/projectVersions/action/purge";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PurgeProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PurgeProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultProjectVersion</returns>            
        public ApiResultProjectVersion ReadProjectVersion (long? id, string fields)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadProjectVersion");
            
    
            var path = "/projectVersions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersion), response.Headers);
        }
    
        /// <summary>
        /// Re-calculate the metrics for the project version 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultProjectVersionRefreshResponse</returns>            
        public ApiResultProjectVersionRefreshResponse RefreshProjectVersion (ProjectVersionRefreshRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling RefreshProjectVersion");
            
    
            var path = "/projectVersions/action/refresh";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersionRefreshResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersionRefreshResponse), response.Headers);
        }
    
        /// <summary>
        /// Check whether the specified application version is already defined in the system 
        /// </summary>
        /// <param name="projectVersionTestRequest">projectVersionTestRequest</param> 
        /// <returns>ApiResultProjectVersionTestResponse</returns>            
        public ApiResultProjectVersionTestResponse TestProjectVersion (ProjectVersionTestRequest projectVersionTestRequest)
        {
            
            // verify the required parameter 'projectVersionTestRequest' is set
            if (projectVersionTestRequest == null) throw new ApiException(400, "Missing required parameter 'projectVersionTestRequest' when calling TestProjectVersion");
            
    
            var path = "/projectVersions/action/test";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(projectVersionTestRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TestProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TestProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersionTestResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersionTestResponse), response.Headers);
        }
    
        /// <summary>
        /// Send audited issue data to Audit Assistant to help train the engine 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid TrainAuditAssistantProjectVersion (ProjectVersionTrainAuditAssistantRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling TrainAuditAssistantProjectVersion");
            
    
            var path = "/projectVersions/action/trainAuditAssistant";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TrainAuditAssistantProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TrainAuditAssistantProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultVoid) ApiClient.Deserialize(response.Content, typeof(ApiResultVoid), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="id">id</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultProjectVersion</returns>            
        public ApiResultProjectVersion UpdateProjectVersion (long? id, ProjectVersion resource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateProjectVersion");
            
    
            var path = "/projectVersions/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersion), response.Headers);
        }
    
    }
}
