using Godot;
using System;

public class GameManager : Node
{
    public static int difficulty = -1;
    public static int[] combinationGenerated = {1, 1, 1, 1};
    public static int maxValuesAccepted = 4;
    public static int hitMax = 50;
    public static int hitLeft = 50;

    public static int xpNovice = 20;
    public static int xpPro = 30;
    public static int xpKiller = 45;
    public static int currentXp;
}
