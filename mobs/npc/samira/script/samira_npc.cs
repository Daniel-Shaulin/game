using Godot;
using System;
public class samira_npc : StaticBody2D
{   

    private Boolean areaEntered = false;
    private DialogConfig dialog = new DialogConfig();

    public void OnArea2DAreaEntered(Area2D area){
        areaEntered = true;
    }
    public void OnArea2DAreaExited(Area2D area){
        areaEntered = false;
    }
 public override void _Process(float delta){
    if(areaEntered){
        if(Input.IsActionJustPressed("ui_accept") && !PlayerStatus.isCool){
            dialog.callDialog("Samira - salao principal", this);
        }
    }
 }
}
