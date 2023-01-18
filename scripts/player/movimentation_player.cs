using Godot;
using System;
public class movimentation_player : KinematicBody2D
{
    private Vector2 velocity;

    Polygon2D statusLayer;

    private Boolean isStatusShow = false;

    Area2D colisionArea;

    public override void _Ready(){
        statusLayer = this.GetNode<Polygon2D>("status");
        colisionArea = this.GetNode<Area2D>("box_area");
        statusLayer.Hide(); 
        base._Ready();
    }

    public override void _Process(float delta) {
        StatusLayer statusObject = new StatusLayer();
         if(Input.IsActionJustPressed("ui_status_bar")){
            if(!PlayerStatus.isCool && !isStatusShow){
                statusObject.callStatusLayer(statusLayer);
                PlayerStatus.isCool = true;
                statusLayer.Show();
            }else{
                PlayerStatus.isCool = false;
                statusLayer.Hide();
            }
        }

        if(!PlayerStatus.isDominating){
            GD.Print((uint) AreaConfig.area_enum.enemies);
        }
        base._Process(delta);
    }
    public override void _PhysicsProcess(float delta){
        
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
