using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm_Barn_Interrior : SceneController
{

    public Transform player;

    // Use this for initialization
    public override void Start()
    {
        base.Start();

        if (prevScene == "Farm")
        {
            player.position = new Vector2(0f, 1.15f);

        }
        GameObject [] cows = GameObject.FindGameObjectsWithTag("Cow");//finds all the plants
        int i = 0;
        foreach(GameObject cow in cows){
            CowBehavior data = cow.GetComponent<CowBehavior>();
            data.hasCow = FarmData.hasCow[i];
            data.wasFed = FarmData.cowWasFed[i];
            data.hasMilk = FarmData.hasMilk[i];
            data.UpdateSprite();
            i++;            
        }
    }
}

