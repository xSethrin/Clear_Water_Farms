using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private string toScene=null;
    private SceneController sceneController;
    void Start()
    {
        sceneController = GameObject.FindGameObjectWithTag("GameController").GetComponent<SceneController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {   
            sceneController.LoadScene(toScene);//loading new scene

            //setting local game object data to static farm data
            GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
            GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the cows
            GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the chickens
            Debug.Log("Number of Chickens in scene: " + chickens.Length);
            Debug.Log("Number of Cows in scene: " + cows.Length);
            Debug.Log("Number of Plants in scene: " + plants.Length);

            if(plants.Length > 0){
                Debug.Log("updating local data for plants...");
                int i = 0;//restes i for plants
                foreach(GameObject plant in plants){
                    PlantBehavior plantData = plant.GetComponent<PlantBehavior>();
                    plantData.currentStage = FarmData.currentStage[i];//sets current stage for plant
                    plantData.timesWatered = FarmData.timesWatered[i];//sets times watered for plant
                    plantData.isWatered = FarmData.isWatered[i];
                    plantData.isTilled = FarmData.isTilled[i];
                    plantData.hasPlant = FarmData.hasPlant[i];
                    i++;
                }
            }
            if(cows.Length > 0){
                Debug.Log("updating local data for cows...");
                int i= 0;
                foreach(GameObject cow in cows){
                    CowBehavior cowData = cow.GetComponent<CowBehavior>();
                    cowData.hasCow = FarmData.hasCow[i]; 
                    cowData.wasFed = FarmData.cowWasFed[i];
                    cowData.hasMilk = FarmData.hasMilk[i];
                    i++;
                }
            }
            if(chickens.Length > 0){
                Debug.Log("updating local data for chickens...");
                int i = 0;
                foreach(GameObject chicken in chickens){
                    ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();
                    chickenData.hasChicken = FarmData.hasChicken[i]; 
                    chickenData.wasFed = FarmData.chickenWasFed[i];
                    chickenData.hasEgg = FarmData.hasEgg[i];
                    i++;
                }
            }

            //sceneController.LoadScene(toScene);//loading new scene
        }
        
    }
}

//if current scene is far,
//grab all the plants
//update plantdata
