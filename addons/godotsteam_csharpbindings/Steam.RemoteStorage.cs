namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Describes whether begin file write batch
    /// </summary>
    /// <returns>The bool</returns>
    public static bool BeginFileWriteBatch()
    {
        return GetInstance().Call(Methods.BeginFileWriteBatch).AsBool();
    }
    
    /// <summary>
    /// Describes whether end file write batch
    /// </summary>
    /// <returns>The bool</returns>
    public static bool EndFileWriteBatch()
    {
        return GetInstance().Call(Methods.EndFileWriteBatch).AsBool();
    }
    
    /// <summary>
    /// Describes whether file delete
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The bool</returns>
    public static bool FileDelete(string file)
    {
        return GetInstance().Call(Methods.FileDelete, file).AsBool();
    }
    
    /// <summary>
    /// Describes whether file exists
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The bool</returns>
    public static bool FileExists(string file)
    {
        return GetInstance().Call(Methods.FileExists, file).AsBool();
    }
    
    /// <summary>
    /// Describes whether file forget
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The bool</returns>
    public static bool FileForget(string file)
    {
        return GetInstance().Call(Methods.FileForget, file).AsBool();
    }
    
    /// <summary>
    /// Describes whether file persisted
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The bool</returns>
    public static bool FilePersisted(string file)
    {
        return GetInstance().Call(Methods.FilePersisted, file).AsBool();
    }
    
    /// <summary>
    /// Files the read using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <param name="dataToRead">The data to read</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary FileRead(string file, long dataToRead)
    {
        return GetInstance().Call(Methods.FileRead, file, dataToRead).AsGodotDictionary();
    }
    
    /// <summary>
    /// Files the read using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <param name="offset">The offset</param>
    /// <param name="dataToRead">The data to read</param>
    public static void FileReadAsync(string file, uint offset, long dataToRead)
    {
        GetInstance().Call(Methods.FileReadAsync, file, offset, dataToRead);
    }
    
    /// <summary>
    /// Files the share using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    public static void FileShare(string file)
    {
        GetInstance().Call(Methods.FileShare, file);
    }
    
    /// <summary>
    /// Describes whether file write
    /// </summary>
    /// <param name="file">The file</param>
    /// <param name="data">The data</param>
    /// <param name="size">The size</param>
    /// <returns>The bool</returns>
    public static bool FileWrite(string file, byte[] data, long size = 0)
    {
        return GetInstance().Call(Methods.FileWrite, file, data, size).AsBool();
    }
    
    /// <summary>
    /// Files the write using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <param name="data">The data</param>
    /// <param name="size">The size</param>
    public static void FileWriteAsync(string file, byte[] data, long size = 0)
    {
        GetInstance().Call(Methods.FileWriteAsync, file, data, size);
    }
    
    /// <summary>
    /// Describes whether file write stream cancel
    /// </summary>
    /// <param name="writeHandle">The write handle</param>
    /// <returns>The bool</returns>
    public static bool FileWriteStreamCancel(long writeHandle)
    {
        return GetInstance().Call(Methods.FileWriteStreamCancel, writeHandle).AsBool();
    }
    
    /// <summary>
    /// Describes whether file write stream close
    /// </summary>
    /// <param name="writeHandle">The write handle</param>
    /// <returns>The bool</returns>
    public static bool FileWriteStreamClose(long writeHandle)
    {
        return GetInstance().Call(Methods.FileWriteStreamClose, writeHandle).AsBool();
    }
    
    /// <summary>
    /// Files the write stream open using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The ulong</returns>
    public static ulong FileWriteStreamOpen(string file)
    {
        return GetInstance().Call(Methods.FileWriteStreamOpen, file).AsUInt64();
    }
    
    /// <summary>
    /// Describes whether file write stream write chunk
    /// </summary>
    /// <param name="writeHandle">The write handle</param>
    /// <param name="data">The data</param>
    /// <returns>The bool</returns>
    public static bool FileWriteStreamWriteChunk(ulong writeHandle, byte[] data)
    {
        return GetInstance().Call(Methods.FileWriteStreamWriteChunk, writeHandle, data).AsBool();
    }
    
    /// <summary>
    /// Gets the cached ugc count
    /// </summary>
    /// <returns>The long</returns>
    public static long GetCachedUGCCount()
    {
        return GetInstance().Call(Methods.GetCachedUGCCount).AsInt64();
    }
    
    /// <summary>
    /// Gets the cached ugc handle using the specified content
    /// </summary>
    /// <param name="content">The content</param>
    /// <returns>The ulong</returns>
    public static ulong GetCachedUGCHandle(long content)
    {
        return GetInstance().Call(Methods.GetCachedUGCHandle, content).AsUInt64();
    }
    
    /// <summary>
    /// Gets the file count
    /// </summary>
    /// <returns>The long</returns>
    public static long GetFileCount()
    {
        return GetInstance().Call(Methods.GetFileCount).AsInt64();
    }
    
    /// <summary>
    /// Gets the file name and size using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetFileNameAndSize(long file)
    {
        return GetInstance().Call(Methods.GetFileNameAndSize, file).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the file size using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The int</returns>
    public static int GetFileSize(string file)
    {
        return GetInstance().Call(Methods.GetFileSize, file).AsInt32();
    }
    
    /// <summary>
    /// Gets the file timestamp using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The long</returns>
    public static long GetFileTimestamp(string file)
    {
        return GetInstance().Call(Methods.GetFileTimestamp, file).AsInt64();
    }
    
    /// <summary>
    /// Gets the local file change using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetLocalFileChange(long file)
    {
        return GetInstance().Call(Methods.GetLocalFileChange, file).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the local file change count
    /// </summary>
    /// <returns>The long</returns>
    public static long GetLocalFileChangeCount()
    {
        return GetInstance().Call(Methods.GetLocalFileChangeCount).AsInt64();
    }
    
    /// <summary>
    /// Gets the quota
    /// </summary>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQuota()
    {
        return GetInstance().Call(Methods.GetQuota).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the sync platforms using the specified file
    /// </summary>
    /// <param name="file">The file</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetSyncPlatforms(string file)
    {
        return GetInstance().Call(Methods.GetSyncPlatforms, file).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the ugc details using the specified content
    /// </summary>
    /// <param name="content">The content</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetUGCDetails(long content)
    {
        return GetInstance().Call(Methods.GetUGCDetails, content).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the ugc download progress using the specified content
    /// </summary>
    /// <param name="content">The content</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetUGCDownloadProgress(long content)
    {
        return GetInstance().Call(Methods.GetUGCDownloadProgress, content).AsGodotDictionary();
    }
    
    /// <summary>
    /// Describes whether is cloud enabled for account
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsCloudEnabledForAccount()
    {
        return GetInstance().Call(Methods.IsCloudEnabledForAccount).AsBool();
    }
    
    /// <summary>
    /// Describes whether is cloud enabled for app
    /// </summary>
    /// <returns>The bool</returns>
    public static bool IsCloudEnabledForApp()
    {
        return GetInstance().Call(Methods.IsCloudEnabledForApp).AsBool();
    }
    
    /// <summary>
    /// Sets the cloud enabled for app using the specified enabled
    /// </summary>
    /// <param name="enabled">The enabled</param>
    public static void SetCloudEnabledForApp(bool enabled)
    {
        GetInstance().Call(Methods.SetCloudEnabledForApp, enabled);
    }
    
    /// <summary>
    /// Describes whether set sync platforms
    /// </summary>
    /// <param name="file">The file</param>
    /// <param name="platform">The platform</param>
    /// <returns>The bool</returns>
    public static bool SetSyncPlatforms(string file, long platform)
    {
        return GetInstance().Call(Methods.SetSyncPlatforms, file, platform).AsBool();
    }
    
    /// <summary>
    /// Ugcs the download using the specified content
    /// </summary>
    /// <param name="content">The content</param>
    /// <param name="priority">The priority</param>
    public static void UgcDownload(ulong content, long priority)
    {
        GetInstance().Call(Methods.UgcDownload, content, priority);
    }
    
    /// <summary>
    /// Ugcs the download to location using the specified content
    /// </summary>
    /// <param name="content">The content</param>
    /// <param name="location">The location</param>
    /// <param name="priority">The priority</param>
    public static void UgcDownloadToLocation(ulong content, string location, long priority)
    {
        GetInstance().Call(Methods.UgcDownloadToLocation, content, location, priority);
    }
    
    /// <summary>
    /// Ugcs the read using the specified content
    /// </summary>
    /// <param name="content">The content</param>
    /// <param name="dataSize">The data size</param>
    /// <param name="offset">The offset</param>
    /// <param name="action">The action</param>
    /// <returns>The byte array</returns>
    public static byte[] UgcRead(ulong content, int dataSize, uint offset, UgcReadAction action)
    {
        return GetInstance().Call(Methods.UgcRead, content, dataSize, offset, (long)action).AsByteArray();
    }

    /// <summary>
    /// The remote storage platform enum
    /// </summary>
    [System.Flags]
    public enum RemoteStoragePlatform : long
    {
        /// <summary>
        /// The none remote storage platform
        /// </summary>
        None = 0,
        /// <summary>
        /// The windows remote storage platform
        /// </summary>
        Windows = 1,
        /// <summary>
        /// The osx remote storage platform
        /// </summary>
        Osx = 2,
        /// <summary>
        /// The ps remote storage platform
        /// </summary>
        Ps3 = 4,
        /// <summary>
        /// The linux remote storage platform
        /// </summary>
        Linux = 8,
        /// <summary>
        /// The switch remote storage platform
        /// </summary>
        Switch = 16,
        /// <summary>
        /// The android remote storage platform
        /// </summary>
        Android = 32,
        /// <summary>
        /// The ios remote storage platform
        /// </summary>
        Ios = 64,
        /// <summary>
        /// The all remote storage platform
        /// </summary>
        All = 4294967295
    }

    /// <summary>
    /// The remote storage published file visibility enum
    /// </summary>
    public enum RemoteStoragePublishedFileVisibility : long
    {
        /// <summary>
        /// The public remote storage published file visibility
        /// </summary>
        Public = 0,
        /// <summary>
        /// The friends only remote storage published file visibility
        /// </summary>
        FriendsOnly = 1,
        /// <summary>
        /// The private remote storage published file visibility
        /// </summary>
        Private = 2,
        /// <summary>
        /// The unlisted remote storage published file visibility
        /// </summary>
        Unlisted = 3
    }

    /// <summary>
    /// The ugc read action enum
    /// </summary>
    public enum UgcReadAction : long
    {
        /// <summary>
        /// The continue reading until finished ugc read action
        /// </summary>
        ContinueReadingUntilFinished = 0,
        /// <summary>
        /// The continue reading ugc read action
        /// </summary>
        ContinueReading = 1,
        /// <summary>
        /// The close ugc read action
        /// </summary>
        Close = 2
    }

    /// <summary>
    /// The workshop enumeration type enum
    /// </summary>
    public enum WorkshopEnumerationType : long
    {
        /// <summary>
        /// The ranked by vote workshop enumeration type
        /// </summary>
        RankedByVote = 0,
        /// <summary>
        /// The recent workshop enumeration type
        /// </summary>
        Recent = 1,
        /// <summary>
        /// The trending workshop enumeration type
        /// </summary>
        Trending = 2,
        /// <summary>
        /// The favorites of friends workshop enumeration type
        /// </summary>
        FavoritesOfFriends = 3,
        /// <summary>
        /// The voted by friends workshop enumeration type
        /// </summary>
        VotedByFriends = 4,
        /// <summary>
        /// The content by friends workshop enumeration type
        /// </summary>
        ContentByFriends = 5,
        /// <summary>
        /// The recent from followed users workshop enumeration type
        /// </summary>
        RecentFromFollowedUsers = 6
    }

    /// <summary>
    /// The workshop file action enum
    /// </summary>
    public enum WorkshopFileAction : long
    {
        /// <summary>
        /// The played workshop file action
        /// </summary>
        Played = 0,
        /// <summary>
        /// The completed workshop file action
        /// </summary>
        Completed = 1
    }

    /// <summary>
    /// The workshop file type enum
    /// </summary>
    public enum WorkshopFileType : long
    {
        /// <summary>
        /// The workshop file type first workshop file type
        /// </summary>
        WorkshopFileTypeFirst = 0,
        /// <summary>
        /// The workshop file type community workshop file type
        /// </summary>
        WorkshopFileTypeCommunity = 0,
        /// <summary>
        /// The workshop file type microtransaction workshop file type
        /// </summary>
        WorkshopFileTypeMicrotransaction = 1,
        /// <summary>
        /// The workshop file type collection workshop file type
        /// </summary>
        WorkshopFileTypeCollection = 2,
        /// <summary>
        /// The workshop file type art workshop file type
        /// </summary>
        WorkshopFileTypeArt = 3,
        /// <summary>
        /// The workshop file type video workshop file type
        /// </summary>
        WorkshopFileTypeVideo = 4,
        /// <summary>
        /// The workshop file type screenshot workshop file type
        /// </summary>
        WorkshopFileTypeScreenshot = 5,
        /// <summary>
        /// The workshop file type game workshop file type
        /// </summary>
        WorkshopFileTypeGame = 6,
        /// <summary>
        /// The workshop file type software workshop file type
        /// </summary>
        WorkshopFileTypeSoftware = 7,
        /// <summary>
        /// The workshop file type concept workshop file type
        /// </summary>
        WorkshopFileTypeConcept = 8,
        /// <summary>
        /// The workshop file type web guide workshop file type
        /// </summary>
        WorkshopFileTypeWebGuide = 9,
        /// <summary>
        /// The workshop file type integrated guide workshop file type
        /// </summary>
        WorkshopFileTypeIntegratedGuide = 10,
        /// <summary>
        /// The workshop file type merch workshop file type
        /// </summary>
        WorkshopFileTypeMerch = 11,
        /// <summary>
        /// The workshop file type controller binding workshop file type
        /// </summary>
        WorkshopFileTypeControllerBinding = 12,
        /// <summary>
        /// The workshop file type steamworks access invite workshop file type
        /// </summary>
        WorkshopFileTypeSteamworksAccessInvite = 13,
        /// <summary>
        /// The workshop file type steam video workshop file type
        /// </summary>
        WorkshopFileTypeSteamVideo = 14,
        /// <summary>
        /// The workshop file type game managed item workshop file type
        /// </summary>
        WorkshopFileTypeGameManagedItem = 15,
        /// <summary>
        /// The workshop file type max workshop file type
        /// </summary>
        WorkshopFileTypeMax = 16
    }

    /// <summary>
    /// The workshop video provider enum
    /// </summary>
    public enum WorkshopVideoProvider : long
    {
        /// <summary>
        /// The none workshop video provider
        /// </summary>
        None = 0,
        /// <summary>
        /// The youtube workshop video provider
        /// </summary>
        Youtube = 1
    }

    /// <summary>
    /// The workshop vote enum
    /// </summary>
    public enum WorkshopVote : long
    {
        /// <summary>
        /// The unvoted workshop vote
        /// </summary>
        Unvoted = 0,
        /// <summary>
        /// The for workshop vote
        /// </summary>
        For = 1,
        /// <summary>
        /// The against workshop vote
        /// </summary>
        Against = 2,
        /// <summary>
        /// The later workshop vote
        /// </summary>
        Later = 3
    }

    /// <summary>
    /// The local file change enum
    /// </summary>
    public enum LocalFileChange : long
    {
        /// <summary>
        /// The invalid local file change
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The file updated local file change
        /// </summary>
        FileUpdated = 1,
        /// <summary>
        /// The file deleted local file change
        /// </summary>
        FileDeleted = 2
    }

    /// <summary>
    /// The file path type enum
    /// </summary>
    public enum FilePathType : long
    {
        /// <summary>
        /// The invalid file path type
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The absolute file path type
        /// </summary>
        Absolute = 1,
        /// <summary>
        /// The api file name file path type
        /// </summary>
        ApiFileName = 2
    }
}