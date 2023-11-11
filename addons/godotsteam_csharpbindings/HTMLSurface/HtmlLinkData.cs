using System;

namespace GodotSteam;

public class HtmlLinkData
{
    public uint X { get; set; }
    public uint Y { get; set; }
    public Uri Url { get; set; }
    public bool Input { get; set; }
    public bool LiveLink { get; set; }
}