using System;
using Godot;

namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// The join party signal event handler
    /// </summary>
    public delegate void JoinPartySignalEventHandler(long result, long beaconId, ulong steamId, string connectString);
    private static event JoinPartySignalEventHandler JoinPartySignalEvent;
    /// <summary>
    /// The connect string
    /// </summary>
    static Action<long, long, ulong, string> _joinPartySignalAction = (result, beaconId, steamId, connectString) =>
    {
        JoinPartySignalEvent?.Invoke(result, beaconId, steamId, connectString);
    };
    /// <summary>
    /// The join party signal
    /// </summary>
    public static event JoinPartySignalEventHandler JoinPartySignal
    {
        add
        {
            if(JoinPartySignalEvent == null)
            {
                GetInstance().Connect(Signals.JoinPartySignal, Callable.From(_joinPartySignalAction));
            }
            
            JoinPartySignalEvent += value;
        }
        remove 
        { 
            JoinPartySignalEvent -= value; 
            
            if(JoinPartySignalEvent == null)
            {
                GetInstance().Disconnect(Signals.JoinPartySignal, Callable.From(_joinPartySignalAction));
            }
        }
    }
    
    /// <summary>
    /// The create beacon signal event handler
    /// </summary>
    public delegate void CreateBeaconSignalEventHandler(long result, long beaconId);
    private static event CreateBeaconSignalEventHandler CreateBeaconSignalEvent;
    /// <summary>
    /// The beacon id
    /// </summary>
    static Action<long, long> _createBeaconSignalAction = (result, beaconId) =>
    {
        CreateBeaconSignalEvent?.Invoke(result, beaconId);
    };
    /// <summary>
    /// The create beacon signal
    /// </summary>
    public static event CreateBeaconSignalEventHandler CreateBeaconSignal
    {
        add
        {
            if(CreateBeaconSignalEvent == null)
            {
                GetInstance().Connect(Signals.CreateBeaconSignal, Callable.From(_createBeaconSignalAction));
            }
            
            CreateBeaconSignalEvent += value;
        }
        remove 
        { 
            CreateBeaconSignalEvent -= value; 
            
            if(CreateBeaconSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.CreateBeaconSignal, Callable.From(_createBeaconSignalAction));
            }
        }
    }
    
    /// <summary>
    /// The reservation notification event handler
    /// </summary>
    public delegate void ReservationNotificationEventHandler(long beaconId, ulong steamId);
    private static event ReservationNotificationEventHandler ReservationNotificationEvent;
    /// <summary>
    /// The steam id
    /// </summary>
    static Action<long, ulong> _reservationNotificationAction = (beaconId, steamId) =>
    {
        ReservationNotificationEvent?.Invoke(beaconId, steamId);
    };
    /// <summary>
    /// The reservation notification
    /// </summary>
    public static event ReservationNotificationEventHandler ReservationNotification
    {
        add
        {
            if(ReservationNotificationEvent == null)
            {
                GetInstance().Connect(Signals.ReservationNotification, Callable.From(_reservationNotificationAction));
            }
            
            ReservationNotificationEvent += value;
        }
        remove 
        { 
            ReservationNotificationEvent -= value; 
            
            if(ReservationNotificationEvent == null)
            {
                GetInstance().Disconnect(Signals.ReservationNotification, Callable.From(_reservationNotificationAction));
            }
        }
    }
    
    /// <summary>
    /// The change num open slots signal event handler
    /// </summary>
    public delegate void ChangeNumOpenSlotsSignalEventHandler(long result);
    private static event ChangeNumOpenSlotsSignalEventHandler ChangeNumOpenSlotsSignalEvent;
    /// <summary>
    /// The result
    /// </summary>
    static Action<long> _changeNumOpenSlotsSignalAction = (result) =>
    {
        ChangeNumOpenSlotsSignalEvent?.Invoke(result);
    };
    /// <summary>
    /// The change num open slots signal
    /// </summary>
    public static event ChangeNumOpenSlotsSignalEventHandler ChangeNumOpenSlotsSignal
    {
        add
        {
            if(ChangeNumOpenSlotsSignalEvent == null)
            {
                GetInstance().Connect(Signals.ChangeNumOpenSlotsSignal, Callable.From(_changeNumOpenSlotsSignalAction));
            }
            
            ChangeNumOpenSlotsSignalEvent += value;
        }
        remove 
        { 
            ChangeNumOpenSlotsSignalEvent -= value; 
            
            if(ChangeNumOpenSlotsSignalEvent == null)
            {
                GetInstance().Disconnect(Signals.ChangeNumOpenSlotsSignal, Callable.From(_changeNumOpenSlotsSignalAction));
            }
        }
    }
    
    private static event Action AvailableBeaconLocationsUpdatedEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _availableBeaconLocationsUpdatedAction = () =>
    {
        AvailableBeaconLocationsUpdatedEvent?.Invoke();
    };
    /// <summary>
    /// The available beacon locations updated
    /// </summary>
    public static event Action AvailableBeaconLocationsUpdated
    {
        add
        {
            if(AvailableBeaconLocationsUpdatedEvent == null)
            {
                GetInstance().Connect(Signals.AvailableBeaconLocationsUpdated, Callable.From(_availableBeaconLocationsUpdatedAction));
            }
            AvailableBeaconLocationsUpdatedEvent += value;
        }
        remove
        {
            AvailableBeaconLocationsUpdatedEvent -= value;
            if(AvailableBeaconLocationsUpdatedEvent == null)
            {
                GetInstance().Disconnect(Signals.AvailableBeaconLocationsUpdated, Callable.From(_availableBeaconLocationsUpdatedAction));
            }
        }
    }
    
    private static event Action ActiveBeaconsUpdatedEvent;
    /// <summary>
    /// The invoke
    /// </summary>
    static Action _activeBeaconsUpdatedAction = () =>
    {
        ActiveBeaconsUpdatedEvent?.Invoke();
    };
    /// <summary>
    /// The active beacons updated
    /// </summary>
    public static event Action ActiveBeaconsUpdated
    {
        add
        {
            if(ActiveBeaconsUpdatedEvent == null)
            {
                GetInstance().Connect(Signals.ActiveBeaconsUpdated, Callable.From(_activeBeaconsUpdatedAction));
            }
            
            ActiveBeaconsUpdatedEvent += value;
        }
        remove 
        { 
            ActiveBeaconsUpdatedEvent -= value; 
            
            if(ActiveBeaconsUpdatedEvent == null)
            {
                GetInstance().Disconnect(Signals.ActiveBeaconsUpdated, Callable.From(_activeBeaconsUpdatedAction));
            }
        }
    }
}