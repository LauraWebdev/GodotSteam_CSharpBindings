namespace GodotSteam;

public static partial class Steam
{
    public static void AddHeader(string key, string value, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.AddHeader, key, value, thisHandle);
    }
    
    public static void AllowStartRequest(bool allowed, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.AllowStartRequest, allowed, thisHandle);
    }
    
    public static void CopyToClipboard(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.CopyToClipboard, thisHandle);
    }
    
    public static void CreateBrowser(string userAgent = "", string userCss = "")
    {
        GetInstance().Call(Methods.CreateBrowser, userAgent, userCss);
    }
    
    public static void ExecuteJavascript(string script, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.ExecuteJavascript, script, thisHandle);
    }
    
    public static void Find(string search, bool currentlyInFind, bool reverse, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.Find, search, currentlyInFind, reverse, thisHandle);
    }
    
    public static void GetLinkAtPosition(int x, int y, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.GetLinkAtPosition, x, y, thisHandle);
    }
    
    public static void GoBack(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.GoBack, thisHandle);
    }
    
    public static void GoForward(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.GoForward, thisHandle);
    }
    
    public static void HtmlInit()
    {
        GetInstance().Call(Methods.HtmlInit);
    }
    
    public static void JsDialogResponse(bool result, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.JsDialogResponse, result, thisHandle);
    }
    
    public static void KeyChar(uint unicodeChar, HtmlKeyModifiers keyModifiers, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyChar, unicodeChar, (int)keyModifiers, thisHandle);
    }
    
    public static void KeyDown(uint nativeKeyCode, HtmlKeyModifiers keyModifiers, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyDown, nativeKeyCode, (int)keyModifiers, thisHandle);
    }
    
    public static void KeyUp(uint nativeKeyCode, HtmlKeyModifiers keyModifiers, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.KeyUp, nativeKeyCode, (int)keyModifiers, thisHandle);
    }
    
    public static void LoadURL(string url, string postData, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.LoadURL, url, postData, thisHandle);
    }
    
    public static void MouseDoubleClick(HtmlMouseButton mouseButton, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseDoubleClick, (int)mouseButton, thisHandle);
    }
    
    public static void MouseDown(HtmlMouseButton mouseButton, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseDown, (int)mouseButton, thisHandle);
    }
    
    public static void MouseMove(int x, int y, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseMove, x, y, thisHandle);
    }
    
    public static void MouseUp(HtmlMouseButton mouseButton, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseUp, (int)mouseButton, thisHandle);
    }
    
    public static void MouseWheel(int delta, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.MouseWheel, delta, thisHandle);
    }
    
    public static void PasteFromClipboard(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.PasteFromClipboard, thisHandle);
    }
    
    public static void Reload(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.Reload, thisHandle);
    }
    
    public static void RemoveBrowser(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.RemoveBrowser, thisHandle);
    }
    
    public static void SetBackgroundMode(bool backgroundMode, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.SetBackgroundMode, backgroundMode, thisHandle);
    }
    
    public static void SetCookie(string hostname, string key, string value, string path, uint expires, bool secure, bool httpOnly)
    {
        GetInstance().Call(Methods.SetCookie, hostname, key, value, path, expires, secure, httpOnly);
    }
    
    public static void SetHorizontalScroll(uint absolutePixelScroll, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.SetHorizontalScroll, absolutePixelScroll, thisHandle);
    }
    
    public static void SetKeyFocus(bool hasKeyFocus, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.SetKeyFocus, hasKeyFocus, thisHandle);
    }
    
    public static void SetPageScaleFactor(float zoom, int pointX, int pointY, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.SetPageScaleFactor, zoom, pointX, pointY, thisHandle);
    }
    
    public static void SetSize(uint width, uint height, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.SetSize, width, height, thisHandle);
    }
    
    public static void SetVerticalScroll(uint absolutePixelScroll, uint thisHandle = 0)
    {
        GetInstance().Call(Methods.SetVerticalScroll, absolutePixelScroll, thisHandle);
    }
    
    public static bool HtmlShutdown()
    {
        return GetInstance().Call(Methods.HtmlShutdown).As<bool>();
    }
    
    public static void StopFind(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.StopFind, thisHandle);
    }
    
    public static void StopLoad(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.StopLoad, thisHandle);
    }
    
    public static void ViewSource(uint thisHandle = 0)
    {
        GetInstance().Call(Methods.ViewSource, thisHandle);
    }
}