using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Farm_House_Interrior")
        {
            player.position = new Vector2(26.44f, -46f);

        }
        else if (prevScene == "Cross_Roads")
        {
            player.position = new Vector2(-10.84f, -36.28f);

        }
        else if (prevScene == "Farm_Barn_Interrior")
        {
            player.position = new Vector2(-20.53f, -10.24f);

        }
        else if (prevScene == "Farm_Coop_Interrior")
        {
            player.position = new Vector2(7.56f, -1.31f);

        }
        GameObject [] plants = GameObject.FindGameObjectsWithTag("Plant");//finds all the plants
        int i = 0;
        foreach(GameObject plant in plants){
            PlantBehavior data = plant.GetComponent<PlantBehavior>();
            //loads local game objects with data from static farm data
            data.timesWatered = FarmData.timesWatered[i];
            data.currentStage = FarmData.currentStage[i];
            data.isWatered = FarmData.isWatered[i];
            data.isTilled = FarmData.isTilled[i];
            data.hasPlant = FarmData.hasPlant[i];
            data.UpdateSprite();
            i++;
        }
    }
}
