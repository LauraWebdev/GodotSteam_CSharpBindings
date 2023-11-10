using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void JoinPartySignalEventHandler(long result, long beaconId, ulong steamId, string connectString);
    private static event JoinPartySignalEventHandler JoinPartySignalEvent;
    static Action<long, long, ulong, string> _joinPartySignalAction = (result, beaconId, steamId, connectString) =>
    {
        JoinPartySignalEvent?.Invoke(result, beaconId, steamId, connectString);
    };
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
    
    public delegate void CreateBeaconSignalEventHandler(long result, long beaconId);
    private static event CreateBeaconSignalEventHandler CreateBeaconSignalEvent;
    static Action<long, long> _createBeaconSignalAction = (result, beaconId) =>
    {
        CreateBeaconSignalEvent?.Invoke(result, beaconId);
    };
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
    
    public delegate void ReservationNotificationEventHandler(long beaconId, ulong steamId);
    private static event ReservationNotificationEventHandler ReservationNotificationEvent;
    static Action<long, ulong> _reservationNotificationAction = (beaconId, steamId) =>
    {
        ReservationNotificationEvent?.Invoke(beaconId, steamId);
    };
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
    
    public delegate void ChangeNumOpenSlotsSignalEventHandler(long result);
    private static event ChangeNumOpenSlotsSignalEventHandler ChangeNumOpenSlotsSignalEvent;
    static Action<long> _changeNumOpenSlotsSignalAction = (result) =>
    {
        ChangeNumOpenSlotsSignalEvent?.Invoke(result);
    };
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
    static Action _availableBeaconLocationsUpdatedAction = () =>
    {
        AvailableBeaconLocationsUpdatedEvent?.Invoke();
    };
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
    static Action _activeBeaconsUpdatedAction = () =>
    {
        ActiveBeaconsUpdatedEvent?.Invoke();
    };
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