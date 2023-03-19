# EventsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiEventsGet**](EventsApi.md#apieventsget) | **GET** /api/Events | 
[**ApiEventsIdDelete**](EventsApi.md#apieventsiddelete) | **DELETE** /api/Events/{id} | 
[**ApiEventsIdGet**](EventsApi.md#apieventsidget) | **GET** /api/Events/{id} | 
[**ApiEventsIdPut**](EventsApi.md#apieventsidput) | **PUT** /api/Events/{id} | 
[**ApiEventsPost**](EventsApi.md#apieventspost) | **POST** /api/Events | 

<a name="apieventsget"></a>
# **ApiEventsGet**
> List<ModelEvent> ApiEventsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiEventsGetExample
    {
        public void main()
        {

            var apiInstance = new EventsApi();

            try
            {
                List&lt;ModelEvent&gt; result = apiInstance.ApiEventsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ModelEvent>**](ModelEvent.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apieventsiddelete"></a>
# **ApiEventsIdDelete**
> void ApiEventsIdDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiEventsIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new EventsApi();
            var id = 56;  // int? | 

            try
            {
                apiInstance.ApiEventsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apieventsidget"></a>
# **ApiEventsIdGet**
> EventDto ApiEventsIdGet (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiEventsIdGetExample
    {
        public void main()
        {

            var apiInstance = new EventsApi();
            var id = 56;  // int? | 

            try
            {
                EventDto result = apiInstance.ApiEventsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

[**EventDto**](EventDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apieventsidput"></a>
# **ApiEventsIdPut**
> void ApiEventsIdPut (int? id, EventDto body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiEventsIdPutExample
    {
        public void main()
        {

            var apiInstance = new EventsApi();
            var id = 56;  // int? | 
            var body = new EventDto(); // EventDto |  (optional) 

            try
            {
                apiInstance.ApiEventsIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **body** | [**EventDto**](EventDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apieventspost"></a>
# **ApiEventsPost**
> EventDto ApiEventsPost (EventDto body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiEventsPostExample
    {
        public void main()
        {

            var apiInstance = new EventsApi();
            var body = new EventDto(); // EventDto |  (optional) 

            try
            {
                EventDto result = apiInstance.ApiEventsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EventsApi.ApiEventsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventDto**](EventDto.md)|  | [optional] 

### Return type

[**EventDto**](EventDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

