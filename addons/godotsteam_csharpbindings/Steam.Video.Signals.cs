using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void GetOpfSettingsResultEventHandler(ErrorResult result, uint appId);
    private static event GetOpfSettingsResultEventHandler GetOpfSettingsResultEvent;
    static Action<int, uint> _getOpfSettingsResultAction = (result, appId) =>
    {
        GetOpfSettingsResultEvent?.Invoke((ErrorResult)result, appId);
    };
    public static event GetOpfSettingsResultEventHandler GetOpfSettingsResult
    {
        add
        {
            if(GetOpfSettingsResultEvent == null)
            {
                GetInstance().Connect(Signals.GetOpfSettingsResult, Callable.From(_getOpfSettingsResultAction));
            }
            GetOpfSettingsResultEvent += value;
        }
        remove
        {
            GetOpfSettingsResultEvent -= value;
            if(GetOpfSettingsResultEvent == null)
            {
                GetInstance().Disconnect(Signals.GetOpfSettingsResult, Callable.From(_getOpfSettingsResultAction));
            }
        }
    }
    
    public delegate void GetVideoResultEventHandler(ErrorResult result, uint appId, string url);
    private static event GetVideoResultEventHandler GetVideoResultEvent;
    static Action<int, uint, string> _getVideoResultAction = (result, appId, url) =>
    {
        GetVideoResultEvent?.Invoke((ErrorResult)result, appId, url);
    };
    public static event GetVideoResultEventHandler GetVideoResult
    {
        add
        {
            if(GetVideoResultEvent == null)
            {
                GetInstance().Connect(Signals.GetVideoResult, Callable.From(_getVideoResultAction));
            }
            GetVideoResultEvent += value;
        }
        remove
        {
            GetVideoResultEvent -= value;
            if(GetVideoResultEvent == null)
            {
                GetInstance().Disconnect(Signals.GetVideoResult, Callable.From(_getVideoResultAction));
            }
        }
    }
}