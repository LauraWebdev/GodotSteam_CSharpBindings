using Godot;
using GodotSteam;

public partial class Demo : CanvasLayer
{
	private const uint AppId = 480;

	[Export] public PlayerInfo PlayerInfo;
	[Export] public Status Status;
	[Export] public FriendsContainer FriendsContainer;

	private bool _isSteamRunning;

	public override void _EnterTree()
	{
		OS.SetEnvironment("SteamAppId", AppId.ToString());
		OS.SetEnvironment("SteamGameId", AppId.ToString());
		
		Steam.SteamInit();
	}
}
