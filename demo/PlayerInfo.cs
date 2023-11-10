using Godot;
using GodotSteam;

public partial class PlayerInfo : PanelContainer
{
	[Export] public Panel PlayerAvatar;
	
	[Export] public Label PlayerName;
	[Export] public Label PlayerLevel;

	public override void _EnterTree()
	{
		Modulate = Colors.Transparent;

		Steam.AvatarLoaded += LoadPlayerAvatar;
	}

	public override void _ExitTree()
	{
		Steam.AvatarLoaded -= LoadPlayerAvatar;
	}

	public override void _Ready()
	{
		if (!Steam.IsSteamRunning()) return;
		
		var steamId = Steam.GetSteamID();
		var name = Steam.GetFriendPersonaName(steamId);
		var level = Steam.GetPlayerSteamLevel();
		
		Modulate = Colors.White;
		
		PlayerName.Text = name;
		PlayerLevel.Text = "Level " + level;
		
		Steam.GetPlayerAvatar();
	}

	private void LoadPlayerAvatar(long avatarId, int size, byte[] data)
	{
		var avatarImage = Image.CreateFromData(size, size, false, Image.Format.Rgba8, data);
		
		var stylebox = new StyleBoxTexture();
		stylebox.Texture = ImageTexture.CreateFromImage(avatarImage);
		
		PlayerAvatar.AddThemeStyleboxOverride("panel", stylebox);
	}
}
