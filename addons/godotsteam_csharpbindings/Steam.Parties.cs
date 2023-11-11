namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Cancels the reservation using the specified beacon id
    /// </summary>
    /// <param name="beaconId">The beacon id</param>
    /// <param name="steamId">The steam id</param>
    public static void CancelReservation(ulong beaconId, ulong steamId)
    {
        GetInstance().Call(Methods.CancelReservation, beaconId, steamId);
    }
    
    /// <summary>
    /// Changes the num open slots using the specified beacon id
    /// </summary>
    /// <param name="beaconId">The beacon id</param>
    /// <param name="openSlots">The open slots</param>
    public static void ChangeNumOpenSlots(ulong beaconId, long openSlots)
    {
        GetInstance().Call(Methods.ChangeNumOpenSlots, beaconId, openSlots);
    }
    
    /// <summary>
    /// Creates the beacon using the specified open slots
    /// </summary>
    /// <param name="openSlots">The open slots</param>
    /// <param name="locationId">The location id</param>
    /// <param name="type">The type</param>
    /// <param name="connectString">The connect string</param>
    /// <param name="beaconMetadata">The beacon metadata</param>
    public static void CreateBeacon(uint openSlots, ulong locationId, PartyBeaconLocationType type, string connectString, string beaconMetadata)
    {
        GetInstance().Call(Methods.CreateBeacon, openSlots, locationId, (long)type, connectString, beaconMetadata);
    }
    
    /// <summary>
    /// Describes whether destroy beacon
    /// </summary>
    /// <param name="beaconId">The beacon id</param>
    /// <returns>The bool</returns>
    public static bool DestroyBeacon(long beaconId)
    {
        return GetInstance().Call(Methods.DestroyBeacon, beaconId).AsBool();
    }
    
    /// <summary>
    /// Gets the available beacon locations using the specified max
    /// </summary>
    /// <param name="max">The max</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetAvailableBeaconLocations(long max)
    {
        return GetInstance().Call(Methods.GetAvailableBeaconLocations, max).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the beacon by index using the specified index
    /// </summary>
    /// <param name="index">The index</param>
    /// <returns>The ulong</returns>
    public static ulong GetBeaconByIndex(long index)
    {
        return GetInstance().Call(Methods.GetBeaconByIndex, index).AsUInt64();
    }
    
    /// <summary>
    /// Gets the beacon details using the specified beacon id
    /// </summary>
    /// <param name="beaconId">The beacon id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetBeaconDetails(long beaconId)
    {
        return GetInstance().Call(Methods.GetBeaconDetails, beaconId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the beacon location data using the specified location id
    /// </summary>
    /// <param name="locationId">The location id</param>
    /// <param name="locationType">The location type</param>
    /// <param name="locationData">The location data</param>
    /// <returns>The string</returns>
    public static string GetBeaconLocationData(ulong locationId, PartyBeaconLocationType locationType, PartyBeaconLocationData locationData)
    {
        return GetInstance().Call(Methods.GetBeaconLocationData, locationId, (long)locationType, (long)locationData).AsString();
    }
    
    /// <summary>
    /// Gets the num active beacons
    /// </summary>
    /// <returns>The long</returns>
    public static long GetNumActiveBeacons()
    {
        return GetInstance().Call(Methods.GetNumActiveBeacons).AsInt64();
    }
    
    /// <summary>
    /// Joins the party using the specified beacon id
    /// </summary>
    /// <param name="beaconId">The beacon id</param>
    public static void JoinParty(long beaconId)
    {
        GetInstance().Call(Methods.JoinParty, beaconId);
    }
    
    /// <summary>
    /// Ons the reservation completed using the specified beacon id
    /// </summary>
    /// <param name="beaconId">The beacon id</param>
    /// <param name="steamId">The steam id</param>
    public static void OnReservationCompleted(ulong beaconId, ulong steamId)
    {
        GetInstance().Call(Methods.OnReservationCompleted, beaconId, steamId);
    }

    /// <summary>
    /// The party beacon location data enum
    /// </summary>
    public enum PartyBeaconLocationData : long
    {
        /// <summary>
        /// The data party beacon location data
        /// </summary>
        Data = 0,
        /// <summary>
        /// The data name party beacon location data
        /// </summary>
        DataName = 1,
        /// <summary>
        /// The data url small party beacon location data
        /// </summary>
        DataUrlSmall = 2,
        /// <summary>
        /// The data url medium party beacon location data
        /// </summary>
        DataUrlMedium = 3,
        /// <summary>
        /// The data url large party beacon location data
        /// </summary>
        DataUrlLarge = 4
    }

    /// <summary>
    /// The party beacon location type enum
    /// </summary>
    public enum PartyBeaconLocationType : long
    {
        /// <summary>
        /// The locationtype invalid party beacon location type
        /// </summary>
        LocationtypeInvalid = 0,
        /// <summary>
        /// The locationtype chat group party beacon location type
        /// </summary>
        LocationtypeChatGroup = 1,
        /// <summary>
        /// The location type max party beacon location type
        /// </summary>
        LocationTypeMax = 2
    }
}