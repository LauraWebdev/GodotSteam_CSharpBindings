namespace GodotSteam;

public static partial class Steam
{
    public static bool ActivationSuccess(bool activate)
    {
        return GetInstance().Call(Methods.ActivationSuccess, activate).AsBool();
    }
    
    public static bool IsCurrentMusicRemote()
    {
        return GetInstance().Call(Methods.IsCurrentMusicRemote).AsBool();
    }
    
    public static bool CurrentEntryDidChange()
    {
        return GetInstance().Call(Methods.CurrentEntryDidChange).AsBool();
    }
    
    public static bool CurrentEntryIsAvailable(bool available)
    {
        return GetInstance().Call(Methods.CurrentEntryIsAvailable, available).AsBool();
    }
    
    public static bool CurrentEntryWillChange()
    {
        return GetInstance().Call(Methods.CurrentEntryWillChange).AsBool();
    }
    
    public static bool DeregisterSteamMusicRemote()
    {
        return GetInstance().Call(Methods.DeregisterSteamMusicRemote).AsBool();
    }
    
    public static bool EnableLooped(bool loop)
    {
        return GetInstance().Call(Methods.EnableLooped, loop).AsBool();
    }
    
    public static bool EnablePlaylists(bool playlists)
    {
        return GetInstance().Call(Methods.EnablePlaylists, playlists).AsBool();
    }
    
    public static bool EnablePlayNext(bool next)
    {
        return GetInstance().Call(Methods.EnablePlayNext, next).AsBool();
    }
    
    public static bool EnablePlayPrevious(bool previous)
    {
        return GetInstance().Call(Methods.EnablePlayPrevious, previous).AsBool();
    }
    
    public static bool EnableQueue(bool queue)
    {
        return GetInstance().Call(Methods.EnableQueue, queue).AsBool();
    }
    
    public static bool EnableShuffled(bool shuffle)
    {
        return GetInstance().Call(Methods.EnableShuffled, shuffle).AsBool();
    }
    
    public static bool PlaylistDidChange()
    {
        return GetInstance().Call(Methods.PlaylistDidChange).AsBool();
    }
    
    public static bool PlaylistWillChange()
    {
        return GetInstance().Call(Methods.PlaylistWillChange).AsBool();
    }
    
    public static bool QueueDidChange()
    {
        return GetInstance().Call(Methods.QueueDidChange).AsBool();
    }
    
    public static bool QueueWillChange()
    {
        return GetInstance().Call(Methods.QueueWillChange).AsBool();
    }
    
    public static bool RegisterSteamMusicRemote(string name)
    {
        return GetInstance().Call(Methods.RegisterSteamMusicRemote, name).AsBool();
    }
    
    public static bool ResetPlaylistEntries()
    {
        return GetInstance().Call(Methods.ResetPlaylistEntries).AsBool();
    }
    
    public static bool ResetQueueEntries()
    {
        return GetInstance().Call(Methods.ResetQueueEntries).AsBool();
    }
    
    public static bool SetCurrentPlaylistEntry(long id)
    {
        return GetInstance().Call(Methods.SetCurrentPlaylistEntry, id).AsBool();
    }
    
    public static bool SetCurrentQueueEntry(long id)
    {
        return GetInstance().Call(Methods.SetCurrentQueueEntry, id).AsBool();
    }
    
    public static bool SetDisplayName(string name)
    {
        return GetInstance().Call(Methods.SetDisplayName, name).AsBool();
    }
    
    public static bool SetPlaylistEntry(int id, int position, string entryText)
    {
        return GetInstance().Call(Methods.SetPlaylistEntry, id, position, entryText).AsBool();
    }
    
    public static bool SetPNGIcon64X64(byte[] icon)
    {
        return GetInstance().Call(Methods.SetPNGIcon64X64, icon).AsBool();
    }
    
    public static bool SetQueueEntry(int id, int position, string entryText)
    {
        return GetInstance().Call(Methods.SetQueueEntry, id, position, entryText).AsBool();
    }
    
    public static bool UpdateCurrentEntryCoverArt(byte[] art)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryCoverArt, art).AsBool();
    }
    
    public static bool UpdateCurrentEntryElapsedSeconds(long seconds)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryElapsedSeconds, seconds).AsBool();
    }
    
    public static bool UpdateCurrentEntryText(string text)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryText, text).AsBool();
    }
    
    public static bool UpdateLooped(bool looped)
    {
        return GetInstance().Call(Methods.UpdateLooped, looped).AsBool();
    }
    
    public static bool UpdatePlaybackStatus(AudioPlaybackStatus status)
    {
        return GetInstance().Call(Methods.UpdatePlaybackStatus, (long)status).AsBool();
    }
    
    public static bool UpdateShuffled(bool shuffle)
    {
        return GetInstance().Call(Methods.UpdateShuffled, shuffle).AsBool();
    }
    
    public static bool UpdateVolume(double volume)
    {
        return GetInstance().Call(Methods.UpdateVolume, volume).AsBool();
    }
}