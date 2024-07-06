namespace GodotSteam;

public static partial class Steam
{
    public static uint CreateCookieContainer(bool allowResponseToModify)
    {
        return GetInstance().Call(Methods.CreateCookieContainer, allowResponseToModify).As<uint>();
    }
    
    public static uint CreateHTTPRequest(HttpMethod requestMethod, string absoluteUrl)
    {
        return GetInstance().Call(Methods.CreateHTTPRequest, (int)requestMethod, absoluteUrl).As<uint>();
    }
    
    public static bool DeferHTTPRequest(uint requestHandle)
    {
        return GetInstance().Call(Methods.DeferHTTPRequest, requestHandle).As<bool>();
    }
    
    public static float GetHTTPDownloadProgressPct(uint requestHandle)
    {
        return GetInstance().Call(Methods.GetHTTPDownloadProgressPct, requestHandle).AsSingle();
    }
    
    public static bool GetHTTPRequestWasTimedOut(uint requestHandle)
    {
        return GetInstance().Call(Methods.GetHTTPRequestWasTimedOut, requestHandle).As<bool>();
    }
    
    public static byte[] GetHTTPResponseBodyData(uint requestHandle, uint bufferSize)
    {
        return GetInstance().Call(Methods.GetHTTPResponseBodyData, requestHandle, bufferSize).AsByteArray();
    }
    
    public static uint GetHTTPResponseBodySize(uint requestHandle)
    {
        return GetInstance().Call(Methods.GetHTTPResponseBodySize, requestHandle).As<uint>();
    }
    
    public static uint GetHTTPResponseHeaderSize(uint requestHandle, string headerName)
    {
        return GetInstance().Call(Methods.GetHTTPResponseHeaderSize, requestHandle, headerName).As<uint>();
    }
    
    public static byte GetHTTPResponseHeaderValue(uint requestHandle, string headerName, uint bufferSize)
    {
        return GetInstance().Call(Methods.GetHTTPResponseHeaderValue, requestHandle, headerName, bufferSize).AsByte();
    }
    
    public static byte GetHTTPStreamingResponseBodyData(uint requestHandle, uint offset, uint bufferSize)
    {
        return GetInstance().Call(Methods.GetHTTPStreamingResponseBodyData, requestHandle, offset, bufferSize).AsByte();
    }
    
    public static bool PrioritizeHTTPRequest(uint requestHandle)
    {
        return GetInstance().Call(Methods.PrioritizeHTTPRequest, requestHandle).As<bool>();
    }
    
    public static bool ReleaseCookieContainer()
    {
        return GetInstance().Call(Methods.ReleaseCookieContainer).As<bool>();
    }
    
    public static bool ReleaseHTTPRequest(uint requestHandle)
    {
        return GetInstance().Call(Methods.ReleaseHTTPRequest, requestHandle).As<bool>();
    }
    
    public static bool SendHTTPRequest(uint requestHandle)
    {
        return GetInstance().Call(Methods.SendHTTPRequest, requestHandle).As<bool>();
    }
    
    public static bool SendHTTPRequestAndStreamResponse(uint requestHandle)
    {
        return GetInstance().Call(Methods.SendHTTPRequestAndStreamResponse, requestHandle).As<bool>();
    }
    
    public static bool SetHTTPCookie(string host, string url, string cookie)
    {
        return GetInstance().Call(Methods.SetHTTPCookie, host, url, cookie).As<bool>();
    }
    
    public static bool SetHTTPRequestAbsoluteTimeoutMS(uint requestHandle, uint milliseconds)
    {
        return GetInstance().Call(Methods.SetHTTPRequestAbsoluteTimeoutMS, requestHandle, milliseconds).As<bool>();
    }
    
    public static bool SetHTTPRequestContextValue(uint requestHandle, ulong contextValue)
    {
        return GetInstance().Call(Methods.SetHTTPRequestContextValue, requestHandle, contextValue).As<bool>();
    }
    
    public static bool SetHTTPRequestCookieContainer(uint requestHandle, uint cookieHandle)
    {
        return GetInstance().Call(Methods.SetHTTPRequestCookieContainer, requestHandle, cookieHandle).As<bool>();
    }
    
    public static bool SetHTTPRequestGetOrPostParameter(uint requestHandle, string name, string value)
    {
        return GetInstance().Call(Methods.SetHTTPRequestGetOrPostParameter, requestHandle, name, value).As<bool>();
    }
    
    public static bool SetHTTPRequestHeaderValue(uint requestHandle, string headerName, string headerValue)
    {
        return GetInstance().Call(Methods.SetHTTPRequestHeaderValue, requestHandle, headerName, headerValue).As<bool>();
    }
    
    public static bool SetHTTPRequestNetworkActivityTimeout(uint requestHandle, uint timeoutSeconds)
    {
        return GetInstance().Call(Methods.SetHTTPRequestNetworkActivityTimeout, requestHandle, timeoutSeconds).As<bool>();
    }
    
    public static byte SetHTTPRequestRawPostBody(uint requestHandle, string contentType, uint bodyLength)
    {
        return GetInstance().Call(Methods.SetHTTPRequestRawPostBody, requestHandle, contentType, bodyLength).AsByte();
    }
    
    public static bool SetHTTPRequestRequiresVerifiedCertificate(uint requestHandle, bool requireVerifiedCertificate)
    {
        return GetInstance().Call(Methods.SetHTTPRequestRequiresVerifiedCertificate, requestHandle, requireVerifiedCertificate).As<bool>();
    }
    
    public static bool SetHTTPRequestUserAgentInfo(uint requestHandle, string userAgentInfo)
    {
        return GetInstance().Call(Methods.SetHTTPRequestUserAgentInfo, requestHandle, userAgentInfo).As<bool>();
    }

    public enum HttpMethod : long
    {
        Invalid = 0,
        Get = 1,
        Head = 2,
        Post = 3,
        Put = 4,
        Delete = 5,
        Options = 6,
        Patch = 7
    }

    public enum HttpStatusCode : long
    {
        Invalid = 0,
        Code100Continue = 100,
        Code101SwitchingProtocols = 101,
        Code200Ok = 200,
        Code201Created = 201,
        Code202Accepted = 202,
        Code203NonAuthoritative = 203,
        Code204NoContent = 204,
        Code205ResetContent = 205,
        Code206PartialContent = 206,
        Code300MultipleChoices = 300,
        Code301MovedPermanently = 301,
        Code302Found = 302,
        Code303SeeOther = 303,
        Code304NotModified = 304,
        Code305UseProxy = 305,
        Code307TemporaryRedirect = 307,
        Code308PermanentRedirect = 308,
        Code400BadRequest = 400,
        Code401Unauthorized = 401,
        Code402PaymentRequired = 402,
        Code403Forbidden = 403,
        Code404NotFound = 404,
        Code405MethodNotAllowed = 405,
        Code406NotAcceptable = 406,
        Code407ProxyAuthRequired = 407,
        Code408RequestTimeout = 408,
        Code409Conflict = 409,
        Code410Gone = 410,
        Code411LengthRequired = 411,
        Code412PreconditionFailed = 412,
        Code413RequestEntityTooLarge = 413,
        Code414RequestUriTooLong = 414,
        Code415UnsupportedMediaType = 415,
        Code416RequestedRangeNotSatisfiable = 416,
        Code417ExpectationFailed = 417,
        Code4XxUnknown = 418,
        Code429TooManyRequests = 429,
        Code444ConnectionClosed = 444,
        Code500InternalServerError = 500,
        Code501NotImplemented = 501,
        Code502BadGateway = 502,
        Code503ServiceUnavailable = 503,
        Code504GatewayTimeout = 504,
        Code505HttpVersionNotSupported = 505,
        Code5XxUnknown = 599
    }
}