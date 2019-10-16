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
    public interface IIssueOfProjectVersionControllerApi
    {
        /// <summary>
        /// Assign issue to user 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultIssueActionResponse</returns>
        ApiResultIssueActionResponse AssignUserForIssueOfProjectVersion (long? parentId, IssueAssignUserRequest resource);
        /// <summary>
        /// Perform an auditing action on the specified issues 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultIssueActionResponse</returns>
        ApiResultIssueActionResponse AuditIssueOfProjectVersion (long? parentId, IssueAuditRequest resource);
        /// <summary>
        /// Submit a bug (defect) for the specified issues in the external bug tracking system (if configured) 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultIssueFileBugResponse</returns>
        ApiResultIssueFileBugResponse FileBugForIssueOfProjectVersion (long? parentId, IssueFileBugRequest resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">An issue query expression, must be used together with the &#39;qm&#39; parameter</param>
        /// <param name="qm">Syntax mode for the &#39;q&#39; parameter, mandatory if the &#39;q&#39; parameter is used</param>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="filterset">Filter set to use</param>
        /// <param name="fields">Output fields</param>
        /// <param name="showhidden">If &#39;true&#39;, include hidden issues in search results. If &#39;false&#39;, exclude hidden issues from search results. If no options are set, use application version profile settings to get value of this option.</param>
        /// <param name="showremoved">If &#39;true&#39;, include removed issues in search results. If &#39;false&#39;, exclude removed issues from search results. If no options are set, use application version profile settings to get value of this option.</param>
        /// <param name="showsuppressed">If &#39;true&#39;, include suppressed issues in search results. If &#39;false&#39;, exclude suppressed issues from search results. If no options are set, use application version profile settings to get value of this option.</param>
        /// <param name="showshortfilenames">If &#39;true&#39;, only short file names will be displayed in issues list.</param>
        /// <param name="filter">filter</param>
        /// <param name="groupid">groupid</param>
        /// <param name="groupingtype">groupingtype</param>
        /// <returns>ApiResultListProjectVersionIssue</returns>
        ApiResultListProjectVersionIssue ListIssueOfProjectVersion (long? parentId, int? start, int? limit, string q, string qm, string orderby, string filterset, string fields, bool? showhidden, bool? showremoved, bool? showsuppressed, bool? showshortfilenames, string filter, string groupid, string groupingtype);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="id">id</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultProjectVersionIssue</returns>
        ApiResultProjectVersionIssue ReadIssueOfProjectVersion (long? parentId, long? id, string fields);
        /// <summary>
        /// Suppress or unsuppress an issue 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultIssueActionResponse</returns>
        ApiResultIssueActionResponse SuppressIssueOfProjectVersion (long? parentId, IssueSuppressRequest resource);
        /// <summary>
        /// Update the custom tag for the specified issues 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultIssueActionResponse</returns>
        ApiResultIssueActionResponse UpdateTagForIssueOfProjectVersion (long? parentId, IssueUpdateTagRequest resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueOfProjectVersionControllerApi : IIssueOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueOfProjectVersionControllerApi(String basePath)
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
        /// Assign issue to user 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultIssueActionResponse</returns>            
        public ApiResultIssueActionResponse AssignUserForIssueOfProjectVersion (long? parentId, IssueAssignUserRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling AssignUserForIssueOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling AssignUserForIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues/action/assignUser";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AssignUserForIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AssignUserForIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueActionResponse), response.Headers);
        }
    
        /// <summary>
        /// Perform an auditing action on the specified issues 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultIssueActionResponse</returns>            
        public ApiResultIssueActionResponse AuditIssueOfProjectVersion (long? parentId, IssueAuditRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling AuditIssueOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling AuditIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues/action/audit";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AuditIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AuditIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueActionResponse), response.Headers);
        }
    
        /// <summary>
        /// Submit a bug (defect) for the specified issues in the external bug tracking system (if configured) 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultIssueFileBugResponse</returns>            
        public ApiResultIssueFileBugResponse FileBugForIssueOfProjectVersion (long? parentId, IssueFileBugRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling FileBugForIssueOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling FileBugForIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues/action/fileBug";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FileBugForIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FileBugForIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueFileBugResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueFileBugResponse), response.Headers);
        }
    
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="q">An issue query expression, must be used together with the &#39;qm&#39; parameter</param> 
        /// <param name="qm">Syntax mode for the &#39;q&#39; parameter, mandatory if the &#39;q&#39; parameter is used</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <param name="filterset">Filter set to use</param> 
        /// <param name="fields">Output fields</param> 
        /// <param name="showhidden">If &#39;true&#39;, include hidden issues in search results. If &#39;false&#39;, exclude hidden issues from search results. If no options are set, use application version profile settings to get value of this option.</param> 
        /// <param name="showremoved">If &#39;true&#39;, include removed issues in search results. If &#39;false&#39;, exclude removed issues from search results. If no options are set, use application version profile settings to get value of this option.</param> 
        /// <param name="showsuppressed">If &#39;true&#39;, include suppressed issues in search results. If &#39;false&#39;, exclude suppressed issues from search results. If no options are set, use application version profile settings to get value of this option.</param> 
        /// <param name="showshortfilenames">If &#39;true&#39;, only short file names will be displayed in issues list.</param> 
        /// <param name="filter">filter</param> 
        /// <param name="groupid">groupid</param> 
        /// <param name="groupingtype">groupingtype</param> 
        /// <returns>ApiResultListProjectVersionIssue</returns>            
        public ApiResultListProjectVersionIssue ListIssueOfProjectVersion (long? parentId, int? start, int? limit, string q, string qm, string orderby, string filterset, string fields, bool? showhidden, bool? showremoved, bool? showsuppressed, bool? showshortfilenames, string filter, string groupid, string groupingtype)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
 if (qm != null) queryParams.Add("qm", ApiClient.ParameterToString(qm)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (filterset != null) queryParams.Add("filterset", ApiClient.ParameterToString(filterset)); // query parameter
 if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (showhidden != null) queryParams.Add("showhidden", ApiClient.ParameterToString(showhidden)); // query parameter
 if (showremoved != null) queryParams.Add("showremoved", ApiClient.ParameterToString(showremoved)); // query parameter
 if (showsuppressed != null) queryParams.Add("showsuppressed", ApiClient.ParameterToString(showsuppressed)); // query parameter
 if (showshortfilenames != null) queryParams.Add("showshortfilenames", ApiClient.ParameterToString(showshortfilenames)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (groupid != null) queryParams.Add("groupid", ApiClient.ParameterToString(groupid)); // query parameter
 if (groupingtype != null) queryParams.Add("groupingtype", ApiClient.ParameterToString(groupingtype)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListProjectVersionIssue) ApiClient.Deserialize(response.Content, typeof(ApiResultListProjectVersionIssue), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="id">id</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultProjectVersionIssue</returns>            
        public ApiResultProjectVersionIssue ReadIssueOfProjectVersion (long? parentId, long? id, string fields)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ReadIssueOfProjectVersion");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultProjectVersionIssue) ApiClient.Deserialize(response.Content, typeof(ApiResultProjectVersionIssue), response.Headers);
        }
    
        /// <summary>
        /// Suppress or unsuppress an issue 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultIssueActionResponse</returns>            
        public ApiResultIssueActionResponse SuppressIssueOfProjectVersion (long? parentId, IssueSuppressRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling SuppressIssueOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling SuppressIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues/action/suppress";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SuppressIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SuppressIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueActionResponse), response.Headers);
        }
    
        /// <summary>
        /// Update the custom tag for the specified issues 
        /// </summary>
        /// <param name="parentId">parentId</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultIssueActionResponse</returns>            
        public ApiResultIssueActionResponse UpdateTagForIssueOfProjectVersion (long? parentId, IssueUpdateTagRequest resource)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling UpdateTagForIssueOfProjectVersion");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateTagForIssueOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issues/action/updateTag";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTagForIssueOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTagForIssueOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultIssueActionResponse) ApiClient.Deserialize(response.Content, typeof(ApiResultIssueActionResponse), response.Headers);
        }
    
    }
}
