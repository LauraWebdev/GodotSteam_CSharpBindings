namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether add identity
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool AddIdentity(string referenceName)
    {
        return GetInstance().Call(Methods.AddIdentity, referenceName).AsBool();
    }
    
    /// <summary>
    /// Describes whether add ip address
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool AddIPAddress(string referenceName)
    {
        return GetInstance().Call(Methods.AddIPAddress, referenceName).AsBool();
    }
    
    /// <summary>
    /// Clears the identity using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    public static void ClearIdentity(string referenceName)
    {
        GetInstance().Call(Methods.ClearIdentity, referenceName);
    }
    
    /// <summary>
    /// Clears the ip address using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    public static void ClearIPAddress(string referenceName)
    {
        GetInstance().Call(Methods.ClearIPAddress, referenceName);
    }
    
    /// <summary>
    /// Gets the generic bytes using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The byte</returns>
    public static byte GetGenericBytes(string referenceName)
    {
        return GetInstance().Call(Methods.GetGenericBytes, referenceName).AsByte();
    }
    
    /// <summary>
    /// Gets the generic string using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The string</returns>
    public static string GetGenericString(string referenceName)
    {
        return GetInstance().Call(Methods.GetGenericString, referenceName).AsString();
    }
    
    /// <summary>
    /// Gets the identities
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetIdentities()
    {
        return GetInstance().Call(Methods.GetIdentities).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the identity ip addr using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The uint</returns>
    public static uint GetIdentityIPAddr(string referenceName)
    {
        return GetInstance().Call(Methods.GetIdentityIPAddr, referenceName).AsUInt32();
    }
    
    /// <summary>
    /// Gets the identity steam id using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The uint</returns>
    public static uint GetIdentitySteamID(string referenceName)
    {
        return GetInstance().Call(Methods.GetIdentitySteamID, referenceName).AsUInt32();
    }
    
    /// <summary>
    /// Gets the identity steam id 64 using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The ulong</returns>
    public static ulong GetIdentitySteamID64(string referenceName)
    {
        return GetInstance().Call(Methods.GetIdentitySteamID64, referenceName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the ip addresses
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetIPAddresses()
    {
        return GetInstance().Call(Methods.GetIPAddresses).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the i pv 4 using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The uint</returns>
    public static uint GetIPv4(string referenceName)
    {
        return GetInstance().Call(Methods.GetIPv4, referenceName).AsUInt32();
    }
    
    /// <summary>
    /// Gets the psnid using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The ulong</returns>
    public static ulong GetPSNID(string referenceName)
    {
        return GetInstance().Call(Methods.GetPSNID, referenceName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the stadia id using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The ulong</returns>
    public static ulong GetStadiaID(string referenceName)
    {
        return GetInstance().Call(Methods.GetStadiaID, referenceName).AsUInt64();
    }
    
    /// <summary>
    /// Gets the xbox pairwise id using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The string</returns>
    public static string GetXboxPairwiseID(string referenceName)
    {
        return GetInstance().Call(Methods.GetXboxPairwiseID, referenceName).AsString();
    }
    
    /// <summary>
    /// Describes whether is address local host
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool IsAddressLocalHost(string referenceName)
    {
        return GetInstance().Call(Methods.IsAddressLocalHost, referenceName).AsBool();
    }
    
    /// <summary>
    /// Describes whether is identity invalid
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool IsIdentityInvalid(string referenceName)
    {
        return GetInstance().Call(Methods.IsIdentityInvalid, referenceName).AsBool();
    }
    
    /// <summary>
    /// Describes whether is identity local host
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool IsIdentityLocalHost(string referenceName)
    {
        return GetInstance().Call(Methods.IsIdentityLocalHost, referenceName).AsBool();
    }
    
    /// <summary>
    /// Describes whether is i pv 4
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool IsIPv4(string referenceName)
    {
        return GetInstance().Call(Methods.IsIPv4, referenceName).AsBool();
    }
    
    /// <summary>
    /// Describes whether is i pv 6 all zeros
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The bool</returns>
    public static bool IsIPv6AllZeros(string referenceName)
    {
        return GetInstance().Call(Methods.IsIPv6AllZeros, referenceName).AsBool();
    }
    
    /// <summary>
    /// Describes whether parse identity string
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="stringToParse">The string to parse</param>
    /// <returns>The bool</returns>
    public static bool ParseIdentityString(string referenceName, string stringToParse)
    {
        return GetInstance().Call(Methods.ParseIdentityString, referenceName, stringToParse).AsBool();
    }
    
    /// <summary>
    /// Describes whether parse ip address string
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="stringToParse">The string to parse</param>
    /// <returns>The bool</returns>
    public static bool ParseIPAddressString(string referenceName, string stringToParse)
    {
        return GetInstance().Call(Methods.ParseIPAddressString, referenceName, stringToParse).AsBool();
    }
    
    /// <summary>
    /// Describes whether set generic bytes
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="data">The data</param>
    /// <returns>The bool</returns>
    public static bool SetGenericBytes(string referenceName, long data)
    {
        return GetInstance().Call(Methods.SetGenericBytes, referenceName, data).AsBool();
    }
    
    /// <summary>
    /// Describes whether set generic string
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="thisString">The this string</param>
    /// <returns>The bool</returns>
    public static bool SetGenericString(string referenceName, string thisString)
    {
        return GetInstance().Call(Methods.SetGenericString, referenceName, thisString).AsBool();
    }
    
    /// <summary>
    /// Describes whether set identity ip addr
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="iPAddressName">The address name</param>
    /// <returns>The bool</returns>
    public static bool SetIdentityIPAddr(string referenceName, string iPAddressName)
    {
        return GetInstance().Call(Methods.SetIdentityIPAddr, referenceName, iPAddressName).AsBool();
    }
    
    /// <summary>
    /// Sets the identity local host using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    public static void SetIdentityLocalHost(string referenceName)
    {
        GetInstance().Call(Methods.SetIdentityLocalHost, referenceName);
    }
    
    /// <summary>
    /// Sets the identity steam id using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="steamId">The steam id</param>
    public static void SetIdentitySteamID(string referenceName, ulong steamId)
    {
        GetInstance().Call(Methods.SetIdentitySteamID, referenceName, steamId);
    }
    
    /// <summary>
    /// Sets the identity steam id 64 using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="steamId">The steam id</param>
    public static void SetIdentitySteamID64(string referenceName, ulong steamId)
    {
        GetInstance().Call(Methods.SetIdentitySteamID64, referenceName, steamId);
    }
    
    /// <summary>
    /// Sets the i pv 4 using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="iP">The </param>
    /// <param name="port">The port</param>
    public static void SetIPv4(string referenceName, uint iP, long port)
    {
        GetInstance().Call(Methods.SetIPv4, referenceName, iP, port);
    }
    
    /// <summary>
    /// Sets the i pv 6 using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="ipv6">The ipv</param>
    /// <param name="port">The port</param>
    public static void SetIPv6(string referenceName, int ipv6, long port)
    {
        GetInstance().Call(Methods.SetIPv6, referenceName, ipv6, port);
    }
    
    /// <summary>
    /// Sets the i pv 6 local host using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="port">The port</param>
    public static void SetIPv6LocalHost(string referenceName, long port = 0)
    {
        GetInstance().Call(Methods.SetIPv6LocalHost, referenceName, port);
    }
    
    /// <summary>
    /// Sets the psnid using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="psnId">The psn id</param>
    public static void SetPSNID(string referenceName, long psnId)
    {
        GetInstance().Call(Methods.SetPSNID, referenceName, psnId);
    }
    
    /// <summary>
    /// Sets the stadia id using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="stadiaId">The stadia id</param>
    public static void SetStadiaID(string referenceName, long stadiaId)
    {
        GetInstance().Call(Methods.SetStadiaID, referenceName, stadiaId);
    }
    
    /// <summary>
    /// Describes whether set xbox pairwise id
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="xboxId">The xbox id</param>
    /// <returns>The bool</returns>
    public static bool SetXboxPairwiseID(string referenceName, string xboxId)
    {
        return GetInstance().Call(Methods.SetXboxPairwiseID, referenceName, xboxId).AsBool();
    }
    
    /// <summary>
    /// Returns the identity string using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <returns>The string</returns>
    public static string ToIdentityString(string referenceName)
    {
        return GetInstance().Call(Methods.ToIdentityString, referenceName).AsString();
    }
    
    /// <summary>
    /// Returns the ip address string using the specified reference name
    /// </summary>
    /// <param name="referenceName">The reference name</param>
    /// <param name="withPort">The with port</param>
    /// <returns>The string</returns>
    public static string ToIPAddressString(string referenceName, bool withPort)
    {
        return GetInstance().Call(Methods.ToIPAddressString, referenceName, withPort).AsString();
    }
}