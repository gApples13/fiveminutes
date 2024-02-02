using Godot;
using System;

public partial class ING875 : CharacterBody2D
{
	public const float Speed = 300.0f;
	public const float Acceleration = 10.0f;
	public const float Deceleration = 10.0f;

	public override void _PhysicsProcess(double delta)
	{
		

		Velocity = velocity;
		MoveAndSlide();
	}
	float MvUpdateLateral(Vector2 dir)
	{
		Vector2 velocity = Velocity;

		Vector2 direction = Input.GetVector("game_left", "game_right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			
			velocity.X = Mathf.MoveToward(velocity.X, direction.X * Speed, Acceleration);
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Deceleration);
		}
		return vel
	}
}
