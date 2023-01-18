using Godot;
using System;
public class samira_npc : StaticBody2D
{   

    private Boolean areaEntered = false;
    private DialogConfig dialog = new DialogConfig();
    private Label npc_info;

    public void OnArea2DAreaEntered(Area2D area){
        PlayerStatus.current_base_life += 20; 
        npc_info.Show();
        areaEntered = true;
    }
    public void OnArea2DAreaExited(Area2D area){
        npc_info.Hide();
        areaEntered = false;
    }
    public override void _Ready(){
        npc_info = this.GetNode<Label>("info");
    }
 public override void _Process(float delta){
    if(areaEntered){
        if(Input.IsActionJustPressed("ui_accept") && !PlayerStatus.isCool){
            dialog.callDialog("Samira - salao principal", this);
        }
    }
 }
}
