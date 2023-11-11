namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether activation success
    /// </summary>
    /// <param name="activate">The activate</param>
    /// <returns>The bool</returns>
    public static bool ActivationSuccess(bool activate)
    {
        return GetInstance().Call(Methods.ActivationSuccess, activate).AsBool();
    }
    
    /// <summary>
    /// Describes whether is current music remote
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsCurrentMusicRemote()
    {
        return GetInstance().Call(Methods.IsCurrentMusicRemote).AsBool();
    }
    
    /// <summary>
    /// Describes whether current entry did change
    /// </summary>
    /// <returns>The bool</returns>
    public static bool CurrentEntryDidChange()
    {
        return GetInstance().Call(Methods.CurrentEntryDidChange).AsBool();
    }
    
    /// <summary>
    /// Describes whether current entry is available
    /// </summary>
    /// <param name="available">The available</param>
    /// <returns>The bool</returns>
    public static bool CurrentEntryIsAvailable(bool available)
    {
        return GetInstance().Call(Methods.CurrentEntryIsAvailable, available).AsBool();
    }
    
    /// <summary>
    /// Describes whether current entry will change
    /// </summary>
    /// <returns>The bool</returns>
    public static bool CurrentEntryWillChange()
    {
        return GetInstance().Call(Methods.CurrentEntryWillChange).AsBool();
    }
    
    /// <summary>
    /// Describes whether deregister steam music remote
    /// </summary>
    /// <returns>The bool</returns>
    public static bool DeregisterSteamMusicRemote()
    {
        return GetInstance().Call(Methods.DeregisterSteamMusicRemote).AsBool();
    }
    
    /// <summary>
    /// Describes whether enable looped
    /// </summary>
    /// <param name="loop">The loop</param>
    /// <returns>The bool</returns>
    public static bool EnableLooped(bool loop)
    {
        return GetInstance().Call(Methods.EnableLooped, loop).AsBool();
    }
    
    /// <summary>
    /// Describes whether enable playlists
    /// </summary>
    /// <param name="playlists">The playlists</param>
    /// <returns>The bool</returns>
    public static bool EnablePlaylists(bool playlists)
    {
        return GetInstance().Call(Methods.EnablePlaylists, playlists).AsBool();
    }
    
    /// <summary>
    /// Describes whether enable play next
    /// </summary>
    /// <param name="next">The next</param>
    /// <returns>The bool</returns>
    public static bool EnablePlayNext(bool next)
    {
        return GetInstance().Call(Methods.EnablePlayNext, next).AsBool();
    }
    
    /// <summary>
    /// Describes whether enable play previous
    /// </summary>
    /// <param name="previous">The previous</param>
    /// <returns>The bool</returns>
    public static bool EnablePlayPrevious(bool previous)
    {
        return GetInstance().Call(Methods.EnablePlayPrevious, previous).AsBool();
    }
    
    /// <summary>
    /// Describes whether enable queue
    /// </summary>
    /// <param name="queue">The queue</param>
    /// <returns>The bool</returns>
    public static bool EnableQueue(bool queue)
    {
        return GetInstance().Call(Methods.EnableQueue, queue).AsBool();
    }
    
    /// <summary>
    /// Describes whether enable shuffled
    /// </summary>
    /// <param name="shuffle">The shuffle</param>
    /// <returns>The bool</returns>
    public static bool EnableShuffled(bool shuffle)
    {
        return GetInstance().Call(Methods.EnableShuffled, shuffle).AsBool();
    }
    
    /// <summary>
    /// Describes whether playlist did change
    /// </summary>
    /// <returns>The bool</returns>
    public static bool PlaylistDidChange()
    {
        return GetInstance().Call(Methods.PlaylistDidChange).AsBool();
    }
    
    /// <summary>
    /// Describes whether playlist will change
    /// </summary>
    /// <returns>The bool</returns>
    public static bool PlaylistWillChange()
    {
        return GetInstance().Call(Methods.PlaylistWillChange).AsBool();
    }
    
    /// <summary>
    /// Describes whether queue did change
    /// </summary>
    /// <returns>The bool</returns>
    public static bool QueueDidChange()
    {
        return GetInstance().Call(Methods.QueueDidChange).AsBool();
    }
    
    /// <summary>
    /// Describes whether queue will change
    /// </summary>
    /// <returns>The bool</returns>
    public static bool QueueWillChange()
    {
        return GetInstance().Call(Methods.QueueWillChange).AsBool();
    }
    
    /// <summary>
    /// Describes whether register steam music remote
    /// </summary>
    /// <param name="name">The name</param>
    /// <returns>The bool</returns>
    public static bool RegisterSteamMusicRemote(string name)
    {
        return GetInstance().Call(Methods.RegisterSteamMusicRemote, name).AsBool();
    }
    
    /// <summary>
    /// Describes whether reset playlist entries
    /// </summary>
    /// <returns>The bool</returns>
    public static bool ResetPlaylistEntries()
    {
        return GetInstance().Call(Methods.ResetPlaylistEntries).AsBool();
    }
    
    /// <summary>
    /// Describes whether reset queue entries
    /// </summary>
    /// <returns>The bool</returns>
    public static bool ResetQueueEntries()
    {
        return GetInstance().Call(Methods.ResetQueueEntries).AsBool();
    }
    
    /// <summary>
    /// Describes whether set current playlist entry
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>The bool</returns>
    public static bool SetCurrentPlaylistEntry(long id)
    {
        return GetInstance().Call(Methods.SetCurrentPlaylistEntry, id).AsBool();
    }
    
    /// <summary>
    /// Describes whether set current queue entry
    /// </summary>
    /// <param name="id">The id</param>
    /// <returns>The bool</returns>
    public static bool SetCurrentQueueEntry(long id)
    {
        return GetInstance().Call(Methods.SetCurrentQueueEntry, id).AsBool();
    }
    
    /// <summary>
    /// Describes whether set display name
    /// </summary>
    /// <param name="name">The name</param>
    /// <returns>The bool</returns>
    public static bool SetDisplayName(string name)
    {
        return GetInstance().Call(Methods.SetDisplayName, name).AsBool();
    }
    
    /// <summary>
    /// Describes whether set playlist entry
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="position">The position</param>
    /// <param name="entryText">The entry text</param>
    /// <returns>The bool</returns>
    public static bool SetPlaylistEntry(int id, int position, string entryText)
    {
        return GetInstance().Call(Methods.SetPlaylistEntry, id, position, entryText).AsBool();
    }
    
    /// <summary>
    /// Describes whether set png icon 64 x 64
    /// </summary>
    /// <param name="icon">The icon</param>
    /// <returns>The bool</returns>
    public static bool SetPNGIcon64X64(byte[] icon)
    {
        return GetInstance().Call(Methods.SetPNGIcon64X64, icon).AsBool();
    }
    
    /// <summary>
    /// Describes whether set queue entry
    /// </summary>
    /// <param name="id">The id</param>
    /// <param name="position">The position</param>
    /// <param name="entryText">The entry text</param>
    /// <returns>The bool</returns>
    public static bool SetQueueEntry(int id, int position, string entryText)
    {
        return GetInstance().Call(Methods.SetQueueEntry, id, position, entryText).AsBool();
    }
    
    /// <summary>
    /// Describes whether update current entry cover art
    /// </summary>
    /// <param name="art">The art</param>
    /// <returns>The bool</returns>
    public static bool UpdateCurrentEntryCoverArt(byte[] art)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryCoverArt, art).AsBool();
    }
    
    /// <summary>
    /// Describes whether update current entry elapsed seconds
    /// </summary>
    /// <param name="seconds">The seconds</param>
    /// <returns>The bool</returns>
    public static bool UpdateCurrentEntryElapsedSeconds(long seconds)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryElapsedSeconds, seconds).AsBool();
    }
    
    /// <summary>
    /// Describes whether update current entry text
    /// </summary>
    /// <param name="text">The text</param>
    /// <returns>The bool</returns>
    public static bool UpdateCurrentEntryText(string text)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryText, text).AsBool();
    }
    
    /// <summary>
    /// Describes whether update looped
    /// </summary>
    /// <param name="looped">The looped</param>
    /// <returns>The bool</returns>
    public static bool UpdateLooped(bool looped)
    {
        return GetInstance().Call(Methods.UpdateLooped, looped).AsBool();
    }
    
    /// <summary>
    /// Describes whether update playback status
    /// </summary>
    /// <param name="status">The status</param>
    /// <returns>The bool</returns>
    public static bool UpdatePlaybackStatus(AudioPlaybackStatus status)
    {
        return GetInstance().Call(Methods.UpdatePlaybackStatus, (long)status).AsBool();
    }
    
    /// <summary>
    /// Describes whether update shuffled
    /// </summary>
    /// <param name="shuffle">The shuffle</param>
    /// <returns>The bool</returns>
    public static bool UpdateShuffled(bool shuffle)
    {
        return GetInstance().Call(Methods.UpdateShuffled, shuffle).AsBool();
    }
    
    /// <summary>
    /// Describes whether update volume
    /// </summary>
    /// <param name="volume">The volume</param>
    /// <returns>The bool</returns>
    public static bool UpdateVolume(double volume)
    {
        return GetInstance().Call(Methods.UpdateVolume, volume).AsBool();
    }
}