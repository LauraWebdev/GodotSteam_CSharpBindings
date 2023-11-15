# GodotSteam C# Bindings

[Back to README](../README.md)

## Implementation Status
### Main
#### Functions
- [x] isSteamRunning
- [x] restartAppIfNecessary
- [x] run_callbacks
- [x] steamInit
- [x] steamInitEx

#### Signals
- [x] steamworks_error

#### Enums
- [x] AccountType
- [ ] AppOwnershipFlags (missing in code)
- [ ] AppReleaseState (missing in code)
- [ ] AppType (mssing in code)
- [x] AuthSessionResponse
- [x] BeginAuthSessionResult
- [x] BroadcastUploadResult
- [x] ChatEntryType
- [x] ChatRoomEnterResponse
- [x] ChatSteamIDInstanceFlags
- [x] DenyReason
- [x] GameIDType
- [ ] LaunchOptionType (missing in code)
- [x] NotificationPosition
- [x] Result
- [x] SteamAPIInitResult
- [x] Universe
- [x] UserHasLicenseForAppResult
- [x] VoiceResult
- [ ] VRHMDType (missing in code)

### App Lists
#### Functions
- [x] getAppListBuildId
- [x] getAppListInstallDir
- [x] getAppName
- [x] getInstalledApps
- [x] getNumInstalledApps

#### Signals
- [x] app_installed
- [x] app_uninstalled

### Apps
#### Functions
- [x] getAppBuildId
- [x] getAppInstallDir
- [x] getAppOwner
- [x] getAvailableGameLanguages
- [x] getCurrentBetaName
- [x] getCurrentGameLanguage
- [x] getDLCCount
- [x] getDLCDataByIndex
- [x] getDLCDownloadProgress
- [x] getEarliestPurchaseUnixTime
- [x] getFileDetails
- [x] getInstalledDepots
- [x] getLaunchCommandLine
- [x] getLaunchQueryParam
- [ ] getLeaderboardDisplayType (missing in code)
- [x] installDLC
- [x] isAppInstalled
- [x] isDLCInstalled
- [x] isLowViolence
- [x] isSubscribed
- [x] isSubscribedApp
- [x] isSubscribedFromFamilySharing
- [x] isSubscribedFromFreeWeekend
- [x] isTimedTrial
- [x] isVACBanned
- [x] markContentCorrupt
- [x] setDLCContext
- [x] uninstallDLC

#### Signals
- [x] dlc_installed
- [x] file_details_result
- [x] new_launch_url_parameters
- [x] timed_trial_status

#### Enums
- [ ] RegisterActivationCodeResult

### Friends
#### Functions
- [x] activateGameOverlay
- [x] activateGameOverlayInviteDialog
- [x] activateGameOverlayInviteDialogConnectString
- [x] activateGameOverlayToStore
- [x] activateGameOverlayToUser
- [x] activateGameOverlayToWebPage
- [x] clearRichPresence
- [x] closeClanChatWindowInSteam
- [x] downloadClanActivityCounts
- [x] enumerateFollowingList
- [x] getChatMemberByIndex
- [x] getClanActivityCounts
- [x] getClanByIndex
- [x] getClanChatMemberCount
- [x] getClanChatMessage
- [x] getClanCount
- [x] getClanName
- [x] getClanOfficerByIndex
- [x] getClanOfficerCount
- [x] getClanOwner
- [x] getClanTag
- [x] getCoplayFriend
- [x] getCoplayFriendCount
- [x] getFollowerCount
- [x] getFriendByIndex
- [x] getFriendCoplayGame
- [x] getFriendCoplayTime
- [x] getFriendCount
- [x] getFriendCountFromSource
- [x] getFriendFromSourceByIndex
- [x] getFriendGamePlayed
- [x] getFriendMessage
- [x] getFriendPersonaName
- [x] getFriendPersonaNameHistory
- [x] getFriendPersonaState
- [x] getFriendRelationship
- [x] getFriendRichPresence
- [x] getFriendRichPresenceKeyCount
- [x] getFriendRichPresenceKeyByIndex
- [x] getFriendsGroupCount
- [x] getFriendsGroupIDByIndex
- [x] getFriendsGroupMembersCount
- [x] getFriendsGroupMembersList
- [x] getFriendsGroupName
- [x] getFriendSteamLevel
- [x] getLargeFriendAvatar
- [x] getMediumFriendAvatar
- [x] getPersonaName
- [x] getPersonaState
- [x] getPlayerAvatar
- [x] getPlayerNickname
- [x] getProfileItemPropertyString
- [x] getProfileItemPropertyInt
- [x] getRecentPlayers
- [x] getSmallFriendAvatar
- [x] getUserFriendsGroups
- [x] getUserRestrictions
- [x] getUserSteamFriends
- [x] getUserSteamGroups
- [x] hasEquippedProfileItem
- [x] hasFriend
- [x] inviteUserToGame
- [x] isClanChatAdmin
- [x] isClanPublic
- [x] isClanOfficialGameGroup
- [x] isClanChatWindowOpenInSteam
- [x] isFollowing
- [x] isUserInSource
- [x] joinClanChatRoom
- [x] leaveClanChatRoom
- [x] openClanChatWindowInSteam
- [x] registerProtocolInOverlayBrowser
- [x] replyToFriendMessage
- [x] requestClanOfficerList
- [x] requestFriendRichPresence
- [x] requestUserInformation
- [x] sendClanChatMessage
- [x] setInGameVoiceSpeaking
- [x] setListenForFriendsMessages
- [x] setPersonaName
- [x] setPlayedWith
- [x] setRichPresence

#### Signals
- [x] avatar_loaded
- [x] avatar_image_loaded
- [x] change_server_requested
- [x] clan_activity_downloaded
- [x] connected_chat_join
- [x] connected_chat_leave
- [x] connected_clan_chat_message
- [x] connected_friend_chat_message
- [x] enumerate_following_list
- [x] equipped_profile_items
- [x] equipped_profile_items_changed
- [x] friend_rich_presence_update
- [x] get_follower_count
- [x] is_following
- [x] join_clan_chat_complete
- [x] join_game_requested
- [x] join_requested
- [x] name_changed
- [x] overlay_browser_protocol
- [x] overlay_toggled
- [x] persona_state_change
- [x] request_clan_officer_list
- [x] unread_chat_messages_changed

#### Enums
- [x] AvatarSizes
- [x] CommunityProfileItemType
- [x] CommunityProfileItemProperty
- [x] FriendFlags
- [x] FriendRelationship
- [x] OverlayToStoreFlag
- [x] OverlayToWebPageMode
- [x] PersonaChange
- [x] PersonaState
- [x] UserRestriction

### Game Search
#### Functions
- [x] acceptGame
- [x] addGameSearchParams
- [x] cancelRequestPlayersForGame
- [x] declineGame
- [x] endGame
- [x] endGameSearch
- [x] hostConfirmGameStart
- [x] requestPlayersForGame
- [x] retrieveConnectionDetails
- [x] searchForGameSolo
- [x] searchForGameWithLobby
- [x] setConnectionDetails
- [x] setGameHostParams
- [x] submitPlayerResult

#### Signals
- [x] end_game_result
- [x] request_players_for_game_final_result
- [x] request_players_for_game_progress
- [x] request_players_for_game_result
- [x] search_for_game_progress
- [x] search_for_game_result
- [x] submit_player_result

#### Enums
- [ ] GameSearchErrorCode
- [x] PlayerResult

### Game Server
#### Functions
- [ ] associateWithClan
- [x] beginAuthSession
- [ ] cancelServerAuthTicket
- [ ] clearAllKeyValues
- [ ] computeNewPlayerCompatibility
- [x] endAuthSession
- [x] getAuthSessionTicket
- [ ] getNextOutgoingPacket
- [ ] getPublicIP
- [x] getSteamID
- [ ] handleIncomingPacket
- [ ] initGameServer
- [x] loggedOn
- [ ] logOff
- [x] logOn
- [ ] logOnAnonymous
- [ ] requestUserGroupStatus
- [ ] secure
- [ ] setAdvertiseServerActive
- [ ] setBotPlayerCount
- [ ] setDedicatedServer
- [ ] setGameData
- [ ] setGameDescription
- [ ] setGameTags
- [ ] setHeartbeatInterval
- [ ] setKeyValue
- [ ] setMapName
- [ ] setMaxPlayerCount
- [ ] setModDir
- [ ] setPasswordProtected
- [ ] setProduct
- [ ] setRegion
- [ ] setServerName
- [ ] setSpectatorPort
- [ ] setSpectatorServerName
- [ ] userHasLicenceForApp
- [ ] wasRestartRequested

#### Signals
- [ ] associate_clan
- [ ] client_approved
- [ ] client_denied
- [ ] client_group_status
- [ ] client_kick
- [ ] player_compat
- [ ] policy_response
- [ ] server_connect_failure
- [ ] server_connected
- [ ] server_disconnected

### Game Server Stats
#### Functions
- [ ] clearUserAchievement
- [ ] serverGetUserAchievement
- [ ] serverGetUserStatFloat
- [ ] serverGetUserStatInt
- [ ] serverRequestUserStats
- [ ] setUserAchievement
- [ ] setUserStatFloat
- [ ] setUserStatInt
- [ ] storeUserStats
- [ ] updateUserAvgRateStat

#### Signals
- [ ] stats_received
- [ ] stats_stored
- [ ] stats_unloaded

### HTML Surface
#### Functions
- [x] addHeader
- [x] allowStartRequest
- [x] copyToClipboard
- [x] createBrowser
- [x] executeJavascript
- [x] find
- [x] getLinkAtPosition
- [x] goBack
- [x] goForward
- [x] htmlInit
- [x] jsDialogResponse
- [x] keyChar
- [x] keyDown
- [x] keyUp
- [x] loadURL
- [x] mouseDoubleClick
- [x] mouseDown
- [x] mouseMove
- [x] mouseUp
- [x] mouseWheel
- [x] pasteFromClipboard
- [x] reload
- [x] removeBrowser
- [x] setBackgroundMode
- [x] setCookie
- [x] setHorizontalScroll
- [x] setKeyFocus
- [x] setPageScaleFactor
- [x] setSize
- [x] setVerticalScroll
- [x] htmlShutdown
- [x] stopFind
- [x] stopLoad
- [x] viewSource

#### Signals
- [x] html_browser_ready
- [x] html_can_go_backandforward
- [x] html_changed_title
- [x] html_close_browser
- [x] html_file_open_dialog
- [x] html_finished_request
- [x] html_hide_tooltip
- [x] html_horizontal_scroll
- [x] html_js_alert
- [x] html_js_confirm
- [x] html_link_at_position
- [x] html_needs_paint
- [x] html_new_window
- [x] html_open_link_in_new_tab
- [x] html_search_results
- [x] html_set_cursor
- [x] html_show_tooltip
- [x] html_start_request
- [x] html_status_text
- [x] html_update_tooltip
- [x] html_url_changed
- [x] html_vertical_scroll

#### Enums
- [x] HTMLKeyModifiers
- [x] HTMLMouseButton
- [x] MouseCursor

### HTTP
#### Functions
- [x] createCookieContainer
- [x] createHTTPRequest
- [x] deferHTTPRequest
- [x] getHTTPDownloadProgressPct
- [x] getHTTPRequestWasTimedOut
- [x] getHTTPResponseBodyData
- [x] getHTTPResponseBodySize
- [x] getHTTPResponseHeaderSize
- [x] getHTTPResponseHeaderValue
- [x] getHTTPStreamingResponseBodyData
- [x] prioritizeHTTPRequest
- [x] releaseCookieContainer
- [x] releaseHTTPRequest
- [x] sendHTTPRequest
- [x] sendHTTPRequestAndStreamResponse
- [x] setHTTPCookie
- [x] setHTTPRequestAbsoluteTimeoutMS
- [x] setHTTPRequestContextValue
- [x] setHTTPRequestCookieContainer
- [x] setHTTPRequestGetOrPostParameter
- [x] setHTTPRequestHeaderValue
- [x] setHTTPRequestNetworkActivityTimeout
- [x] setHTTPRequestRawPostBody
- [x] setHTTPRequestRequiresVerifiedCertificate
- [x] setHTTPRequestUserAgentInfo

#### Signals
- [x] http_request_completed
- [x] http_request_data_received
- [x] http_request_headers_received

#### Enums
- [x] HTTPMethod
- [x] HTTPStatusCode

### Input
#### Functions
- [x] activateActionSet
- [x] activateActionSetLayer
- [x] deactivateActionSetLayer
- [x] deactivateAllActionSetLayers
- [x] getActiveActionSetLayers
- [x] getActionSetHandle
- [x] getActionOriginFromXboxOrigin
- [x] getAnalogActionData
- [x] getAnalogActionHandle
- [x] getAnalogActionOrigins
- [x] getConnectedControllers
- [x] getControllerForGamepadIndex
- [x] getCurrentActionSet
- [x] getDeviceBindingRevision
- [x] getDigitalActionData
- [x] getDigitalActionHandle
- [x] getDigitalActionOrigins
- [x] getGamepadIndexForController
- [x] getGlyphForActionOrigin
- [x] getInputTypeForHandle
- [x] getMotionData
- [x] getRemotePlaySessionID
- [x] getSessionInputConfigurationSettings
- [x] getStringforActionOrigin
- [x] inputInit
- [x] inputShutdown
- [x] runFrame
- [x] setDualSenseTriggerEffect
- [x] setLEDColor
- [x] showBindingPanel
- [x] stopAnalogActionMomentum
- [x] translateActionOrigin
- [x] triggerHapticPulse
- [x] triggerRepeatedHapticPulse
- [x] triggerVibration
- [x] triggerVibrationExtended

#### Signals
- [x] input_action_event (missing in docs)
- [x] input_configuration_loaded
- [x] input_device_connected
- [x] input_device_disconnected
- [x] input_gamepad_slot_change

#### Enums
- [x] InputActionEventType
- [x] InputActionOrigin
- [x] InputConfigurationEnableType
- [x] InputGlyphSize
- [x] InputGlyphStyle
- [x] InputLedFlag
- [x] InputSourceMode

### Inventory
#### Functions
- [x] addPromoItem
- [x] addPromoItems
- [x] checkResultSteamID
- [x] consumeItem
- [x] deserializeResult
- [x] destroyResult
- [x] exchangeItems
- [x] generateItems
- [x] getAllItems
- [x] getItemDefinitionProperty
- [x] getItemsByID
- [x] getItemPrice
- [x] getItemsWithPrices
- [x] getNumItemsWithPrices
- [x] getResultItemProperty
- [x] getResultItems
- [x] getResultStatus
- [x] getResultTimestamp
- [x] grantPromoItems
- [x] loadItemDefinitions
- [x] requestEligiblePromoItemDefinitionsIDs
- [x] requestPrices
- [x] serializeResult
- [x] startPurchase
- [x] transferItemQuantity
- [x] triggerItemDrop
- [x] startUpdateProperties
- [x] submitUpdateProperties
- [x] removeProperty
- [x] setPropertyString
- [x] setPropertyBool
- [x] setPropertyInt
- [x] setPropertyFloat

#### Signals
- [x] inventory_definition_update
- [x] inventory_eligible_promo_item
- [x] inventory_full_update
- [x] inventory_request_prices_result
- [x] inventory_result_ready
- [x] inventory_start_purchase_result

#### Enums
- [x] SteamItemFlags

### Matchmaking
#### Functions
- [x] addFavoriteGame
- [x] addRequestLobbyListDistanceFilter
- [x] addRequestLobbyListFilterSlotsAvailable
- [x] addRequestLobbyListNearValueFilter
- [x] addRequestLobbyListNumericalFilter
- [x] addRequestLobbyListResultCountFilter
- [x] addRequestLobbyListStringFilter
- [x] createLobby
- [x] deleteLobbyData
- [x] getAllLobbyData
- [x] getFavoriteGames
- [x] getLobbyData
- [x] getLobbyGameServer
- [x] getLobbyMemberByIndex
- [x] getLobbyMemberData
- [x] getLobbyMemberLimit
- [x] getLobbyOwner
- [x] getNumLobbyMembers
- [x] inviteUserToLobby
- [x] joinLobby
- [x] leaveLobby
- [x] removeFavoriteGame
- [x] requestLobbyData
- [x] requestLobbyList
- [x] sendLobbyChatMsg
- [x] setLobbyData
- [x] setLobbyGameServer
- [x] setLobbyJoinable
- [x] setLobbyMemberData
- [x] setLobbyMemberLimit
- [x] setLobbyOwner
- [x] setLobbyType

#### Signals
- [x] favorites_list_accounts_updated
- [x] favorites_list_changed
- [x] lobby_chat_update
- [x] lobby_created
- [x] lobby_data_update
- [x] lobby_game_created
- [x] lobby_invite
- [x] lobby_joined
- [x] lobby_kicked
- [x] lobby_match_list
- [x] lobby_message

#### Enums
- [x] ChatMemberStateChange
- [x] LobbyComparison
- [x] LobbyDistanceFilter
- [x] LobbyType

### Matchmaking Servers
#### Functions
- [x] cancelQuery
- [x] cancelServerQuery
- [x] getServerCount
- [x] getServerDetails
- [x] isRefreshing
- [x] pingServer
- [x] playerDetails
- [x] refreshQuery
- [x] refreshServer
- [x] releaseRequest
- [x] requestFavoritesServerList
- [x] requestFriendsServerList
- [x] requestHistoryServerList
- [x] requestInternetServerList
- [x] requestLANServerList
- [x] requestSpectatorServerList
- [x] serverRules

#### Signals
- [x] server_failed_to_respond
- [x] server_responded

#### Enums
- [x] MatchMakingServerResponse

### Music
#### Functions
- [x] getPlaybackStatus
- [x] musicIsEnabled
- [x] musicIsPlaying
- [x] musicGetVolume
- [x] musicPause
- [x] musicPlay
- [x] musicPlayNext
- [x] musicPlayPrev
- [x] musicSetVolume

#### Enums
- [x] AudioPlaybackStatus

### Music Remote
#### Functions
- [x] activationSuccess
- [x] isCurrentMusicRemote
- [x] currentEntryDidChange
- [x] currentEntryIsAvailable
- [x] currentEntryWillChange
- [x] deregisterSteamMusicRemote
- [x] enableLooped
- [x] enablePlaylists
- [x] enablePlayNext
- [x] enablePlayPrevious
- [x] enableQueue
- [x] enableShuffled
- [x] playlistDidChange
- [x] playlistWillChange
- [x] queueDidChange
- [x] queueWillChange
- [x] registerSteamMusicRemote
- [x] resetPlaylistEntries
- [x] resetQueueEntries
- [x] setCurrentPlaylistEntry
- [x] setCurrentQueueEntry
- [x] setDisplayName
- [x] setPlaylistEntry
- [x] setPNGIcon64x64
- [x] setQueueEntry
- [x] updateCurrentEntryCoverArt
- [x] updateCurrentEntryElapsedSeconds
- [x] updateCurrentEntryText
- [x] updateLooped
- [x] updatePlaybackStatus
- [x] updateShuffled
- [x] updateVolume

#### Signals
- [x] music_player_remote_to_front
- [x] music_player_remote_will_activate
- [x] music_player_remote_will_deactivate
- [x] music_player_selects_playlist_entry
- [x] music_player_selects_queue_entry
- [x] music_player_wants_looped
- [x] music_player_wants_pause
- [x] music_player_wants_play
- [x] music_player_wants_play_next
- [x] music_player_wants_play_previous
- [x] music_player_wants_playing_repeat_status
- [x] music_player_wants_shuffled
- [x] music_player_wants_volume
- [x] music_player_will_quit

### Networking
#### Functions
- [x] acceptP2PSessionWithUser
- [x] allowP2PPacketRelay
- [x] closeP2PChannelWithUser
- [x] closeP2PSessionWithUser
- [x] getP2PSessionState
- [x] getAvailableP2PPacketSize
- [x] readP2PPacket
- [x] sendP2PPacket

#### Signals
- [x] p2p_session_connect_fail
- [x] p2p_session_request

#### Enums
- [x] P2PSend
- [x] P2PSessionError
- [x] SocketConnectionType
- [x] SocketState

### Networking Messages
#### Functions
- [x] acceptSessionWithUser
- [x] closeChannelWithUser
- [x] closeSessionWithUser
- [x] getSessionConnectionInfo
- [x] receiveMessagesOnChannel
- [x] sendMessageToUser

#### Signals
- [x] network_messages_session_request (missing in docs)
- [x] network_messages_session_failed (missing in docs)

### Networking Sockets
#### Functions
- [x] acceptConnection
- [x] beginAsyncRequestFakeIP
- [x] closeConnection
- [x] closeListenSocket
- [x] configureConnectionLanes
- [x] connectP2P
- [x] connectToHostedDedicatedServer
- [x] createFakeUDPPort
- [x] createHostedDedicatedServerListenSocket
- [x] createListenSocketIP
- [x] createListenSocketP2P
- [x] createListenSocketP2PFakeIP
- [x] createPollGroup
- [x] createSocketPair
- [x] destroyPollGroup
- [ ] findRelayAuthTicketForServer (missing in code)
- [x] flushMessagesOnConnection
- [x] getAuthenticationStatus
- [x] getCertificateRequest
- [x] getConnectionInfo
- [x] getConnectionName
- [x] GetConnectionRealTimeStatus
- [x] getConnectionUserData
- [x] getDetailedConnectionStatus
- [x] getFakeIP
- [ ] getGameCoordinatorServerLogin (missing in code)
- [ ] getHostedDedicatedServerAddress (missing in code)
- [x] getHostedDedicatedServerPOPId
- [x] getHostedDedicatedServerPort
- [x] getListenSocketAddress
- [x] getIdentity
- [x] getRemoteFakeIPForConnection
- [x] initAuthentication
- [x] receiveMessagesOnConnection
- [x] receiveMessagesOnPollGroup
- [ ] receivedRelayAuthTicket (missing in code)
- [x] resetIdentity
- [x] runNetworkingCallbacks
- [x] sendMessages
- [x] sendMessageToConnection
- [x] setConnectionPollGroup
- [x] setConnectionName
- [x] setCertificate (missing in docs)

#### Signals
- [x] fake_ip_result (missing in code)
- [x] network_authentication_status
- [x] network_connection_status_changed

#### Enums
- [x] NetworkingConfigValue
- [x] NetworkingFakeIPType (missing in docs)
- [x] NetworkingGetConfigValueResult
- [x] NetworkingConnectionState
- [x] NetworkingConnectionEnd
- [x] NetworkingIdentityType
- [x] NetworkingSocketsDebugOutputType

### Networking Types
#### Functions
- [x] addIdentity
- [x] addIPAddress
- [x] clearIPAddress
- [x] clearIdentity
- [x] getGenericBytes
- [x] getGenericString
- [x] getIdentities
- [x] getIdentityIPAddr
- [x] getIdentitySteamID
- [x] getIdentitySteamID64
- [x] getIPAddresses
- [x] getIPv4
- [x] getPSNID
- [x] getStadiaID
- [x] getXboxPairwiseID
- [x] isAddressLocalHost
- [x] isIdentityInvalid
- [x] isIdentityLocalHost
- [x] isIPv4
- [x] isIPv6AllZeros
- [x] parseIPAddressString
- [x] parseIdentityString
- [x] setGenericBytes
- [x] setIdentityIPAddr
- [x] setIdentityLocalHost
- [x] setIdentitySteamID
- [x] setIdentitySteamID64
- [x] setGenericString
- [x] setPSNID
- [x] setStadiaID
- [x] setXboxPairwiseID
- [x] toIdentityString
- [x] toIPAddressString
- [x] setIPv4
- [x] setIPv6
- [x] setIPv6LocalHost

### Networking Utils
#### Functions
- [x] checkPingDataUpToDate
- [x] convertPingLocationToString
- [x] estimatePingTimeBetweenTwoLocations
- [x] estimatePingTimeFromLocalHost
- [x] getConfigValue
- [x] getConfigValueInfo
- [x] getDirectPingToPOP
- [x] getLocalPingLocation
- [x] getLocalTimestamp
- [x] getPingToDataCenter
- [x] getPOPCount
- [x] getPOPList
- [x] getRelayNetworkStatus
- [x] initRelayNetworkAccess
- [x] parsePingLocationString
- [x] setConnectionConfigValueFloat
- [x] setConnectionConfigValueInt32
- [x] setConnectionConfigValueString
- [ ] setConfigValue (missing in code)
- [x] setGlobalConfigValueFloat
- [x] setGlobalConfigValueInt32
- [x] setGlobalConfigValueString

#### Signals
- [x] relay_network_status

#### Enums
- [x] NetworkingAvailability
- [x] NetworkingConfigScope
- [x] NetworkingConfigDataType

### Parental Settings
#### Functions
- [x] isAppBlocked
- [x] isAppInBlockList
- [x] isFeatureBlocked
- [x] isFeatureInBlockList
- [x] isParentalLockEnabled
- [x] isParentalLockLocked

#### Signals
- [x] parental_setting_changed

#### Enums
- [x] ParentalFeature

### Parties
#### Functions
- [x] cancelReservation
- [x] changeNumOpenSlots
- [x] createBeacon
- [x] destroyBeacon
- [x] getAvailableBeaconLocations
- [x] getBeaconByIndex
- [x] getBeaconDetails
- [x] getBeaconLocationData
- [x] getNumActiveBeacons
- [x] joinParty
- [x] onReservationCompleted

#### Signals
- [x] active_beacons_updated
- [x] available_beacon_locations_updated
- [x] change_num_open_slots
- [x] create_beacon
- [x] join_party
- [x] reservation_notification

#### Enums
- [ ] SteamPartyBeaconLocationType (missing in code)
- [ ] SteamPartyBeaconLocationData (missing in code)
- [x] PartyBeaconLocationData (missing in docs)
- [x] PartyBeaconLocationType (missing in docs)

### Remote Play
#### Functions
- [x] getSessionClientFormFactor
- [x] getSessionClientName
- [x] getSessionClientResolution
- [x] getSessionCount
- [x] getSessionID
- [x] getSessionSteamID
- [x] sendRemotePlayTogetherInvite
- [x] startRemotePlayTogether

#### Signals
- [x] remote_play_session_connected
- [x] remote_play_session_disconnected

### Remote Storage
#### Functions
- [x] beginFileWriteBatch
- [x] endFileWriteBatch
- [x] fileDelete
- [x] fileExists
- [x] fileForget
- [x] filePersisted
- [x] fileRead
- [x] fileReadAsync
- [x] fileShare
- [x] fileWrite
- [x] fileWriteAsync
- [x] fileWriteStreamCancel
- [x] fileWriteStreamClose
- [x] fileWriteStreamOpen
- [x] fileWriteStreamWriteChunk
- [x] getCachedUGCCount
- [x] getCachedUGCHandle
- [x] getFileCount
- [x] getFileNameAndSize
- [x] getFileSize
- [x] getFileTimestamp
- [x] getLocalFileChange
- [x] getLocalFileChangeCount
- [x] getQuota
- [x] getSyncPlatforms
- [x] getUGCDetails
- [x] getUGCDownloadProgress
- [x] isCloudEnabledForAccount
- [x] isCloudEnabledForApp
- [x] setCloudEnabledForApp
- [x] setSyncPlatforms
- [x] ugcDownload
- [x] ugcDownloadToLocation
- [x] ugcRead

#### Signals
- [x] download_ugc_result
- [x] file_read_async_complete
- [x] file_share_result
- [x] file_write_async_complete
- [x] local_file_changed
- [x] subscribe_item
- [x] unsubscribe_item

#### Enums
- [x] RemoteStoragePlatform
- [x] RemoteStoragePublishedFileVisibility
- [x] UGCReadAction
- [x] WorkshopEnumerationType
- [x] WorkshopFileAction
- [x] WorkshopFileType
- [x] WorkshopVideoProvider
- [x] WorkshopVote
- [x] LocalFileChange
- [x] FilePathType

### Screenshots
#### Functions
- [x] addScreenshotToLibrary
- [x] addVRScreenshotToLibrary
- [x] hookScreenshots
- [x] isScreenshotsHooked
- [x] setLocation
- [x] tagPublishedFile
- [x] tagUser
- [x] triggerScreenshot
- [x] writeScreenshot

#### Signals
- [x] screenshot_ready
- [x] screenshot_requested

#### Enums
- [x] VRScreenshotType

### UGC
#### Functions
- [x] addAppDependency
- [x] addContentDescriptor
- [x] addDependency
- [x] addExcludedTag
- [x] addItemKeyValueTag
- [x] addItemPreviewFile
- [x] addItemPreviewVideo
- [x] addItemToFavorites
- [x] addRequiredKeyValueTag
- [x] addRequiredTag
- [x] addRequiredTagGroup
- [x] initWorkshopForGameServer
- [x] createItem
- [x] createQueryAllUGCRequest
- [x] createQueryUGCDetailsRequest
- [x] createQueryUserUGCRequest
- [x] deleteItem
- [x] downloadItem
- [x] getAppDependencies
- [x] getItemDownloadInfo
- [x] getItemInstallInfo
- [x] getItemState
- [x] getItemUpdateProgress
- [x] getNumSubscribedItems
- [x] getQueryUGCAdditionalPreview
- [x] getQueryUGCChildren
- [x] getQueryUGCContentDescriptors
- [x] getQueryUGCKeyValueTag
- [x] getQueryUGCMetadata
- [x] getQueryUGCNumAdditionalPreviews
- [x] getQueryUGCNumKeyValueTags
- [x] getQueryUGCNumTags
- [x] getQueryUGCPreviewURL
- [x] getQueryUGCResult
- [x] getQueryUGCStatistic
- [x] getQueryUGCTag
- [x] getQueryUGCTagDisplayName
- [x] getSubscribedItems
- [x] getWorkshopEULAStatus
- [x] getUserContentDescriptorPreferences
- [x] getUserItemVote
- [x] releaseQueryUGCRequest
- [x] removeAppDependency
- [x] removeContentDescriptor
- [x] removeDependency
- [x] removeItemFromFavorites
- [x] removeItemKeyValueTags
- [x] removeItemPreview
- [x] sendQueryUGCRequest
- [x] setAllowCachedResponse
- [x] setCloudFileNameFilter
- [x] setItemContent
- [x] setItemDescription
- [x] setItemMetadata
- [x] setItemPreview
- [x] setItemTags
- [x] setItemTitle
- [x] setItemUpdateLanguage
- [x] setItemVisibility
- [x] setLanguage
- [x] setMatchAnyTag
- [x] setRankedByTrendDays
- [x] setReturnAdditionalPreviews
- [x] setReturnChildren
- [x] setReturnKeyValueTags
- [x] setReturnLongDescription
- [x] setReturnMetadata
- [x] setReturnOnlyIDs
- [x] setReturnPlaytimeStats
- [x] setReturnTotalOnly
- [x] setSearchText
- [x] setUserItemVote
- [x] showWorkshopEULA
- [x] startItemUpdate
- [x] startPlaytimeTracking
- [x] stopPlaytimeTracking
- [x] stopPlaytimeTrackingForAllItems
- [x] submitItemUpdate
- [x] subscribeItem
- [x] suspendDownloads
- [x] unsubscribeItem
- [x] updateItemPreviewFile
- [x] updateItemPreviewVideo

#### Signals
- [x] add_app_dependency_result
- [x] add_ugc_dependency_result
- [x] get_app_dependencies_result
- [x] get_item_vote_result
- [x] item_created
- [x] item_deleted
- [x] item_downloaded
- [x] item_installed
- [x] item_updated
- [x] remove_app_dependency_result
- [x] remove_ugc_dependency_result
- [x] set_user_item_vote
- [x] start_playtime_tracking
- [x] stop_playtime_tracking
- [x] ugc_query_completed
- [x] user_favorite_items_list_changed
- [x] user_subscribed_items_list_changed
- [x] workshop_eula_status

#### Enums
- [x] ItemPreviewType
- [x] ItemState
- [x] ItemStatistic
- [x] ItemUpdateStatus
- [x] UGCMatchingUGCType
- [x] UGCQuery
- [x] UserUGCList
- [x] UserUGCListSortOrder
- [x] UGCContentDescriptorID

### User
#### Functions
- [x] advertiseGame
- [x] beginAuthSession
- [x] cancelAuthTicket
- [x] decompressVoice
- [x] endAuthSession
- [x] getAuthSessionTicket
- [x] getAuthTicketForWebApi
- [x] getAvailableVoice
- [x] getDurationControl
- [x] getEncryptedAppTicket
- [x] getGameBadgeLevel
- [x] getPlayerSteamLevel
- [x] getSteamID
- [x] getVoice
- [x] getVoiceOptimalSampleRate
- [x] initiateGameConnection
- [x] isBehindNAT
- [x] isPhoneIdentifying
- [x] isPhoneRequiringVerification
- [x] isPhoneVerified
- [x] isTwoFactorEnabled
- [x] loggedOn
- [x] requestEncryptedAppTicket
- [x] requestStoreAuthURL
- [x] setDurationControlOnlineState
- [x] startVoiceRecording
- [x] stopVoiceRecording
- [x] terminateGameConnection
- [x] userHasLicenseForApp

#### Signals
- [x] duration_control
- [x] client_game_server_deny
- [x] encrypted_app_ticket_response
- [x] game_web_callback
- [x] get_auth_session_ticket_response
- [x] get_ticket_for_web_api
- [x] ipc_failure
- [x] licenses_updated
- [x] microtransaction_auth_response
- [x] steam_server_connect_failed
- [x] steam_server_connected
- [x] steam_server_disconnected
- [x] store_auth_url_response
- [x] validate_auth_ticket_response

#### Enums
- [ ] FailureType (missing in code)
- [x] DurationControlProgress
- [x] DurationControlNotification

### User Stats
#### Functions
- [x] attachLeaderboardUGC
- [x] clearAchievement
- [x] downloadLeaderboardEntries
- [x] downloadLeaderboardEntriesForUsers
- [x] findLeaderboard
- [x] findOrCreateLeaderboard
- [x] getAchievement
- [x] getAchievementAchievedPercent
- [x] getAchievementAndUnlockTime
- [x] getAchievementDisplayAttribute
- [x] getAchievementIcon
- [x] getAchievementName
- [x] getAchievementProgressLimitsFloat
- [x] getAchievementProgressLimitsInt
- [x] getGlobalStatFloat
- [x] getGlobalStatInt
- [x] getGlobalStatFloatHistory
- [x] getGlobalStatIntHistory
- [x] getLeaderboardDisplayType
- [x] getLeaderboardEntries
- [x] getLeaderboardEntryCount
- [x] getLeaderboardName
- [x] getLeaderboardSortMethod
- [x] getMostAchievedAchievementInfo
- [x] getNextMostAchievedAchievementInfo
- [x] getNumAchievements
- [x] getNumberOfCurrentPlayers
- [x] getStatFloat
- [x] getStatInt
- [x] getUserAchievement
- [x] getUserAchievementAndUnlockTime
- [x] getUserStatFloat
- [x] getUserStatInt
- [x] indicateAchievementProgress
- [x] requestCurrentStats
- [x] requestGlobalAchievementPercentages
- [x] requestGlobalStats
- [x] requestUserStats
- [x] resetAllStats
- [x] setAchievement
- [x] setLeaderboardDetailsMax
- [x] setStatFloat
- [x] setStatInt
- [x] storeStats
- [x] updateAvgRateStat
- [x] uploadLeaderboardScore

#### Signals
- [x] current_stats_received
- [x] global_achievement_percentages_ready
- [x] global_stats_received
- [x] leaderboard_find_result
- [x] leaderboard_scores_downloaded
- [x] leaderboard_score_uploaded
- [x] leaderboard_ugc_set
- [x] number_of_current_players
- [x] user_achievement_stored
- [x] user_stats_received
- [x] user_stats_stored
- [x] user_stats_unloaded

#### Enums
- [x] LeaderboardDataRequest
- [x] LeaderboardDisplayType
- [x] LeaderboardSortMethod
- [x] LeaderboardUploadScoreMethod
- [ ] SteamUserStatType (missing in code)

### Utils
#### Functions
- [x] filterText
- [x] getAPICallFailureReason
- [x] getAppID
- [x] getCurrentBatteryPower
- [x] getImageRGBA
- [x] getImageSize
- [x] getIPCCallCount
- [x] getIPCountry
- [x] getSecondsSinceAppActive
- [x] getSecondsSinceComputerActive
- [x] getServerRealTime
- [x] getSteamUILanguage
- [x] initFilterText
- [x] isAPICallCompleted
- [x] isOverlayEnabled
- [x] isSteamChinaLauncher
- [x] isSteamInBigPictureMode
- [x] isSteamRunningInVR
- [x] isSteamRunningOnSteamDeck
- [x] isVRHeadsetStreamingEnabled
- [x] overlayNeedsPresent
- [x] setGameLauncherMode
- [x] setOverlayNotificationInset
- [x] setOverlayNotificationPosition
- [x] setVRHeadsetStreamingEnabled
- [x] showGamepadTextInput
- [x] showFloatingGamepadTextInput
- [x] startVRDashboard

#### Signals
- [x] app_resuming_from_suspend
- [x] check_file_signature
- [x] filter_text_dictionary_changed
- [x] floating_gamepad_text_input_dismissed
- [x] gamepad_text_input_dismissed
- [x] ip_country
- [x] low_power
- [x] steam_api_call_completed
- [x] steam_shutdown

#### Enums
- [x] CheckFileSignature
- [x] GamepadTextInputLineMode
- [x] GamepadTextInputMode
- [x] FloatingGamepadTextInputMode
- [ ] SteamAPICallFailure (missing in code)
- [x] ApiCallFailure (mising in docs)
- [x] TextFilteringContext

### Video
#### Functions
- [x] getOPFSettings
- [x] getOPFStringForApp
- [x] getVideoURL
- [x] isBroadcasting

#### Signals
- [x] get_opf_settings_result
- [x] get_video_result