namespace GodotSteam;

public static partial class Steam
{
    public static bool IsParentalLockEnabled()
    {
        return GetInstance().Call(Methods.IsParentalLockEnabled).AsBool();
    }
    
    public static bool IsParentalLockLocked()
    {
        return GetInstance().Call(Methods.IsParentalLockLocked).AsBool();
    }
    
    public static bool IsAppBlocked(uint appId)
    {
        return GetInstance().Call(Methods.IsAppBlocked, appId).AsBool();
    }
    
    public static bool IsAppInBlockList(uint appId)
    {
        return GetInstance().Call(Methods.IsAppInBlockList, appId).AsBool();
    }
    
    public static bool IsFeatureBlocked(ParentalFeature feature)
    {
        return GetInstance().Call(Methods.IsFeatureBlocked, (long)feature).AsBool();
    }
    
    public static bool IsFeatureInBlockList(ParentalFeature feature)
    {
        return GetInstance().Call(Methods.IsFeatureInBlockList, (long)feature).AsBool();
    }
    
    public enum ParentalFeature : long
    {
        Invalid = 0,
        Store = 1,
        Community = 2,
        Profile = 3,
        Friends = 4,
        News = 5,
        Trading = 6,
        Settings = 7,
        Console = 8,
        Browser = 9,
        ParentalSetup = 10,
        Library = 11,
        Test = 12,
        SiteLicense = 13,
        KioskMode = 14,
        Max = 15
    }
}