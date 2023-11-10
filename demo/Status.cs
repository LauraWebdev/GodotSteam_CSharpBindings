using Godot;
using GodotSteam;

public partial class Status : PanelContainer
{
	[Export] public Label SteamStatus;

	public override void _EnterTree()
	{
		Modulate = Colors.Transparent;
	}

	public override void _Ready()
	{
		var isSteamRunning = Steam.IsSteamRunning();
		
		Modulate = isSteamRunning ? Colors.Green : Colors.Red;
		SteamStatus.Text = isSteamRunning ? "Steam is running" : "Steam is not running";
	}
}
