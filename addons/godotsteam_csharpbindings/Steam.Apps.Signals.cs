using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The dlc installed event handler
    /// </summary>
    public delegate void DlcInstalledEventHandler(uint appId);
    private static event DlcInstalledEventHandler DlcInstalledEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<uint> _dlcInstalledAction = (appId) =>
    {
        DlcInstalledEvent?.Invoke(appId);
    };
    /// <summary>
    /// The dlc installed
    /// </summary>
    public static event DlcInstalledEventHandler DlcInstalled
    {
        add
        {
            if(DlcInstalledEvent == null)
            {
                GetInstance().Connect(Signals.DlcInstalled, Callable.From(_dlcInstalledAction));
            }
            DlcInstalledEvent += value;
        }
        remove 
        { 
            DlcInstalledEvent -= value; 
            if(DlcInstalledEvent == null)
            {
                GetInstance().Disconnect(Signals.DlcInstalled, Callable.From(_dlcInstalledAction));
            }
        }
    }
    
    /// <summary>
    /// The file details result event handler
    /// </summary>
    public delegate void FileDetailsResultEventHandler(ErrorResult result, ulong fileSize, sbyte fileHash, uint flags);
    private static event FileDetailsResultEventHandler FileDetailsResultEvent;
    /// <summary>
    /// The flags
    /// </summary>
    static Action<int, ulong, sbyte, uint> _fileDetailsResultAction = (result, fileSize, fileHash, flags) =>
    {
        FileDetailsResultEvent?.Invoke((ErrorResult)result, fileSize, fileHash, flags);
    };
    /// <summary>
    /// The file details result
    /// </summary>
    public static event FileDetailsResultEventHandler FileDetailsResult
    {
        add
        {
            if(FileDetailsResultEvent == null)
            {
                GetInstance().Connect(Signals.FileDetailsResult, Callable.From(_fileDetailsResultAction));
            }
            FileDetailsResultEvent += value;
        }
        remove 
        { 
            FileDetailsResultEvent -= value; 
            if(FileDetailsResultEvent == null)
            {
                GetInstance().Disconnect(Signals.FileDetailsResult, Callable.From(_fileDetailsResultAction));
            }
        }
    }
    
    private static event Action NewLaunchUrlParametersEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _newLaunchUrlParametersAction = () =>
    {
        NewLaunchUrlParametersEvent?.Invoke();
    };
    /// <summary>
    /// The new launch url parameters
    /// </summary>
    public static event Action NewLaunchUrlParameters
    {
        add
        {
            if(NewLaunchUrlParametersEvent == null)
            {
                GetInstance().Connect(Signals.NewLaunchUrlParameters, Callable.From(_newLaunchUrlParametersAction));
            }
            NewLaunchUrlParametersEvent += value;
        }
        remove 
        { 
            NewLaunchUrlParametersEvent -= value; 
            if(NewLaunchUrlParametersEvent == null)
            {
                GetInstance().Disconnect(Signals.NewLaunchUrlParameters, Callable.From(_newLaunchUrlParametersAction));
            }
        }
    }
    
    /// <summary>
    /// The timed trial status event handler
    /// </summary>
    public delegate void TimedTrialStatusEventHandler(uint appId, bool isOffline, uint secondsAllowed, uint secondsPlayed);
    private static event TimedTrialStatusEventHandler TimedTrialStatusEvent;
    /// <summary>
    /// The seconds played
    /// </summary>
    static Action<uint, bool, uint, uint> _timeTrialStatusAction = (appId, isOffline, secondsAllowed, secondsPlayed) =>
    {
        TimedTrialStatusEvent?.Invoke(appId, isOffline, secondsAllowed, secondsPlayed);
    };
    /// <summary>
    /// The timed trial status
    /// </summary>
    public static event TimedTrialStatusEventHandler TimedTrialStatus
    {
        add
        {
            if(TimedTrialStatusEvent == null)
            {
                GetInstance().Connect(Signals.TimedTrialStatus, Callable.From(_timeTrialStatusAction));
            }
            TimedTrialStatusEvent += value;
        }
        remove 
        { 
            TimedTrialStatusEvent -= value; 
            if(TimedTrialStatusEvent == null)
            {
                GetInstance().Disconnect(Signals.TimedTrialStatus, Callable.From(_timeTrialStatusAction));
            }
        }
    }
}