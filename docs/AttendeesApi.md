# AttendeesApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiAttendeesGet**](AttendeesApi.md#apiattendeesget) | **GET** /api/Attendees | 
[**ApiAttendeesIdDelete**](AttendeesApi.md#apiattendeesiddelete) | **DELETE** /api/Attendees/{id} | 
[**ApiAttendeesIdGet**](AttendeesApi.md#apiattendeesidget) | **GET** /api/Attendees/{id} | 
[**ApiAttendeesIdPut**](AttendeesApi.md#apiattendeesidput) | **PUT** /api/Attendees/{id} | 
[**ApiAttendeesPost**](AttendeesApi.md#apiattendeespost) | **POST** /api/Attendees | 

<a name="apiattendeesget"></a>
# **ApiAttendeesGet**
> List<AttendeeDto> ApiAttendeesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAttendeesGetExample
    {
        public void main()
        {

            var apiInstance = new AttendeesApi();

            try
            {
                List&lt;AttendeeDto&gt; result = apiInstance.ApiAttendeesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendeesApi.ApiAttendeesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<AttendeeDto>**](AttendeeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiattendeesiddelete"></a>
# **ApiAttendeesIdDelete**
> void ApiAttendeesIdDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAttendeesIdDeleteExample
    {
        public void main()
        {

            var apiInstance = new AttendeesApi();
            var id = 56;  // int? | 

            try
            {
                apiInstance.ApiAttendeesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendeesApi.ApiAttendeesIdDelete: " + e.Message );
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

<a name="apiattendeesidget"></a>
# **ApiAttendeesIdGet**
> AttendeeDto ApiAttendeesIdGet (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAttendeesIdGetExample
    {
        public void main()
        {

            var apiInstance = new AttendeesApi();
            var id = 56;  // int? | 

            try
            {
                AttendeeDto result = apiInstance.ApiAttendeesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendeesApi.ApiAttendeesIdGet: " + e.Message );
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

[**AttendeeDto**](AttendeeDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiattendeesidput"></a>
# **ApiAttendeesIdPut**
> void ApiAttendeesIdPut (int? id, AttendeeDto body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAttendeesIdPutExample
    {
        public void main()
        {

            var apiInstance = new AttendeesApi();
            var id = 56;  // int? | 
            var body = new AttendeeDto(); // AttendeeDto |  (optional) 

            try
            {
                apiInstance.ApiAttendeesIdPut(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendeesApi.ApiAttendeesIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **body** | [**AttendeeDto**](AttendeeDto.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiattendeespost"></a>
# **ApiAttendeesPost**
> Attendee ApiAttendeesPost (AttendeeDto body)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiAttendeesPostExample
    {
        public void main()
        {

            var apiInstance = new AttendeesApi();
            var body = new AttendeeDto(); // AttendeeDto |  (optional) 

            try
            {
                Attendee result = apiInstance.ApiAttendeesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendeesApi.ApiAttendeesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AttendeeDto**](AttendeeDto.md)|  | [optional] 

### Return type

[**Attendee**](Attendee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

