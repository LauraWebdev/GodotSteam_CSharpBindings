using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void DurationControlEventHandler(long result, Godot.Collections.Dictionary duration);
    private static event DurationControlEventHandler DurationControlEvent;
    static Action<long, Godot.Collections.Dictionary> _durationControlAction = (result, duration) =>
    {
        DurationControlEvent?.Invoke(result, duration);
    };
    public static event DurationControlEventHandler DurationControl
    {
        add
        {
            if(DurationControlEvent == null)
            {
                GetInstance().Connect(Signals.DurationControl, Callable.From(_durationControlAction));
            }
            DurationControlEvent += value;
        }
        remove
        {
            DurationControlEvent -= value;
            if(DurationControlEvent == null)
            {
                GetInstance().Disconnect(Signals.DurationControl, Callable.From(_durationControlAction));
            }
        }
    }
    
    public delegate void ClientGameServerDenyEventHandler(uint appId, string iP, long serverPort, long secure, long reason);
    private static event ClientGameServerDenyEventHandler ClientGameServerDenyEvent;
    static Action<uint, string, long, long, long> _clientGameServerDenyAction = (appId, iP, serverPort, secure, reason) =>
    {
        ClientGameServerDenyEvent?.Invoke(appId, iP, serverPort, secure, reason);
    };
    public static event ClientGameServerDenyEventHandler ClientGameServerDeny
    {
        add
        {
            if(ClientGameServerDenyEvent == null)
            {
                GetInstance().Connect(Signals.ClientGameServerDeny, Callable.From(_clientGameServerDenyAction));
            }
            ClientGameServerDenyEvent += value;
        }
        remove
        {
            ClientGameServerDenyEvent -= value;
            if(ClientGameServerDenyEvent == null)
            {
                GetInstance().Disconnect(Signals.ClientGameServerDeny, Callable.From(_clientGameServerDenyAction));
            }
        }
    }
    
    public delegate void EncryptedAppTicketResponseEventHandler(string result);
    private static event EncryptedAppTicketResponseEventHandler EncryptedAppTicketResponseEvent;
    static Action<string> _encryptedAppTicketResponseAction = (result) =>
    {
        EncryptedAppTicketResponseEvent?.Invoke(result);
    };
    public static event EncryptedAppTicketResponseEventHandler EncryptedAppTicketResponse
    {
        add
        {
            if(EncryptedAppTicketResponseEvent == null)
            {
                GetInstance().Connect(Signals.EncryptedAppTicketResponse, Callable.From(_encryptedAppTicketResponseAction));
            }
            EncryptedAppTicketResponseEvent += value;
        }
        remove
        {
            EncryptedAppTicketResponseEvent -= value;
            if(EncryptedAppTicketResponseEvent == null)
            {
                GetInstance().Disconnect(Signals.EncryptedAppTicketResponse, Callable.From(_encryptedAppTicketResponseAction));
            }
        }
    }
    
    public delegate void GameWebCallbackEventHandler(string url);
    private static event GameWebCallbackEventHandler GameWebCallbackEvent;
    static Action<string> _gameWebCallbackAction = (url) =>
    {
        GameWebCallbackEvent?.Invoke(url);
    };
    public static event GameWebCallbackEventHandler GameWebCallback
    {
        add
        {
            if(GameWebCallbackEvent == null)
            {
                GetInstance().Connect(Signals.GameWebCallback, Callable.From(_gameWebCallbackAction));
            }
            GameWebCallbackEvent += value;
        }
        remove
        {
            GameWebCallbackEvent -= value;
            if(GameWebCallbackEvent == null)
            {
                GetInstance().Disconnect(Signals.GameWebCallback, Callable.From(_gameWebCallbackAction));
            }
        }
    }
    
    public delegate void GetAuthSessionTicketResponseEventHandler(long authTicket, long result);
    private static event GetAuthSessionTicketResponseEventHandler GetAuthSessionTicketResponseEvent;
    static Action<long, long> _getAuthSessionTicketResponseAction = (authTicket, result) =>
    {
        GetAuthSessionTicketResponseEvent?.Invoke(authTicket, result);
    };
    public static event GetAuthSessionTicketResponseEventHandler GetAuthSessionTicketResponse
    {
        add
        {
            if(GetAuthSessionTicketResponseEvent == null)
            {
                GetInstance().Connect(Signals.GetAuthSessionTicketResponse, Callable.From(_getAuthSessionTicketResponseAction));
            }
            GetAuthSessionTicketResponseEvent += value;
        }
        remove
        {
            GetAuthSessionTicketResponseEvent -= value;
            if(GetAuthSessionTicketResponseEvent == null)
            {
                GetInstance().Disconnect(Signals.GetAuthSessionTicketResponse, Callable.From(_getAuthSessionTicketResponseAction));
            }
        }
    }
    
    public delegate void GetTicketForWebApiEventHandler(long authTicket, long result, long ticketSize, Godot.Collections.Array ticketBuffer);
    private static event GetTicketForWebApiEventHandler GetTicketForWebApiEvent;
    static Action<long, long, long, Godot.Collections.Array> _getTicketForWebApiAction = (authTicket, result, ticketSize, ticketBuffer) =>
    {
        GetTicketForWebApiEvent?.Invoke(authTicket, result, ticketSize, ticketBuffer);
    };
    public static event GetTicketForWebApiEventHandler GetTicketForWebApi
    {
        add
        {
            if(GetTicketForWebApiEvent == null)
            {
                GetInstance().Connect(Signals.GetTicketForWebApi, Callable.From(_getTicketForWebApiAction));
            }
            GetTicketForWebApiEvent += value;
        }
        remove
        {
            GetTicketForWebApiEvent -= value;
            if(GetTicketForWebApiEvent == null)
            {
                GetInstance().Disconnect(Signals.GetTicketForWebApi, Callable.From(_getTicketForWebApiAction));
            }
        }
    }
    
    public delegate void IpcFailureEventHandler(long type);
    private static event IpcFailureEventHandler IpcFailureEvent;
    static Action<long> _ipcFailureAction = (type) =>
    {
        IpcFailureEvent?.Invoke(type);
    };
    public static event IpcFailureEventHandler IpcFailure
    {
        add
        {
            if(IpcFailureEvent == null)
            {
                GetInstance().Connect(Signals.IpcFailure, Callable.From(_ipcFailureAction));
            }
            IpcFailureEvent += value;
        }
        remove
        {
            IpcFailureEvent -= value;
            if(IpcFailureEvent == null)
            {
                GetInstance().Disconnect(Signals.IpcFailure, Callable.From(_ipcFailureAction));
            }
        }
    }
    
    private static event Action LicensesUpdatedEvent;
    static Action _licensesUpdatedAction = () =>
    {
        LicensesUpdatedEvent?.Invoke();
    };
    public static event Action LicensesUpdated
    {
        add
        {
            if(LicensesUpdatedEvent == null)
            {
                GetInstance().Connect(Signals.LicensesUpdated, Callable.From(_licensesUpdatedAction));
            }
            LicensesUpdatedEvent += value;
        }
        remove
        {
            LicensesUpdatedEvent -= value;
            if(LicensesUpdatedEvent == null)
            {
                GetInstance().Disconnect(Signals.LicensesUpdated, Callable.From(_licensesUpdatedAction));
            }
        }
    }
    
    public delegate void MicrotransactionAuthResponseEventHandler(uint appId, long orderId, bool authorized);
    private static event MicrotransactionAuthResponseEventHandler MicrotransactionAuthResponseEvent;
    static Action<uint, long, bool> _microtransactionAuthResponseAction = (appId, orderId, authorized) =>
    {
        MicrotransactionAuthResponseEvent?.Invoke(appId, orderId, authorized);
    };
    public static event MicrotransactionAuthResponseEventHandler MicrotransactionAuthResponse
    {
        add
        {
            if(MicrotransactionAuthResponseEvent == null)
            {
                GetInstance().Connect(Signals.MicrotransactionAuthResponse, Callable.From(_microtransactionAuthResponseAction));
            }
            MicrotransactionAuthResponseEvent += value;
        }
        remove
        {
            MicrotransactionAuthResponseEvent -= value;
            if(MicrotransactionAuthResponseEvent == null)
            {
                GetInstance().Disconnect(Signals.MicrotransactionAuthResponse, Callable.From(_microtransactionAuthResponseAction));
            }
        }
    }
    
    public delegate void SteamServerConnectFailedEventHandler(long result, bool retrying);
    private static event SteamServerConnectFailedEventHandler SteamServerConnectFailedEvent;
    static Action<long, bool> _steamServerConnectFailedAction = (result, retrying) =>
    {
        SteamServerConnectFailedEvent?.Invoke(result, retrying);
    };
    public static event SteamServerConnectFailedEventHandler SteamServerConnectFailed
    {
        add
        {
            if(SteamServerConnectFailedEvent == null)
            {
                GetInstance().Connect(Signals.SteamServerConnectFailed, Callable.From(_steamServerConnectFailedAction));
            }
            SteamServerConnectFailedEvent += value;
        }
        remove
        {
            SteamServerConnectFailedEvent -= value;
            if(SteamServerConnectFailedEvent == null)
            {
                GetInstance().Disconnect(Signals.SteamServerConnectFailed, Callable.From(_steamServerConnectFailedAction));
            }
        }
    }
    
    private static event Action SteamServerConnectedEvent;
    static Action _steamServerConnectedAction = () =>
    {
        SteamServerConnectedEvent?.Invoke();
    };
    public static event Action SteamServerConnected
    {
        add
        {
            if(SteamServerConnectedEvent == null)
            {
                GetInstance().Connect(Signals.SteamServerConnected, Callable.From(_steamServerConnectedAction));
            }
            SteamServerConnectedEvent += value;
        }
        remove
        {
            SteamServerConnectedEvent -= value;
            if(SteamServerConnectedEvent == null)
            {
                GetInstance().Disconnect(Signals.SteamServerConnected, Callable.From(_steamServerConnectedAction));
            }
        }
    }
    
    private static event Action SteamServerDisconnectedEvent;
    static Action _steamServerDisconnectedAction = () =>
    {
        SteamServerDisconnectedEvent?.Invoke();
    };
    public static event Action SteamServerDisconnected
    {
        add
        {
            if(SteamServerDisconnectedEvent == null)
            {
                GetInstance().Connect(Signals.SteamServerDisconnected, Callable.From(_steamServerDisconnectedAction));
            }
            SteamServerDisconnectedEvent += value;
        }
        remove
        {
            SteamServerDisconnectedEvent -= value;
            if(SteamServerDisconnectedEvent == null)
            {
                GetInstance().Disconnect(Signals.SteamServerDisconnected, Callable.From(_steamServerDisconnectedAction));
            }
        }
    }
    
    public delegate void StoreAuthUrlResponseEventHandler(string url);
    private static event StoreAuthUrlResponseEventHandler StoreAuthUrlResponseEvent;
    static Action<string> _storeAuthUrlResponseAction = (url) =>
    {
        StoreAuthUrlResponseEvent?.Invoke(url);
    };
    public static event StoreAuthUrlResponseEventHandler StoreAuthUrlResponse
    {
        add
        {
            if(StoreAuthUrlResponseEvent == null)
            {
                GetInstance().Connect(Signals.StoreAuthUrlResponse, Callable.From(_storeAuthUrlResponseAction));
            }
            StoreAuthUrlResponseEvent += value;
        }
        remove
        {
            StoreAuthUrlResponseEvent -= value;
            if(StoreAuthUrlResponseEvent == null)
            {
                GetInstance().Disconnect(Signals.StoreAuthUrlResponse, Callable.From(_storeAuthUrlResponseAction));
            }
        }
    }
    
    public delegate void ValidateAuthTicketResponseEventHandler(long authId, long response, long ownerId);
    private static event ValidateAuthTicketResponseEventHandler ValidateAuthTicketResponseEvent;
    static Action<long, long, long> _validateAuthTicketResponseAction = (authId, response, ownerId) =>
    {
        ValidateAuthTicketResponseEvent?.Invoke(authId, response, ownerId);
    };
    public static event ValidateAuthTicketResponseEventHandler ValidateAuthTicketResponse
    {
        add
        {
            if(ValidateAuthTicketResponseEvent == null)
            {
                GetInstance().Connect(Signals.ValidateAuthTicketResponse, Callable.From(_validateAuthTicketResponseAction));
            }
            ValidateAuthTicketResponseEvent += value;
        }
        remove
        {
            ValidateAuthTicketResponseEvent -= value;
            if(ValidateAuthTicketResponseEvent == null)
            {
                GetInstance().Disconnect(Signals.ValidateAuthTicketResponse, Callable.From(_validateAuthTicketResponseAction));
            }
        }
    }
}