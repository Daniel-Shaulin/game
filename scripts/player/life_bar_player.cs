using Godot;
using System;

public class life_bar_player : Node2D
{

    private TextureProgress heartBar;

    public override void _Process(float delta){
        heartBar.MaxValue = PlayerStatus.max_base_life;
        heartBar.Value = PlayerStatus.current_base_life;
        base._Process(delta);
    }
    public override void _Ready(){
        heartBar = this.GetNode<TextureProgress>("hearth_bar");

    }
}
