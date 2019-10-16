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
    public interface IIssueSummaryOfProjectVersionControllerApi
    {
        /// <summary>
        /// list 
        /// </summary>
        /// <param name="parentId">parentId</param>
        /// <param name="seriestype">seriestype</param>
        /// <param name="groupaxistype">List of allowed patterns: APP_NAME, SCAN_DATE, SCAN_PRODUCT, ISSUE_FOLDER, ISSUE_CATEGORY, ISSUE_KINGDOM, ISSUE_FILENAME, ISSUE_FRIORITY, ISSUE_AUDITED, ISSUE_PACKAGE_NAME, ISSUE_CLASS_NAME, ISSUE_FUNCTION_NAME, ISSUE_MAPPED_CATEGORY, FOLDER_FOLDER, ISSUE_{name of issue attribute}, EXTERNALLIST_{external category name}, CUSTOMTAG_{custom tag name}.</param>
        /// <param name="audited">audited</param>
        /// <param name="filter">filter</param>
        /// <param name="showhidden">showhidden</param>
        /// <param name="showremoved">showremoved</param>
        /// <param name="showsuppressed">showsuppressed</param>
        /// <returns>ApiResultListIssueSummary</returns>
        ApiResultListIssueSummary ListIssueSummaryOfProjectVersion (long? parentId, string seriestype, string groupaxistype, string audited, string filter, bool? showhidden, bool? showremoved, bool? showsuppressed);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IssueSummaryOfProjectVersionControllerApi : IIssueSummaryOfProjectVersionControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueSummaryOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IssueSummaryOfProjectVersionControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueSummaryOfProjectVersionControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IssueSummaryOfProjectVersionControllerApi(String basePath)
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
        /// <param name="seriestype">seriestype</param> 
        /// <param name="groupaxistype">List of allowed patterns: APP_NAME, SCAN_DATE, SCAN_PRODUCT, ISSUE_FOLDER, ISSUE_CATEGORY, ISSUE_KINGDOM, ISSUE_FILENAME, ISSUE_FRIORITY, ISSUE_AUDITED, ISSUE_PACKAGE_NAME, ISSUE_CLASS_NAME, ISSUE_FUNCTION_NAME, ISSUE_MAPPED_CATEGORY, FOLDER_FOLDER, ISSUE_{name of issue attribute}, EXTERNALLIST_{external category name}, CUSTOMTAG_{custom tag name}.</param> 
        /// <param name="audited">audited</param> 
        /// <param name="filter">filter</param> 
        /// <param name="showhidden">showhidden</param> 
        /// <param name="showremoved">showremoved</param> 
        /// <param name="showsuppressed">showsuppressed</param> 
        /// <returns>ApiResultListIssueSummary</returns>            
        public ApiResultListIssueSummary ListIssueSummaryOfProjectVersion (long? parentId, string seriestype, string groupaxistype, string audited, string filter, bool? showhidden, bool? showremoved, bool? showsuppressed)
        {
            
            // verify the required parameter 'parentId' is set
            if (parentId == null) throw new ApiException(400, "Missing required parameter 'parentId' when calling ListIssueSummaryOfProjectVersion");
            
            // verify the required parameter 'seriestype' is set
            if (seriestype == null) throw new ApiException(400, "Missing required parameter 'seriestype' when calling ListIssueSummaryOfProjectVersion");
            
            // verify the required parameter 'groupaxistype' is set
            if (groupaxistype == null) throw new ApiException(400, "Missing required parameter 'groupaxistype' when calling ListIssueSummaryOfProjectVersion");
            
    
            var path = "/projectVersions/{parentId}/issueSummaries";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "parentId" + "}", ApiClient.ParameterToString(parentId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (seriestype != null) queryParams.Add("seriestype", ApiClient.ParameterToString(seriestype)); // query parameter
 if (groupaxistype != null) queryParams.Add("groupaxistype", ApiClient.ParameterToString(groupaxistype)); // query parameter
 if (audited != null) queryParams.Add("audited", ApiClient.ParameterToString(audited)); // query parameter
 if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
 if (showhidden != null) queryParams.Add("showhidden", ApiClient.ParameterToString(showhidden)); // query parameter
 if (showremoved != null) queryParams.Add("showremoved", ApiClient.ParameterToString(showremoved)); // query parameter
 if (showsuppressed != null) queryParams.Add("showsuppressed", ApiClient.ParameterToString(showsuppressed)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueSummaryOfProjectVersion: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListIssueSummaryOfProjectVersion: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultListIssueSummary) ApiClient.Deserialize(response.Content, typeof(ApiResultListIssueSummary), response.Headers);
        }
    
    }
}
