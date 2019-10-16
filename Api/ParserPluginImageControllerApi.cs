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
    public interface IParserPluginImageControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <param name="imageType">imageType</param>
        /// <param name="engineType">engineType</param>
        /// <param name="dataVersion">dataVersion</param>
        /// <returns>byte[]</returns>
        byte[] GetParserPluginImage (string imageType, string engineType, long? dataVersion);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ParserPluginImageControllerApi : IParserPluginImageControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserPluginImageControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ParserPluginImageControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParserPluginImageControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ParserPluginImageControllerApi(String basePath)
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
        /// <param name="imageType">imageType</param> 
        /// <param name="engineType">engineType</param> 
        /// <param name="dataVersion">dataVersion</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetParserPluginImage (string imageType, string engineType, long? dataVersion)
        {
            
            // verify the required parameter 'imageType' is set
            if (imageType == null) throw new ApiException(400, "Missing required parameter 'imageType' when calling GetParserPluginImage");
            
            // verify the required parameter 'engineType' is set
            if (engineType == null) throw new ApiException(400, "Missing required parameter 'engineType' when calling GetParserPluginImage");
            
            // verify the required parameter 'dataVersion' is set
            if (dataVersion == null) throw new ApiException(400, "Missing required parameter 'dataVersion' when calling GetParserPluginImage");
            
    
            var path = "/pluginimage/parser";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (imageType != null) queryParams.Add("imageType", ApiClient.ParameterToString(imageType)); // query parameter
 if (engineType != null) queryParams.Add("engineType", ApiClient.ParameterToString(engineType)); // query parameter
 if (dataVersion != null) queryParams.Add("dataVersion", ApiClient.ParameterToString(dataVersion)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParserPluginImage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetParserPluginImage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
    }
}
