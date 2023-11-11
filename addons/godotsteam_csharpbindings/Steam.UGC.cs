namespace GodotSteam;

/// <summary>

/// The steam class

/// </summary>

public static partial class Steam
{
    /// <summary>
    /// Adds the app dependency using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <param name="appId">The app id</param>
    public static void AddAppDependency(ulong publishedFileId, uint appId)
    {
        GetInstance().Call(Methods.AddAppDependency, publishedFileId, appId);
    }
    
    /// <summary>
    /// Describes whether add content descriptor
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="descriptorId">The descriptor id</param>
    /// <returns>The bool</returns>
    public static bool AddContentDescriptor(ulong updateHandle, long descriptorId)
    {
        return GetInstance().Call(Methods.AddContentDescriptor, updateHandle, descriptorId).AsBool();
    }
    
    /// <summary>
    /// Adds the dependency using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <param name="childPublishedFileId">The child published file id</param>
    public static void AddDependency(ulong publishedFileId, long childPublishedFileId)
    {
        GetInstance().Call(Methods.AddDependency, publishedFileId, childPublishedFileId);
    }
    
    /// <summary>
    /// Describes whether add excluded tag
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="tagName">The tag name</param>
    /// <returns>The bool</returns>
    public static bool AddExcludedTag(ulong queryHandle, string tagName)
    {
        return GetInstance().Call(Methods.AddExcludedTag, queryHandle, tagName).AsBool();
    }
    
    /// <summary>
    /// Describes whether add item key value tag
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool AddItemKeyValueTag(ulong queryHandle, string key, string value)
    {
        return GetInstance().Call(Methods.AddItemKeyValueTag, queryHandle, key, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether add item preview file
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="previewFile">The preview file</param>
    /// <param name="type">The type</param>
    /// <returns>The bool</returns>
    public static bool AddItemPreviewFile(ulong queryHandle, string previewFile, ItemPreviewType type)
    {
        return GetInstance().Call(Methods.AddItemPreviewFile, queryHandle, previewFile, (long)type).AsBool();
    }
    
    /// <summary>
    /// Describes whether add item preview video
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="videoId">The video id</param>
    /// <returns>The bool</returns>
    public static bool AddItemPreviewVideo(ulong queryHandle, string videoId)
    {
        return GetInstance().Call(Methods.AddItemPreviewVideo, queryHandle, videoId).AsBool();
    }
    
    /// <summary>
    /// Adds the item to favorites using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="publishedFileId">The published file id</param>
    public static void AddItemToFavorites(uint appId, long publishedFileId)
    {
        GetInstance().Call(Methods.AddItemToFavorites, appId, publishedFileId);
    }
    
    /// <summary>
    /// Describes whether add required key value tag
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="key">The key</param>
    /// <param name="value">The value</param>
    /// <returns>The bool</returns>
    public static bool AddRequiredKeyValueTag(ulong queryHandle, string key, string value)
    {
        return GetInstance().Call(Methods.AddRequiredKeyValueTag, queryHandle, key, value).AsBool();
    }
    
    /// <summary>
    /// Describes whether add required tag
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="tagName">The tag name</param>
    /// <returns>The bool</returns>
    public static bool AddRequiredTag(ulong queryHandle, string tagName)
    {
        return GetInstance().Call(Methods.AddRequiredTag, queryHandle, tagName).AsBool();
    }
    
    /// <summary>
    /// Describes whether add required tag group
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="tagArray">The tag array</param>
    /// <returns>The bool</returns>
    public static bool AddRequiredTagGroup(ulong queryHandle, Godot.Collections.Array tagArray)
    {
        return GetInstance().Call(Methods.AddRequiredTagGroup, queryHandle, tagArray).AsBool();
    }
    
    /// <summary>
    /// Describes whether init workshop for game server
    /// </summary>
    /// <param name="workshopDepotId">The workshop depot id</param>
    /// <returns>The bool</returns>
    public static bool InitWorkshopForGameServer(long workshopDepotId)
    {
        return GetInstance().Call(Methods.InitWorkshopForGameServer, workshopDepotId).AsBool();
    }
    
    /// <summary>
    /// Creates the item using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="fileType">The file type</param>
    public static void CreateItem(uint appId, WorkshopFileType fileType)
    {
        GetInstance().Call(Methods.CreateItem, appId, (long)fileType);
    }
    
    /// <summary>
    /// Creates the query all ugc request using the specified query type
    /// </summary>
    /// <param name="queryType">The query type</param>
    /// <param name="matchingType">The matching type</param>
    /// <param name="creatorId">The creator id</param>
    /// <param name="consumerId">The consumer id</param>
    /// <param name="page">The page</param>
    /// <returns>The ulong</returns>
    public static ulong CreateQueryAllUGCRequest(UgcQuery queryType, UgcMatchingUgcType matchingType, uint creatorId, uint consumerId, long page)
    {
        return GetInstance().Call(Methods.CreateQueryAllUGCRequest, (long)queryType, (long)matchingType, creatorId, consumerId, page).AsUInt64();
    }
    
    /// <summary>
    /// Creates the query ugc details request using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <returns>The ulong</returns>
    public static ulong CreateQueryUGCDetailsRequest(Godot.Collections.Array publishedFileId)
    {
        return GetInstance().Call(Methods.CreateQueryUGCDetailsRequest, publishedFileId).AsUInt64();
    }
    
    /// <summary>
    /// Creates the query user ugc request using the specified account id
    /// </summary>
    /// <param name="accountId">The account id</param>
    /// <param name="listType">The list type</param>
    /// <param name="matchingUgcType">The matching ugc type</param>
    /// <param name="sortOrder">The sort order</param>
    /// <param name="creatorId">The creator id</param>
    /// <param name="consumerId">The consumer id</param>
    /// <param name="page">The page</param>
    /// <returns>The ulong</returns>
    public static ulong CreateQueryUserUGCRequest(ulong accountId, UserUgcList listType, UgcMatchingUgcType matchingUgcType, UserUgcListSortOrder sortOrder, uint creatorId, uint consumerId, long page)
    {
        return GetInstance().Call(Methods.CreateQueryUserUGCRequest, accountId, (long)listType, (long)matchingUgcType, (long)sortOrder, creatorId, consumerId, page).AsUInt64();
    }
    
    /// <summary>
    /// Deletes the item using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    public static void DeleteItem(long publishedFileId)
    {
        GetInstance().Call(Methods.DeleteItem, publishedFileId);
    }
    
    /// <summary>
    /// Describes whether download item
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <param name="highPriority">The high priority</param>
    /// <returns>The bool</returns>
    public static bool DownloadItem(ulong publishedFileId, bool highPriority)
    {
        return GetInstance().Call(Methods.DownloadItem, publishedFileId, highPriority).AsBool();
    }
    
    /// <summary>
    /// Gets the item download info using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetItemDownloadInfo(long publishedFileId)
    {
        return GetInstance().Call(Methods.GetItemDownloadInfo, publishedFileId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the item install info using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetItemInstallInfo(long publishedFileId)
    {
        return GetInstance().Call(Methods.GetItemInstallInfo, publishedFileId).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the item state using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <returns>The uint</returns>
    public static uint GetItemState(long publishedFileId)
    {
        return GetInstance().Call(Methods.GetItemState, publishedFileId).AsUInt32();
    }
    
    /// <summary>
    /// Gets the item update progress using the specified update handle
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetItemUpdateProgress(long updateHandle)
    {
        return GetInstance().Call(Methods.GetItemUpdateProgress, updateHandle).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the num subscribed items
    /// </summary>
    /// <returns>The long</returns>
    public static long GetNumSubscribedItems()
    {
        return GetInstance().Call(Methods.GetNumSubscribedItems).AsInt64();
    }
    
    /// <summary>
    /// Gets the query ugc additional preview using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="previewIndex">The preview index</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQueryUGCAdditionalPreview(ulong queryHandle, uint index, long previewIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCAdditionalPreview, queryHandle, index, previewIndex).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the query ugc children using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="childCount">The child count</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQueryUGCChildren(ulong queryHandle, uint index, long childCount)
    {
        return GetInstance().Call(Methods.GetQueryUGCChildren, queryHandle, index, childCount).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the query ugc content descriptors using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="maxEntries">The max entries</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQueryUGCContentDescriptors(ulong queryHandle, uint index, long maxEntries)
    {
        return GetInstance().Call(Methods.GetQueryUGCContentDescriptors, queryHandle, index, maxEntries).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the query ugc key value tag using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="keyValueTagIndex">The key value tag index</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQueryUGCKeyValueTag(ulong queryHandle, uint index, long keyValueTagIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCKeyValueTag, queryHandle, index, keyValueTagIndex).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the query ugc metadata using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <returns>The string</returns>
    public static string GetQueryUGCMetadata(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCMetadata, queryHandle, index).AsString();
    }
    
    /// <summary>
    /// Gets the query ugc num additional previews using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <returns>The uint</returns>
    public static uint GetQueryUGCNumAdditionalPreviews(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCNumAdditionalPreviews, queryHandle, index).AsUInt32();
    }
    
    /// <summary>
    /// Gets the query ugc num key value tags using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <returns>The uint</returns>
    public static uint GetQueryUGCNumKeyValueTags(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCNumKeyValueTags, queryHandle, index).AsUInt32();
    }
    
    /// <summary>
    /// Gets the query ugc num tags using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <returns>The uint</returns>
    public static uint GetQueryUGCNumTags(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCNumTags, queryHandle, index).AsUInt32();
    }
    
    /// <summary>
    /// Gets the query ugc preview url using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <returns>The string</returns>
    public static string GetQueryUGCPreviewURL(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCPreviewURL, queryHandle, index).AsString();
    }
    
    /// <summary>
    /// Gets the query ugc result using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQueryUGCResult(ulong queryHandle, long index)
    {
        return GetInstance().Call(Methods.GetQueryUGCResult, queryHandle, index).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the query ugc statistic using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="statType">The stat type</param>
    /// <returns>The godot collections dictionary</returns>
    public static Godot.Collections.Dictionary GetQueryUGCStatistic(ulong queryHandle, uint index, ItemStatistic statType)
    {
        return GetInstance().Call(Methods.GetQueryUGCStatistic, queryHandle, index, (long)statType).AsGodotDictionary();
    }
    
    /// <summary>
    /// Gets the query ugc tag using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="tagIndex">The tag index</param>
    /// <returns>The string</returns>
    public static string GetQueryUGCTag(ulong queryHandle, uint index, long tagIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCTag, queryHandle, index, tagIndex).AsString();
    }
    
    /// <summary>
    /// Gets the query ugc tag display name using the specified query handle
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="index">The index</param>
    /// <param name="tagIndex">The tag index</param>
    /// <returns>The string</returns>
    public static string GetQueryUGCTagDisplayName(ulong queryHandle, uint index, long tagIndex)
    {
        return GetInstance().Call(Methods.GetQueryUGCTagDisplayName, queryHandle, index, tagIndex).AsString();
    }
    
    /// <summary>
    /// Gets the subscribed items
    /// </summary>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetSubscribedItems()
    {
        return GetInstance().Call(Methods.GetSubscribedItems).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the user content descriptor preferences using the specified max entries
    /// </summary>
    /// <param name="maxEntries">The max entries</param>
    /// <returns>The godot collections array</returns>
    public static Godot.Collections.Array GetUserContentDescriptorPreferences(long maxEntries)
    {
        return GetInstance().Call(Methods.GetUserContentDescriptorPreferences, maxEntries).AsGodotArray();
    }
    
    /// <summary>
    /// Gets the user item vote using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    public static void GetUserItemVote(long publishedFileId)
    {
        GetInstance().Call(Methods.GetUserItemVote, publishedFileId);
    }
    
    /// <summary>
    /// Describes whether release query ugc request
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <returns>The bool</returns>
    public static bool ReleaseQueryUGCRequest(long queryHandle)
    {
        return GetInstance().Call(Methods.ReleaseQueryUGCRequest, queryHandle).AsBool();
    }
    
    /// <summary>
    /// Removes the app dependency using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <param name="appId">The app id</param>
    public static void RemoveAppDependency(ulong publishedFileId, uint appId)
    {
        GetInstance().Call(Methods.RemoveAppDependency, publishedFileId, appId);
    }
    
    /// <summary>
    /// Describes whether remove content descriptor
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="descriptorId">The descriptor id</param>
    /// <returns>The bool</returns>
    public static bool RemoveContentDescriptor(ulong updateHandle, long descriptorId)
    {
        return GetInstance().Call(Methods.RemoveContentDescriptor, updateHandle, descriptorId).AsBool();
    }
    
    /// <summary>
    /// Removes the dependency using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <param name="childPublishedFileId">The child published file id</param>
    public static void RemoveDependency(ulong publishedFileId, long childPublishedFileId)
    {
        GetInstance().Call(Methods.RemoveDependency, publishedFileId, childPublishedFileId);
    }
    
    /// <summary>
    /// Removes the item from favorites using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="publishedFileId">The published file id</param>
    public static void RemoveItemFromFavorites(uint appId, long publishedFileId)
    {
        GetInstance().Call(Methods.RemoveItemFromFavorites, appId, publishedFileId);
    }
    
    /// <summary>
    /// Describes whether remove item key value tags
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="key">The key</param>
    /// <returns>The bool</returns>
    public static bool RemoveItemKeyValueTags(ulong updateHandle, string key)
    {
        return GetInstance().Call(Methods.RemoveItemKeyValueTags, updateHandle, key).AsBool();
    }
    
    /// <summary>
    /// Describes whether remove item preview
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="index">The index</param>
    /// <returns>The bool</returns>
    public static bool RemoveItemPreview(ulong updateHandle, long index)
    {
        return GetInstance().Call(Methods.RemoveItemPreview, updateHandle, index).AsBool();
    }
    
    /// <summary>
    /// Sends the query ugc request using the specified update handle
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    public static void SendQueryUGCRequest(long updateHandle)
    {
        GetInstance().Call(Methods.SendQueryUGCRequest, updateHandle);
    }
    
    /// <summary>
    /// Describes whether set allow cached response
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="maxAgeSeconds">The max age seconds</param>
    /// <returns>The bool</returns>
    public static bool SetAllowCachedResponse(ulong updateHandle, long maxAgeSeconds)
    {
        return GetInstance().Call(Methods.SetAllowCachedResponse, updateHandle, maxAgeSeconds).AsBool();
    }
    
    /// <summary>
    /// Describes whether set cloud file name filter
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="matchCloudFileName">The match cloud file name</param>
    /// <returns>The bool</returns>
    public static bool SetCloudFileNameFilter(ulong updateHandle, string matchCloudFileName)
    {
        return GetInstance().Call(Methods.SetCloudFileNameFilter, updateHandle, matchCloudFileName).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item content
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="contentFolder">The content folder</param>
    /// <returns>The bool</returns>
    public static bool SetItemContent(ulong updateHandle, string contentFolder)
    {
        return GetInstance().Call(Methods.SetItemContent, updateHandle, contentFolder).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item description
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="description">The description</param>
    /// <returns>The bool</returns>
    public static bool SetItemDescription(ulong updateHandle, string description)
    {
        return GetInstance().Call(Methods.SetItemDescription, updateHandle, description).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item metadata
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="ugcMetadata">The ugc metadata</param>
    /// <returns>The bool</returns>
    public static bool SetItemMetadata(ulong updateHandle, string ugcMetadata)
    {
        return GetInstance().Call(Methods.SetItemMetadata, updateHandle, ugcMetadata).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item preview
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="previewFile">The preview file</param>
    /// <returns>The bool</returns>
    public static bool SetItemPreview(ulong updateHandle, string previewFile)
    {
        return GetInstance().Call(Methods.SetItemPreview, updateHandle, previewFile).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item tags
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="tagArray">The tag array</param>
    /// <param name="allowAdminTags">The allow admin tags</param>
    /// <returns>The bool</returns>
    public static bool SetItemTags(ulong updateHandle, Godot.Collections.Array tagArray, bool allowAdminTags = false)
    {
        return GetInstance().Call(Methods.SetItemTags, updateHandle, tagArray, allowAdminTags).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item title
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="title">The title</param>
    /// <returns>The bool</returns>
    public static bool SetItemTitle(ulong updateHandle, string title)
    {
        return GetInstance().Call(Methods.SetItemTitle, updateHandle, title).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item update language
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="language">The language</param>
    /// <returns>The bool</returns>
    public static bool SetItemUpdateLanguage(ulong updateHandle, string language)
    {
        return GetInstance().Call(Methods.SetItemUpdateLanguage, updateHandle, language).AsBool();
    }
    
    /// <summary>
    /// Describes whether set item visibility
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="visibility">The visibility</param>
    /// <returns>The bool</returns>
    public static bool SetItemVisibility(ulong updateHandle, RemoteStoragePublishedFileVisibility visibility)
    {
        return GetInstance().Call(Methods.SetItemVisibility, updateHandle, (long)visibility).AsBool();
    }
    
    /// <summary>
    /// Describes whether set language
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="language">The language</param>
    /// <returns>The bool</returns>
    public static bool SetLanguage(ulong queryHandle, string language)
    {
        return GetInstance().Call(Methods.SetLanguage, queryHandle, language).AsBool();
    }
    
    /// <summary>
    /// Describes whether set match any tag
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="matchAnyTag">The match any tag</param>
    /// <returns>The bool</returns>
    public static bool SetMatchAnyTag(ulong queryHandle, bool matchAnyTag)
    {
        return GetInstance().Call(Methods.SetMatchAnyTag, queryHandle, matchAnyTag).AsBool();
    }
    
    /// <summary>
    /// Describes whether set ranked by trend days
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="days">The days</param>
    /// <returns>The bool</returns>
    public static bool SetRankedByTrendDays(ulong queryHandle, long days)
    {
        return GetInstance().Call(Methods.SetRankedByTrendDays, queryHandle, days).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return additional previews
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnAdditionalPreviews">The return additional previews</param>
    /// <returns>The bool</returns>
    public static bool SetReturnAdditionalPreviews(ulong queryHandle, bool returnAdditionalPreviews)
    {
        return GetInstance().Call(Methods.SetReturnAdditionalPreviews, queryHandle, returnAdditionalPreviews).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return children
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnChildren">The return children</param>
    /// <returns>The bool</returns>
    public static bool SetReturnChildren(ulong queryHandle, bool returnChildren)
    {
        return GetInstance().Call(Methods.SetReturnChildren, queryHandle, returnChildren).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return key value tags
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnKeyValueTags">The return key value tags</param>
    /// <returns>The bool</returns>
    public static bool SetReturnKeyValueTags(ulong queryHandle, bool returnKeyValueTags)
    {
        return GetInstance().Call(Methods.SetReturnKeyValueTags, queryHandle, returnKeyValueTags).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return long description
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnLongDescription">The return long description</param>
    /// <returns>The bool</returns>
    public static bool SetReturnLongDescription(ulong queryHandle, bool returnLongDescription)
    {
        return GetInstance().Call(Methods.SetReturnLongDescription, queryHandle, returnLongDescription).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return metadata
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnMetadata">The return metadata</param>
    /// <returns>The bool</returns>
    public static bool SetReturnMetadata(ulong queryHandle, bool returnMetadata)
    {
        return GetInstance().Call(Methods.SetReturnMetadata, queryHandle, returnMetadata).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return only i ds
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnOnlyIds">The return only ids</param>
    /// <returns>The bool</returns>
    public static bool SetReturnOnlyIDs(ulong queryHandle, bool returnOnlyIds)
    {
        return GetInstance().Call(Methods.SetReturnOnlyIDs, queryHandle, returnOnlyIds).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return playtime stats
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="days">The days</param>
    /// <returns>The bool</returns>
    public static bool SetReturnPlaytimeStats(ulong queryHandle, long days)
    {
        return GetInstance().Call(Methods.SetReturnPlaytimeStats, queryHandle, days).AsBool();
    }
    
    /// <summary>
    /// Describes whether set return total only
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="returnTotalOnly">The return total only</param>
    /// <returns>The bool</returns>
    public static bool SetReturnTotalOnly(ulong queryHandle, bool returnTotalOnly)
    {
        return GetInstance().Call(Methods.SetReturnTotalOnly, queryHandle, returnTotalOnly).AsBool();
    }
    
    /// <summary>
    /// Describes whether set search text
    /// </summary>
    /// <param name="queryHandle">The query handle</param>
    /// <param name="searchText">The search text</param>
    /// <returns>The bool</returns>
    public static bool SetSearchText(ulong queryHandle, string searchText)
    {
        return GetInstance().Call(Methods.SetSearchText, queryHandle, searchText).AsBool();
    }
    
    /// <summary>
    /// Sets the user item vote using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    /// <param name="voteUp">The vote up</param>
    public static void SetUserItemVote(ulong publishedFileId, bool voteUp)
    {
        GetInstance().Call(Methods.SetUserItemVote, publishedFileId, voteUp);
    }
    
    /// <summary>
    /// Starts the item update using the specified app id
    /// </summary>
    /// <param name="appId">The app id</param>
    /// <param name="fileId">The file id</param>
    /// <returns>The ulong</returns>
    public static ulong StartItemUpdate(uint appId, long fileId)
    {
        return GetInstance().Call(Methods.StartItemUpdate, appId, fileId).AsUInt64();
    }
    
    /// <summary>
    /// Starts the playtime tracking using the specified published file ids
    /// </summary>
    /// <param name="publishedFileIds">The published file ids</param>
    public static void StartPlaytimeTracking(Godot.Collections.Array publishedFileIds)
    {
        GetInstance().Call(Methods.StartPlaytimeTracking, publishedFileIds);
    }
    
    /// <summary>
    /// Stops the playtime tracking using the specified published file ids
    /// </summary>
    /// <param name="publishedFileIds">The published file ids</param>
    public static void StopPlaytimeTracking(Godot.Collections.Array publishedFileIds)
    {
        GetInstance().Call(Methods.StopPlaytimeTracking, publishedFileIds);
    }
    
    /// <summary>
    /// Stops the playtime tracking for all items
    /// </summary>
    public static void StopPlaytimeTrackingForAllItems()
    {
        GetInstance().Call(Methods.StopPlaytimeTrackingForAllItems);
    }
    
    /// <summary>
    /// Gets the app dependencies using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    public static void GetAppDependencies(long publishedFileId)
    {
        GetInstance().Call(Methods.GetAppDependencies, publishedFileId);
    }
    
    /// <summary>
    /// Submits the item update using the specified update handle
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="changeNote">The change note</param>
    public static void SubmitItemUpdate(ulong updateHandle, string changeNote)
    {
        GetInstance().Call(Methods.SubmitItemUpdate, updateHandle, changeNote);
    }
    
    /// <summary>
    /// Subscribes the item using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    public static void SubscribeItem(long publishedFileId)
    {
        GetInstance().Call(Methods.SubscribeItem, publishedFileId);
    }
    
    /// <summary>
    /// Suspends the downloads using the specified suspend
    /// </summary>
    /// <param name="suspend">The suspend</param>
    public static void SuspendDownloads(bool suspend)
    {
        GetInstance().Call(Methods.SuspendDownloads, suspend);
    }
    
    /// <summary>
    /// Unsubscribes the item using the specified published file id
    /// </summary>
    /// <param name="publishedFileId">The published file id</param>
    public static void UnsubscribeItem(long publishedFileId)
    {
        GetInstance().Call(Methods.UnsubscribeItem, publishedFileId);
    }
    
    /// <summary>
    /// Describes whether update item preview file
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="index">The index</param>
    /// <param name="previewFile">The preview file</param>
    /// <returns>The bool</returns>
    public static bool UpdateItemPreviewFile(ulong updateHandle, uint index, string previewFile)
    {
        return GetInstance().Call(Methods.UpdateItemPreviewFile, updateHandle, index, previewFile).AsBool();
    }
    
    /// <summary>
    /// Describes whether update item preview video
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="index">The index</param>
    /// <param name="videoId">The video id</param>
    /// <returns>The bool</returns>
    public static bool UpdateItemPreviewVideo(ulong updateHandle, uint index, string videoId)
    {
        return GetInstance().Call(Methods.UpdateItemPreviewVideo, updateHandle, index, videoId).AsBool();
    }
    
    /// <summary>
    /// Describes whether show workshop eula
    /// </summary>
    /// <returns>The bool</returns>
    public static bool ShowWorkshopEULA()
    {
        return GetInstance().Call(Methods.ShowWorkshopEULA).AsBool();
    }
    
    /// <summary>
    /// Gets the workshop eula status
    /// </summary>
    public static void GetWorkshopEULAStatus()
    {
        GetInstance().Call(Methods.GetWorkshopEULAStatus);
    }
    
    /// <summary>
    /// Describes whether set time created date range
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="start">The start</param>
    /// <param name="end">The end</param>
    /// <returns>The bool</returns>
    public static bool SetTimeCreatedDateRange(ulong updateHandle, uint start, long end)
    {
        return GetInstance().Call(Methods.SetTimeCreatedDateRange, updateHandle, start, end).AsBool();
    }
    
    /// <summary>
    /// Describes whether set time updated date range
    /// </summary>
    /// <param name="updateHandle">The update handle</param>
    /// <param name="start">The start</param>
    /// <param name="end">The end</param>
    /// <returns>The bool</returns>
    public static bool SetTimeUpdatedDateRange(ulong updateHandle, uint start, long end)
    {
        return GetInstance().Call(Methods.SetTimeUpdatedDateRange, updateHandle, start, end).AsBool();
    }

    /// <summary>
    /// The item preview type enum
    /// </summary>
    public enum ItemPreviewType : long
    {
        /// <summary>
        /// The image item preview type
        /// </summary>
        Image = 0,
        /// <summary>
        /// The youtube video item preview type
        /// </summary>
        YoutubeVideo = 1,
        /// <summary>
        /// The sketchfab item preview type
        /// </summary>
        Sketchfab = 2,
        /// <summary>
        /// The environmentmap horizontal cross item preview type
        /// </summary>
        EnvironmentmapHorizontalCross = 3,
        /// <summary>
        /// The environmentmap lat long item preview type
        /// </summary>
        EnvironmentmapLatLong = 4,
        /// <summary>
        /// The reserved max item preview type
        /// </summary>
        ReservedMax = 255
    }

    /// <summary>
    /// The item state enum
    /// </summary>
    [System.Flags]
    public enum ItemState : long
    {
        /// <summary>
        /// The none item state
        /// </summary>
        None = 0,
        /// <summary>
        /// The subscribed item state
        /// </summary>
        Subscribed = 1,
        /// <summary>
        /// The legacy item item state
        /// </summary>
        LegacyItem = 2,
        /// <summary>
        /// The installed item state
        /// </summary>
        Installed = 4,
        /// <summary>
        /// The needs update item state
        /// </summary>
        NeedsUpdate = 8,
        /// <summary>
        /// The downloading item state
        /// </summary>
        Downloading = 16,
        /// <summary>
        /// The download pending item state
        /// </summary>
        DownloadPending = 32
    }

    /// <summary>
    /// The item statistic enum
    /// </summary>
    public enum ItemStatistic : long
    {
        /// <summary>
        /// The num subscriptions item statistic
        /// </summary>
        NumSubscriptions = 0,
        /// <summary>
        /// The num favorites item statistic
        /// </summary>
        NumFavorites = 1,
        /// <summary>
        /// The num followers item statistic
        /// </summary>
        NumFollowers = 2,
        /// <summary>
        /// The num unique subscriptions item statistic
        /// </summary>
        NumUniqueSubscriptions = 3,
        /// <summary>
        /// The num unique favorites item statistic
        /// </summary>
        NumUniqueFavorites = 4,
        /// <summary>
        /// The num unique followers item statistic
        /// </summary>
        NumUniqueFollowers = 5,
        /// <summary>
        /// The num unique website views item statistic
        /// </summary>
        NumUniqueWebsiteViews = 6,
        /// <summary>
        /// The report score item statistic
        /// </summary>
        ReportScore = 7,
        /// <summary>
        /// The num seconds played item statistic
        /// </summary>
        NumSecondsPlayed = 8,
        /// <summary>
        /// The num playtime sessions item statistic
        /// </summary>
        NumPlaytimeSessions = 9,
        /// <summary>
        /// The num comments item statistic
        /// </summary>
        NumComments = 10,
        /// <summary>
        /// The num seconds played during time period item statistic
        /// </summary>
        NumSecondsPlayedDuringTimePeriod = 11,
        /// <summary>
        /// The num playtime sessions during time period item statistic
        /// </summary>
        NumPlaytimeSessionsDuringTimePeriod = 12
    }

    /// <summary>
    /// The item update status enum
    /// </summary>
    public enum ItemUpdateStatus : long
    {
        /// <summary>
        /// The invalid item update status
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// The preparing config item update status
        /// </summary>
        PreparingConfig = 1,
        /// <summary>
        /// The preparing content item update status
        /// </summary>
        PreparingContent = 2,
        /// <summary>
        /// The uploading content item update status
        /// </summary>
        UploadingContent = 3,
        /// <summary>
        /// The uploading preview file item update status
        /// </summary>
        UploadingPreviewFile = 4,
        /// <summary>
        /// The committing changes item update status
        /// </summary>
        CommittingChanges = 5
    }

    /// <summary>
    /// The user ugc list enum
    /// </summary>
    public enum UserUgcList : long
    {
        /// <summary>
        /// The published user ugc list
        /// </summary>
        Published = 0,
        /// <summary>
        /// The voted on user ugc list
        /// </summary>
        VotedOn = 1,
        /// <summary>
        /// The voted up user ugc list
        /// </summary>
        VotedUp = 2,
        /// <summary>
        /// The voted down user ugc list
        /// </summary>
        VotedDown = 3,
        /// <summary>
        /// The will vote later user ugc list
        /// </summary>
        WillVoteLater = 4,
        /// <summary>
        /// The favorited user ugc list
        /// </summary>
        Favorited = 5,
        /// <summary>
        /// The subscribed user ugc list
        /// </summary>
        Subscribed = 6,
        /// <summary>
        /// The used or played user ugc list
        /// </summary>
        UsedOrPlayed = 7,
        /// <summary>
        /// The followed user ugc list
        /// </summary>
        Followed = 8
    }

    /// <summary>
    /// The user ugc list sort order enum
    /// </summary>
    public enum UserUgcListSortOrder : long
    {
        /// <summary>
        /// The userugclistsortorder creationorderdesc user ugc list sort order
        /// </summary>
        UserugclistsortorderCreationorderdesc = 0,
        /// <summary>
        /// The userugclistsortorder creationorderasc user ugc list sort order
        /// </summary>
        UserugclistsortorderCreationorderasc = 1,
        /// <summary>
        /// The userugclistsortorder titleasc user ugc list sort order
        /// </summary>
        UserugclistsortorderTitleasc = 2,
        /// <summary>
        /// The userugclistsortorder lastupdateddesc user ugc list sort order
        /// </summary>
        UserugclistsortorderLastupdateddesc = 3,
        /// <summary>
        /// The userugclistsortorder subscriptiondatedesc user ugc list sort order
        /// </summary>
        UserugclistsortorderSubscriptiondatedesc = 4,
        /// <summary>
        /// The userugclistsortorder votescoredesc user ugc list sort order
        /// </summary>
        UserugclistsortorderVotescoredesc = 5,
        /// <summary>
        /// The serugclistsortorder formoderation user ugc list sort order
        /// </summary>
        SerugclistsortorderFormoderation = 6
    }

    /// <summary>
    /// The ugc query enum
    /// </summary>
    public enum UgcQuery : long
    {
        /// <summary>
        /// The ranked by vote ugc query
        /// </summary>
        RankedByVote = 0,
        /// <summary>
        /// The ranked by publication date ugc query
        /// </summary>
        RankedByPublicationDate = 1,
        /// <summary>
        /// The accepted for game ranked by acceptance date ugc query
        /// </summary>
        AcceptedForGameRankedByAcceptanceDate = 2,
        /// <summary>
        /// The ranked by trend ugc query
        /// </summary>
        RankedByTrend = 3,
        /// <summary>
        /// The favorited by friends ranked by publication date ugc query
        /// </summary>
        FavoritedByFriendsRankedByPublicationDate = 4,
        /// <summary>
        /// The created by friends ranked by publication date ugc query
        /// </summary>
        CreatedByFriendsRankedByPublicationDate = 5,
        /// <summary>
        /// The ranked by num times reported ugc query
        /// </summary>
        RankedByNumTimesReported = 6,
        /// <summary>
        /// The created by followed users ranked by publication date ugc query
        /// </summary>
        CreatedByFollowedUsersRankedByPublicationDate = 7,
        /// <summary>
        /// The not yet rated ugc query
        /// </summary>
        NotYetRated = 8,
        /// <summary>
        /// The ranked by total votes asc ugc query
        /// </summary>
        RankedByTotalVotesAsc = 9,
        /// <summary>
        /// The ranked by votes up ugc query
        /// </summary>
        RankedByVotesUp = 10,
        /// <summary>
        /// The ranked by text search ugc query
        /// </summary>
        RankedByTextSearch = 11,
        /// <summary>
        /// The ranked by total unique subscriptions ugc query
        /// </summary>
        RankedByTotalUniqueSubscriptions = 12,
        /// <summary>
        /// The ranked by playtime trend ugc query
        /// </summary>
        RankedByPlaytimeTrend = 13,
        /// <summary>
        /// The ranked by total playtime ugc query
        /// </summary>
        RankedByTotalPlaytime = 14,
        /// <summary>
        /// The ranked by average playtime trend ugc query
        /// </summary>
        RankedByAveragePlaytimeTrend = 15,
        /// <summary>
        /// The ranked by lifetime average playtime ugc query
        /// </summary>
        RankedByLifetimeAveragePlaytime = 16,
        /// <summary>
        /// The ranked by playtime sessions trend ugc query
        /// </summary>
        RankedByPlaytimeSessionsTrend = 17,
        /// <summary>
        /// The ranked by lifetime playtime sessions ugc query
        /// </summary>
        RankedByLifetimePlaytimeSessions = 18,
        /// <summary>
        /// The ranked by last updated date ugc query
        /// </summary>
        RankedByLastUpdatedDate = 19
    }

    /// <summary>
    /// The ugc content descriptor id enum
    /// </summary>
    public enum UgcContentDescriptorId : long
    {
        /// <summary>
        /// The nudity or sexual content ugc content descriptor id
        /// </summary>
        NudityOrSexualContent = 1,
        /// <summary>
        /// The frequent violence or gore ugc content descriptor id
        /// </summary>
        FrequentViolenceOrGore = 2,
        /// <summary>
        /// The adult only sexual content ugc content descriptor id
        /// </summary>
        AdultOnlySexualContent = 3,
        /// <summary>
        /// The gratuitous sexual content ugc content descriptor id
        /// </summary>
        GratuitousSexualContent = 4,
        /// <summary>
        /// The any mature content ugc content descriptor id
        /// </summary>
        AnyMatureContent = 5
    }

    /// <summary>
    /// The ugc matching ugc type enum
    /// </summary>
    public enum UgcMatchingUgcType : long
    {
        /// <summary>
        /// The matchingugctype items ugc matching ugc type
        /// </summary>
        MatchingugctypeItems = 0,
        /// <summary>
        /// The matching ugc type items mtx ugc matching ugc type
        /// </summary>
        MatchingUgcTypeItemsMtx = 1,
        /// <summary>
        /// The matching ugc type items ready to use ugc matching ugc type
        /// </summary>
        MatchingUgcTypeItemsReadyToUse = 2,
        /// <summary>
        /// The matching ugc type collections ugc matching ugc type
        /// </summary>
        MatchingUgcTypeCollections = 3,
        /// <summary>
        /// The matching ugc type artwork ugc matching ugc type
        /// </summary>
        MatchingUgcTypeArtwork = 4,
        /// <summary>
        /// The matching ugc type videos ugc matching ugc type
        /// </summary>
        MatchingUgcTypeVideos = 5,
        /// <summary>
        /// The matching ugc type screenshots ugc matching ugc type
        /// </summary>
        MatchingUgcTypeScreenshots = 6,
        /// <summary>
        /// The matching ugc type all guides ugc matching ugc type
        /// </summary>
        MatchingUgcTypeAllGuides = 7,
        /// <summary>
        /// The matching ugc type web guides ugc matching ugc type
        /// </summary>
        MatchingUgcTypeWebGuides = 8,
        /// <summary>
        /// The matching ugc type integrated guides ugc matching ugc type
        /// </summary>
        MatchingUgcTypeIntegratedGuides = 9,
        /// <summary>
        /// The matching ugc type usable in game ugc matching ugc type
        /// </summary>
        MatchingUgcTypeUsableInGame = 10,
        /// <summary>
        /// The matching ugc type controller bindings ugc matching ugc type
        /// </summary>
        MatchingUgcTypeControllerBindings = 11,
        /// <summary>
        /// The matching ugc type game managed items ugc matching ugc type
        /// </summary>
        MatchingUgcTypeGameManagedItems = 12,
        /// <summary>
        /// The matching ugc type all ugc matching ugc type
        /// </summary>
        MatchingUgcTypeAll = -1
    }
}