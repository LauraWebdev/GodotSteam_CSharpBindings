@tool
class_name GodotSteamPlugin
extends EditorPlugin

const EDITOR_PANEL = preload("uid://cyniebd6yahu5")

static var dock_frame

var link_changelog: String = "[url=https://godotsteam.com/changelog/gdextension/]changelog[/url]"
var link_website: String = "[url=https://godotsteam.com]website[/url]"
var steamworks_dock: Control


## Used specifically to add/remove additional dock content
static func get_dock_frame() -> Control:
	return dock_frame


func _enable_plugin() -> void:
	print("GodotSteam GDExtension updater functionality enabled")


func _disable_plugin() -> void:
	print("GodotSteam GDEXtension updater functionality disabled")


func _enter_tree() -> void:
	print_rich("GodotSteam v%s | %s | %s" % [Steam.get_godotsteam_version(), link_website, link_changelog])
	add_project_settings()
	add_steamworks_dock()


func _exit_tree() -> void:
	remove_steamworks_dock()


func _make_visible(visible) -> void:
	if steamworks_dock:
		steamworks_dock.set_visible(visible)


#region Add and remove things
func add_project_settings() -> void:
	# Used for the Updater looking for redist files and SteamCMD
	if not ProjectSettings.has_setting("steam/updates/godotsteam/check_for_updates"):
		ProjectSettings.set_setting("steam/updates/godotsteam/check_for_updates", true)
	ProjectSettings.add_property_info({
		"name": "steam/updates/godotsteam/check_for_updates",
		"type": TYPE_BOOL
	})
	ProjectSettings.set_initial_value("steam/updates/godotsteam/check_for_updates", true)
	ProjectSettings.set_as_basic("steam/updates/godotsteam/check_for_updates", true)
	# Which channel of updates to pull from
	# Sponsors repo should require the user to have access to that repository already
	# In theory, they can connect via SSH?
	if not ProjectSettings.has_setting("steam/updates/godotsteam/update_channel"):
		ProjectSettings.set_setting("steam/updates/godotsteam/update_channel", 0)
	ProjectSettings.add_property_info({
		"name": "steam/updates/godotsteam/update_channel",
		"type": TYPE_INT,
		"hint": PROPERTY_HINT_ENUM,
		"hint_string": "Community, Sponsors"
	})
	ProjectSettings.set_initial_value("steam/updates/godotsteam/update_channel", 0)
	ProjectSettings.set_as_basic("steam/updates/godotsteam/update_channel", true)


func add_steamworks_dock() -> void:
	steamworks_dock = EDITOR_PANEL.instantiate()
	# This will be used when 4.4.x is deprecated
	#add_control_to_dock(DockSlot.DOCK_SLOT_BOTTOM, steamworks_dock)
	# This is deprecated as of 4.6; when it is removed then 4.4.x will be deprecated for GodotSteam
	add_control_to_bottom_panel(steamworks_dock, "Steamworks")
	dock_frame = steamworks_dock


func remove_steamworks_dock() -> void:
	# This will be used when 4.4.x is deprecated
	#remove_control_from_docks(steamworks_dock)
	# This is deprecated as of 4.6; when it is removed then 4.4.x will be deprecated for GodotSteam
	remove_control_from_bottom_panel(steamworks_dock)
	# This may be causing crashes for some people and is unnecessary with the call above
	# steamworks_dock.queue_free()
	steamworks_dock = null
	dock_frame = null
#endregion