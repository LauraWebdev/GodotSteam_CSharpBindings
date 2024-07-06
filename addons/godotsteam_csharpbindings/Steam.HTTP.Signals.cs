using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void HttpRequestCompletedEventHandler(uint cookieHandle, ulong contextValue, bool requestSuccess, int statusCode, uint bodySize);
    private static event HttpRequestCompletedEventHandler HttpRequestCompletedEvent;
    static Action<uint, ulong, bool, int, uint> _httpRequestCompletedAction = (cookieHandle, contextValue, requestSuccess, statusCode, bodySize) =>
    {
        HttpRequestCompletedEvent?.Invoke(cookieHandle, contextValue, requestSuccess, statusCode, bodySize);
    };
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
    
    public delegate void HttpRequestDataReceivedEventHandler(uint cookieHandle, ulong contextValue, uint offset, uint bytesReceived);
    private static event HttpRequestDataReceivedEventHandler HttpRequestDataReceivedEvent;
    static Action<uint, ulong, uint, uint> _httpRequestDataReceivedAction = (cookieHandle, contextValue, offset, bytesReceived) =>
    {
        HttpRequestDataReceivedEvent?.Invoke(cookieHandle, contextValue, offset, bytesReceived);
    };
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
    
    public delegate void HttpRequestHeadersReceivedEventHandler(uint cookieHandle, ulong contextValue);
    private static event HttpRequestHeadersReceivedEventHandler HttpRequestHeadersReceivedEvent;
    static Action<uint, ulong> _httpRequestHeadersReceivedAction = (cookieHandle, contextValue) =>
    {
        HttpRequestHeadersReceivedEvent?.Invoke(cookieHandle, contextValue);
    };
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