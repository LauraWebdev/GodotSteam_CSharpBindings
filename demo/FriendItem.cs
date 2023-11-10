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

	private Color GetStatusColor(PersonaState personaState)
	{
		switch (personaState)
		{
			case PersonaState.Busy:
				return new Color("#872032");
			case PersonaState.Away:
				return new Color("#a6862e");
			case PersonaState.Snooze:
				return new Color("#77b3e0");
			case PersonaState.Online:
			case PersonaState.LookingToTrade:
			case PersonaState.LookingToPlay:
				return new Color("#59d952");
			case PersonaState.Offline:
			case PersonaState.Invisible:
			default:
				return new Color("#444");
		}
	}
}
