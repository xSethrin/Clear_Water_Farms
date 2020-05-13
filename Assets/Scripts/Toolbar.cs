using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar : MonoBehaviour {
    private int toolBarInt = 0;
    private string[] toolBarStrings = { "1- hand", "2- watering can", "3- hoe", "4- sickle", "5- hammer", "6- axe", "7- fodder", "8- seeds" };
    //private Sprite[] toolImages;

    void Update() {
        if (JackObject.currentTool == "hand") {
            toolBarStrings[1] =  "2- watering can";
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 0;
        }
        else if (JackObject.currentTool == "water") {
            toolBarStrings[1] = "water: " + JackObject.waterAmount;
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 1;
        }
        else if (JackObject.currentTool == "hoe") {
            toolBarStrings[1] ="2- watering can";
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 2;
        }
        else if (JackObject.currentTool == "sickle") {
            toolBarStrings[1] =  "2- watering can";
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 3;
        }
        else if (JackObject.currentTool == "hammer") {
            toolBarStrings[1] =  "2- watering can";
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 4;
        }
        else if (JackObject.currentTool == "axe") {
            toolBarStrings[1] =  "2- watering can";
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 5;
        }
        else if (JackObject.currentTool == "fodder") {
            toolBarStrings[1] =  "2- watering can";
            toolBarStrings[6] = "fodder: " + JackObject.fodder;
            toolBarStrings[7] = "8- seeds";
            toolBarInt = 6;
        }
        else if (JackObject.currentTool == "seeds") {
            toolBarStrings[1] =  "2- watering can";
            toolBarStrings[6] = "7- fodder";
            toolBarStrings[7] = "seeds: " + JackObject.seeds;
            toolBarInt = 7;
        }
    }

    void OnGUI() {
        toolBarInt = GUI.Toolbar(new Rect(0, 1, 820, 30), toolBarInt, toolBarStrings);
        //GUI.Label(new Rect(0, 2, 50, 50), toolBarStrings[toolBarInt]);
    }
}