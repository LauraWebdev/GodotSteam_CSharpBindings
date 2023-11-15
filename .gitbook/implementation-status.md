# Implementation Status

#### [Main](../docs/Status.md#main) <a href="#user-content-main" id="user-content-main"></a>

[**Functions**](../docs/Status.md#functions)

* [x] &#x20;isSteamRunning
* [x] &#x20;restartAppIfNecessary
* [x] &#x20;run\_callbacks
* [x] &#x20;steamInit
* [x] &#x20;steamInitEx

[**Signals**](../docs/Status.md#signals)

* [x] &#x20;steamworks\_error

[**Enums**](../docs/Status.md#enums)

* [x] &#x20;AccountType
* [ ] &#x20;AppOwnershipFlags (missing in code)
* [ ] &#x20;AppReleaseState (missing in code)
* [ ] &#x20;AppType (mssing in code)
* [x] &#x20;AuthSessionResponse
* [x] &#x20;BeginAuthSessionResult
* [x] &#x20;BroadcastUploadResult
* [x] &#x20;ChatEntryType
* [x] &#x20;ChatRoomEnterResponse
* [x] &#x20;ChatSteamIDInstanceFlags
* [x] &#x20;DenyReason
* [x] &#x20;GameIDType
* [ ] &#x20;LaunchOptionType (missing in code)
* [x] &#x20;NotificationPosition
* [x] &#x20;Result
* [x] &#x20;SteamAPIInitResult
* [x] &#x20;Universe
* [x] &#x20;UserHasLicenseForAppResult
* [x] &#x20;VoiceResult
* [ ] &#x20;VRHMDType (missing in code)

#### [App Lists](../docs/Status.md#app-lists) <a href="#user-content-app-lists" id="user-content-app-lists"></a>

[**Functions**](../docs/Status.md#functions-1)

* [x] &#x20;getAppListBuildId
* [x] &#x20;getAppListInstallDir
* [x] &#x20;getAppName
* [x] &#x20;getInstalledApps
* [x] &#x20;getNumInstalledApps

[**Signals**](../docs/Status.md#signals-1)

* [x] &#x20;app\_installed
* [x] &#x20;app\_uninstalled

#### [Apps](../docs/Status.md#apps) <a href="#user-content-apps" id="user-content-apps"></a>

[**Functions**](../docs/Status.md#functions-2)

* [x] &#x20;getAppBuildId
* [x] &#x20;getAppInstallDir
* [x] &#x20;getAppOwner
* [x] &#x20;getAvailableGameLanguages
* [x] &#x20;getCurrentBetaName
* [x] &#x20;getCurrentGameLanguage
* [x] &#x20;getDLCCount
* [x] &#x20;getDLCDataByIndex
* [x] &#x20;getDLCDownloadProgress
* [x] &#x20;getEarliestPurchaseUnixTime
* [x] &#x20;getFileDetails
* [x] &#x20;getInstalledDepots
* [x] &#x20;getLaunchCommandLine
* [x] &#x20;getLaunchQueryParam
* [ ] &#x20;getLeaderboardDisplayType (missing in code)
* [x] &#x20;installDLC
* [x] &#x20;isAppInstalled
* [x] &#x20;isDLCInstalled
* [x] &#x20;isLowViolence
* [x] &#x20;isSubscribed
* [x] &#x20;isSubscribedApp
* [x] &#x20;isSubscribedFromFamilySharing
* [x] &#x20;isSubscribedFromFreeWeekend
* [x] &#x20;isTimedTrial
* [x] &#x20;isVACBanned
* [x] &#x20;markContentCorrupt
* [x] &#x20;setDLCContext
* [x] &#x20;uninstallDLC

[**Signals**](../docs/Status.md#signals-2)

* [x] &#x20;dlc\_installed
* [x] &#x20;file\_details\_result
* [x] &#x20;new\_launch\_url\_parameters
* [x] &#x20;timed\_trial\_status

[**Enums**](../docs/Status.md#enums-1)

* [ ] &#x20;RegisterActivationCodeResult

#### [Friends](../docs/Status.md#friends) <a href="#user-content-friends" id="user-content-friends"></a>

[**Functions**](../docs/Status.md#functions-3)

* [x] &#x20;activateGameOverlay
* [x] &#x20;activateGameOverlayInviteDialog
* [x] &#x20;activateGameOverlayInviteDialogConnectString
* [x] &#x20;activateGameOverlayToStore
* [x] &#x20;activateGameOverlayToUser
* [x] &#x20;activateGameOverlayToWebPage
* [x] &#x20;clearRichPresence
* [x] &#x20;closeClanChatWindowInSteam
* [x] &#x20;downloadClanActivityCounts
* [x] &#x20;enumerateFollowingList
* [x] &#x20;getChatMemberByIndex
* [x] &#x20;getClanActivityCounts
* [x] &#x20;getClanByIndex
* [x] &#x20;getClanChatMemberCount
* [x] &#x20;getClanChatMessage
* [x] &#x20;getClanCount
* [x] &#x20;getClanName
* [x] &#x20;getClanOfficerByIndex
* [x] &#x20;getClanOfficerCount
* [x] &#x20;getClanOwner
* [x] &#x20;getClanTag
* [x] &#x20;getCoplayFriend
* [x] &#x20;getCoplayFriendCount
* [x] &#x20;getFollowerCount
* [x] &#x20;getFriendByIndex
* [x] &#x20;getFriendCoplayGame
* [x] &#x20;getFriendCoplayTime
* [x] &#x20;getFriendCount
* [x] &#x20;getFriendCountFromSource
* [x] &#x20;getFriendFromSourceByIndex
* [x] &#x20;getFriendGamePlayed
* [x] &#x20;getFriendMessage
* [x] &#x20;getFriendPersonaName
* [x] &#x20;getFriendPersonaNameHistory
* [x] &#x20;getFriendPersonaState
* [x] &#x20;getFriendRelationship
* [x] &#x20;getFriendRichPresence
* [x] &#x20;getFriendRichPresenceKeyCount
* [x] &#x20;getFriendRichPresenceKeyByIndex
* [x] &#x20;getFriendsGroupCount
* [x] &#x20;getFriendsGroupIDByIndex
* [x] &#x20;getFriendsGroupMembersCount
* [x] &#x20;getFriendsGroupMembersList
* [x] &#x20;getFriendsGroupName
* [x] &#x20;getFriendSteamLevel
* [x] &#x20;getLargeFriendAvatar
* [x] &#x20;getMediumFriendAvatar
* [x] &#x20;getPersonaName
* [x] &#x20;getPersonaState
* [x] &#x20;getPlayerAvatar
* [x] &#x20;getPlayerNickname
* [x] &#x20;getProfileItemPropertyString
* [x] &#x20;getProfileItemPropertyInt
* [x] &#x20;getRecentPlayers
* [x] &#x20;getSmallFriendAvatar
* [x] &#x20;getUserFriendsGroups
* [x] &#x20;getUserRestrictions
* [x] &#x20;getUserSteamFriends
* [x] &#x20;getUserSteamGroups
* [x] &#x20;hasEquippedProfileItem
* [x] &#x20;hasFriend
* [x] &#x20;inviteUserToGame
* [x] &#x20;isClanChatAdmin
* [x] &#x20;isClanPublic
* [x] &#x20;isClanOfficialGameGroup
* [x] &#x20;isClanChatWindowOpenInSteam
* [x] &#x20;isFollowing
* [x] &#x20;isUserInSource
* [x] &#x20;joinClanChatRoom
* [x] &#x20;leaveClanChatRoom
* [x] &#x20;openClanChatWindowInSteam
* [x] &#x20;registerProtocolInOverlayBrowser
* [x] &#x20;replyToFriendMessage
* [x] &#x20;requestClanOfficerList
* [x] &#x20;requestFriendRichPresence
* [x] &#x20;requestUserInformation
* [x] &#x20;sendClanChatMessage
* [x] &#x20;setInGameVoiceSpeaking
* [x] &#x20;setListenForFriendsMessages
* [x] &#x20;setPersonaName
* [x] &#x20;setPlayedWith
* [x] &#x20;setRichPresence

[**Signals**](../docs/Status.md#signals-3)

* [x] &#x20;avatar\_loaded
* [x] &#x20;avatar\_image\_loaded
* [x] &#x20;change\_server\_requested
* [x] &#x20;clan\_activity\_downloaded
* [x] &#x20;connected\_chat\_join
* [x] &#x20;connected\_chat\_leave
* [x] &#x20;connected\_clan\_chat\_message
* [x] &#x20;connected\_friend\_chat\_message
* [x] &#x20;enumerate\_following\_list
* [x] &#x20;equipped\_profile\_items
* [x] &#x20;equipped\_profile\_items\_changed
* [x] &#x20;friend\_rich\_presence\_update
* [x] &#x20;get\_follower\_count
* [x] &#x20;is\_following
* [x] &#x20;join\_clan\_chat\_complete
* [x] &#x20;join\_game\_requested
* [x] &#x20;join\_requested
* [x] &#x20;name\_changed
* [x] &#x20;overlay\_browser\_protocol
* [x] &#x20;overlay\_toggled
* [x] &#x20;persona\_state\_change
* [x] &#x20;request\_clan\_officer\_list
* [x] &#x20;unread\_chat\_messages\_changed

[**Enums**](../docs/Status.md#enums-2)

* [x] &#x20;AvatarSizes
* [x] &#x20;CommunityProfileItemType
* [x] &#x20;CommunityProfileItemProperty
* [x] &#x20;FriendFlags
* [x] &#x20;FriendRelationship
* [x] &#x20;OverlayToStoreFlag
* [x] &#x20;OverlayToWebPageMode
* [x] &#x20;PersonaChange
* [x] &#x20;PersonaState
* [x] &#x20;UserRestriction

#### [Game Search](../docs/Status.md#game-search) <a href="#user-content-game-search" id="user-content-game-search"></a>

[**Functions**](../docs/Status.md#functions-4)

* [x] &#x20;acceptGame
* [x] &#x20;addGameSearchParams
* [x] &#x20;cancelRequestPlayersForGame
* [x] &#x20;declineGame
* [x] &#x20;endGame
* [x] &#x20;endGameSearch
* [x] &#x20;hostConfirmGameStart
* [x] &#x20;requestPlayersForGame
* [x] &#x20;retrieveConnectionDetails
* [x] &#x20;searchForGameSolo
* [x] &#x20;searchForGameWithLobby
* [x] &#x20;setConnectionDetails
* [x] &#x20;setGameHostParams
* [x] &#x20;submitPlayerResult

[**Signals**](../docs/Status.md#signals-4)

* [x] &#x20;end\_game\_result
* [x] &#x20;request\_players\_for\_game\_final\_result
* [x] &#x20;request\_players\_for\_game\_progress
* [x] &#x20;request\_players\_for\_game\_result
* [x] &#x20;search\_for\_game\_progress
* [x] &#x20;search\_for\_game\_result
* [x] &#x20;submit\_player\_result

[**Enums**](../docs/Status.md#enums-3)

* [ ] &#x20;GameSearchErrorCode
* [x] &#x20;PlayerResult

#### [Game Server](../docs/Status.md#game-server) <a href="#user-content-game-server" id="user-content-game-server"></a>

[**Functions**](../docs/Status.md#functions-5)

* [ ] &#x20;associateWithClan
* [x] &#x20;beginAuthSession
* [ ] &#x20;cancelServerAuthTicket
* [ ] &#x20;clearAllKeyValues
* [ ] &#x20;computeNewPlayerCompatibility
* [x] &#x20;endAuthSession
* [x] &#x20;getAuthSessionTicket
* [ ] &#x20;getNextOutgoingPacket
* [ ] &#x20;getPublicIP
* [x] &#x20;getSteamID
* [ ] &#x20;handleIncomingPacket
* [ ] &#x20;initGameServer
* [x] &#x20;loggedOn
* [ ] &#x20;logOff
* [x] &#x20;logOn
* [ ] &#x20;logOnAnonymous
* [ ] &#x20;requestUserGroupStatus
* [ ] &#x20;secure
* [ ] &#x20;setAdvertiseServerActive
* [ ] &#x20;setBotPlayerCount
* [ ] &#x20;setDedicatedServer
* [ ] &#x20;setGameData
* [ ] &#x20;setGameDescription
* [ ] &#x20;setGameTags
* [ ] &#x20;setHeartbeatInterval
* [ ] &#x20;setKeyValue
* [ ] &#x20;setMapName
* [ ] &#x20;setMaxPlayerCount
* [ ] &#x20;setModDir
* [ ] &#x20;setPasswordProtected
* [ ] &#x20;setProduct
* [ ] &#x20;setRegion
* [ ] &#x20;setServerName
* [ ] &#x20;setSpectatorPort
* [ ] &#x20;setSpectatorServerName
* [ ] &#x20;userHasLicenceForApp
* [ ] &#x20;wasRestartRequested

[**Signals**](../docs/Status.md#signals-5)

* [ ] &#x20;associate\_clan
* [ ] &#x20;client\_approved
* [ ] &#x20;client\_denied
* [ ] &#x20;client\_group\_status
* [ ] &#x20;client\_kick
* [ ] &#x20;player\_compat
* [ ] &#x20;policy\_response
* [ ] &#x20;server\_connect\_failure
* [ ] &#x20;server\_connected
* [ ] &#x20;server\_disconnected

#### [Game Server Stats](../docs/Status.md#game-server-stats) <a href="#user-content-game-server-stats" id="user-content-game-server-stats"></a>

[**Functions**](../docs/Status.md#functions-6)

* [ ] &#x20;clearUserAchievement
* [ ] &#x20;serverGetUserAchievement
* [ ] &#x20;serverGetUserStatFloat
* [ ] &#x20;serverGetUserStatInt
* [ ] &#x20;serverRequestUserStats
* [ ] &#x20;setUserAchievement
* [ ] &#x20;setUserStatFloat
* [ ] &#x20;setUserStatInt
* [ ] &#x20;storeUserStats
* [ ] &#x20;updateUserAvgRateStat

[**Signals**](../docs/Status.md#signals-6)

* [ ] &#x20;stats\_received
* [ ] &#x20;stats\_stored
* [ ] &#x20;stats\_unloaded

#### [HTML Surface](../docs/Status.md#html-surface) <a href="#user-content-html-surface" id="user-content-html-surface"></a>

[**Functions**](../docs/Status.md#functions-7)

* [x] &#x20;addHeader
* [x] &#x20;allowStartRequest
* [x] &#x20;copyToClipboard
* [x] &#x20;createBrowser
* [x] &#x20;executeJavascript
* [x] &#x20;find
* [x] &#x20;getLinkAtPosition
* [x] &#x20;goBack
* [x] &#x20;goForward
* [x] &#x20;htmlInit
* [x] &#x20;jsDialogResponse
* [x] &#x20;keyChar
* [x] &#x20;keyDown
* [x] &#x20;keyUp
* [x] &#x20;loadURL
* [x] &#x20;mouseDoubleClick
* [x] &#x20;mouseDown
* [x] &#x20;mouseMove
* [x] &#x20;mouseUp
* [x] &#x20;mouseWheel
* [x] &#x20;pasteFromClipboard
* [x] &#x20;reload
* [x] &#x20;removeBrowser
* [x] &#x20;setBackgroundMode
* [x] &#x20;setCookie
* [x] &#x20;setHorizontalScroll
* [x] &#x20;setKeyFocus
* [x] &#x20;setPageScaleFactor
* [x] &#x20;setSize
* [x] &#x20;setVerticalScroll
* [x] &#x20;htmlShutdown
* [x] &#x20;stopFind
* [x] &#x20;stopLoad
* [x] &#x20;viewSource

[**Signals**](../docs/Status.md#signals-7)

* [x] &#x20;html\_browser\_ready
* [x] &#x20;html\_can\_go\_backandforward
* [x] &#x20;html\_changed\_title
* [x] &#x20;html\_close\_browser
* [x] &#x20;html\_file\_open\_dialog
* [x] &#x20;html\_finished\_request
* [x] &#x20;html\_hide\_tooltip
* [x] &#x20;html\_horizontal\_scroll
* [x] &#x20;html\_js\_alert
* [x] &#x20;html\_js\_confirm
* [x] &#x20;html\_link\_at\_position
* [x] &#x20;html\_needs\_paint
* [x] &#x20;html\_new\_window
* [x] &#x20;html\_open\_link\_in\_new\_tab
* [x] &#x20;html\_search\_results
* [x] &#x20;html\_set\_cursor
* [x] &#x20;html\_show\_tooltip
* [x] &#x20;html\_start\_request
* [x] &#x20;html\_status\_text
* [x] &#x20;html\_update\_tooltip
* [x] &#x20;html\_url\_changed
* [x] &#x20;html\_vertical\_scroll

[**Enums**](../docs/Status.md#enums-4)

* [x] &#x20;HTMLKeyModifiers
* [x] &#x20;HTMLMouseButton
* [x] &#x20;MouseCursor

#### [HTTP](../docs/Status.md#http) <a href="#user-content-http" id="user-content-http"></a>

[**Functions**](../docs/Status.md#functions-8)

* [x] &#x20;createCookieContainer
* [x] &#x20;createHTTPRequest
* [x] &#x20;deferHTTPRequest
* [x] &#x20;getHTTPDownloadProgressPct
* [x] &#x20;getHTTPRequestWasTimedOut
* [x] &#x20;getHTTPResponseBodyData
* [x] &#x20;getHTTPResponseBodySize
* [x] &#x20;getHTTPResponseHeaderSize
* [x] &#x20;getHTTPResponseHeaderValue
* [x] &#x20;getHTTPStreamingResponseBodyData
* [x] &#x20;prioritizeHTTPRequest
* [x] &#x20;releaseCookieContainer
* [x] &#x20;releaseHTTPRequest
* [x] &#x20;sendHTTPRequest
* [x] &#x20;sendHTTPRequestAndStreamResponse
* [x] &#x20;setHTTPCookie
* [x] &#x20;setHTTPRequestAbsoluteTimeoutMS
* [x] &#x20;setHTTPRequestContextValue
* [x] &#x20;setHTTPRequestCookieContainer
* [x] &#x20;setHTTPRequestGetOrPostParameter
* [x] &#x20;setHTTPRequestHeaderValue
* [x] &#x20;setHTTPRequestNetworkActivityTimeout
* [x] &#x20;setHTTPRequestRawPostBody
* [x] &#x20;setHTTPRequestRequiresVerifiedCertificate
* [x] &#x20;setHTTPRequestUserAgentInfo

[**Signals**](../docs/Status.md#signals-8)

* [x] &#x20;http\_request\_completed
* [x] &#x20;http\_request\_data\_received
* [x] &#x20;http\_request\_headers\_received

[**Enums**](../docs/Status.md#enums-5)

* [x] &#x20;HTTPMethod
* [x] &#x20;HTTPStatusCode

#### [Input](../docs/Status.md#input) <a href="#user-content-input" id="user-content-input"></a>

[**Functions**](../docs/Status.md#functions-9)

* [x] &#x20;activateActionSet
* [x] &#x20;activateActionSetLayer
* [x] &#x20;deactivateActionSetLayer
* [x] &#x20;deactivateAllActionSetLayers
* [x] &#x20;getActiveActionSetLayers
* [x] &#x20;getActionSetHandle
* [x] &#x20;getActionOriginFromXboxOrigin
* [x] &#x20;getAnalogActionData
* [x] &#x20;getAnalogActionHandle
* [x] &#x20;getAnalogActionOrigins
* [x] &#x20;getConnectedControllers
* [x] &#x20;getControllerForGamepadIndex
* [x] &#x20;getCurrentActionSet
* [x] &#x20;getDeviceBindingRevision
* [x] &#x20;getDigitalActionData
* [x] &#x20;getDigitalActionHandle
* [x] &#x20;getDigitalActionOrigins
* [x] &#x20;getGamepadIndexForController
* [x] &#x20;getGlyphForActionOrigin
* [x] &#x20;getInputTypeForHandle
* [x] &#x20;getMotionData
* [x] &#x20;getRemotePlaySessionID
* [x] &#x20;getSessionInputConfigurationSettings
* [x] &#x20;getStringforActionOrigin
* [x] &#x20;inputInit
* [x] &#x20;inputShutdown
* [x] &#x20;runFrame
* [x] &#x20;setDualSenseTriggerEffect
* [x] &#x20;setLEDColor
* [x] &#x20;showBindingPanel
* [x] &#x20;stopAnalogActionMomentum
* [x] &#x20;translateActionOrigin
* [x] &#x20;triggerHapticPulse
* [x] &#x20;triggerRepeatedHapticPulse
* [x] &#x20;triggerVibration
* [x] &#x20;triggerVibrationExtended

[**Signals**](../docs/Status.md#signals-9)

* [x] &#x20;input\_action\_event (missing in docs)
* [x] &#x20;input\_configuration\_loaded
* [x] &#x20;input\_device\_connected
* [x] &#x20;input\_device\_disconnected
* [x] &#x20;input\_gamepad\_slot\_change

[**Enums**](../docs/Status.md#enums-6)

* [x] &#x20;InputActionEventType
* [x] &#x20;InputActionOrigin
* [x] &#x20;InputConfigurationEnableType
* [x] &#x20;InputGlyphSize
* [x] &#x20;InputGlyphStyle
* [x] &#x20;InputLedFlag
* [x] &#x20;InputSourceMode

#### [Inventory](../docs/Status.md#inventory) <a href="#user-content-inventory" id="user-content-inventory"></a>

[**Functions**](../docs/Status.md#functions-10)

* [x] &#x20;addPromoItem
* [x] &#x20;addPromoItems
* [x] &#x20;checkResultSteamID
* [x] &#x20;consumeItem
* [x] &#x20;deserializeResult
* [x] &#x20;destroyResult
* [x] &#x20;exchangeItems
* [x] &#x20;generateItems
* [x] &#x20;getAllItems
* [x] &#x20;getItemDefinitionProperty
* [x] &#x20;getItemsByID
* [x] &#x20;getItemPrice
* [x] &#x20;getItemsWithPrices
* [x] &#x20;getNumItemsWithPrices
* [x] &#x20;getResultItemProperty
* [x] &#x20;getResultItems
* [x] &#x20;getResultStatus
* [x] &#x20;getResultTimestamp
* [x] &#x20;grantPromoItems
* [x] &#x20;loadItemDefinitions
* [x] &#x20;requestEligiblePromoItemDefinitionsIDs
* [x] &#x20;requestPrices
* [x] &#x20;serializeResult
* [x] &#x20;startPurchase
* [x] &#x20;transferItemQuantity
* [x] &#x20;triggerItemDrop
* [x] &#x20;startUpdateProperties
* [x] &#x20;submitUpdateProperties
* [x] &#x20;removeProperty
* [x] &#x20;setPropertyString
* [x] &#x20;setPropertyBool
* [x] &#x20;setPropertyInt
* [x] &#x20;setPropertyFloat

[**Signals**](../docs/Status.md#signals-10)

* [x] &#x20;inventory\_definition\_update
* [x] &#x20;inventory\_eligible\_promo\_item
* [x] &#x20;inventory\_full\_update
* [x] &#x20;inventory\_request\_prices\_result
* [x] &#x20;inventory\_result\_ready
* [x] &#x20;inventory\_start\_purchase\_result

[**Enums**](../docs/Status.md#enums-7)

* [x] &#x20;SteamItemFlags

#### [Matchmaking](../docs/Status.md#matchmaking) <a href="#user-content-matchmaking" id="user-content-matchmaking"></a>

[**Functions**](../docs/Status.md#functions-11)

* [x] &#x20;addFavoriteGame
* [x] &#x20;addRequestLobbyListDistanceFilter
* [x] &#x20;addRequestLobbyListFilterSlotsAvailable
* [x] &#x20;addRequestLobbyListNearValueFilter
* [x] &#x20;addRequestLobbyListNumericalFilter
* [x] &#x20;addRequestLobbyListResultCountFilter
* [x] &#x20;addRequestLobbyListStringFilter
* [x] &#x20;createLobby
* [x] &#x20;deleteLobbyData
* [x] &#x20;getAllLobbyData
* [x] &#x20;getFavoriteGames
* [x] &#x20;getLobbyData
* [x] &#x20;getLobbyGameServer
* [x] &#x20;getLobbyMemberByIndex
* [x] &#x20;getLobbyMemberData
* [x] &#x20;getLobbyMemberLimit
* [x] &#x20;getLobbyOwner
* [x] &#x20;getNumLobbyMembers
* [x] &#x20;inviteUserToLobby
* [x] &#x20;joinLobby
* [x] &#x20;leaveLobby
* [x] &#x20;removeFavoriteGame
* [x] &#x20;requestLobbyData
* [x] &#x20;requestLobbyList
* [x] &#x20;sendLobbyChatMsg
* [x] &#x20;setLobbyData
* [x] &#x20;setLobbyGameServer
* [x] &#x20;setLobbyJoinable
* [x] &#x20;setLobbyMemberData
* [x] &#x20;setLobbyMemberLimit
* [x] &#x20;setLobbyOwner
* [x] &#x20;setLobbyType

[**Signals**](../docs/Status.md#signals-11)

* [x] &#x20;favorites\_list\_accounts\_updated
* [x] &#x20;favorites\_list\_changed
* [x] &#x20;lobby\_chat\_update
* [x] &#x20;lobby\_created
* [x] &#x20;lobby\_data\_update
* [x] &#x20;lobby\_game\_created
* [x] &#x20;lobby\_invite
* [x] &#x20;lobby\_joined
* [x] &#x20;lobby\_kicked
* [x] &#x20;lobby\_match\_list
* [x] &#x20;lobby\_message

[**Enums**](../docs/Status.md#enums-8)

* [x] &#x20;ChatMemberStateChange
* [x] &#x20;LobbyComparison
* [x] &#x20;LobbyDistanceFilter
* [x] &#x20;LobbyType

#### [Matchmaking Servers](../docs/Status.md#matchmaking-servers) <a href="#user-content-matchmaking-servers" id="user-content-matchmaking-servers"></a>

[**Functions**](../docs/Status.md#functions-12)

* [x] &#x20;cancelQuery
* [x] &#x20;cancelServerQuery
* [x] &#x20;getServerCount
* [x] &#x20;getServerDetails
* [x] &#x20;isRefreshing
* [x] &#x20;pingServer
* [x] &#x20;playerDetails
* [x] &#x20;refreshQuery
* [x] &#x20;refreshServer
* [x] &#x20;releaseRequest
* [x] &#x20;requestFavoritesServerList
* [x] &#x20;requestFriendsServerList
* [x] &#x20;requestHistoryServerList
* [x] &#x20;requestInternetServerList
* [x] &#x20;requestLANServerList
* [x] &#x20;requestSpectatorServerList
* [x] &#x20;serverRules

[**Signals**](../docs/Status.md#signals-12)

* [x] &#x20;server\_failed\_to\_respond
* [x] &#x20;server\_responded

[**Enums**](../docs/Status.md#enums-9)

* [x] &#x20;MatchMakingServerResponse

#### [Music](../docs/Status.md#music) <a href="#user-content-music" id="user-content-music"></a>

[**Functions**](../docs/Status.md#functions-13)

* [x] &#x20;getPlaybackStatus
* [x] &#x20;musicIsEnabled
* [x] &#x20;musicIsPlaying
* [x] &#x20;musicGetVolume
* [x] &#x20;musicPause
* [x] &#x20;musicPlay
* [x] &#x20;musicPlayNext
* [x] &#x20;musicPlayPrev
* [x] &#x20;musicSetVolume

[**Enums**](../docs/Status.md#enums-10)

* [x] &#x20;AudioPlaybackStatus

#### [Music Remote](../docs/Status.md#music-remote) <a href="#user-content-music-remote" id="user-content-music-remote"></a>

[**Functions**](../docs/Status.md#functions-14)

* [x] &#x20;activationSuccess
* [x] &#x20;isCurrentMusicRemote
* [x] &#x20;currentEntryDidChange
* [x] &#x20;currentEntryIsAvailable
* [x] &#x20;currentEntryWillChange
* [x] &#x20;deregisterSteamMusicRemote
* [x] &#x20;enableLooped
* [x] &#x20;enablePlaylists
* [x] &#x20;enablePlayNext
* [x] &#x20;enablePlayPrevious
* [x] &#x20;enableQueue
* [x] &#x20;enableShuffled
* [x] &#x20;playlistDidChange
* [x] &#x20;playlistWillChange
* [x] &#x20;queueDidChange
* [x] &#x20;queueWillChange
* [x] &#x20;registerSteamMusicRemote
* [x] &#x20;resetPlaylistEntries
* [x] &#x20;resetQueueEntries
* [x] &#x20;setCurrentPlaylistEntry
* [x] &#x20;setCurrentQueueEntry
* [x] &#x20;setDisplayName
* [x] &#x20;setPlaylistEntry
* [x] &#x20;setPNGIcon64x64
* [x] &#x20;setQueueEntry
* [x] &#x20;updateCurrentEntryCoverArt
* [x] &#x20;updateCurrentEntryElapsedSeconds
* [x] &#x20;updateCurrentEntryText
* [x] &#x20;updateLooped
* [x] &#x20;updatePlaybackStatus
* [x] &#x20;updateShuffled
* [x] &#x20;updateVolume

[**Signals**](../docs/Status.md#signals-13)

* [x] &#x20;music\_player\_remote\_to\_front
* [x] &#x20;music\_player\_remote\_will\_activate
* [x] &#x20;music\_player\_remote\_will\_deactivate
* [x] &#x20;music\_player\_selects\_playlist\_entry
* [x] &#x20;music\_player\_selects\_queue\_entry
* [x] &#x20;music\_player\_wants\_looped
* [x] &#x20;music\_player\_wants\_pause
* [x] &#x20;music\_player\_wants\_play
* [x] &#x20;music\_player\_wants\_play\_next
* [x] &#x20;music\_player\_wants\_play\_previous
* [x] &#x20;music\_player\_wants\_playing\_repeat\_status
* [x] &#x20;music\_player\_wants\_shuffled
* [x] &#x20;music\_player\_wants\_volume
* [x] &#x20;music\_player\_will\_quit

#### [Networking](../docs/Status.md#networking) <a href="#user-content-networking" id="user-content-networking"></a>

[**Functions**](../docs/Status.md#functions-15)

* [x] &#x20;acceptP2PSessionWithUser
* [x] &#x20;allowP2PPacketRelay
* [x] &#x20;closeP2PChannelWithUser
* [x] &#x20;closeP2PSessionWithUser
* [x] &#x20;getP2PSessionState
* [x] &#x20;getAvailableP2PPacketSize
* [x] &#x20;readP2PPacket
* [x] &#x20;sendP2PPacket

[**Signals**](../docs/Status.md#signals-14)

* [x] &#x20;p2p\_session\_connect\_fail
* [x] &#x20;p2p\_session\_request

[**Enums**](../docs/Status.md#enums-11)

* [x] &#x20;P2PSend
* [x] &#x20;P2PSessionError
* [x] &#x20;SocketConnectionType
* [x] &#x20;SocketState

#### [Networking Messages](../docs/Status.md#networking-messages) <a href="#user-content-networking-messages" id="user-content-networking-messages"></a>

[**Functions**](../docs/Status.md#functions-16)

* [x] &#x20;acceptSessionWithUser
* [x] &#x20;closeChannelWithUser
* [x] &#x20;closeSessionWithUser
* [x] &#x20;getSessionConnectionInfo
* [x] &#x20;receiveMessagesOnChannel
* [x] &#x20;sendMessageToUser

[**Signals**](../docs/Status.md#signals-15)

* [x] &#x20;network\_messages\_session\_request (missing in docs)
* [x] &#x20;network\_messages\_session\_failed (missing in docs)

#### [Networking Sockets](../docs/Status.md#networking-sockets) <a href="#user-content-networking-sockets" id="user-content-networking-sockets"></a>

[**Functions**](../docs/Status.md#functions-17)

* [x] &#x20;acceptConnection
* [x] &#x20;beginAsyncRequestFakeIP
* [x] &#x20;closeConnection
* [x] &#x20;closeListenSocket
* [x] &#x20;configureConnectionLanes
* [x] &#x20;connectP2P
* [x] &#x20;connectToHostedDedicatedServer
* [x] &#x20;createFakeUDPPort
* [x] &#x20;createHostedDedicatedServerListenSocket
* [x] &#x20;createListenSocketIP
* [x] &#x20;createListenSocketP2P
* [x] &#x20;createListenSocketP2PFakeIP
* [x] &#x20;createPollGroup
* [x] &#x20;createSocketPair
* [x] &#x20;destroyPollGroup
* [ ] &#x20;findRelayAuthTicketForServer (missing in code)
* [x] &#x20;flushMessagesOnConnection
* [x] &#x20;getAuthenticationStatus
* [x] &#x20;getCertificateRequest
* [x] &#x20;getConnectionInfo
* [x] &#x20;getConnectionName
* [x] &#x20;GetConnectionRealTimeStatus
* [x] &#x20;getConnectionUserData
* [x] &#x20;getDetailedConnectionStatus
* [x] &#x20;getFakeIP
* [ ] &#x20;getGameCoordinatorServerLogin (missing in code)
* [ ] &#x20;getHostedDedicatedServerAddress (missing in code)
* [x] &#x20;getHostedDedicatedServerPOPId
* [x] &#x20;getHostedDedicatedServerPort
* [x] &#x20;getListenSocketAddress
* [x] &#x20;getIdentity
* [x] &#x20;getRemoteFakeIPForConnection
* [x] &#x20;initAuthentication
* [x] &#x20;receiveMessagesOnConnection
* [x] &#x20;receiveMessagesOnPollGroup
* [ ] &#x20;receivedRelayAuthTicket (missing in code)
* [x] &#x20;resetIdentity
* [x] &#x20;runNetworkingCallbacks
* [x] &#x20;sendMessages
* [x] &#x20;sendMessageToConnection
* [x] &#x20;setConnectionPollGroup
* [x] &#x20;setConnectionName
* [x] &#x20;setCertificate (missing in docs)

[**Signals**](../docs/Status.md#signals-16)

* [x] &#x20;fake\_ip\_result (missing in code)
* [x] &#x20;network\_authentication\_status
* [x] &#x20;network\_connection\_status\_changed

[**Enums**](../docs/Status.md#enums-12)

* [x] &#x20;NetworkingConfigValue
* [x] &#x20;NetworkingFakeIPType (missing in docs)
* [x] &#x20;NetworkingGetConfigValueResult
* [x] &#x20;NetworkingConnectionState
* [x] &#x20;NetworkingConnectionEnd
* [x] &#x20;NetworkingIdentityType
* [x] &#x20;NetworkingSocketsDebugOutputType

#### [Networking Types](../docs/Status.md#networking-types) <a href="#user-content-networking-types" id="user-content-networking-types"></a>

[**Functions**](../docs/Status.md#functions-18)

* [x] &#x20;addIdentity
* [x] &#x20;addIPAddress
* [x] &#x20;clearIPAddress
* [x] &#x20;clearIdentity
* [x] &#x20;getGenericBytes
* [x] &#x20;getGenericString
* [x] &#x20;getIdentities
* [x] &#x20;getIdentityIPAddr
* [x] &#x20;getIdentitySteamID
* [x] &#x20;getIdentitySteamID64
* [x] &#x20;getIPAddresses
* [x] &#x20;getIPv4
* [x] &#x20;getPSNID
* [x] &#x20;getStadiaID
* [x] &#x20;getXboxPairwiseID
* [x] &#x20;isAddressLocalHost
* [x] &#x20;isIdentityInvalid
* [x] &#x20;isIdentityLocalHost
* [x] &#x20;isIPv4
* [x] &#x20;isIPv6AllZeros
* [x] &#x20;parseIPAddressString
* [x] &#x20;parseIdentityString
* [x] &#x20;setGenericBytes
* [x] &#x20;setIdentityIPAddr
* [x] &#x20;setIdentityLocalHost
* [x] &#x20;setIdentitySteamID
* [x] &#x20;setIdentitySteamID64
* [x] &#x20;setGenericString
* [x] &#x20;setPSNID
* [x] &#x20;setStadiaID
* [x] &#x20;setXboxPairwiseID
* [x] &#x20;toIdentityString
* [x] &#x20;toIPAddressString
* [x] &#x20;setIPv4
* [x] &#x20;setIPv6
* [x] &#x20;setIPv6LocalHost

#### [Networking Utils](../docs/Status.md#networking-utils) <a href="#user-content-networking-utils" id="user-content-networking-utils"></a>

[**Functions**](../docs/Status.md#functions-19)

* [x] &#x20;checkPingDataUpToDate
* [x] &#x20;convertPingLocationToString
* [x] &#x20;estimatePingTimeBetweenTwoLocations
* [x] &#x20;estimatePingTimeFromLocalHost
* [x] &#x20;getConfigValue
* [x] &#x20;getConfigValueInfo
* [x] &#x20;getDirectPingToPOP
* [x] &#x20;getLocalPingLocation
* [x] &#x20;getLocalTimestamp
* [x] &#x20;getPingToDataCenter
* [x] &#x20;getPOPCount
* [x] &#x20;getPOPList
* [x] &#x20;getRelayNetworkStatus
* [x] &#x20;initRelayNetworkAccess
* [x] &#x20;parsePingLocationString
* [x] &#x20;setConnectionConfigValueFloat
* [x] &#x20;setConnectionConfigValueInt32
* [x] &#x20;setConnectionConfigValueString
* [ ] &#x20;setConfigValue (missing in code)
* [x] &#x20;setGlobalConfigValueFloat
* [x] &#x20;setGlobalConfigValueInt32
* [x] &#x20;setGlobalConfigValueString

[**Signals**](../docs/Status.md#signals-17)

* [x] &#x20;relay\_network\_status

[**Enums**](../docs/Status.md#enums-13)

* [x] &#x20;NetworkingAvailability
* [x] &#x20;NetworkingConfigScope
* [x] &#x20;NetworkingConfigDataType

#### [Parental Settings](../docs/Status.md#parental-settings) <a href="#user-content-parental-settings" id="user-content-parental-settings"></a>

[**Functions**](../docs/Status.md#functions-20)

* [x] &#x20;isAppBlocked
* [x] &#x20;isAppInBlockList
* [x] &#x20;isFeatureBlocked
* [x] &#x20;isFeatureInBlockList
* [x] &#x20;isParentalLockEnabled
* [x] &#x20;isParentalLockLocked

[**Signals**](../docs/Status.md#signals-18)

* [x] &#x20;parental\_setting\_changed

[**Enums**](../docs/Status.md#enums-14)

* [x] &#x20;ParentalFeature

#### [Parties](../docs/Status.md#parties) <a href="#user-content-parties" id="user-content-parties"></a>

[**Functions**](../docs/Status.md#functions-21)

* [x] &#x20;cancelReservation
* [x] &#x20;changeNumOpenSlots
* [x] &#x20;createBeacon
* [x] &#x20;destroyBeacon
* [x] &#x20;getAvailableBeaconLocations
* [x] &#x20;getBeaconByIndex
* [x] &#x20;getBeaconDetails
* [x] &#x20;getBeaconLocationData
* [x] &#x20;getNumActiveBeacons
* [x] &#x20;joinParty
* [x] &#x20;onReservationCompleted

[**Signals**](../docs/Status.md#signals-19)

* [x] &#x20;active\_beacons\_updated
* [x] &#x20;available\_beacon\_locations\_updated
* [x] &#x20;change\_num\_open\_slots
* [x] &#x20;create\_beacon
* [x] &#x20;join\_party
* [x] &#x20;reservation\_notification

[**Enums**](../docs/Status.md#enums-15)

* [ ] &#x20;SteamPartyBeaconLocationType (missing in code)
* [ ] &#x20;SteamPartyBeaconLocationData (missing in code)
* [x] &#x20;PartyBeaconLocationData (missing in docs)
* [x] &#x20;PartyBeaconLocationType (missing in docs)

#### [Remote Play](../docs/Status.md#remote-play) <a href="#user-content-remote-play" id="user-content-remote-play"></a>

[**Functions**](../docs/Status.md#functions-22)

* [x] &#x20;getSessionClientFormFactor
* [x] &#x20;getSessionClientName
* [x] &#x20;getSessionClientResolution
* [x] &#x20;getSessionCount
* [x] &#x20;getSessionID
* [x] &#x20;getSessionSteamID
* [x] &#x20;sendRemotePlayTogetherInvite
* [x] &#x20;startRemotePlayTogether

[**Signals**](../docs/Status.md#signals-20)

* [x] &#x20;remote\_play\_session\_connected
* [x] &#x20;remote\_play\_session\_disconnected

#### [Remote Storage](../docs/Status.md#remote-storage) <a href="#user-content-remote-storage" id="user-content-remote-storage"></a>

[**Functions**](../docs/Status.md#functions-23)

* [x] &#x20;beginFileWriteBatch
* [x] &#x20;endFileWriteBatch
* [x] &#x20;fileDelete
* [x] &#x20;fileExists
* [x] &#x20;fileForget
* [x] &#x20;filePersisted
* [x] &#x20;fileRead
* [x] &#x20;fileReadAsync
* [x] &#x20;fileShare
* [x] &#x20;fileWrite
* [x] &#x20;fileWriteAsync
* [x] &#x20;fileWriteStreamCancel
* [x] &#x20;fileWriteStreamClose
* [x] &#x20;fileWriteStreamOpen
* [x] &#x20;fileWriteStreamWriteChunk
* [x] &#x20;getCachedUGCCount
* [x] &#x20;getCachedUGCHandle
* [x] &#x20;getFileCount
* [x] &#x20;getFileNameAndSize
* [x] &#x20;getFileSize
* [x] &#x20;getFileTimestamp
* [x] &#x20;getLocalFileChange
* [x] &#x20;getLocalFileChangeCount
* [x] &#x20;getQuota
* [x] &#x20;getSyncPlatforms
* [x] &#x20;getUGCDetails
* [x] &#x20;getUGCDownloadProgress
* [x] &#x20;isCloudEnabledForAccount
* [x] &#x20;isCloudEnabledForApp
* [x] &#x20;setCloudEnabledForApp
* [x] &#x20;setSyncPlatforms
* [x] &#x20;ugcDownload
* [x] &#x20;ugcDownloadToLocation
* [x] &#x20;ugcRead

[**Signals**](../docs/Status.md#signals-21)

* [x] &#x20;download\_ugc\_result
* [x] &#x20;file\_read\_async\_complete
* [x] &#x20;file\_share\_result
* [x] &#x20;file\_write\_async\_complete
* [x] &#x20;local\_file\_changed
* [x] &#x20;subscribe\_item
* [x] &#x20;unsubscribe\_item

[**Enums**](../docs/Status.md#enums-16)

* [x] &#x20;RemoteStoragePlatform
* [x] &#x20;RemoteStoragePublishedFileVisibility
* [x] &#x20;UGCReadAction
* [x] &#x20;WorkshopEnumerationType
* [x] &#x20;WorkshopFileAction
* [x] &#x20;WorkshopFileType
* [x] &#x20;WorkshopVideoProvider
* [x] &#x20;WorkshopVote
* [x] &#x20;LocalFileChange
* [x] &#x20;FilePathType

#### [Screenshots](../docs/Status.md#screenshots) <a href="#user-content-screenshots" id="user-content-screenshots"></a>

[**Functions**](../docs/Status.md#functions-24)

* [x] &#x20;addScreenshotToLibrary
* [x] &#x20;addVRScreenshotToLibrary
* [x] &#x20;hookScreenshots
* [x] &#x20;isScreenshotsHooked
* [x] &#x20;setLocation
* [x] &#x20;tagPublishedFile
* [x] &#x20;tagUser
* [x] &#x20;triggerScreenshot
* [x] &#x20;writeScreenshot

[**Signals**](../docs/Status.md#signals-22)

* [x] &#x20;screenshot\_ready
* [x] &#x20;screenshot\_requested

[**Enums**](../docs/Status.md#enums-17)

* [x] &#x20;VRScreenshotType

#### [UGC](../docs/Status.md#ugc) <a href="#user-content-ugc" id="user-content-ugc"></a>

[**Functions**](../docs/Status.md#functions-25)

* [x] &#x20;addAppDependency
* [x] &#x20;addContentDescriptor
* [x] &#x20;addDependency
* [x] &#x20;addExcludedTag
* [x] &#x20;addItemKeyValueTag
* [x] &#x20;addItemPreviewFile
* [x] &#x20;addItemPreviewVideo
* [x] &#x20;addItemToFavorites
* [x] &#x20;addRequiredKeyValueTag
* [x] &#x20;addRequiredTag
* [x] &#x20;addRequiredTagGroup
* [x] &#x20;initWorkshopForGameServer
* [x] &#x20;createItem
* [x] &#x20;createQueryAllUGCRequest
* [x] &#x20;createQueryUGCDetailsRequest
* [x] &#x20;createQueryUserUGCRequest
* [x] &#x20;deleteItem
* [x] &#x20;downloadItem
* [x] &#x20;getAppDependencies
* [x] &#x20;getItemDownloadInfo
* [x] &#x20;getItemInstallInfo
* [x] &#x20;getItemState
* [x] &#x20;getItemUpdateProgress
* [x] &#x20;getNumSubscribedItems
* [x] &#x20;getQueryUGCAdditionalPreview
* [x] &#x20;getQueryUGCChildren
* [x] &#x20;getQueryUGCContentDescriptors
* [x] &#x20;getQueryUGCKeyValueTag
* [x] &#x20;getQueryUGCMetadata
* [x] &#x20;getQueryUGCNumAdditionalPreviews
* [x] &#x20;getQueryUGCNumKeyValueTags
* [x] &#x20;getQueryUGCNumTags
* [x] &#x20;getQueryUGCPreviewURL
* [x] &#x20;getQueryUGCResult
* [x] &#x20;getQueryUGCStatistic
* [x] &#x20;getQueryUGCTag
* [x] &#x20;getQueryUGCTagDisplayName
* [x] &#x20;getSubscribedItems
* [x] &#x20;getWorkshopEULAStatus
* [x] &#x20;getUserContentDescriptorPreferences
* [x] &#x20;getUserItemVote
* [x] &#x20;releaseQueryUGCRequest
* [x] &#x20;removeAppDependency
* [x] &#x20;removeContentDescriptor
* [x] &#x20;removeDependency
* [x] &#x20;removeItemFromFavorites
* [x] &#x20;removeItemKeyValueTags
* [x] &#x20;removeItemPreview
* [x] &#x20;sendQueryUGCRequest
* [x] &#x20;setAllowCachedResponse
* [x] &#x20;setCloudFileNameFilter
* [x] &#x20;setItemContent
* [x] &#x20;setItemDescription
* [x] &#x20;setItemMetadata
* [x] &#x20;setItemPreview
* [x] &#x20;setItemTags
* [x] &#x20;setItemTitle
* [x] &#x20;setItemUpdateLanguage
* [x] &#x20;setItemVisibility
* [x] &#x20;setLanguage
* [x] &#x20;setMatchAnyTag
* [x] &#x20;setRankedByTrendDays
* [x] &#x20;setReturnAdditionalPreviews
* [x] &#x20;setReturnChildren
* [x] &#x20;setReturnKeyValueTags
* [x] &#x20;setReturnLongDescription
* [x] &#x20;setReturnMetadata
* [x] &#x20;setReturnOnlyIDs
* [x] &#x20;setReturnPlaytimeStats
* [x] &#x20;setReturnTotalOnly
* [x] &#x20;setSearchText
* [x] &#x20;setUserItemVote
* [x] &#x20;showWorkshopEULA
* [x] &#x20;startItemUpdate
* [x] &#x20;startPlaytimeTracking
* [x] &#x20;stopPlaytimeTracking
* [x] &#x20;stopPlaytimeTrackingForAllItems
* [x] &#x20;submitItemUpdate
* [x] &#x20;subscribeItem
* [x] &#x20;suspendDownloads
* [x] &#x20;unsubscribeItem
* [x] &#x20;updateItemPreviewFile
* [x] &#x20;updateItemPreviewVideo

[**Signals**](../docs/Status.md#signals-23)

* [x] &#x20;add\_app\_dependency\_result
* [x] &#x20;add\_ugc\_dependency\_result
* [x] &#x20;get\_app\_dependencies\_result
* [x] &#x20;get\_item\_vote\_result
* [x] &#x20;item\_created
* [x] &#x20;item\_deleted
* [x] &#x20;item\_downloaded
* [x] &#x20;item\_installed
* [x] &#x20;item\_updated
* [x] &#x20;remove\_app\_dependency\_result
* [x] &#x20;remove\_ugc\_dependency\_result
* [x] &#x20;set\_user\_item\_vote
* [x] &#x20;start\_playtime\_tracking
* [x] &#x20;stop\_playtime\_tracking
* [x] &#x20;ugc\_query\_completed
* [x] &#x20;user\_favorite\_items\_list\_changed
* [x] &#x20;user\_subscribed\_items\_list\_changed
* [x] &#x20;workshop\_eula\_status

[**Enums**](../docs/Status.md#enums-18)

* [x] &#x20;ItemPreviewType
* [x] &#x20;ItemState
* [x] &#x20;ItemStatistic
* [x] &#x20;ItemUpdateStatus
* [x] &#x20;UGCMatchingUGCType
* [x] &#x20;UGCQuery
* [x] &#x20;UserUGCList
* [x] &#x20;UserUGCListSortOrder
* [x] &#x20;UGCContentDescriptorID

#### [User](../docs/Status.md#user) <a href="#user-content-user" id="user-content-user"></a>

[**Functions**](../docs/Status.md#functions-26)

* [x] &#x20;advertiseGame
* [x] &#x20;beginAuthSession
* [x] &#x20;cancelAuthTicket
* [x] &#x20;decompressVoice
* [x] &#x20;endAuthSession
* [x] &#x20;getAuthSessionTicket
* [x] &#x20;getAuthTicketForWebApi
* [x] &#x20;getAvailableVoice
* [x] &#x20;getDurationControl
* [x] &#x20;getEncryptedAppTicket
* [x] &#x20;getGameBadgeLevel
* [x] &#x20;getPlayerSteamLevel
* [x] &#x20;getSteamID
* [x] &#x20;getVoice
* [x] &#x20;getVoiceOptimalSampleRate
* [x] &#x20;initiateGameConnection
* [x] &#x20;isBehindNAT
* [x] &#x20;isPhoneIdentifying
* [x] &#x20;isPhoneRequiringVerification
* [x] &#x20;isPhoneVerified
* [x] &#x20;isTwoFactorEnabled
* [x] &#x20;loggedOn
* [x] &#x20;requestEncryptedAppTicket
* [x] &#x20;requestStoreAuthURL
* [x] &#x20;setDurationControlOnlineState
* [x] &#x20;startVoiceRecording
* [x] &#x20;stopVoiceRecording
* [x] &#x20;terminateGameConnection
* [x] &#x20;userHasLicenseForApp

[**Signals**](../docs/Status.md#signals-24)

* [x] &#x20;duration\_control
* [x] &#x20;client\_game\_server\_deny
* [x] &#x20;encrypted\_app\_ticket\_response
* [x] &#x20;game\_web\_callback
* [x] &#x20;get\_auth\_session\_ticket\_response
* [x] &#x20;get\_ticket\_for\_web\_api
* [x] &#x20;ipc\_failure
* [x] &#x20;licenses\_updated
* [x] &#x20;microtransaction\_auth\_response
* [x] &#x20;steam\_server\_connect\_failed
* [x] &#x20;steam\_server\_connected
* [x] &#x20;steam\_server\_disconnected
* [x] &#x20;store\_auth\_url\_response
* [x] &#x20;validate\_auth\_ticket\_response

[**Enums**](../docs/Status.md#enums-19)

* [ ] &#x20;FailureType (missing in code)
* [x] &#x20;DurationControlProgress
* [x] &#x20;DurationControlNotification

#### [User Stats](../docs/Status.md#user-stats) <a href="#user-content-user-stats" id="user-content-user-stats"></a>

[**Functions**](../docs/Status.md#functions-27)

* [x] &#x20;attachLeaderboardUGC
* [x] &#x20;clearAchievement
* [x] &#x20;downloadLeaderboardEntries
* [x] &#x20;downloadLeaderboardEntriesForUsers
* [x] &#x20;findLeaderboard
* [x] &#x20;findOrCreateLeaderboard
* [x] &#x20;getAchievement
* [x] &#x20;getAchievementAchievedPercent
* [x] &#x20;getAchievementAndUnlockTime
* [x] &#x20;getAchievementDisplayAttribute
* [x] &#x20;getAchievementIcon
* [x] &#x20;getAchievementName
* [x] &#x20;getAchievementProgressLimitsFloat
* [x] &#x20;getAchievementProgressLimitsInt
* [x] &#x20;getGlobalStatFloat
* [x] &#x20;getGlobalStatInt
* [x] &#x20;getGlobalStatFloatHistory
* [x] &#x20;getGlobalStatIntHistory
* [x] &#x20;getLeaderboardDisplayType
* [x] &#x20;getLeaderboardEntries
* [x] &#x20;getLeaderboardEntryCount
* [x] &#x20;getLeaderboardName
* [x] &#x20;getLeaderboardSortMethod
* [x] &#x20;getMostAchievedAchievementInfo
* [x] &#x20;getNextMostAchievedAchievementInfo
* [x] &#x20;getNumAchievements
* [x] &#x20;getNumberOfCurrentPlayers
* [x] &#x20;getStatFloat
* [x] &#x20;getStatInt
* [x] &#x20;getUserAchievement
* [x] &#x20;getUserAchievementAndUnlockTime
* [x] &#x20;getUserStatFloat
* [x] &#x20;getUserStatInt
* [x] &#x20;indicateAchievementProgress
* [x] &#x20;requestCurrentStats
* [x] &#x20;requestGlobalAchievementPercentages
* [x] &#x20;requestGlobalStats
* [x] &#x20;requestUserStats
* [x] &#x20;resetAllStats
* [x] &#x20;setAchievement
* [x] &#x20;setLeaderboardDetailsMax
* [x] &#x20;setStatFloat
* [x] &#x20;setStatInt
* [x] &#x20;storeStats
* [x] &#x20;updateAvgRateStat
* [x] &#x20;uploadLeaderboardScore

[**Signals**](../docs/Status.md#signals-25)

* [x] &#x20;current\_stats\_received
* [x] &#x20;global\_achievement\_percentages\_ready
* [x] &#x20;global\_stats\_received
* [x] &#x20;leaderboard\_find\_result
* [x] &#x20;leaderboard\_scores\_downloaded
* [x] &#x20;leaderboard\_score\_uploaded
* [x] &#x20;leaderboard\_ugc\_set
* [x] &#x20;number\_of\_current\_players
* [x] &#x20;user\_achievement\_stored
* [x] &#x20;user\_stats\_received
* [x] &#x20;user\_stats\_stored
* [x] &#x20;user\_stats\_unloaded

[**Enums**](../docs/Status.md#enums-20)

* [x] &#x20;LeaderboardDataRequest
* [x] &#x20;LeaderboardDisplayType
* [x] &#x20;LeaderboardSortMethod
* [x] &#x20;LeaderboardUploadScoreMethod
* [ ] &#x20;SteamUserStatType (missing in code)

#### [Utils](../docs/Status.md#utils) <a href="#user-content-utils" id="user-content-utils"></a>

[**Functions**](../docs/Status.md#functions-28)

* [x] &#x20;filterText
* [x] &#x20;getAPICallFailureReason
* [x] &#x20;getAppID
* [x] &#x20;getCurrentBatteryPower
* [x] &#x20;getImageRGBA
* [x] &#x20;getImageSize
* [x] &#x20;getIPCCallCount
* [x] &#x20;getIPCountry
* [x] &#x20;getSecondsSinceAppActive
* [x] &#x20;getSecondsSinceComputerActive
* [x] &#x20;getServerRealTime
* [x] &#x20;getSteamUILanguage
* [x] &#x20;initFilterText
* [x] &#x20;isAPICallCompleted
* [x] &#x20;isOverlayEnabled
* [x] &#x20;isSteamChinaLauncher
* [x] &#x20;isSteamInBigPictureMode
* [x] &#x20;isSteamRunningInVR
* [x] &#x20;isSteamRunningOnSteamDeck
* [x] &#x20;isVRHeadsetStreamingEnabled
* [x] &#x20;overlayNeedsPresent
* [x] &#x20;setGameLauncherMode
* [x] &#x20;setOverlayNotificationInset
* [x] &#x20;setOverlayNotificationPosition
* [x] &#x20;setVRHeadsetStreamingEnabled
* [x] &#x20;showGamepadTextInput
* [x] &#x20;showFloatingGamepadTextInput
* [x] &#x20;startVRDashboard

[**Signals**](../docs/Status.md#signals-26)

* [x] &#x20;app\_resuming\_from\_suspend
* [x] &#x20;check\_file\_signature
* [x] &#x20;filter\_text\_dictionary\_changed
* [x] &#x20;floating\_gamepad\_text\_input\_dismissed
* [x] &#x20;gamepad\_text\_input\_dismissed
* [x] &#x20;ip\_country
* [x] &#x20;low\_power
* [x] &#x20;steam\_api\_call\_completed
* [x] &#x20;steam\_shutdown

[**Enums**](../docs/Status.md#enums-21)

* [x] &#x20;CheckFileSignature
* [x] &#x20;GamepadTextInputLineMode
* [x] &#x20;GamepadTextInputMode
* [x] &#x20;FloatingGamepadTextInputMode
* [ ] &#x20;SteamAPICallFailure (missing in code)
* [x] &#x20;ApiCallFailure (mising in docs)
* [x] &#x20;TextFilteringContext

#### [Video](../docs/Status.md#video) <a href="#user-content-video" id="user-content-video"></a>

[**Functions**](../docs/Status.md#functions-29)

* [x] &#x20;getOPFSettings
* [x] &#x20;getOPFStringForApp
* [x] &#x20;getVideoURL
* [x] &#x20;isBroadcasting

[**Signals**](../docs/Status.md#signals-27)

* [x] &#x20;get\_opf\_settings\_result
* [x] &#x20;get\_video\_result
