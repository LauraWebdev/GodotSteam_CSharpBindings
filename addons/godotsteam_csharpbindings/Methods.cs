using Godot;

namespace GodotSteam;

/// <summary>

/// The methods class

/// </summary>

public static class Methods
{
    /// <summary>
    /// The is steam running
    /// </summary>
    public static readonly StringName IsSteamRunning = "isSteamRunning";
    /// <summary>
    /// The run callbacks
    /// </summary>
    public static readonly StringName RunCallbacks = "run_callbacks";
    /// <summary>
    /// The restart app if necessary
    /// </summary>
    public static readonly StringName RestartAppIfNecessary = "restartAppIfNecessary";
    /// <summary>
    /// The steam init
    /// </summary>
    public static readonly StringName SteamInit = "steamInit";
    /// <summary>
    /// The steam init ex
    /// </summary>
    public static readonly StringName SteamInitEx = "steamInitEx";
    /// <summary>
    /// The steam shutdown
    /// </summary>
    public static readonly StringName SteamShutdown = "steamShutdown";
    /// <summary>
    /// The get dlc data by index
    /// </summary>
    public static readonly StringName GetDLCDataByIndex = "getDLCDataByIndex";
    /// <summary>
    /// The is app installed
    /// </summary>
    public static readonly StringName IsAppInstalled = "isAppInstalled";
    /// <summary>
    /// The is cybercafe
    /// </summary>
    public static readonly StringName IsCybercafe = "isCybercafe";
    /// <summary>
    /// The is dlc installed
    /// </summary>
    public static readonly StringName IsDLCInstalled = "isDLCInstalled";
    /// <summary>
    /// The is low violence
    /// </summary>
    public static readonly StringName IsLowViolence = "isLowViolence";
    /// <summary>
    /// The is subscribed
    /// </summary>
    public static readonly StringName IsSubscribed = "isSubscribed";
    /// <summary>
    /// The is subscribed app
    /// </summary>
    public static readonly StringName IsSubscribedApp = "isSubscribedApp";
    /// <summary>
    /// The is subscribed from family sharing
    /// </summary>
    public static readonly StringName IsSubscribedFromFamilySharing = "isSubscribedFromFamilySharing";
    /// <summary>
    /// The is subscribed from free weekend
    /// </summary>
    public static readonly StringName IsSubscribedFromFreeWeekend = "isSubscribedFromFreeWeekend";
    /// <summary>
    /// The is timed trial
    /// </summary>
    public static readonly StringName IsTimedTrial = "isTimedTrial";
    /// <summary>
    /// The is vac banned
    /// </summary>
    public static readonly StringName IsVACBanned = "isVACBanned";
    /// <summary>
    /// The get app build id
    /// </summary>
    public static readonly StringName GetAppBuildId = "getAppBuildId";
    /// <summary>
    /// The get app install dir
    /// </summary>
    public static readonly StringName GetAppInstallDir = "getAppInstallDir";
    /// <summary>
    /// The get app owner
    /// </summary>
    public static readonly StringName GetAppOwner = "getAppOwner";
    /// <summary>
    /// The get available game languages
    /// </summary>
    public static readonly StringName GetAvailableGameLanguages = "getAvailableGameLanguages";
    /// <summary>
    /// The get current beta name
    /// </summary>
    public static readonly StringName GetCurrentBetaName = "getCurrentBetaName";
    /// <summary>
    /// The get current game language
    /// </summary>
    public static readonly StringName GetCurrentGameLanguage = "getCurrentGameLanguage";
    /// <summary>
    /// The get dlc count
    /// </summary>
    public static readonly StringName GetDLCCount = "getDLCCount";
    /// <summary>
    /// The get dlc download progress
    /// </summary>
    public static readonly StringName GetDLCDownloadProgress = "getDLCDownloadProgress";
    /// <summary>
    /// The get earliest purchase unix time
    /// </summary>
    public static readonly StringName GetEarliestPurchaseUnixTime = "getEarliestPurchaseUnixTime";
    /// <summary>
    /// The get file details
    /// </summary>
    public static readonly StringName GetFileDetails = "getFileDetails";
    /// <summary>
    /// The get installed depots
    /// </summary>
    public static readonly StringName GetInstalledDepots = "getInstalledDepots";
    /// <summary>
    /// The get launch command line
    /// </summary>
    public static readonly StringName GetLaunchCommandLine = "getLaunchCommandLine";
    /// <summary>
    /// The get launch query param
    /// </summary>
    public static readonly StringName GetLaunchQueryParam = "getLaunchQueryParam";
    /// <summary>
    /// The install dlc
    /// </summary>
    public static readonly StringName InstallDLC = "installDLC";
    /// <summary>
    /// The mark content corrupt
    /// </summary>
    public static readonly StringName MarkContentCorrupt = "markContentCorrupt";
    /// <summary>
    /// The set dlc context
    /// </summary>
    public static readonly StringName SetDLCContext = "setDLCContext";
    /// <summary>
    /// The uninstall dlc
    /// </summary>
    public static readonly StringName UninstallDLC = "uninstallDLC";
    /// <summary>
    /// The get num installed apps
    /// </summary>
    public static readonly StringName GetNumInstalledApps = "getNumInstalledApps";
    /// <summary>
    /// The get installed apps
    /// </summary>
    public static readonly StringName GetInstalledApps = "getInstalledApps";
    /// <summary>
    /// The get app name
    /// </summary>
    public static readonly StringName GetAppName = "getAppName";
    /// <summary>
    /// The get app list install dir
    /// </summary>
    public static readonly StringName GetAppListInstallDir = "getAppListInstallDir";
    /// <summary>
    /// The get app list build id
    /// </summary>
    public static readonly StringName GetAppListBuildId = "getAppListBuildId";
    /// <summary>
    /// The activate game overlay
    /// </summary>
    public static readonly StringName ActivateGameOverlay = "activateGameOverlay";
    /// <summary>
    /// The activate game overlay invite dialog
    /// </summary>
    public static readonly StringName ActivateGameOverlayInviteDialog = "activateGameOverlayInviteDialog";
    /// <summary>
    /// The activate game overlay invite dialog connect string
    /// </summary>
    public static readonly StringName ActivateGameOverlayInviteDialogConnectString = "activateGameOverlayInviteDialogConnectString";
    /// <summary>
    /// The activate game overlay to store
    /// </summary>
    public static readonly StringName ActivateGameOverlayToStore = "activateGameOverlayToStore";
    /// <summary>
    /// The activate game overlay to user
    /// </summary>
    public static readonly StringName ActivateGameOverlayToUser = "activateGameOverlayToUser";
    /// <summary>
    /// The activate game overlay to web page
    /// </summary>
    public static readonly StringName ActivateGameOverlayToWebPage = "activateGameOverlayToWebPage";
    /// <summary>
    /// The clear rich presence
    /// </summary>
    public static readonly StringName ClearRichPresence = "clearRichPresence";
    /// <summary>
    /// The close clan chat window in steam
    /// </summary>
    public static readonly StringName CloseClanChatWindowInSteam = "closeClanChatWindowInSteam";
    /// <summary>
    /// The download clan activity counts
    /// </summary>
    public static readonly StringName DownloadClanActivityCounts = "downloadClanActivityCounts";
    /// <summary>
    /// The enumerate following list
    /// </summary>
    public static readonly StringName EnumerateFollowingList = "enumerateFollowingList";
    /// <summary>
    /// The get chat member by index
    /// </summary>
    public static readonly StringName GetChatMemberByIndex = "getChatMemberByIndex";
    /// <summary>
    /// The get clan activity counts
    /// </summary>
    public static readonly StringName GetClanActivityCounts = "getClanActivityCounts";
    /// <summary>
    /// The get clan by index
    /// </summary>
    public static readonly StringName GetClanByIndex = "getClanByIndex";
    /// <summary>
    /// The get clan chat member count
    /// </summary>
    public static readonly StringName GetClanChatMemberCount = "getClanChatMemberCount";
    /// <summary>
    /// The get clan chat message
    /// </summary>
    public static readonly StringName GetClanChatMessage = "getClanChatMessage";
    /// <summary>
    /// The get clan count
    /// </summary>
    public static readonly StringName GetClanCount = "getClanCount";
    /// <summary>
    /// The get clan name
    /// </summary>
    public static readonly StringName GetClanName = "getClanName";
    /// <summary>
    /// The get clan officer by index
    /// </summary>
    public static readonly StringName GetClanOfficerByIndex = "getClanOfficerByIndex";
    /// <summary>
    /// The get clan officer count
    /// </summary>
    public static readonly StringName GetClanOfficerCount = "getClanOfficerCount";
    /// <summary>
    /// The get clan owner
    /// </summary>
    public static readonly StringName GetClanOwner = "getClanOwner";
    /// <summary>
    /// The get clan tag
    /// </summary>
    public static readonly StringName GetClanTag = "getClanTag";
    /// <summary>
    /// The get coplay friend
    /// </summary>
    public static readonly StringName GetCoplayFriend = "getCoplayFriend";
    /// <summary>
    /// The get coplay friend count
    /// </summary>
    public static readonly StringName GetCoplayFriendCount = "getCoplayFriendCount";
    /// <summary>
    /// The get follower count
    /// </summary>
    public static readonly StringName GetFollowerCount = "getFollowerCount";
    /// <summary>
    /// The get friend by index
    /// </summary>
    public static readonly StringName GetFriendByIndex = "getFriendByIndex";
    /// <summary>
    /// The get friend coplay game
    /// </summary>
    public static readonly StringName GetFriendCoplayGame = "getFriendCoplayGame";
    /// <summary>
    /// The get friend coplay time
    /// </summary>
    public static readonly StringName GetFriendCoplayTime = "getFriendCoplayTime";
    /// <summary>
    /// The get friend count
    /// </summary>
    public static readonly StringName GetFriendCount = "getFriendCount";
    /// <summary>
    /// The get friend count from source
    /// </summary>
    public static readonly StringName GetFriendCountFromSource = "getFriendCountFromSource";
    /// <summary>
    /// The get friend from source by index
    /// </summary>
    public static readonly StringName GetFriendFromSourceByIndex = "getFriendFromSourceByIndex";
    /// <summary>
    /// The get friend game played
    /// </summary>
    public static readonly StringName GetFriendGamePlayed = "getFriendGamePlayed";
    /// <summary>
    /// The get friend message
    /// </summary>
    public static readonly StringName GetFriendMessage = "getFriendMessage";
    /// <summary>
    /// The get friend persona name
    /// </summary>
    public static readonly StringName GetFriendPersonaName = "getFriendPersonaName";
    /// <summary>
    /// The get friend persona name history
    /// </summary>
    public static readonly StringName GetFriendPersonaNameHistory = "getFriendPersonaNameHistory";
    /// <summary>
    /// The get friend persona state
    /// </summary>
    public static readonly StringName GetFriendPersonaState = "getFriendPersonaState";
    /// <summary>
    /// The get friend relationship
    /// </summary>
    public static readonly StringName GetFriendRelationship = "getFriendRelationship";
    /// <summary>
    /// The get friend rich presence
    /// </summary>
    public static readonly StringName GetFriendRichPresence = "getFriendRichPresence";
    /// <summary>
    /// The get friend rich presence key count
    /// </summary>
    public static readonly StringName GetFriendRichPresenceKeyCount = "getFriendRichPresenceKeyCount";
    /// <summary>
    /// The get friend rich presence key by index
    /// </summary>
    public static readonly StringName GetFriendRichPresenceKeyByIndex = "getFriendRichPresenceKeyByIndex";
    /// <summary>
    /// The get friends group count
    /// </summary>
    public static readonly StringName GetFriendsGroupCount = "getFriendsGroupCount";
    /// <summary>
    /// The get friends group id by index
    /// </summary>
    public static readonly StringName GetFriendsGroupIDByIndex = "getFriendsGroupIDByIndex";
    /// <summary>
    /// The get friends group members count
    /// </summary>
    public static readonly StringName GetFriendsGroupMembersCount = "getFriendsGroupMembersCount";
    /// <summary>
    /// The get friends group members list
    /// </summary>
    public static readonly StringName GetFriendsGroupMembersList = "getFriendsGroupMembersList";
    /// <summary>
    /// The get friends group name
    /// </summary>
    public static readonly StringName GetFriendsGroupName = "getFriendsGroupName";
    /// <summary>
    /// The get friend steam level
    /// </summary>
    public static readonly StringName GetFriendSteamLevel = "getFriendSteamLevel";
    /// <summary>
    /// The get large friend avatar
    /// </summary>
    public static readonly StringName GetLargeFriendAvatar = "getLargeFriendAvatar";
    /// <summary>
    /// The get medium friend avatar
    /// </summary>
    public static readonly StringName GetMediumFriendAvatar = "getMediumFriendAvatar";
    /// <summary>
    /// The get persona name
    /// </summary>
    public static readonly StringName GetPersonaName = "getPersonaName";
    /// <summary>
    /// The get persona state
    /// </summary>
    public static readonly StringName GetPersonaState = "getPersonaState";
    /// <summary>
    /// The get player avatar
    /// </summary>
    public static readonly StringName GetPlayerAvatar = "getPlayerAvatar";
    /// <summary>
    /// The get player nickname
    /// </summary>
    public static readonly StringName GetPlayerNickname = "getPlayerNickname";
    /// <summary>
    /// The get profile item property string
    /// </summary>
    public static readonly StringName GetProfileItemPropertyString = "getProfileItemPropertyString";
    /// <summary>
    /// The get profile item property int
    /// </summary>
    public static readonly StringName GetProfileItemPropertyInt = "getProfileItemPropertyInt";
    /// <summary>
    /// The get recent players
    /// </summary>
    public static readonly StringName GetRecentPlayers = "getRecentPlayers";
    /// <summary>
    /// The get small friend avatar
    /// </summary>
    public static readonly StringName GetSmallFriendAvatar = "getSmallFriendAvatar";
    /// <summary>
    /// The get user friends groups
    /// </summary>
    public static readonly StringName GetUserFriendsGroups = "getUserFriendsGroups";
    /// <summary>
    /// The get user restrictions
    /// </summary>
    public static readonly StringName GetUserRestrictions = "getUserRestrictions";
    /// <summary>
    /// The get user steam friends
    /// </summary>
    public static readonly StringName GetUserSteamFriends = "getUserSteamFriends";
    /// <summary>
    /// The get user steam groups
    /// </summary>
    public static readonly StringName GetUserSteamGroups = "getUserSteamGroups";
    /// <summary>
    /// The has equipped profile item
    /// </summary>
    public static readonly StringName HasEquippedProfileItem = "hasEquippedProfileItem";
    /// <summary>
    /// The has friend
    /// </summary>
    public static readonly StringName HasFriend = "hasFriend";
    /// <summary>
    /// The invite user to game
    /// </summary>
    public static readonly StringName InviteUserToGame = "inviteUserToGame";
    /// <summary>
    /// The is clan chat admin
    /// </summary>
    public static readonly StringName IsClanChatAdmin = "isClanChatAdmin";
    /// <summary>
    /// The is clan public
    /// </summary>
    public static readonly StringName IsClanPublic = "isClanPublic";
    /// <summary>
    /// The is clan official game group
    /// </summary>
    public static readonly StringName IsClanOfficialGameGroup = "isClanOfficialGameGroup";
    /// <summary>
    /// The is clan chat window open in steam
    /// </summary>
    public static readonly StringName IsClanChatWindowOpenInSteam = "isClanChatWindowOpenInSteam";
    /// <summary>
    /// The is following
    /// </summary>
    public static readonly StringName IsFollowing = "isFollowing";
    /// <summary>
    /// The is user in source
    /// </summary>
    public static readonly StringName IsUserInSource = "isUserInSource";
    /// <summary>
    /// The join clan chat room
    /// </summary>
    public static readonly StringName JoinClanChatRoom = "joinClanChatRoom";
    /// <summary>
    /// The leave clan chat room
    /// </summary>
    public static readonly StringName LeaveClanChatRoom = "leaveClanChatRoom";
    /// <summary>
    /// The open clan chat window in steam
    /// </summary>
    public static readonly StringName OpenClanChatWindowInSteam = "openClanChatWindowInSteam";
    /// <summary>
    /// The register protocol in overlay browser
    /// </summary>
    public static readonly StringName RegisterProtocolInOverlayBrowser = "registerProtocolInOverlayBrowser";
    /// <summary>
    /// The reply to friend message
    /// </summary>
    public static readonly StringName ReplyToFriendMessage = "replyToFriendMessage";
    /// <summary>
    /// The request clan officer list
    /// </summary>
    public static readonly StringName RequestClanOfficerList = "requestClanOfficerList";
    /// <summary>
    /// The request equipped profile items
    /// </summary>
    public static readonly StringName RequestEquippedProfileItems = "requestEquippedProfileItems";
    /// <summary>
    /// The request friend rich presence
    /// </summary>
    public static readonly StringName RequestFriendRichPresence = "requestFriendRichPresence";
    /// <summary>
    /// The request user information
    /// </summary>
    public static readonly StringName RequestUserInformation = "requestUserInformation";
    /// <summary>
    /// The send clan chat message
    /// </summary>
    public static readonly StringName SendClanChatMessage = "sendClanChatMessage";
    /// <summary>
    /// The set in game voice speaking
    /// </summary>
    public static readonly StringName SetInGameVoiceSpeaking = "setInGameVoiceSpeaking";
    /// <summary>
    /// The set listen for friends messages
    /// </summary>
    public static readonly StringName SetListenForFriendsMessages = "setListenForFriendsMessages";
    /// <summary>
    /// The set persona name
    /// </summary>
    public static readonly StringName SetPersonaName = "setPersonaName";
    /// <summary>
    /// The set played with
    /// </summary>
    public static readonly StringName SetPlayedWith = "setPlayedWith";
    /// <summary>
    /// The set rich presence
    /// </summary>
    public static readonly StringName SetRichPresence = "setRichPresence";
    /// <summary>
    /// The add game search params
    /// </summary>
    public static readonly StringName AddGameSearchParams = "addGameSearchParams";
    /// <summary>
    /// The search for game with lobby
    /// </summary>
    public static readonly StringName SearchForGameWithLobby = "searchForGameWithLobby";
    /// <summary>
    /// The search for game solo
    /// </summary>
    public static readonly StringName SearchForGameSolo = "searchForGameSolo";
    /// <summary>
    /// The accept game
    /// </summary>
    public static readonly StringName AcceptGame = "acceptGame";
    /// <summary>
    /// The decline game
    /// </summary>
    public static readonly StringName DeclineGame = "declineGame";
    /// <summary>
    /// The retrieve connection details
    /// </summary>
    public static readonly StringName RetrieveConnectionDetails = "retrieveConnectionDetails";
    /// <summary>
    /// The end game search
    /// </summary>
    public static readonly StringName EndGameSearch = "endGameSearch";
    /// <summary>
    /// The set game host params
    /// </summary>
    public static readonly StringName SetGameHostParams = "setGameHostParams";
    /// <summary>
    /// The set connection details
    /// </summary>
    public static readonly StringName SetConnectionDetails = "setConnectionDetails";
    /// <summary>
    /// The request players for game
    /// </summary>
    public static readonly StringName RequestPlayersForGame = "requestPlayersForGame";
    /// <summary>
    /// The host confirm game start
    /// </summary>
    public static readonly StringName HostConfirmGameStart = "hostConfirmGameStart";
    /// <summary>
    /// The cancel request players for game
    /// </summary>
    public static readonly StringName CancelRequestPlayersForGame = "cancelRequestPlayersForGame";
    /// <summary>
    /// The submit player result
    /// </summary>
    public static readonly StringName SubmitPlayerResult = "submitPlayerResult";
    /// <summary>
    /// The end game
    /// </summary>
    public static readonly StringName EndGame = "endGame";
    /// <summary>
    /// The add header
    /// </summary>
    public static readonly StringName AddHeader = "addHeader";
    /// <summary>
    /// The allow start request
    /// </summary>
    public static readonly StringName AllowStartRequest = "allowStartRequest";
    /// <summary>
    /// The copy to clipboard
    /// </summary>
    public static readonly StringName CopyToClipboard = "copyToClipboard";
    /// <summary>
    /// The create browser
    /// </summary>
    public static readonly StringName CreateBrowser = "createBrowser";
    /// <summary>
    /// The execute javascript
    /// </summary>
    public static readonly StringName ExecuteJavascript = "executeJavascript";
    /// <summary>
    /// The find
    /// </summary>
    public static readonly StringName Find = "find";
    /// <summary>
    /// The get link at position
    /// </summary>
    public static readonly StringName GetLinkAtPosition = "getLinkAtPosition";
    /// <summary>
    /// The go back
    /// </summary>
    public static readonly StringName GoBack = "goBack";
    /// <summary>
    /// The go forward
    /// </summary>
    public static readonly StringName GoForward = "goForward";
    /// <summary>
    /// The html init
    /// </summary>
    public static readonly StringName HtmlInit = "htmlInit";
    /// <summary>
    /// The js dialog response
    /// </summary>
    public static readonly StringName JsDialogResponse = "jsDialogResponse";
    /// <summary>
    /// The key char
    /// </summary>
    public static readonly StringName KeyChar = "keyChar";
    /// <summary>
    /// The key down
    /// </summary>
    public static readonly StringName KeyDown = "keyDown";
    /// <summary>
    /// The key up
    /// </summary>
    public static readonly StringName KeyUp = "keyUp";
    /// <summary>
    /// The load url
    /// </summary>
    public static readonly StringName LoadURL = "loadURL";
    /// <summary>
    /// The mouse double click
    /// </summary>
    public static readonly StringName MouseDoubleClick = "mouseDoubleClick";
    /// <summary>
    /// The mouse down
    /// </summary>
    public static readonly StringName MouseDown = "mouseDown";
    /// <summary>
    /// The mouse move
    /// </summary>
    public static readonly StringName MouseMove = "mouseMove";
    /// <summary>
    /// The mouse up
    /// </summary>
    public static readonly StringName MouseUp = "mouseUp";
    /// <summary>
    /// The mouse wheel
    /// </summary>
    public static readonly StringName MouseWheel = "mouseWheel";
    /// <summary>
    /// The paste from clipboard
    /// </summary>
    public static readonly StringName PasteFromClipboard = "pasteFromClipboard";
    /// <summary>
    /// The reload
    /// </summary>
    public static readonly StringName Reload = "reload";
    /// <summary>
    /// The remove browser
    /// </summary>
    public static readonly StringName RemoveBrowser = "removeBrowser";
    /// <summary>
    /// The set background mode
    /// </summary>
    public static readonly StringName SetBackgroundMode = "setBackgroundMode";
    /// <summary>
    /// The set cookie
    /// </summary>
    public static readonly StringName SetCookie = "setCookie";
    /// <summary>
    /// The set horizontal scroll
    /// </summary>
    public static readonly StringName SetHorizontalScroll = "setHorizontalScroll";
    /// <summary>
    /// The set key focus
    /// </summary>
    public static readonly StringName SetKeyFocus = "setKeyFocus";
    /// <summary>
    /// The set page scale factor
    /// </summary>
    public static readonly StringName SetPageScaleFactor = "setPageScaleFactor";
    /// <summary>
    /// The set size
    /// </summary>
    public static readonly StringName SetSize = "setSize";
    /// <summary>
    /// The set vertical scroll
    /// </summary>
    public static readonly StringName SetVerticalScroll = "setVerticalScroll";
    /// <summary>
    /// The html shutdown
    /// </summary>
    public static readonly StringName HtmlShutdown = "htmlShutdown";
    /// <summary>
    /// The stop find
    /// </summary>
    public static readonly StringName StopFind = "stopFind";
    /// <summary>
    /// The stop load
    /// </summary>
    public static readonly StringName StopLoad = "stopLoad";
    /// <summary>
    /// The view source
    /// </summary>
    public static readonly StringName ViewSource = "viewSource";
    /// <summary>
    /// The create cookie container
    /// </summary>
    public static readonly StringName CreateCookieContainer = "createCookieContainer";
    /// <summary>
    /// The create http request
    /// </summary>
    public static readonly StringName CreateHTTPRequest = "createHTTPRequest";
    /// <summary>
    /// The defer http request
    /// </summary>
    public static readonly StringName DeferHTTPRequest = "deferHTTPRequest";
    /// <summary>
    /// The get http download progress pct
    /// </summary>
    public static readonly StringName GetHTTPDownloadProgressPct = "getHTTPDownloadProgressPct";
    /// <summary>
    /// The get http request was timed out
    /// </summary>
    public static readonly StringName GetHTTPRequestWasTimedOut = "getHTTPRequestWasTimedOut";
    /// <summary>
    /// The get http response body data
    /// </summary>
    public static readonly StringName GetHTTPResponseBodyData = "getHTTPResponseBodyData";
    /// <summary>
    /// The get http response body size
    /// </summary>
    public static readonly StringName GetHTTPResponseBodySize = "getHTTPResponseBodySize";
    /// <summary>
    /// The get http response header size
    /// </summary>
    public static readonly StringName GetHTTPResponseHeaderSize = "getHTTPResponseHeaderSize";
    /// <summary>
    /// The get http response header value
    /// </summary>
    public static readonly StringName GetHTTPResponseHeaderValue = "getHTTPResponseHeaderValue";
    /// <summary>
    /// The get http streaming response body data
    /// </summary>
    public static readonly StringName GetHTTPStreamingResponseBodyData = "getHTTPStreamingResponseBodyData";
    /// <summary>
    /// The prioritize http request
    /// </summary>
    public static readonly StringName PrioritizeHTTPRequest = "prioritizeHTTPRequest";
    /// <summary>
    /// The release cookie container
    /// </summary>
    public static readonly StringName ReleaseCookieContainer = "releaseCookieContainer";
    /// <summary>
    /// The release http request
    /// </summary>
    public static readonly StringName ReleaseHTTPRequest = "releaseHTTPRequest";
    /// <summary>
    /// The send http request
    /// </summary>
    public static readonly StringName SendHTTPRequest = "sendHTTPRequest";
    /// <summary>
    /// The send http request and stream response
    /// </summary>
    public static readonly StringName SendHTTPRequestAndStreamResponse = "sendHTTPRequestAndStreamResponse";
    /// <summary>
    /// The set http cookie
    /// </summary>
    public static readonly StringName SetHTTPCookie = "setHTTPCookie";
    /// <summary>
    /// The set http request absolute timeout ms
    /// </summary>
    public static readonly StringName SetHTTPRequestAbsoluteTimeoutMS = "setHTTPRequestAbsoluteTimeoutMS";
    /// <summary>
    /// The set http request context value
    /// </summary>
    public static readonly StringName SetHTTPRequestContextValue = "setHTTPRequestContextValue";
    /// <summary>
    /// The set http request cookie container
    /// </summary>
    public static readonly StringName SetHTTPRequestCookieContainer = "setHTTPRequestCookieContainer";
    /// <summary>
    /// The set http request get or post parameter
    /// </summary>
    public static readonly StringName SetHTTPRequestGetOrPostParameter = "setHTTPRequestGetOrPostParameter";
    /// <summary>
    /// The set http request header value
    /// </summary>
    public static readonly StringName SetHTTPRequestHeaderValue = "setHTTPRequestHeaderValue";
    /// <summary>
    /// The set http request network activity timeout
    /// </summary>
    public static readonly StringName SetHTTPRequestNetworkActivityTimeout = "setHTTPRequestNetworkActivityTimeout";
    /// <summary>
    /// The set http request raw post body
    /// </summary>
    public static readonly StringName SetHTTPRequestRawPostBody = "setHTTPRequestRawPostBody";
    /// <summary>
    /// The set http request requires verified certificate
    /// </summary>
    public static readonly StringName SetHTTPRequestRequiresVerifiedCertificate = "setHTTPRequestRequiresVerifiedCertificate";
    /// <summary>
    /// The set http request user agent info
    /// </summary>
    public static readonly StringName SetHTTPRequestUserAgentInfo = "setHTTPRequestUserAgentInfo";
    /// <summary>
    /// The activate action set
    /// </summary>
    public static readonly StringName ActivateActionSet = "activateActionSet";
    /// <summary>
    /// The activate action set layer
    /// </summary>
    public static readonly StringName ActivateActionSetLayer = "activateActionSetLayer";
    /// <summary>
    /// The deactivate action set layer
    /// </summary>
    public static readonly StringName DeactivateActionSetLayer = "deactivateActionSetLayer";
    /// <summary>
    /// The deactivate all action set layers
    /// </summary>
    public static readonly StringName DeactivateAllActionSetLayers = "deactivateAllActionSetLayers";
    /// <summary>
    /// The get action set handle
    /// </summary>
    public static readonly StringName GetActionSetHandle = "getActionSetHandle";
    /// <summary>
    /// The get action origin from xbox origin
    /// </summary>
    public static readonly StringName GetActionOriginFromXboxOrigin = "getActionOriginFromXboxOrigin";
    /// <summary>
    /// The get active action set layers
    /// </summary>
    public static readonly StringName GetActiveActionSetLayers = "getActiveActionSetLayers";
    /// <summary>
    /// The get analog action data
    /// </summary>
    public static readonly StringName GetAnalogActionData = "getAnalogActionData";
    /// <summary>
    /// The get analog action handle
    /// </summary>
    public static readonly StringName GetAnalogActionHandle = "getAnalogActionHandle";
    /// <summary>
    /// The get analog action origins
    /// </summary>
    public static readonly StringName GetAnalogActionOrigins = "getAnalogActionOrigins";
    /// <summary>
    /// The get connected controllers
    /// </summary>
    public static readonly StringName GetConnectedControllers = "getConnectedControllers";
    /// <summary>
    /// The get controller for gamepad index
    /// </summary>
    public static readonly StringName GetControllerForGamepadIndex = "getControllerForGamepadIndex";
    /// <summary>
    /// The get current action set
    /// </summary>
    public static readonly StringName GetCurrentActionSet = "getCurrentActionSet";
    /// <summary>
    /// The get device binding revision
    /// </summary>
    public static readonly StringName GetDeviceBindingRevision = "getDeviceBindingRevision";
    /// <summary>
    /// The get digital action data
    /// </summary>
    public static readonly StringName GetDigitalActionData = "getDigitalActionData";
    /// <summary>
    /// The get digital action handle
    /// </summary>
    public static readonly StringName GetDigitalActionHandle = "getDigitalActionHandle";
    /// <summary>
    /// The get digital action origins
    /// </summary>
    public static readonly StringName GetDigitalActionOrigins = "getDigitalActionOrigins";
    /// <summary>
    /// The get gamepad index for controller
    /// </summary>
    public static readonly StringName GetGamepadIndexForController = "getGamepadIndexForController";
    /// <summary>
    /// The get glyph for action origin
    /// </summary>
    public static readonly StringName GetGlyphForActionOrigin = "getGlyphForActionOrigin";
    /// <summary>
    /// The get input type for handle
    /// </summary>
    public static readonly StringName GetInputTypeForHandle = "getInputTypeForHandle";
    /// <summary>
    /// The get motion data
    /// </summary>
    public static readonly StringName GetMotionData = "getMotionData";
    /// <summary>
    /// The get remote play session id
    /// </summary>
    public static readonly StringName GetRemotePlaySessionID = "getRemotePlaySessionID";
    /// <summary>
    /// The get string for action origin
    /// </summary>
    public static readonly StringName GetStringForActionOrigin = "getStringForActionOrigin";
    /// <summary>
    /// The input init
    /// </summary>
    public static readonly StringName InputInit = "inputInit";
    /// <summary>
    /// The input shutdown
    /// </summary>
    public static readonly StringName InputShutdown = "inputShutdown";
    /// <summary>
    /// The run frame
    /// </summary>
    public static readonly StringName RunFrame = "runFrame";
    /// <summary>
    /// The set led color
    /// </summary>
    public static readonly StringName SetLEDColor = "setLEDColor";
    /// <summary>
    /// The show binding panel
    /// </summary>
    public static readonly StringName ShowBindingPanel = "showBindingPanel";
    /// <summary>
    /// The stop analog action momentum
    /// </summary>
    public static readonly StringName StopAnalogActionMomentum = "stopAnalogActionMomentum";
    /// <summary>
    /// The translate action origin
    /// </summary>
    public static readonly StringName TranslateActionOrigin = "translateActionOrigin";
    /// <summary>
    /// The trigger haptic pulse
    /// </summary>
    public static readonly StringName TriggerHapticPulse = "triggerHapticPulse";
    /// <summary>
    /// The trigger repeated haptic pulse
    /// </summary>
    public static readonly StringName TriggerRepeatedHapticPulse = "triggerRepeatedHapticPulse";
    /// <summary>
    /// The trigger vibration
    /// </summary>
    public static readonly StringName TriggerVibration = "triggerVibration";
    /// <summary>
    /// The set input action manifest file path
    /// </summary>
    public static readonly StringName SetInputActionManifestFilePath = "setInputActionManifestFilePath";
    /// <summary>
    /// The set dual sense trigger effect
    /// </summary>
    public static readonly StringName SetDualSenseTriggerEffect = "setDualSenseTriggerEffect";
    /// <summary>
    /// The wait for data
    /// </summary>
    public static readonly StringName WaitForData = "waitForData";
    /// <summary>
    /// The new data available
    /// </summary>
    public static readonly StringName NewDataAvailable = "newDataAvailable";
    /// <summary>
    /// The enable device callbacks
    /// </summary>
    public static readonly StringName EnableDeviceCallbacks = "enableDeviceCallbacks";
    /// <summary>
    /// The get glyph png for action origin
    /// </summary>
    public static readonly StringName GetGlyphPNGForActionOrigin = "getGlyphPNGForActionOrigin";
    /// <summary>
    /// The get glyph svg for action origin
    /// </summary>
    public static readonly StringName GetGlyphSVGForActionOrigin = "getGlyphSVGForActionOrigin";
    /// <summary>
    /// The trigger vibration extended
    /// </summary>
    public static readonly StringName TriggerVibrationExtended = "triggerVibrationExtended";
    /// <summary>
    /// The trigger simple haptic event
    /// </summary>
    public static readonly StringName TriggerSimpleHapticEvent = "triggerSimpleHapticEvent";
    /// <summary>
    /// The get string for xbox origin
    /// </summary>
    public static readonly StringName GetStringForXboxOrigin = "getStringForXboxOrigin";
    /// <summary>
    /// The get glyph for xbox origin
    /// </summary>
    public static readonly StringName GetGlyphForXboxOrigin = "getGlyphForXboxOrigin";
    /// <summary>
    /// The get session input configuration settings
    /// </summary>
    public static readonly StringName GetSessionInputConfigurationSettings = "getSessionInputConfigurationSettings";
    /// <summary>
    /// The get string for digital action name
    /// </summary>
    public static readonly StringName GetStringForDigitalActionName = "getStringForDigitalActionName";
    /// <summary>
    /// The get string for analog action name
    /// </summary>
    public static readonly StringName GetStringForAnalogActionName = "getStringForAnalogActionName";
    /// <summary>
    /// The add promo item
    /// </summary>
    public static readonly StringName AddPromoItem = "addPromoItem";
    /// <summary>
    /// The add promo items
    /// </summary>
    public static readonly StringName AddPromoItems = "addPromoItems";
    /// <summary>
    /// The check result steam id
    /// </summary>
    public static readonly StringName CheckResultSteamID = "checkResultSteamID";
    /// <summary>
    /// The consume item
    /// </summary>
    public static readonly StringName ConsumeItem = "consumeItem";
    /// <summary>
    /// The deserialize result
    /// </summary>
    public static readonly StringName DeserializeResult = "deserializeResult";
    /// <summary>
    /// The destroy result
    /// </summary>
    public static readonly StringName DestroyResult = "destroyResult";
    /// <summary>
    /// The exchange items
    /// </summary>
    public static readonly StringName ExchangeItems = "exchangeItems";
    /// <summary>
    /// The generate items
    /// </summary>
    public static readonly StringName GenerateItems = "generateItems";
    /// <summary>
    /// The get all items
    /// </summary>
    public static readonly StringName GetAllItems = "getAllItems";
    /// <summary>
    /// The get item definition property
    /// </summary>
    public static readonly StringName GetItemDefinitionProperty = "getItemDefinitionProperty";
    /// <summary>
    /// The get items by id
    /// </summary>
    public static readonly StringName GetItemsByID = "getItemsByID";
    /// <summary>
    /// The get item price
    /// </summary>
    public static readonly StringName GetItemPrice = "getItemPrice";
    /// <summary>
    /// The get items with prices
    /// </summary>
    public static readonly StringName GetItemsWithPrices = "getItemsWithPrices";
    /// <summary>
    /// The get num items with prices
    /// </summary>
    public static readonly StringName GetNumItemsWithPrices = "getNumItemsWithPrices";
    /// <summary>
    /// The get result item property
    /// </summary>
    public static readonly StringName GetResultItemProperty = "getResultItemProperty";
    /// <summary>
    /// The get result items
    /// </summary>
    public static readonly StringName GetResultItems = "getResultItems";
    /// <summary>
    /// The get result status
    /// </summary>
    public static readonly StringName GetResultStatus = "getResultStatus";
    /// <summary>
    /// The get result timestamp
    /// </summary>
    public static readonly StringName GetResultTimestamp = "getResultTimestamp";
    /// <summary>
    /// The grant promo items
    /// </summary>
    public static readonly StringName GrantPromoItems = "grantPromoItems";
    /// <summary>
    /// The load item definitions
    /// </summary>
    public static readonly StringName LoadItemDefinitions = "loadItemDefinitions";
    /// <summary>
    /// The request eligible promo item definitions ds
    /// </summary>
    public static readonly StringName RequestEligiblePromoItemDefinitionsIDs = "requestEligiblePromoItemDefinitionsIDs";
    /// <summary>
    /// The request prices
    /// </summary>
    public static readonly StringName RequestPrices = "requestPrices";
    /// <summary>
    /// The serialize result
    /// </summary>
    public static readonly StringName SerializeResult = "serializeResult";
    /// <summary>
    /// The start purchase
    /// </summary>
    public static readonly StringName StartPurchase = "startPurchase";
    /// <summary>
    /// The transfer item quantity
    /// </summary>
    public static readonly StringName TransferItemQuantity = "transferItemQuantity";
    /// <summary>
    /// The trigger item drop
    /// </summary>
    public static readonly StringName TriggerItemDrop = "triggerItemDrop";
    /// <summary>
    /// The start update properties
    /// </summary>
    public static readonly StringName StartUpdateProperties = "startUpdateProperties";
    /// <summary>
    /// The submit update properties
    /// </summary>
    public static readonly StringName SubmitUpdateProperties = "submitUpdateProperties";
    /// <summary>
    /// The remove property
    /// </summary>
    public static readonly StringName RemoveProperty = "removeProperty";
    /// <summary>
    /// The set property string
    /// </summary>
    public static readonly StringName SetPropertyString = "setPropertyString";
    /// <summary>
    /// The set property bool
    /// </summary>
    public static readonly StringName SetPropertyBool = "setPropertyBool";
    /// <summary>
    /// The set property int
    /// </summary>
    public static readonly StringName SetPropertyInt = "setPropertyInt";
    /// <summary>
    /// The set property float
    /// </summary>
    public static readonly StringName SetPropertyFloat = "setPropertyFloat";
    /// <summary>
    /// The get favorite games
    /// </summary>
    public static readonly StringName GetFavoriteGames = "getFavoriteGames";
    /// <summary>
    /// The add favorite game
    /// </summary>
    public static readonly StringName AddFavoriteGame = "addFavoriteGame";
    /// <summary>
    /// The remove favorite game
    /// </summary>
    public static readonly StringName RemoveFavoriteGame = "removeFavoriteGame";
    /// <summary>
    /// The request lobby list
    /// </summary>
    public static readonly StringName RequestLobbyList = "requestLobbyList";
    /// <summary>
    /// The add request lobby list string filter
    /// </summary>
    public static readonly StringName AddRequestLobbyListStringFilter = "addRequestLobbyListStringFilter";
    /// <summary>
    /// The add request lobby list numerical filter
    /// </summary>
    public static readonly StringName AddRequestLobbyListNumericalFilter = "addRequestLobbyListNumericalFilter";
    /// <summary>
    /// The add request lobby list near value filter
    /// </summary>
    public static readonly StringName AddRequestLobbyListNearValueFilter = "addRequestLobbyListNearValueFilter";
    /// <summary>
    /// The add request lobby list filter slots available
    /// </summary>
    public static readonly StringName AddRequestLobbyListFilterSlotsAvailable = "addRequestLobbyListFilterSlotsAvailable";
    /// <summary>
    /// The add request lobby list distance filter
    /// </summary>
    public static readonly StringName AddRequestLobbyListDistanceFilter = "addRequestLobbyListDistanceFilter";
    /// <summary>
    /// The add request lobby list result count filter
    /// </summary>
    public static readonly StringName AddRequestLobbyListResultCountFilter = "addRequestLobbyListResultCountFilter";
    /// <summary>
    /// The create lobby
    /// </summary>
    public static readonly StringName CreateLobby = "createLobby";
    /// <summary>
    /// The join lobby
    /// </summary>
    public static readonly StringName JoinLobby = "joinLobby";
    /// <summary>
    /// The leave lobby
    /// </summary>
    public static readonly StringName LeaveLobby = "leaveLobby";
    /// <summary>
    /// The invite user to lobby
    /// </summary>
    public static readonly StringName InviteUserToLobby = "inviteUserToLobby";
    /// <summary>
    /// The get num lobby members
    /// </summary>
    public static readonly StringName GetNumLobbyMembers = "getNumLobbyMembers";
    /// <summary>
    /// The get lobby member by index
    /// </summary>
    public static readonly StringName GetLobbyMemberByIndex = "getLobbyMemberByIndex";
    /// <summary>
    /// The get lobby data
    /// </summary>
    public static readonly StringName GetLobbyData = "getLobbyData";
    /// <summary>
    /// The set lobby data
    /// </summary>
    public static readonly StringName SetLobbyData = "setLobbyData";
    /// <summary>
    /// The get all lobby data
    /// </summary>
    public static readonly StringName GetAllLobbyData = "getAllLobbyData";
    /// <summary>
    /// The delete lobby data
    /// </summary>
    public static readonly StringName DeleteLobbyData = "deleteLobbyData";
    /// <summary>
    /// The get lobby member data
    /// </summary>
    public static readonly StringName GetLobbyMemberData = "getLobbyMemberData";
    /// <summary>
    /// The set lobby member data
    /// </summary>
    public static readonly StringName SetLobbyMemberData = "setLobbyMemberData";
    /// <summary>
    /// The send lobby chat msg
    /// </summary>
    public static readonly StringName SendLobbyChatMsg = "sendLobbyChatMsg";
    /// <summary>
    /// The request lobby data
    /// </summary>
    public static readonly StringName RequestLobbyData = "requestLobbyData";
    /// <summary>
    /// The set lobby game server
    /// </summary>
    public static readonly StringName SetLobbyGameServer = "setLobbyGameServer";
    /// <summary>
    /// The get lobby game server
    /// </summary>
    public static readonly StringName GetLobbyGameServer = "getLobbyGameServer";
    /// <summary>
    /// The set lobby member limit
    /// </summary>
    public static readonly StringName SetLobbyMemberLimit = "setLobbyMemberLimit";
    /// <summary>
    /// The get lobby member limit
    /// </summary>
    public static readonly StringName GetLobbyMemberLimit = "getLobbyMemberLimit";
    /// <summary>
    /// The set lobby type
    /// </summary>
    public static readonly StringName SetLobbyType = "setLobbyType";
    /// <summary>
    /// The set lobby joinable
    /// </summary>
    public static readonly StringName SetLobbyJoinable = "setLobbyJoinable";
    /// <summary>
    /// The get lobby owner
    /// </summary>
    public static readonly StringName GetLobbyOwner = "getLobbyOwner";
    /// <summary>
    /// The set lobby owner
    /// </summary>
    public static readonly StringName SetLobbyOwner = "setLobbyOwner";
    /// <summary>
    /// The cancel query
    /// </summary>
    public static readonly StringName CancelQuery = "cancelQuery";
    /// <summary>
    /// The cancel server query
    /// </summary>
    public static readonly StringName CancelServerQuery = "cancelServerQuery";
    /// <summary>
    /// The get server count
    /// </summary>
    public static readonly StringName GetServerCount = "getServerCount";
    /// <summary>
    /// The get server details
    /// </summary>
    public static readonly StringName GetServerDetails = "getServerDetails";
    /// <summary>
    /// The is refreshing
    /// </summary>
    public static readonly StringName IsRefreshing = "isRefreshing";
    /// <summary>
    /// The ping server
    /// </summary>
    public static readonly StringName PingServer = "pingServer";
    /// <summary>
    /// The player details
    /// </summary>
    public static readonly StringName PlayerDetails = "playerDetails";
    /// <summary>
    /// The refresh query
    /// </summary>
    public static readonly StringName RefreshQuery = "refreshQuery";
    /// <summary>
    /// The refresh server
    /// </summary>
    public static readonly StringName RefreshServer = "refreshServer";
    /// <summary>
    /// The release request
    /// </summary>
    public static readonly StringName ReleaseRequest = "releaseRequest";
    /// <summary>
    /// The request favorites server list
    /// </summary>
    public static readonly StringName RequestFavoritesServerList = "requestFavoritesServerList";
    /// <summary>
    /// The request friends server list
    /// </summary>
    public static readonly StringName RequestFriendsServerList = "requestFriendsServerList";
    /// <summary>
    /// The request history server list
    /// </summary>
    public static readonly StringName RequestHistoryServerList = "requestHistoryServerList";
    /// <summary>
    /// The request internet server list
    /// </summary>
    public static readonly StringName RequestInternetServerList = "requestInternetServerList";
    /// <summary>
    /// The request lan server list
    /// </summary>
    public static readonly StringName RequestLANServerList = "requestLANServerList";
    /// <summary>
    /// The request spectator server list
    /// </summary>
    public static readonly StringName RequestSpectatorServerList = "requestSpectatorServerList";
    /// <summary>
    /// The server rules
    /// </summary>
    public static readonly StringName ServerRules = "serverRules";
    /// <summary>
    /// The music is enabled
    /// </summary>
    public static readonly StringName MusicIsEnabled = "musicIsEnabled";
    /// <summary>
    /// The music is playing
    /// </summary>
    public static readonly StringName MusicIsPlaying = "musicIsPlaying";
    /// <summary>
    /// The get playback status
    /// </summary>
    public static readonly StringName GetPlaybackStatus = "getPlaybackStatus";
    /// <summary>
    /// The music get volume
    /// </summary>
    public static readonly StringName MusicGetVolume = "musicGetVolume";
    /// <summary>
    /// The music pause
    /// </summary>
    public static readonly StringName MusicPause = "musicPause";
    /// <summary>
    /// The music play
    /// </summary>
    public static readonly StringName MusicPlay = "musicPlay";
    /// <summary>
    /// The music play next
    /// </summary>
    public static readonly StringName MusicPlayNext = "musicPlayNext";
    /// <summary>
    /// The music play prev
    /// </summary>
    public static readonly StringName MusicPlayPrev = "musicPlayPrev";
    /// <summary>
    /// The music set volume
    /// </summary>
    public static readonly StringName MusicSetVolume = "musicSetVolume";
    /// <summary>
    /// The activation success
    /// </summary>
    public static readonly StringName ActivationSuccess = "activationSuccess";
    /// <summary>
    /// The is current music remote
    /// </summary>
    public static readonly StringName IsCurrentMusicRemote = "isCurrentMusicRemote";
    /// <summary>
    /// The current entry did change
    /// </summary>
    public static readonly StringName CurrentEntryDidChange = "currentEntryDidChange";
    /// <summary>
    /// The current entry is available
    /// </summary>
    public static readonly StringName CurrentEntryIsAvailable = "currentEntryIsAvailable";
    /// <summary>
    /// The current entry will change
    /// </summary>
    public static readonly StringName CurrentEntryWillChange = "currentEntryWillChange";
    /// <summary>
    /// The deregister steam music remote
    /// </summary>
    public static readonly StringName DeregisterSteamMusicRemote = "deregisterSteamMusicRemote";
    /// <summary>
    /// The enable looped
    /// </summary>
    public static readonly StringName EnableLooped = "enableLooped";
    /// <summary>
    /// The enable playlists
    /// </summary>
    public static readonly StringName EnablePlaylists = "enablePlaylists";
    /// <summary>
    /// The enable play next
    /// </summary>
    public static readonly StringName EnablePlayNext = "enablePlayNext";
    /// <summary>
    /// The enable play previous
    /// </summary>
    public static readonly StringName EnablePlayPrevious = "enablePlayPrevious";
    /// <summary>
    /// The enable queue
    /// </summary>
    public static readonly StringName EnableQueue = "enableQueue";
    /// <summary>
    /// The enable shuffled
    /// </summary>
    public static readonly StringName EnableShuffled = "enableShuffled";
    /// <summary>
    /// The playlist did change
    /// </summary>
    public static readonly StringName PlaylistDidChange = "playlistDidChange";
    /// <summary>
    /// The playlist will change
    /// </summary>
    public static readonly StringName PlaylistWillChange = "playlistWillChange";
    /// <summary>
    /// The queue did change
    /// </summary>
    public static readonly StringName QueueDidChange = "queueDidChange";
    /// <summary>
    /// The queue will change
    /// </summary>
    public static readonly StringName QueueWillChange = "queueWillChange";
    /// <summary>
    /// The register steam music remote
    /// </summary>
    public static readonly StringName RegisterSteamMusicRemote = "registerSteamMusicRemote";
    /// <summary>
    /// The reset playlist entries
    /// </summary>
    public static readonly StringName ResetPlaylistEntries = "resetPlaylistEntries";
    /// <summary>
    /// The reset queue entries
    /// </summary>
    public static readonly StringName ResetQueueEntries = "resetQueueEntries";
    /// <summary>
    /// The set current playlist entry
    /// </summary>
    public static readonly StringName SetCurrentPlaylistEntry = "setCurrentPlaylistEntry";
    /// <summary>
    /// The set current queue entry
    /// </summary>
    public static readonly StringName SetCurrentQueueEntry = "setCurrentQueueEntry";
    /// <summary>
    /// The set display name
    /// </summary>
    public static readonly StringName SetDisplayName = "setDisplayName";
    /// <summary>
    /// The set playlist entry
    /// </summary>
    public static readonly StringName SetPlaylistEntry = "setPlaylistEntry";
    /// <summary>
    /// The set png icon 64 64
    /// </summary>
    public static readonly StringName SetPNGIcon64X64 = "setPNGIcon64x64";
    /// <summary>
    /// The set queue entry
    /// </summary>
    public static readonly StringName SetQueueEntry = "setQueueEntry";
    /// <summary>
    /// The update current entry cover art
    /// </summary>
    public static readonly StringName UpdateCurrentEntryCoverArt = "updateCurrentEntryCoverArt";
    /// <summary>
    /// The update current entry elapsed seconds
    /// </summary>
    public static readonly StringName UpdateCurrentEntryElapsedSeconds = "updateCurrentEntryElapsedSeconds";
    /// <summary>
    /// The update current entry text
    /// </summary>
    public static readonly StringName UpdateCurrentEntryText = "updateCurrentEntryText";
    /// <summary>
    /// The update looped
    /// </summary>
    public static readonly StringName UpdateLooped = "updateLooped";
    /// <summary>
    /// The update playback status
    /// </summary>
    public static readonly StringName UpdatePlaybackStatus = "updatePlaybackStatus";
    /// <summary>
    /// The update shuffled
    /// </summary>
    public static readonly StringName UpdateShuffled = "updateShuffled";
    /// <summary>
    /// The update volume
    /// </summary>
    public static readonly StringName UpdateVolume = "updateVolume";
    /// <summary>
    /// The accept session with user
    /// </summary>
    public static readonly StringName AcceptP2PSessionWithUser = "acceptP2PSessionWithUser";
    /// <summary>
    /// The allow packet relay
    /// </summary>
    public static readonly StringName AllowP2PPacketRelay = "allowP2PPacketRelay";
    /// <summary>
    /// The close channel with user
    /// </summary>
    public static readonly StringName CloseP2PChannelWithUser = "closeP2PChannelWithUser";
    /// <summary>
    /// The close session with user
    /// </summary>
    public static readonly StringName CloseP2PSessionWithUser = "closeP2PSessionWithUser";
    /// <summary>
    /// The get session state
    /// </summary>
    public static readonly StringName GetP2PSessionState = "getP2PSessionState";
    /// <summary>
    /// The get available packet size
    /// </summary>
    public static readonly StringName GetAvailableP2PPacketSize = "getAvailableP2PPacketSize";
    /// <summary>
    /// The read packet
    /// </summary>
    public static readonly StringName ReadP2PPacket = "readP2PPacket";
    /// <summary>
    /// The send packet
    /// </summary>
    public static readonly StringName SendP2PPacket = "sendP2PPacket";
    /// <summary>
    /// The accept session with user
    /// </summary>
    public static readonly StringName AcceptSessionWithUser = "acceptSessionWithUser";
    /// <summary>
    /// The close channel with user
    /// </summary>
    public static readonly StringName CloseChannelWithUser = "closeChannelWithUser";
    /// <summary>
    /// The close session with user
    /// </summary>
    public static readonly StringName CloseSessionWithUser = "closeSessionWithUser";
    /// <summary>
    /// The get session connection info
    /// </summary>
    public static readonly StringName GetSessionConnectionInfo = "getSessionConnectionInfo";
    /// <summary>
    /// The receive messages on channel
    /// </summary>
    public static readonly StringName ReceiveMessagesOnChannel = "receiveMessagesOnChannel";
    /// <summary>
    /// The send message to user
    /// </summary>
    public static readonly StringName SendMessageToUser = "sendMessageToUser";
    /// <summary>
    /// The accept connection
    /// </summary>
    public static readonly StringName AcceptConnection = "acceptConnection";
    /// <summary>
    /// The begin async request fake ip
    /// </summary>
    public static readonly StringName BeginAsyncRequestFakeIP = "beginAsyncRequestFakeIP";
    /// <summary>
    /// The close connection
    /// </summary>
    public static readonly StringName CloseConnection = "closeConnection";
    /// <summary>
    /// The close listen socket
    /// </summary>
    public static readonly StringName CloseListenSocket = "closeListenSocket";
    /// <summary>
    /// The configure connection lanes
    /// </summary>
    public static readonly StringName ConfigureConnectionLanes = "configureConnectionLanes";
    /// <summary>
    /// The connect
    /// </summary>
    public static readonly StringName ConnectP2P = "connectP2P";
    /// <summary>
    /// The connect by ip address
    /// </summary>
    public static readonly StringName ConnectByIPAddress = "connectByIPAddress";
    /// <summary>
    /// The connect to hosted dedicated server
    /// </summary>
    public static readonly StringName ConnectToHostedDedicatedServer = "connectToHostedDedicatedServer";
    /// <summary>
    /// The create fake udp port
    /// </summary>
    public static readonly StringName CreateFakeUDPPort = "createFakeUDPPort";
    /// <summary>
    /// The create hosted dedicated server listen socket
    /// </summary>
    public static readonly StringName CreateHostedDedicatedServerListenSocket = "createHostedDedicatedServerListenSocket";
    /// <summary>
    /// The create listen socket ip
    /// </summary>
    public static readonly StringName CreateListenSocketIP = "createListenSocketIP";
    /// <summary>
    /// The create listen socket
    /// </summary>
    public static readonly StringName CreateListenSocketP2P = "createListenSocketP2P";
    /// <summary>
    /// The create listen socket fake ip
    /// </summary>
    public static readonly StringName CreateListenSocketP2PFakeIP = "createListenSocketP2PFakeIP";
    /// <summary>
    /// The create poll group
    /// </summary>
    public static readonly StringName CreatePollGroup = "createPollGroup";
    /// <summary>
    /// The create socket pair
    /// </summary>
    public static readonly StringName CreateSocketPair = "createSocketPair";
    /// <summary>
    /// The destroy poll group
    /// </summary>
    public static readonly StringName DestroyPollGroup = "destroyPollGroup";
    /// <summary>
    /// The flush messages on connection
    /// </summary>
    public static readonly StringName FlushMessagesOnConnection = "flushMessagesOnConnection";
    /// <summary>
    /// The get authentication status
    /// </summary>
    public static readonly StringName GetAuthenticationStatus = "getAuthenticationStatus";
    /// <summary>
    /// The get certificate request
    /// </summary>
    public static readonly StringName GetCertificateRequest = "getCertificateRequest";
    /// <summary>
    /// The get connection info
    /// </summary>
    public static readonly StringName GetConnectionInfo = "getConnectionInfo";
    /// <summary>
    /// The get connection name
    /// </summary>
    public static readonly StringName GetConnectionName = "getConnectionName";
    /// <summary>
    /// The get connection real time status
    /// </summary>
    public static readonly StringName GetConnectionRealTimeStatus = "getConnectionRealTimeStatus";
    /// <summary>
    /// The get connection user data
    /// </summary>
    public static readonly StringName GetConnectionUserData = "getConnectionUserData";
    /// <summary>
    /// The get detailed connection status
    /// </summary>
    public static readonly StringName GetDetailedConnectionStatus = "getDetailedConnectionStatus";
    /// <summary>
    /// The get fake ip
    /// </summary>
    public static readonly StringName GetFakeIP = "getFakeIP";
    /// <summary>
    /// The get hosted dedicated server pop id
    /// </summary>
    public static readonly StringName GetHostedDedicatedServerPOPId = "getHostedDedicatedServerPOPId";
    /// <summary>
    /// The get hosted dedicated server port
    /// </summary>
    public static readonly StringName GetHostedDedicatedServerPort = "getHostedDedicatedServerPort";
    /// <summary>
    /// The get listen socket address
    /// </summary>
    public static readonly StringName GetListenSocketAddress = "getListenSocketAddress";
    /// <summary>
    /// The get identity
    /// </summary>
    public static readonly StringName GetIdentity = "getIdentity";
    /// <summary>
    /// The get remote fake ip for connection
    /// </summary>
    public static readonly StringName GetRemoteFakeIPForConnection = "getRemoteFakeIPForConnection";
    /// <summary>
    /// The init authentication
    /// </summary>
    public static readonly StringName InitAuthentication = "initAuthentication";
    /// <summary>
    /// The receive messages on connection
    /// </summary>
    public static readonly StringName ReceiveMessagesOnConnection = "receiveMessagesOnConnection";
    /// <summary>
    /// The receive messages on poll group
    /// </summary>
    public static readonly StringName ReceiveMessagesOnPollGroup = "receiveMessagesOnPollGroup";
    /// <summary>
    /// The reset identity
    /// </summary>
    public static readonly StringName ResetIdentity = "resetIdentity";
    /// <summary>
    /// The run networking callbacks
    /// </summary>
    public static readonly StringName RunNetworkingCallbacks = "runNetworkingCallbacks";
    /// <summary>
    /// The send messages
    /// </summary>
    public static readonly StringName SendMessages = "sendMessages";
    /// <summary>
    /// The send message to connection
    /// </summary>
    public static readonly StringName SendMessageToConnection = "sendMessageToConnection";
    /// <summary>
    /// The set certificate
    /// </summary>
    public static readonly StringName SetCertificate = "setCertificate";
    /// <summary>
    /// The set connection poll group
    /// </summary>
    public static readonly StringName SetConnectionPollGroup = "setConnectionPollGroup";
    /// <summary>
    /// The set connection name
    /// </summary>
    public static readonly StringName SetConnectionName = "setConnectionName";
    /// <summary>
    /// The add identity
    /// </summary>
    public static readonly StringName AddIdentity = "addIdentity";
    /// <summary>
    /// The add ip address
    /// </summary>
    public static readonly StringName AddIPAddress = "addIPAddress";
    /// <summary>
    /// The clear identity
    /// </summary>
    public static readonly StringName ClearIdentity = "clearIdentity";
    /// <summary>
    /// The clear ip address
    /// </summary>
    public static readonly StringName ClearIPAddress = "clearIPAddress";
    /// <summary>
    /// The get generic bytes
    /// </summary>
    public static readonly StringName GetGenericBytes = "getGenericBytes";
    /// <summary>
    /// The get generic string
    /// </summary>
    public static readonly StringName GetGenericString = "getGenericString";
    /// <summary>
    /// The get identities
    /// </summary>
    public static readonly StringName GetIdentities = "getIdentities";
    /// <summary>
    /// The get identity ip addr
    /// </summary>
    public static readonly StringName GetIdentityIPAddr = "getIdentityIPAddr";
    /// <summary>
    /// The get identity steam id
    /// </summary>
    public static readonly StringName GetIdentitySteamID = "getIdentitySteamID";
    /// <summary>
    /// The get identity steam id 64
    /// </summary>
    public static readonly StringName GetIdentitySteamID64 = "getIdentitySteamID64";
    /// <summary>
    /// The get ip addresses
    /// </summary>
    public static readonly StringName GetIPAddresses = "getIPAddresses";
    /// <summary>
    /// The get pv
    /// </summary>
    public static readonly StringName GetIPv4 = "getIPv4";
    /// <summary>
    /// The get psnid
    /// </summary>
    public static readonly StringName GetPSNID = "getPSNID";
    /// <summary>
    /// The get stadia id
    /// </summary>
    public static readonly StringName GetStadiaID = "getStadiaID";
    /// <summary>
    /// The get xbox pairwise id
    /// </summary>
    public static readonly StringName GetXboxPairwiseID = "getXboxPairwiseID";
    /// <summary>
    /// The is address local host
    /// </summary>
    public static readonly StringName IsAddressLocalHost = "isAddressLocalHost";
    /// <summary>
    /// The is identity invalid
    /// </summary>
    public static readonly StringName IsIdentityInvalid = "isIdentityInvalid";
    /// <summary>
    /// The is identity local host
    /// </summary>
    public static readonly StringName IsIdentityLocalHost = "isIdentityLocalHost";
    /// <summary>
    /// The is pv
    /// </summary>
    public static readonly StringName IsIPv4 = "isIPv4";
    /// <summary>
    /// The is pv all zeros
    /// </summary>
    public static readonly StringName IsIPv6AllZeros = "isIPv6AllZeros";
    /// <summary>
    /// The parse identity string
    /// </summary>
    public static readonly StringName ParseIdentityString = "parseIdentityString";
    /// <summary>
    /// The parse ip address string
    /// </summary>
    public static readonly StringName ParseIPAddressString = "parseIPAddressString";
    /// <summary>
    /// The set generic bytes
    /// </summary>
    public static readonly StringName SetGenericBytes = "setGenericBytes";
    /// <summary>
    /// The set generic string
    /// </summary>
    public static readonly StringName SetGenericString = "setGenericString";
    /// <summary>
    /// The set identity ip addr
    /// </summary>
    public static readonly StringName SetIdentityIPAddr = "setIdentityIPAddr";
    /// <summary>
    /// The set identity local host
    /// </summary>
    public static readonly StringName SetIdentityLocalHost = "setIdentityLocalHost";
    /// <summary>
    /// The set identity steam id
    /// </summary>
    public static readonly StringName SetIdentitySteamID = "setIdentitySteamID";
    /// <summary>
    /// The set identity steam id 64
    /// </summary>
    public static readonly StringName SetIdentitySteamID64 = "setIdentitySteamID64";
    /// <summary>
    /// The set pv
    /// </summary>
    public static readonly StringName SetIPv4 = "setIPv4";
    /// <summary>
    /// The set pv
    /// </summary>
    public static readonly StringName SetIPv6 = "setIPv6";
    /// <summary>
    /// The set pv local host
    /// </summary>
    public static readonly StringName SetIPv6LocalHost = "setIPv6LocalHost";
    /// <summary>
    /// The set psnid
    /// </summary>
    public static readonly StringName SetPSNID = "setPSNID";
    /// <summary>
    /// The set stadia id
    /// </summary>
    public static readonly StringName SetStadiaID = "setStadiaID";
    /// <summary>
    /// The set xbox pairwise id
    /// </summary>
    public static readonly StringName SetXboxPairwiseID = "setXboxPairwiseID";
    /// <summary>
    /// The to identity string
    /// </summary>
    public static readonly StringName ToIdentityString = "toIdentityString";
    /// <summary>
    /// The to ip address string
    /// </summary>
    public static readonly StringName ToIPAddressString = "toIPAddressString";
    /// <summary>
    /// The check ping data up to date
    /// </summary>
    public static readonly StringName CheckPingDataUpToDate = "checkPingDataUpToDate";
    /// <summary>
    /// The convert ping location to string
    /// </summary>
    public static readonly StringName ConvertPingLocationToString = "convertPingLocationToString";
    /// <summary>
    /// The estimate ping time between two locations
    /// </summary>
    public static readonly StringName EstimatePingTimeBetweenTwoLocations = "estimatePingTimeBetweenTwoLocations";
    /// <summary>
    /// The estimate ping time from local host
    /// </summary>
    public static readonly StringName EstimatePingTimeFromLocalHost = "estimatePingTimeFromLocalHost";
    /// <summary>
    /// The get config value
    /// </summary>
    public static readonly StringName GetConfigValue = "getConfigValue";
    /// <summary>
    /// The get config value info
    /// </summary>
    public static readonly StringName GetConfigValueInfo = "getConfigValueInfo";
    /// <summary>
    /// The get direct ping to pop
    /// </summary>
    public static readonly StringName GetDirectPingToPOP = "getDirectPingToPOP";
    /// <summary>
    /// The get local ping location
    /// </summary>
    public static readonly StringName GetLocalPingLocation = "getLocalPingLocation";
    /// <summary>
    /// The get local timestamp
    /// </summary>
    public static readonly StringName GetLocalTimestamp = "getLocalTimestamp";
    /// <summary>
    /// The get ping to data center
    /// </summary>
    public static readonly StringName GetPingToDataCenter = "getPingToDataCenter";
    /// <summary>
    /// The get pop count
    /// </summary>
    public static readonly StringName GetPOPCount = "getPOPCount";
    /// <summary>
    /// The get pop list
    /// </summary>
    public static readonly StringName GetPOPList = "getPOPList";
    /// <summary>
    /// The get relay network status
    /// </summary>
    public static readonly StringName GetRelayNetworkStatus = "getRelayNetworkStatus";
    /// <summary>
    /// The init relay network access
    /// </summary>
    public static readonly StringName InitRelayNetworkAccess = "initRelayNetworkAccess";
    /// <summary>
    /// The parse ping location string
    /// </summary>
    public static readonly StringName ParsePingLocationString = "parsePingLocationString";
    /// <summary>
    /// The set connection config value float
    /// </summary>
    public static readonly StringName SetConnectionConfigValueFloat = "setConnectionConfigValueFloat";
    /// <summary>
    /// The set connection config value int 32
    /// </summary>
    public static readonly StringName SetConnectionConfigValueInt32 = "setConnectionConfigValueInt32";
    /// <summary>
    /// The set connection config value string
    /// </summary>
    public static readonly StringName SetConnectionConfigValueString = "setConnectionConfigValueString";
    /// <summary>
    /// The set global config value float
    /// </summary>
    public static readonly StringName SetGlobalConfigValueFloat = "setGlobalConfigValueFloat";
    /// <summary>
    /// The set global config value int 32
    /// </summary>
    public static readonly StringName SetGlobalConfigValueInt32 = "setGlobalConfigValueInt32";
    /// <summary>
    /// The set global config value string
    /// </summary>
    public static readonly StringName SetGlobalConfigValueString = "setGlobalConfigValueString";
    /// <summary>
    /// The is parental lock enabled
    /// </summary>
    public static readonly StringName IsParentalLockEnabled = "isParentalLockEnabled";
    /// <summary>
    /// The is parental lock locked
    /// </summary>
    public static readonly StringName IsParentalLockLocked = "isParentalLockLocked";
    /// <summary>
    /// The is app blocked
    /// </summary>
    public static readonly StringName IsAppBlocked = "isAppBlocked";
    /// <summary>
    /// The is app in block list
    /// </summary>
    public static readonly StringName IsAppInBlockList = "isAppInBlockList";
    /// <summary>
    /// The is feature blocked
    /// </summary>
    public static readonly StringName IsFeatureBlocked = "isFeatureBlocked";
    /// <summary>
    /// The is feature in block list
    /// </summary>
    public static readonly StringName IsFeatureInBlockList = "isFeatureInBlockList";
    /// <summary>
    /// The cancel reservation
    /// </summary>
    public static readonly StringName CancelReservation = "cancelReservation";
    /// <summary>
    /// The change num open slots
    /// </summary>
    public static readonly StringName ChangeNumOpenSlots = "changeNumOpenSlots";
    /// <summary>
    /// The create beacon
    /// </summary>
    public static readonly StringName CreateBeacon = "createBeacon";
    /// <summary>
    /// The destroy beacon
    /// </summary>
    public static readonly StringName DestroyBeacon = "destroyBeacon";
    /// <summary>
    /// The get available beacon locations
    /// </summary>
    public static readonly StringName GetAvailableBeaconLocations = "getAvailableBeaconLocations";
    /// <summary>
    /// The get beacon by index
    /// </summary>
    public static readonly StringName GetBeaconByIndex = "getBeaconByIndex";
    /// <summary>
    /// The get beacon details
    /// </summary>
    public static readonly StringName GetBeaconDetails = "getBeaconDetails";
    /// <summary>
    /// The get beacon location data
    /// </summary>
    public static readonly StringName GetBeaconLocationData = "getBeaconLocationData";
    /// <summary>
    /// The get num active beacons
    /// </summary>
    public static readonly StringName GetNumActiveBeacons = "getNumActiveBeacons";
    /// <summary>
    /// The join party
    /// </summary>
    public static readonly StringName JoinParty = "joinParty";
    /// <summary>
    /// The on reservation completed
    /// </summary>
    public static readonly StringName OnReservationCompleted = "onReservationCompleted";
    /// <summary>
    /// The get session count
    /// </summary>
    public static readonly StringName GetSessionCount = "getSessionCount";
    /// <summary>
    /// The get session id
    /// </summary>
    public static readonly StringName GetSessionID = "getSessionID";
    /// <summary>
    /// The get session steam id
    /// </summary>
    public static readonly StringName GetSessionSteamID = "getSessionSteamID";
    /// <summary>
    /// The get session client name
    /// </summary>
    public static readonly StringName GetSessionClientName = "getSessionClientName";
    /// <summary>
    /// The get session client form factor
    /// </summary>
    public static readonly StringName GetSessionClientFormFactor = "getSessionClientFormFactor";
    /// <summary>
    /// The get session client resolution
    /// </summary>
    public static readonly StringName GetSessionClientResolution = "getSessionClientResolution";
    /// <summary>
    /// The send remote play together invite
    /// </summary>
    public static readonly StringName SendRemotePlayTogetherInvite = "sendRemotePlayTogetherInvite";
    /// <summary>
    /// The start remote play together
    /// </summary>
    public static readonly StringName StartRemotePlayTogether = "startRemotePlayTogether";
    /// <summary>
    /// The begin file write batch
    /// </summary>
    public static readonly StringName BeginFileWriteBatch = "beginFileWriteBatch";
    /// <summary>
    /// The end file write batch
    /// </summary>
    public static readonly StringName EndFileWriteBatch = "endFileWriteBatch";
    /// <summary>
    /// The file delete
    /// </summary>
    public static readonly StringName FileDelete = "fileDelete";
    /// <summary>
    /// The file exists
    /// </summary>
    public static readonly StringName FileExists = "fileExists";
    /// <summary>
    /// The file forget
    /// </summary>
    public static readonly StringName FileForget = "fileForget";
    /// <summary>
    /// The file persisted
    /// </summary>
    public static readonly StringName FilePersisted = "filePersisted";
    /// <summary>
    /// The file read
    /// </summary>
    public static readonly StringName FileRead = "fileRead";
    /// <summary>
    /// The file read
    /// </summary>
    public static readonly StringName FileReadAsync = "fileReadAsync";
    /// <summary>
    /// The file share
    /// </summary>
    public static readonly StringName FileShare = "fileShare";
    /// <summary>
    /// The file write
    /// </summary>
    public static readonly StringName FileWrite = "fileWrite";
    /// <summary>
    /// The file write
    /// </summary>
    public static readonly StringName FileWriteAsync = "fileWriteAsync";
    /// <summary>
    /// The file write stream cancel
    /// </summary>
    public static readonly StringName FileWriteStreamCancel = "fileWriteStreamCancel";
    /// <summary>
    /// The file write stream close
    /// </summary>
    public static readonly StringName FileWriteStreamClose = "fileWriteStreamClose";
    /// <summary>
    /// The file write stream open
    /// </summary>
    public static readonly StringName FileWriteStreamOpen = "fileWriteStreamOpen";
    /// <summary>
    /// The file write stream write chunk
    /// </summary>
    public static readonly StringName FileWriteStreamWriteChunk = "fileWriteStreamWriteChunk";
    /// <summary>
    /// The get cached ugc count
    /// </summary>
    public static readonly StringName GetCachedUGCCount = "getCachedUGCCount";
    /// <summary>
    /// The get cached ugc handle
    /// </summary>
    public static readonly StringName GetCachedUGCHandle = "getCachedUGCHandle";
    /// <summary>
    /// The get file count
    /// </summary>
    public static readonly StringName GetFileCount = "getFileCount";
    /// <summary>
    /// The get file name and size
    /// </summary>
    public static readonly StringName GetFileNameAndSize = "getFileNameAndSize";
    /// <summary>
    /// The get file size
    /// </summary>
    public static readonly StringName GetFileSize = "getFileSize";
    /// <summary>
    /// The get file timestamp
    /// </summary>
    public static readonly StringName GetFileTimestamp = "getFileTimestamp";
    /// <summary>
    /// The get local file change
    /// </summary>
    public static readonly StringName GetLocalFileChange = "getLocalFileChange";
    /// <summary>
    /// The get local file change count
    /// </summary>
    public static readonly StringName GetLocalFileChangeCount = "getLocalFileChangeCount";
    /// <summary>
    /// The get quota
    /// </summary>
    public static readonly StringName GetQuota = "getQuota";
    /// <summary>
    /// The get sync platforms
    /// </summary>
    public static readonly StringName GetSyncPlatforms = "getSyncPlatforms";
    /// <summary>
    /// The get ugc details
    /// </summary>
    public static readonly StringName GetUGCDetails = "getUGCDetails";
    /// <summary>
    /// The get ugc download progress
    /// </summary>
    public static readonly StringName GetUGCDownloadProgress = "getUGCDownloadProgress";
    /// <summary>
    /// The is cloud enabled for account
    /// </summary>
    public static readonly StringName IsCloudEnabledForAccount = "isCloudEnabledForAccount";
    /// <summary>
    /// The is cloud enabled for app
    /// </summary>
    public static readonly StringName IsCloudEnabledForApp = "isCloudEnabledForApp";
    /// <summary>
    /// The set cloud enabled for app
    /// </summary>
    public static readonly StringName SetCloudEnabledForApp = "setCloudEnabledForApp";
    /// <summary>
    /// The set sync platforms
    /// </summary>
    public static readonly StringName SetSyncPlatforms = "setSyncPlatforms";
    /// <summary>
    /// The ugc download
    /// </summary>
    public static readonly StringName UgcDownload = "ugcDownload";
    /// <summary>
    /// The ugc download to location
    /// </summary>
    public static readonly StringName UgcDownloadToLocation = "ugcDownloadToLocation";
    /// <summary>
    /// The ugc read
    /// </summary>
    public static readonly StringName UgcRead = "ugcRead";
    /// <summary>
    /// The add screenshot to library
    /// </summary>
    public static readonly StringName AddScreenshotToLibrary = "addScreenshotToLibrary";
    /// <summary>
    /// The add vr screenshot to library
    /// </summary>
    public static readonly StringName AddVRScreenshotToLibrary = "addVRScreenshotToLibrary";
    /// <summary>
    /// The hook screenshots
    /// </summary>
    public static readonly StringName HookScreenshots = "hookScreenshots";
    /// <summary>
    /// The is screenshots hooked
    /// </summary>
    public static readonly StringName IsScreenshotsHooked = "isScreenshotsHooked";
    /// <summary>
    /// The set location
    /// </summary>
    public static readonly StringName SetLocation = "setLocation";
    /// <summary>
    /// The tag published file
    /// </summary>
    public static readonly StringName TagPublishedFile = "tagPublishedFile";
    /// <summary>
    /// The tag user
    /// </summary>
    public static readonly StringName TagUser = "tagUser";
    /// <summary>
    /// The trigger screenshot
    /// </summary>
    public static readonly StringName TriggerScreenshot = "triggerScreenshot";
    /// <summary>
    /// The write screenshot
    /// </summary>
    public static readonly StringName WriteScreenshot = "writeScreenshot";
    /// <summary>
    /// The add app dependency
    /// </summary>
    public static readonly StringName AddAppDependency = "addAppDependency";
    /// <summary>
    /// The add content descriptor
    /// </summary>
    public static readonly StringName AddContentDescriptor = "addContentDescriptor";
    /// <summary>
    /// The add dependency
    /// </summary>
    public static readonly StringName AddDependency = "addDependency";
    /// <summary>
    /// The add excluded tag
    /// </summary>
    public static readonly StringName AddExcludedTag = "addExcludedTag";
    /// <summary>
    /// The add item key value tag
    /// </summary>
    public static readonly StringName AddItemKeyValueTag = "addItemKeyValueTag";
    /// <summary>
    /// The add item preview file
    /// </summary>
    public static readonly StringName AddItemPreviewFile = "addItemPreviewFile";
    /// <summary>
    /// The add item preview video
    /// </summary>
    public static readonly StringName AddItemPreviewVideo = "addItemPreviewVideo";
    /// <summary>
    /// The add item to favorites
    /// </summary>
    public static readonly StringName AddItemToFavorites = "addItemToFavorites";
    /// <summary>
    /// The add required key value tag
    /// </summary>
    public static readonly StringName AddRequiredKeyValueTag = "addRequiredKeyValueTag";
    /// <summary>
    /// The add required tag
    /// </summary>
    public static readonly StringName AddRequiredTag = "addRequiredTag";
    /// <summary>
    /// The add required tag group
    /// </summary>
    public static readonly StringName AddRequiredTagGroup = "addRequiredTagGroup";
    /// <summary>
    /// The init workshop for game server
    /// </summary>
    public static readonly StringName InitWorkshopForGameServer = "initWorkshopForGameServer";
    /// <summary>
    /// The create item
    /// </summary>
    public static readonly StringName CreateItem = "createItem";
    /// <summary>
    /// The create query all ugc request
    /// </summary>
    public static readonly StringName CreateQueryAllUGCRequest = "createQueryAllUGCRequest";
    /// <summary>
    /// The create query ugc details request
    /// </summary>
    public static readonly StringName CreateQueryUGCDetailsRequest = "createQueryUGCDetailsRequest";
    /// <summary>
    /// The create query user ugc request
    /// </summary>
    public static readonly StringName CreateQueryUserUGCRequest = "createQueryUserUGCRequest";
    /// <summary>
    /// The delete item
    /// </summary>
    public static readonly StringName DeleteItem = "deleteItem";
    /// <summary>
    /// The download item
    /// </summary>
    public static readonly StringName DownloadItem = "downloadItem";
    /// <summary>
    /// The get item download info
    /// </summary>
    public static readonly StringName GetItemDownloadInfo = "getItemDownloadInfo";
    /// <summary>
    /// The get item install info
    /// </summary>
    public static readonly StringName GetItemInstallInfo = "getItemInstallInfo";
    /// <summary>
    /// The get item state
    /// </summary>
    public static readonly StringName GetItemState = "getItemState";
    /// <summary>
    /// The get item update progress
    /// </summary>
    public static readonly StringName GetItemUpdateProgress = "getItemUpdateProgress";
    /// <summary>
    /// The get num subscribed items
    /// </summary>
    public static readonly StringName GetNumSubscribedItems = "getNumSubscribedItems";
    /// <summary>
    /// The get query ugc additional preview
    /// </summary>
    public static readonly StringName GetQueryUGCAdditionalPreview = "getQueryUGCAdditionalPreview";
    /// <summary>
    /// The get query ugc children
    /// </summary>
    public static readonly StringName GetQueryUGCChildren = "getQueryUGCChildren";
    /// <summary>
    /// The get query ugc content descriptors
    /// </summary>
    public static readonly StringName GetQueryUGCContentDescriptors = "getQueryUGCContentDescriptors";
    /// <summary>
    /// The get query ugc key value tag
    /// </summary>
    public static readonly StringName GetQueryUGCKeyValueTag = "getQueryUGCKeyValueTag";
    /// <summary>
    /// The get query ugc metadata
    /// </summary>
    public static readonly StringName GetQueryUGCMetadata = "getQueryUGCMetadata";
    /// <summary>
    /// The get query ugc num additional previews
    /// </summary>
    public static readonly StringName GetQueryUGCNumAdditionalPreviews = "getQueryUGCNumAdditionalPreviews";
    /// <summary>
    /// The get query ugc num key value tags
    /// </summary>
    public static readonly StringName GetQueryUGCNumKeyValueTags = "getQueryUGCNumKeyValueTags";
    /// <summary>
    /// The get query ugc num tags
    /// </summary>
    public static readonly StringName GetQueryUGCNumTags = "getQueryUGCNumTags";
    /// <summary>
    /// The get query ugc preview url
    /// </summary>
    public static readonly StringName GetQueryUGCPreviewURL = "getQueryUGCPreviewURL";
    /// <summary>
    /// The get query ugc result
    /// </summary>
    public static readonly StringName GetQueryUGCResult = "getQueryUGCResult";
    /// <summary>
    /// The get query ugc statistic
    /// </summary>
    public static readonly StringName GetQueryUGCStatistic = "getQueryUGCStatistic";
    /// <summary>
    /// The get query ugc tag
    /// </summary>
    public static readonly StringName GetQueryUGCTag = "getQueryUGCTag";
    /// <summary>
    /// The get query ugc tag display name
    /// </summary>
    public static readonly StringName GetQueryUGCTagDisplayName = "getQueryUGCTagDisplayName";
    /// <summary>
    /// The get subscribed items
    /// </summary>
    public static readonly StringName GetSubscribedItems = "getSubscribedItems";
    /// <summary>
    /// The get user content descriptor preferences
    /// </summary>
    public static readonly StringName GetUserContentDescriptorPreferences = "getUserContentDescriptorPreferences";
    /// <summary>
    /// The get user item vote
    /// </summary>
    public static readonly StringName GetUserItemVote = "getUserItemVote";
    /// <summary>
    /// The release query ugc request
    /// </summary>
    public static readonly StringName ReleaseQueryUGCRequest = "releaseQueryUGCRequest";
    /// <summary>
    /// The remove app dependency
    /// </summary>
    public static readonly StringName RemoveAppDependency = "removeAppDependency";
    /// <summary>
    /// The remove content descriptor
    /// </summary>
    public static readonly StringName RemoveContentDescriptor = "removeContentDescriptor";
    /// <summary>
    /// The remove dependency
    /// </summary>
    public static readonly StringName RemoveDependency = "removeDependency";
    /// <summary>
    /// The remove item from favorites
    /// </summary>
    public static readonly StringName RemoveItemFromFavorites = "removeItemFromFavorites";
    /// <summary>
    /// The remove item key value tags
    /// </summary>
    public static readonly StringName RemoveItemKeyValueTags = "removeItemKeyValueTags";
    /// <summary>
    /// The remove item preview
    /// </summary>
    public static readonly StringName RemoveItemPreview = "removeItemPreview";
    /// <summary>
    /// The send query ugc request
    /// </summary>
    public static readonly StringName SendQueryUGCRequest = "sendQueryUGCRequest";
    /// <summary>
    /// The set allow cached response
    /// </summary>
    public static readonly StringName SetAllowCachedResponse = "setAllowCachedResponse";
    /// <summary>
    /// The set cloud file name filter
    /// </summary>
    public static readonly StringName SetCloudFileNameFilter = "setCloudFileNameFilter";
    /// <summary>
    /// The set item content
    /// </summary>
    public static readonly StringName SetItemContent = "setItemContent";
    /// <summary>
    /// The set item description
    /// </summary>
    public static readonly StringName SetItemDescription = "setItemDescription";
    /// <summary>
    /// The set item metadata
    /// </summary>
    public static readonly StringName SetItemMetadata = "setItemMetadata";
    /// <summary>
    /// The set item preview
    /// </summary>
    public static readonly StringName SetItemPreview = "setItemPreview";
    /// <summary>
    /// The set item tags
    /// </summary>
    public static readonly StringName SetItemTags = "setItemTags";
    /// <summary>
    /// The set item title
    /// </summary>
    public static readonly StringName SetItemTitle = "setItemTitle";
    /// <summary>
    /// The set item update language
    /// </summary>
    public static readonly StringName SetItemUpdateLanguage = "setItemUpdateLanguage";
    /// <summary>
    /// The set item visibility
    /// </summary>
    public static readonly StringName SetItemVisibility = "setItemVisibility";
    /// <summary>
    /// The set language
    /// </summary>
    public static readonly StringName SetLanguage = "setLanguage";
    /// <summary>
    /// The set match any tag
    /// </summary>
    public static readonly StringName SetMatchAnyTag = "setMatchAnyTag";
    /// <summary>
    /// The set ranked by trend days
    /// </summary>
    public static readonly StringName SetRankedByTrendDays = "setRankedByTrendDays";
    /// <summary>
    /// The set return additional previews
    /// </summary>
    public static readonly StringName SetReturnAdditionalPreviews = "setReturnAdditionalPreviews";
    /// <summary>
    /// The set return children
    /// </summary>
    public static readonly StringName SetReturnChildren = "setReturnChildren";
    /// <summary>
    /// The set return key value tags
    /// </summary>
    public static readonly StringName SetReturnKeyValueTags = "setReturnKeyValueTags";
    /// <summary>
    /// The set return long description
    /// </summary>
    public static readonly StringName SetReturnLongDescription = "setReturnLongDescription";
    /// <summary>
    /// The set return metadata
    /// </summary>
    public static readonly StringName SetReturnMetadata = "setReturnMetadata";
    /// <summary>
    /// The set return only ds
    /// </summary>
    public static readonly StringName SetReturnOnlyIDs = "setReturnOnlyIDs";
    /// <summary>
    /// The set return playtime stats
    /// </summary>
    public static readonly StringName SetReturnPlaytimeStats = "setReturnPlaytimeStats";
    /// <summary>
    /// The set return total only
    /// </summary>
    public static readonly StringName SetReturnTotalOnly = "setReturnTotalOnly";
    /// <summary>
    /// The set search text
    /// </summary>
    public static readonly StringName SetSearchText = "setSearchText";
    /// <summary>
    /// The set user item vote
    /// </summary>
    public static readonly StringName SetUserItemVote = "setUserItemVote";
    /// <summary>
    /// The start item update
    /// </summary>
    public static readonly StringName StartItemUpdate = "startItemUpdate";
    /// <summary>
    /// The start playtime tracking
    /// </summary>
    public static readonly StringName StartPlaytimeTracking = "startPlaytimeTracking";
    /// <summary>
    /// The stop playtime tracking
    /// </summary>
    public static readonly StringName StopPlaytimeTracking = "stopPlaytimeTracking";
    /// <summary>
    /// The stop playtime tracking for all items
    /// </summary>
    public static readonly StringName StopPlaytimeTrackingForAllItems = "stopPlaytimeTrackingForAllItems";
    /// <summary>
    /// The get app dependencies
    /// </summary>
    public static readonly StringName GetAppDependencies = "getAppDependencies";
    /// <summary>
    /// The submit item update
    /// </summary>
    public static readonly StringName SubmitItemUpdate = "submitItemUpdate";
    /// <summary>
    /// The subscribe item
    /// </summary>
    public static readonly StringName SubscribeItem = "subscribeItem";
    /// <summary>
    /// The suspend downloads
    /// </summary>
    public static readonly StringName SuspendDownloads = "suspendDownloads";
    /// <summary>
    /// The unsubscribe item
    /// </summary>
    public static readonly StringName UnsubscribeItem = "unsubscribeItem";
    /// <summary>
    /// The update item preview file
    /// </summary>
    public static readonly StringName UpdateItemPreviewFile = "updateItemPreviewFile";
    /// <summary>
    /// The update item preview video
    /// </summary>
    public static readonly StringName UpdateItemPreviewVideo = "updateItemPreviewVideo";
    /// <summary>
    /// The show workshop eula
    /// </summary>
    public static readonly StringName ShowWorkshopEULA = "showWorkshopEULA";
    /// <summary>
    /// The get workshop eula status
    /// </summary>
    public static readonly StringName GetWorkshopEULAStatus = "getWorkshopEULAStatus";
    /// <summary>
    /// The set time created date range
    /// </summary>
    public static readonly StringName SetTimeCreatedDateRange = "setTimeCreatedDateRange";
    /// <summary>
    /// The set time updated date range
    /// </summary>
    public static readonly StringName SetTimeUpdatedDateRange = "setTimeUpdatedDateRange";
    /// <summary>
    /// The advertise game
    /// </summary>
    public static readonly StringName AdvertiseGame = "advertiseGame";
    /// <summary>
    /// The begin auth session
    /// </summary>
    public static readonly StringName BeginAuthSession = "beginAuthSession";
    /// <summary>
    /// The cancel auth ticket
    /// </summary>
    public static readonly StringName CancelAuthTicket = "cancelAuthTicket";
    /// <summary>
    /// The decompress voice
    /// </summary>
    public static readonly StringName DecompressVoice = "decompressVoice";
    /// <summary>
    /// The end auth session
    /// </summary>
    public static readonly StringName EndAuthSession = "endAuthSession";
    /// <summary>
    /// The get auth session ticket
    /// </summary>
    public static readonly StringName GetAuthSessionTicket = "getAuthSessionTicket";
    /// <summary>
    /// The get auth ticket for web api
    /// </summary>
    public static readonly StringName GetAuthTicketForWebApi = "getAuthTicketForWebApi";
    /// <summary>
    /// The get available voice
    /// </summary>
    public static readonly StringName GetAvailableVoice = "getAvailableVoice";
    /// <summary>
    /// The get duration control
    /// </summary>
    public static readonly StringName GetDurationControl = "getDurationControl";
    /// <summary>
    /// The get encrypted app ticket
    /// </summary>
    public static readonly StringName GetEncryptedAppTicket = "getEncryptedAppTicket";
    /// <summary>
    /// The get game badge level
    /// </summary>
    public static readonly StringName GetGameBadgeLevel = "getGameBadgeLevel";
    /// <summary>
    /// The get player steam level
    /// </summary>
    public static readonly StringName GetPlayerSteamLevel = "getPlayerSteamLevel";
    /// <summary>
    /// The get steam id
    /// </summary>
    public static readonly StringName GetSteamID = "getSteamID";
    /// <summary>
    /// The get voice
    /// </summary>
    public static readonly StringName GetVoice = "getVoice";
    /// <summary>
    /// The get voice optimal sample rate
    /// </summary>
    public static readonly StringName GetVoiceOptimalSampleRate = "getVoiceOptimalSampleRate";
    /// <summary>
    /// The initiate game connection
    /// </summary>
    public static readonly StringName InitiateGameConnection = "initiateGameConnection";
    /// <summary>
    /// The is behind nat
    /// </summary>
    public static readonly StringName IsBehindNAT = "isBehindNAT";
    /// <summary>
    /// The is phone identifying
    /// </summary>
    public static readonly StringName IsPhoneIdentifying = "isPhoneIdentifying";
    /// <summary>
    /// The is phone requiring verification
    /// </summary>
    public static readonly StringName IsPhoneRequiringVerification = "isPhoneRequiringVerification";
    /// <summary>
    /// The is phone verified
    /// </summary>
    public static readonly StringName IsPhoneVerified = "isPhoneVerified";
    /// <summary>
    /// The is two factor enabled
    /// </summary>
    public static readonly StringName IsTwoFactorEnabled = "isTwoFactorEnabled";
    /// <summary>
    /// The logged on
    /// </summary>
    public static readonly StringName LoggedOn = "loggedOn";
    /// <summary>
    /// The request encrypted app ticket
    /// </summary>
    public static readonly StringName RequestEncryptedAppTicket = "requestEncryptedAppTicket";
    /// <summary>
    /// The request store auth url
    /// </summary>
    public static readonly StringName RequestStoreAuthURL = "requestStoreAuthURL";
    /// <summary>
    /// The start voice recording
    /// </summary>
    public static readonly StringName StartVoiceRecording = "startVoiceRecording";
    /// <summary>
    /// The set duration control online state
    /// </summary>
    public static readonly StringName SetDurationControlOnlineState = "setDurationControlOnlineState";
    /// <summary>
    /// The stop voice recording
    /// </summary>
    public static readonly StringName StopVoiceRecording = "stopVoiceRecording";
    /// <summary>
    /// The terminate game connection
    /// </summary>
    public static readonly StringName TerminateGameConnection = "terminateGameConnection";
    /// <summary>
    /// The user has license for app
    /// </summary>
    public static readonly StringName UserHasLicenseForApp = "userHasLicenseForApp";
    /// <summary>
    /// The attach leaderboard ugc
    /// </summary>
    public static readonly StringName AttachLeaderboardUGC = "attachLeaderboardUGC";
    /// <summary>
    /// The clear achievement
    /// </summary>
    public static readonly StringName ClearAchievement = "clearAchievement";
    /// <summary>
    /// The download leaderboard entries
    /// </summary>
    public static readonly StringName DownloadLeaderboardEntries = "downloadLeaderboardEntries";
    /// <summary>
    /// The download leaderboard entries for users
    /// </summary>
    public static readonly StringName DownloadLeaderboardEntriesForUsers = "downloadLeaderboardEntriesForUsers";
    /// <summary>
    /// The find leaderboard
    /// </summary>
    public static readonly StringName FindLeaderboard = "findLeaderboard";
    /// <summary>
    /// The find or create leaderboard
    /// </summary>
    public static readonly StringName FindOrCreateLeaderboard = "findOrCreateLeaderboard";
    /// <summary>
    /// The get achievement
    /// </summary>
    public static readonly StringName GetAchievement = "getAchievement";
    /// <summary>
    /// The get achievement achieved percent
    /// </summary>
    public static readonly StringName GetAchievementAchievedPercent = "getAchievementAchievedPercent";
    /// <summary>
    /// The get achievement and unlock time
    /// </summary>
    public static readonly StringName GetAchievementAndUnlockTime = "getAchievementAndUnlockTime";
    /// <summary>
    /// The get achievement display attribute
    /// </summary>
    public static readonly StringName GetAchievementDisplayAttribute = "getAchievementDisplayAttribute";
    /// <summary>
    /// The get achievement icon
    /// </summary>
    public static readonly StringName GetAchievementIcon = "getAchievementIcon";
    /// <summary>
    /// The get achievement name
    /// </summary>
    public static readonly StringName GetAchievementName = "getAchievementName";
    /// <summary>
    /// The get achievement progress limits int
    /// </summary>
    public static readonly StringName GetAchievementProgressLimitsInt = "getAchievementProgressLimitsInt";
    /// <summary>
    /// The get achievement progress limits float
    /// </summary>
    public static readonly StringName GetAchievementProgressLimitsFloat = "getAchievementProgressLimitsFloat";
    /// <summary>
    /// The get global stat int
    /// </summary>
    public static readonly StringName GetGlobalStatInt = "getGlobalStatInt";
    /// <summary>
    /// The get global stat float
    /// </summary>
    public static readonly StringName GetGlobalStatFloat = "getGlobalStatFloat";
    /// <summary>
    /// The get global stat int history
    /// </summary>
    public static readonly StringName GetGlobalStatIntHistory = "getGlobalStatIntHistory";
    /// <summary>
    /// The get global stat float history
    /// </summary>
    public static readonly StringName GetGlobalStatFloatHistory = "getGlobalStatFloatHistory";
    /// <summary>
    /// The get leaderboard display type
    /// </summary>
    public static readonly StringName GetLeaderboardDisplayType = "getLeaderboardDisplayType";
    /// <summary>
    /// The get leaderboard entry count
    /// </summary>
    public static readonly StringName GetLeaderboardEntryCount = "getLeaderboardEntryCount";
    /// <summary>
    /// The get leaderboard name
    /// </summary>
    public static readonly StringName GetLeaderboardName = "getLeaderboardName";
    /// <summary>
    /// The get leaderboard sort method
    /// </summary>
    public static readonly StringName GetLeaderboardSortMethod = "getLeaderboardSortMethod";
    /// <summary>
    /// The get most achieved achievement info
    /// </summary>
    public static readonly StringName GetMostAchievedAchievementInfo = "getMostAchievedAchievementInfo";
    /// <summary>
    /// The get next most achieved achievement info
    /// </summary>
    public static readonly StringName GetNextMostAchievedAchievementInfo = "getNextMostAchievedAchievementInfo";
    /// <summary>
    /// The get num achievements
    /// </summary>
    public static readonly StringName GetNumAchievements = "getNumAchievements";
    /// <summary>
    /// The get number of current players
    /// </summary>
    public static readonly StringName GetNumberOfCurrentPlayers = "getNumberOfCurrentPlayers";
    /// <summary>
    /// The get stat float
    /// </summary>
    public static readonly StringName GetStatFloat = "getStatFloat";
    /// <summary>
    /// The get stat int
    /// </summary>
    public static readonly StringName GetStatInt = "getStatInt";
    /// <summary>
    /// The get user achievement
    /// </summary>
    public static readonly StringName GetUserAchievement = "getUserAchievement";
    /// <summary>
    /// The get user achievement and unlock time
    /// </summary>
    public static readonly StringName GetUserAchievementAndUnlockTime = "getUserAchievementAndUnlockTime";
    /// <summary>
    /// The get user stat float
    /// </summary>
    public static readonly StringName GetUserStatFloat = "getUserStatFloat";
    /// <summary>
    /// The get user stat int
    /// </summary>
    public static readonly StringName GetUserStatInt = "getUserStatInt";
    /// <summary>
    /// The indicate achievement progress
    /// </summary>
    public static readonly StringName IndicateAchievementProgress = "indicateAchievementProgress";
    /// <summary>
    /// The request current stats
    /// </summary>
    public static readonly StringName RequestCurrentStats = "requestCurrentStats";
    /// <summary>
    /// The request global achievement percentages
    /// </summary>
    public static readonly StringName RequestGlobalAchievementPercentages = "requestGlobalAchievementPercentages";
    /// <summary>
    /// The request global stats
    /// </summary>
    public static readonly StringName RequestGlobalStats = "requestGlobalStats";
    /// <summary>
    /// The request user stats
    /// </summary>
    public static readonly StringName RequestUserStats = "requestUserStats";
    /// <summary>
    /// The reset all stats
    /// </summary>
    public static readonly StringName ResetAllStats = "resetAllStats";
    /// <summary>
    /// The set achievement
    /// </summary>
    public static readonly StringName SetAchievement = "setAchievement";
    /// <summary>
    /// The set leaderboard details max
    /// </summary>
    public static readonly StringName SetLeaderboardDetailsMax = "setLeaderboardDetailsMax";
    /// <summary>
    /// The set stat float
    /// </summary>
    public static readonly StringName SetStatFloat = "setStatFloat";
    /// <summary>
    /// The set stat int
    /// </summary>
    public static readonly StringName SetStatInt = "setStatInt";
    /// <summary>
    /// The store stats
    /// </summary>
    public static readonly StringName StoreStats = "storeStats";
    /// <summary>
    /// The update avg rate stat
    /// </summary>
    public static readonly StringName UpdateAvgRateStat = "updateAvgRateStat";
    /// <summary>
    /// The upload leaderboard score
    /// </summary>
    public static readonly StringName UploadLeaderboardScore = "uploadLeaderboardScore";
    /// <summary>
    /// The get leaderboard entries
    /// </summary>
    public static readonly StringName GetLeaderboardEntries = "getLeaderboardEntries";
    /// <summary>
    /// The filter text
    /// </summary>
    public static readonly StringName FilterText = "filterText";
    /// <summary>
    /// The get api call failure reason
    /// </summary>
    public static readonly StringName GetAPICallFailureReason = "getAPICallFailureReason";
    /// <summary>
    /// The get app id
    /// </summary>
    public static readonly StringName GetAppID = "getAppID";
    /// <summary>
    /// The get current battery power
    /// </summary>
    public static readonly StringName GetCurrentBatteryPower = "getCurrentBatteryPower";
    /// <summary>
    /// The get image rgba
    /// </summary>
    public static readonly StringName GetImageRGBA = "getImageRGBA";
    /// <summary>
    /// The get image size
    /// </summary>
    public static readonly StringName GetImageSize = "getImageSize";
    /// <summary>
    /// The get ipc call count
    /// </summary>
    public static readonly StringName GetIPCCallCount = "getIPCCallCount";
    /// <summary>
    /// The get ip country
    /// </summary>
    public static readonly StringName GetIPCountry = "getIPCountry";
    /// <summary>
    /// The get seconds since app active
    /// </summary>
    public static readonly StringName GetSecondsSinceAppActive = "getSecondsSinceAppActive";
    /// <summary>
    /// The get seconds since computer active
    /// </summary>
    public static readonly StringName GetSecondsSinceComputerActive = "getSecondsSinceComputerActive";
    /// <summary>
    /// The get server real time
    /// </summary>
    public static readonly StringName GetServerRealTime = "getServerRealTime";
    /// <summary>
    /// The get steam ui language
    /// </summary>
    public static readonly StringName GetSteamUILanguage = "getSteamUILanguage";
    /// <summary>
    /// The init filter text
    /// </summary>
    public static readonly StringName InitFilterText = "initFilterText";
    /// <summary>
    /// The is api call completed
    /// </summary>
    public static readonly StringName IsAPICallCompleted = "isAPICallCompleted";
    /// <summary>
    /// The is overlay enabled
    /// </summary>
    public static readonly StringName IsOverlayEnabled = "isOverlayEnabled";
    /// <summary>
    /// The is steam china launcher
    /// </summary>
    public static readonly StringName IsSteamChinaLauncher = "isSteamChinaLauncher";
    /// <summary>
    /// The is steam in big picture mode
    /// </summary>
    public static readonly StringName IsSteamInBigPictureMode = "isSteamInBigPictureMode";
    /// <summary>
    /// The is steam running in vr
    /// </summary>
    public static readonly StringName IsSteamRunningInVR = "isSteamRunningInVR";
    /// <summary>
    /// The is vr headset streaming enabled
    /// </summary>
    public static readonly StringName IsVRHeadsetStreamingEnabled = "isVRHeadsetStreamingEnabled";
    /// <summary>
    /// The overlay needs present
    /// </summary>
    public static readonly StringName OverlayNeedsPresent = "overlayNeedsPresent";
    /// <summary>
    /// The set overlay notification inset
    /// </summary>
    public static readonly StringName SetOverlayNotificationInset = "setOverlayNotificationInset";
    /// <summary>
    /// The set overlay notification position
    /// </summary>
    public static readonly StringName SetOverlayNotificationPosition = "setOverlayNotificationPosition";
    /// <summary>
    /// The set vr headset streaming enabled
    /// </summary>
    public static readonly StringName SetVRHeadsetStreamingEnabled = "setVRHeadsetStreamingEnabled";
    /// <summary>
    /// The show gamepad text input
    /// </summary>
    public static readonly StringName ShowGamepadTextInput = "showGamepadTextInput";
    /// <summary>
    /// The show floating gamepad text input
    /// </summary>
    public static readonly StringName ShowFloatingGamepadTextInput = "showFloatingGamepadTextInput";
    /// <summary>
    /// The set game launcher mode
    /// </summary>
    public static readonly StringName SetGameLauncherMode = "setGameLauncherMode";
    /// <summary>
    /// The start vr dashboard
    /// </summary>
    public static readonly StringName StartVRDashboard = "startVRDashboard";
    /// <summary>
    /// The is steam running on steam deck
    /// </summary>
    public static readonly StringName IsSteamRunningOnSteamDeck = "isSteamRunningOnSteamDeck";
    /// <summary>
    /// The dismiss floating gamepad text input
    /// </summary>
    public static readonly StringName DismissFloatingGamepadTextInput = "dismissFloatingGamepadTextInput";
    /// <summary>
    /// The get opf settings
    /// </summary>
    public static readonly StringName GetOPFSettings = "getOPFSettings";
    /// <summary>
    /// The get opf string for app
    /// </summary>
    public static readonly StringName GetOPFStringForApp = "getOPFStringForApp";
    /// <summary>
    /// The get video url
    /// </summary>
    public static readonly StringName GetVideoURL = "getVideoURL";
    /// <summary>
    /// The is broadcasting
    /// </summary>
    public static readonly StringName IsBroadcasting = "isBroadcasting";
}