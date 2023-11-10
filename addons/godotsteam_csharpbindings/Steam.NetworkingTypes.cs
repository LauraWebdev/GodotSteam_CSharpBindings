namespace GodotSteam;

public static partial class Steam
{
    public static bool AddIdentity(string referenceName)
    {
        return GetInstance().Call(Methods.AddIdentity, referenceName).AsBool();
    }
    
    public static bool AddIPAddress(string referenceName)
    {
        return GetInstance().Call(Methods.AddIPAddress, referenceName).AsBool();
    }
    
    public static void ClearIdentity(string referenceName)
    {
        GetInstance().Call(Methods.ClearIdentity, referenceName);
    }
    
    public static void ClearIPAddress(string referenceName)
    {
        GetInstance().Call(Methods.ClearIPAddress, referenceName);
    }
    
    public static byte GetGenericBytes(string referenceName)
    {
        return GetInstance().Call(Methods.GetGenericBytes, referenceName).AsByte();
    }
    
    public static string GetGenericString(string referenceName)
    {
        return GetInstance().Call(Methods.GetGenericString, referenceName).AsString();
    }
    
    public static Godot.Collections.Array GetIdentities()
    {
        return GetInstance().Call(Methods.GetIdentities).AsGodotArray();
    }
    
    public static uint GetIdentityIPAddr(string referenceName)
    {
        return GetInstance().Call(Methods.GetIdentityIPAddr, referenceName).AsUInt32();
    }
    
    public static uint GetIdentitySteamID(string referenceName)
    {
        return GetInstance().Call(Methods.GetIdentitySteamID, referenceName).AsUInt32();
    }
    
    public static ulong GetIdentitySteamID64(string referenceName)
    {
        return GetInstance().Call(Methods.GetIdentitySteamID64, referenceName).AsUInt64();
    }
    
    public static Godot.Collections.Array GetIPAddresses()
    {
        return GetInstance().Call(Methods.GetIPAddresses).AsGodotArray();
    }
    
    public static uint GetIPv4(string referenceName)
    {
        return GetInstance().Call(Methods.GetIPv4, referenceName).AsUInt32();
    }
    
    public static ulong GetPSNID(string referenceName)
    {
        return GetInstance().Call(Methods.GetPSNID, referenceName).AsUInt64();
    }
    
    public static ulong GetStadiaID(string referenceName)
    {
        return GetInstance().Call(Methods.GetStadiaID, referenceName).AsUInt64();
    }
    
    public static string GetXboxPairwiseID(string referenceName)
    {
        return GetInstance().Call(Methods.GetXboxPairwiseID, referenceName).AsString();
    }
    
    public static bool IsAddressLocalHost(string referenceName)
    {
        return GetInstance().Call(Methods.IsAddressLocalHost, referenceName).AsBool();
    }
    
    public static bool IsIdentityInvalid(string referenceName)
    {
        return GetInstance().Call(Methods.IsIdentityInvalid, referenceName).AsBool();
    }
    
    public static bool IsIdentityLocalHost(string referenceName)
    {
        return GetInstance().Call(Methods.IsIdentityLocalHost, referenceName).AsBool();
    }
    
    public static bool IsIPv4(string referenceName)
    {
        return GetInstance().Call(Methods.IsIPv4, referenceName).AsBool();
    }
    
    public static bool IsIPv6AllZeros(string referenceName)
    {
        return GetInstance().Call(Methods.IsIPv6AllZeros, referenceName).AsBool();
    }
    
    public static bool ParseIdentityString(string referenceName, string stringToParse)
    {
        return GetInstance().Call(Methods.ParseIdentityString, referenceName, stringToParse).AsBool();
    }
    
    public static bool ParseIPAddressString(string referenceName, string stringToParse)
    {
        return GetInstance().Call(Methods.ParseIPAddressString, referenceName, stringToParse).AsBool();
    }
    
    public static bool SetGenericBytes(string referenceName, long data)
    {
        return GetInstance().Call(Methods.SetGenericBytes, referenceName, data).AsBool();
    }
    
    public static bool SetGenericString(string referenceName, string thisString)
    {
        return GetInstance().Call(Methods.SetGenericString, referenceName, thisString).AsBool();
    }
    
    public static bool SetIdentityIPAddr(string referenceName, string iPAddressName)
    {
        return GetInstance().Call(Methods.SetIdentityIPAddr, referenceName, iPAddressName).AsBool();
    }
    
    public static void SetIdentityLocalHost(string referenceName)
    {
        GetInstance().Call(Methods.SetIdentityLocalHost, referenceName);
    }
    
    public static void SetIdentitySteamID(string referenceName, long steamId)
    {
        GetInstance().Call(Methods.SetIdentitySteamID, referenceName, steamId);
    }
    
    public static void SetIdentitySteamID64(string referenceName, long steamId)
    {
        GetInstance().Call(Methods.SetIdentitySteamID64, referenceName, steamId);
    }
    
    public static void SetIPv4(string referenceName, uint iP, long port)
    {
        GetInstance().Call(Methods.SetIPv4, referenceName, iP, port);
    }
    
    public static void SetIPv6(string referenceName, int ipv6, long port)
    {
        GetInstance().Call(Methods.SetIPv6, referenceName, ipv6, port);
    }
    
    public static void SetIPv6LocalHost(string referenceName, long port = 0)
    {
        GetInstance().Call(Methods.SetIPv6LocalHost, referenceName, port);
    }
    
    public static void SetPSNID(string referenceName, long psnId)
    {
        GetInstance().Call(Methods.SetPSNID, referenceName, psnId);
    }
    
    public static void SetStadiaID(string referenceName, long stadiaId)
    {
        GetInstance().Call(Methods.SetStadiaID, referenceName, stadiaId);
    }
    
    public static bool SetXboxPairwiseID(string referenceName, string xboxId)
    {
        return GetInstance().Call(Methods.SetXboxPairwiseID, referenceName, xboxId).AsBool();
    }
    
    public static string ToIdentityString(string referenceName)
    {
        return GetInstance().Call(Methods.ToIdentityString, referenceName).AsString();
    }
    
    public static string ToIPAddressString(string referenceName, bool withPort)
    {
        return GetInstance().Call(Methods.ToIPAddressString, referenceName, withPort).AsString();
    }
}