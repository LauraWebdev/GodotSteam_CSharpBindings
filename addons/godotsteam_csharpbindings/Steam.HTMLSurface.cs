namespace GodotSteam;

public static partial class Steam
{
    public static void AddHeader(string key, string value, long thisHandle = 0)
    {
        GetInstance().Call(Methods.AddHeader, key, value, thisHandle);
    }
    
    public static void AllowStartRequest(bool allowed, long thisHandle = 0)
    {
        GetInstance().Call(Methods.AllowStartRequest, allowed, thisHandle);
    }
    
    public static void CopyToClipboard(long thisHandle = 0)
    {
        GetInstance().Call(Methods.CopyToClipboard, thisHandle);
    }
    
    public static void CreateBrowser(string userAgent = "", string userCss = "")
    {
        GetInstance().Call(Methods.CreateBrowser, userAgent, userCss);
    }
    
    public static void ExecuteJavascript(string script, long thisHandle = 0)
    {
        GetInstance().Call(Methods.ExecuteJavascript, script, thisHandle);
    }
    
    public static void Find(string search, bool currentlyInFind, bool reverse, long thisHandle = 0)
    {
        GetInstance().Call(Methods.Find, search, currentlyInFind, reverse, thisHandle);
    }
    
    public static void GetLinkAtPosition(int x, int y, long thisHandle = 0)
    {
        GetInstance().Call(Methods.GetLinkAtPosition, x, y, thisHandle);
    }
    
    public static void GoBack(long thisHandle = 0)
    {
        GetInstance().Call(Methods.GoBack, thisHandle);
    }
    
    public static void GoForward(long thisHandle = 0)
    {
        GetInstance().Call(Methods.GoForward, thisHandle);
    }
    
    public static void HtmlInit()
    {
        GetInstance().Call(Methods.HtmlInit);
    }
    
    public static void JsDialogResponse(bool result, long thisHandle = 0)
    {
        GetInstance().Call(Methods.JsDialogResponse, result, thisHandle);
    }
    
    public static void KeyChar(uint unicodeChar, HtmlKeyModifiers keyModifiers, long thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyChar, unicodeChar, (long)keyModifiers, thisHandle);
    }
    
    public static void KeyDown(uint nativeKeyCode, HtmlKeyModifiers keyModifiers, long thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyDown, nativeKeyCode, (long)keyModifiers, thisHandle);
    }
    
    public static void KeyUp(uint nativeKeyCode, HtmlKeyModifiers keyModifiers, long thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyUp, nativeKeyCode, (long)keyModifiers, thisHandle);
    }
    
    public static void LoadURL(string url, string postData, long thisHandle = 0)
    {
        GetInstance().Call(Methods.LoadURL, url, postData, thisHandle);
    }
    
    public static void MouseDoubleClick(HtmlMouseButton mouseButton, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseDoubleClick, (long)mouseButton, thisHandle);
    }
    
    public static void MouseDown(HtmlMouseButton mouseButton, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseDown, (long)mouseButton, thisHandle);
    }
    
    public static void MouseMove(int x, int y, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseMove, x, y, thisHandle);
    }
    
    public static void MouseUp(HtmlMouseButton mouseButton, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseUp, (long)mouseButton, thisHandle);
    }
    
    public static void MouseWheel(int delta, long thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseWheel, delta, thisHandle);
    }
    
    public static void PasteFromClipboard(long thisHandle = 0)
    {
        GetInstance().Call(Methods.PasteFromClipboard, thisHandle);
    }
    
    public static void Reload(long thisHandle = 0)
    {
        GetInstance().Call(Methods.Reload, thisHandle);
    }
    
    public static void RemoveBrowser(long thisHandle = 0)
    {
        GetInstance().Call(Methods.RemoveBrowser, thisHandle);
    }
    
    public static void SetBackgroundMode(bool backgroundMode, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetBackgroundMode, backgroundMode, thisHandle);
    }
    
    public static void SetCookie(string hostname, string key, string value, string path, uint expires, bool secure, bool httpOnly)
    {
        GetInstance().Call(Methods.SetCookie, hostname, key, value, path, expires, secure, httpOnly);
    }
    
    public static void SetHorizontalScroll(uint absolutePixelScroll, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetHorizontalScroll, absolutePixelScroll, thisHandle);
    }
    
    public static void SetKeyFocus(bool hasKeyFocus, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetKeyFocus, hasKeyFocus, thisHandle);
    }
    
    public static void SetPageScaleFactor(float zoom, int pointX, int pointY, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetPageScaleFactor, zoom, pointX, pointY, thisHandle);
    }
    
    public static void SetSize(uint width, uint height, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetSize, width, height, thisHandle);
    }
    
    public static void SetVerticalScroll(uint absolutePixelScroll, long thisHandle = 0)
    {
        GetInstance().Call(Methods.SetVerticalScroll, absolutePixelScroll, thisHandle);
    }
    
    public static bool HtmlShutdown()
    {
        return GetInstance().Call(Methods.HtmlShutdown).AsBool();
    }
    
    public static void StopFind(long thisHandle = 0)
    {
        GetInstance().Call(Methods.StopFind, thisHandle);
    }
    
    public static void StopLoad(long thisHandle = 0)
    {
        GetInstance().Call(Methods.StopLoad, thisHandle);
    }
    
    public static void ViewSource(long thisHandle = 0)
    {
        GetInstance().Call(Methods.ViewSource, thisHandle);
    }

    [System.Flags]
    public enum HtmlKeyModifiers : long
    {
        None = 0,
        AltDown = 1,
        CtrlDown = 2,
        ShiftDown = 4
    }

    public enum HtmlMouseButton : long
    {
        Left = 0,
        Right = 1,
        Middle = 2
    }

    public enum MouseCursor : long
    {
        User = 0,
        None = 1,
        Arrow = 2,
        Ibeam = 3,
        HourGlass = 4,
        WaitArrow = 5,
        Crosshair = 6,
        Up = 7,
        SizeNw = 8,
        SizeSe = 9,
        SizeNe = 10,
        SizeSw = 11,
        SizeW = 12,
        SizeE = 13,
        SizeN = 14,
        SizeS = 15,
        SizeWe = 16,
        SizeNs = 17,
        SizeAll = 18,
        No = 19,
        Hand = 20,
        Blank = 21,
        MiddlePan = 22,
        NorthPan = 23,
        NorthEastPan = 24,
        EastPan = 25,
        SouthEastPan = 26,
        SouthPan = 27,
        SouthWestPan = 28,
        WestPan = 29,
        NorthWestPan = 30,
        Alias = 31,
        Cell = 32,
        ColResize = 33,
        CopyCur = 34,
        VerticalText = 35,
        RowResize = 36,
        ZoomIn = 37,
        ZoomOut = 38,
        Help = 39,
        Custom = 40,
        Last = 41
    }
}