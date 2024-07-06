namespace GodotSteam;

public static partial class Steam
{
    public static bool CheckPingDataUpToDate(double maxAgeInSeconds)
    {
        return GetInstance().Call(Methods.CheckPingDataUpToDate, maxAgeInSeconds).As<bool>();
    }
    
    public static string ConvertPingLocationToString(byte[] location)
    {
        return GetInstance().Call(Methods.ConvertPingLocationToString, location).As<string>();
    }
    
    public static int EstimatePingTimeBetweenTwoLocations(byte[] location1, byte[] location2)
    {
        return GetInstance().Call(Methods.EstimatePingTimeBetweenTwoLocations, location1, location2).As<int>();
    }
    
    public static int EstimatePingTimeFromLocalHost(byte[] location)
    {
        return GetInstance().Call(Methods.EstimatePingTimeFromLocalHost, location).As<int>();
    }
    
    public static Godot.Collections.Dictionary GetConfigValue(NetworkingConfigValue configValue, NetworkingConfigScope scopeType, long connectionHandle)
    {
        return GetInstance().Call(Methods.GetConfigValue, (long)configValue, (long)scopeType, connectionHandle).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetConfigValueInfo(NetworkingConfigValue configValue)
    {
        return GetInstance().Call(Methods.GetConfigValueInfo, (long)configValue).AsGodotDictionary();
    }
    
    public static int GetDirectPingToPOP(long popId)
    {
        return GetInstance().Call(Methods.GetDirectPingToPOP, popId).As<int>();
    }
    
    public static Godot.Collections.Dictionary GetLocalPingLocation()
    {
        return GetInstance().Call(Methods.GetLocalPingLocation).AsGodotDictionary();
    }
    
    public static long GetLocalTimestamp()
    {
        return GetInstance().Call(Methods.GetLocalTimestamp).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetPingToDataCenter(long popId)
    {
        return GetInstance().Call(Methods.GetPingToDataCenter, popId).AsGodotDictionary();
    }
    
    public static long GetPOPCount()
    {
        return GetInstance().Call(Methods.GetPOPCount).AsInt64();
    }
    
    public static Godot.Collections.Array GetPOPList()
    {
        return GetInstance().Call(Methods.GetPOPList).AsGodotArray();
    }
    
    public static NetworkingAvailability GetRelayNetworkStatus()
    {
        return (NetworkingAvailability)GetInstance().Call(Methods.GetRelayNetworkStatus).AsInt64();
    }
    
    public static void InitRelayNetworkAccess()
    {
        GetInstance().Call(Methods.InitRelayNetworkAccess);
    }
    
    public static Godot.Collections.Dictionary ParsePingLocationString(string @string)
    {
        return GetInstance().Call(Methods.ParsePingLocationString, @string).AsGodotDictionary();
    }
    
    public static bool SetConnectionConfigValueFloat(uint connection, NetworkingConfigValue config, double value)
    {
        return GetInstance().Call(Methods.SetConnectionConfigValueFloat, connection, (long)config, value).As<bool>();
    }
    
    public static bool SetConnectionConfigValueInt32(uint connection, NetworkingConfigValue config, long value)
    {
        return GetInstance().Call(Methods.SetConnectionConfigValueInt32, connection, (long)config, value).As<bool>();
    }
    
    public static bool SetConnectionConfigValueString(uint connection, NetworkingConfigValue config, string value)
    {
        return GetInstance().Call(Methods.SetConnectionConfigValueString, connection, (long)config, value).As<bool>();
    }
    
    public static bool SetGlobalConfigValueFloat(NetworkingConfigValue config, double value)
    {
        return GetInstance().Call(Methods.SetGlobalConfigValueFloat, (long)config, value).As<bool>();
    }
    
    public static bool SetGlobalConfigValueInt32(NetworkingConfigValue config, long value)
    {
        return GetInstance().Call(Methods.SetGlobalConfigValueInt32, (long)config, value).As<bool>();
    }
    
    public static bool SetGlobalConfigValueString(NetworkingConfigValue config, string value)
    {
        return GetInstance().Call(Methods.SetGlobalConfigValueString, (long)config, value).As<bool>();
    }
    
    public enum NetworkingAvailability : long
    {
        CannotTry = -102,
        Failed = -101,
        Previously = -100,
        Retrying = -10,
        NeverTried = 1,
        Waiting = 2,
        Attempting = 3,
        Current = 100,
        Unknown = 0,
        Force32Bit = 2147483647
    }

    public enum NetworkingConfigDataType : long
    {
        NetworkingConfigTypeInt32 = 1,
        NetworkingConfigTypeInt64 = 2,
        NetworkingConfigTypeFloat = 3,
        EtworkingConfigTypeString = 4,
        NetworkingConfigTypeFunctionPtr = 5,
        NetworkingConfigTypeForce32Bit = 2147483647
    }

    public enum NetworkingConfigScope : long
    {
        Global = 1,
        SocketsInterface = 2,
        ListenSocket = 3,
        Connection = 4,
        Force32Bit = 2147483647
    }
}