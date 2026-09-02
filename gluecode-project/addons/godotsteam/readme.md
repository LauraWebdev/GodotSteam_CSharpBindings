# GodotSteam for GDExtension | Community Edition
An ecosystem of tools for [Godot Engine](https://godotengine.org) and [Valve's Steam](https://store.steampowered.com). For the Windows, Linux, and Mac platforms.


Additional Flavors
---
Standard Module | Standard Plug-ins | Server Module | Server Plug-ins | Tools | Examples
--- | --- | --- | --- | --- | ---
[Godot 2.x](https://codeberg.org/godotsteam/godotsteam/src/branch/godot2) | [GDNative](https://codeberg.org/godotsteam/godotsteam/src/branch/gdnative) | [Server 3.x](https://codeberg.org/godotsteam/godotsteam-server/src/branch/godot3) | [GDNative](https://codeberg.org/godotsteam/godotsteam-server/src/branch/gdnative) | [GodotSteamKit](https://godotsteam.com/projects/godotsteamkit) | [Skillet](https://codeberg.org/godotsteam/skillet)
[Godot 3.x](https://codeberg.org/godotsteam/godotsteam/src/branch/godot3) | [GDExtension](https://codeberg.org/godotsteam/godotsteam/src/branch/gdextension) | [Server 4.x](https://codeberg.org/godotsteam/godotsteam-server/src/branch/godot4) | [GDExtension](https://codeberg.org/godotsteam/godotsteam-server/src/branch/gdextension) | --- | [Skillet UGC Editor](https://codeberg.org/godotsteam/skillet/src/branch/ugc_editor)
[Godot 4.x](https://codeberg.org/godotsteam/godotsteam/src/branch/godot4) | --- | --- | --- | --- | ---
[MultiplayerPeer](https://codeberg.org/godotsteam/multiplayerpeer)| --- | --- | --- | --- | ---


Documentation
---
[Documentation is available here](https://godotsteam.com).  You can also check out the Search Help section inside Godot Engine.  [To start, try checking out our tutorial on initializing Steam.](https://godotsteam.com/tutorials/initializing/)  There are additional tutorials, with more in the works.  You can also [check out additional Godot and Steam related videos, text, additional tools, plug-ins, etc. here.](https://godotsteam.com/resources/external/)

Feel free to chat with us about GodotSteam or ask for assistance on the [Stoat server](https://stt.gg/9DxQ3Dcd) or [IRC on Libera Chat](irc://irc.libera.chat/#godotsteam).


Donate
---
Pull-requests are the best way to help the project out but you can also donate through [Github Sponsors](https://github.com/sponsors/Gramps) or [LiberaPay](https://liberapay.com/godotsteam/donate)! [You can read more about donor perks here.](https://godotsteam.com/contribute/donations/)  [You can also view all our awesome donors here.](https://godotsteam.com/contribute/donors/)


Current Build
---
You can [download pre-compiled versions of this repo here](https://codeberg.org/godotsteam/godotsteam/releases).

**Version 4.22 Changes**

- Added: pre-commit static checks, ***thanks to false***
- Changed: merged GDExtension branch into Godot 4, ***thanks to fales***
- Changed: improvements to the build system, ***thanks to fales***
- Changed: revised small bits of code
- Removed: automatic API fix for Windows as it will not run due to failing to load

[You can read more change-logs here](https://godotsteam.com/changelog/godot4/).


Compatibility
---
While rare, sometimes Steamworks SDK updates will break compatibility with older GodotSteam versions. Any compatibility breaks are noted below. Newer API files (dll, so, dylib) _should_ still work for older versions.

Steamworks SDK Version | GodotSteam Version
---|---
1.65 | 4.21 or newer
1.63 to 1.64 | 4.17 to 4.20.1
1.62 | 4.14 to 4.16.2
1.61 | 4.12 to 4.13
1.60 | 4.6 to 4.11
1.59 | 4.6 to 4.8
1.58a or older | 4.5.4 or older

Versions of GodotSteam that have compatibility breaks introduced.

GodotSteam Version | Broken Compatibility
---|---
4.8 | Networking identity system removed, replaced with Steam IDs
4.9 | sendMessages returns an Array
4.11 | setLeaderboardDetailsMax removed
4.13 | getItemDefinitionProperty return a dictionary, html_needs_paint key 'bgra' changed to 'rbga'
4.14 | Removed first argument for stat request in steamInit and steamInitEx, steamInit returns intended bool value
4.16 | Variety of small break points, refer to [4.16 changelog for details](https://godotsteam.com/changelog/godot4/#version-416)
4.17 | Windows projects using Steam SDK 1.63 are meant to work with Proton 11 or Experimental on Linux / Steam Deck.
4.19 | Lots of changes to Voice functions, refer to [4.19 changelog for details](https://godotsteam.com/changelog/godot4/#version-419)
4.20 | Godot 4.7 changed callable_method_pointer.h to callable_mp.h which will break backwards compatibility
4.21 | ControllerPad enum changed to SteamControllerPad enum, SendMessages added new parameter


Known Issues
---
- Steam Overlay ***may not*** work when running your game from Godot but the exported project should work perfectly fine in the Steam client. [Read more.](https://godotsteam.com/issues/common_issues/#steam-overlay)
- If using the Steam version of Godot on Windows, you may need to manually update Godot's steam_api64.dll or steam_api.dll with GodotSteam's version as it is sometimes outdated and may cause the plug-in to fail to load. [Read more.](https://godotsteam.com/issues/windows_issues/#failure-to-load-steam-version)


No LLM Policy / No "AI" Policy
---
No LLMs are allowed to be used for issues, patches, or pull-requests.  They will be closed or rejected and the submitter may be blocked from future submissions.


License
---
MIT license
