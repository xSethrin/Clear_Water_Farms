using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm_Coop_Interrior : SceneController{

    public Transform player;

    // Use this for initialization
    public override void Start(){
        base.Start();

        if (prevScene == "Farm"){
            player.position = new Vector2(0f, 4.143f);
        }
        GameObject [] chickens = GameObject.FindGameObjectsWithTag("Chicken");//finds all the plants
        int i = 0;
        foreach(GameObject chicken in chickens){
            ChickenBehavior data = chicken.GetComponent<ChickenBehavior>();
            data.hasChicken = FarmData.hasChicken[i];
            data.wasFed = FarmData.chickenWasFed[i];
            data.hasEgg = FarmData.hasEgg[i];
            data.UpdateSprite();
            i++; 
        }
    }
}
