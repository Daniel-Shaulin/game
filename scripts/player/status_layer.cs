using Godot;
using System;

public class StatusLayer : Polygon2D
{

    Label life;
    Label experience;
    Label stamina;
    Label habilities;

    [Obsolete]
    public void callStatusLayer(Polygon2D node){
        populate(node);
        life.SetText(String.Concat("Vida: ", PlayerStatus.base_life));
        stamina.SetText(String.Concat("Estamina: ", PlayerStatus.stamina));
        experience.SetText(String.Concat("Experiência: ", PlayerStatus.base_experience));
        habilities.SetText(String.Concat("Habilidades: ", String.Join(", ", PlayerStatus.habilities)));
    }

    private void populate(Polygon2D node){
        life = node.GetNode<GridContainer>("container").GetNode<Label>("Life");
        experience = node.GetNode<GridContainer>("container").GetNode<Label>("Experience");
        stamina = node.GetNode<GridContainer>("container").GetNode<Label>("Stamina");
        habilities = node.GetNode<GridContainer>("container").GetNode<Label>("Habilityes");
    }
    public override void _Ready(){
         base._Ready();
    }
}
