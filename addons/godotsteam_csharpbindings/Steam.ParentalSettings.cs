namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether is parental lock enabled
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsParentalLockEnabled()
    {
        return GetInstance().Call(Methods.IsParentalLockEnabled).AsBool();
    }
    
    /// <summary>
    /// Describes whether is parental lock locked
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsParentalLockLocked()
    {
        return GetInstance().Call(Methods.IsParentalLockLocked).AsBool();
    }
    
    /// <summary>
    /// Describes whether is app blocked
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The bool</returns>
    public static bool IsAppBlocked(uint appId)
    {
        return GetInstance().Call(Methods.IsAppBlocked, appId).AsBool();
    }
    
    /// <summary>
    /// Describes whether is app in block list
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <returns>The bool</returns>
    public static bool IsAppInBlockList(uint appId)
    {
        return GetInstance().Call(Methods.IsAppInBlockList, appId).AsBool();
    }
    
    /// <summary>
    /// Describes whether is feature blocked
    /// </summary>
    /// <param name="feature">The feature</param>
    /// <returns>The bool</returns>
    public static bool IsFeatureBlocked(ParentalFeature feature)
    {
        return GetInstance().Call(Methods.IsFeatureBlocked, (long)feature).AsBool();
    }
    
    /// <summary>
    /// Describes whether is feature in block list
    /// </summary>
    /// <param name="feature">The feature</param>
    /// <returns>The bool</returns>
    public static bool IsFeatureInBlockList(ParentalFeature feature)
    {
        return GetInstance().Call(Methods.IsFeatureInBlockList, (long)feature).AsBool();
    }
    
    /// <summary>
    /// The parental feature enum
    /// </summary>
    public enum ParentalFeature : long
    {
        /// <summary>
        /// The invalid parental feature
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The store parental feature
        /// </summary>
        Store = 1,
        /// <summary>
        /// The community parental feature
        /// </summary>
        Community = 2,
        /// <summary>
        /// The profile parental feature
        /// </summary>
        Profile = 3,
        /// <summary>
        /// The friends parental feature
        /// </summary>
        Friends = 4,
        /// <summary>
        /// The news parental feature
        /// </summary>
        News = 5,
        /// <summary>
        /// The trading parental feature
        /// </summary>
        Trading = 6,
        /// <summary>
        /// The settings parental feature
        /// </summary>
        Settings = 7,
        /// <summary>
        /// The console parental feature
        /// </summary>
        Console = 8,
        /// <summary>
        /// The browser parental feature
        /// </summary>
        Browser = 9,
        /// <summary>
        /// The parental setup parental feature
        /// </summary>
        ParentalSetup = 10,
        /// <summary>
        /// The library parental feature
        /// </summary>
        Library = 11,
        /// <summary>
        /// The test parental feature
        /// </summary>
        Test = 12,
        /// <summary>
        /// The site license parental feature
        /// </summary>
        SiteLicense = 13,
        /// <summary>
        /// The kiosk mode parental feature
        /// </summary>
        KioskMode = 14,
        /// <summary>
        /// The max parental feature
        /// </summary>
        Max = 15
    }
}