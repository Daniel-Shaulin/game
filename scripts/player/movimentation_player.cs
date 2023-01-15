using Godot;
using System;

public class movimentation_player : KinematicBody2D
{
    private Vector2 velocity;
    public override void _PhysicsProcess(float delta)
    {
        Vector2 moviment = Vector2.Zero;
        if(!PlayerStatus.isCool){
            moviment.x = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
            moviment.y = Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up");
        }
        if(moviment != Vector2.Zero){
            velocity = velocity.MoveToward(moviment * PlayerStatus.max_speed, PlayerStatus.acceleration);
        }else{
            velocity = velocity.MoveToward(Vector2.Zero, PlayerStatus.friction);
        }
        MoveAndSlide(velocity);
        base._PhysicsProcess(delta);
    }
}
