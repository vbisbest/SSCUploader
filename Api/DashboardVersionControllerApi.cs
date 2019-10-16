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
    public interface IDashboardVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="fields">Output fields</param>
        /// <param name="orderby">Fields to order by</param>
        /// <param name="groupby">Fields to group by</param>
        /// <param name="start">A start offset in object listing</param>
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param>
        /// <param name="aggregateby">aggregateby</param>
        /// <param name="startdate">startdate</param>
        /// <param name="enddate">enddate</param>
        /// <param name="attributes">attributes</param>
        /// <param name="variables">variables</param>
        /// <param name="performanceindicators">performanceindicators</param>
        /// <param name="attributefilter">attributefilter</param>
        /// <returns>ApiResultListDashboardVersion</returns>
        ApiResultListDashboardVersion ListDashboardVersion (string fields, string orderby, string groupby, int? start, int? limit, string aggregateby, string startdate, string enddate, string attributes, string variables, string performanceindicators, string attributefilter);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DashboardVersionControllerApi : IDashboardVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DashboardVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DashboardVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DashboardVersionControllerApi(String basePath)
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
        /// <param name="fields">Output fields</param> 
        /// <param name="orderby">Fields to order by</param> 
        /// <param name="groupby">Fields to group by</param> 
        /// <param name="start">A start offset in object listing</param> 
        /// <param name="limit">A maximum number of returned objects in listing, if &#39;-1&#39; or &#39;0&#39; no limit is applied</param> 
        /// <param name="aggregateby">aggregateby</param> 
        /// <param name="startdate">startdate</param> 
        /// <param name="enddate">enddate</param> 
        /// <param name="attributes">attributes</param> 
        /// <param name="variables">variables</param> 
        /// <param name="performanceindicators">performanceindicators</param> 
        /// <param name="attributefilter">attributefilter</param> 
        /// <returns>ApiResultListDashboardVersion</returns>            
        public ApiResultListDashboardVersion ListDashboardVersion (string fields, string orderby, string groupby, int? start, int? limit, string aggregateby, string startdate, string enddate, string attributes, string variables, string performanceindicators, string attributefilter)
        {
            
    
            var path = "/dashboardVersions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (fields != null) queryParams.Add("fields", ApiClient.ParameterToString(fields)); // query parameter
 if (orderby != null) queryParams.Add("orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (groupby != null) queryParams.Add("groupby", ApiClient.ParameterToString(groupby)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (aggregateby != null) queryParams.Add("aggregateby", ApiClient.ParameterToString(aggregateby)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
 if (attributes != null) queryParams.Add("attributes", ApiClient.ParameterToString(attributes)); // query parameter
 if (variables != null) queryParams.Add("variables", ApiClient.ParameterToString(variables)); // query parameter
 if (performanceindicators != null) queryParams.Add("performanceindicators", ApiClient.ParameterToString(performanceindicators)); // query parameter
 if (attributefilter != null) queryParams.Add("attributefilter", ApiClient.ParameterToString(attributefilter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListDashboardVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListDashboardVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListDashboardVersion) ApiClient.Deserialize(response.Content, typeof(ApiResultListDashboardVersion), response.Headers);
        }
    
    }
}
