using Godot;
using System;

public class PlayerStatus : Node
{
    public static long max_speed = 200;
    public static long acceleration = 800;
    public static float friction = 800;
    public static long life = 100;
    public static long level = 1;
    public static long stamina = 100;
    public static Boolean isCool = false;
    public static long max_base_life = 100;
    public static String[] habilities = {"Volvo", "BMW", "Ford", "Mazda"};
    public static long current_base_life = 10;
    public static Boolean isDominating = false;
    public static long base_experience = 0;
    public static long base_level = 0;

    public override void _Ready()
    {
        
    }
}
