using System;
using System.Collections.Generic;
using Events.ApiClient.Client;
using Events.ApiClient.Model;
using RestSharp;

namespace Events.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAttendeesApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;AttendeeDto&gt;</returns>
        List<AttendeeDto> ApiAttendeesGet ();
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void ApiAttendeesIdDelete (int? id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>AttendeeDto</returns>
        AttendeeDto ApiAttendeesIdGet (int? id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApiAttendeesIdPut (int? id, AttendeeDto body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Attendee</returns>
        Attendee ApiAttendeesPost (AttendeeDto body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttendeesApi : IAttendeesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AttendeesApi(Client.ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttendeesApi(String basePath)
        {
            this.ApiClient = new Client.ApiClient(basePath);
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
        public Client.ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;AttendeeDto&gt;</returns>
        public List<AttendeeDto> ApiAttendeesGet ()
        {
    
            var path = "/api/Attendees";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<AttendeeDto>) ApiClient.Deserialize(response.Content, typeof(List<AttendeeDto>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void ApiAttendeesIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiAttendeesIdDelete");
    
            var path = "/api/Attendees/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Delete, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>AttendeeDto</returns>
        public AttendeeDto ApiAttendeesIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiAttendeesIdGet");
    
            var path = "/api/Attendees/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AttendeeDto) ApiClient.Deserialize(response.Content, typeof(AttendeeDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void ApiAttendeesIdPut (int? id, AttendeeDto body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiAttendeesIdPut");
    
            var path = "/api/Attendees/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Put, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Attendee</returns>
        public Attendee ApiAttendeesPost (AttendeeDto body)
        {
    
            var path = "/api/Attendees";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiAttendeesPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Attendee) ApiClient.Deserialize(response.Content, typeof(Attendee), response.Headers);
        }
    
    }
}
