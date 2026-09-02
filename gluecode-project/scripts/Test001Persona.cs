using Godot;
using System;
using GDExtension.Wrappers;

public partial class Test001Persona : Node
{
    [Export] private Label ResultLabel { get; set; }
    private Steam _instance { get; set; }

    public override void _Ready()
    {
        // Instantiate the GodotSteam wrapper
        _instance = Steam.GetSingleton();

        // Fetch Persona
        if (_instance != null)
        {
            var name = _instance.GetPersonaName();
            var state = _instance.GetPersonaState();
            ResultLabel.Text = $"Persona: {name} ({state})";
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
