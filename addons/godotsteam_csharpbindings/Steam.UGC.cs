namespace GodotSteam;

public static partial class Steam
{
    public static void AddAppDependency(ulong publishedFileId, uint appId)
    {
        GetInstance().Call(Methods.AddAppDependency, publishedFileId, appId);
    }
    
    public static bool AddContentDescriptor(ulong updateHandle, long descriptorId)
    {
        return GetInstance().Call(Methods.AddContentDescriptor, updateHandle, descriptorId).As<bool>();
    }
    
    public static void AddDependency(ulong publishedFileId, long childPublishedFileId)
    {
        GetInstance().Call(Methods.AddDependency, publishedFileId, childPublishedFileId);
    }
    
    public static bool AddExcludedTag(ulong queryHandle, string tagName)
    {
        return GetInstance().Call(Methods.AddExcludedTag, queryHandle, tagName).As<bool>();
    }
    
    public static bool AddItemKeyValueTag(ulong queryHandle, string key, string value)
    {
        return GetInstance().Call(Methods.AddItemKeyValueTag, queryHandle, key, value).As<bool>();
    }
    
    public static bool AddItemPreviewFile(ulong queryHandle, string previewFile, ItemPreviewType type)
    {
        return GetInstance().Call(Methods.AddItemPreviewFile, queryHandle, previewFile, (long)type).As<bool>();
    }
    
    public static bool AddItemPreviewVideo(ulong queryHandle, string videoId)
    {
        return GetInstance().Call(Methods.AddItemPreviewVideo, queryHandle, videoId).As<bool>();
    }
    
    public static void AddItemToFavorites(uint appId, long publishedFileId)
    {
        GetInstance().Call(Methods.AddItemToFavorites, appId, publishedFileId);
    }
    
    public static bool AddRequiredKeyValueTag(ulong queryHandle, string key, string value)
    {
        return GetInstance().Call(Methods.AddRequiredKeyValueTag, queryHandle, key, value).As<bool>();
    }
    
    public static bool AddRequiredTag(ulong queryHandle, string tagName)
    {
        return GetInstance().Call(Methods.AddRequiredTag, queryHandle, tagName).As<bool>();
    }
    
    public static bool AddRequiredTagGroup(ulong queryHandle, Godot.Collections.Array tagArray)
    {
        return GetInstance().Call(Methods.AddRequiredTagGroup, queryHandle, tagArray).As<bool>();
    }
    
    public static bool InitWorkshopForGameServer(long workshopDepotId)
    {
        return GetInstance().Call(Methods.InitWorkshopForGameServer, workshopDepotId).As<bool>();
    }
    
    public static void CreateItem(uint appId, WorkshopFileType fileType)
    {
        GetInstance().Call(Methods.CreateItem, appId, (long)fileType);
    }
    
    public static ulong CreateQueryAllUGCRequest(UgcQuery queryType, UgcMatchingUgcType matchingType, uint creatorId, uint consumerId, long page)
    {
        return GetInstance().Call(Methods.CreateQueryAllUGCRequest, (long)queryType, (long)matchingType, creatorId, consumerId, page).As<ulong>();
    }
    
    public static ulong CreateQueryUGCDetailsRequest(Godot.Collections.Array publishedFileId)
    {
        return GetInstance().Call(Methods.CreateQueryUGCDetailsRequest, publishedFileId).As<ulong>();
    }
    
    public static ulong CreateQueryUserUGCRequest(ulong accountId, UserUgcList listType, UgcMatchingUgcType matchingUgcType, UserUgcListSortOrder sortOrder, uint creatorId, uint consumerId, long page)
    {
        return GetInstance().Call(Methods.CreateQueryUserUGCRequest, accountId, (long)listType, (long)matchingUgcType, (long)sortOrder, creatorId, consumerId, page).As<ulong>();
    }
    
    public static void DeleteItem(long publishedFileId)
    {
        GetInstance().Call(Methods.DeleteItem, publishedFileId);
    }
    
    public static bool DownloadItem(ulong publishedFileId, bool highPriority)
    {
        return GetInstance().Call(Methods.DownloadItem, publishedFileId, highPriority).As<bool>();
    }
    
    public static Godot.Collections.Dictionary GetItemDownloadInfo(long publishedFileId)
    {
        return GetInstance().Call(Methods.GetItemDownloadInfo, publishedFileId).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetItemInstallInfo(long publishedFileId)
    {
        return GetInstance().Call(Methods.GetItemInstallInfo, publishedFileId).AsGodotDictionary();
    }
    
    public static uint GetItemState(long publishedFileId)
    {
        return GetInstance().Call(Methods.GetItemState, publishedFileId).As<uint>();
    }
    
    public static Godot.Collections.Dictionary GetItemUpdateProgress(long updateHandle)
    {
        return GetInstance().Call(Methods.GetItemUpdateProgress, updateHandle).AsGodotDictionary();
    }
    
    public static long GetNumSubscribedItems()
    {
        return GetInstance().Call(Methods.GetNumSubscribedItems).AsInt64();
    }
    
    public static Godot.Collections.Dictionary GetQueryUGCAdditionalPreview(ulong queryHandle, uint index, long previewIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCAdditionalPreview, queryHandle, index, previewIndex).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetQueryUGCChildren(ulong queryHandle, uint index, long childCount)
    {
        return GetInstance().Call(Methods.GetQueryUGCChildren, queryHandle, index, childCount).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetQueryUGCContentDescriptors(ulong queryHandle, uint index, long maxEntries)
    {
        return GetInstance().Call(Methods.GetQueryUGCContentDescriptors, queryHandle, index, maxEntries).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetQueryUGCKeyValueTag(ulong queryHandle, uint index, long keyValueTagIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCKeyValueTag, queryHandle, index, keyValueTagIndex).AsGodotDictionary();
    }
    
    public static string GetQueryUGCMetadata(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCMetadata, queryHandle, index).As<string>();
    }
    
    public static uint GetQueryUGCNumAdditionalPreviews(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCNumAdditionalPreviews, queryHandle, index).As<uint>();
    }
    
    public static uint GetQueryUGCNumKeyValueTags(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCNumKeyValueTags, queryHandle, index).As<uint>();
    }
    
    public static uint GetQueryUGCNumTags(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCNumTags, queryHandle, index).As<uint>();
    }
    
    public static string GetQueryUGCPreviewURL(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCPreviewURL, queryHandle, index).As<string>();
    }
    
    public static Godot.Collections.Dictionary GetQueryUGCResult(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCResult, queryHandle, index).AsGodotDictionary();
    }
    
    public static Godot.Collections.Dictionary GetQueryUGCStatistic(ulong queryHandle, uint index, ItemStatistic statType)
    {
        return GetInstance().Call(Methods.GetQueryUGCStatistic, queryHandle, index, (long)statType).AsGodotDictionary();
    }
    
    public static string GetQueryUGCTag(ulong queryHandle, uint index, long tagIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCTag, queryHandle, index, tagIndex).As<string>();
    }
    
    public static string GetQueryUGCTagDisplayName(ulong queryHandle, uint index, long tagIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCTagDisplayName, queryHandle, index, tagIndex).As<string>();
    }
    
    public static Godot.Collections.Array GetSubscribedItems()
    {
        return GetInstance().Call(Methods.GetSubscribedItems).AsGodotArray();
    }
    
    public static Godot.Collections.Array GetUserContentDescriptorPreferences(long maxEntries)
    {
        return GetInstance().Call(Methods.GetUserContentDescriptorPreferences, maxEntries).AsGodotArray();
    }
    
    public static void GetUserItemVote(long publishedFileId)
    {
        GetInstance().Call(Methods.GetUserItemVote, publishedFileId);
    }
    
    public static bool ReleaseQueryUGCRequest(long queryHandle)
    {
        return GetInstance().Call(Methods.ReleaseQueryUGCRequest, queryHandle).As<bool>();
    }
    
    public static void RemoveAppDependency(ulong publishedFileId, uint appId)
    {
        GetInstance().Call(Methods.RemoveAppDependency, publishedFileId, appId);
    }
    
    public static bool RemoveContentDescriptor(ulong updateHandle, long descriptorId)
    {
        return GetInstance().Call(Methods.RemoveContentDescriptor, updateHandle, descriptorId).As<bool>();
    }
    
    public static void RemoveDependency(ulong publishedFileId, long childPublishedFileId)
    {
        GetInstance().Call(Methods.RemoveDependency, publishedFileId, childPublishedFileId);
    }
    
    public static void RemoveItemFromFavorites(uint appId, long publishedFileId)
    {
        GetInstance().Call(Methods.RemoveItemFromFavorites, appId, publishedFileId);
    }
    
    public static bool RemoveItemKeyValueTags(ulong updateHandle, string key)
    {
        return GetInstance().Call(Methods.RemoveItemKeyValueTags, updateHandle, key).As<bool>();
    }
    
    public static bool RemoveItemPreview(ulong updateHandle, long index)
    {
        return GetInstance().Call(Methods.RemoveItemPreview, updateHandle, index).As<bool>();
    }
    
    public static void SendQueryUGCRequest(long updateHandle)
    {
        GetInstance().Call(Methods.SendQueryUGCRequest, updateHandle);
    }
    
    public static bool SetAllowCachedResponse(ulong updateHandle, long maxAgeSeconds)
    {
        return GetInstance().Call(Methods.SetAllowCachedResponse, updateHandle, maxAgeSeconds).As<bool>();
    }
    
    public static bool SetCloudFileNameFilter(ulong updateHandle, string matchCloudFileName)
    {
        return GetInstance().Call(Methods.SetCloudFileNameFilter, updateHandle, matchCloudFileName).As<bool>();
    }
    
    public static bool SetItemContent(ulong updateHandle, string contentFolder)
    {
        return GetInstance().Call(Methods.SetItemContent, updateHandle, contentFolder).As<bool>();
    }
    
    public static bool SetItemDescription(ulong updateHandle, string description)
    {
        return GetInstance().Call(Methods.SetItemDescription, updateHandle, description).As<bool>();
    }
    
    public static bool SetItemMetadata(ulong updateHandle, string ugcMetadata)
    {
        return GetInstance().Call(Methods.SetItemMetadata, updateHandle, ugcMetadata).As<bool>();
    }
    
    public static bool SetItemPreview(ulong updateHandle, string previewFile)
    {
        return GetInstance().Call(Methods.SetItemPreview, updateHandle, previewFile).As<bool>();
    }
    
    public static bool SetItemTags(ulong updateHandle, Godot.Collections.Array tagArray, bool allowAdminTags = false)
    {
        return GetInstance().Call(Methods.SetItemTags, updateHandle, tagArray, allowAdminTags).As<bool>();
    }
    
    public static bool SetItemTitle(ulong updateHandle, string title)
    {
        return GetInstance().Call(Methods.SetItemTitle, updateHandle, title).As<bool>();
    }
    
    public static bool SetItemUpdateLanguage(ulong updateHandle, string language)
    {
        return GetInstance().Call(Methods.SetItemUpdateLanguage, updateHandle, language).As<bool>();
    }
    
    public static bool SetItemVisibility(ulong updateHandle, RemoteStoragePublishedFileVisibility visibility)
    {
        return GetInstance().Call(Methods.SetItemVisibility, updateHandle, (long)visibility).As<bool>();
    }
    
    public static bool SetLanguage(ulong queryHandle, string language)
    {
        return GetInstance().Call(Methods.SetLanguage, queryHandle, language).As<bool>();
    }
    
    public static bool SetMatchAnyTag(ulong queryHandle, bool matchAnyTag)
    {
        return GetInstance().Call(Methods.SetMatchAnyTag, queryHandle, matchAnyTag).As<bool>();
    }
    
    public static bool SetRankedByTrendDays(ulong queryHandle, long days)
    {
        return GetInstance().Call(Methods.SetRankedByTrendDays, queryHandle, days).As<bool>();
    }
    
    public static bool SetReturnAdditionalPreviews(ulong queryHandle, bool returnAdditionalPreviews)
    {
        return GetInstance().Call(Methods.SetReturnAdditionalPreviews, queryHandle, returnAdditionalPreviews).As<bool>();
    }
    
    public static bool SetReturnChildren(ulong queryHandle, bool returnChildren)
    {
        return GetInstance().Call(Methods.SetReturnChildren, queryHandle, returnChildren).As<bool>();
    }
    
    public static bool SetReturnKeyValueTags(ulong queryHandle, bool returnKeyValueTags)
    {
        return GetInstance().Call(Methods.SetReturnKeyValueTags, queryHandle, returnKeyValueTags).As<bool>();
    }
    
    public static bool SetReturnLongDescription(ulong queryHandle, bool returnLongDescription)
    {
        return GetInstance().Call(Methods.SetReturnLongDescription, queryHandle, returnLongDescription).As<bool>();
    }
    
    public static bool SetReturnMetadata(ulong queryHandle, bool returnMetadata)
    {
        return GetInstance().Call(Methods.SetReturnMetadata, queryHandle, returnMetadata).As<bool>();
    }
    
    public static bool SetReturnOnlyIDs(ulong queryHandle, bool returnOnlyIds)
    {
        return GetInstance().Call(Methods.SetReturnOnlyIDs, queryHandle, returnOnlyIds).As<bool>();
    }
    
    public static bool SetReturnPlaytimeStats(ulong queryHandle, long days)
    {
        return GetInstance().Call(Methods.SetReturnPlaytimeStats, queryHandle, days).As<bool>();
    }
    
    public static bool SetReturnTotalOnly(ulong queryHandle, bool returnTotalOnly)
    {
        return GetInstance().Call(Methods.SetReturnTotalOnly, queryHandle, returnTotalOnly).As<bool>();
    }
    
    public static bool SetSearchText(ulong queryHandle, string searchText)
    {
        return GetInstance().Call(Methods.SetSearchText, queryHandle, searchText).As<bool>();
    }
    
    public static void SetUserItemVote(ulong publishedFileId, bool voteUp)
    {
        GetInstance().Call(Methods.SetUserItemVote, publishedFileId, voteUp);
    }
    
    public static ulong StartItemUpdate(uint appId, long fileId)
    {
        return GetInstance().Call(Methods.StartItemUpdate, appId, fileId).As<ulong>();
    }
    
    public static void StartPlaytimeTracking(Godot.Collections.Array publishedFileIds)
    {
        GetInstance().Call(Methods.StartPlaytimeTracking, publishedFileIds);
    }
    
    public static void StopPlaytimeTracking(Godot.Collections.Array publishedFileIds)
    {
        GetInstance().Call(Methods.StopPlaytimeTracking, publishedFileIds);
    }
    
    public static void StopPlaytimeTrackingForAllItems()
    {
        GetInstance().Call(Methods.StopPlaytimeTrackingForAllItems);
    }
    
    public static void GetAppDependencies(long publishedFileId)
    {
        GetInstance().Call(Methods.GetAppDependencies, publishedFileId);
    }
    
    public static void SubmitItemUpdate(ulong updateHandle, string changeNote)
    {
        GetInstance().Call(Methods.SubmitItemUpdate, updateHandle, changeNote);
    }
    
    public static void SubscribeItem(long publishedFileId)
    {
        GetInstance().Call(Methods.SubscribeItem, publishedFileId);
    }
    
    public static void SuspendDownloads(bool suspend)
    {
        GetInstance().Call(Methods.SuspendDownloads, suspend);
    }
    
    public static void UnsubscribeItem(long publishedFileId)
    {
        GetInstance().Call(Methods.UnsubscribeItem, publishedFileId);
    }
    
    public static bool UpdateItemPreviewFile(ulong updateHandle, uint index, string previewFile)
    {
        return GetInstance().Call(Methods.UpdateItemPreviewFile, updateHandle, index, previewFile).As<bool>();
    }
    
    public static bool UpdateItemPreviewVideo(ulong updateHandle, uint index, string videoId)
    {
        return GetInstance().Call(Methods.UpdateItemPreviewVideo, updateHandle, index, videoId).As<bool>();
    }
    
    public static bool ShowWorkshopEULA()
    {
        return GetInstance().Call(Methods.ShowWorkshopEULA).As<bool>();
    }
    
    public static void GetWorkshopEULAStatus()
    {
        GetInstance().Call(Methods.GetWorkshopEULAStatus);
    }
    
    public static bool SetTimeCreatedDateRange(ulong updateHandle, uint start, long end)
    {
        return GetInstance().Call(Methods.SetTimeCreatedDateRange, updateHandle, start, end).As<bool>();
    }
    
    public static bool SetTimeUpdatedDateRange(ulong updateHandle, uint start, long end)
    {
        return GetInstance().Call(Methods.SetTimeUpdatedDateRange, updateHandle, start, end).As<bool>();
    }

    public enum ItemPreviewType : long
    {
        Image = 0,
        YoutubeVideo = 1,
        Sketchfab = 2,
        EnvironmentmapHorizontalCross = 3,
        EnvironmentmapLatLong = 4,
        ReservedMax = 255
    }

    [System.Flags]
    public enum ItemState : long
    {
        None = 0,
        Subscribed = 1,
        LegacyItem = 2,
        Installed = 4,
        NeedsUpdate = 8,
        Downloading = 16,
        DownloadPending = 32
    }

    public enum ItemStatistic : long
    {
        NumSubscriptions = 0,
        NumFavorites = 1,
        NumFollowers = 2,
        NumUniqueSubscriptions = 3,
        NumUniqueFavorites = 4,
        NumUniqueFollowers = 5,
        NumUniqueWebsiteViews = 6,
        ReportScore = 7,
        NumSecondsPlayed = 8,
        NumPlaytimeSessions = 9,
        NumComments = 10,
        NumSecondsPlayedDuringTimePeriod = 11,
        NumPlaytimeSessionsDuringTimePeriod = 12
    }

    public enum ItemUpdateStatus : long
    {
        Invalid = 0,
        PreparingConfig = 1,
        PreparingContent = 2,
        UploadingContent = 3,
        UploadingPreviewFile = 4,
        CommittingChanges = 5
    }

    public enum UserUgcList : long
    {
        Published = 0,
        VotedOn = 1,
        VotedUp = 2,
        VotedDown = 3,
        WillVoteLater = 4,
        Favorited = 5,
        Subscribed = 6,
        UsedOrPlayed = 7,
        Followed = 8
    }

    public enum UserUgcListSortOrder : long
    {
        UserugclistsortorderCreationorderdesc = 0,
        UserugclistsortorderCreationorderasc = 1,
        UserugclistsortorderTitleasc = 2,
        UserugclistsortorderLastupdateddesc = 3,
        UserugclistsortorderSubscriptiondatedesc = 4,
        UserugclistsortorderVotescoredesc = 5,
        SerugclistsortorderFormoderation = 6
    }

    public enum UgcQuery : long
    {
        RankedByVote = 0,
        RankedByPublicationDate = 1,
        AcceptedForGameRankedByAcceptanceDate = 2,
        RankedByTrend = 3,
        FavoritedByFriendsRankedByPublicationDate = 4,
        CreatedByFriendsRankedByPublicationDate = 5,
        RankedByNumTimesReported = 6,
        CreatedByFollowedUsersRankedByPublicationDate = 7,
        NotYetRated = 8,
        RankedByTotalVotesAsc = 9,
        RankedByVotesUp = 10,
        RankedByTextSearch = 11,
        RankedByTotalUniqueSubscriptions = 12,
        RankedByPlaytimeTrend = 13,
        RankedByTotalPlaytime = 14,
        RankedByAveragePlaytimeTrend = 15,
        RankedByLifetimeAveragePlaytime = 16,
        RankedByPlaytimeSessionsTrend = 17,
        RankedByLifetimePlaytimeSessions = 18,
        RankedByLastUpdatedDate = 19
    }

    public enum UgcContentDescriptorId : long
    {
        NudityOrSexualContent = 1,
        FrequentViolenceOrGore = 2,
        AdultOnlySexualContent = 3,
        GratuitousSexualContent = 4,
        AnyMatureContent = 5
    }

    public enum UgcMatchingUgcType : long
    {
        MatchingugctypeItems = 0,
        MatchingUgcTypeItemsMtx = 1,
        MatchingUgcTypeItemsReadyToUse = 2,
        MatchingUgcTypeCollections = 3,
        MatchingUgcTypeArtwork = 4,
        MatchingUgcTypeVideos = 5,
        MatchingUgcTypeScreenshots = 6,
        MatchingUgcTypeAllGuides = 7,
        MatchingUgcTypeWebGuides = 8,
        MatchingUgcTypeIntegratedGuides = 9,
        MatchingUgcTypeUsableInGame = 10,
        MatchingUgcTypeControllerBindings = 11,
        MatchingUgcTypeGameManagedItems = 12,
        MatchingUgcTypeAll = -1
    }
}