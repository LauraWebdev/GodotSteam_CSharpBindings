namespace GodotSteam;

public struct DlcDownloadProgress
{
    public bool Ret { get; set; }
    public ulong Downloaded { get; set; }
    public ulong Total { get; set; }
}