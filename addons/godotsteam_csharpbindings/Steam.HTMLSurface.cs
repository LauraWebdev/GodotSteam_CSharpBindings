namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Adds the header using the specified key
    /// </summary>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <param name="thisHandle">The this handle</param>
    public static void AddHeader(string key, string value, long thisHandle = 0)
    {
        GetInstance().Call(Methods.AddHeader, key, value, thisHandle);
    }
    
    /// <summary>
    /// Allows the start request using the specified allowed
    /// </summary>
    /// <param name="allowed">The allowed</param>
    /// <param name="thisHandle">The this handle</param>
    public static void AllowStartRequest(bool allowed, long thisHandle = 0)
    {
        GetInstance().Call(Methods.AllowStartRequest, allowed, thisHandle);
    }
    
    /// <summary>
    /// Copies the to clipboard using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void CopyToClipboard(long thisHandle = 0)
    {
        GetInstance().Call(Methods.CopyToClipboard, thisHandle);
    }
    
    /// <summary>
    /// Creates the browser using the specified user agent
    /// </summary>
    /// <param name="userAgent">The user agent</param>
    /// <param name="userCss">The user css</param>
    public static void CreateBrowser(string userAgent = "", string userCss = "")
    {
        GetInstance().Call(Methods.CreateBrowser, userAgent, userCss);
    }
    
    /// <summary>
    /// Executes the javascript using the specified script
    /// </summary>
    /// <param name="script">The script</param>
    /// <param name="thisHandle">The this handle</param>
    public static void ExecuteJavascript(string script, long thisHandle = 0)
    {
        GetInstance().Call(Methods.ExecuteJavascript, script, thisHandle);
    }
    
    /// <summary>
    /// Finds the search
    /// </summary>
    /// <param name="search">The search</param>
    /// <param name="currentlyInFind">The currently in find</param>
    /// <param name="reverse">The reverse</param>
    /// <param name="thisHandle">The this handle</param>
    public static void Find(string search, bool currentlyInFind, bool reverse, long thisHandle = 0)
    {
        GetInstance().Call(Methods.Find, search, currentlyInFind, reverse, thisHandle);
    }
    
    /// <summary>
    /// Gets the link at position using the specified x
    /// </summary>
    /// <param name="x">The </param>
    /// <param name="y">The </param>
    /// <param name="thisHandle">The this handle</param>
    public static void GetLinkAtPosition(int x, int y, long thisHandle = 0)
    {
        GetInstance().Call(Methods.GetLinkAtPosition, x, y, thisHandle);
    }
    
    /// <summary>
    /// Goes the back using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void GoBack(long thisHandle = 0)
    {
        GetInstance().Call(Methods.GoBack, thisHandle);
    }
    
    /// <summary>
    /// Goes the forward using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void GoForward(long thisHandle = 0)
    {
        GetInstance().Call(Methods.GoForward, thisHandle);
    }
    
    /// <summary>
    /// Htmls the init
    /// </summary>
    public static void HtmlInit()
    {
        GetInstance().Call(Methods.HtmlInit);
    }
    
    /// <summary>
    /// Jses the dialog response using the specified result
    /// </summary>
    /// <param name="result">The result</param>
    /// <param name="thisHandle">The this handle</param>
    public static void JsDialogResponse(bool result, long thisHandle = 0)
    {
        GetInstance().Call(Methods.JsDialogResponse, result, thisHandle);
    }
    
    /// <summary>
    /// Keys the char using the specified unicode char
    /// </summary>
    /// <param name="unicodeChar">The unicode char</param>
    /// <param name="keyModifiers">The key modifiers</param>
    /// <param name="thisHandle">The this handle</param>
    public static void KeyChar(uint unicodeChar, HtmlKeyModifiers keyModifiers, long thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyChar, unicodeChar, (long)keyModifiers, thisHandle);
    }
    
    /// <summary>
    /// Keys the down using the specified native key code
    /// </summary>
    /// <param name="nativeKeyCode">The native key code</param>
    /// <param name="keyModifiers">The key modifiers</param>
    /// <param name="thisHandle">The this handle</param>
    public static void KeyDown(uint nativeKeyCode, HtmlKeyModifiers keyModifiers, long thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyDown, nativeKeyCode, (long)keyModifiers, thisHandle);
    }
    
    /// <summary>
    /// Keys the up using the specified native key code
    /// </summary>
    /// <param name="nativeKeyCode">The native key code</param>
    /// <param name="keyModifiers">The key modifiers</param>
    /// <param name="thisHandle">The this handle</param>
    public static void KeyUp(uint nativeKeyCode, HtmlKeyModifiers keyModifiers, long thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyUp, nativeKeyCode, (long)keyModifiers, thisHandle);
    }
    
    /// <summary>
    /// Loads the url using the specified url
    /// </summary>
    /// <param name="url">The url</param>
    /// <param name="postData">The post data</param>
    /// <param name="thisHandle">The this handle</param>
    public static void LoadURL(string url, string postData, long thisHandle = 0)
    {
        GetInstance().Call(Methods.LoadURL, url, postData, thisHandle);
    }
    
    /// <summary>
    /// Mouses the double click using the specified mouse button
    /// </summary>
    /// <param name="mouseButton">The mouse button</param>
    /// <param name="thisHandle">The this handle</param>
    public static void MouseDoubleClick(HtmlMouseButton mouseButton, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseDoubleClick, (long)mouseButton, thisHandle);
    }
    
    /// <summary>
    /// Mouses the down using the specified mouse button
    /// </summary>
    /// <param name="mouseButton">The mouse button</param>
    /// <param name="thisHandle">The this handle</param>
    public static void MouseDown(HtmlMouseButton mouseButton, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseDown, (long)mouseButton, thisHandle);
    }
    
    /// <summary>
    /// Mouses the move using the specified x
    /// </summary>
    /// <param name="x">The </param>
    /// <param name="y">The </param>
    /// <param name="thisHandle">The this handle</param>
    public static void MouseMove(int x, int y, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseMove, x, y, thisHandle);
    }
    
    /// <summary>
    /// Mouses the up using the specified mouse button
    /// </summary>
    /// <param name="mouseButton">The mouse button</param>
    /// <param name="thisHandle">The this handle</param>
    public static void MouseUp(HtmlMouseButton mouseButton, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseUp, (long)mouseButton, thisHandle);
    }
    
    /// <summary>
    /// Mouses the wheel using the specified delta
    /// </summary>
    /// <param name="delta">The delta</param>
    /// <param name="thisHandle">The this handle</param>
    public static void MouseWheel(int delta, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseWheel, delta, thisHandle);
    }
    
    /// <summary>
    /// Pastes the from clipboard using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void PasteFromClipboard(long thisHandle = 0)
    {
        GetInstance().Call(Methods.PasteFromClipboard, thisHandle);
    }
    
    /// <summary>
    /// Reloads the this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void Reload(long thisHandle = 0)
    {
        GetInstance().Call(Methods.Reload, thisHandle);
    }
    
    /// <summary>
    /// Removes the browser using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void RemoveBrowser(long thisHandle = 0)
    {
        GetInstance().Call(Methods.RemoveBrowser, thisHandle);
    }
    
    /// <summary>
    /// Sets the background mode using the specified background mode
    /// </summary>
    /// <param name="backgroundMode">The background mode</param>
    /// <param name="thisHandle">The this handle</param>
    public static void SetBackgroundMode(bool backgroundMode, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetBackgroundMode, backgroundMode, thisHandle);
    }
    
    /// <summary>
    /// Sets the cookie using the specified hostname
    /// </summary>
    /// <param name="hostname">The hostname</param>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <param name="path">The path</param>
    /// <param name="expires">The expires</param>
    /// <param name="secure">The secure</param>
    /// <param name="httpOnly">The http only</param>
    public static void SetCookie(string hostname, string key, string value, string path, uint expires, bool secure, bool httpOnly)
    {
        GetInstance().Call(Methods.SetCookie, hostname, key, value, path, expires, secure, httpOnly);
    }
    
    /// <summary>
    /// Sets the horizontal scroll using the specified absolute pixel scroll
    /// </summary>
    /// <param name="absolutePixelScroll">The absolute pixel scroll</param>
    /// <param name="thisHandle">The this handle</param>
    public static void SetHorizontalScroll(uint absolutePixelScroll, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetHorizontalScroll, absolutePixelScroll, thisHandle);
    }
    
    /// <summary>
    /// Sets the key focus using the specified has key focus
    /// </summary>
    /// <param name="hasKeyFocus">The has key focus</param>
    /// <param name="thisHandle">The this handle</param>
    public static void SetKeyFocus(bool hasKeyFocus, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetKeyFocus, hasKeyFocus, thisHandle);
    }
    
    /// <summary>
    /// Sets the page scale factor using the specified zoom
    /// </summary>
    /// <param name="zoom">The zoom</param>
    /// <param name="pointX">The point</param>
    /// <param name="pointY">The point</param>
    /// <param name="thisHandle">The this handle</param>
    public static void SetPageScaleFactor(float zoom, int pointX, int pointY, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetPageScaleFactor, zoom, pointX, pointY, thisHandle);
    }
    
    /// <summary>
    /// Sets the size using the specified width
    /// </summary>
    /// <param name="width">The width</param>
    /// <param name="height">The height</param>
    /// <param name="thisHandle">The this handle</param>
    public static void SetSize(uint width, uint height, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetSize, width, height, thisHandle);
    }
    
    /// <summary>
    /// Sets the vertical scroll using the specified absolute pixel scroll
    /// </summary>
    /// <param name="absolutePixelScroll">The absolute pixel scroll</param>
    /// <param name="thisHandle">The this handle</param>
    public static void SetVerticalScroll(uint absolutePixelScroll, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetVerticalScroll, absolutePixelScroll, thisHandle);
    }
    
    /// <summary>
    /// Describes whether html shutdown
    /// </summary>
    /// <returns>The bool</returns>
    public static bool HtmlShutdown()
    {
        return GetInstance().Call(Methods.HtmlShutdown).AsBool();
    }
    
    /// <summary>
    /// Stops the find using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void StopFind(long thisHandle = 0)
    {
        GetInstance().Call(Methods.StopFind, thisHandle);
    }
    
    /// <summary>
    /// Stops the load using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void StopLoad(long thisHandle = 0)
    {
        GetInstance().Call(Methods.StopLoad, thisHandle);
    }
    
    /// <summary>
    /// Views the source using the specified this handle
    /// </summary>
    /// <param name="thisHandle">The this handle</param>
    public static void ViewSource(long thisHandle = 0)
    {
        GetInstance().Call(Methods.ViewSource, thisHandle);
    }

    /// <summary>
    /// The html key modifiers enum
    /// </summary>
    [System.Flags]
    public enum HtmlKeyModifiers : long
    {
        /// <summary>
        /// The none html key modifiers
        /// </summary>
        None = 0,
        /// <summary>
        /// The alt down html key modifiers
        /// </summary>
        AltDown = 1,
        /// <summary>
        /// The ctrl down html key modifiers
        /// </summary>
        CtrlDown = 2,
        /// <summary>
        /// The shift down html key modifiers
        /// </summary>
        ShiftDown = 4
    }

    /// <summary>
    /// The html mouse button enum
    /// </summary>
    public enum HtmlMouseButton : long
    {
        /// <summary>
        /// The left html mouse button
        /// </summary>
        Left = 0,
        /// <summary>
        /// The right html mouse button
        /// </summary>
        Right = 1,
        /// <summary>
        /// The middle html mouse button
        /// </summary>
        Middle = 2
    }

    /// <summary>
    /// The mouse cursor enum
    /// </summary>
    public enum MouseCursor : long
    {
        /// <summary>
        /// The user mouse cursor
        /// </summary>
        User = 0,
        /// <summary>
        /// The none mouse cursor
        /// </summary>
        None = 1,
        /// <summary>
        /// The arrow mouse cursor
        /// </summary>
        Arrow = 2,
        /// <summary>
        /// The ibeam mouse cursor
        /// </summary>
        Ibeam = 3,
        /// <summary>
        /// The hour glass mouse cursor
        /// </summary>
        HourGlass = 4,
        /// <summary>
        /// The wait arrow mouse cursor
        /// </summary>
        WaitArrow = 5,
        /// <summary>
        /// The crosshair mouse cursor
        /// </summary>
        Crosshair = 6,
        /// <summary>
        /// The up mouse cursor
        /// </summary>
        Up = 7,
        /// <summary>
        /// The size nw mouse cursor
        /// </summary>
        SizeNw = 8,
        /// <summary>
        /// The size se mouse cursor
        /// </summary>
        SizeSe = 9,
        /// <summary>
        /// The size ne mouse cursor
        /// </summary>
        SizeNe = 10,
        /// <summary>
        /// The size sw mouse cursor
        /// </summary>
        SizeSw = 11,
        /// <summary>
        /// The size mouse cursor
        /// </summary>
        SizeW = 12,
        /// <summary>
        /// The size mouse cursor
        /// </summary>
        SizeE = 13,
        /// <summary>
        /// The size mouse cursor
        /// </summary>
        SizeN = 14,
        /// <summary>
        /// The size mouse cursor
        /// </summary>
        SizeS = 15,
        /// <summary>
        /// The size we mouse cursor
        /// </summary>
        SizeWe = 16,
        /// <summary>
        /// The size ns mouse cursor
        /// </summary>
        SizeNs = 17,
        /// <summary>
        /// The size all mouse cursor
        /// </summary>
        SizeAll = 18,
        /// <summary>
        /// The no mouse cursor
        /// </summary>
        No = 19,
        /// <summary>
        /// The hand mouse cursor
        /// </summary>
        Hand = 20,
        /// <summary>
        /// The blank mouse cursor
        /// </summary>
        Blank = 21,
        /// <summary>
        /// The middle pan mouse cursor
        /// </summary>
        MiddlePan = 22,
        /// <summary>
        /// The north pan mouse cursor
        /// </summary>
        NorthPan = 23,
        /// <summary>
        /// The north east pan mouse cursor
        /// </summary>
        NorthEastPan = 24,
        /// <summary>
        /// The east pan mouse cursor
        /// </summary>
        EastPan = 25,
        /// <summary>
        /// The south east pan mouse cursor
        /// </summary>
        SouthEastPan = 26,
        /// <summary>
        /// The south pan mouse cursor
        /// </summary>
        SouthPan = 27,
        /// <summary>
        /// The south west pan mouse cursor
        /// </summary>
        SouthWestPan = 28,
        /// <summary>
        /// The west pan mouse cursor
        /// </summary>
        WestPan = 29,
        /// <summary>
        /// The north west pan mouse cursor
        /// </summary>
        NorthWestPan = 30,
        /// <summary>
        /// The alias mouse cursor
        /// </summary>
        Alias = 31,
        /// <summary>
        /// The cell mouse cursor
        /// </summary>
        Cell = 32,
        /// <summary>
        /// The col resize mouse cursor
        /// </summary>
        ColResize = 33,
        /// <summary>
        /// The copy cur mouse cursor
        /// </summary>
        CopyCur = 34,
        /// <summary>
        /// The vertical text mouse cursor
        /// </summary>
        VerticalText = 35,
        /// <summary>
        /// The row resize mouse cursor
        /// </summary>
        RowResize = 36,
        /// <summary>
        /// The zoom in mouse cursor
        /// </summary>
        ZoomIn = 37,
        /// <summary>
        /// The zoom out mouse cursor
        /// </summary>
        ZoomOut = 38,
        /// <summary>
        /// The help mouse cursor
        /// </summary>
        Help = 39,
        /// <summary>
        /// The custom mouse cursor
        /// </summary>
        Custom = 40,
        /// <summary>
        /// The last mouse cursor
        /// </summary>
        Last = 41
    }
}