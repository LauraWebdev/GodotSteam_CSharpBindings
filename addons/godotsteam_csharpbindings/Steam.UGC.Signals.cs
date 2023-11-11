using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The add app dependency result event handler
    /// </summary>
    public delegate void AddAppDependencyResultEventHandler(long result, long fileId, uint appId);
    private static event AddAppDependencyResultEventHandler AddAppDependencyResultEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<long, long, uint> _addAppDependencyResultAction = (result, fileId, appId) =>
    {
        AddAppDependencyResultEvent?.Invoke(result, fileId, appId);
    };
    /// <summary>
    /// The add app dependency result
    /// </summary>
    public static event AddAppDependencyResultEventHandler AddAppDependencyResult
    {
        add
        {
            if(AddAppDependencyResultEvent == null)
            {
                GetInstance().Connect(Signals.AddAppDependencyResult, Callable.From(_addAppDependencyResultAction));
            }
            AddAppDependencyResultEvent += value;
        }
        remove 
        { 
            AddAppDependencyResultEvent -= value; 
            if(AddAppDependencyResultEvent == null)
            {
                GetInstance().Disconnect(Signals.AddAppDependencyResult, Callable.From(_addAppDependencyResultAction));
            }
        }
    }
    
    /// <summary>
    /// The add ugc dependency result event handler
    /// </summary>
    public delegate void AddUgcDependencyResultEventHandler(long result, long fileId, long childId);
    private static event AddUgcDependencyResultEventHandler AddUgcDependencyResultEvent;
    /// <summary>
    /// The child id
    /// </summary>
    static Action<long, long, long> _addUgcDependencyResultAction = (result, fileId, childId) =>
    {
        AddUgcDependencyResultEvent?.Invoke(result, fileId, childId);
    };
    /// <summary>
    /// The add ugc dependency result
    /// </summary>
    public static event AddUgcDependencyResultEventHandler AddUgcDependencyResult
    {
        add
        {
            if(AddUgcDependencyResultEvent == null)
            {
                GetInstance().Connect(Signals.AddUgcDependencyResult, Callable.From(_addUgcDependencyResultAction));
            }
            AddUgcDependencyResultEvent += value;
        }
        remove 
        { 
            AddUgcDependencyResultEvent -= value; 
            if(AddUgcDependencyResultEvent == null)
            {
                GetInstance().Disconnect(Signals.AddUgcDependencyResult, Callable.From(_addUgcDependencyResultAction));
            }
        }
    }
    
    /// <summary>
    /// The item created event handler
    /// </summary>
    public delegate void ItemCreatedEventHandler(long result, long fileId, bool acceptTos);
    private static event ItemCreatedEventHandler ItemCreatedEvent;
    /// <summary>
    /// The accept tos
    /// </summary>
    static Action<long, long, bool> _itemCreatedAction = (result, fileId, acceptTos) =>
    {
        ItemCreatedEvent?.Invoke(result, fileId, acceptTos);
    };
    /// <summary>
    /// The item created
    /// </summary>
    public static event ItemCreatedEventHandler ItemCreated
    {
        add
        {
            if(ItemCreatedEvent == null)
            {
                GetInstance().Connect(Signals.ItemCreated, Callable.From(_itemCreatedAction));
            }
            ItemCreatedEvent += value;
        }
        remove 
        { 
            ItemCreatedEvent -= value; 
            if(ItemCreatedEvent == null)
            {
                GetInstance().Disconnect(Signals.ItemCreated, Callable.From(_itemCreatedAction));
            }
        }
    }
    
    /// <summary>
    /// The item downloaded event handler
    /// </summary>
    public delegate void ItemDownloadedEventHandler(long result, long fileId, uint appId);
    private static event ItemDownloadedEventHandler ItemDownloadedEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<long, long, uint> _itemDownloadedAction = (result, fileId, appId) =>
    {
        ItemDownloadedEvent?.Invoke(result, fileId, appId);
    };
    /// <summary>
    /// The item downloaded
    /// </summary>
    public static event ItemDownloadedEventHandler ItemDownloaded
    {
        add
        {
            if(ItemDownloadedEvent == null)
            {
                GetInstance().Connect(Signals.ItemDownloaded, Callable.From(_itemDownloadedAction));
            }
            ItemDownloadedEvent += value;
        }
        remove 
        { 
            ItemDownloadedEvent -= value; 
            if(ItemDownloadedEvent == null)
            {
                GetInstance().Disconnect(Signals.ItemDownloaded, Callable.From(_itemDownloadedAction));
            }
        }
    }
    
    /// <summary>
    /// The get app dependencies result event handler
    /// </summary>
    public delegate void GetAppDependenciesResultEventHandler(long result, long fileId, long appDependencies, long totalAppDependencies);
    private static event GetAppDependenciesResultEventHandler GetAppDependenciesResultEvent;
    /// <summary>
    /// The total app dependencies
    /// </summary>
    static Action<long, long, long, long> _getAppDependenciesResultAction = (result, fileId, appDependencies, totalAppDependencies) =>
    {
        GetAppDependenciesResultEvent?.Invoke(result, fileId, appDependencies, totalAppDependencies);
    };
    /// <summary>
    /// The get app dependencies result
    /// </summary>
    public static event GetAppDependenciesResultEventHandler GetAppDependenciesResult
    {
        add
        {
            if(GetAppDependenciesResultEvent == null)
            {
                GetInstance().Connect(Signals.GetAppDependenciesResult, Callable.From(_getAppDependenciesResultAction));
            }
            GetAppDependenciesResultEvent += value;
        }
        remove 
        { 
            GetAppDependenciesResultEvent -= value; 
            if(GetAppDependenciesResultEvent == null)
            {
                GetInstance().Disconnect(Signals.GetAppDependenciesResult, Callable.From(_getAppDependenciesResultAction));
            }
        }
    }
    
    /// <summary>
    /// The item deleted event handler
    /// </summary>
    public delegate void ItemDeletedEventHandler(long result, long fileId);
    private static event ItemDeletedEventHandler ItemDeletedEvent;
    /// <summary>
    /// The file id
    /// </summary>
    static Action<long, long> _itemDeletedAction = (result, fileId) =>
    {
        ItemDeletedEvent?.Invoke(result, fileId);
    };
    /// <summary>
    /// The item deleted
    /// </summary>
    public static event ItemDeletedEventHandler ItemDeleted
    {
        add
        {
            if(ItemDeletedEvent == null)
            {
                GetInstance().Connect(Signals.ItemDeleted, Callable.From(_itemDeletedAction));
            }
            ItemDeletedEvent += value;
        }
        remove 
        { 
            ItemDeletedEvent -= value; 
            if(ItemDeletedEvent == null)
            {
                GetInstance().Disconnect(Signals.ItemDeleted, Callable.From(_itemDeletedAction));
            }
        }
    }
    
    /// <summary>
    /// The get item vote result event handler
    /// </summary>
    public delegate void GetItemVoteResultEventHandler(long result, long fileId, bool voteUp, bool voteDown, bool voteSkipped);
    private static event GetItemVoteResultEventHandler GetItemVoteResultEvent;
    /// <summary>
    /// The vote skipped
    /// </summary>
    static Action<long, long, bool, bool, bool> _getItemVoteResultAction = (result, fileId, voteUp, voteDown, voteSkipped) =>
    {
        GetItemVoteResultEvent?.Invoke(result, fileId, voteUp, voteDown, voteSkipped);
    };
    /// <summary>
    /// The get item vote result
    /// </summary>
    public static event GetItemVoteResultEventHandler GetItemVoteResult
    {
        add
        {
            if(GetItemVoteResultEvent == null)
            {
                GetInstance().Connect(Signals.GetItemVoteResult, Callable.From(_getItemVoteResultAction));
            }
            GetItemVoteResultEvent += value;
        }
        remove 
        { 
            GetItemVoteResultEvent -= value; 
            if(GetItemVoteResultEvent == null)
            {
                GetInstance().Disconnect(Signals.GetItemVoteResult, Callable.From(_getItemVoteResultAction));
            }
        }
    }
    
    /// <summary>
    /// The item installed event handler
    /// </summary>
    public delegate void ItemInstalledEventHandler(uint appId, long fileId);
    private static event ItemInstalledEventHandler ItemInstalledEvent;
    /// <summary>
    /// The file id
    /// </summary>
    static Action<uint, long> _itemInstalledAction = (appId, fileId) =>
    {
        ItemInstalledEvent?.Invoke(appId, fileId);
    };
    /// <summary>
    /// The item installed
    /// </summary>
    public static event ItemInstalledEventHandler ItemInstalled
    {
        add
        {
            if(ItemInstalledEvent == null)
            {
                GetInstance().Connect(Signals.ItemInstalled, Callable.From(_itemInstalledAction));
            }
            ItemInstalledEvent += value;
        }
        remove 
        { 
            ItemInstalledEvent -= value; 
            if(ItemInstalledEvent == null)
            {
                GetInstance().Disconnect(Signals.ItemInstalled, Callable.From(_itemInstalledAction));
            }
        }
    }
    
    /// <summary>
    /// The remove app dependency result event handler
    /// </summary>
    public delegate void RemoveAppDependencyResultEventHandler(long result, long fileId, uint appId);
    private static event RemoveAppDependencyResultEventHandler RemoveAppDependencyResultEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<long, long, uint> _removeAppDependencyResultAction = (result, fileId, appId) =>
    {
        RemoveAppDependencyResultEvent?.Invoke(result, fileId, appId);
    };
    /// <summary>
    /// The remove app dependency result
    /// </summary>
    public static event RemoveAppDependencyResultEventHandler RemoveAppDependencyResult
    {
        add
        {
            if(RemoveAppDependencyResultEvent == null)
            {
                GetInstance().Connect(Signals.RemoveAppDependencyResult, Callable.From(_removeAppDependencyResultAction));
            }
            RemoveAppDependencyResultEvent += value;
        }
        remove 
        { 
            RemoveAppDependencyResultEvent -= value; 
            if(RemoveAppDependencyResultEvent == null)
            {
                GetInstance().Disconnect(Signals.RemoveAppDependencyResult, Callable.From(_removeAppDependencyResultAction));
            }
        }
    }
    
    /// <summary>
    /// The remove ugc dependency result event handler
    /// </summary>
    public delegate void RemoveUgcDependencyResultEventHandler(long result, long fileId, long childId);
    private static event RemoveUgcDependencyResultEventHandler RemoveUgcDependencyResultEvent;
    /// <summary>
    /// The child id
    /// </summary>
    static Action<long, long, long> _removeUgcDependencyResultAction = (result, fileId, childId) =>
    {
        RemoveUgcDependencyResultEvent?.Invoke(result, fileId, childId);
    };
    /// <summary>
    /// The remove ugc dependency result
    /// </summary>
    public static event RemoveUgcDependencyResultEventHandler RemoveUgcDependencyResult
    {
        add
        {
            if(RemoveUgcDependencyResultEvent == null)
            {
                GetInstance().Connect(Signals.RemoveUgcDependencyResult, Callable.From(_removeUgcDependencyResultAction));
            }
            RemoveUgcDependencyResultEvent += value;
        }
        remove 
        { 
            RemoveUgcDependencyResultEvent -= value; 
            if(RemoveUgcDependencyResultEvent == null)
            {
                GetInstance().Disconnect(Signals.RemoveUgcDependencyResult, Callable.From(_removeUgcDependencyResultAction));
            }
        }
    }
    
    /// <summary>
    /// The set user item vote signal event handler
    /// </summary>
    public delegate void SetUserItemVoteSignalEventHandler(long result, long fileId, bool voteUp);
    private static event SetUserItemVoteSignalEventHandler SetUserItemVoteSignalEvent;
    /// <summary>
    /// The vote up
    /// </summary>
    static Action<long, long, bool> _setUserItemVoteSignalAction = (result, fileId, voteUp) =>
    {
        SetUserItemVoteSignalEvent?.Invoke(result, fileId, voteUp);
    };
    /// <summary>
    /// The set user item vote signal
    /// </summary>
    public static event SetUserItemVoteSignalEventHandler SetUserItemVoteSignal
    {
        add
        {
            if(SetUserItemVoteSignalEvent == null)
            {
                GetInstance().Connect(Signals.SetUserItemVoteSignal, Callable.From(_setUserItemVoteSignalAction));
            }
            SetUserItemVoteSignalEvent += value;
        }
        remove 
        { 
            SetUserItemVoteSignalEvent -= value; 
            if(SetUserItemVoteSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.SetUserItemVoteSignal, Callable.From(_setUserItemVoteSignalAction));
            }
        }
    }
    
    /// <summary>
    /// The start playtime tracking signal event handler
    /// </summary>
    public delegate void StartPlaytimeTrackingSignalEventHandler(long result);
    private static event StartPlaytimeTrackingSignalEventHandler StartPlaytimeTrackingSignalEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long> _startPlaytimeTrackingSignalAction = (result) =>
    {
        StartPlaytimeTrackingSignalEvent?.Invoke(result);
    };
    /// <summary>
    /// The start playtime tracking signal
    /// </summary>
    public static event StartPlaytimeTrackingSignalEventHandler StartPlaytimeTrackingSignal
    {
        add
        {
            if(StartPlaytimeTrackingSignalEvent == null)
            {
                GetInstance().Connect(Signals.StartPlaytimeTrackingSignal, Callable.From(_startPlaytimeTrackingSignalAction));
            }
            StartPlaytimeTrackingSignalEvent += value;
        }
        remove 
        { 
            StartPlaytimeTrackingSignalEvent -= value; 
            if(StartPlaytimeTrackingSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.StartPlaytimeTrackingSignal, Callable.From(_startPlaytimeTrackingSignalAction));
            }
        }
    }
    
    /// <summary>
    /// The ugc query completed event handler
    /// </summary>
    public delegate void UgcQueryCompletedEventHandler(long handle, long result, long resultsReturned, long totalMatching, bool cached);
    private static event UgcQueryCompletedEventHandler UgcQueryCompletedEvent;
    /// <summary>
    /// The cached
    /// </summary>
    static Action<long, long, long, long, bool> _ugcQueryCompletedAction = (handle, result, resultsReturned, totalMatching, cached) =>
    {
        UgcQueryCompletedEvent?.Invoke(handle, result, resultsReturned, totalMatching, cached);
    };
    /// <summary>
    /// The ugc query completed
    /// </summary>
    public static event UgcQueryCompletedEventHandler UgcQueryCompleted
    {
        add
        {
            if(UgcQueryCompletedEvent == null)
            {
                GetInstance().Connect(Signals.UgcQueryCompleted, Callable.From(_ugcQueryCompletedAction));
            }
            UgcQueryCompletedEvent += value;
        }
        remove 
        { 
            UgcQueryCompletedEvent -= value; 
            if(UgcQueryCompletedEvent == null)
            {
                GetInstance().Disconnect(Signals.UgcQueryCompleted, Callable.From(_ugcQueryCompletedAction));
            }
        }
    }
    
    /// <summary>
    /// The stop playtime tracking signal event handler
    /// </summary>
    public delegate void StopPlaytimeTrackingSignalEventHandler(long result);
    private static event StopPlaytimeTrackingSignalEventHandler StopPlaytimeTrackingSignalEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long> _stopPlaytimeTrackingSignalAction = (result) =>
    {
        StopPlaytimeTrackingSignalEvent?.Invoke(result);
    };
    /// <summary>
    /// The stop playtime tracking signal
    /// </summary>
    public static event StopPlaytimeTrackingSignalEventHandler StopPlaytimeTrackingSignal
    {
        add
        {
            if(StopPlaytimeTrackingSignalEvent == null)
            {
                GetInstance().Connect(Signals.StopPlaytimeTrackingSignal, Callable.From(_stopPlaytimeTrackingSignalAction));
            }
            StopPlaytimeTrackingSignalEvent += value;
        }
        remove 
        { 
            StopPlaytimeTrackingSignalEvent -= value; 
            if(StopPlaytimeTrackingSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.StopPlaytimeTrackingSignal, Callable.From(_stopPlaytimeTrackingSignalAction));
            }
        }
    }
    
    /// <summary>
    /// The item updated event handler
    /// </summary>
    public delegate void ItemUpdatedEventHandler(long result, bool acceptTos);
    private static event ItemUpdatedEventHandler ItemUpdatedEvent;
    /// <summary>
    /// The accept tos
    /// </summary>
    static Action<long, bool> _itemUpdatedAction = (result, acceptTos) =>
    {
        ItemUpdatedEvent?.Invoke(result, acceptTos);
    };
    /// <summary>
    /// The item updated
    /// </summary>
    public static event ItemUpdatedEventHandler ItemUpdated
    {
        add
        {
            if(ItemUpdatedEvent == null)
            {
                GetInstance().Connect(Signals.ItemUpdated, Callable.From(_itemUpdatedAction));
            }
            ItemUpdatedEvent += value;
        }
        remove 
        { 
            ItemUpdatedEvent -= value; 
            if(ItemUpdatedEvent == null)
            {
                GetInstance().Disconnect(Signals.ItemUpdated, Callable.From(_itemUpdatedAction));
            }
        }
    }
    
    /// <summary>
    /// The user favorite items list changed event handler
    /// </summary>
    public delegate void UserFavoriteItemsListChangedEventHandler(long result, long fileId, bool wasAddRequest);
    private static event UserFavoriteItemsListChangedEventHandler UserFavoriteItemsListChangedEvent;
    /// <summary>
    /// The was add request
    /// </summary>
    static Action<long, long, bool> _userFavoriteItemsListChangedAction = (result, fileId, wasAddRequest) =>
    {
        UserFavoriteItemsListChangedEvent?.Invoke(result, fileId, wasAddRequest);
    };
    /// <summary>
    /// The user favorite items list changed
    /// </summary>
    public static event UserFavoriteItemsListChangedEventHandler UserFavoriteItemsListChanged
    {
        add
        {
            if(UserFavoriteItemsListChangedEvent == null)
            {
                GetInstance().Connect(Signals.UserFavoriteItemsListChanged, Callable.From(_userFavoriteItemsListChangedAction));
            }
            UserFavoriteItemsListChangedEvent += value;
        }
        remove 
        { 
            UserFavoriteItemsListChangedEvent -= value; 
            if(UserFavoriteItemsListChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.UserFavoriteItemsListChanged, Callable.From(_userFavoriteItemsListChangedAction));
            }
        }
    }
    
    /// <summary>
    /// The workshop eula status event handler
    /// </summary>
    public delegate void WorkshopEulaStatusEventHandler(long result, uint appId, Godot.Collections.Dictionary eulaData);
    private static event WorkshopEulaStatusEventHandler WorkshopEulaStatusEvent;
    /// <summary>
    /// The eula data
    /// </summary>
    static Action<long, uint, Godot.Collections.Dictionary> _workshopEulaStatusAction = (result, appId, eulaData) =>
    {
        WorkshopEulaStatusEvent?.Invoke(result, appId, eulaData);
    };
    /// <summary>
    /// The workshop eula status
    /// </summary>
    public static event WorkshopEulaStatusEventHandler WorkshopEulaStatus
    {
        add
        {
            if(WorkshopEulaStatusEvent == null)
            {
                GetInstance().Connect(Signals.WorkshopEulaStatus, Callable.From(_workshopEulaStatusAction));
            }
            WorkshopEulaStatusEvent += value;
        }
        remove
        {
            WorkshopEulaStatusEvent -= value;
            if(WorkshopEulaStatusEvent == null)
            {
                GetInstance().Disconnect(Signals.WorkshopEulaStatus, Callable.From(_workshopEulaStatusAction));
            }
        }
    }
    
    /// <summary>
    /// The user subscribed items list changed event handler
    /// </summary>
    public delegate void UserSubscribedItemsListChangedEventHandler(uint appId);
    private static event UserSubscribedItemsListChangedEventHandler UserSubscribedItemsListChangedEvent;
    /// <summary>
    /// The app id
    /// </summary>
    static Action<uint> _userSubscribedItemsListChangedAction = (appId) =>
    {
        UserSubscribedItemsListChangedEvent?.Invoke(appId);
    };
    /// <summary>
    /// The user subscribed items list changed
    /// </summary>
    public static event UserSubscribedItemsListChangedEventHandler UserSubscribedItemsListChanged
    {
        add
        {
            if(UserSubscribedItemsListChangedEvent == null)
            {
                GetInstance().Connect(Signals.UserSubscribedItemsListChanged, Callable.From(_userSubscribedItemsListChangedAction));
            }
            UserSubscribedItemsListChangedEvent += value;
        }
        remove
        {
            UserSubscribedItemsListChangedEvent -= value;
            if(UserSubscribedItemsListChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.UserSubscribedItemsListChanged, Callable.From(_userSubscribedItemsListChangedAction));
            }
        }
    }
}