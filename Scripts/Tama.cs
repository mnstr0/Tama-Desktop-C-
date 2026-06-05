using Godot;
using System;

/// <summary>
/// Enum for tracking the different mindsets the Tama entity can be in.
/// </summary>

public enum MindsetState
{
	Wander,
	Exclaim,
	Sleep
}

public partial class Tama : Area2D
{

    private Sprite2D Sprite2D;
    private Timer BehaviorTimer;
    private MindsetState currentMindset = MindsetState.Wander;

	public override void _Ready()
	{
		// Initialize the entity in the Wander state
		SetMindset(MindsetState.Wander);
		GD.Print($"Tama entered {currentMindset} state");
	}

	public override void _Process(double delta)
	{
		// State-specific logic will be handled here based on the current mindset
		switch (currentMindset)
		{
			case MindsetState.Wander:
				// Wander behavior goes here
				break;
			case MindsetState.Exclaim:
				// Exclaim behavior goes here
				break;
			case MindsetState.Sleep:
				// Sleep behavior goes here
				break;
		}
	}

	/// <summary>
	/// Sets the entity's mindset to a new state.
	/// </summary>
	public void SetMindset(MindsetState newState)
	{
		if (currentMindset != newState)
		{
			currentMindset = newState;
			GD.Print($"Tama entered {currentMindset} state");
		}
	}

	/// <summary>
	/// Returns the entity's current mindset state.
	/// </summary>
	public MindsetState GetCurrentMindset()
	{
		return currentMindset;
	}
}
