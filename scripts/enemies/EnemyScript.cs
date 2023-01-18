using Godot;
using System;

public class EnemyScript : KinematicBody2D
{
    Vector2 moviment = Vector2.Zero;
    public override void _Ready()
    {
        base._Ready();
    }

    public override void _Process(float delta){
    }

    
    public void onAreaEntered(PhysicsBody2D body){
        PlayerStatus.current_base_life -= 50;
        GD.Print(body.GetPosition());
    }

    public void onBodySapeEntered(PhysicsBody2D body){
        GD.Print(body.GetPosition());
    }
    public override void _PhysicsProcess(float delta){
        
        
        Vector2 velocity = Vector2.Zero;

        if(moviment != Vector2.Zero){
            velocity = velocity.MoveToward(moviment * (PlayerStatus.max_speed - 20), PlayerStatus.acceleration - 40);
        }else{
            velocity = velocity.MoveToward(Vector2.Zero, PlayerStatus.friction);
        }
        MoveAndSlide(velocity);
        base._PhysicsProcess(delta);
    }
}
