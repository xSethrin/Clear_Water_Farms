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
            //setting local game object data to static farm data
            GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
            GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the cows
            GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the chickens
            if(plants.Length > 0){
                Debug.Log("saving local data for plants...");
                int i = 0;//restes i for plants
                foreach(GameObject plant in plants){
                    PlantBehavior plantData = plant.GetComponent<PlantBehavior>();
                    plantData.currentStage = FarmData.currentStage[i];//sets current stage for plant
                    plantData.timesWatered = FarmData.timesWatered[i];//sets times watered for plant
                    plantData.isWatered = FarmData.isWatered[i];
                    plantData.isTilled = FarmData.isTilled[i];
                    plantData.hasPlant = FarmData.hasPlant[i];
                }
            }
            if(cows.Length > 0){
                Debug.Log("saving local data for plants...");
                FarmData.cowData = cows;
            }
            if(chickens.Length > 0){
                Debug.Log("saving local data for plants...");
                FarmData.chickenData = chickens;
            }

            sceneController.LoadScene(toScene);//loading new scene
        }
        
    }
}

//if current scene is far,
//grab all the plants
//update plantdata
