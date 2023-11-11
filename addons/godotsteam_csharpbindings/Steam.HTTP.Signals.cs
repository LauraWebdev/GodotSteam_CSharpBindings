using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The http request completed event handler
    /// </summary>
    public delegate void HttpRequestCompletedEventHandler(long cookieHandle, long contextValue, bool requestSuccess, long statusCode, long bodySize);
    private static event HttpRequestCompletedEventHandler HttpRequestCompletedEvent;
    /// <summary>
    /// The body size
    /// </summary>
    static Action<long, long, bool, long, long> _httpRequestCompletedAction = (cookieHandle, contextValue, requestSuccess, statusCode, bodySize) =>
    {
        HttpRequestCompletedEvent?.Invoke(cookieHandle, contextValue, requestSuccess, statusCode, bodySize);
    };
    /// <summary>
    /// The http request completed
    /// </summary>
    public static event HttpRequestCompletedEventHandler HttpRequestCompleted
    {
        add
        {
            if(HttpRequestCompletedEvent == null)
            {
                GetInstance().Connect(Signals.HttpRequestCompleted, Callable.From(_httpRequestCompletedAction));
            }
            HttpRequestCompletedEvent += value;
        }
        remove
        {
            HttpRequestCompletedEvent -= value; 
            if(HttpRequestCompletedEvent == null)
            {
                GetInstance().Disconnect(Signals.HttpRequestCompleted, Callable.From(_httpRequestCompletedAction));
            }
        }
    }
    
    /// <summary>
    /// The http request data received event handler
    /// </summary>
    public delegate void HttpRequestDataReceivedEventHandler(long cookieHandle, long contextValue, long offset, long bytesReceived);
    private static event HttpRequestDataReceivedEventHandler HttpRequestDataReceivedEvent;
    /// <summary>
    /// The bytes received
    /// </summary>
    static Action<long, long, long, long> _httpRequestDataReceivedAction = (cookieHandle, contextValue, offset, bytesReceived) =>
    {
        HttpRequestDataReceivedEvent?.Invoke(cookieHandle, contextValue, offset, bytesReceived);
    };
    /// <summary>
    /// The http request data received
    /// </summary>
    public static event HttpRequestDataReceivedEventHandler HttpRequestDataReceived
    {
        add
        {
            if(HttpRequestDataReceivedEvent == null)
            {
                GetInstance().Connect(Signals.HttpRequestDataReceived, Callable.From(_httpRequestDataReceivedAction));
            }
            HttpRequestDataReceivedEvent += value;
        }
        remove
        {
            HttpRequestDataReceivedEvent -= value; 
            if(HttpRequestDataReceivedEvent == null)
            {
                GetInstance().Disconnect(Signals.HttpRequestDataReceived, Callable.From(_httpRequestDataReceivedAction));
            }
        }
    }
    
    /// <summary>
    /// The http request headers received event handler
    /// </summary>
    public delegate void HttpRequestHeadersReceivedEventHandler(long cookieHandle, long contextValue);
    private static event HttpRequestHeadersReceivedEventHandler HttpRequestHeadersReceivedEvent;
    /// <summary>
    /// The context value
    /// </summary>
    static Action<long, long> _httpRequestHeadersReceivedAction = (cookieHandle, contextValue) =>
    {
        HttpRequestHeadersReceivedEvent?.Invoke(cookieHandle, contextValue);
    };
    /// <summary>
    /// The http request headers received
    /// </summary>
    public static event HttpRequestHeadersReceivedEventHandler HttpRequestHeadersReceived
    {
        add
        {
            if(HttpRequestHeadersReceivedEvent == null)
            {
                GetInstance().Connect(Signals.HttpRequestHeadersReceived, Callable.From(_httpRequestHeadersReceivedAction));
            }
            HttpRequestHeadersReceivedEvent += value;
        }
        remove
        {
            HttpRequestHeadersReceivedEvent -= value; 
            if(HttpRequestHeadersReceivedEvent == null)
            {
                GetInstance().Disconnect(Signals.HttpRequestHeadersReceived, Callable.From(_httpRequestHeadersReceivedAction));
            }
        }
    }
}