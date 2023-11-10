namespace GodotSteam;

public static partial class Steam
{
    public static bool BeginFileWriteBatch()
    {
        return GetInstance().Call(Methods.BeginFileWriteBatch).AsBool();
    }
    
    public static bool EndFileWriteBatch()
    {
        return GetInstance().Call(Methods.EndFileWriteBatch).AsBool();
    }
    
    public static bool FileDelete(string file)
    {
        return GetInstance().Call(Methods.FileDelete, file).AsBool();
    }
    
    public static bool FileExists(string file)
    {
        return GetInstance().Call(Methods.FileExists, file).AsBool();
    }
    
    public static bool FileForget(string file)
    {
        return GetInstance().Call(Methods.FileForget, file).AsBool();
    }
    
    public static bool FilePersisted(string file)
    {
        return GetInstance().Call(Methods.FilePersisted, file).AsBool();
    }
    
    public static Godot.Collections.Dictionary FileRead(string file, long dataToRead)
    {
        return GetInstance().Call(Methods.FileRead, file, dataToRead).AsGodotDictionary();
    }
    
    public static void FileReadAsync(string file, uint offset, long dataToRead)
    {
        GetInstance().Call(Methods.FileReadAsync, file, offset, dataToRead);
    }
    
    public static void FileShare(string file)
    {
        GetInstance().Call(Methods.FileShare, file);
    }
    
    public static bool FileWrite(string file, byte[] data, long size = 0)
    {
        return GetInstance().Call(Methods.FileWrite, file, data, size).AsBool();
    }
    
    public static void FileWriteAsync(string file, byte[] data, long size = 0)
    {
        GetInstance().Call(Methods.FileWriteAsync, file, data, size);
    }
    
    public static bool FileWriteStreamCancel(long writeHandle)
    {
        return GetInstance().Call(Methods.FileWriteStreamCancel, writeHandle).AsBool();
    }
    
    public static bool FileWriteStreamClose(long writeHandle)
    {
        return GetInstance().Call(Methods.FileWriteStreamClose, writeHandle).AsBool();
    }
    
    public static ulong FileWriteStreamOpen(string file)
    {
        return GetInstance().Call(Methods.FileWriteStreamOpen, file).AsUInt64();
    }
    
    public static bool FileWriteStreamWriteChunk(ulong writeHandle, byte[] data)
    {
        return GetInstance().Call(Methods.FileWriteStreamWriteChunk, writeHandle, data).AsBool();
    }
    
    public static long GetCachedUGCCount()
    {
        return GetInstance().Call(Methods.GetCachedUGCCount).AsInt64();
    }
    
    public static ulong GetCachedUGCHandle(long content)
    {
        return GetInstance().Call(Methods.GetCachedUGCHandle, content).AsUInt64();
    }
    
    public static long GetFileCount()
    {
        return GetInstance().Call(Methods.GetFileCount).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetFileNameAndSize(long file)
    {
        return GetInstance().Call(Methods.GetFileNameAndSize, file).AsGodotDictionary();
    }
    
    public static int GetFileSize(string file)
    {
        return GetInstance().Call(Methods.GetFileSize, file).AsInt32();
    }
    
    public static long GetFileTimestamp(string file)
    {
        return GetInstance().Call(Methods.GetFileTimestamp, file).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetLocalFileChange(long file)
    {
        return GetInstance().Call(Methods.GetLocalFileChange, file).AsGodotDictionary();
    }
    
    public static long GetLocalFileChangeCount()
    {
        return GetInstance().Call(Methods.GetLocalFileChangeCount).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetQuota()
    {
        return GetInstance().Call(Methods.GetQuota).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetSyncPlatforms(string file)
    {
        return GetInstance().Call(Methods.GetSyncPlatforms, file).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetUGCDetails(long content)
    {
        return GetInstance().Call(Methods.GetUGCDetails, content).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetUGCDownloadProgress(long content)
    {
        return GetInstance().Call(Methods.GetUGCDownloadProgress, content).AsGodotDictionary();
    }
    
    public static bool IsCloudEnabledForAccount()
    {
        return GetInstance().Call(Methods.IsCloudEnabledForAccount).AsBool();
    }
    
    public static bool IsCloudEnabledForApp()
    {
        return GetInstance().Call(Methods.IsCloudEnabledForApp).AsBool();
    }
    
    public static void SetCloudEnabledForApp(bool enabled)
    {
        GetInstance().Call(Methods.SetCloudEnabledForApp, enabled);
    }
    
    public static bool SetSyncPlatforms(string file, long platform)
    {
        return GetInstance().Call(Methods.SetSyncPlatforms, file, platform).AsBool();
    }
    
    public static void UgcDownload(ulong content, long priority)
    {
        GetInstance().Call(Methods.UgcDownload, content, priority);
    }
    
    public static void UgcDownloadToLocation(ulong content, string location, long priority)
    {
        GetInstance().Call(Methods.UgcDownloadToLocation, content, location, priority);
    }
    
    public static byte[] UgcRead(ulong content, int dataSize, uint offset, UgcReadAction action)
    {
        return GetInstance().Call(Methods.UgcRead, content, dataSize, offset, (long)action).AsByteArray();
    }

    [System.Flags]
    public enum RemoteStoragePlatform : long
    {
        None = 0,
        Windows = 1,
        Osx = 2,
        Ps3 = 4,
        Linux = 8,
        Switch = 16,
        Android = 32,
        Ios = 64,
        All = 4294967295
    }

    public enum RemoteStoragePublishedFileVisibility : long
    {
        Public = 0,
        FriendsOnly = 1,
        Private = 2,
        Unlisted = 3
    }

    public enum UgcReadAction : long
    {
        ContinueReadingUntilFinished = 0,
        ContinueReading = 1,
        Close = 2
    }

    public enum WorkshopEnumerationType : long
    {
        RankedByVote = 0,
        Recent = 1,
        Trending = 2,
        FavoritesOfFriends = 3,
        VotedByFriends = 4,
        ContentByFriends = 5,
        RecentFromFollowedUsers = 6
    }

    public enum WorkshopFileAction : long
    {
        Played = 0,
        Completed = 1
    }

    public enum WorkshopFileType : long
    {
        WorkshopFileTypeFirst = 0,
        WorkshopFileTypeCommunity = 0,
        WorkshopFileTypeMicrotransaction = 1,
        WorkshopFileTypeCollection = 2,
        WorkshopFileTypeArt = 3,
        WorkshopFileTypeVideo = 4,
        WorkshopFileTypeScreenshot = 5,
        WorkshopFileTypeGame = 6,
        WorkshopFileTypeSoftware = 7,
        WorkshopFileTypeConcept = 8,
        WorkshopFileTypeWebGuide = 9,
        WorkshopFileTypeIntegratedGuide = 10,
        WorkshopFileTypeMerch = 11,
        WorkshopFileTypeControllerBinding = 12,
        WorkshopFileTypeSteamworksAccessInvite = 13,
        WorkshopFileTypeSteamVideo = 14,
        WorkshopFileTypeGameManagedItem = 15,
        WorkshopFileTypeMax = 16
    }

    public enum WorkshopVideoProvider : long
    {
        None = 0,
        Youtube = 1
    }

    public enum WorkshopVote : long
    {
        Unvoted = 0,
        For = 1,
        Against = 2,
        Later = 3
    }

    public enum LocalFileChange : long
    {
        Invalid = 0,
        FileUpdated = 1,
        FileDeleted = 2
    }

    public enum FilePathType : long
    {
        Invalid = 0,
        Absolute = 1,
        ApiFileName = 2
    }
}