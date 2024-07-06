namespace GodotSteam;

public static partial class Steam
{
    public static bool MusicIsEnabled()
    {
        return GetInstance().Call(Methods.MusicIsEnabled).As<bool>();
    }
    
    public static bool MusicIsPlaying()
    {
        return GetInstance().Call(Methods.MusicIsPlaying).As<bool>();
    }
    
    public static AudioPlaybackStatus GetPlaybackStatus()
    {
        return (AudioPlaybackStatus)GetInstance().Call(Methods.GetPlaybackStatus).AsInt64();
    }
    
    public static double MusicGetVolume()
    {
        return GetInstance().Call(Methods.MusicGetVolume).AsDouble();
    }
    
    public static void MusicPause()
    {
        GetInstance().Call(Methods.MusicPause);
    }
    
    public static void MusicPlay()
    {
        GetInstance().Call(Methods.MusicPlay);
    }
    
    public static void MusicPlayNext()
    {
        GetInstance().Call(Methods.MusicPlayNext);
    }
    
    public static void MusicPlayPrev()
    {
        GetInstance().Call(Methods.MusicPlayPrev);
    }
    
    public static void MusicSetVolume(double volume)
    {
        GetInstance().Call(Methods.MusicSetVolume, volume);
    }

    public enum AudioPlaybackStatus : long
    {
        Undefined = 0,
        Playing = 1,
        Paused = 2,
        Idle = 3
    }
}