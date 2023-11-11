using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public static event Action MusicPlayerRemoteToFrontEvent;
    static Action _musicPlayerRemoteToFrontAction = () =>
    {
        MusicPlayerRemoteToFrontEvent?.Invoke();
    };
    public static event Action MusicPlayerRemoteToFront
    {
        add
        {
            if(MusicPlayerRemoteToFrontEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerRemoteToFront, Callable.From(_musicPlayerRemoteToFrontAction));
            }
            MusicPlayerRemoteToFrontEvent += value;
        }
        remove
        {
            MusicPlayerRemoteToFrontEvent -= value;
            if(MusicPlayerRemoteToFrontEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerRemoteToFront, Callable.From(_musicPlayerRemoteToFrontAction));
            }
        }
    }
    
    public static event Action MusicPlayerRemoteWillActivateEvent;
    static Action _musicPlayerRemoteWillActivateAction = () =>
    {
        MusicPlayerRemoteWillActivateEvent?.Invoke();
    };
    public static event Action MusicPlayerRemoteWillActivate
    {
        add
        {
            if(MusicPlayerRemoteWillActivateEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerRemoteWillActivate, Callable.From(_musicPlayerRemoteWillActivateAction));
            }
            MusicPlayerRemoteWillActivateEvent += value;
        }
        remove
        {
            MusicPlayerRemoteWillActivateEvent -= value;
            if(MusicPlayerRemoteWillActivateEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerRemoteWillActivate, Callable.From(_musicPlayerRemoteWillActivateAction));
            }
        }
    }
    
    public static event Action MusicPlayerRemoteWillDeactivateEvent;
    static Action _musicPlayerRemoteWillDeactivateAction = () =>
    {
        MusicPlayerRemoteWillDeactivateEvent?.Invoke();
    };
    public static event Action MusicPlayerRemoteWillDeactivate
    {
        add
        {
            if(MusicPlayerRemoteWillDeactivateEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerRemoteWillDeactivate, Callable.From(_musicPlayerRemoteWillDeactivateAction));
            }
            MusicPlayerRemoteWillDeactivateEvent += value;
        }
        remove
        {
            MusicPlayerRemoteWillDeactivateEvent -= value;
            if(MusicPlayerRemoteWillDeactivateEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerRemoteWillDeactivate, Callable.From(_musicPlayerRemoteWillDeactivateAction));
            }
        }
    }
    
    public delegate void MusicPlayerSelectsPlaylistEntryEventHandler(long entry);
    private static event MusicPlayerSelectsPlaylistEntryEventHandler MusicPlayerSelectsPlaylistEntryEvent;
    static Action<long> _musicPlayerSelectsPlaylistEntryAction = (entry) =>
    {
        MusicPlayerSelectsPlaylistEntryEvent?.Invoke(entry);
    };
    public static event MusicPlayerSelectsPlaylistEntryEventHandler MusicPlayerSelectsPlaylistEntry
    {
        add
        {
            if(MusicPlayerSelectsPlaylistEntryEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerSelectsPlaylistEntry, Callable.From(_musicPlayerSelectsPlaylistEntryAction));
            }
            MusicPlayerSelectsPlaylistEntryEvent += value;
        }
        remove 
        { 
            MusicPlayerSelectsPlaylistEntryEvent -= value; 
            if(MusicPlayerSelectsPlaylistEntryEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerSelectsPlaylistEntry, Callable.From(_musicPlayerSelectsPlaylistEntryAction));
            }
        }
    }
    
    public delegate void MusicPlayerSelectsQueueEntryEventHandler(long entry);
    private static event MusicPlayerSelectsQueueEntryEventHandler MusicPlayerSelectsQueueEntryEvent;
    static Action<long> _musicPlayerSelectsQueueEntryAction = (entry) =>
    {
        MusicPlayerSelectsQueueEntryEvent?.Invoke(entry);
    };
    public static event MusicPlayerSelectsQueueEntryEventHandler MusicPlayerSelectsQueueEntry
    {
        add
        {
            if(MusicPlayerSelectsQueueEntryEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerSelectsQueueEntry, Callable.From(_musicPlayerSelectsQueueEntryAction));
            }
            MusicPlayerSelectsQueueEntryEvent += value;
        }
        remove 
        { 
            MusicPlayerSelectsQueueEntryEvent -= value; 
            if(MusicPlayerSelectsQueueEntryEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerSelectsQueueEntry, Callable.From(_musicPlayerSelectsQueueEntryAction));
            }
        }
    }
    
    public delegate void MusicPlayerWantsLoopedEventHandler(bool looped);
    private static event MusicPlayerWantsLoopedEventHandler MusicPlayerWantsLoopedEvent;
    static Action<bool> _musicPlayerWantsLoopedAction = (looped) =>
    {
        MusicPlayerWantsLoopedEvent?.Invoke(looped);
    };
    public static event MusicPlayerWantsLoopedEventHandler MusicPlayerWantsLooped
    {
        add
        {
            if(MusicPlayerWantsLoopedEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsLooped, Callable.From(_musicPlayerWantsLoopedAction));
            }
            MusicPlayerWantsLoopedEvent += value;
        }
        remove 
        { 
            MusicPlayerWantsLoopedEvent -= value; 
            if(MusicPlayerWantsLoopedEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsLooped, Callable.From(_musicPlayerWantsLoopedAction));
            }
        }
    }
    
    public static event Action MusicPlayerWantsPauseEvent;
    static Action _musicPlayerWantsPauseAction = () =>
    {
        MusicPlayerWantsPauseEvent?.Invoke();
    };
    public static event Action MusicPlayerWantsPause
    {
        add
        {
            if(MusicPlayerWantsPauseEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsPause, Callable.From(_musicPlayerWantsPauseAction));
            }
            MusicPlayerWantsPauseEvent += value;
        }
        remove
        {
            MusicPlayerWantsPauseEvent -= value;
            if(MusicPlayerWantsPauseEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsPause, Callable.From(_musicPlayerWantsPauseAction));
            }
        }
    }
    
    public delegate void MusicPlayerWantsPlayingRepeatStatusEventHandler(long status);
    private static event MusicPlayerWantsPlayingRepeatStatusEventHandler MusicPlayerWantsPlayingRepeatStatusEvent;
    static Action<long> _musicPlayerWantsPlayingRepeatStatusAction = (status) =>
    {
        MusicPlayerWantsPlayingRepeatStatusEvent?.Invoke(status);
    };
    public static event MusicPlayerWantsPlayingRepeatStatusEventHandler MusicPlayerWantsPlayingRepeatStatus
    {
        add
        {
            if(MusicPlayerWantsPlayingRepeatStatusEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsPlayingRepeatStatus, Callable.From(_musicPlayerWantsPlayingRepeatStatusAction));
            }
            MusicPlayerWantsPlayingRepeatStatusEvent += value;
        }
        remove 
        { 
            MusicPlayerWantsPlayingRepeatStatusEvent -= value;
            if(MusicPlayerWantsPlayingRepeatStatusEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsPlayingRepeatStatus, Callable.From(_musicPlayerWantsPlayingRepeatStatusAction));
            }
        }
    }
    
    public static event Action MusicPlayerWantsPlayNextEvent;
    static Action _musicPlayerWantsPlayNextAction = () =>
    {
        MusicPlayerWantsPlayNextEvent?.Invoke();
    };
    public static event Action MusicPlayerWantsPlayNext
    {
        add
        {
            if(MusicPlayerWantsPlayNextEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsPlayNext, Callable.From(_musicPlayerWantsPlayNextAction));
            }
            MusicPlayerWantsPlayNextEvent += value;
        }
        remove
        {
            MusicPlayerWantsPlayNextEvent -= value;
            if(MusicPlayerWantsPlayNextEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsPlayNext, Callable.From(_musicPlayerWantsPlayNextAction));
            }
        }
    }
    
    public static event Action MusicPlayerWantsPlayPreviousEvent;
    static Action _musicPlayerWantsPlayPreviousAction = () =>
    {
        MusicPlayerWantsPlayPreviousEvent?.Invoke();
    };
    public static event Action MusicPlayerWantsPlayPrevious
    {
        add
        {
            if(MusicPlayerWantsPlayPreviousEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsPlayPrevious, Callable.From(_musicPlayerWantsPlayPreviousAction));
            }
            MusicPlayerWantsPlayPreviousEvent += value;
        }
        remove
        {
            MusicPlayerWantsPlayPreviousEvent -= value;
            if(MusicPlayerWantsPlayPreviousEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsPlayPrevious, Callable.From(_musicPlayerWantsPlayPreviousAction));
            }
        }
    }
    
    public static event Action MusicPlayerWantsPlayEvent;
    static Action _musicPlayerWantsPlayAction = () =>
    {
        MusicPlayerWantsPlayEvent?.Invoke();
    };
    public static event Action MusicPlayerWantsPlay
    {
        add
        {
            if(MusicPlayerWantsPlayEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsPlay, Callable.From(_musicPlayerWantsPlayAction));
            }
            MusicPlayerWantsPlayEvent += value;
        }
        remove
        {
            MusicPlayerWantsPlayEvent -= value;
            if(MusicPlayerWantsPlayEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsPlay, Callable.From(_musicPlayerWantsPlayAction));
            }
        }
    }
    
    public delegate void MusicPlayerWantsShuffledEventHandler(bool shuffled);
    private static event MusicPlayerWantsShuffledEventHandler MusicPlayerWantsShuffledEvent;
    static Action<bool> _musicPlayerWantsShuffledAction = (shuffled) =>
    {
        MusicPlayerWantsShuffledEvent?.Invoke(shuffled);
    };
    public static event MusicPlayerWantsShuffledEventHandler MusicPlayerWantsShuffled
    {
        add
        {
            if(MusicPlayerWantsShuffledEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsShuffled, Callable.From(_musicPlayerWantsShuffledAction));
            }
            MusicPlayerWantsShuffledEvent += value;
        }
        remove 
        { 
            MusicPlayerWantsShuffledEvent -= value;
            if(MusicPlayerWantsShuffledEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsShuffled, Callable.From(_musicPlayerWantsShuffledAction));
            }
        }
    }
    
    public delegate void MusicPlayerWantsVolumeEventHandler(double volume);
    private static event MusicPlayerWantsVolumeEventHandler MusicPlayerWantsVolumeEvent;
    static Action<double> _musicPlayerWantsVolumeAction = (volume) =>
    {
        MusicPlayerWantsVolumeEvent?.Invoke(volume);
    };
    public static event MusicPlayerWantsVolumeEventHandler MusicPlayerWantsVolume
    {
        add
        {
            if(MusicPlayerWantsVolumeEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWantsVolume, Callable.From(_musicPlayerWantsVolumeAction));
            }
            MusicPlayerWantsVolumeEvent += value;
        }
        remove 
        { 
            MusicPlayerWantsVolumeEvent -= value; 
            if(MusicPlayerWantsVolumeEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWantsVolume, Callable.From(_musicPlayerWantsVolumeAction));
            }
        }
    }
    
    public static event Action MusicPlayerWillQuitEvent;
    static Action _musicPlayerWillQuitAction = () =>
    {
        MusicPlayerWillQuitEvent?.Invoke();
    };
    public static event Action MusicPlayerWillQuit
    {
        add
        {
            if(MusicPlayerWillQuitEvent == null)
            {
                GetInstance().Connect(Signals.MusicPlayerWillQuit, Callable.From(_musicPlayerWillQuitAction));
            }
            MusicPlayerWillQuitEvent += value;
        }
        remove
        {
            MusicPlayerWillQuitEvent -= value;
            if(MusicPlayerWillQuitEvent == null)
            {
                GetInstance().Disconnect(Signals.MusicPlayerWillQuit, Callable.From(_musicPlayerWillQuitAction));
            }
        }
    }
}