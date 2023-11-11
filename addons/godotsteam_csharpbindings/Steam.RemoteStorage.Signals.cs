using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The file read async complete event handler
    /// </summary>
    public delegate void FileReadAsyncCompleteEventHandler(Godot.Collections.Dictionary fileRead);
    private static event FileReadAsyncCompleteEventHandler FileReadAsyncCompleteEvent;
    /// <summary>
    /// The file read
    /// </summary>
    static Action<Godot.Collections.Dictionary> _fileReadAsyncCompleteAction = (fileRead) =>
    {
        FileReadAsyncCompleteEvent?.Invoke(fileRead);
    };
    /// <summary>
    /// The file read async complete
    /// </summary>
    public static event FileReadAsyncCompleteEventHandler FileReadAsyncComplete
    {
        add
        {
            if(FileReadAsyncCompleteEvent == null)
            {
                GetInstance().Connect(Signals.FileReadAsyncComplete, Callable.From(_fileReadAsyncCompleteAction));
            }
            FileReadAsyncCompleteEvent += value;
        }
        remove
        {
            FileReadAsyncCompleteEvent -= value;
            if(FileReadAsyncCompleteEvent == null)
            {
                GetInstance().Disconnect(Signals.FileReadAsyncComplete, Callable.From(_fileReadAsyncCompleteAction));
            }
        }
    }
    
    /// <summary>
    /// The file share result event handler
    /// </summary>
    public delegate void FileShareResultEventHandler(long result, long handle, string name);
    private static event FileShareResultEventHandler FileShareResultEvent;
    /// <summary>
    /// The name
    /// </summary>
    static Action<long, long, string> _fileShareResultAction = (result, handle, name) =>
    {
        FileShareResultEvent?.Invoke(result, handle, name);
    };
    /// <summary>
    /// The file share result
    /// </summary>
    public static event FileShareResultEventHandler FileShareResult
    {
        add
        {
            if(FileShareResultEvent == null)
            {
                GetInstance().Connect(Signals.FileShareResult, Callable.From(_fileShareResultAction));
            }
            FileShareResultEvent += value;
        }
        remove
        {
            FileShareResultEvent -= value;
            if(FileShareResultEvent == null)
            {
                GetInstance().Disconnect(Signals.FileShareResult, Callable.From(_fileShareResultAction));
            }
        }
    }
    
    /// <summary>
    /// The file write async complete event handler
    /// </summary>
    public delegate void FileWriteAsyncCompleteEventHandler(long result);
    private static event FileWriteAsyncCompleteEventHandler FileWriteAsyncCompleteEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long> _fileWriteAsyncCompleteAction = (result) =>
    {
        FileWriteAsyncCompleteEvent?.Invoke(result);
    };
    /// <summary>
    /// The file write async complete
    /// </summary>
    public static event FileWriteAsyncCompleteEventHandler FileWriteAsyncComplete
    {
        add
        {
            if(FileWriteAsyncCompleteEvent == null)
            {
                GetInstance().Connect(Signals.FileWriteAsyncComplete, Callable.From(_fileWriteAsyncCompleteAction));
            }
            FileWriteAsyncCompleteEvent += value;
        }
        remove
        {
            FileWriteAsyncCompleteEvent -= value;
            if(FileWriteAsyncCompleteEvent == null)
            {
                GetInstance().Disconnect(Signals.FileWriteAsyncComplete, Callable.From(_fileWriteAsyncCompleteAction));
            }
        }
    }
    
    /// <summary>
    /// The download ugc result event handler
    /// </summary>
    public delegate void DownloadUgcResultEventHandler(long result, Godot.Collections.Dictionary downloadData);
    private static event DownloadUgcResultEventHandler DownloadUgcResultEvent;
    /// <summary>
    /// The download data
    /// </summary>
    static Action<long, Godot.Collections.Dictionary> _downloadUgcResultAction = (result, downloadData) => 
    {
        DownloadUgcResultEvent?.Invoke(result, downloadData);
    };
    /// <summary>
    /// The download ugc result
    /// </summary>
    public static event DownloadUgcResultEventHandler DownloadUgcResult
    {
        add
        {
            if(DownloadUgcResultEvent == null)
            {
                GetInstance().Connect(Signals.DownloadUgcResult, Callable.From(_downloadUgcResultAction));
            }
            DownloadUgcResultEvent += value;
        }
        remove
        {
            DownloadUgcResultEvent -= value;
            if(DownloadUgcResultEvent == null)
            {
                GetInstance().Disconnect(Signals.DownloadUgcResult, Callable.From(_downloadUgcResultAction));
            }
        }
    }
    
    /// <summary>
    /// The unsubscribe item signal event handler
    /// </summary>
    public delegate void UnsubscribeItemSignalEventHandler(long result, long fileId);
    private static event UnsubscribeItemSignalEventHandler UnsubscribeItemSignalEvent;
    /// <summary>
    /// The file id
    /// </summary>
    static Action<long, long> _unsubscribeItemSignalAction = (result, fileId) =>
    {
        UnsubscribeItemSignalEvent?.Invoke(result, fileId);
    };
    /// <summary>
    /// The unsubscribe item signal
    /// </summary>
    public static event UnsubscribeItemSignalEventHandler UnsubscribeItemSignal
    {
        add
        {
            if(UnsubscribeItemSignalEvent == null)
            {
                GetInstance().Connect(Signals.UnsubscribeItemSignal, Callable.From(_unsubscribeItemSignalAction));
            }
            UnsubscribeItemSignalEvent += value;
        }
        remove
        {
            UnsubscribeItemSignalEvent -= value;
            if(UnsubscribeItemSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.UnsubscribeItemSignal, Callable.From(_unsubscribeItemSignalAction));
            }
        }
    }
    
    /// <summary>
    /// The subscribe item signal event handler
    /// </summary>
    public delegate void SubscribeItemSignalEventHandler(long result, long fileId);
    private static event SubscribeItemSignalEventHandler SubscribeItemSignalEvent;
    /// <summary>
    /// The file id
    /// </summary>
    static Action<long, long> _subscribeItemSignalAction = (result, fileId) =>
    {
        SubscribeItemSignalEvent?.Invoke(result, fileId);
    };
    /// <summary>
    /// The subscribe item signal
    /// </summary>
    public static event SubscribeItemSignalEventHandler SubscribeItemSignal
    {
        add
        {
            if(SubscribeItemSignalEvent == null)
            {
                GetInstance().Connect(Signals.SubscribeItemSignal, Callable.From(_subscribeItemSignalAction));
            }
            SubscribeItemSignalEvent += value;
        }
        remove
        {
            SubscribeItemSignalEvent -= value;
            if(SubscribeItemSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.SubscribeItemSignal, Callable.From(_subscribeItemSignalAction));
            }
        }
    }
    
    private static event Action LocalFileChangedEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _localFileChangedAction = () =>
    {
        LocalFileChangedEvent?.Invoke();
    };
    /// <summary>
    /// The local file changed
    /// </summary>
    public static event Action LocalFileChanged
    {
        add
        {
            if(LocalFileChangedEvent == null)
            {
                GetInstance().Connect(Signals.LocalFileChanged, Callable.From(_localFileChangedAction));
            }
            LocalFileChangedEvent += value;
        }
        remove
        {
            LocalFileChangedEvent -= value;
            if(LocalFileChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.LocalFileChanged, Callable.From(_localFileChangedAction));
            }
        }
    }
}