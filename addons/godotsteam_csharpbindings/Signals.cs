using Godot;

namespace GodotSteam;

/// <summary>

/// The signals class

/// </summary>

public static class Signals
{
    /// <summary>
    /// The steamworks error
    /// </summary>
    public static readonly StringName SteamworksError = "steamworks_error";
    /// <summary>
    /// The file details result
    /// </summary>
    public static readonly StringName FileDetailsResult = "file_details_result";
    /// <summary>
    /// The dlc installed
    /// </summary>
    public static readonly StringName DlcInstalled = "dlc_installed";
    /// <summary>
    /// The new launch url parameters
    /// </summary>
    public static readonly StringName NewLaunchUrlParameters = "new_launch_url_parameters";
    /// <summary>
    /// The timed trial status
    /// </summary>
    public static readonly StringName TimedTrialStatus = "timed_trial_status";
    /// <summary>
    /// The app installed
    /// </summary>
    public static readonly StringName AppInstalled = "app_installed";
    /// <summary>
    /// The app uninstalled
    /// </summary>
    public static readonly StringName AppUninstalled = "app_uninstalled";
    /// <summary>
    /// The avatar loaded
    /// </summary>
    public static readonly StringName AvatarLoaded = "avatar_loaded";
    /// <summary>
    /// The avatar image loaded
    /// </summary>
    public static readonly StringName AvatarImageLoaded = "avatar_image_loaded";
    /// <summary>
    /// The request clan officer list signal
    /// </summary>
    public static readonly StringName RequestClanOfficerListSignal = "request_clan_officer_list";
    /// <summary>
    /// The clan activity downloaded
    /// </summary>
    public static readonly StringName ClanActivityDownloaded = "clan_activity_downloaded";
    /// <summary>
    /// The friend rich presence update
    /// </summary>
    public static readonly StringName FriendRichPresenceUpdate = "friend_rich_presence_update";
    /// <summary>
    /// The enumerate following list signal
    /// </summary>
    public static readonly StringName EnumerateFollowingListSignal = "enumerate_following_list";
    /// <summary>
    /// The get follower count signal
    /// </summary>
    public static readonly StringName GetFollowerCountSignal = "get_follower_count";
    /// <summary>
    /// The is following signal
    /// </summary>
    public static readonly StringName IsFollowingSignal = "is_following";
    /// <summary>
    /// The connected chat join
    /// </summary>
    public static readonly StringName ConnectedChatJoin = "connected_chat_join";
    /// <summary>
    /// The connected chat leave
    /// </summary>
    public static readonly StringName ConnectedChatLeave = "connected_chat_leave";
    /// <summary>
    /// The connected clan chat message
    /// </summary>
    public static readonly StringName ConnectedClanChatMessage = "connected_clan_chat_message";
    /// <summary>
    /// The connected friend chat message
    /// </summary>
    public static readonly StringName ConnectedFriendChatMessage = "connected_friend_chat_message";
    /// <summary>
    /// The join requested
    /// </summary>
    public static readonly StringName JoinRequested = "join_requested";
    /// <summary>
    /// The overlay toggled
    /// </summary>
    public static readonly StringName OverlayToggled = "overlay_toggled";
    /// <summary>
    /// The join game requested
    /// </summary>
    public static readonly StringName JoinGameRequested = "join_game_requested";
    /// <summary>
    /// The change server requested
    /// </summary>
    public static readonly StringName ChangeServerRequested = "change_server_requested";
    /// <summary>
    /// The join clan chat complete
    /// </summary>
    public static readonly StringName JoinClanChatComplete = "join_clan_chat_complete";
    /// <summary>
    /// The persona state change
    /// </summary>
    public static readonly StringName PersonaStateChange = "persona_state_change";
    /// <summary>
    /// The name changed
    /// </summary>
    public static readonly StringName NameChanged = "name_changed";
    /// <summary>
    /// The overlay browser protocol
    /// </summary>
    public static readonly StringName OverlayBrowserProtocol = "overlay_browser_protocol";
    /// <summary>
    /// The unread chat messages changed
    /// </summary>
    public static readonly StringName UnreadChatMessagesChanged = "unread_chat_messages_changed";
    /// <summary>
    /// The equipped profile items changed
    /// </summary>
    public static readonly StringName EquippedProfileItemsChanged = "equipped_profile_items_changed";
    /// <summary>
    /// The equipped profile items
    /// </summary>
    public static readonly StringName EquippedProfileItems = "equipped_profile_items";
    /// <summary>
    /// The search for game progress
    /// </summary>
    public static readonly StringName SearchForGameProgress = "search_for_game_progress";
    /// <summary>
    /// The search for game result
    /// </summary>
    public static readonly StringName SearchForGameResult = "search_for_game_result";
    /// <summary>
    /// The request players for game progress
    /// </summary>
    public static readonly StringName RequestPlayersForGameProgress = "request_players_for_game_progress";
    /// <summary>
    /// The request players for game result
    /// </summary>
    public static readonly StringName RequestPlayersForGameResult = "request_players_for_game_result";
    /// <summary>
    /// The request players for game final result
    /// </summary>
    public static readonly StringName RequestPlayersForGameFinalResult = "request_players_for_game_final_result";
    /// <summary>
    /// The submit player result signal
    /// </summary>
    public static readonly StringName SubmitPlayerResultSignal = "submit_player_result";
    /// <summary>
    /// The end game result
    /// </summary>
    public static readonly StringName EndGameResult = "end_game_result";
    /// <summary>
    /// The html browser ready
    /// </summary>
    public static readonly StringName HtmlBrowserReady = "html_browser_ready";
    /// <summary>
    /// The html can go backandforward
    /// </summary>
    public static readonly StringName HtmlCanGoBackandforward = "html_can_go_backandforward";
    /// <summary>
    /// The html changed title
    /// </summary>
    public static readonly StringName HtmlChangedTitle = "html_changed_title";
    /// <summary>
    /// The html close browser
    /// </summary>
    public static readonly StringName HtmlCloseBrowser = "html_close_browser";
    /// <summary>
    /// The html file open dialog
    /// </summary>
    public static readonly StringName HtmlFileOpenDialog = "html_file_open_dialog";
    /// <summary>
    /// The html finished request
    /// </summary>
    public static readonly StringName HtmlFinishedRequest = "html_finished_request";
    /// <summary>
    /// The html hide tooltip
    /// </summary>
    public static readonly StringName HtmlHideTooltip = "html_hide_tooltip";
    /// <summary>
    /// The html horizontal scroll
    /// </summary>
    public static readonly StringName HtmlHorizontalScroll = "html_horizontal_scroll";
    /// <summary>
    /// The html js alert
    /// </summary>
    public static readonly StringName HtmlJsAlert = "html_js_alert";
    /// <summary>
    /// The html js confirm
    /// </summary>
    public static readonly StringName HtmlJsConfirm = "html_js_confirm";
    /// <summary>
    /// The html link at position
    /// </summary>
    public static readonly StringName HtmlLinkAtPosition = "html_link_at_position";
    /// <summary>
    /// The html needs paint
    /// </summary>
    public static readonly StringName HtmlNeedsPaint = "html_needs_paint";
    /// <summary>
    /// The html new window
    /// </summary>
    public static readonly StringName HtmlNewWindow = "html_new_window";
    /// <summary>
    /// The html open link in new tab
    /// </summary>
    public static readonly StringName HtmlOpenLinkInNewTab = "html_open_link_in_new_tab";
    /// <summary>
    /// The html search results
    /// </summary>
    public static readonly StringName HtmlSearchResults = "html_search_results";
    /// <summary>
    /// The html set cursor
    /// </summary>
    public static readonly StringName HtmlSetCursor = "html_set_cursor";
    /// <summary>
    /// The html show tooltip
    /// </summary>
    public static readonly StringName HtmlShowTooltip = "html_show_tooltip";
    /// <summary>
    /// The html start request
    /// </summary>
    public static readonly StringName HtmlStartRequest = "html_start_request";
    /// <summary>
    /// The html status text
    /// </summary>
    public static readonly StringName HtmlStatusText = "html_status_text";
    /// <summary>
    /// The html update tooltip
    /// </summary>
    public static readonly StringName HtmlUpdateTooltip = "html_update_tooltip";
    /// <summary>
    /// The html url changed
    /// </summary>
    public static readonly StringName HtmlUrlChanged = "html_url_changed";
    /// <summary>
    /// The html vertical scroll
    /// </summary>
    public static readonly StringName HtmlVerticalScroll = "html_vertical_scroll";
    /// <summary>
    /// The http request completed
    /// </summary>
    public static readonly StringName HttpRequestCompleted = "http_request_completed";
    /// <summary>
    /// The http request data received
    /// </summary>
    public static readonly StringName HttpRequestDataReceived = "http_request_data_received";
    /// <summary>
    /// The http request headers received
    /// </summary>
    public static readonly StringName HttpRequestHeadersReceived = "http_request_headers_received";
    /// <summary>
    /// The input action event
    /// </summary>
    public static readonly StringName InputActionEvent = "input_action_event";
    /// <summary>
    /// The input device connected
    /// </summary>
    public static readonly StringName InputDeviceConnected = "input_device_connected";
    /// <summary>
    /// The input device disconnected
    /// </summary>
    public static readonly StringName InputDeviceDisconnected = "input_device_disconnected";
    /// <summary>
    /// The input configuration loaded
    /// </summary>
    public static readonly StringName InputConfigurationLoaded = "input_configuration_loaded";
    /// <summary>
    /// The input gamepad slot change
    /// </summary>
    public static readonly StringName InputGamepadSlotChange = "input_gamepad_slot_change";
    /// <summary>
    /// The inventory definition update
    /// </summary>
    public static readonly StringName InventoryDefinitionUpdate = "inventory_definition_update";
    /// <summary>
    /// The inventory eligible promo item
    /// </summary>
    public static readonly StringName InventoryEligiblePromoItem = "inventory_eligible_promo_item";
    /// <summary>
    /// The inventory full update
    /// </summary>
    public static readonly StringName InventoryFullUpdate = "inventory_full_update";
    /// <summary>
    /// The inventory result ready
    /// </summary>
    public static readonly StringName InventoryResultReady = "inventory_result_ready";
    /// <summary>
    /// The inventory start purchase result
    /// </summary>
    public static readonly StringName InventoryStartPurchaseResult = "inventory_start_purchase_result";
    /// <summary>
    /// The inventory request prices result
    /// </summary>
    public static readonly StringName InventoryRequestPricesResult = "inventory_request_prices_result";
    /// <summary>
    /// The favorites list accounts updated
    /// </summary>
    public static readonly StringName FavoritesListAccountsUpdated = "favorites_list_accounts_updated";
    /// <summary>
    /// The favorites list changed
    /// </summary>
    public static readonly StringName FavoritesListChanged = "favorites_list_changed";
    /// <summary>
    /// The lobby message
    /// </summary>
    public static readonly StringName LobbyMessage = "lobby_message";
    /// <summary>
    /// The lobby chat update
    /// </summary>
    public static readonly StringName LobbyChatUpdate = "lobby_chat_update";
    /// <summary>
    /// The lobby created
    /// </summary>
    public static readonly StringName LobbyCreated = "lobby_created";
    /// <summary>
    /// The lobby data update
    /// </summary>
    public static readonly StringName LobbyDataUpdate = "lobby_data_update";
    /// <summary>
    /// The lobby joined
    /// </summary>
    public static readonly StringName LobbyJoined = "lobby_joined";
    /// <summary>
    /// The lobby game created
    /// </summary>
    public static readonly StringName LobbyGameCreated = "lobby_game_created";
    /// <summary>
    /// The lobby invite
    /// </summary>
    public static readonly StringName LobbyInvite = "lobby_invite";
    /// <summary>
    /// The lobby match list
    /// </summary>
    public static readonly StringName LobbyMatchList = "lobby_match_list";
    /// <summary>
    /// The lobby kicked
    /// </summary>
    public static readonly StringName LobbyKicked = "lobby_kicked";
    /// <summary>
    /// The server responded
    /// </summary>
    public static readonly StringName ServerResponded = "server_responded";
    /// <summary>
    /// The server failed to respond
    /// </summary>
    public static readonly StringName ServerFailedToRespond = "server_failed_to_respond";
    /// <summary>
    /// The music player remote to front
    /// </summary>
    public static readonly StringName MusicPlayerRemoteToFront = "music_player_remote_to_front";
    /// <summary>
    /// The music player remote will activate
    /// </summary>
    public static readonly StringName MusicPlayerRemoteWillActivate = "music_player_remote_will_activate";
    /// <summary>
    /// The music player remote will deactivate
    /// </summary>
    public static readonly StringName MusicPlayerRemoteWillDeactivate = "music_player_remote_will_deactivate";
    /// <summary>
    /// The music player selects playlist entry
    /// </summary>
    public static readonly StringName MusicPlayerSelectsPlaylistEntry = "music_player_selects_playlist_entry";
    /// <summary>
    /// The music player selects queue entry
    /// </summary>
    public static readonly StringName MusicPlayerSelectsQueueEntry = "music_player_selects_queue_entry";
    /// <summary>
    /// The music player wants looped
    /// </summary>
    public static readonly StringName MusicPlayerWantsLooped = "music_player_wants_looped";
    /// <summary>
    /// The music player wants pause
    /// </summary>
    public static readonly StringName MusicPlayerWantsPause = "music_player_wants_pause";
    /// <summary>
    /// The music player wants playing repeat status
    /// </summary>
    public static readonly StringName MusicPlayerWantsPlayingRepeatStatus = "music_player_wants_playing_repeat_status";
    /// <summary>
    /// The music player wants play next
    /// </summary>
    public static readonly StringName MusicPlayerWantsPlayNext = "music_player_wants_play_next";
    /// <summary>
    /// The music player wants play previous
    /// </summary>
    public static readonly StringName MusicPlayerWantsPlayPrevious = "music_player_wants_play_previous";
    /// <summary>
    /// The music player wants play
    /// </summary>
    public static readonly StringName MusicPlayerWantsPlay = "music_player_wants_play";
    /// <summary>
    /// The music player wants shuffled
    /// </summary>
    public static readonly StringName MusicPlayerWantsShuffled = "music_player_wants_shuffled";
    /// <summary>
    /// The music player wants volume
    /// </summary>
    public static readonly StringName MusicPlayerWantsVolume = "music_player_wants_volume";
    /// <summary>
    /// The music player will quit
    /// </summary>
    public static readonly StringName MusicPlayerWillQuit = "music_player_will_quit";
    /// <summary>
    /// The session request
    /// </summary>
    public static readonly StringName P2PSessionRequest = "p2p_session_request";
    /// <summary>
    /// The session connect fail
    /// </summary>
    public static readonly StringName P2PSessionConnectFail = "p2p_session_connect_fail";
    /// <summary>
    /// The network messages session request
    /// </summary>
    public static readonly StringName NetworkMessagesSessionRequest = "network_messages_session_request";
    /// <summary>
    /// The network messages session failed
    /// </summary>
    public static readonly StringName NetworkMessagesSessionFailed = "network_messages_session_failed";
    /// <summary>
    /// The network connection status changed
    /// </summary>
    public static readonly StringName NetworkConnectionStatusChanged = "network_connection_status_changed";
    /// <summary>
    /// The network authentication status
    /// </summary>
    public static readonly StringName NetworkAuthenticationStatus = "network_authentication_status";
    /// <summary>
    /// The fake ip result
    /// </summary>
    public static readonly StringName FakeIPResult = "fake_ip_result";
    /// <summary>
    /// The relay network status
    /// </summary>
    public static readonly StringName RelayNetworkStatus = "relay_network_status";
    /// <summary>
    /// The parental setting changed
    /// </summary>
    public static readonly StringName ParentalSettingChanged = "parental_setting_changed";
    /// <summary>
    /// The join party signal
    /// </summary>
    public static readonly StringName JoinPartySignal = "join_party";
    /// <summary>
    /// The create beacon signal
    /// </summary>
    public static readonly StringName CreateBeaconSignal = "create_beacon";
    /// <summary>
    /// The reservation notification
    /// </summary>
    public static readonly StringName ReservationNotification = "reservation_notification";
    /// <summary>
    /// The change num open slots signal
    /// </summary>
    public static readonly StringName ChangeNumOpenSlotsSignal = "change_num_open_slots";
    /// <summary>
    /// The available beacon locations updated
    /// </summary>
    public static readonly StringName AvailableBeaconLocationsUpdated = "available_beacon_locations_updated";
    /// <summary>
    /// The active beacons updated
    /// </summary>
    public static readonly StringName ActiveBeaconsUpdated = "active_beacons_updated";
    /// <summary>
    /// The remote play session connected
    /// </summary>
    public static readonly StringName RemotePlaySessionConnected = "remote_play_session_connected";
    /// <summary>
    /// The remote play session disconnected
    /// </summary>
    public static readonly StringName RemotePlaySessionDisconnected = "remote_play_session_disconnected";
    /// <summary>
    /// The file read async complete
    /// </summary>
    public static readonly StringName FileReadAsyncComplete = "file_read_async_complete";
    /// <summary>
    /// The file share result
    /// </summary>
    public static readonly StringName FileShareResult = "file_share_result";
    /// <summary>
    /// The file write async complete
    /// </summary>
    public static readonly StringName FileWriteAsyncComplete = "file_write_async_complete";
    /// <summary>
    /// The download ugc result
    /// </summary>
    public static readonly StringName DownloadUgcResult = "download_ugc_result";
    /// <summary>
    /// The unsubscribe item signal
    /// </summary>
    public static readonly StringName UnsubscribeItemSignal = "unsubscribe_item";
    /// <summary>
    /// The subscribe item signal
    /// </summary>
    public static readonly StringName SubscribeItemSignal = "subscribe_item";
    /// <summary>
    /// The local file changed
    /// </summary>
    public static readonly StringName LocalFileChanged = "local_file_changed";
    /// <summary>
    /// The screenshot ready
    /// </summary>
    public static readonly StringName ScreenshotReady = "screenshot_ready";
    /// <summary>
    /// The screenshot requested
    /// </summary>
    public static readonly StringName ScreenshotRequested = "screenshot_requested";
    /// <summary>
    /// The add app dependency result
    /// </summary>
    public static readonly StringName AddAppDependencyResult = "add_app_dependency_result";
    /// <summary>
    /// The add ugc dependency result
    /// </summary>
    public static readonly StringName AddUgcDependencyResult = "add_ugc_dependency_result";
    /// <summary>
    /// The item created
    /// </summary>
    public static readonly StringName ItemCreated = "item_created";
    /// <summary>
    /// The item downloaded
    /// </summary>
    public static readonly StringName ItemDownloaded = "item_downloaded";
    /// <summary>
    /// The get app dependencies result
    /// </summary>
    public static readonly StringName GetAppDependenciesResult = "get_app_dependencies_result";
    /// <summary>
    /// The item deleted
    /// </summary>
    public static readonly StringName ItemDeleted = "item_deleted";
    /// <summary>
    /// The get item vote result
    /// </summary>
    public static readonly StringName GetItemVoteResult = "get_item_vote_result";
    /// <summary>
    /// The item installed
    /// </summary>
    public static readonly StringName ItemInstalled = "item_installed";
    /// <summary>
    /// The remove app dependency result
    /// </summary>
    public static readonly StringName RemoveAppDependencyResult = "remove_app_dependency_result";
    /// <summary>
    /// The remove ugc dependency result
    /// </summary>
    public static readonly StringName RemoveUgcDependencyResult = "remove_ugc_dependency_result";
    /// <summary>
    /// The set user item vote signal
    /// </summary>
    public static readonly StringName SetUserItemVoteSignal = "set_user_item_vote";
    /// <summary>
    /// The start playtime tracking signal
    /// </summary>
    public static readonly StringName StartPlaytimeTrackingSignal = "start_playtime_tracking";
    /// <summary>
    /// The ugc query completed
    /// </summary>
    public static readonly StringName UgcQueryCompleted = "ugc_query_completed";
    /// <summary>
    /// The stop playtime tracking signal
    /// </summary>
    public static readonly StringName StopPlaytimeTrackingSignal = "stop_playtime_tracking";
    /// <summary>
    /// The item updated
    /// </summary>
    public static readonly StringName ItemUpdated = "item_updated";
    /// <summary>
    /// The user favorite items list changed
    /// </summary>
    public static readonly StringName UserFavoriteItemsListChanged = "user_favorite_items_list_changed";
    /// <summary>
    /// The workshop eula status
    /// </summary>
    public static readonly StringName WorkshopEulaStatus = "workshop_eula_status";
    /// <summary>
    /// The user subscribed items list changed
    /// </summary>
    public static readonly StringName UserSubscribedItemsListChanged = "user_subscribed_items_list_changed";
    /// <summary>
    /// The client game server deny
    /// </summary>
    public static readonly StringName ClientGameServerDeny = "client_game_server_deny";
    /// <summary>
    /// The duration control
    /// </summary>
    public static readonly StringName DurationControl = "duration_control";
    /// <summary>
    /// The encrypted app ticket response
    /// </summary>
    public static readonly StringName EncryptedAppTicketResponse = "encrypted_app_ticket_response";
    /// <summary>
    /// The game web callback
    /// </summary>
    public static readonly StringName GameWebCallback = "game_web_callback";
    /// <summary>
    /// The get auth session ticket response
    /// </summary>
    public static readonly StringName GetAuthSessionTicketResponse = "get_auth_session_ticket_response";
    /// <summary>
    /// The get ticket for web api
    /// </summary>
    public static readonly StringName GetTicketForWebApi = "get_ticket_for_web_api";
    /// <summary>
    /// The ipc failure
    /// </summary>
    public static readonly StringName IpcFailure = "ipc_failure";
    /// <summary>
    /// The licenses updated
    /// </summary>
    public static readonly StringName LicensesUpdated = "licenses_updated";
    /// <summary>
    /// The microtransaction auth response
    /// </summary>
    public static readonly StringName MicrotransactionAuthResponse = "microtransaction_auth_response";
    /// <summary>
    /// The steam server connect failed
    /// </summary>
    public static readonly StringName SteamServerConnectFailed = "steam_server_connect_failed";
    /// <summary>
    /// The steam server connected
    /// </summary>
    public static readonly StringName SteamServerConnected = "steam_server_connected";
    /// <summary>
    /// The steam server disconnected
    /// </summary>
    public static readonly StringName SteamServerDisconnected = "steam_server_disconnected";
    /// <summary>
    /// The store auth url response
    /// </summary>
    public static readonly StringName StoreAuthUrlResponse = "store_auth_url_response";
    /// <summary>
    /// The validate auth ticket response
    /// </summary>
    public static readonly StringName ValidateAuthTicketResponse = "validate_auth_ticket_response";
    /// <summary>
    /// The global achievement percentages ready
    /// </summary>
    public static readonly StringName GlobalAchievementPercentagesReady = "global_achievement_percentages_ready";
    /// <summary>
    /// The global stats received
    /// </summary>
    public static readonly StringName GlobalStatsReceived = "global_stats_received";
    /// <summary>
    /// The leaderboard find result
    /// </summary>
    public static readonly StringName LeaderboardFindResult = "leaderboard_find_result";
    /// <summary>
    /// The leaderboard scores downloaded
    /// </summary>
    public static readonly StringName LeaderboardScoresDownloaded = "leaderboard_scores_downloaded";
    /// <summary>
    /// The leaderboard score uploaded
    /// </summary>
    public static readonly StringName LeaderboardScoreUploaded = "leaderboard_score_uploaded";
    /// <summary>
    /// The leaderboard ugc set
    /// </summary>
    public static readonly StringName LeaderboardUgcSet = "leaderboard_ugc_set";
    /// <summary>
    /// The number of current players
    /// </summary>
    public static readonly StringName NumberOfCurrentPlayers = "number_of_current_players";
    /// <summary>
    /// The user achievement stored
    /// </summary>
    public static readonly StringName UserAchievementStored = "user_achievement_stored";
    /// <summary>
    /// The current stats received
    /// </summary>
    public static readonly StringName CurrentStatsReceived = "current_stats_received";
    /// <summary>
    /// The user stats received
    /// </summary>
    public static readonly StringName UserStatsReceived = "user_stats_received";
    /// <summary>
    /// The user stats stored
    /// </summary>
    public static readonly StringName UserStatsStored = "user_stats_stored";
    /// <summary>
    /// The user stats unloaded
    /// </summary>
    public static readonly StringName UserStatsUnloaded = "user_stats_unloaded";
    /// <summary>
    /// The check file signature
    /// </summary>
    public static readonly StringName CheckFileSignature = "check_file_signature";
    /// <summary>
    /// The gamepad text input dismissed
    /// </summary>
    public static readonly StringName GamepadTextInputDismissed = "gamepad_text_input_dismissed";
    /// <summary>
    /// The ip country
    /// </summary>
    public static readonly StringName IPCountry = "ip_country";
    /// <summary>
    /// The low power
    /// </summary>
    public static readonly StringName LowPower = "low_power";
    /// <summary>
    /// The steam api call completed
    /// </summary>
    public static readonly StringName SteamApiCallCompleted = "steam_api_call_completed";
    /// <summary>
    /// The steam shutdown signal
    /// </summary>
    public static readonly StringName SteamShutdownSignal = "steam_shutdown";
    /// <summary>
    /// The app resuming from suspend
    /// </summary>
    public static readonly StringName AppResumingFromSuspend = "app_resuming_from_suspend";
    /// <summary>
    /// The floating gamepad text input dismissed
    /// </summary>
    public static readonly StringName FloatingGamepadTextInputDismissed = "floating_gamepad_text_input_dismissed";
    /// <summary>
    /// The filter text dictionary changed
    /// </summary>
    public static readonly StringName FilterTextDictionaryChanged = "filter_text_dictionary_changed";
    /// <summary>
    /// The get opf settings result
    /// </summary>
    public static readonly StringName GetOpfSettingsResult = "get_opf_settings_result";
    /// <summary>
    /// The get video result
    /// </summary>
    public static readonly StringName GetVideoResult = "get_video_result";
}