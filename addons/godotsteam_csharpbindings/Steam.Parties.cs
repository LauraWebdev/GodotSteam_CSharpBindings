namespace GodotSteam;

public static partial class Steam
{
    public static void CancelReservation(ulong beaconId, long steamId)
    {
        GetInstance().Call(Methods.CancelReservation, beaconId, steamId);
    }
    
    public static void ChangeNumOpenSlots(ulong beaconId, long openSlots)
    {
        GetInstance().Call(Methods.ChangeNumOpenSlots, beaconId, openSlots);
    }
    
    public static void CreateBeacon(uint openSlots, ulong locationId, PartyBeaconLocationType type, string connectString, string beaconMetadata)
    {
        GetInstance().Call(Methods.CreateBeacon, openSlots, locationId, (long)type, connectString, beaconMetadata);
    }
    
    public static bool DestroyBeacon(long beaconId)
    {
        return GetInstance().Call(Methods.DestroyBeacon, beaconId).AsBool();
    }
    
    public static Godot.Collections.Array GetAvailableBeaconLocations(long max)
    {
        return GetInstance().Call(Methods.GetAvailableBeaconLocations, max).AsGodotArray();
    }
    
    public static ulong GetBeaconByIndex(long index)
    {
        return GetInstance().Call(Methods.GetBeaconByIndex, index).AsUInt64();
    }
    
    public static Godot.Collections.Dictionary GetBeaconDetails(long beaconId)
    {
        return GetInstance().Call(Methods.GetBeaconDetails, beaconId).AsGodotDictionary();
    }
    
    public static string GetBeaconLocationData(ulong locationId, PartyBeaconLocationType locationType, PartyBeaconLocationData locationData)
    {
        return GetInstance().Call(Methods.GetBeaconLocationData, locationId, (long)locationType, (long)locationData).AsString();
    }
    
    public static long GetNumActiveBeacons()
    {
        return GetInstance().Call(Methods.GetNumActiveBeacons).AsInt64();
    }
    
    public static void JoinParty(long beaconId)
    {
        GetInstance().Call(Methods.JoinParty, beaconId);
    }
    
    public static void OnReservationCompleted(ulong beaconId, long steamId)
    {
        GetInstance().Call(Methods.OnReservationCompleted, beaconId, steamId);
    }

    public enum PartyBeaconLocationData : long
    {
        Data = 0,
        DataName = 1,
        DataUrlSmall = 2,
        DataUrlMedium = 3,
        DataUrlLarge = 4
    }

    public enum PartyBeaconLocationType : long
    {
        LocationtypeInvalid = 0,
        LocationtypeChatGroup = 1,
        LocationTypeMax = 2
    }
}