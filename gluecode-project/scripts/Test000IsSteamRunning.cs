using Godot;
using System;
using GDExtension.Wrappers;

public partial class Test000IsSteamRunning : Node
{
    [Export] private Label ResultLabel { get; set; }
    private Steam _instance { get; set; }

    public override void _Ready()
    {
        // Instantiate the GodotSteam wrapper
        _instance = Steam.GetSingleton();

        // Fetch IsSteamRunning
        if (_instance != null)
        {
            bool isRunning = _instance.IsSteamRunning();
            ResultLabel.Text = $"IsSteamRunning: {isRunning}";
        }
        else
        {
            ResultLabel.Text = "Steam not initialized";
        }
    }
    
    public override void _Process(double delta)
    {
        _instance.RunCallbacks();
    }
}
