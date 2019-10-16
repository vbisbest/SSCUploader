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
    public interface IValidateEquationControllerApi
    {
        /// <summary>
        /// DoValidation 
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>ApiResultValidationStatus</returns>
        ApiResultValidationStatus DoValidateEquation (ValidationRequest request);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ValidateEquationControllerApi : IValidateEquationControllerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEquationControllerApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ValidateEquationControllerApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEquationControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ValidateEquationControllerApi(String basePath)
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
        /// DoValidation 
        /// </summary>
        /// <param name="request">request</param> 
        /// <returns>ApiResultValidationStatus</returns>            
        public ApiResultValidationStatus DoValidateEquation (ValidationRequest request)
        {
            
            // verify the required parameter 'request' is set
            if (request == null) throw new ApiException(400, "Missing required parameter 'request' when calling DoValidateEquation");
            
    
            var path = "/validateEquation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(request); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "FortifyToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DoValidateEquation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DoValidateEquation: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiResultValidationStatus) ApiClient.Deserialize(response.Content, typeof(ApiResultValidationStatus), response.Headers);
        }
    
    }
}
