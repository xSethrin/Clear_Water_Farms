using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    [SerializeField] private string toScene=null;
    private SceneController sceneController;
    /**
    *
    * Runs once on start
    */
    void Start(){
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }

    /*
    * This method handles the scene changes
    *
    */
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.CompareTag("Player")){
            GameObject[] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
            GameObject[] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the cows
            GameObject[] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the chickens
            if (plants.Length > 0){
                int i = 0;
                //this loops through the local plants and updates them from static data
                foreach (GameObject plant in plants){
                    PlantBehavior plantData = plant.GetComponent<PlantBehavior>();
                    FarmData.currentStage[i] = plantData.currentStage;//sets current stage for plant
                    FarmData.timesWatered[i] = plantData.timesWatered;//sets times watered for plant
                    FarmData.isWatered[i] = plantData.isWatered;
                    FarmData.isTilled[i] = plantData.isTilled;
                    FarmData.hasPlant[i] = plantData.hasPlant;
                    i++;
                }
            }
            if (cows.Length > 0){
                int i = 0;
                //this loops through all the cows and updates them from static data
                foreach (GameObject cow in cows){
                    CowBehavior cowData = cow.GetComponent<CowBehavior>();
                    FarmData.hasCow[i] = cowData.hasCow;
                    FarmData.cowWasFed[i] = cowData.wasFed;
                    FarmData.hasMilk[i] = cowData.hasMilk;
                    i++;
                }
            }
            if (chickens.Length > 0){
                int i = 0;
                //this loops through all the local plantsand updates them from plant data
                foreach (GameObject chicken in chickens){
                    ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();
                    FarmData.hasChicken[i] = chickenData.hasChicken;
                    FarmData.chickenWasFed[i] = chickenData.wasFed;
                    FarmData.hasEgg[i] = chickenData.hasEgg;
                    i++;
                }
            }
            sceneController.LoadScene(toScene);//loading new scene 
        }
    }
}
