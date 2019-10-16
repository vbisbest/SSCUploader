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
    public interface IConfigurationControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <param name="group">group</param>
        /// <returns>ApiResultConfigProperties</returns>
        ApiResultConfigProperties GetConfiguration (string group);
        /// <summary>
        /// getFullTextIndexStatus 
        /// </summary>
        /// <returns>ApiResultSearchIndexStatus</returns>
        ApiResultSearchIndexStatus GetFullTextIndexStatusConfiguration ();
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>ApiResultConfigProperty</returns>
        ApiResultConfigProperty ReadConfiguration (string id);
        /// <summary>
        /// Refreshes prediction policies between Audit Assistant server and SSC 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultRefreshAuditAssistantPoliciesRequest</returns>
        ApiResultRefreshAuditAssistantPoliciesRequest RefreshAuditAssistantPoliciesConfiguration (RefreshAuditAssistantPoliciesRequest resource);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultConfigProperties</returns>
        ApiResultConfigProperties UpdateConfiguration (ConfigProperties resource);
        /// <summary>
        /// validateAuditAssistantConnection 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultConfigProperties</returns>
        ApiResultConfigProperties ValidateAuditAssistantConnectionConfiguration (ConfigProperties resource);
        /// <summary>
        /// validateReportConnection 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultConfigProperties</returns>
        ApiResultConfigProperties ValidateReportConnectionConfiguration (ConfigProperties resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ConfigurationControllerApi : IConfigurationControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ConfigurationControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigurationControllerApi(String basePath)
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
        /// get 
        /// </summary>
        /// <param name="group">group</param> 
        /// <returns>ApiResultConfigProperties</returns>            
        public ApiResultConfigProperties GetConfiguration (string group)
        {
            
    
            var path = "/configuration";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultConfigProperties) ApiClient.Deserialize(response.Content, typeof(ApiResultConfigProperties), response.Headers);
        }
    
        /// <summary>
        /// getFullTextIndexStatus 
        /// </summary>
        /// <returns>ApiResultSearchIndexStatus</returns>            
        public ApiResultSearchIndexStatus GetFullTextIndexStatusConfiguration ()
        {
            
    
            var path = "/configuration/searchIndex";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFullTextIndexStatusConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFullTextIndexStatusConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultSearchIndexStatus) ApiClient.Deserialize(response.Content, typeof(ApiResultSearchIndexStatus), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="id">id</param> 
        /// <returns>ApiResultConfigProperty</returns>            
        public ApiResultConfigProperty ReadConfiguration (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReadConfiguration");
            
    
            var path = "/configuration/{id}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultConfigProperty) ApiClient.Deserialize(response.Content, typeof(ApiResultConfigProperty), response.Headers);
        }
    
        /// <summary>
        /// Refreshes prediction policies between Audit Assistant server and SSC 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultRefreshAuditAssistantPoliciesRequest</returns>            
        public ApiResultRefreshAuditAssistantPoliciesRequest RefreshAuditAssistantPoliciesConfiguration (RefreshAuditAssistantPoliciesRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling RefreshAuditAssistantPoliciesConfiguration");
            
    
            var path = "/configuration/action/refreshAuditAssistantPolicies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshAuditAssistantPoliciesConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshAuditAssistantPoliciesConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultRefreshAuditAssistantPoliciesRequest) ApiClient.Deserialize(response.Content, typeof(ApiResultRefreshAuditAssistantPoliciesRequest), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultConfigProperties</returns>            
        public ApiResultConfigProperties UpdateConfiguration (ConfigProperties resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateConfiguration");
            
    
            var path = "/configuration";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultConfigProperties) ApiClient.Deserialize(response.Content, typeof(ApiResultConfigProperties), response.Headers);
        }
    
        /// <summary>
        /// validateAuditAssistantConnection 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultConfigProperties</returns>            
        public ApiResultConfigProperties ValidateAuditAssistantConnectionConfiguration (ConfigProperties resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling ValidateAuditAssistantConnectionConfiguration");
            
    
            var path = "/configuration/validateAuditAssistantConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateAuditAssistantConnectionConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateAuditAssistantConnectionConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultConfigProperties) ApiClient.Deserialize(response.Content, typeof(ApiResultConfigProperties), response.Headers);
        }
    
        /// <summary>
        /// validateReportConnection 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultConfigProperties</returns>            
        public ApiResultConfigProperties ValidateReportConnectionConfiguration (ConfigProperties resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling ValidateReportConnectionConfiguration");
            
    
            var path = "/configuration/validateReportConnection";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateReportConnectionConfiguration: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateReportConnectionConfiguration: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultConfigProperties) ApiClient.Deserialize(response.Content, typeof(ApiResultConfigProperties), response.Headers);
        }
    
    }
}
