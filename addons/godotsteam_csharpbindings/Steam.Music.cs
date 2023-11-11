namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether music is enabled
    /// </summary>
    /// <returns>The bool</returns>
    public static bool MusicIsEnabled()
    {
        return GetInstance().Call(Methods.MusicIsEnabled).AsBool();
    }
    
    /// <summary>
    /// Describes whether music is playing
    /// </summary>
    /// <returns>The bool</returns>
    public static bool MusicIsPlaying()
    {
        return GetInstance().Call(Methods.MusicIsPlaying).AsBool();
    }
    
    /// <summary>
    /// Gets the playback status
    /// </summary>
    /// <returns>The audio playback status</returns>
    public static AudioPlaybackStatus GetPlaybackStatus()
    {
        return (AudioPlaybackStatus)GetInstance().Call(Methods.GetPlaybackStatus).AsInt64();
    }
    
    /// <summary>
    /// Musics the get volume
    /// </summary>
    /// <returns>The double</returns>
    public static double MusicGetVolume()
    {
        return GetInstance().Call(Methods.MusicGetVolume).AsDouble();
    }
    
    /// <summary>
    /// Musics the pause
    /// </summary>
    public static void MusicPause()
    {
        GetInstance().Call(Methods.MusicPause);
    }
    
    /// <summary>
    /// Musics the play
    /// </summary>
    public static void MusicPlay()
    {
        GetInstance().Call(Methods.MusicPlay);
    }
    
    /// <summary>
    /// Musics the play next
    /// </summary>
    public static void MusicPlayNext()
    {
        GetInstance().Call(Methods.MusicPlayNext);
    }
    
    /// <summary>
    /// Musics the play prev
    /// </summary>
    public static void MusicPlayPrev()
    {
        GetInstance().Call(Methods.MusicPlayPrev);
    }
    
    /// <summary>
    /// Musics the set volume using the specified volume
    /// </summary>
    /// <param name="volume">The volume</param>
    public static void MusicSetVolume(double volume)
    {
        GetInstance().Call(Methods.MusicSetVolume, volume);
    }

    /// <summary>
    /// The audio playback status enum
    /// </summary>
    public enum AudioPlaybackStatus : long
    {
        /// <summary>
        /// The undefined audio playback status
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// The playing audio playback status
        /// </summary>
        Playing = 1,
        /// <summary>
        /// The paused audio playback status
        /// </summary>
        Paused = 2,
        /// <summary>
        /// The idle audio playback status
        /// </summary>
        Idle = 3
    }
}