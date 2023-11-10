using Godot;
using GodotSteam;

public partial class FriendItem : PanelContainer
{
	[Export] public Panel PlayerStatus;
	[Export] public Label PlayerName;
	[Export] public Label PlayerLevel;

	public void SetFriendAndLevel(Friend friend, int level)
	{
		PlayerName.Text = friend.Name;
		PlayerLevel.Text = "Level " + level;

		var stylebox = (StyleBoxFlat)PlayerStatus.GetThemeStylebox("panel").Duplicate();
		stylebox.BgColor = GetStatusColor(friend.Status);
		PlayerStatus.AddThemeStyleboxOverride("panel", stylebox);
	}

	private Color GetStatusColor(Steam.PersonaState personaState)
	{
		switch (personaState)
		{
			case Steam.PersonaState.Busy:
				return new Color("#872032");
			case Steam.PersonaState.Away:
				return new Color("#a6862e");
			case Steam.PersonaState.Snooze:
				return new Color("#77b3e0");
			case Steam.PersonaState.Online:
			case Steam.PersonaState.LookingToTrade:
			case Steam.PersonaState.LookingToPlay:
				return new Color("#59d952");
			case Steam.PersonaState.Offline:
			case Steam.PersonaState.Invisible:
			default:
				return new Color("#444");
		}
	}
}
