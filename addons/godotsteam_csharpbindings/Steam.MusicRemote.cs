namespace GodotSteam;

public static partial class Steam
{
    public static bool ActivationSuccess(bool activate)
    {
        return GetInstance().Call(Methods.ActivationSuccess, activate).As<bool>();
    }
    
    public static bool IsCurrentMusicRemote()
    {
        return GetInstance().Call(Methods.IsCurrentMusicRemote).As<bool>();
    }
    
    public static bool CurrentEntryDidChange()
    {
        return GetInstance().Call(Methods.CurrentEntryDidChange).As<bool>();
    }
    
    public static bool CurrentEntryIsAvailable(bool available)
    {
        return GetInstance().Call(Methods.CurrentEntryIsAvailable, available).As<bool>();
    }
    
    public static bool CurrentEntryWillChange()
    {
        return GetInstance().Call(Methods.CurrentEntryWillChange).As<bool>();
    }
    
    public static bool DeregisterSteamMusicRemote()
    {
        return GetInstance().Call(Methods.DeregisterSteamMusicRemote).As<bool>();
    }
    
    public static bool EnableLooped(bool loop)
    {
        return GetInstance().Call(Methods.EnableLooped, loop).As<bool>();
    }
    
    public static bool EnablePlaylists(bool playlists)
    {
        return GetInstance().Call(Methods.EnablePlaylists, playlists).As<bool>();
    }
    
    public static bool EnablePlayNext(bool next)
    {
        return GetInstance().Call(Methods.EnablePlayNext, next).As<bool>();
    }
    
    public static bool EnablePlayPrevious(bool previous)
    {
        return GetInstance().Call(Methods.EnablePlayPrevious, previous).As<bool>();
    }
    
    public static bool EnableQueue(bool queue)
    {
        return GetInstance().Call(Methods.EnableQueue, queue).As<bool>();
    }
    
    public static bool EnableShuffled(bool shuffle)
    {
        return GetInstance().Call(Methods.EnableShuffled, shuffle).As<bool>();
    }
    
    public static bool PlaylistDidChange()
    {
        return GetInstance().Call(Methods.PlaylistDidChange).As<bool>();
    }
    
    public static bool PlaylistWillChange()
    {
        return GetInstance().Call(Methods.PlaylistWillChange).As<bool>();
    }
    
    public static bool QueueDidChange()
    {
        return GetInstance().Call(Methods.QueueDidChange).As<bool>();
    }
    
    public static bool QueueWillChange()
    {
        return GetInstance().Call(Methods.QueueWillChange).As<bool>();
    }
    
    public static bool RegisterSteamMusicRemote(string name)
    {
        return GetInstance().Call(Methods.RegisterSteamMusicRemote, name).As<bool>();
    }
    
    public static bool ResetPlaylistEntries()
    {
        return GetInstance().Call(Methods.ResetPlaylistEntries).As<bool>();
    }
    
    public static bool ResetQueueEntries()
    {
        return GetInstance().Call(Methods.ResetQueueEntries).As<bool>();
    }
    
    public static bool SetCurrentPlaylistEntry(long id)
    {
        return GetInstance().Call(Methods.SetCurrentPlaylistEntry, id).As<bool>();
    }
    
    public static bool SetCurrentQueueEntry(long id)
    {
        return GetInstance().Call(Methods.SetCurrentQueueEntry, id).As<bool>();
    }
    
    public static bool SetDisplayName(string name)
    {
        return GetInstance().Call(Methods.SetDisplayName, name).As<bool>();
    }
    
    public static bool SetPlaylistEntry(int id, int position, string entryText)
    {
        return GetInstance().Call(Methods.SetPlaylistEntry, id, position, entryText).As<bool>();
    }
    
    public static bool SetPNGIcon64X64(byte[] icon)
    {
        return GetInstance().Call(Methods.SetPNGIcon64X64, icon).As<bool>();
    }
    
    public static bool SetQueueEntry(int id, int position, string entryText)
    {
        return GetInstance().Call(Methods.SetQueueEntry, id, position, entryText).As<bool>();
    }
    
    public static bool UpdateCurrentEntryCoverArt(byte[] art)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryCoverArt, art).As<bool>();
    }
    
    public static bool UpdateCurrentEntryElapsedSeconds(long seconds)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryElapsedSeconds, seconds).As<bool>();
    }
    
    public static bool UpdateCurrentEntryText(string text)
    {
        return GetInstance().Call(Methods.UpdateCurrentEntryText, text).As<bool>();
    }
    
    public static bool UpdateLooped(bool looped)
    {
        return GetInstance().Call(Methods.UpdateLooped, looped).As<bool>();
    }
    
    public static bool UpdatePlaybackStatus(AudioPlaybackStatus status)
    {
        return GetInstance().Call(Methods.UpdatePlaybackStatus, (long)status).As<bool>();
    }
    
    public static bool UpdateShuffled(bool shuffle)
    {
        return GetInstance().Call(Methods.UpdateShuffled, shuffle).As<bool>();
    }
    
    public static bool UpdateVolume(double volume)
    {
        return GetInstance().Call(Methods.UpdateVolume, volume).As<bool>();
    }
}