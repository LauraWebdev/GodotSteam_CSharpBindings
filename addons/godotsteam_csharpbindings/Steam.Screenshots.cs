namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Adds the screenshot to library using the specified file name
    /// </summary>
    /// <param name="fileName">The file name</param>
    /// <param name="thumbnailFileName">The thumbnail file name</param>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <returns>The uint</returns>
    public static uint AddScreenshotToLibrary(string fileName, string thumbnailFileName, int width, int height)
    {
        return GetInstance().Call(Methods.AddScreenshotToLibrary, fileName, thumbnailFileName, width, height).AsUInt32();
    }
    
    /// <summary>
    /// Adds the vr screenshot to library using the specified type
    /// </summary>
    /// <param name="type">The type</param>
    /// <param name="fileName">The file name</param>
    /// <param name="vrFileName">The vr file name</param>
    /// <returns>The uint</returns>
    public static uint AddVRScreenshotToLibrary(VRScreenshotType type, string fileName, string vrFileName)
    {
        return GetInstance().Call(Methods.AddVRScreenshotToLibrary, (int)type, fileName, vrFileName).AsUInt32();
    }
    
    /// <summary>
    /// Hooks the screenshots using the specified hook
    /// </summary>
    /// <param name="hook">The hook</param>
    public static void HookScreenshots(bool hook)
    {
        GetInstance().Call(Methods.HookScreenshots, hook);
    }
    
    /// <summary>
    /// Describes whether is screenshots hooked
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsScreenshotsHooked()
    {
        return GetInstance().Call(Methods.IsScreenshotsHooked).AsBool();
    }
    
    /// <summary>
    /// Describes whether set location
    /// </summary>
    /// <param name="screenshot">The screenshot</param>
    /// <param name="location">The location</param>
    /// <returns>The bool</returns>
    public static bool SetLocation(uint screenshot, string location)
    {
        return GetInstance().Call(Methods.SetLocation, screenshot, location).AsBool();
    }
    
    /// <summary>
    /// Describes whether tag published file
    /// </summary>
    /// <param name="screenshot">The screenshot</param>
    /// <param name="fileId">The file id</param>
    /// <returns>The bool</returns>
    public static bool TagPublishedFile(uint screenshot, ulong fileId)
    {
        return GetInstance().Call(Methods.TagPublishedFile, screenshot, fileId).AsBool();
    }
    
    /// <summary>
    /// Describes whether tag user
    /// </summary>
    /// <param name="screenshot">The screenshot</param>
    /// <param name="steamId">The steam id</param>
    /// <returns>The bool</returns>
    public static bool TagUser(uint screenshot, ulong steamId)
    {
        return GetInstance().Call(Methods.TagUser, screenshot, steamId).AsBool();
    }
    
    /// <summary>
    /// Triggers the screenshot
    /// </summary>
    public static void TriggerScreenshot()
    {
        GetInstance().Call(Methods.TriggerScreenshot);
    }
    
    /// <summary>
    /// Writes the screenshot using the specified rgb
    /// </summary>
    /// <param name="rgb">The rgb</param>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <returns>The uint</returns>
    public static uint WriteScreenshot(byte[] rgb, int width, int height)
    {
        return GetInstance().Call(Methods.WriteScreenshot, rgb, width, height).AsUInt32();
    }
}