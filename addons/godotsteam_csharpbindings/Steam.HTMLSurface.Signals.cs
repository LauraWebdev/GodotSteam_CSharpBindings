using System;
using Godot;

namespace GodotSteam;

public static partial class Steam
{
    public delegate void HtmlBrowserReadyEventHandler(uint browserHandle);
    private static event HtmlBrowserReadyEventHandler HtmlBrowserReadyEvent;
    static Action<uint> _htmlBrowserReadyAction = (browserHandle) =>
    {
        HtmlBrowserReadyEvent?.Invoke(browserHandle);
    };
    public static event HtmlBrowserReadyEventHandler HtmlBrowserReady
    {
        add
        {
            if(HtmlBrowserReadyEvent == null)
            {
                GetInstance().Connect(Signals.HtmlBrowserReady, Callable.From(_htmlBrowserReadyAction));
            }
            HtmlBrowserReadyEvent += value;
        }
        remove
        {
            HtmlBrowserReadyEvent -= value; 
            if(HtmlBrowserReadyEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlBrowserReady, Callable.From(_htmlBrowserReadyAction));
            }
        }
    }
    
    public delegate void HtmlCanGoBackandforwardEventHandler(uint browserHandle, bool goBack, bool goForward);
    private static event HtmlCanGoBackandforwardEventHandler HtmlCanGoBackandforwardEvent;
    static Action<uint, bool, bool> _htmlCanGoBackandforwardAction = (browserHandle, goBack, goForward) =>
    {
        HtmlCanGoBackandforwardEvent?.Invoke(browserHandle, goBack, goForward);
    };
    public static event HtmlCanGoBackandforwardEventHandler HtmlCanGoBackandforward
    {
        add
        {
            if(HtmlCanGoBackandforwardEvent == null)
            {
                GetInstance().Connect(Signals.HtmlCanGoBackandforward, Callable.From(_htmlCanGoBackandforwardAction));
            }
            HtmlCanGoBackandforwardEvent += value;
        }
        remove
        {
            HtmlCanGoBackandforwardEvent -= value; 
            if(HtmlCanGoBackandforwardEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlCanGoBackandforward, Callable.From(_htmlCanGoBackandforwardAction));
            }
        }
    }
    
    public delegate void HtmlChangedTitleEventHandler(uint browserHandle, string title);
    private static event HtmlChangedTitleEventHandler HtmlChangedTitleEvent;
    static Action<uint, string> _htmlChangedTitleAction = (browserHandle, title) =>
    {
        HtmlChangedTitleEvent?.Invoke(browserHandle, title);
    };
    public static event HtmlChangedTitleEventHandler HtmlChangedTitle
    {
        add
        {
            if(HtmlChangedTitleEvent == null)
            {
                GetInstance().Connect(Signals.HtmlChangedTitle, Callable.From(_htmlChangedTitleAction));
            }
            HtmlChangedTitleEvent += value;
        }
        remove
        {
            HtmlChangedTitleEvent -= value; 
            if(HtmlChangedTitleEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlChangedTitle, Callable.From(_htmlChangedTitleAction));
            }
        }
    }
    
    public delegate void HtmlCloseBrowserEventHandler(uint browserHandle);
    private static event HtmlCloseBrowserEventHandler HtmlCloseBrowserEvent;
    static Action<uint> _htmlCloseBrowserAction = (browserHandle) =>
    {
        HtmlCloseBrowserEvent?.Invoke(browserHandle);
    };
    public static event HtmlCloseBrowserEventHandler HtmlCloseBrowser
    {
        add
        {
            if(HtmlCloseBrowserEvent == null)
            {
                GetInstance().Connect(Signals.HtmlCloseBrowser, Callable.From(_htmlCloseBrowserAction));
            }
            HtmlCloseBrowserEvent += value;
        }
        remove
        {
            HtmlCloseBrowserEvent -= value; 
            if(HtmlCloseBrowserEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlCloseBrowser, Callable.From(_htmlCloseBrowserAction));
            }
        }
    }
    
    public delegate void HtmlFileOpenDialogEventHandler(uint browserHandle, string title, string initialFile);
    private static event HtmlFileOpenDialogEventHandler HtmlFileOpenDialogEvent;
    static Action<uint, string, string> _htmlFileOpenDialogAction = (browserHandle, title, initialFile) =>
    {
        HtmlFileOpenDialogEvent?.Invoke(browserHandle, title, initialFile);
    };
    public static event HtmlFileOpenDialogEventHandler HtmlFileOpenDialog
    {
        add
        {
            if(HtmlFileOpenDialogEvent == null)
            {
                GetInstance().Connect(Signals.HtmlFileOpenDialog, Callable.From(_htmlFileOpenDialogAction));
            }
            HtmlFileOpenDialogEvent += value;
        }
        remove
        {
            HtmlFileOpenDialogEvent -= value; 
            if(HtmlFileOpenDialogEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlFileOpenDialog, Callable.From(_htmlFileOpenDialogAction));
            }
        }
    }
    
    public delegate void HtmlFinishedRequestEventHandler(uint browserHandle, string url, string title);
    private static event HtmlFinishedRequestEventHandler HtmlFinishedRequestEvent;
    static Action<uint, string, string> _htmlFinishedRequestAction = (browserHandle, url, title) =>
    {
        HtmlFinishedRequestEvent?.Invoke(browserHandle, url, title);
    };
    public static event HtmlFinishedRequestEventHandler HtmlFinishedRequest
    {
        add
        {
            if(HtmlFinishedRequestEvent == null)
            {
                GetInstance().Connect(Signals.HtmlFinishedRequest, Callable.From(_htmlFinishedRequestAction));
            }
            HtmlFinishedRequestEvent += value;
        }
        remove
        {
            HtmlFinishedRequestEvent -= value; 
            if(HtmlFinishedRequestEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlFinishedRequest, Callable.From(_htmlFinishedRequestAction));
            }
        }
    }
    
    public delegate void HtmlHideTooltipEventHandler(uint browserHandle);
    private static event HtmlHideTooltipEventHandler HtmlHideTooltipEvent;
    static Action<uint> _htmlHideTooltipAction = (browserHandle) =>
    {
        HtmlHideTooltipEvent?.Invoke(browserHandle);
    };
    public static event HtmlHideTooltipEventHandler HtmlHideTooltip
    {
        add
        {
            if(HtmlHideTooltipEvent == null)
            {
                GetInstance().Connect(Signals.HtmlHideTooltip, Callable.From(_htmlHideTooltipAction));
            }
            HtmlHideTooltipEvent += value;
        }
        remove
        {
            HtmlHideTooltipEvent -= value; 
            if(HtmlHideTooltipEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlHideTooltip, Callable.From(_htmlHideTooltipAction));
            }
        }
    }
    
    public delegate void HtmlHorizontalScrollEventHandler(uint browserHandle, HtmlScrollData scrollData);
    private static event HtmlHorizontalScrollEventHandler HtmlHorizontalScrollEvent;
    static Action<uint, Godot.Collections.Dictionary> _htmlHorizontalScrollAction = (browserHandle, scrollData) =>
    {
        HtmlHorizontalScrollEvent?.Invoke(
            browserHandle,
            new HtmlScrollData
            {
                ScrollMax = scrollData["scroll_max"].As<uint>(),
                ScrollCurrent = scrollData["scroll_current"].As<uint>(),
                PageScale = scrollData["page_scale"].AsSingle(),
                Visible = scrollData["visible"].As<bool>(),
                PageSize = scrollData["page_size"].As<uint>(),
            }
        );
    };
    public static event HtmlHorizontalScrollEventHandler HtmlHorizontalScroll
    {
        add
        {
            if(HtmlHorizontalScrollEvent == null)
            {
                GetInstance().Connect(Signals.HtmlHorizontalScroll, Callable.From(_htmlHorizontalScrollAction));
            }
            HtmlHorizontalScrollEvent += value;
        }
        remove
        {
            HtmlHorizontalScrollEvent -= value; 
            if(HtmlHorizontalScrollEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlHorizontalScroll, Callable.From(_htmlHorizontalScrollAction));
            }
        }
    }
    
    public delegate void HtmlJsAlertEventHandler(uint browserHandle, string message);
    private static event HtmlJsAlertEventHandler HtmlJsAlertEvent;
    static Action<uint, string> _htmlJsAlertAction = (browserHandle, message) =>
    {
        HtmlJsAlertEvent?.Invoke(browserHandle, message);
    };
    public static event HtmlJsAlertEventHandler HtmlJsAlert
    {
        add
        {
            if(HtmlJsAlertEvent == null)
            {
                GetInstance().Connect(Signals.HtmlJsAlert, Callable.From(_htmlJsAlertAction));
            }
            HtmlJsAlertEvent += value;
        }
        remove
        {
            HtmlJsAlertEvent -= value; 
            if(HtmlJsAlertEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlJsAlert, Callable.From(_htmlJsAlertAction));
            }
        }
    }
    
    public delegate void HtmlJsConfirmEventHandler(uint browserHandle, string message);
    private static event HtmlJsConfirmEventHandler HtmlJsConfirmEvent;
    static Action<uint, string> _htmlJsConfirmAction = (browserHandle, message) =>
    {
        HtmlJsConfirmEvent?.Invoke(browserHandle, message);
    };
    public static event HtmlJsConfirmEventHandler HtmlJsConfirm
    {
        add
        {
            if(HtmlJsConfirmEvent == null)
            {
                GetInstance().Connect(Signals.HtmlJsConfirm, Callable.From(_htmlJsConfirmAction));
            }
            HtmlJsConfirmEvent += value;
        }
        remove
        {
            HtmlJsConfirmEvent -= value; 
            if(HtmlJsConfirmEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlJsConfirm, Callable.From(_htmlJsConfirmAction));
            }
        }
    }
    
    public delegate void HtmlLinkAtPositionEventHandler(uint browserHandle, HtmlLinkData linkData);
    private static event HtmlLinkAtPositionEventHandler HtmlLinkAtPositionEvent;
    static Action<uint, Godot.Collections.Dictionary> _htmlLinkAtPositionAction = (browserHandle, linkData) =>
    {
        HtmlLinkAtPositionEvent?.Invoke(
            browserHandle,
            new HtmlLinkData
            {
                X = linkData["x"].As<uint>(),
                Y = linkData["y"].As<uint>(),
                Url = new Uri(linkData["url"].As<string>()),
                Input = linkData["input"].As<bool>(),
                LiveLink = linkData["live_link"].As<bool>(),
            }
        );
    };
    public static event HtmlLinkAtPositionEventHandler HtmlLinkAtPosition
    {
        add
        {
            if(HtmlLinkAtPositionEvent == null)
            {
                GetInstance().Connect(Signals.HtmlLinkAtPosition, Callable.From(_htmlLinkAtPositionAction));
            }
            HtmlLinkAtPositionEvent += value;
        }
        remove
        {
            HtmlLinkAtPositionEvent -= value; 
            if(HtmlLinkAtPositionEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlLinkAtPosition, Callable.From(_htmlLinkAtPositionAction));
            }
        }
    }
    
    public delegate void HtmlNeedsPaintEventHandler(uint browserHandle, HtmlPageData pageData);
    private static event HtmlNeedsPaintEventHandler HtmlNeedsPaintEvent;
    static Action<uint, Godot.Collections.Dictionary> _htmlNeedsPaintAction = (browserHandle, pageData) =>
    {
        HtmlNeedsPaintEvent?.Invoke(
            browserHandle,
            new HtmlPageData
            {
                Bgra = pageData["bgra"].As<string>(),
                Wide = pageData["wide"].As<uint>(),
                Tall = pageData["tall"].As<uint>(),
                UpdateX = pageData["update_x"].As<uint>(),
                UpdateY = pageData["update_y"].As<uint>(),
                UpdateWide = pageData["update_wide"].As<uint>(),
                UpdateTall = pageData["update_tall"].As<uint>(),
                ScrollX = pageData["scroll_x"].As<uint>(),
                ScrollY = pageData["scroll_y"].As<uint>(),
                PageScale = pageData["page_scale"].AsSingle(),
                PageSerial = pageData["page_serial"].As<uint>(),
            }
        );
    };
    public static event HtmlNeedsPaintEventHandler HtmlNeedsPaint
    {
        add
        {
            if(HtmlNeedsPaintEvent == null)
            {
                GetInstance().Connect(Signals.HtmlNeedsPaint, Callable.From(_htmlNeedsPaintAction));
            }
            HtmlNeedsPaintEvent += value;
        }
        remove
        {
            HtmlNeedsPaintEvent -= value; 
            if(HtmlNeedsPaintEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlNeedsPaint, Callable.From(_htmlNeedsPaintAction));
            }
        }
    }
    
    public delegate void HtmlNewWindowEventHandler(uint browserHandle, HtmlWindowData windowData);
    private static event HtmlNewWindowEventHandler HtmlNewWindowEvent;
    static Action<uint, Godot.Collections.Dictionary> _htmlNewWindowAction = (browserHandle, windowData) =>
    {
        HtmlNewWindowEvent?.Invoke(
            browserHandle,
            new HtmlWindowData
            {
                Url = new Uri(windowData["url"].As<string>()),
                X = windowData["x"].As<uint>(),
                Y = windowData["y"].As<uint>(),
                Wide = windowData["wide"].As<uint>(),
                Tall = windowData["tall"].As<uint>(),
                NewHandle = windowData["new_handle"].As<uint>(),
            }
        );
    };
    public static event HtmlNewWindowEventHandler HtmlNewWindow
    {
        add
        {
            if(HtmlNewWindowEvent == null)
            {
                GetInstance().Connect(Signals.HtmlNewWindow, Callable.From(_htmlNewWindowAction));
            }
            HtmlNewWindowEvent += value;
        }
        remove
        {
            HtmlNewWindowEvent -= value; 
            if(HtmlNewWindowEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlNewWindow, Callable.From(_htmlNewWindowAction));
            }
        }
    }
    
    public delegate void HtmlOpenLinkInNewTabEventHandler(uint browserHandle, string url);
    private static event HtmlOpenLinkInNewTabEventHandler HtmlOpenLinkInNewTabEvent;
    static Action<uint, string> _htmlOpenLinkInNewTabAction = (browserHandle, url) =>
    {
        HtmlOpenLinkInNewTabEvent?.Invoke(browserHandle, url);
    };
    public static event HtmlOpenLinkInNewTabEventHandler HtmlOpenLinkInNewTab
    {
        add
        {
            if(HtmlOpenLinkInNewTabEvent == null)
            {
                GetInstance().Connect(Signals.HtmlOpenLinkInNewTab, Callable.From(_htmlOpenLinkInNewTabAction));
            }
            HtmlOpenLinkInNewTabEvent += value;
        }
        remove
        {
            HtmlOpenLinkInNewTabEvent -= value; 
            if(HtmlOpenLinkInNewTabEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlOpenLinkInNewTab, Callable.From(_htmlOpenLinkInNewTabAction));
            }
        }
    }
    
    public delegate void HtmlSearchResultsEventHandler(uint browserHandle, uint results, uint currentMatch);
    private static event HtmlSearchResultsEventHandler HtmlSearchResultsEvent;
    static Action<uint, uint, uint> _htmlSearchResultsAction = (browserHandle, results, currentMatch) =>
    {
        HtmlSearchResultsEvent?.Invoke(browserHandle, results, currentMatch);
    };
    public static event HtmlSearchResultsEventHandler HtmlSearchResults
    {
        add
        {
            if(HtmlSearchResultsEvent == null)
            {
                GetInstance().Connect(Signals.HtmlSearchResults, Callable.From(_htmlSearchResultsAction));
            }
            HtmlSearchResultsEvent += value;
        }
        remove
        {
            HtmlSearchResultsEvent -= value; 
            if(HtmlSearchResultsEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlSearchResults, Callable.From(_htmlSearchResultsAction));
            }
        }
    }
    
    public delegate void HtmlSetCursorEventHandler(uint browserHandle, HtmlMouseCursor mouseCursor);
    private static event HtmlSetCursorEventHandler HtmlSetCursorEvent;
    static Action<uint, int> _htmlSetCursorAction = (browserHandle, mouseCursor) =>
    {
        HtmlSetCursorEvent?.Invoke(browserHandle, (HtmlMouseCursor)mouseCursor);
    };
    public static event HtmlSetCursorEventHandler HtmlSetCursor
    {
        add
        {
            if(HtmlSetCursorEvent == null)
            {
                GetInstance().Connect(Signals.HtmlSetCursor, Callable.From(_htmlSetCursorAction));
            }
            HtmlSetCursorEvent += value;
        }
        remove
        {
            HtmlSetCursorEvent -= value; 
            if(HtmlSetCursorEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlSetCursor, Callable.From(_htmlSetCursorAction));
            }
        }
    }
    
    public delegate void HtmlShowTooltipEventHandler(uint browserHandle, string message);
    private static event HtmlShowTooltipEventHandler HtmlShowTooltipEvent;
    static Action<uint, string> _htmlShowTooltipAction = (browserHandle, message) =>
    {
        HtmlShowTooltipEvent?.Invoke(browserHandle, message);
    };
    public static event HtmlShowTooltipEventHandler HtmlShowTooltip
    {
        add
        {
            if(HtmlShowTooltipEvent == null)
            {
                GetInstance().Connect(Signals.HtmlShowTooltip, Callable.From(_htmlShowTooltipAction));
            }
            HtmlShowTooltipEvent += value;
        }
        remove
        {
            HtmlShowTooltipEvent -= value; 
            if(HtmlShowTooltipEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlShowTooltip, Callable.From(_htmlShowTooltipAction));
            }
        }
    }
    
    public delegate void HtmlStartRequestEventHandler(uint browserHandle, string url, string target, string postData, bool redirect);
    private static event HtmlStartRequestEventHandler HtmlStartRequestEvent;
    static Action<uint, string, string, string, bool> _htmlStartRequestAction = (browserHandle, url, target, postData, redirect) =>
    {
        HtmlStartRequestEvent?.Invoke(browserHandle, url, target, postData, redirect);
    };
    public static event HtmlStartRequestEventHandler HtmlStartRequest
    {
        add
        {
            if(HtmlStartRequestEvent == null)
            {
                GetInstance().Connect(Signals.HtmlStartRequest, Callable.From(_htmlStartRequestAction));
            }
            HtmlStartRequestEvent += value;
        }
        remove
        {
            HtmlStartRequestEvent -= value; 
            if(HtmlStartRequestEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlStartRequest, Callable.From(_htmlStartRequestAction));
            }
        }
    }
    
    public delegate void HtmlStatusTextEventHandler(uint browserHandle, string message);
    private static event HtmlStatusTextEventHandler HtmlStatusTextEvent;
    static Action<uint, string> _htmlStatusTextAction = (browserHandle, message) =>
    {
        HtmlStatusTextEvent?.Invoke(browserHandle, message);
    };
    public static event HtmlStatusTextEventHandler HtmlStatusText
    {
        add
        {
            if(HtmlStatusTextEvent == null)
            {
                GetInstance().Connect(Signals.HtmlStatusText, Callable.From(_htmlStatusTextAction));
            }
            HtmlStatusTextEvent += value;
        }
        remove
        {
            HtmlStatusTextEvent -= value; 
            if(HtmlStatusTextEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlStatusText, Callable.From(_htmlStatusTextAction));
            }
        }
    }
    
    public delegate void HtmlUpdateTooltipEventHandler(uint browserHandle, string message);
    private static event HtmlUpdateTooltipEventHandler HtmlUpdateTooltipEvent;
    static Action<uint, string> _htmlUpdateTooltipAction = (browserHandle, message) =>
    {
        HtmlUpdateTooltipEvent?.Invoke(browserHandle, message);
    };
    public static event HtmlUpdateTooltipEventHandler HtmlUpdateTooltip
    {
        add
        {
            if(HtmlUpdateTooltipEvent == null)
            {
                GetInstance().Connect(Signals.HtmlUpdateTooltip, Callable.From(_htmlUpdateTooltipAction));
            }
            HtmlUpdateTooltipEvent += value;
        }
        remove
        {
            HtmlUpdateTooltipEvent -= value; 
            if(HtmlUpdateTooltipEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlUpdateTooltip, Callable.From(_htmlUpdateTooltipAction));
            }
        }
    }
    
    public delegate void HtmlUrlChangedEventHandler(uint browserHandle, HtmlUrlData urlData);
    private static event HtmlUrlChangedEventHandler HtmlUrlChangedEvent;
    static Action<uint, Godot.Collections.Dictionary> _htmlUrlChangedAction = (browserHandle, urlData) =>
    {
        HtmlUrlChangedEvent?.Invoke(
            browserHandle,
            new HtmlUrlData
            {
                Url = new Uri(urlData["url"].As<string>()),
                PostData = urlData["post_data"].As<string>(),
                Redirect = urlData["redirect"].As<bool>(),
                Title = urlData["title"].As<string>(),
                NewNavigation = urlData["new_navigation"].As<bool>(),
            }
        );
    };
    public static event HtmlUrlChangedEventHandler HtmlUrlChanged
    {
        add
        {
            if(HtmlUrlChangedEvent == null)
            {
                GetInstance().Connect(Signals.HtmlUrlChanged, Callable.From(_htmlUrlChangedAction));
            }
            HtmlUrlChangedEvent += value;
        }
        remove
        {
            HtmlUrlChangedEvent -= value; 
            if(HtmlUrlChangedEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlUrlChanged, Callable.From(_htmlUrlChangedAction));
            }
        }
    }
    
    public delegate void HtmlVerticalScrollEventHandler(uint browserHandle, HtmlScrollData scrollData);
    private static event HtmlVerticalScrollEventHandler HtmlVerticalScrollEvent;
    static Action<uint, Godot.Collections.Dictionary> _htmlVerticalScrollAction = (browserHandle, scrollData) =>
    {
        HtmlVerticalScrollEvent?.Invoke(
            browserHandle, 
            new HtmlScrollData
            {
                ScrollMax = scrollData["scroll_max"].As<uint>(),
                ScrollCurrent = scrollData["scroll_current"].As<uint>(),
                PageScale = scrollData["page_scale"].AsSingle(),
                Visible = scrollData["visible"].As<bool>(),
                PageSize = scrollData["page_size"].As<uint>(),
            }
        );
    };
    public static event HtmlVerticalScrollEventHandler HtmlVerticalScroll
    {
        add
        {
            if(HtmlVerticalScrollEvent == null)
            {
                GetInstance().Connect(Signals.HtmlVerticalScroll, Callable.From(_htmlVerticalScrollAction));
            }
            HtmlVerticalScrollEvent += value;
        }
        remove
        {
            HtmlVerticalScrollEvent -= value; 
            if(HtmlVerticalScrollEvent == null)
            {
                GetInstance().Disconnect(Signals.HtmlVerticalScroll, Callable.From(_htmlVerticalScrollAction));
            }
        }
    }
}