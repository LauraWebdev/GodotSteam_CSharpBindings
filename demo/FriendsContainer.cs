using Godot;
using System;
using System.Collections.Generic;
using GodotSteam;

public partial class FriendsContainer : GridContainer
{
	[Export] public PackedScene FriendItem;

	public override void _Ready()
	{
		if (!Steam.IsSteamRunning()) return;
		
		var friendsList = Steam.GetUserSteamFriends();

		ClearList();
		
		foreach (var friend in friendsList)
		{
			AddFriend(friend);
		}
	}

	private void ClearList()
	{
		foreach (var child in GetChildren())
		{
			child.QueueFree();
		}
	}

	private void AddFriend(Friend friend)
	{
		var friendLevel = Steam.GetFriendSteamLevel(friend.Id);
		
		var newFriendItem = FriendItem.Instantiate<FriendItem>();
		newFriendItem.SetFriendAndLevel(friend, friendLevel);
			
		AddChild(newFriendItem);
	}
}
