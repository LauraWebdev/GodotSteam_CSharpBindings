namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether check ping data up to date
    /// </summary>
    /// <param name="maxAgeInSeconds">The max age in seconds</param>
    /// <returns>The bool</returns>
    public static bool CheckPingDataUpToDate(double maxAgeInSeconds)
    {
        return GetInstance().Call(Methods.CheckPingDataUpToDate, maxAgeInSeconds).AsBool();
    }
    
    /// <summary>
    /// Converts the ping location to string using the specified location
    /// </summary>
    /// <param name="location">The location</param>
    /// <returns>The string</returns>
    public static string ConvertPingLocationToString(byte[] location)
    {
        return GetInstance().Call(Methods.ConvertPingLocationToString, location).AsString();
    }
    
    /// <summary>
    /// Estimates the ping time between two locations using the specified location 1
    /// </summary>
    /// <param name="location1">The location</param>
    /// <param name="location2">The location</param>
    /// <returns>The int</returns>
    public static int EstimatePingTimeBetweenTwoLocations(byte[] location1, byte[] location2)
    {
        return GetInstance().Call(Methods.EstimatePingTimeBetweenTwoLocations, location1, location2).AsInt32();
    }
    
    /// <summary>
    /// Estimates the ping time from local host using the specified location
    /// </summary>
    /// <param name="location">The location</param>
    /// <returns>The int</returns>
    public static int EstimatePingTimeFromLocalHost(byte[] location)
    {
        return GetInstance().Call(Methods.EstimatePingTimeFromLocalHost, location).AsInt32();
    }
    
    /// <summary>
    /// Gets the config value using the specified config value
    /// </summary>
    /// <param name="configValue">The config value</param>
    /// <param name="scopeType">The scope type</param>
    /// <param name="connectionHandle">The connection handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetConfigValue(NetworkingConfigValue configValue, NetworkingConfigScope scopeType, long connectionHandle)
    {
        return GetInstance().Call(Methods.GetConfigValue, (long)configValue, (long)scopeType, connectionHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the config value info using the specified config value
    /// </summary>
    /// <param name="configValue">The config value</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetConfigValueInfo(NetworkingConfigValue configValue)
    {
        return GetInstance().Call(Methods.GetConfigValueInfo, (long)configValue).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the direct ping to pop using the specified pop id
    /// </summary>
    /// <param name="popId">The pop id</param>
    /// <returns>The int</returns>
    public static int GetDirectPingToPOP(long popId)
    {
        return GetInstance().Call(Methods.GetDirectPingToPOP, popId).AsInt32();
    }
    
    /// <summary>
    /// Gets the local ping location
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetLocalPingLocation()
    {
        return GetInstance().Call(Methods.GetLocalPingLocation).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the local timestamp
    /// </summary>
    /// <returns>The long</returns>
    public static long GetLocalTimestamp()
    {
        return GetInstance().Call(Methods.GetLocalTimestamp).AsInt64();
    }
    
    /// <summary>
    /// Gets the ping to data center using the specified pop id
    /// </summary>
    /// <param name="popId">The pop id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetPingToDataCenter(long popId)
    {
        return GetInstance().Call(Methods.GetPingToDataCenter, popId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the pop count
    /// </summary>
    /// <returns>The long</returns>
    public static long GetPOPCount()
    {
        return GetInstance().Call(Methods.GetPOPCount).AsInt64();
    }
    
    /// <summary>
    /// Gets the pop list
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetPOPList()
    {
        return GetInstance().Call(Methods.GetPOPList).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the relay network status
    /// </summary>
    /// <returns>The networking availability</returns>
    public static NetworkingAvailability GetRelayNetworkStatus()
    {
        return (NetworkingAvailability)GetInstance().Call(Methods.GetRelayNetworkStatus).AsInt64();
    }
    
    /// <summary>
    /// Inits the relay network access
    /// </summary>
    public static void InitRelayNetworkAccess()
    {
        GetInstance().Call(Methods.InitRelayNetworkAccess);
    }
    
    /// <summary>
    /// Parses the ping location string using the specified string
    /// </summary>
    /// <param name="@string">The string</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary ParsePingLocationString(string @string)
    {
        return GetInstance().Call(Methods.ParsePingLocationString, @string).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether set connection config value float
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <param name="config">The config</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetConnectionConfigValueFloat(uint connection, NetworkingConfigValue config, double value)
    {
        return GetInstance().Call(Methods.SetConnectionConfigValueFloat, connection, (long)config, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set connection config value int 32
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <param name="config">The config</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetConnectionConfigValueInt32(uint connection, NetworkingConfigValue config, long value)
    {
        return GetInstance().Call(Methods.SetConnectionConfigValueInt32, connection, (long)config, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set connection config value string
    /// </summary>
    /// <param name="connection">The connection</param>
    /// <param name="config">The config</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetConnectionConfigValueString(uint connection, NetworkingConfigValue config, string value)
    {
        return GetInstance().Call(Methods.SetConnectionConfigValueString, connection, (long)config, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set global config value float
    /// </summary>
    /// <param name="config">The config</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetGlobalConfigValueFloat(NetworkingConfigValue config, double value)
    {
        return GetInstance().Call(Methods.SetGlobalConfigValueFloat, (long)config, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set global config value int 32
    /// </summary>
    /// <param name="config">The config</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetGlobalConfigValueInt32(NetworkingConfigValue config, long value)
    {
        return GetInstance().Call(Methods.SetGlobalConfigValueInt32, (long)config, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether set global config value string
    /// </summary>
    /// <param name="config">The config</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool SetGlobalConfigValueString(NetworkingConfigValue config, string value)
    {
        return GetInstance().Call(Methods.SetGlobalConfigValueString, (long)config, value).AsBool();
    }
    
    /// <summary>
    /// The networking availability enum
    /// </summary>
    public enum NetworkingAvailability : long
    {
        /// <summary>
        /// The cannot try networking availability
        /// </summary>
        CannotTry = -102,
        /// <summary>
        /// The failed networking availability
        /// </summary>
        Failed = -101,
        /// <summary>
        /// The previously networking availability
        /// </summary>
        Previously = -100,
        /// <summary>
        /// The retrying networking availability
        /// </summary>
        Retrying = -10,
        /// <summary>
        /// The never tried networking availability
        /// </summary>
        NeverTried = 1,
        /// <summary>
        /// The waiting networking availability
        /// </summary>
        Waiting = 2,
        /// <summary>
        /// The attempting networking availability
        /// </summary>
        Attempting = 3,
        /// <summary>
        /// The current networking availability
        /// </summary>
        Current = 100,
        /// <summary>
        /// The unknown networking availability
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The force 32 bit networking availability
        /// </summary>
        Force32Bit = 2147483647
    }

    /// <summary>
    /// The networking config data type enum
    /// </summary>
    public enum NetworkingConfigDataType : long
    {
        /// <summary>
        /// The networking config type int 32 networking config data type
        /// </summary>
        NetworkingConfigTypeInt32 = 1,
        /// <summary>
        /// The networking config type int 64 networking config data type
        /// </summary>
        NetworkingConfigTypeInt64 = 2,
        /// <summary>
        /// The networking config type float networking config data type
        /// </summary>
        NetworkingConfigTypeFloat = 3,
        /// <summary>
        /// The etworking config type string networking config data type
        /// </summary>
        EtworkingConfigTypeString = 4,
        /// <summary>
        /// The networking config type function ptr networking config data type
        /// </summary>
        NetworkingConfigTypeFunctionPtr = 5,
        /// <summary>
        /// The networking config type force 32 bit networking config data type
        /// </summary>
        NetworkingConfigTypeForce32Bit = 2147483647
    }

    /// <summary>
    /// The networking config scope enum
    /// </summary>
    public enum NetworkingConfigScope : long
    {
        /// <summary>
        /// The global networking config scope
        /// </summary>
        Global = 1,
        /// <summary>
        /// The sockets interface networking config scope
        /// </summary>
        SocketsInterface = 2,
        /// <summary>
        /// The listen socket networking config scope
        /// </summary>
        ListenSocket = 3,
        /// <summary>
        /// The connection networking config scope
        /// </summary>
        Connection = 4,
        /// <summary>
        /// The force 32 bit networking config scope
        /// </summary>
        Force32Bit = 2147483647
    }
}