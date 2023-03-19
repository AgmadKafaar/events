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
    public interface IEventsApi
    {
        /// <summary>
        ///  
        /// </summary>
        /// <returns>List&lt;ModelEvent&gt;</returns>
        List<ModelEvent> ApiEventsGet ();
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        void ApiEventsIdDelete (int? id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>EventDto</returns>
        EventDto ApiEventsIdGet (int? id);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ApiEventsIdPut (int? id, EventDto body);
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>EventDto</returns>
        EventDto ApiEventsPost (EventDto body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EventsApi : IEventsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EventsApi(Client.ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(String basePath)
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
        /// <returns>List&lt;ModelEvent&gt;</returns>
        public List<ModelEvent> ApiEventsGet ()
        {
    
            var path = "/api/Events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ModelEvent>) ApiClient.Deserialize(response.Content, typeof(List<ModelEvent>), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void ApiEventsIdDelete (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiEventsIdDelete");
    
            var path = "/api/Events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <returns>EventDto</returns>
        public EventDto ApiEventsIdGet (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiEventsIdGet");
    
            var path = "/api/Events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventDto) ApiClient.Deserialize(response.Content, typeof(EventDto), response.Headers);
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void ApiEventsIdPut (int? id, EventDto body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApiEventsIdPut");
    
            var path = "/api/Events/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsIdPut: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsIdPut: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  
        /// </summary>
        /// <param name="body"></param>
        /// <returns>EventDto</returns>
        public EventDto ApiEventsPost (EventDto body)
        {
    
            var path = "/api/Events";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApiEventsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (EventDto) ApiClient.Deserialize(response.Content, typeof(EventDto), response.Headers);
        }
    
    }
}
