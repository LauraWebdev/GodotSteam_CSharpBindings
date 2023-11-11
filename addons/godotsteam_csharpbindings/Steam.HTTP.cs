namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Creates the cookie container using the specified allow response to modify
    /// </summary>
    /// <param name="allowResponseToModify">The allow response to modify</param>
    /// <returns>The uint</returns>
    public static uint CreateCookieContainer(bool allowResponseToModify)
    {
        return GetInstance().Call(Methods.CreateCookieContainer, allowResponseToModify).AsUInt32();
    }
    
    /// <summary>
    /// Creates the http request using the specified request method
    /// </summary>
    /// <param name="requestMethod">The request method</param>
    /// <param name="absoluteUrl">The absolute url</param>
    /// <returns>The uint</returns>
    public static uint CreateHTTPRequest(HttpMethod requestMethod, string absoluteUrl)
    {
        return GetInstance().Call(Methods.CreateHTTPRequest, (long)requestMethod, absoluteUrl).AsUInt32();
    }
    
    /// <summary>
    /// Describes whether defer http request
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The bool</returns>
    public static bool DeferHTTPRequest(long requestHandle)
    {
        return GetInstance().Call(Methods.DeferHTTPRequest, requestHandle).AsBool();
    }
    
    /// <summary>
    /// Gets the http download progress pct using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The float</returns>
    public static float GetHTTPDownloadProgressPct(long requestHandle)
    {
        return GetInstance().Call(Methods.GetHTTPDownloadProgressPct, requestHandle).AsSingle();
    }
    
    /// <summary>
    /// Describes whether get http request was timed out
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The bool</returns>
    public static bool GetHTTPRequestWasTimedOut(long requestHandle)
    {
        return GetInstance().Call(Methods.GetHTTPRequestWasTimedOut, requestHandle).AsBool();
    }
    
    /// <summary>
    /// Gets the http response body data using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="bufferSize">The buffer size</param>
    /// <returns>The byte array</returns>
    public static byte[] GetHTTPResponseBodyData(uint requestHandle, long bufferSize)
    {
        return GetInstance().Call(Methods.GetHTTPResponseBodyData, requestHandle, bufferSize).AsByteArray();
    }
    
    /// <summary>
    /// Gets the http response body size using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The uint</returns>
    public static uint GetHTTPResponseBodySize(long requestHandle)
    {
        return GetInstance().Call(Methods.GetHTTPResponseBodySize, requestHandle).AsUInt32();
    }
    
    /// <summary>
    /// Gets the http response header size using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="headerName">The header name</param>
    /// <returns>The uint</returns>
    public static uint GetHTTPResponseHeaderSize(uint requestHandle, string headerName)
    {
        return GetInstance().Call(Methods.GetHTTPResponseHeaderSize, requestHandle, headerName).AsUInt32();
    }
    
    /// <summary>
    /// Gets the http response header value using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="headerName">The header name</param>
    /// <param name="bufferSize">The buffer size</param>
    /// <returns>The byte</returns>
    public static byte GetHTTPResponseHeaderValue(uint requestHandle, string headerName, long bufferSize)
    {
        return GetInstance().Call(Methods.GetHTTPResponseHeaderValue, requestHandle, headerName, bufferSize).AsByte();
    }
    
    /// <summary>
    /// Gets the http streaming response body data using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="offset">The offset</param>
    /// <param name="bufferSize">The buffer size</param>
    /// <returns>The byte</returns>
    public static byte GetHTTPStreamingResponseBodyData(uint requestHandle, uint offset, long bufferSize)
    {
        return GetInstance().Call(Methods.GetHTTPStreamingResponseBodyData, requestHandle, offset, bufferSize).AsByte();
    }
    
    /// <summary>
    /// Describes whether prioritize http request
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The bool</returns>
    public static bool PrioritizeHTTPRequest(long requestHandle)
    {
        return GetInstance().Call(Methods.PrioritizeHTTPRequest, requestHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether release cookie container
    /// </summary>
    /// <param name="cookieHandle">The cookie handle</param>
    /// <returns>The bool</returns>
    public static bool ReleaseCookieContainer(long cookieHandle)
    {
        return GetInstance().Call(Methods.ReleaseCookieContainer, cookieHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether release http request
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The bool</returns>
    public static bool ReleaseHTTPRequest(long requestHandle)
    {
        return GetInstance().Call(Methods.ReleaseHTTPRequest, requestHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether send http request
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The bool</returns>
    public static bool SendHTTPRequest(long requestHandle)
    {
        return GetInstance().Call(Methods.SendHTTPRequest, requestHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether send http request and stream response
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <returns>The bool</returns>
    public static bool SendHTTPRequestAndStreamResponse(long requestHandle)
    {
        return GetInstance().Call(Methods.SendHTTPRequestAndStreamResponse, requestHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http cookie
    /// </summary>
    /// <param name="cookieHandle">The cookie handle</param>
    /// <param name="host">The host</param>
    /// <param name="url">The url</param>
    /// <param name="cookie">The cookie</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPCookie(uint cookieHandle, string host, string url, string cookie)
    {
        return GetInstance().Call(Methods.SetHTTPCookie, cookieHandle, host, url, cookie).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request absolute timeout ms
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="milliseconds">The milliseconds</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestAbsoluteTimeoutMS(uint requestHandle, long milliseconds)
    {
        return GetInstance().Call(Methods.SetHTTPRequestAbsoluteTimeoutMS, requestHandle, milliseconds).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request context value
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="contextValue">The context value</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestContextValue(uint requestHandle, long contextValue)
    {
        return GetInstance().Call(Methods.SetHTTPRequestContextValue, requestHandle, contextValue).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request cookie container
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="cookieHandle">The cookie handle</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestCookieContainer(uint requestHandle, long cookieHandle)
    {
        return GetInstance().Call(Methods.SetHTTPRequestCookieContainer, requestHandle, cookieHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request get or post parameter
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="name">The name</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestGetOrPostParameter(uint requestHandle, string name, string value)
    {
        return GetInstance().Call(Methods.SetHTTPRequestGetOrPostParameter, requestHandle, name, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request header value
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="headerName">The header name</param>
    /// <param name="headerValue">The header value</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestHeaderValue(uint requestHandle, string headerName, string headerValue)
    {
        return GetInstance().Call(Methods.SetHTTPRequestHeaderValue, requestHandle, headerName, headerValue).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request network activity timeout
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="timeoutSeconds">The timeout seconds</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestNetworkActivityTimeout(uint requestHandle, long timeoutSeconds)
    {
        return GetInstance().Call(Methods.SetHTTPRequestNetworkActivityTimeout, requestHandle, timeoutSeconds).AsBool();
    }
    
    /// <summary>
    /// Sets the http request raw post body using the specified request handle
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="contentType">The content type</param>
    /// <param name="bodyLength">The body length</param>
    /// <returns>The byte</returns>
    public static byte SetHTTPRequestRawPostBody(uint requestHandle, string contentType, long bodyLength)
    {
        return GetInstance().Call(Methods.SetHTTPRequestRawPostBody, requestHandle, contentType, bodyLength).AsByte();
    }
    
    /// <summary>
    /// Describes whether set http request requires verified certificate
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="requireVerifiedCertificate">The require verified certificate</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestRequiresVerifiedCertificate(uint requestHandle, bool requireVerifiedCertificate)
    {
        return GetInstance().Call(Methods.SetHTTPRequestRequiresVerifiedCertificate, requestHandle, requireVerifiedCertificate).AsBool();
    }
    
    /// <summary>
    /// Describes whether set http request user agent info
    /// </summary>
    /// <param name="requestHandle">The request handle</param>
    /// <param name="userAgentInfo">The user agent info</param>
    /// <returns>The bool</returns>
    public static bool SetHTTPRequestUserAgentInfo(uint requestHandle, string userAgentInfo)
    {
        return GetInstance().Call(Methods.SetHTTPRequestUserAgentInfo, requestHandle, userAgentInfo).AsBool();
    }

    /// <summary>
    /// The http method enum
    /// </summary>
    public enum HttpMethod : long
    {
        /// <summary>
        /// The invalid http method
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The get http method
        /// </summary>
        Get = 1,
        /// <summary>
        /// The head http method
        /// </summary>
        Head = 2,
        /// <summary>
        /// The post http method
        /// </summary>
        Post = 3,
        /// <summary>
        /// The put http method
        /// </summary>
        Put = 4,
        /// <summary>
        /// The delete http method
        /// </summary>
        Delete = 5,
        /// <summary>
        /// The options http method
        /// </summary>
        Options = 6,
        /// <summary>
        /// The patch http method
        /// </summary>
        Patch = 7
    }

    /// <summary>
    /// The http status code enum
    /// </summary>
    public enum HttpStatusCode : long
    {
        /// <summary>
        /// The invalid http status code
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The code 100 continue http status code
        /// </summary>
        Code100Continue = 100,
        /// <summary>
        /// The code 101 switching protocols http status code
        /// </summary>
        Code101SwitchingProtocols = 101,
        /// <summary>
        /// The code 200 ok http status code
        /// </summary>
        Code200Ok = 200,
        /// <summary>
        /// The code 201 created http status code
        /// </summary>
        Code201Created = 201,
        /// <summary>
        /// The code 202 accepted http status code
        /// </summary>
        Code202Accepted = 202,
        /// <summary>
        /// The code 203 non authoritative http status code
        /// </summary>
        Code203NonAuthoritative = 203,
        /// <summary>
        /// The code 204 no content http status code
        /// </summary>
        Code204NoContent = 204,
        /// <summary>
        /// The code 205 reset content http status code
        /// </summary>
        Code205ResetContent = 205,
        /// <summary>
        /// The code 206 partial content http status code
        /// </summary>
        Code206PartialContent = 206,
        /// <summary>
        /// The code 300 multiple choices http status code
        /// </summary>
        Code300MultipleChoices = 300,
        /// <summary>
        /// The code 301 moved permanently http status code
        /// </summary>
        Code301MovedPermanently = 301,
        /// <summary>
        /// The code 302 found http status code
        /// </summary>
        Code302Found = 302,
        /// <summary>
        /// The code 303 see other http status code
        /// </summary>
        Code303SeeOther = 303,
        /// <summary>
        /// The code 304 not modified http status code
        /// </summary>
        Code304NotModified = 304,
        /// <summary>
        /// The code 305 use proxy http status code
        /// </summary>
        Code305UseProxy = 305,
        /// <summary>
        /// The code 307 temporary redirect http status code
        /// </summary>
        Code307TemporaryRedirect = 307,
        /// <summary>
        /// The code 308 permanent redirect http status code
        /// </summary>
        Code308PermanentRedirect = 308,
        /// <summary>
        /// The code 400 bad request http status code
        /// </summary>
        Code400BadRequest = 400,
        /// <summary>
        /// The code 401 unauthorized http status code
        /// </summary>
        Code401Unauthorized = 401,
        /// <summary>
        /// The code 402 payment required http status code
        /// </summary>
        Code402PaymentRequired = 402,
        /// <summary>
        /// The code 403 forbidden http status code
        /// </summary>
        Code403Forbidden = 403,
        /// <summary>
        /// The code 404 not found http status code
        /// </summary>
        Code404NotFound = 404,
        /// <summary>
        /// The code 405 method not allowed http status code
        /// </summary>
        Code405MethodNotAllowed = 405,
        /// <summary>
        /// The code 406 not acceptable http status code
        /// </summary>
        Code406NotAcceptable = 406,
        /// <summary>
        /// The code 407 proxy auth required http status code
        /// </summary>
        Code407ProxyAuthRequired = 407,
        /// <summary>
        /// The code 408 request timeout http status code
        /// </summary>
        Code408RequestTimeout = 408,
        /// <summary>
        /// The code 409 conflict http status code
        /// </summary>
        Code409Conflict = 409,
        /// <summary>
        /// The code 410 gone http status code
        /// </summary>
        Code410Gone = 410,
        /// <summary>
        /// The code 411 length required http status code
        /// </summary>
        Code411LengthRequired = 411,
        /// <summary>
        /// The code 412 precondition failed http status code
        /// </summary>
        Code412PreconditionFailed = 412,
        /// <summary>
        /// The code 413 request entity too large http status code
        /// </summary>
        Code413RequestEntityTooLarge = 413,
        /// <summary>
        /// The code 414 request uri too long http status code
        /// </summary>
        Code414RequestUriTooLong = 414,
        /// <summary>
        /// The code 415 unsupported media type http status code
        /// </summary>
        Code415UnsupportedMediaType = 415,
        /// <summary>
        /// The code 416 requested range not satisfiable http status code
        /// </summary>
        Code416RequestedRangeNotSatisfiable = 416,
        /// <summary>
        /// The code 417 expectation failed http status code
        /// </summary>
        Code417ExpectationFailed = 417,
        /// <summary>
        /// The code xx unknown http status code
        /// </summary>
        Code4XxUnknown = 418,
        /// <summary>
        /// The code 429 too many requests http status code
        /// </summary>
        Code429TooManyRequests = 429,
        /// <summary>
        /// The code 444 connection closed http status code
        /// </summary>
        Code444ConnectionClosed = 444,
        /// <summary>
        /// The code 500 internal server error http status code
        /// </summary>
        Code500InternalServerError = 500,
        /// <summary>
        /// The code 501 not implemented http status code
        /// </summary>
        Code501NotImplemented = 501,
        /// <summary>
        /// The code 502 bad gateway http status code
        /// </summary>
        Code502BadGateway = 502,
        /// <summary>
        /// The code 503 service unavailable http status code
        /// </summary>
        Code503ServiceUnavailable = 503,
        /// <summary>
        /// The code 504 gateway timeout http status code
        /// </summary>
        Code504GatewayTimeout = 504,
        /// <summary>
        /// The code 505 http version not supported http status code
        /// </summary>
        Code505HttpVersionNotSupported = 505,
        /// <summary>
        /// The code xx unknown http status code
        /// </summary>
        Code5XxUnknown = 599
    }
}