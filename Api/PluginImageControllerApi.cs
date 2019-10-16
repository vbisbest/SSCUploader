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
    public interface IPluginImageControllerApi
    {
        /// <summary>
        /// get 
        /// </summary>
        /// <param name="imageType">imageType</param>
        /// <param name="metadataId">metadataId</param>
        /// <returns>byte[]</returns>
        byte[] GetPluginImage (string imageType, long? metadataId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PluginImageControllerApi : IPluginImageControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginImageControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PluginImageControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginImageControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PluginImageControllerApi(String basePath)
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
        /// <param name="metadataId">metadataId</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetPluginImage (string imageType, long? metadataId)
        {
            
            // verify the required parameter 'imageType' is set
            if (imageType == null) throw new ApiException(400, "Missing required parameter 'imageType' when calling GetPluginImage");
            
            // verify the required parameter 'metadataId' is set
            if (metadataId == null) throw new ApiException(400, "Missing required parameter 'metadataId' when calling GetPluginImage");
            
    
            var path = "/pluginimage";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (imageType != null) queryParams.Add("imageType", ApiClient.ParameterToString(imageType)); // query parameter
 if (metadataId != null) queryParams.Add("metadataId", ApiClient.ParameterToString(metadataId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPluginImage: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPluginImage: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]), response.Headers);
        }
    
    }
}
