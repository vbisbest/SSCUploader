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
    public interface IJobControllerApi
    {
        /// <summary>
        /// Cancel a job 
        /// </summary>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultVoid</returns>
        ApiResultVoid CancelJob (JobCancelRequest resource);
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="q">A search query</param>
        /// <param name="orderby">Fields to order by</param>
        /// <returns>ApiResultListJob</returns>
        ApiResultListJob ListJob (string fields, int? start, int? limit, string q, string orderby);
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="jobName">jobName</param>
        /// <param name="fields">Output fields</param>
        /// <returns>ApiResultJob</returns>
        ApiResultJob ReadJob (string jobName, string fields);
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="jobName">jobName</param>
        /// <param name="resource">resource</param>
        /// <returns>ApiResultJob</returns>
        ApiResultJob UpdateJob (string jobName, Job resource);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JobControllerApi : IJobControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public JobControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JobControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JobControllerApi(String basePath)
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
        /// Cancel a job 
        /// </summary>
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultVoid</returns>            
        public ApiResultVoid CancelJob (JobCancelRequest resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling CancelJob");
            
    
            var path = "/jobs/action/cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CancelJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CancelJob: " + response.ErrorMessage, response.ErrorMessage);
    
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
        /// <returns>ApiResultListJob</returns>            
        public ApiResultListJob ListJob (string fields, int? start, int? limit, string q, string orderby)
        {
            
    
            var path = "/jobs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListJob) ApiClient.Deserialize(response.Content, typeof(ApiResultListJob), response.Headers);
        }
    
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="jobName">jobName</param> 
        /// <param name="fields">Output fields</param> 
        /// <returns>ApiResultJob</returns>            
        public ApiResultJob ReadJob (string jobName, string fields)
        {
            
            // verify the required parameter 'jobName' is set
            if (jobName == null) throw new ApiException(400, "Missing required parameter 'jobName' when calling ReadJob");
            
    
            var path = "/jobs/{jobName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "jobName" + "}", ApiClient.ParameterToString(jobName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReadJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultJob) ApiClient.Deserialize(response.Content, typeof(ApiResultJob), response.Headers);
        }
    
        /// <summary>
        /// update 
        /// </summary>
        /// <param name="jobName">jobName</param> 
        /// <param name="resource">resource</param> 
        /// <returns>ApiResultJob</returns>            
        public ApiResultJob UpdateJob (string jobName, Job resource)
        {
            
            // verify the required parameter 'jobName' is set
            if (jobName == null) throw new ApiException(400, "Missing required parameter 'jobName' when calling UpdateJob");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateJob");
            
    
            var path = "/jobs/{jobName}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "jobName" + "}", ApiClient.ParameterToString(jobName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateJob: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateJob: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultJob) ApiClient.Deserialize(response.Content, typeof(ApiResultJob), response.Headers);
        }
    
    }
}
