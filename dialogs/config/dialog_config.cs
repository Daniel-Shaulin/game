using Godot;
using System;
public class DialogConfig : Node
{

    public void callDialog(String name, Godot.Node node){
        Godot.Node dialogo = DialogicSharp.Start(name);
        Input.SetMouseMode(Input.MouseModeEnum.Visible);
        PlayerStatus.isCool = true;
        dialogo.Connect("timeline_end", this, "endDialog");
        node.AddChild(dialogo);
    }

    public void endDialog(String data){
        PlayerStatus.isCool = false;
        Input.SetMouseMode(Input.MouseModeEnum.Hidden);
    } 
}
