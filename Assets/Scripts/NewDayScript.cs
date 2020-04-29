using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDayScript : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }
    void OnMouseDown(){
        JackObject.stam = 100;
        Debug.Log("Reset Jack's Stamina");
        GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");
        GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");
        foreach(GameObject plant in plants){
            fieldBehavior plantData = plant.GetComponent<fieldBehavior>();
            if(plantData.timesWatered == 3){
                plantData.currentStage++;
                plantData.UpdateSprite(plantData.currentStage);
                plantData.timesWatered = 0;
            }
            else{
                plantData.UpdateSprite(plantData.currentStage);
            }
            plantData.isWatered = false;
        }
        foreach(GameObject cow in cows){
            cowBehavior cowData = cow.GetComponent<cowBehavior>();
            if(cowData.wasFed){
                cowData.hasMilk = true;
            }
            else{
                cowData.hasMilk = false;
            }
            cowData.wasFed = false;
            cowData.UpdateSprite();
        }
        foreach(GameObject chicken in chickens){
            chickenBehavior chickenData = chicken.GetComponent<chickenBehavior>();
            if(chickenData.wasFed){
                chickenData.hasEgg = true;
            }
            else{
                chickenData.hasEgg = false;
            }
           chickenData.wasFed = false;
           chickenData.UpdateSprite();
        }

    }
}
