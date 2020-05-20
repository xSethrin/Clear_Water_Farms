using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class JackObject{

    public static string currentTool = "hand";
    public static int stam = 150, gold = 500, water = 0, hoe = 0, sickle = 0, hammer = 0, axe = 0, ore = 0, lumber = 0, seeds = 0, fodder = 0, waterAmount = 0, cows = 0, chickens = 0;
    //public bool[] isFull = new bool[6];//dont need?
    public static List<Produce> slots = new List<Produce>();
}
//