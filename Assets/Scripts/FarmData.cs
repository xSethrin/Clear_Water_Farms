using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FarmData{

    public static int [] timesWatered = new int [255];
    public static int [] currentStage = new int [255];
    public static bool [] isWatered = new bool [255];
    public static bool [] isTilled = new bool [255];
    public static bool [] hasPlant = new bool[255];
    public static bool [] hasCow = new bool [10];
    public static bool [] cowWasFed = new bool [10];
    public static bool [] hasMilk = new bool [10];
    public static bool [] hasChicken = new bool [10];
    public static bool [] chickenWasFed = new bool [10];
    public static bool [] hasEgg = new bool [10];

    //need to delete these
    public static GameObject [] plantData;
    public static GameObject [] cowData;
    public static GameObject [] chickenData;
  
}
