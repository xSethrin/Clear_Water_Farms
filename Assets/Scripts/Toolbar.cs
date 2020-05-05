using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar : MonoBehaviour {
    private int toolBarInt = 0;
    private string[] toolBarStrings = { "hand", "water", "hoe", "sickle", "hammer", "axe" };
    //private Sprite[] toolImages;

    void Update() {
        if (JackObject.currentTool == "hand") {
            toolBarInt = 0;
        }
        else if (JackObject.currentTool == "water") {
            toolBarInt = 1;
        }
        else if (JackObject.currentTool == "hoe") {
            toolBarInt = 2;
        }
        else if (JackObject.currentTool == "sickle") {
            toolBarInt = 3;
        }
        else if (JackObject.currentTool == "hammer") {
            toolBarInt = 4;
        }
        else if (JackObject.currentTool == "axe") {
            toolBarInt = 5;
        }
    }

    void OnGUI() {
        toolBarInt = GUI.Toolbar(new Rect(0, 1, 400, 30), toolBarInt, toolBarStrings);
        //GUI.Label(new Rect(0, 2, 50, 50), toolBarStrings[toolBarInt]);
    }
}