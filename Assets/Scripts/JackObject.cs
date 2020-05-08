using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JackObject{

    public static string currentTool = "hand";
    public static int stam = 100, gold = 500, water = 1, hoe = 1, sickle = 1, hammer = 1, axe = 1, ore = 0, lumber = 0, seeds = 0, fodder = 0, waterCap = 0;
    //public bool[] isFull = new bool[6];//dont need?
    public static List<Produce> slots = new List<Produce>();
}
