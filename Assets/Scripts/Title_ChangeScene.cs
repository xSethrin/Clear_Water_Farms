using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* This is the script for when the player clicks on the new game text on title screen
* It fills the cow, plant, and chicken data in the FarmData object.
*/
public class Title_ChangeScene : MonoBehaviour
{
    [SerializeField] private string toScene = null;
   
    private SceneController sceneController;

    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    void OnMouseDown(){
        
        for(int i = 0; i < 255; i++){
            FarmData.timesWatered[i] = 0;
            FarmData.currentStage[i] = 0;
            FarmData.isWatered[i] = false;
            FarmData.isTilled[i] = false;
            FarmData.hasPlant[i] = false;
        }
        for(int i = 0; i< 10; i++){
            FarmData.hasChicken[i] = false;
            FarmData.chickenWasFed[i] = false;
            FarmData.hasEgg[i] = false;
            FarmData.hasCow[i] = false;
            FarmData.cowWasFed[i] = false;
            FarmData.hasMilk[i] = false;
        }
            sceneController.LoadScene(toScene);//loading new scene
    }
}

