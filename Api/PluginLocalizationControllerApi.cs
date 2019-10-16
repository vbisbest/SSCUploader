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
    public interface IPluginLocalizationControllerApi
    {
        /// <summary>
        /// read 
        /// </summary>
        /// <param name="engineType">engineType</param>
        /// <param name="dataVersion">dataVersion</param>
        /// <param name="language">language</param>
        /// <returns>ApiResultPluginLocalization</returns>
        ApiResultPluginLocalization ReadPluginLocalization (string engineType, int? dataVersion, string language);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PluginLocalizationControllerApi : IPluginLocalizationControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginLocalizationControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PluginLocalizationControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginLocalizationControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PluginLocalizationControllerApi(String basePath)
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
        /// read 
        /// </summary>
        /// <param name="engineType">engineType</param> 
        /// <param name="dataVersion">dataVersion</param> 
        /// <param name="language">language</param> 
        /// <returns>ApiResultPluginLocalization</returns>            
        public ApiResultPluginLocalization ReadPluginLocalization (string engineType, int? dataVersion, string language)
        {
            
            // verify the required parameter 'engineType' is set
            if (engineType == null) throw new ApiException(400, "Missing required parameter 'engineType' when calling ReadPluginLocalization");
            
            // verify the required parameter 'dataVersion' is set
            if (dataVersion == null) throw new ApiException(400, "Missing required parameter 'dataVersion' when calling ReadPluginLocalization");
            
            // verify the required parameter 'language' is set
            if (language == null) throw new ApiException(400, "Missing required parameter 'language' when calling ReadPluginLocalization");
            
    
            var path = "/pluginlocalization";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (engineType != null) queryParams.Add("engineType", ApiClient.ParameterToString(engineType)); // query parameter
 if (dataVersion != null) queryParams.Add("dataVersion", ApiClient.ParameterToString(dataVersion)); // query parameter
 if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPluginLocalization: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReadPluginLocalization: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultPluginLocalization) ApiClient.Deserialize(response.Content, typeof(ApiResultPluginLocalization), response.Headers);
        }
    
    }
}
