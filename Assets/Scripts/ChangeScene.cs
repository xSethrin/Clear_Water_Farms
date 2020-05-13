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
            Debug.Log("In change scene!!!!");
            //setting local game object data to static farm data
            //This code does not seem to occur when leaving the coop
            GameObject[] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
            GameObject[] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the cows
            GameObject[] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the chickens
            Debug.Log("Number of Chickens in scene: " + chickens.Length);
            Debug.Log("Number of Cows in scene: " + cows.Length);
            Debug.Log("Number of Plants in scene: " + plants.Length);

            if (plants.Length > 0)
            {
                Debug.Log("updating local data for plants...");
                int i = 0;//restes i for plants
                foreach (GameObject plant in plants)
                {
                    PlantBehavior plantData = plant.GetComponent<PlantBehavior>();
                    FarmData.currentStage[i] = plantData.currentStage;//sets current stage for plant
                    FarmData.timesWatered[i] = plantData.timesWatered;//sets times watered for plant
                    FarmData.isWatered[i] = plantData.isWatered;
                    FarmData.isTilled[i] = plantData.isTilled;
                    FarmData.hasPlant[i] = plantData.hasPlant;
                    i++;
                }
            }
            if (cows.Length > 0)
            {
                Debug.Log("updating local data for cows...");
                int i = 0;
                foreach (GameObject cow in cows)
                {
                    CowBehavior cowData = cow.GetComponent<CowBehavior>();
                    FarmData.hasCow[i] = cowData.hasCow;
                    FarmData.cowWasFed[i] = cowData.wasFed;
                    FarmData.hasMilk[i] = cowData.hasMilk;
                    i++;
                }
            }
            if (chickens.Length > 0)
            {
                Debug.Log("updating local data for chickens...");
                int i = 0;
                foreach (GameObject chicken in chickens)
                {
                    ChickenBehavior chickenData = chicken.GetComponent<ChickenBehavior>();
                    FarmData.hasChicken[i] = chickenData.hasChicken;
                    FarmData.chickenWasFed[i] = chickenData.wasFed;
                    FarmData.hasEgg[i] = chickenData.hasEgg;
                    i++;
                }
            }
        }

            sceneController.LoadScene(toScene);//loading new scene
        }
        
    }


//if current scene is far,
//grab all the plants
//update plantdata
