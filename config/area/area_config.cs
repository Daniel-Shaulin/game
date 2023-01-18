using Godot;
using System;

public class AreaConfig : Node
{

    public enum area_enum : uint{
        player = 1,
        enemies = 2,
        npc = 3,
        static_body = 4,
        physcal_attack = 5
    }
    public static area_enum getLayerName(uint value){
        string enumValue = Enum.GetName(typeof(area_enum), value);
        return (area_enum) Enum.Parse(typeof(area_enum), enumValue);
    }
    public override void _Ready()
    {
        
    }
}
