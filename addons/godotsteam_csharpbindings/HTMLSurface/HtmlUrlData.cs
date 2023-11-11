using System;

namespace GodotSteam;

public class HtmlUrlData
{
    public Uri Url { get; set; }
    public string PostData { get; set; }
    public bool Redirect { get; set; }
    public string Title { get; set; }
    public bool NewNavigation { get; set; }
}