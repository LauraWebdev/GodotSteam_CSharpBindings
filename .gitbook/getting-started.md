# Getting Started

### Installation

1. Make sure you have set up GodotSteam GDExtension. You can get it either from the GitHub Releases or the Godot AssetLib.
2. Copy the `/addons/godotsteam_csharpbindings` folder into your project. Alternatively, you can download "GodotSteam C# Bindings" from the Godot AssetLib or just drop in the latest GitHub Release.
3. Now build your C# solution in JetBrains Rider.



### Getting Started

Once everything is set up properly, you can test C# Bindings with this initial example script:

```csharp
using Godot;
using GodotSteam;

public partial class SteamDemo : Node
{
	private const uint AppId = 480;

	public override void _EnterTree()
	{
		OS.SetEnvironment("SteamAppId", AppId.ToString());
		OS.SetEnvironment("SteamGameId", AppId.ToString());
	}

	public override void _Ready()
	{
		Steam.SteamInit();

		var isSteamRunning = Steam.IsSteamRunning();
		if (!isSteamRunning)
		{
			GD.Print("Steam is not running.");
			return;
		}
		
		var steamId = Steam.GetSteamID();
		var name = Steam.GetFriendPersonaName(steamId);	
        
		GD.Print("Your Steam Name: " + name);
	}
}
```



### Signals & Events

This project aims to create a familiar developer experience for C# developers. Thus, GDScript signals emitted from GodotSteam are available as events which can be subscribed to.

```csharp
Steam.SteamworksError += (failedSignal, iOFailure) =>
{
    GD.PrintErr(failedSignal);
    GD.PrintErr(iOFailure);
};
```

```csharp
Steam.AvatarLoaded += (id, size, data) =>
{
    // Use id/size/data
};
```
